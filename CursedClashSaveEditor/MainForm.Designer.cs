namespace CursedClashSaveEditor;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    // ----- Top level -----
    private TableLayoutPanel pnlRoot;
    private TableLayoutPanel pnlHeader;
    private TableLayoutPanel pnlTitleStack;
    private FlowLayoutPanel pnlHeaderActions;
    private TableLayoutPanel pnlContent;
    private TableLayoutPanel pnlStatusBar;
    private Label lblFooter;

    // ----- Editor card (left column) -----
    private Panel pnlEditorCard;
    private TableLayoutPanel pnlEditorLayout;
    private TableLayoutPanel pnlSectionIntroEditor;
    private Label lblSectionEditorHeading;
    private Label lblSectionEditorSubtitle;

    private TableLayoutPanel pnlIndependentActions;
    private Label lblIndependentBoostsHeading;

    private TableLayoutPanel pnlActionRow1;
    private TableLayoutPanel pnlActionText1;
    private Label lblActionTitle1;
    private Label lblActionDetail1;

    private TableLayoutPanel pnlActionRow2;
    private TableLayoutPanel pnlActionText2;
    private Label lblActionTitle2;
    private Label lblActionDetail2;

    private TableLayoutPanel pnlCoOpRow;
    private TableLayoutPanel pnlCoOpText;
    private Label lblCoOpTitle;
    private Label lblCoOpDetail;

    private TableLayoutPanel pnlActionRow4;
    private TableLayoutPanel pnlActionText4;
    private Label lblActionTitle4;
    private Label lblActionDetail4;
    private Button btnJujuPoints;

    private TableLayoutPanel pnlActionRow5;
    private TableLayoutPanel pnlActionText5;
    private Label lblActionTitle5;
    private Label lblActionDetail5;
    private Button btnCoOpExp;

    private TableLayoutPanel pnlPresetGroups;
    private Label lblPresetsHeading;

    private TableLayoutPanel pnlTaskPresetRow;
    private TableLayoutPanel pnlTaskPresetText;
    private Label lblTaskPresetTitle;
    private Label lblTaskPresetDetail;

    private TableLayoutPanel pnlSkillPresetRow;
    private TableLayoutPanel pnlSkillPresetText;
    private Label lblSkillPresetTitle;
    private Label lblSkillPresetDetail;

    // ----- Inspector card (right column) -----
    private Panel pnlInspectorCard;
    private TableLayoutPanel pnlInspectorLayout;

    private TableLayoutPanel pnlChecksumCard;
    private TableLayoutPanel pnlChecksumDetails;
    private Label lblChecksumHint;

    private Panel pnlFileCard;
    private Label lblFileCardTitle;
    private Label lblFileCardBody;

    private Panel pnlStatsCard;
    private TableLayoutPanel pnlStatsCardLayout;
    private TableLayoutPanel pnlStatsSectionIntro;
    private Label lblStatsHeading;
    private Label lblStatsSubtitle;
    private Panel pnlScrollHost;

    private TableLayoutPanel pnlResetRow;
    private Label _checksumBadge;
    private Label _checksumDetail;
    private Label _statusLabel;
    private Label _dirtyLabel;
    private TableLayoutPanel _statsTable;
    private Label lblStatNameTasks;
    private Label lblStatValueTasks;
    private Label lblStatNameBinding;
    private Label lblStatValueBinding;
    private Label lblStatNameRank;
    private Label lblStatValueRank;
    private Label lblStatNameCoop;
    private Label lblStatValueCoop;
    private Label lblStatNameJuju;
    private Label lblStatValueJuju;
    private Label lblStatNameSkill;
    private Label lblStatValueSkill;
    private Label lblStatNameCoOpExp;
    private Label lblStatValueCoOpExp;
    private ComboBox _taskPresetCombo;
    private ComboBox _skillPresetCombo;
    private Button _exportButton;
    private Button _importButton;
    private Button _verifyButton;
    private Button _resetButton;
    private Button _applyTaskButton;
    private Button _applySkillButton;
    private Button btnBindingVows;
    private Button btnRankS;
    private Button btnCoOp;

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        pnlRoot = new TableLayoutPanel();
        pnlHeader = new TableLayoutPanel();
        pnlTitleStack = new TableLayoutPanel();
        pictureBox1 = new PictureBox();
        pnlHeaderActions = new FlowLayoutPanel();
        _exportButton = new Button();
        _importButton = new Button();
        _verifyButton = new Button();
        pnlContent = new TableLayoutPanel();
        pnlEditorCard = new Panel();
        pnlEditorLayout = new TableLayoutPanel();
        pnlSectionIntroEditor = new TableLayoutPanel();
        lblSectionEditorHeading = new Label();
        lblSectionEditorSubtitle = new Label();
        pnlIndependentActions = new TableLayoutPanel();
        lblIndependentBoostsHeading = new Label();
        pnlActionRow1 = new TableLayoutPanel();
        pnlActionText1 = new TableLayoutPanel();
        lblActionTitle1 = new Label();
        lblActionDetail1 = new Label();
        btnBindingVows = new Button();
        pnlActionRow2 = new TableLayoutPanel();
        pnlActionText2 = new TableLayoutPanel();
        lblActionTitle2 = new Label();
        lblActionDetail2 = new Label();
        btnRankS = new Button();
        pnlCoOpRow = new TableLayoutPanel();
        pnlCoOpText = new TableLayoutPanel();
        lblCoOpTitle = new Label();
        lblCoOpDetail = new Label();
        btnCoOp = new Button();
        pnlActionRow4 = new TableLayoutPanel();
        pnlActionText4 = new TableLayoutPanel();
        lblActionTitle4 = new Label();
        lblActionDetail4 = new Label();
        btnJujuPoints = new Button();
        pnlActionRow5 = new TableLayoutPanel();
        pnlActionText5 = new TableLayoutPanel();
        lblActionTitle5 = new Label();
        lblActionDetail5 = new Label();
        btnCoOpExp = new Button();
        pnlPresetGroups = new TableLayoutPanel();
        lblPresetsHeading = new Label();
        pnlTaskPresetRow = new TableLayoutPanel();
        pnlTaskPresetText = new TableLayoutPanel();
        lblTaskPresetTitle = new Label();
        lblTaskPresetDetail = new Label();
        _taskPresetCombo = new ComboBox();
        _applyTaskButton = new Button();
        pnlSkillPresetRow = new TableLayoutPanel();
        pnlSkillPresetText = new TableLayoutPanel();
        lblSkillPresetTitle = new Label();
        lblSkillPresetDetail = new Label();
        _skillPresetCombo = new ComboBox();
        _applySkillButton = new Button();
        pnlInspectorCard = new Panel();
        pnlInspectorLayout = new TableLayoutPanel();
        pnlChecksumCard = new TableLayoutPanel();
        _checksumBadge = new Label();
        pnlChecksumDetails = new TableLayoutPanel();
        _checksumDetail = new Label();
        lblChecksumHint = new Label();
        pnlFileCard = new Panel();
        lblFileCardTitle = new Label();
        lblFileCardBody = new Label();
        pnlStatsCard = new Panel();
        pnlStatsCardLayout = new TableLayoutPanel();
        pnlStatsSectionIntro = new TableLayoutPanel();
        lblStatsHeading = new Label();
        lblStatsSubtitle = new Label();
        pnlScrollHost = new Panel();
        _statsTable = new TableLayoutPanel();
        lblStatNameBinding = new Label();
        lblStatValueBinding = new Label();
        lblStatNameRank = new Label();
        lblStatValueRank = new Label();
        lblStatNameCoop = new Label();
        lblStatValueCoop = new Label();
        lblStatNameJuju = new Label();
        lblStatValueJuju = new Label();
        lblStatNameTasks = new Label();
        lblStatValueTasks = new Label();
        lblStatNameSkill = new Label();
        lblStatValueSkill = new Label();
        lblStatNameCoOpExp = new Label();
        lblStatValueCoOpExp = new Label();
        pnlResetRow = new TableLayoutPanel();
        _dirtyLabel = new Label();
        _resetButton = new Button();
        pnlStatusBar = new TableLayoutPanel();
        _statusLabel = new Label();
        lblFooter = new Label();
        pnlRoot.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlTitleStack.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        pnlHeaderActions.SuspendLayout();
        pnlContent.SuspendLayout();
        pnlEditorCard.SuspendLayout();
        pnlEditorLayout.SuspendLayout();
        pnlSectionIntroEditor.SuspendLayout();
        pnlIndependentActions.SuspendLayout();
        pnlActionRow1.SuspendLayout();
        pnlActionText1.SuspendLayout();
        pnlActionRow2.SuspendLayout();
        pnlActionText2.SuspendLayout();
        pnlCoOpRow.SuspendLayout();
        pnlCoOpText.SuspendLayout();
        pnlActionRow4.SuspendLayout();
        pnlActionText4.SuspendLayout();
        pnlActionRow5.SuspendLayout();
        pnlActionText5.SuspendLayout();
        pnlPresetGroups.SuspendLayout();
        pnlTaskPresetRow.SuspendLayout();
        pnlTaskPresetText.SuspendLayout();
        pnlSkillPresetRow.SuspendLayout();
        pnlSkillPresetText.SuspendLayout();
        pnlInspectorCard.SuspendLayout();
        pnlInspectorLayout.SuspendLayout();
        pnlChecksumCard.SuspendLayout();
        pnlChecksumDetails.SuspendLayout();
        pnlFileCard.SuspendLayout();
        pnlStatsCard.SuspendLayout();
        pnlStatsCardLayout.SuspendLayout();
        pnlStatsSectionIntro.SuspendLayout();
        pnlScrollHost.SuspendLayout();
        _statsTable.SuspendLayout();
        pnlResetRow.SuspendLayout();
        pnlStatusBar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlRoot
        // 
        pnlRoot.BackColor = Color.FromArgb(9, 15, 29);
        pnlRoot.ColumnCount = 1;
        pnlRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlRoot.Controls.Add(pnlHeader, 0, 0);
        pnlRoot.Controls.Add(pnlContent, 0, 1);
        pnlRoot.Controls.Add(pnlStatusBar, 0, 2);
        pnlRoot.Dock = DockStyle.Fill;
        pnlRoot.Location = new Point(0, 0);
        pnlRoot.Name = "pnlRoot";
        pnlRoot.Padding = new Padding(28, 22, 28, 18);
        pnlRoot.RowCount = 3;
        pnlRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
        pnlRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        pnlRoot.Size = new Size(1180, 820);
        pnlRoot.TabIndex = 0;
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(9, 15, 29);
        pnlHeader.ColumnCount = 2;
        pnlHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 365F));
        pnlHeader.Controls.Add(pnlTitleStack, 0, 0);
        pnlHeader.Controls.Add(pnlHeaderActions, 1, 0);
        pnlHeader.Dock = DockStyle.Fill;
        pnlHeader.Location = new Point(31, 25);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.RowCount = 1;
        pnlHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlHeader.Size = new Size(1118, 78);
        pnlHeader.TabIndex = 0;
        // 
        // pnlTitleStack
        // 
        pnlTitleStack.BackColor = Color.FromArgb(9, 15, 29);
        pnlTitleStack.ColumnCount = 1;
        pnlTitleStack.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlTitleStack.Controls.Add(pictureBox1, 0, 0);
        pnlTitleStack.Dock = DockStyle.Fill;
        pnlTitleStack.Location = new Point(3, 3);
        pnlTitleStack.Name = "pnlTitleStack";
        pnlTitleStack.Padding = new Padding(0, 0, 0, 4);
        pnlTitleStack.RowCount = 1;
        pnlTitleStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        pnlTitleStack.Size = new Size(747, 72);
        pnlTitleStack.TabIndex = 0;
        pnlTitleStack.Paint += pnlTitleStack_Paint;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.logo;
        pictureBox1.Location = new Point(3, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(210, 62);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // pnlHeaderActions
        // 
        pnlHeaderActions.BackColor = Color.FromArgb(9, 15, 29);
        pnlHeaderActions.Controls.Add(_exportButton);
        pnlHeaderActions.Controls.Add(_importButton);
        pnlHeaderActions.Controls.Add(_verifyButton);
        pnlHeaderActions.Dock = DockStyle.Fill;
        pnlHeaderActions.FlowDirection = FlowDirection.RightToLeft;
        pnlHeaderActions.Location = new Point(756, 3);
        pnlHeaderActions.Name = "pnlHeaderActions";
        pnlHeaderActions.Padding = new Padding(0, 12, 0, 0);
        pnlHeaderActions.Size = new Size(359, 72);
        pnlHeaderActions.TabIndex = 1;
        pnlHeaderActions.WrapContents = false;
        // 
        // _exportButton
        // 
        _exportButton.BackColor = Color.FromArgb(127, 89, 119);
        _exportButton.Cursor = Cursors.Hand;
        _exportButton.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        _exportButton.FlatStyle = FlatStyle.Flat;
        _exportButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        _exportButton.ForeColor = Color.FromArgb(235, 241, 250);
        _exportButton.Location = new Point(240, 15);
        _exportButton.Name = "_exportButton";
        _exportButton.Size = new Size(116, 40);
        _exportButton.TabIndex = 0;
        _exportButton.Text = "EXPORT";
        _exportButton.UseVisualStyleBackColor = false;
        _exportButton.Click += ExportButton_Click;
        // 
        // _importButton
        // 
        _importButton.BackColor = Color.FromArgb(82, 168, 255);
        _importButton.Cursor = Cursors.Hand;
        _importButton.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        _importButton.FlatStyle = FlatStyle.Flat;
        _importButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        _importButton.ForeColor = Color.White;
        _importButton.Location = new Point(118, 15);
        _importButton.Name = "_importButton";
        _importButton.Size = new Size(116, 40);
        _importButton.TabIndex = 1;
        _importButton.Text = "IMPORT";
        _importButton.UseVisualStyleBackColor = false;
        _importButton.Click += ImportButton_Click;
        // 
        // _verifyButton
        // 
        _verifyButton.BackColor = Color.FromArgb(23, 36, 60);
        _verifyButton.Cursor = Cursors.Hand;
        _verifyButton.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        _verifyButton.FlatStyle = FlatStyle.Flat;
        _verifyButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        _verifyButton.ForeColor = Color.FromArgb(235, 241, 250);
        _verifyButton.Location = new Point(27, 15);
        _verifyButton.Name = "_verifyButton";
        _verifyButton.Size = new Size(85, 40);
        _verifyButton.TabIndex = 2;
        _verifyButton.Text = "VERIFY";
        _verifyButton.UseVisualStyleBackColor = false;
        _verifyButton.Click += VerifyButton_Click;
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(9, 15, 29);
        pnlContent.ColumnCount = 2;
        pnlContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
        pnlContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
        pnlContent.Controls.Add(pnlEditorCard, 0, 0);
        pnlContent.Controls.Add(pnlInspectorCard, 1, 0);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(31, 109);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new Padding(0, 12, 0, 10);
        pnlContent.RowCount = 1;
        pnlContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlContent.Size = new Size(1118, 660);
        pnlContent.TabIndex = 1;
        // 
        // pnlEditorCard
        // 
        pnlEditorCard.BackColor = Color.FromArgb(17, 27, 46);
        pnlEditorCard.BorderStyle = BorderStyle.FixedSingle;
        pnlEditorCard.Controls.Add(pnlEditorLayout);
        pnlEditorCard.Dock = DockStyle.Fill;
        pnlEditorCard.Location = new Point(0, 12);
        pnlEditorCard.Margin = new Padding(0, 0, 12, 0);
        pnlEditorCard.Name = "pnlEditorCard";
        pnlEditorCard.Padding = new Padding(1);
        pnlEditorCard.Size = new Size(636, 638);
        pnlEditorCard.TabIndex = 0;
        // 
        // pnlEditorLayout
        // 
        pnlEditorLayout.BackColor = Color.FromArgb(17, 27, 46);
        pnlEditorLayout.ColumnCount = 1;
        pnlEditorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlEditorLayout.Controls.Add(pnlSectionIntroEditor, 0, 0);
        pnlEditorLayout.Controls.Add(pnlIndependentActions, 0, 1);
        pnlEditorLayout.Controls.Add(pnlPresetGroups, 0, 2);
        pnlEditorLayout.Dock = DockStyle.Fill;
        pnlEditorLayout.Location = new Point(1, 1);
        pnlEditorLayout.Name = "pnlEditorLayout";
        pnlEditorLayout.Padding = new Padding(24, 20, 24, 20);
        pnlEditorLayout.RowCount = 4;
        pnlEditorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        pnlEditorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 65.8181839F));
        pnlEditorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 26.545454F));
        pnlEditorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.818182F));
        pnlEditorLayout.Size = new Size(632, 634);
        pnlEditorLayout.TabIndex = 0;
        pnlEditorLayout.Paint += pnlEditorLayout_Paint;
        // 
        // pnlSectionIntroEditor
        // 
        pnlSectionIntroEditor.BackColor = Color.FromArgb(17, 27, 46);
        pnlSectionIntroEditor.ColumnCount = 1;
        pnlSectionIntroEditor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlSectionIntroEditor.Controls.Add(lblSectionEditorHeading, 0, 0);
        pnlSectionIntroEditor.Controls.Add(lblSectionEditorSubtitle, 0, 1);
        pnlSectionIntroEditor.Dock = DockStyle.Fill;
        pnlSectionIntroEditor.Location = new Point(27, 23);
        pnlSectionIntroEditor.Name = "pnlSectionIntroEditor";
        pnlSectionIntroEditor.RowCount = 2;
        pnlSectionIntroEditor.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        pnlSectionIntroEditor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlSectionIntroEditor.Size = new Size(578, 38);
        pnlSectionIntroEditor.TabIndex = 0;
        // 
        // lblSectionEditorHeading
        // 
        lblSectionEditorHeading.BackColor = Color.Transparent;
        lblSectionEditorHeading.Dock = DockStyle.Fill;
        lblSectionEditorHeading.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblSectionEditorHeading.ForeColor = Color.FromArgb(235, 241, 250);
        lblSectionEditorHeading.Location = new Point(3, 0);
        lblSectionEditorHeading.Name = "lblSectionEditorHeading";
        lblSectionEditorHeading.Size = new Size(572, 22);
        lblSectionEditorHeading.TabIndex = 0;
        lblSectionEditorHeading.Text = "CHOOSE YOUR CHEATS";
        lblSectionEditorHeading.Click += lblSectionEditorHeading_Click;
        // 
        // lblSectionEditorSubtitle
        // 
        lblSectionEditorSubtitle.BackColor = Color.Transparent;
        lblSectionEditorSubtitle.Dock = DockStyle.Fill;
        lblSectionEditorSubtitle.Font = new Font("Segoe UI", 8.5F);
        lblSectionEditorSubtitle.ForeColor = Color.FromArgb(145, 163, 189);
        lblSectionEditorSubtitle.Location = new Point(3, 22);
        lblSectionEditorSubtitle.Name = "lblSectionEditorSubtitle";
        lblSectionEditorSubtitle.Size = new Size(572, 16);
        lblSectionEditorSubtitle.TabIndex = 1;
        lblSectionEditorSubtitle.Text = "Changes stay in memory until you export.";
        // 
        // pnlIndependentActions
        // 
        pnlIndependentActions.BackColor = Color.FromArgb(17, 27, 46);
        pnlIndependentActions.ColumnCount = 1;
        pnlIndependentActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlIndependentActions.Controls.Add(lblIndependentBoostsHeading, 0, 0);
        pnlIndependentActions.Controls.Add(pnlActionRow1, 0, 1);
        pnlIndependentActions.Controls.Add(pnlActionRow2, 0, 2);
        pnlIndependentActions.Controls.Add(pnlCoOpRow, 0, 3);
        pnlIndependentActions.Controls.Add(pnlActionRow4, 0, 4);
        pnlIndependentActions.Controls.Add(pnlActionRow5, 0, 5);
        pnlIndependentActions.Dock = DockStyle.Fill;
        pnlIndependentActions.Location = new Point(27, 67);
        pnlIndependentActions.Name = "pnlIndependentActions";
        pnlIndependentActions.RowCount = 6;
        pnlIndependentActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        pnlIndependentActions.RowStyles.Add(new RowStyle(SizeType.Percent, 21.4F));
        pnlIndependentActions.RowStyles.Add(new RowStyle(SizeType.Percent, 20.9F));
        pnlIndependentActions.RowStyles.Add(new RowStyle(SizeType.Percent, 20.8F));
        pnlIndependentActions.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        pnlIndependentActions.RowStyles.Add(new RowStyle(SizeType.Percent, 16.9F));
        pnlIndependentActions.Size = new Size(578, 355);
        pnlIndependentActions.TabIndex = 1;
        // 
        // lblIndependentBoostsHeading
        // 
        lblIndependentBoostsHeading.BackColor = Color.Transparent;
        lblIndependentBoostsHeading.Dock = DockStyle.Fill;
        lblIndependentBoostsHeading.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblIndependentBoostsHeading.ForeColor = Color.FromArgb(82, 168, 255);
        lblIndependentBoostsHeading.Location = new Point(3, 0);
        lblIndependentBoostsHeading.Name = "lblIndependentBoostsHeading";
        lblIndependentBoostsHeading.Size = new Size(572, 28);
        lblIndependentBoostsHeading.TabIndex = 0;
        lblIndependentBoostsHeading.Text = "INDEPENDENT BOOSTS";
        // 
        // pnlActionRow1
        // 
        pnlActionRow1.BackColor = Color.FromArgb(17, 27, 46);
        pnlActionRow1.ColumnCount = 2;
        pnlActionRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlActionRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
        pnlActionRow1.Controls.Add(pnlActionText1, 0, 0);
        pnlActionRow1.Controls.Add(btnBindingVows, 1, 0);
        pnlActionRow1.Dock = DockStyle.Fill;
        pnlActionRow1.Location = new Point(3, 31);
        pnlActionRow1.Name = "pnlActionRow1";
        pnlActionRow1.RowCount = 1;
        pnlActionRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlActionRow1.Size = new Size(572, 63);
        pnlActionRow1.TabIndex = 1;
        pnlActionRow1.Paint += pnlActionRow1_Paint;
        // 
        // pnlActionText1
        // 
        pnlActionText1.BackColor = Color.FromArgb(17, 27, 46);
        pnlActionText1.ColumnCount = 1;
        pnlActionText1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlActionText1.Controls.Add(lblActionTitle1, 0, 0);
        pnlActionText1.Controls.Add(lblActionDetail1, 0, 1);
        pnlActionText1.Dock = DockStyle.Fill;
        pnlActionText1.Location = new Point(3, 3);
        pnlActionText1.Name = "pnlActionText1";
        pnlActionText1.Padding = new Padding(0, 1, 12, 0);
        pnlActionText1.RowCount = 2;
        pnlActionText1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        pnlActionText1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlActionText1.Size = new Size(444, 57);
        pnlActionText1.TabIndex = 0;
        // 
        // lblActionTitle1
        // 
        lblActionTitle1.BackColor = Color.Transparent;
        lblActionTitle1.Dock = DockStyle.Fill;
        lblActionTitle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblActionTitle1.ForeColor = Color.FromArgb(235, 241, 250);
        lblActionTitle1.Location = new Point(3, 1);
        lblActionTitle1.Name = "lblActionTitle1";
        lblActionTitle1.Size = new Size(426, 21);
        lblActionTitle1.TabIndex = 0;
        lblActionTitle1.Text = "99 Binding Vows Co-op Won";
        lblActionTitle1.Click += lblActionTitle1_Click;
        // 
        // lblActionDetail1
        // 
        lblActionDetail1.AutoEllipsis = true;
        lblActionDetail1.BackColor = Color.Transparent;
        lblActionDetail1.Dock = DockStyle.Fill;
        lblActionDetail1.Font = new Font("Segoe UI", 8.5F);
        lblActionDetail1.ForeColor = Color.FromArgb(145, 163, 189);
        lblActionDetail1.Location = new Point(3, 22);
        lblActionDetail1.Name = "lblActionDetail1";
        lblActionDetail1.Size = new Size(426, 35);
        lblActionDetail1.TabIndex = 1;
        lblActionDetail1.Text = "Offset 0x0006170C  ·  writes 99";
        // 
        // btnBindingVows
        // 
        btnBindingVows.BackColor = Color.FromArgb(127, 89, 119);
        btnBindingVows.Cursor = Cursors.Hand;
        btnBindingVows.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        btnBindingVows.FlatStyle = FlatStyle.Flat;
        btnBindingVows.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        btnBindingVows.ForeColor = Color.FromArgb(235, 241, 250);
        btnBindingVows.Location = new Point(453, 3);
        btnBindingVows.Name = "btnBindingVows";
        btnBindingVows.Size = new Size(116, 28);
        btnBindingVows.TabIndex = 1;
        btnBindingVows.Text = "Apply";
        btnBindingVows.UseVisualStyleBackColor = false;
        btnBindingVows.Click += EditBindingVowsButton_Click;
        // 
        // pnlActionRow2
        // 
        pnlActionRow2.BackColor = Color.FromArgb(17, 27, 46);
        pnlActionRow2.ColumnCount = 2;
        pnlActionRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlActionRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
        pnlActionRow2.Controls.Add(pnlActionText2, 0, 0);
        pnlActionRow2.Controls.Add(btnRankS, 1, 0);
        pnlActionRow2.Dock = DockStyle.Fill;
        pnlActionRow2.Location = new Point(3, 100);
        pnlActionRow2.Name = "pnlActionRow2";
        pnlActionRow2.RowCount = 1;
        pnlActionRow2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlActionRow2.Size = new Size(572, 62);
        pnlActionRow2.TabIndex = 2;
        // 
        // pnlActionText2
        // 
        pnlActionText2.BackColor = Color.FromArgb(17, 27, 46);
        pnlActionText2.ColumnCount = 1;
        pnlActionText2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlActionText2.Controls.Add(lblActionTitle2, 0, 0);
        pnlActionText2.Controls.Add(lblActionDetail2, 0, 1);
        pnlActionText2.Dock = DockStyle.Fill;
        pnlActionText2.Location = new Point(3, 3);
        pnlActionText2.Name = "pnlActionText2";
        pnlActionText2.Padding = new Padding(0, 1, 12, 0);
        pnlActionText2.RowCount = 2;
        pnlActionText2.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        pnlActionText2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlActionText2.Size = new Size(444, 56);
        pnlActionText2.TabIndex = 0;
        // 
        // lblActionTitle2
        // 
        lblActionTitle2.BackColor = Color.Transparent;
        lblActionTitle2.Dock = DockStyle.Fill;
        lblActionTitle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblActionTitle2.ForeColor = Color.FromArgb(235, 241, 250);
        lblActionTitle2.Location = new Point(3, 1);
        lblActionTitle2.Name = "lblActionTitle2";
        lblActionTitle2.Size = new Size(426, 21);
        lblActionTitle2.TabIndex = 0;
        lblActionTitle2.Text = "99 Rank S Co-op Won";
        lblActionTitle2.Click += lblActionTitle2_Click;
        // 
        // lblActionDetail2
        // 
        lblActionDetail2.AutoEllipsis = true;
        lblActionDetail2.BackColor = Color.Transparent;
        lblActionDetail2.Dock = DockStyle.Fill;
        lblActionDetail2.Font = new Font("Segoe UI", 8.5F);
        lblActionDetail2.ForeColor = Color.FromArgb(145, 163, 189);
        lblActionDetail2.Location = new Point(3, 22);
        lblActionDetail2.Name = "lblActionDetail2";
        lblActionDetail2.Size = new Size(426, 34);
        lblActionDetail2.TabIndex = 1;
        lblActionDetail2.Text = "Offset 0x0006172C  ·  writes 99";
        // 
        // btnRankS
        // 
        btnRankS.BackColor = Color.FromArgb(127, 89, 119);
        btnRankS.Cursor = Cursors.Hand;
        btnRankS.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        btnRankS.FlatStyle = FlatStyle.Flat;
        btnRankS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        btnRankS.ForeColor = Color.FromArgb(235, 241, 250);
        btnRankS.Location = new Point(453, 3);
        btnRankS.Name = "btnRankS";
        btnRankS.Size = new Size(116, 28);
        btnRankS.TabIndex = 1;
        btnRankS.Text = "Apply";
        btnRankS.UseVisualStyleBackColor = false;
        btnRankS.Click += EditRankSButton_Click;
        // 
        // pnlCoOpRow
        // 
        pnlCoOpRow.BackColor = Color.FromArgb(17, 27, 46);
        pnlCoOpRow.ColumnCount = 2;
        pnlCoOpRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlCoOpRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
        pnlCoOpRow.Controls.Add(pnlCoOpText, 0, 0);
        pnlCoOpRow.Controls.Add(btnCoOp, 1, 0);
        pnlCoOpRow.Dock = DockStyle.Fill;
        pnlCoOpRow.Location = new Point(3, 168);
        pnlCoOpRow.Name = "pnlCoOpRow";
        pnlCoOpRow.RowCount = 1;
        pnlCoOpRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlCoOpRow.Size = new Size(572, 62);
        pnlCoOpRow.TabIndex = 3;
        pnlCoOpRow.Paint += pnlCoOpRow_Paint;
        // 
        // pnlCoOpText
        // 
        pnlCoOpText.BackColor = Color.FromArgb(17, 27, 46);
        pnlCoOpText.ColumnCount = 1;
        pnlCoOpText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlCoOpText.Controls.Add(lblCoOpTitle, 0, 0);
        pnlCoOpText.Controls.Add(lblCoOpDetail, 0, 1);
        pnlCoOpText.Dock = DockStyle.Fill;
        pnlCoOpText.Location = new Point(3, 3);
        pnlCoOpText.Name = "pnlCoOpText";
        pnlCoOpText.Padding = new Padding(0, 1, 12, 0);
        pnlCoOpText.RowCount = 2;
        pnlCoOpText.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        pnlCoOpText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlCoOpText.Size = new Size(444, 56);
        pnlCoOpText.TabIndex = 0;
        // 
        // lblCoOpTitle
        // 
        lblCoOpTitle.BackColor = Color.Transparent;
        lblCoOpTitle.Dock = DockStyle.Fill;
        lblCoOpTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblCoOpTitle.ForeColor = Color.FromArgb(235, 241, 250);
        lblCoOpTitle.Location = new Point(3, 1);
        lblCoOpTitle.Name = "lblCoOpTitle";
        lblCoOpTitle.Size = new Size(426, 21);
        lblCoOpTitle.TabIndex = 0;
        lblCoOpTitle.Text = "99 Co-op Completions";
        // 
        // lblCoOpDetail
        // 
        lblCoOpDetail.AutoEllipsis = true;
        lblCoOpDetail.BackColor = Color.Transparent;
        lblCoOpDetail.Dock = DockStyle.Fill;
        lblCoOpDetail.Font = new Font("Segoe UI", 8.5F);
        lblCoOpDetail.ForeColor = Color.FromArgb(145, 163, 189);
        lblCoOpDetail.Location = new Point(3, 22);
        lblCoOpDetail.Name = "lblCoOpDetail";
        lblCoOpDetail.Size = new Size(426, 34);
        lblCoOpDetail.TabIndex = 1;
        lblCoOpDetail.Text = "Offsets 0x00061718 + 0x00061730  ·  writes 99 to both";
        lblCoOpDetail.Click += lblCoOpDetail_Click;
        // 
        // btnCoOp
        // 
        btnCoOp.BackColor = Color.FromArgb(127, 89, 119);
        btnCoOp.Cursor = Cursors.Hand;
        btnCoOp.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        btnCoOp.FlatStyle = FlatStyle.Flat;
        btnCoOp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        btnCoOp.ForeColor = Color.FromArgb(235, 241, 250);
        btnCoOp.Location = new Point(453, 3);
        btnCoOp.Name = "btnCoOp";
        btnCoOp.Size = new Size(116, 28);
        btnCoOp.TabIndex = 1;
        btnCoOp.Text = "Apply";
        btnCoOp.UseVisualStyleBackColor = false;
        btnCoOp.Click += EditCoOpCompletionsButton_Click;
        // 
        // pnlActionRow4
        // 
        pnlActionRow4.BackColor = Color.FromArgb(17, 27, 46);
        pnlActionRow4.ColumnCount = 2;
        pnlActionRow4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlActionRow4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
        pnlActionRow4.Controls.Add(pnlActionText4, 0, 0);
        pnlActionRow4.Controls.Add(btnJujuPoints, 1, 0);
        pnlActionRow4.Dock = DockStyle.Fill;
        pnlActionRow4.Location = new Point(3, 236);
        pnlActionRow4.Name = "pnlActionRow4";
        pnlActionRow4.RowCount = 1;
        pnlActionRow4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlActionRow4.Size = new Size(572, 59);
        pnlActionRow4.TabIndex = 4;
        // 
        // pnlActionText4
        // 
        pnlActionText4.BackColor = Color.FromArgb(17, 27, 46);
        pnlActionText4.ColumnCount = 1;
        pnlActionText4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlActionText4.Controls.Add(lblActionTitle4, 0, 0);
        pnlActionText4.Controls.Add(lblActionDetail4, 0, 1);
        pnlActionText4.Dock = DockStyle.Fill;
        pnlActionText4.Location = new Point(3, 3);
        pnlActionText4.Name = "pnlActionText4";
        pnlActionText4.Padding = new Padding(0, 1, 12, 0);
        pnlActionText4.RowCount = 2;
        pnlActionText4.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        pnlActionText4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlActionText4.Size = new Size(444, 53);
        pnlActionText4.TabIndex = 0;
        // 
        // lblActionTitle4
        // 
        lblActionTitle4.BackColor = Color.Transparent;
        lblActionTitle4.Dock = DockStyle.Fill;
        lblActionTitle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblActionTitle4.ForeColor = Color.FromArgb(235, 241, 250);
        lblActionTitle4.Location = new Point(3, 1);
        lblActionTitle4.Name = "lblActionTitle4";
        lblActionTitle4.Size = new Size(426, 21);
        lblActionTitle4.TabIndex = 0;
        lblActionTitle4.Text = "99,999,999 Juju Points";
        // 
        // lblActionDetail4
        // 
        lblActionDetail4.AutoEllipsis = true;
        lblActionDetail4.BackColor = Color.Transparent;
        lblActionDetail4.Dock = DockStyle.Fill;
        lblActionDetail4.Font = new Font("Segoe UI", 8.5F);
        lblActionDetail4.ForeColor = Color.FromArgb(145, 163, 189);
        lblActionDetail4.Location = new Point(3, 22);
        lblActionDetail4.Name = "lblActionDetail4";
        lblActionDetail4.Size = new Size(426, 31);
        lblActionDetail4.TabIndex = 1;
        lblActionDetail4.Text = "Offset 0x0000232C  ·  writes 99,999,999";
        lblActionDetail4.Click += lblActionDetail4_Click;
        // 
        // btnJujuPoints
        // 
        btnJujuPoints.BackColor = Color.FromArgb(127, 89, 119);
        btnJujuPoints.Cursor = Cursors.Hand;
        btnJujuPoints.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        btnJujuPoints.FlatStyle = FlatStyle.Flat;
        btnJujuPoints.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        btnJujuPoints.ForeColor = Color.FromArgb(235, 241, 250);
        btnJujuPoints.Location = new Point(453, 3);
        btnJujuPoints.Name = "btnJujuPoints";
        btnJujuPoints.Size = new Size(116, 28);
        btnJujuPoints.TabIndex = 1;
        btnJujuPoints.Text = "Apply";
        btnJujuPoints.UseVisualStyleBackColor = false;
        btnJujuPoints.Click += EditJujuPointsButton_Click;
        // 
        // pnlActionRow5
        // 
        pnlActionRow5.BackColor = Color.FromArgb(17, 27, 46);
        pnlActionRow5.ColumnCount = 2;
        pnlActionRow5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlActionRow5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
        pnlActionRow5.Controls.Add(pnlActionText5, 0, 0);
        pnlActionRow5.Controls.Add(btnCoOpExp, 1, 0);
        pnlActionRow5.Dock = DockStyle.Fill;
        pnlActionRow5.Location = new Point(3, 301);
        pnlActionRow5.Name = "pnlActionRow5";
        pnlActionRow5.RowCount = 1;
        pnlActionRow5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlActionRow5.Size = new Size(572, 51);
        pnlActionRow5.TabIndex = 5;
        // 
        // pnlActionText5
        // 
        pnlActionText5.BackColor = Color.FromArgb(17, 27, 46);
        pnlActionText5.ColumnCount = 1;
        pnlActionText5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlActionText5.Controls.Add(lblActionTitle5, 0, 0);
        pnlActionText5.Controls.Add(lblActionDetail5, 0, 1);
        pnlActionText5.Dock = DockStyle.Fill;
        pnlActionText5.Location = new Point(3, 3);
        pnlActionText5.Name = "pnlActionText5";
        pnlActionText5.Padding = new Padding(0, 1, 12, 0);
        pnlActionText5.RowCount = 2;
        pnlActionText5.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        pnlActionText5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlActionText5.Size = new Size(444, 45);
        pnlActionText5.TabIndex = 0;
        // 
        // lblActionTitle5
        // 
        lblActionTitle5.BackColor = Color.Transparent;
        lblActionTitle5.Dock = DockStyle.Fill;
        lblActionTitle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblActionTitle5.ForeColor = Color.FromArgb(235, 241, 250);
        lblActionTitle5.Location = new Point(3, 1);
        lblActionTitle5.Name = "lblActionTitle5";
        lblActionTitle5.Size = new Size(426, 21);
        lblActionTitle5.TabIndex = 0;
        lblActionTitle5.Text = "Max Co-op EXP Pool";
        // 
        // lblActionDetail5
        // 
        lblActionDetail5.AutoEllipsis = true;
        lblActionDetail5.BackColor = Color.Transparent;
        lblActionDetail5.Dock = DockStyle.Fill;
        lblActionDetail5.Font = new Font("Segoe UI", 8.5F);
        lblActionDetail5.ForeColor = Color.FromArgb(145, 163, 189);
        lblActionDetail5.Location = new Point(3, 22);
        lblActionDetail5.Name = "lblActionDetail5";
        lblActionDetail5.Size = new Size(426, 23);
        lblActionDetail5.TabIndex = 1;
        lblActionDetail5.Text = "Offset 0x00047E4C  ·  writes 96,421,969";
        // 
        // btnCoOpExp
        // 
        btnCoOpExp.BackColor = Color.FromArgb(127, 89, 119);
        btnCoOpExp.Cursor = Cursors.Hand;
        btnCoOpExp.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        btnCoOpExp.FlatStyle = FlatStyle.Flat;
        btnCoOpExp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        btnCoOpExp.ForeColor = Color.FromArgb(235, 241, 250);
        btnCoOpExp.Location = new Point(453, 3);
        btnCoOpExp.Name = "btnCoOpExp";
        btnCoOpExp.Size = new Size(116, 28);
        btnCoOpExp.TabIndex = 1;
        btnCoOpExp.Text = "Apply";
        btnCoOpExp.UseVisualStyleBackColor = false;
        btnCoOpExp.Click += EditCoOpExpButton_Click;
        // 
        // pnlPresetGroups
        // 
        pnlPresetGroups.BackColor = Color.FromArgb(17, 27, 46);
        pnlPresetGroups.ColumnCount = 1;
        pnlPresetGroups.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlPresetGroups.Controls.Add(lblPresetsHeading, 0, 0);
        pnlPresetGroups.Controls.Add(pnlTaskPresetRow, 0, 1);
        pnlPresetGroups.Controls.Add(pnlSkillPresetRow, 0, 2);
        pnlPresetGroups.Dock = DockStyle.Fill;
        pnlPresetGroups.Location = new Point(27, 428);
        pnlPresetGroups.Name = "pnlPresetGroups";
        pnlPresetGroups.RowCount = 4;
        pnlPresetGroups.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        pnlPresetGroups.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        pnlPresetGroups.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        pnlPresetGroups.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
        pnlPresetGroups.Size = new Size(578, 139);
        pnlPresetGroups.TabIndex = 2;
        // 
        // lblPresetsHeading
        // 
        lblPresetsHeading.BackColor = Color.Transparent;
        lblPresetsHeading.Dock = DockStyle.Fill;
        lblPresetsHeading.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPresetsHeading.ForeColor = Color.FromArgb(82, 168, 255);
        lblPresetsHeading.Location = new Point(3, 0);
        lblPresetsHeading.Name = "lblPresetsHeading";
        lblPresetsHeading.Size = new Size(572, 28);
        lblPresetsHeading.TabIndex = 0;
        lblPresetsHeading.Text = "CHOOSE 1 FROM EACH DROPDOWN";
        // 
        // pnlTaskPresetRow
        // 
        pnlTaskPresetRow.BackColor = Color.FromArgb(17, 27, 46);
        pnlTaskPresetRow.ColumnCount = 3;
        pnlTaskPresetRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlTaskPresetRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
        pnlTaskPresetRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
        pnlTaskPresetRow.Controls.Add(pnlTaskPresetText, 0, 0);
        pnlTaskPresetRow.Controls.Add(_taskPresetCombo, 1, 0);
        pnlTaskPresetRow.Controls.Add(_applyTaskButton, 2, 0);
        pnlTaskPresetRow.Dock = DockStyle.Fill;
        pnlTaskPresetRow.Location = new Point(3, 31);
        pnlTaskPresetRow.Name = "pnlTaskPresetRow";
        pnlTaskPresetRow.RowCount = 1;
        pnlTaskPresetRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlTaskPresetRow.Size = new Size(572, 49);
        pnlTaskPresetRow.TabIndex = 1;
        // 
        // pnlTaskPresetText
        // 
        pnlTaskPresetText.BackColor = Color.FromArgb(17, 27, 46);
        pnlTaskPresetText.ColumnCount = 1;
        pnlTaskPresetText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlTaskPresetText.Controls.Add(lblTaskPresetTitle, 0, 0);
        pnlTaskPresetText.Controls.Add(lblTaskPresetDetail, 0, 1);
        pnlTaskPresetText.Dock = DockStyle.Fill;
        pnlTaskPresetText.Location = new Point(3, 3);
        pnlTaskPresetText.Name = "pnlTaskPresetText";
        pnlTaskPresetText.Padding = new Padding(0, 1, 12, 0);
        pnlTaskPresetText.RowCount = 2;
        pnlTaskPresetText.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        pnlTaskPresetText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlTaskPresetText.Size = new Size(336, 43);
        pnlTaskPresetText.TabIndex = 0;
        // 
        // lblTaskPresetTitle
        // 
        lblTaskPresetTitle.BackColor = Color.Transparent;
        lblTaskPresetTitle.Dock = DockStyle.Fill;
        lblTaskPresetTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTaskPresetTitle.ForeColor = Color.FromArgb(235, 241, 250);
        lblTaskPresetTitle.Location = new Point(3, 1);
        lblTaskPresetTitle.Name = "lblTaskPresetTitle";
        lblTaskPresetTitle.Size = new Size(318, 21);
        lblTaskPresetTitle.TabIndex = 0;
        lblTaskPresetTitle.Text = "Tasks Completed";
        // 
        // lblTaskPresetDetail
        // 
        lblTaskPresetDetail.AutoEllipsis = true;
        lblTaskPresetDetail.BackColor = Color.Transparent;
        lblTaskPresetDetail.Dock = DockStyle.Fill;
        lblTaskPresetDetail.Font = new Font("Segoe UI", 8.5F);
        lblTaskPresetDetail.ForeColor = Color.FromArgb(145, 163, 189);
        lblTaskPresetDetail.Location = new Point(3, 22);
        lblTaskPresetDetail.Name = "lblTaskPresetDetail";
        lblTaskPresetDetail.Size = new Size(318, 21);
        lblTaskPresetDetail.TabIndex = 1;
        lblTaskPresetDetail.Text = "Same offset, so choose one preset before applying.";
        // 
        // _taskPresetCombo
        // 
        _taskPresetCombo.BackColor = Color.FromArgb(23, 36, 60);
        _taskPresetCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _taskPresetCombo.Font = new Font("Segoe UI Semibold", 9F);
        _taskPresetCombo.ForeColor = Color.FromArgb(235, 241, 250);
        _taskPresetCombo.Items.AddRange(new object[] { "99", "299" });
        _taskPresetCombo.Location = new Point(342, 3);
        _taskPresetCombo.Margin = new Padding(0, 3, 8, 3);
        _taskPresetCombo.Name = "_taskPresetCombo";
        _taskPresetCombo.Size = new Size(99, 23);
        _taskPresetCombo.TabIndex = 1;
        // 
        // _applyTaskButton
        // 
        _applyTaskButton.BackColor = Color.FromArgb(127, 89, 119);
        _applyTaskButton.Cursor = Cursors.Hand;
        _applyTaskButton.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        _applyTaskButton.FlatStyle = FlatStyle.Flat;
        _applyTaskButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        _applyTaskButton.ForeColor = Color.FromArgb(235, 241, 250);
        _applyTaskButton.Location = new Point(452, 3);
        _applyTaskButton.Name = "_applyTaskButton";
        _applyTaskButton.Size = new Size(117, 25);
        _applyTaskButton.TabIndex = 2;
        _applyTaskButton.Text = "Apply";
        _applyTaskButton.UseVisualStyleBackColor = false;
        _applyTaskButton.Click += ApplyTaskButton_Click;
        // 
        // pnlSkillPresetRow
        // 
        pnlSkillPresetRow.BackColor = Color.FromArgb(17, 27, 46);
        pnlSkillPresetRow.ColumnCount = 3;
        pnlSkillPresetRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlSkillPresetRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
        pnlSkillPresetRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
        pnlSkillPresetRow.Controls.Add(pnlSkillPresetText, 0, 0);
        pnlSkillPresetRow.Controls.Add(_skillPresetCombo, 1, 0);
        pnlSkillPresetRow.Controls.Add(_applySkillButton, 2, 0);
        pnlSkillPresetRow.Dock = DockStyle.Fill;
        pnlSkillPresetRow.Location = new Point(3, 86);
        pnlSkillPresetRow.Name = "pnlSkillPresetRow";
        pnlSkillPresetRow.RowCount = 1;
        pnlSkillPresetRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlSkillPresetRow.Size = new Size(572, 49);
        pnlSkillPresetRow.TabIndex = 2;
        // 
        // pnlSkillPresetText
        // 
        pnlSkillPresetText.BackColor = Color.FromArgb(17, 27, 46);
        pnlSkillPresetText.ColumnCount = 1;
        pnlSkillPresetText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlSkillPresetText.Controls.Add(lblSkillPresetTitle, 0, 0);
        pnlSkillPresetText.Controls.Add(lblSkillPresetDetail, 0, 1);
        pnlSkillPresetText.Dock = DockStyle.Fill;
        pnlSkillPresetText.Location = new Point(3, 3);
        pnlSkillPresetText.Name = "pnlSkillPresetText";
        pnlSkillPresetText.Padding = new Padding(0, 1, 12, 0);
        pnlSkillPresetText.RowCount = 2;
        pnlSkillPresetText.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
        pnlSkillPresetText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlSkillPresetText.Size = new Size(336, 43);
        pnlSkillPresetText.TabIndex = 0;
        // 
        // lblSkillPresetTitle
        // 
        lblSkillPresetTitle.BackColor = Color.Transparent;
        lblSkillPresetTitle.Dock = DockStyle.Fill;
        lblSkillPresetTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblSkillPresetTitle.ForeColor = Color.FromArgb(235, 241, 250);
        lblSkillPresetTitle.Location = new Point(3, 1);
        lblSkillPresetTitle.Name = "lblSkillPresetTitle";
        lblSkillPresetTitle.Size = new Size(318, 21);
        lblSkillPresetTitle.TabIndex = 0;
        lblSkillPresetTitle.Text = "Skill Level";
        // 
        // lblSkillPresetDetail
        // 
        lblSkillPresetDetail.AutoEllipsis = true;
        lblSkillPresetDetail.BackColor = Color.Transparent;
        lblSkillPresetDetail.Dock = DockStyle.Fill;
        lblSkillPresetDetail.Font = new Font("Segoe UI", 8.5F);
        lblSkillPresetDetail.ForeColor = Color.FromArgb(145, 163, 189);
        lblSkillPresetDetail.Location = new Point(3, 22);
        lblSkillPresetDetail.Name = "lblSkillPresetDetail";
        lblSkillPresetDetail.Size = new Size(318, 21);
        lblSkillPresetDetail.TabIndex = 1;
        lblSkillPresetDetail.Text = "Writes the selected level to both skill offsets.";
        // 
        // _skillPresetCombo
        // 
        _skillPresetCombo.BackColor = Color.FromArgb(23, 36, 60);
        _skillPresetCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        _skillPresetCombo.Font = new Font("Segoe UI Semibold", 9F);
        _skillPresetCombo.ForeColor = Color.FromArgb(235, 241, 250);
        _skillPresetCombo.Items.AddRange(new object[] { "3,000", "4,999", "10,000", "14,999", "40,000" });
        _skillPresetCombo.Location = new Point(342, 3);
        _skillPresetCombo.Margin = new Padding(0, 3, 8, 3);
        _skillPresetCombo.Name = "_skillPresetCombo";
        _skillPresetCombo.Size = new Size(99, 23);
        _skillPresetCombo.TabIndex = 1;
        // 
        // _applySkillButton
        // 
        _applySkillButton.BackColor = Color.FromArgb(127, 89, 119);
        _applySkillButton.Cursor = Cursors.Hand;
        _applySkillButton.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        _applySkillButton.FlatStyle = FlatStyle.Flat;
        _applySkillButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        _applySkillButton.ForeColor = Color.FromArgb(235, 241, 250);
        _applySkillButton.Location = new Point(452, 3);
        _applySkillButton.Name = "_applySkillButton";
        _applySkillButton.Size = new Size(117, 25);
        _applySkillButton.TabIndex = 2;
        _applySkillButton.Text = "Apply";
        _applySkillButton.UseVisualStyleBackColor = false;
        _applySkillButton.Click += ApplySkillButton_Click;
        // 
        // pnlInspectorCard
        // 
        pnlInspectorCard.BackColor = Color.FromArgb(17, 27, 46);
        pnlInspectorCard.BorderStyle = BorderStyle.FixedSingle;
        pnlInspectorCard.Controls.Add(pnlInspectorLayout);
        pnlInspectorCard.Dock = DockStyle.Fill;
        pnlInspectorCard.Location = new Point(648, 12);
        pnlInspectorCard.Margin = new Padding(0, 0, 12, 0);
        pnlInspectorCard.Name = "pnlInspectorCard";
        pnlInspectorCard.Padding = new Padding(1);
        pnlInspectorCard.Size = new Size(458, 638);
        pnlInspectorCard.TabIndex = 1;
        // 
        // pnlInspectorLayout
        // 
        pnlInspectorLayout.BackColor = Color.FromArgb(17, 27, 46);
        pnlInspectorLayout.ColumnCount = 1;
        pnlInspectorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlInspectorLayout.Controls.Add(pnlChecksumCard, 0, 0);
        pnlInspectorLayout.Controls.Add(pnlFileCard, 0, 1);
        pnlInspectorLayout.Controls.Add(pnlStatsCard, 0, 2);
        pnlInspectorLayout.Controls.Add(pnlResetRow, 0, 3);
        pnlInspectorLayout.Dock = DockStyle.Fill;
        pnlInspectorLayout.Location = new Point(1, 1);
        pnlInspectorLayout.Name = "pnlInspectorLayout";
        pnlInspectorLayout.Padding = new Padding(24, 20, 24, 20);
        pnlInspectorLayout.RowCount = 4;
        pnlInspectorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        pnlInspectorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
        pnlInspectorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlInspectorLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        pnlInspectorLayout.Size = new Size(454, 634);
        pnlInspectorLayout.TabIndex = 0;
        // 
        // pnlChecksumCard
        // 
        pnlChecksumCard.BackColor = Color.FromArgb(17, 27, 46);
        pnlChecksumCard.ColumnCount = 2;
        pnlChecksumCard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
        pnlChecksumCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlChecksumCard.Controls.Add(_checksumBadge, 0, 0);
        pnlChecksumCard.Controls.Add(pnlChecksumDetails, 1, 0);
        pnlChecksumCard.Dock = DockStyle.Fill;
        pnlChecksumCard.Location = new Point(27, 23);
        pnlChecksumCard.Name = "pnlChecksumCard";
        pnlChecksumCard.RowCount = 1;
        pnlChecksumCard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlChecksumCard.Size = new Size(400, 64);
        pnlChecksumCard.TabIndex = 0;
        // 
        // _checksumBadge
        // 
        _checksumBadge.BackColor = Color.FromArgb(23, 36, 60);
        _checksumBadge.Dock = DockStyle.Fill;
        _checksumBadge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        _checksumBadge.ForeColor = Color.FromArgb(145, 163, 189);
        _checksumBadge.Location = new Point(0, 6);
        _checksumBadge.Margin = new Padding(0, 6, 16, 6);
        _checksumBadge.Name = "_checksumBadge";
        _checksumBadge.Size = new Size(84, 52);
        _checksumBadge.TabIndex = 0;
        _checksumBadge.Text = "WAITING";
        _checksumBadge.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlChecksumDetails
        // 
        pnlChecksumDetails.BackColor = Color.FromArgb(17, 27, 46);
        pnlChecksumDetails.ColumnCount = 1;
        pnlChecksumDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlChecksumDetails.Controls.Add(_checksumDetail, 0, 0);
        pnlChecksumDetails.Controls.Add(lblChecksumHint, 0, 1);
        pnlChecksumDetails.Dock = DockStyle.Fill;
        pnlChecksumDetails.Location = new Point(103, 3);
        pnlChecksumDetails.Name = "pnlChecksumDetails";
        pnlChecksumDetails.Padding = new Padding(0, 5, 0, 0);
        pnlChecksumDetails.RowCount = 2;
        pnlChecksumDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlChecksumDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlChecksumDetails.Size = new Size(294, 58);
        pnlChecksumDetails.TabIndex = 1;
        // 
        // _checksumDetail
        // 
        _checksumDetail.Dock = DockStyle.Fill;
        _checksumDetail.Font = new Font("Segoe UI Semibold", 10.5F);
        _checksumDetail.ForeColor = Color.FromArgb(235, 241, 250);
        _checksumDetail.Location = new Point(3, 5);
        _checksumDetail.Name = "_checksumDetail";
        _checksumDetail.Size = new Size(288, 20);
        _checksumDetail.TabIndex = 0;
        _checksumDetail.Text = "Checksum status";
        // 
        // lblChecksumHint
        // 
        lblChecksumHint.BackColor = Color.Transparent;
        lblChecksumHint.Dock = DockStyle.Fill;
        lblChecksumHint.Font = new Font("Segoe UI", 8.5F);
        lblChecksumHint.ForeColor = Color.FromArgb(145, 163, 189);
        lblChecksumHint.Location = new Point(3, 25);
        lblChecksumHint.Name = "lblChecksumHint";
        lblChecksumHint.Size = new Size(288, 33);
        lblChecksumHint.TabIndex = 1;
        lblChecksumHint.Text = "MD5 of all bytes before the final 24-byte footer";
        // 
        // pnlFileCard
        // 
        pnlFileCard.BackColor = Color.FromArgb(14, 23, 40);
        pnlFileCard.Controls.Add(lblFileCardTitle);
        pnlFileCard.Controls.Add(lblFileCardBody);
        pnlFileCard.Dock = DockStyle.Fill;
        pnlFileCard.Location = new Point(27, 93);
        pnlFileCard.Name = "pnlFileCard";
        pnlFileCard.Padding = new Padding(14, 10, 14, 8);
        pnlFileCard.Size = new Size(400, 106);
        pnlFileCard.TabIndex = 1;
        // 
        // lblFileCardTitle
        // 
        lblFileCardTitle.BackColor = Color.Transparent;
        lblFileCardTitle.Dock = DockStyle.Top;
        lblFileCardTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblFileCardTitle.ForeColor = Color.FromArgb(82, 168, 255);
        lblFileCardTitle.Location = new Point(14, 10);
        lblFileCardTitle.Name = "lblFileCardTitle";
        lblFileCardTitle.Size = new Size(372, 18);
        lblFileCardTitle.TabIndex = 0;
        lblFileCardTitle.Text = "GUIDE";
        lblFileCardTitle.Click += lblFileCardTitle_Click;
        // 
        // lblFileCardBody
        // 
        lblFileCardBody.AutoEllipsis = true;
        lblFileCardBody.BackColor = Color.Transparent;
        lblFileCardBody.Dock = DockStyle.Fill;
        lblFileCardBody.Font = new Font("Segoe UI", 9F);
        lblFileCardBody.ForeColor = Color.FromArgb(145, 163, 189);
        lblFileCardBody.Location = new Point(14, 10);
        lblFileCardBody.Name = "lblFileCardBody";
        lblFileCardBody.Size = new Size(372, 88);
        lblFileCardBody.TabIndex = 1;
        lblFileCardBody.Text = "\r\nDecrypt your save with a bot, Apollo, SW etc.\r\nImport your decrypted save\r\nApply all cheats you want\r\nHit Export, rename and save somewhere\r\nEncrypt back (import in SW AM) to your save and play";
        // 
        // pnlStatsCard
        // 
        pnlStatsCard.BackColor = Color.FromArgb(23, 36, 60);
        pnlStatsCard.BorderStyle = BorderStyle.FixedSingle;
        pnlStatsCard.Controls.Add(pnlStatsCardLayout);
        pnlStatsCard.Dock = DockStyle.Fill;
        pnlStatsCard.Location = new Point(27, 205);
        pnlStatsCard.Name = "pnlStatsCard";
        pnlStatsCard.Padding = new Padding(1);
        pnlStatsCard.Size = new Size(400, 358);
        pnlStatsCard.TabIndex = 2;
        // 
        // pnlStatsCardLayout
        // 
        pnlStatsCardLayout.BackColor = Color.FromArgb(23, 36, 60);
        pnlStatsCardLayout.ColumnCount = 1;
        pnlStatsCardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlStatsCardLayout.Controls.Add(pnlStatsSectionIntro, 0, 0);
        pnlStatsCardLayout.Controls.Add(pnlScrollHost, 0, 1);
        pnlStatsCardLayout.Dock = DockStyle.Fill;
        pnlStatsCardLayout.Location = new Point(1, 1);
        pnlStatsCardLayout.Name = "pnlStatsCardLayout";
        pnlStatsCardLayout.Padding = new Padding(16, 12, 16, 12);
        pnlStatsCardLayout.RowCount = 2;
        pnlStatsCardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        pnlStatsCardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlStatsCardLayout.Size = new Size(396, 354);
        pnlStatsCardLayout.TabIndex = 0;
        // 
        // pnlStatsSectionIntro
        // 
        pnlStatsSectionIntro.BackColor = Color.FromArgb(23, 36, 60);
        pnlStatsSectionIntro.ColumnCount = 1;
        pnlStatsSectionIntro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        pnlStatsSectionIntro.Controls.Add(lblStatsHeading, 0, 0);
        pnlStatsSectionIntro.Controls.Add(lblStatsSubtitle, 0, 1);
        pnlStatsSectionIntro.Dock = DockStyle.Fill;
        pnlStatsSectionIntro.Location = new Point(19, 15);
        pnlStatsSectionIntro.Name = "pnlStatsSectionIntro";
        pnlStatsSectionIntro.RowCount = 2;
        pnlStatsSectionIntro.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
        pnlStatsSectionIntro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        pnlStatsSectionIntro.Size = new Size(358, 24);
        pnlStatsSectionIntro.TabIndex = 0;
        // 
        // lblStatsHeading
        // 
        lblStatsHeading.BackColor = Color.Transparent;
        lblStatsHeading.Dock = DockStyle.Fill;
        lblStatsHeading.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatsHeading.ForeColor = Color.FromArgb(235, 241, 250);
        lblStatsHeading.Location = new Point(3, 0);
        lblStatsHeading.Name = "lblStatsHeading";
        lblStatsHeading.Size = new Size(352, 22);
        lblStatsHeading.TabIndex = 0;
        lblStatsHeading.Text = "CURRENT VALUES";
        // 
        // lblStatsSubtitle
        // 
        lblStatsSubtitle.BackColor = Color.Transparent;
        lblStatsSubtitle.Dock = DockStyle.Fill;
        lblStatsSubtitle.Font = new Font("Segoe UI", 8.5F);
        lblStatsSubtitle.ForeColor = Color.FromArgb(145, 163, 189);
        lblStatsSubtitle.Location = new Point(3, 22);
        lblStatsSubtitle.Name = "lblStatsSubtitle";
        lblStatsSubtitle.Size = new Size(352, 2);
        lblStatsSubtitle.TabIndex = 1;
        lblStatsSubtitle.Text = "Little-endian Int32 read directly from the save.";
        // 
        // pnlScrollHost
        // 
        pnlScrollHost.AutoScroll = true;
        pnlScrollHost.BackColor = Color.FromArgb(23, 36, 60);
        pnlScrollHost.Controls.Add(_statsTable);
        pnlScrollHost.Dock = DockStyle.Fill;
        pnlScrollHost.Location = new Point(19, 45);
        pnlScrollHost.Name = "pnlScrollHost";
        pnlScrollHost.Size = new Size(358, 294);
        pnlScrollHost.TabIndex = 1;
        // 
        // _statsTable
        // 
        _statsTable.BackColor = Color.FromArgb(23, 36, 60);
        _statsTable.ColumnCount = 2;
        _statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
        _statsTable.Controls.Add(lblStatNameBinding, 0, 0);
        _statsTable.Controls.Add(lblStatValueBinding, 1, 0);
        _statsTable.Controls.Add(lblStatNameRank, 0, 1);
        _statsTable.Controls.Add(lblStatValueRank, 1, 1);
        _statsTable.Controls.Add(lblStatNameCoop, 0, 2);
        _statsTable.Controls.Add(lblStatValueCoop, 1, 2);
        _statsTable.Controls.Add(lblStatNameJuju, 0, 3);
        _statsTable.Controls.Add(lblStatValueJuju, 1, 3);
        _statsTable.Controls.Add(lblStatNameTasks, 0, 4);
        _statsTable.Controls.Add(lblStatValueTasks, 1, 4);
        _statsTable.Controls.Add(lblStatNameSkill, 0, 5);
        _statsTable.Controls.Add(lblStatValueSkill, 1, 5);
        _statsTable.Controls.Add(lblStatNameCoOpExp, 0, 6);
        _statsTable.Controls.Add(lblStatValueCoOpExp, 1, 6);
        _statsTable.Dock = DockStyle.Fill;
        _statsTable.Location = new Point(0, 0);
        _statsTable.Name = "_statsTable";
        _statsTable.RowCount = 7;
        _statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
        _statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
        _statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
        _statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
        _statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
        _statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
        _statsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
        _statsTable.Size = new Size(358, 294);
        _statsTable.TabIndex = 0;
        // 
        // lblStatNameBinding
        // 
        lblStatNameBinding.BackColor = Color.Transparent;
        lblStatNameBinding.Dock = DockStyle.Fill;
        lblStatNameBinding.Font = new Font("Segoe UI", 9F);
        lblStatNameBinding.ForeColor = Color.FromArgb(145, 163, 189);
        lblStatNameBinding.Location = new Point(3, 0);
        lblStatNameBinding.Name = "lblStatNameBinding";
        lblStatNameBinding.Size = new Size(252, 31);
        lblStatNameBinding.TabIndex = 0;
        lblStatNameBinding.Text = "Binding Vows Co-op Won";
        lblStatNameBinding.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatValueBinding
        // 
        lblStatValueBinding.BackColor = Color.Transparent;
        lblStatValueBinding.Dock = DockStyle.Fill;
        lblStatValueBinding.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatValueBinding.ForeColor = Color.FromArgb(235, 241, 250);
        lblStatValueBinding.Location = new Point(261, 0);
        lblStatValueBinding.Name = "lblStatValueBinding";
        lblStatValueBinding.Size = new Size(94, 31);
        lblStatValueBinding.TabIndex = 1;
        lblStatValueBinding.Text = "—";
        lblStatValueBinding.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblStatNameRank
        // 
        lblStatNameRank.BackColor = Color.Transparent;
        lblStatNameRank.Dock = DockStyle.Fill;
        lblStatNameRank.Font = new Font("Segoe UI", 9F);
        lblStatNameRank.ForeColor = Color.FromArgb(145, 163, 189);
        lblStatNameRank.Location = new Point(3, 31);
        lblStatNameRank.Name = "lblStatNameRank";
        lblStatNameRank.Size = new Size(252, 31);
        lblStatNameRank.TabIndex = 0;
        lblStatNameRank.Text = "Rank S Co-op Won";
        lblStatNameRank.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatValueRank
        // 
        lblStatValueRank.BackColor = Color.Transparent;
        lblStatValueRank.Dock = DockStyle.Fill;
        lblStatValueRank.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatValueRank.ForeColor = Color.FromArgb(235, 241, 250);
        lblStatValueRank.Location = new Point(261, 31);
        lblStatValueRank.Name = "lblStatValueRank";
        lblStatValueRank.Size = new Size(94, 31);
        lblStatValueRank.TabIndex = 1;
        lblStatValueRank.Text = "—";
        lblStatValueRank.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblStatNameCoop
        // 
        lblStatNameCoop.BackColor = Color.Transparent;
        lblStatNameCoop.Dock = DockStyle.Fill;
        lblStatNameCoop.Font = new Font("Segoe UI", 9F);
        lblStatNameCoop.ForeColor = Color.FromArgb(145, 163, 189);
        lblStatNameCoop.Location = new Point(3, 62);
        lblStatNameCoop.Name = "lblStatNameCoop";
        lblStatNameCoop.Size = new Size(252, 31);
        lblStatNameCoop.TabIndex = 0;
        lblStatNameCoop.Text = "Co-op Completions";
        lblStatNameCoop.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatValueCoop
        // 
        lblStatValueCoop.BackColor = Color.Transparent;
        lblStatValueCoop.Dock = DockStyle.Fill;
        lblStatValueCoop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatValueCoop.ForeColor = Color.FromArgb(235, 241, 250);
        lblStatValueCoop.Location = new Point(261, 62);
        lblStatValueCoop.Name = "lblStatValueCoop";
        lblStatValueCoop.Size = new Size(94, 31);
        lblStatValueCoop.TabIndex = 1;
        lblStatValueCoop.Text = "—";
        lblStatValueCoop.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblStatNameJuju
        // 
        lblStatNameJuju.BackColor = Color.Transparent;
        lblStatNameJuju.Dock = DockStyle.Fill;
        lblStatNameJuju.Font = new Font("Segoe UI", 9F);
        lblStatNameJuju.ForeColor = Color.FromArgb(145, 163, 189);
        lblStatNameJuju.Location = new Point(3, 93);
        lblStatNameJuju.Name = "lblStatNameJuju";
        lblStatNameJuju.Size = new Size(252, 31);
        lblStatNameJuju.TabIndex = 0;
        lblStatNameJuju.Text = "Juju Points";
        lblStatNameJuju.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatValueJuju
        // 
        lblStatValueJuju.BackColor = Color.Transparent;
        lblStatValueJuju.Dock = DockStyle.Fill;
        lblStatValueJuju.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatValueJuju.ForeColor = Color.FromArgb(235, 241, 250);
        lblStatValueJuju.Location = new Point(261, 93);
        lblStatValueJuju.Name = "lblStatValueJuju";
        lblStatValueJuju.Size = new Size(94, 31);
        lblStatValueJuju.TabIndex = 1;
        lblStatValueJuju.Text = "—";
        lblStatValueJuju.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblStatNameTasks
        // 
        lblStatNameTasks.BackColor = Color.Transparent;
        lblStatNameTasks.Dock = DockStyle.Fill;
        lblStatNameTasks.Font = new Font("Segoe UI", 9F);
        lblStatNameTasks.ForeColor = Color.FromArgb(145, 163, 189);
        lblStatNameTasks.Location = new Point(3, 124);
        lblStatNameTasks.Name = "lblStatNameTasks";
        lblStatNameTasks.Size = new Size(252, 31);
        lblStatNameTasks.TabIndex = 0;
        lblStatNameTasks.Text = "Tasks Completed";
        lblStatNameTasks.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatValueTasks
        // 
        lblStatValueTasks.BackColor = Color.Transparent;
        lblStatValueTasks.Dock = DockStyle.Fill;
        lblStatValueTasks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatValueTasks.ForeColor = Color.FromArgb(235, 241, 250);
        lblStatValueTasks.Location = new Point(261, 124);
        lblStatValueTasks.Name = "lblStatValueTasks";
        lblStatValueTasks.Size = new Size(94, 31);
        lblStatValueTasks.TabIndex = 1;
        lblStatValueTasks.Text = "—";
        lblStatValueTasks.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblStatNameSkill
        // 
        lblStatNameSkill.BackColor = Color.Transparent;
        lblStatNameSkill.Dock = DockStyle.Fill;
        lblStatNameSkill.Font = new Font("Segoe UI", 9F);
        lblStatNameSkill.ForeColor = Color.FromArgb(145, 163, 189);
        lblStatNameSkill.Location = new Point(3, 155);
        lblStatNameSkill.Name = "lblStatNameSkill";
        lblStatNameSkill.Size = new Size(252, 31);
        lblStatNameSkill.TabIndex = 0;
        lblStatNameSkill.Text = "Skill Level";
        lblStatNameSkill.TextAlign = ContentAlignment.MiddleLeft;
        lblStatNameSkill.Click += lblStatNameSkill_Click;
        // 
        // lblStatValueSkill
        // 
        lblStatValueSkill.BackColor = Color.Transparent;
        lblStatValueSkill.Dock = DockStyle.Fill;
        lblStatValueSkill.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatValueSkill.ForeColor = Color.FromArgb(235, 241, 250);
        lblStatValueSkill.Location = new Point(261, 155);
        lblStatValueSkill.Name = "lblStatValueSkill";
        lblStatValueSkill.Size = new Size(94, 31);
        lblStatValueSkill.TabIndex = 1;
        lblStatValueSkill.Text = "—";
        lblStatValueSkill.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblStatNameCoOpExp
        // 
        lblStatNameCoOpExp.BackColor = Color.Transparent;
        lblStatNameCoOpExp.Dock = DockStyle.Fill;
        lblStatNameCoOpExp.Font = new Font("Segoe UI", 9F);
        lblStatNameCoOpExp.ForeColor = Color.FromArgb(145, 163, 189);
        lblStatNameCoOpExp.Location = new Point(3, 186);
        lblStatNameCoOpExp.Name = "lblStatNameCoOpExp";
        lblStatNameCoOpExp.Size = new Size(252, 108);
        lblStatNameCoOpExp.TabIndex = 0;
        lblStatNameCoOpExp.Text = "Co-op EXP Pool";
        lblStatNameCoOpExp.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatValueCoOpExp
        // 
        lblStatValueCoOpExp.BackColor = Color.Transparent;
        lblStatValueCoOpExp.Dock = DockStyle.Fill;
        lblStatValueCoOpExp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblStatValueCoOpExp.ForeColor = Color.FromArgb(235, 241, 250);
        lblStatValueCoOpExp.Location = new Point(261, 186);
        lblStatValueCoOpExp.Name = "lblStatValueCoOpExp";
        lblStatValueCoOpExp.Size = new Size(94, 108);
        lblStatValueCoOpExp.TabIndex = 1;
        lblStatValueCoOpExp.Text = "—";
        lblStatValueCoOpExp.TextAlign = ContentAlignment.MiddleRight;
        // 
        // pnlResetRow
        // 
        pnlResetRow.BackColor = Color.FromArgb(17, 27, 46);
        pnlResetRow.ColumnCount = 2;
        pnlResetRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlResetRow.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
        pnlResetRow.Controls.Add(_dirtyLabel, 0, 0);
        pnlResetRow.Controls.Add(_resetButton, 1, 0);
        pnlResetRow.Dock = DockStyle.Fill;
        pnlResetRow.Location = new Point(27, 569);
        pnlResetRow.Name = "pnlResetRow";
        pnlResetRow.RowCount = 1;
        pnlResetRow.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlResetRow.Size = new Size(400, 42);
        pnlResetRow.TabIndex = 3;
        // 
        // _dirtyLabel
        // 
        _dirtyLabel.Dock = DockStyle.Fill;
        _dirtyLabel.ForeColor = Color.FromArgb(145, 163, 189);
        _dirtyLabel.Location = new Point(3, 0);
        _dirtyLabel.Name = "_dirtyLabel";
        _dirtyLabel.Size = new Size(268, 42);
        _dirtyLabel.TabIndex = 0;
        _dirtyLabel.Text = "No file loaded";
        _dirtyLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // _resetButton
        // 
        _resetButton.BackColor = Color.FromArgb(127, 89, 119);
        _resetButton.Cursor = Cursors.Hand;
        _resetButton.FlatAppearance.BorderColor = Color.FromArgb(42, 60, 88);
        _resetButton.FlatStyle = FlatStyle.Flat;
        _resetButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        _resetButton.ForeColor = Color.FromArgb(235, 241, 250);
        _resetButton.Location = new Point(277, 3);
        _resetButton.Name = "_resetButton";
        _resetButton.Size = new Size(116, 34);
        _resetButton.TabIndex = 1;
        _resetButton.Text = "Reset edits";
        _resetButton.UseVisualStyleBackColor = false;
        _resetButton.Click += ResetButton_Click;
        // 
        // pnlStatusBar
        // 
        pnlStatusBar.BackColor = Color.FromArgb(9, 15, 29);
        pnlStatusBar.ColumnCount = 2;
        pnlStatusBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        pnlStatusBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 290F));
        pnlStatusBar.Controls.Add(_statusLabel, 0, 0);
        pnlStatusBar.Controls.Add(lblFooter, 1, 0);
        pnlStatusBar.Dock = DockStyle.Fill;
        pnlStatusBar.Location = new Point(31, 775);
        pnlStatusBar.Name = "pnlStatusBar";
        pnlStatusBar.RowCount = 1;
        pnlStatusBar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        pnlStatusBar.Size = new Size(1118, 24);
        pnlStatusBar.TabIndex = 2;
        // 
        // _statusLabel
        // 
        _statusLabel.Dock = DockStyle.Fill;
        _statusLabel.ForeColor = Color.FromArgb(145, 163, 189);
        _statusLabel.Location = new Point(3, 0);
        _statusLabel.Name = "_statusLabel";
        _statusLabel.Size = new Size(822, 24);
        _statusLabel.TabIndex = 0;
        _statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblFooter
        // 
        lblFooter.BackColor = Color.Transparent;
        lblFooter.Dock = DockStyle.Fill;
        lblFooter.Font = new Font("Segoe UI", 8.5F);
        lblFooter.ForeColor = Color.FromArgb(145, 163, 189);
        lblFooter.Location = new Point(831, 0);
        lblFooter.Name = "lblFooter";
        lblFooter.Size = new Size(284, 24);
        lblFooter.TabIndex = 1;
        lblFooter.Text = "PS4  ·  UE4 save format  ·  MD5 protected";
        lblFooter.TextAlign = ContentAlignment.MiddleRight;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(9, 15, 29);
        ClientSize = new Size(1180, 820);
        Controls.Add(pnlRoot);
        Font = new Font("Segoe UI", 9.5F);
        ForeColor = Color.FromArgb(235, 241, 250);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(1000, 700);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cursed Clash Save Editor";
        pnlRoot.ResumeLayout(false);
        pnlHeader.ResumeLayout(false);
        pnlTitleStack.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        pnlHeaderActions.ResumeLayout(false);
        pnlContent.ResumeLayout(false);
        pnlEditorCard.ResumeLayout(false);
        pnlEditorLayout.ResumeLayout(false);
        pnlSectionIntroEditor.ResumeLayout(false);
        pnlIndependentActions.ResumeLayout(false);
        pnlActionRow1.ResumeLayout(false);
        pnlActionText1.ResumeLayout(false);
        pnlActionRow2.ResumeLayout(false);
        pnlActionText2.ResumeLayout(false);
        pnlCoOpRow.ResumeLayout(false);
        pnlCoOpText.ResumeLayout(false);
        pnlActionRow4.ResumeLayout(false);
        pnlActionText4.ResumeLayout(false);
        pnlActionRow5.ResumeLayout(false);
        pnlActionText5.ResumeLayout(false);
        pnlPresetGroups.ResumeLayout(false);
        pnlTaskPresetRow.ResumeLayout(false);
        pnlTaskPresetText.ResumeLayout(false);
        pnlSkillPresetRow.ResumeLayout(false);
        pnlSkillPresetText.ResumeLayout(false);
        pnlInspectorCard.ResumeLayout(false);
        pnlInspectorLayout.ResumeLayout(false);
        pnlChecksumCard.ResumeLayout(false);
        pnlChecksumDetails.ResumeLayout(false);
        pnlFileCard.ResumeLayout(false);
        pnlStatsCard.ResumeLayout(false);
        pnlStatsCardLayout.ResumeLayout(false);
        pnlStatsSectionIntro.ResumeLayout(false);
        pnlScrollHost.ResumeLayout(false);
        _statsTable.ResumeLayout(false);
        pnlResetRow.ResumeLayout(false);
        pnlStatusBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
}
