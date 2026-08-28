using System.Security.Cryptography;

namespace CursedClashSaveEditor.Save;

public static class SaveChecksum
{
    public static void FixChecksum(byte[] saveData)
    {
        EnsureSupported(saveData);

        int bodyLength = SaveLayout.GetBodyLength(saveData);
        using MD5 md5 = MD5.Create();
        byte[] hash = md5.ComputeHash(saveData, 0, bodyLength);
        hash.AsSpan(0, SaveLayout.HashLength)
            .CopyTo(saveData.AsSpan(bodyLength, SaveLayout.HashLength));
    }

    public static bool VerifyChecksum(byte[] saveData)
    {
        if (!SaveLayout.HasRequiredLength(saveData))
        {
            return false;
        }

        int bodyLength = SaveLayout.GetBodyLength(saveData);
        using MD5 md5 = MD5.Create();
        byte[] expected = md5.ComputeHash(saveData, 0, bodyLength);
        return CryptographicOperations.FixedTimeEquals(
            expected.AsSpan(0, SaveLayout.HashLength),
            saveData.AsSpan(bodyLength, SaveLayout.HashLength));
    }

    private static void EnsureSupported(byte[] saveData)
    {
        if (!SaveLayout.HasRequiredLength(saveData))
        {
            throw new InvalidDataException(
                $"The save is too small to contain the documented stat offsets. " +
                $"Expected at least {FooterLengthForMessage()} bytes, but found {saveData.Length}.");
        }
    }

    private static int FooterLengthForMessage() =>
        SaveLayout.FooterLength + SaveLayout.MinimumSupportedBodyLength;
}