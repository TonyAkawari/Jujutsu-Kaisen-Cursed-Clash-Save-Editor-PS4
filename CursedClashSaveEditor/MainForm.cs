using CursedClashSaveEditor.Save;

namespace CursedClashSaveEditor;

public sealed partial class MainForm : Form
{
    private readonly Color _background = Color.FromArgb(9, 15, 29);
    private readonly Color _surface = Color.FromArgb(17, 27, 46);
    private readonly Color _surfaceRaised = Color.FromArgb(23, 36, 60);
    private readonly Color _border = Color.FromArgb(42, 60, 88);
    private readonly Color _text = Color.FromArgb(235, 241, 250);
    private readonly Color _muted = Color.FromArgb(145, 163, 189);
    private readonly Color _accent = Color.FromArgb(82, 168, 255);
    private readonly Color _success = Color.FromArgb(81, 207, 145);
    private readonly Color _warning = Color.FromArgb(250, 187, 82);
    private readonly Color _danger = Color.FromArgb(255, 106, 118);

    private SaveDocument? _document;

    public MainForm()
    {
        InitializeComponent();

        SetLoadedState(false);
        SetStatus("Import a ue4savegame_ps4.sav file to begin.");
    }

    private void ImportButton_Click(object? sender, EventArgs e)
    {
        using OpenFileDialog dialog = new()
        {
            Title = "Import Cursed Clash PS4 save",
            Filter = "Cursed Clash saves (*.sav)|*.sav|All files (*.*)|*.*",
            FileName = "ue4savegame_ps4.sav",
            CheckFileExists = true,
            Multiselect = false
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            _document = SaveDocument.Load(dialog.FileName);
            RefreshValues();
            UpdateChecksumDisplay();
            SetLoadedState(true);
            SetStatus($"Imported {Path.GetFileName(dialog.FileName)}  \u00b7  {_document.Data.Length:N0} bytes  \u00b7  body {_document.BodyLength:N0} bytes. No changes have been written to disk.");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or InvalidDataException)
        {
            ShowError("Import failed", ex.Message);
        }
    }

    private void ExportButton_Click(object? sender, EventArgs e)
    {
        if (_document is null)
        {
            return;
        }

        using SaveFileDialog dialog = new()
        {
            Title = "Export edited Cursed Clash save",
            Filter = "Cursed Clash saves (*.sav)|*.sav|All files (*.*)|*.*",
            FileName = $"{Path.GetFileNameWithoutExtension(_document.SourcePath)}_edited.sav",
            AddExtension = true,
            DefaultExt = "sav",
            OverwritePrompt = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            string targetPath = Path.GetFullPath(dialog.FileName);
            string sourcePath = Path.GetFullPath(_document.SourcePath);
            string? backupPath = null;

            if (string.Equals(targetPath, sourcePath, StringComparison.OrdinalIgnoreCase))
            {
                DialogResult confirm = MessageBox.Show(
                    this,
                    "This will replace the imported file. A backup will be created next to it first. Continue?",
                    "Confirm overwrite",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                backupPath = CreateBackupPath(sourcePath);
                File.Copy(sourcePath, backupPath);
            }

            // Get the export bytes, then FORCE a checksum fix on this exact
            // byte array right before writing it to disk. This is deliberately
            // redundant with anything SaveDocument.GetExportBytes() already
            // does internally: if that method ever fails to recompute the MD5
            // (e.g. a future edit path that bypasses it), the exported file
            // would still get flagged as corrupted on the PS4 without this
            // safety net. Calling FixChecksum twice is harmless/idempotent.
            byte[] exportData = _document.GetExportBytes();
            SaveChecksum.FixChecksum(exportData);

            File.WriteAllBytes(targetPath, exportData);

            bool valid = SaveChecksum.VerifyChecksum(exportData);
            _checksumBadge.Text = valid ? "VALID" : "INVALID";
            _checksumBadge.BackColor = valid ? Color.FromArgb(24, 77, 62) : Color.FromArgb(95, 35, 46);
            _checksumBadge.ForeColor = valid ? _success : _danger;
            _checksumDetail.Text = valid ? "Export ready for transfer" : "Export checksum failed";

            if (!valid)
            {
                // This should now be unreachable given the forced fix above,
                // but surface it loudly if it ever happens rather than
                // silently handing back a save the PS4 will reject.
                ShowError(
                    "Export checksum failed",
                    "The checksum could not be verified after writing the file. " +
                    "Please keep your backup and report this — the exported save may be rejected by the PS4.");
            }

            _dirtyLabel.Text = backupPath is null
                ? $"Exported \u00b7 {Path.GetFileName(targetPath)}"
                : $"Exported \u00b7 backup: {Path.GetFileName(backupPath)}";
            SetStatus(backupPath is null
                ? $"Exported a checksum-valid save to {Path.GetFileName(targetPath)}."
                : $"Exported safely. Original backup created at {Path.GetFileName(backupPath)}.");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            ShowError("Export failed", ex.Message);
        }
    }

    private void VerifyButton_Click(object? sender, EventArgs e)
    {
        if (_document is null)
        {
            return;
        }

        UpdateChecksumDisplay();
        bool valid = SaveChecksum.VerifyChecksum(_document.Data);
        SetStatus(valid
            ? "The in-memory save has a valid MD5 checksum."
            : "The in-memory save checksum is invalid; exporting will recalculate it.");
    }

    private void EditBindingVowsButton_Click(object? sender, EventArgs e) =>
        Apply("Binding Vows", () => _document!.WriteInt32(SaveLayout.BindingVowsCoOpWonOffset, 99));

    private void EditRankSButton_Click(object? sender, EventArgs e) =>
        Apply("Rank S wins", () => _document!.WriteInt32(SaveLayout.RankSCoOpWonOffset, 99));

    private void EditCoOpCompletionsButton_Click(object? sender, EventArgs e) =>
        Apply("Co-op completions", () => _document!.WriteInt32s(
            (SaveLayout.CoOpCompletionsOffset, 99),
            (SaveLayout.CoOpCompletionsSecondaryOffset, 99)));

    private void EditJujuPointsButton_Click(object? sender, EventArgs e) =>
        Apply("Juju Points", () => _document!.WriteInt32(SaveLayout.JujuPointsOffset, 99_999_999));

    private void EditCoOpExpButton_Click(object? sender, EventArgs e) =>
        Apply("Co-op EXP Pool", () => _document!.WriteInt32(SaveLayout.CoOpExpPoolOffset, 96_421_969));

    private void ApplyTaskButton_Click(object? sender, EventArgs e)
    {
        int value = _taskPresetCombo.SelectedIndex == 1 ? 299 : 99;
        Apply($"Tasks completed: {value}", () => _document!.WriteInt32(SaveLayout.TasksCompletedOffset, value));
    }

    private void ApplySkillButton_Click(object? sender, EventArgs e)
    {
        int[] values = { 3_000, 4_999, 10_000, 14_999, 40_000 };
        int value = values[Math.Max(0, _skillPresetCombo.SelectedIndex)];
        Apply($"Skill level: {value:N0}", () => _document!.WriteInt32s(
            (SaveLayout.SkillLevelOffset, value),
            (SaveLayout.SkillLevelSecondaryOffset, value)));
    }

    private void ResetButton_Click(object? sender, EventArgs e)
    {
        if (_document is null)
        {
            return;
        }

        _document.Reset();
        RefreshValues();
        UpdateChecksumDisplay();
        SetStatus("Edits reset to the imported file.");
    }

    private void Apply(string label, Action edit)
    {
        if (_document is null)
        {
            return;
        }

        try
        {
            edit();
            RefreshValues();
            UpdateChecksumDisplay();
            SetStatus($"{label} applied in memory. Export to write the edited save.");
        }
        catch (Exception ex) when (ex is InvalidDataException or ArgumentOutOfRangeException)
        {
            ShowError("Edit failed", ex.Message);
        }
    }

    private void RefreshValues()
    {
        if (_document is null)
        {
            return;
        }

        lblStatValueTasks.Text = _document.ReadInt32(SaveLayout.TasksCompletedOffset).ToString("N0");
        lblStatValueBinding.Text = _document.ReadInt32(SaveLayout.BindingVowsCoOpWonOffset).ToString("N0");
        lblStatValueRank.Text = _document.ReadInt32(SaveLayout.RankSCoOpWonOffset).ToString("N0");
        lblStatValueCoop.Text = _document.ReadInt32(SaveLayout.CoOpCompletionsOffset).ToString("N0");
        lblStatValueJuju.Text = _document.ReadInt32(SaveLayout.JujuPointsOffset).ToString("N0");
        lblStatValueSkill.Text = _document.ReadInt32(SaveLayout.SkillLevelOffset).ToString("N0");
        lblStatValueCoOpExp.Text = _document.ReadInt32(SaveLayout.CoOpExpPoolOffset).ToString("N0");
        _dirtyLabel.Text = _document.IsDirty ? "Unsaved edits in memory" : "No edits yet";
    }

    private void UpdateChecksumDisplay()
    {
        if (_document is null)
        {
            _checksumBadge.Text = "WAITING";
            _checksumBadge.BackColor = _surfaceRaised;
            _checksumBadge.ForeColor = _muted;
            _checksumDetail.Text = "Checksum status";
            return;
        }

        bool valid = SaveChecksum.VerifyChecksum(_document.Data);
        _checksumBadge.Text = valid ? "VALID" : "INVALID";
        _checksumBadge.BackColor = valid ? Color.FromArgb(24, 77, 62) : Color.FromArgb(95, 35, 46);
        _checksumBadge.ForeColor = valid ? _success : _danger;
        _checksumDetail.Text = valid
            ? "Checksum matches the save body"
            : "Imported checksum does not match";
    }

    private void SetLoadedState(bool loaded)
    {
        _exportButton.Enabled = loaded;
        _verifyButton.Enabled = loaded;
        _resetButton.Enabled = loaded;
        _applyTaskButton.Enabled = loaded;
        _applySkillButton.Enabled = loaded;
        btnBindingVows.Enabled = loaded;
        btnRankS.Enabled = loaded;
        btnCoOp.Enabled = loaded;
        btnJujuPoints.Enabled = loaded;
        btnCoOpExp.Enabled = loaded;
        _taskPresetCombo.Enabled = loaded;
        _skillPresetCombo.Enabled = loaded;
    }

    private void SetStatus(string message) => _statusLabel.Text = message;

    private void ShowError(string title, string message) =>
        MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

    private static string CreateBackupPath(string sourcePath)
    {
        string directory = Path.GetDirectoryName(sourcePath) ?? Environment.CurrentDirectory;
        string name = Path.GetFileNameWithoutExtension(sourcePath);
        string extension = Path.GetExtension(sourcePath);
        string candidate = Path.Combine(directory, $"{name}.backup{extension}");
        if (!File.Exists(candidate))
        {
            return candidate;
        }

        return Path.Combine(
            directory,
            $"{name}.backup-{DateTime.Now:yyyyMMdd-HHmmss}{extension}");
    }

    private void lblSectionEditorHeading_Click(object sender, EventArgs e)
    {

    }

    private void lblTitle_Click(object sender, EventArgs e)
    {

    }

    private void lblActionTitle1_Click(object sender, EventArgs e)
    {

    }

    private void pnlActionRow1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblCoOpDetail_Click(object sender, EventArgs e)
    {

    }

    private void pnlCoOpRow_Paint(object sender, PaintEventArgs e)
    {

    }

    private void pnlEditorLayout_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblActionDetail4_Click(object sender, EventArgs e)
    {

    }

    private void lblStatNameSkill_Click(object sender, EventArgs e)
    {

    }

    private void lblActionTitle2_Click(object sender, EventArgs e)
    {

    }

    private void lblFileCardTitle_Click(object sender, EventArgs e)
    {

    }

    private void pnlTitleStack_Paint(object sender, PaintEventArgs e)
    {

    }
}
