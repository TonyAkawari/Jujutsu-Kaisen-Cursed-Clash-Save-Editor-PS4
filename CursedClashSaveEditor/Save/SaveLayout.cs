namespace CursedClashSaveEditor.Save;

public static class SaveLayout
{
    public const int FooterLength = 24;
    public const int HashLength = 16;
    public const int ExpectedFileLength = 402_236;

    public const int JujuPointsOffset = 0x0000232C;
    public const int SkillLevelOffset = 0x00002334;
    public const int SkillLevelSecondaryOffset = 0x00002338;
    public const int CoOpExpPoolOffset = 0x00047E4C;
    public const int TasksCompletedOffset = 0x00061704;
    public const int BindingVowsCoOpWonOffset = 0x0006170C;
    public const int CoOpCompletionsOffset = 0x00061718;
    public const int RankSCoOpWonOffset = 0x0006172C;
    public const int CoOpCompletionsSecondaryOffset = 0x00061730;

    public const int MinimumSupportedBodyLength = CoOpCompletionsSecondaryOffset + sizeof(int);

    public static int GetBodyLength(byte[] saveData) => saveData.Length - FooterLength;

    public static int GetChecksumOffset(byte[] saveData) => GetBodyLength(saveData);

    public static bool HasRequiredLength(byte[] saveData) =>
        saveData.Length >= FooterLength + MinimumSupportedBodyLength;
}