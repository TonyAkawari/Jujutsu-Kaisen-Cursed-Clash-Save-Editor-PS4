using System.Buffers.Binary;

namespace CursedClashSaveEditor.Save;

public sealed class SaveDocument
{
    private readonly byte[] _originalData;

    private SaveDocument(string sourcePath, byte[] data)
    {
        SourcePath = sourcePath;
        Data = data;
        _originalData = data.ToArray();
    }

    public string SourcePath { get; }
    public byte[] Data { get; private set; }
    public int BodyLength => SaveLayout.GetBodyLength(Data);
    public bool IsDirty => !Data.AsSpan().SequenceEqual(_originalData);

    public static SaveDocument Load(string path)
    {
        byte[] data = File.ReadAllBytes(path);
        if (!SaveLayout.HasRequiredLength(data))
        {
            throw new InvalidDataException(
                $"This file is only {data.Length:N0} bytes. " +
                $"A compatible save must be at least " +
                $"{SaveLayout.FooterLength + SaveLayout.MinimumSupportedBodyLength:N0} bytes.");
        }

        return new SaveDocument(path, data);
    }

    public int ReadInt32(int offset)
    {
        ValidateStatOffset(offset);
        return BinaryPrimitives.ReadInt32LittleEndian(Data.AsSpan(offset, sizeof(int)));
    }

    public void WriteInt32(int offset, int value)
    {
        ValidateStatOffset(offset);
        BinaryPrimitives.WriteInt32LittleEndian(Data.AsSpan(offset, sizeof(int)), value);
        SaveChecksum.FixChecksum(Data);
    }

    public void WriteInt32s(params (int Offset, int Value)[] writes)
    {
        foreach ((int offset, int value) in writes)
        {
            ValidateStatOffset(offset);
            BinaryPrimitives.WriteInt32LittleEndian(Data.AsSpan(offset, sizeof(int)), value);
        }

        SaveChecksum.FixChecksum(Data);
    }

    public void Reset()
    {
        Data = _originalData.ToArray();
    }

    public byte[] GetExportBytes()
    {
        byte[] exportData = Data.ToArray();
        SaveChecksum.FixChecksum(exportData);
        return exportData;
    }

    private void ValidateStatOffset(int offset)
    {
        if (offset < 0 || offset + sizeof(int) > BodyLength)
        {
            throw new ArgumentOutOfRangeException(
                nameof(offset),
                $"Offset 0x{offset:X8} is outside the save body.");
        }
    }
}