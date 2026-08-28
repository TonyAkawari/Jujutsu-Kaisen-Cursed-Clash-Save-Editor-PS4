# Fixing the Save Checksum: How It Was Found, and How to Replicate It

This document explains how the corruption-check on `ue4savegame_ps4.sav`
(Jujutsu Kaisen Cursed Clash, PS4) was reverse-engineered, why hand-edited
saves were getting deleted by the game, and how you can apply the same
method to find and fix a checksum in a different save format.

## The symptom

Editing any stat value in the save file with a hex editor (or a raw
Save Wizard-style offset/value write) caused the PS4 to report
**"save data corrupted"** and delete the file — even when the edited
value itself was perfectly valid. This is the signature of an
**integrity check**: the game hashes its own save data and compares
that hash against a value stored in the file. Change the data without
updating the stored hash, and the comparison fails.

## Step 1 — Find two saves that differ only in known ways

The key to reverse-engineering *any* binary format is having two
files where you know exactly what changed. In this case:

- **Save 1**: a save with known values (e.g. 36 Binding Vow co-op
  battles, 28 tasks completed, 7 Rank S wins, skill level 2143).
- **Save 2**: the same save after those specific stats changed
  in-game (45 / 33 / 9 / 2738) — nothing else touched.

Diffing the two files byte-for-byte showed the expected stat offsets
changing as predicted, **plus** a block of 24 bytes at the very end of
the file that changed completely, even though only a few stats were
edited:

```
Save 1 (last 24 bytes): 2f47f9d8478e34914addf1d007f14ef8eb17d14d5698d740
Save 2 (last 24 bytes): 52dc5b8812a91ba10a10113ae9810b6c754276ef1682d840
```

A block that changes *every time*, regardless of which specific bytes
were edited, and that sits at a fixed location (the very end of the
file) is the classic fingerprint of a checksum/hash footer.

## Step 2 — Identify the hash algorithm

With a suspect region isolated, the next step is brute-forcing common
hash/checksum algorithms against candidate byte ranges of the file and
checking for a match:

```python
import hashlib

data = open("save.sav", "rb").read()
footer = data[-24:]
body = data[:-24]

md5_digest = hashlib.md5(body).digest()
print(md5_digest.hex())     # 2f47f9d8478e34914addf1d007f14ef8
print(footer[:16].hex())    # 2f47f9d8478e34914addf1d007f14ef8
```

The first 16 bytes of the 24-byte footer matched `MD5(body)` exactly,
where `body` is every byte in the file **except the trailing 24 bytes**.
That's the whole trick — two lines of Python confirmed it once the
region was correctly isolated.

The remaining 8 bytes of the footer didn't match MD5, CRC32, Adler32,
SHA-1, or any obvious timestamp encoding tested. They're left alone —
whatever they are, they don't appear to be part of the integrity
check, since a file with a valid recomputed MD5 and untouched trailing
8 bytes loads without error.

## Step 3 — Confirm the fix works both ways

To be confident this was actually *the* check (and not a coincidence),
two things were verified:

1. **Forward**: recomputing MD5 over an edited save's body and writing
   it into the footer produces a file the game accepts.
2. **Backward**: deliberately corrupting the recomputed hash (or
   leaving the stale one in place after an edit) reproduces the
   "corrupted" error.

## The fix, in general form

```python
import hashlib

FOOTER_LENGTH = 24
HASH_LENGTH = 16

def fix_checksum(data: bytearray) -> None:
    body_end = len(data) - FOOTER_LENGTH
    digest = hashlib.md5(data[:body_end]).digest()
    data[body_end:body_end + HASH_LENGTH] = digest
```

Any edit to the save now follows the same two-step pattern:
1. Write the new value(s) into the body.
2. Call `fix_checksum()` before writing the file back to disk.

The C# equivalent (used in the actual Windows Forms editor) is the
same idea with `System.Security.Cryptography.MD5`:

```csharp
public static void FixChecksum(byte[] saveData)
{
    int bodyLength = saveData.Length - FooterLength; // 24
    using MD5 md5 = MD5.Create();
    byte[] hash = md5.ComputeHash(saveData, 0, bodyLength);
    hash.AsSpan(0, HashLength) // 16
        .CopyTo(saveData.AsSpan(bodyLength, HashLength));
}
```

## How to replicate this on a different game/save format

1. **Get two saves that differ in a known, narrow way.** Change one
   or two stats in-game, export both the before and after save files.
2. **Diff them byte-for-byte.** Look for:
   - The bytes that changed at the expected stat locations (confirms
     you're looking at the right file/region).
   - Any *additional* changed region that isn't explained by your
     edit — especially if it's a fixed size and located at a
     consistent position (start or end of the file are common).
3. **Guess-and-check common hash/checksum functions** against
   candidate byte ranges: MD5 (16 bytes), SHA-1 (20 bytes), SHA-256
   (32 bytes), CRC32 (4 bytes), Adler-32 (4 bytes). Try hashing the
   whole file, the whole file minus the suspect region, and other
   plausible boundaries (e.g. minus just a header, or minus a fixed
   footer size).
4. **Once you find a match, verify it both ways** — recompute after
   an edit and confirm the file loads, then deliberately break it and
   confirm you get the corruption error back. This rules out
   coincidence.
5. **Bake the fix into your edit pipeline** so every value write is
   immediately followed by a checksum recompute, rather than leaving
   it as a separate manual step.

## Caveats

- This method only works if the checksum is a **standard, known
  algorithm**. Some games use proprietary/keyed hashes (HMACs with an
  embedded secret, XOR-folded custom checksums, etc.) that won't show
  up from brute-forcing common library functions. If none of the
  common candidates match, the next step is manual bit-diffing: flip
  one bit in the body and see exactly how the footer bytes respond,
  which can reveal a custom algorithm's structure.
- A checksum matching in isolation isn't proof it's *the* check the
  game enforces — always confirm with the forward/backward test in
  Step 3 before relying on it.
- Console-level save encryption (e.g. the PS4's own save-data signing)
  is a **separate layer** from a game's internal checksum. Tools like
  Save Wizard handle that outer layer by decrypting via console keys;
  this document only covers the checksum the *game itself* adds
  inside the decrypted file.