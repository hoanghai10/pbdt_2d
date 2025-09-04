namespace PBDT_2D.Forms
{
    partial class VS_PrintPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VS_PrintPreview));
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutSettings = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.header_cbDraw = new System.Windows.Forms.CheckBox();
            this.header_cboAlign = new System.Windows.Forms.ComboBox();
            this.header_btnFont = new System.Windows.Forms.Button();
            this.header_tbText = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.title_cbDraw = new System.Windows.Forms.CheckBox();
            this.title_cboAlign = new System.Windows.Forms.ComboBox();
            this.title_tbText = new System.Windows.Forms.RichTextBox();
            this.title_btnFont = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.firstSentences_cbDraw = new System.Windows.Forms.CheckBox();
            this.firstSentences_cboAlign = new System.Windows.Forms.ComboBox();
            this.firstSentences_tbText = new System.Windows.Forms.RichTextBox();
            this.firstSentences_btnFont = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.layoutSettings_Content = new System.Windows.Forms.TableLayoutPanel();
            this.grdSetupHeaders = new System.Windows.Forms.DataGridView();
            this.HeaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.content_btnDataFont = new System.Windows.Forms.Button();
            this.content_btnHeaderFont = new System.Windows.Forms.Button();
            this.content_cboAlign = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.footer_cboType = new System.Windows.Forms.ComboBox();
            this.footer_cbDraw = new System.Windows.Forms.CheckBox();
            this.footer_btnFont = new System.Windows.Forms.Button();
            this.footer_cboAlign = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.others_rdLanscape = new System.Windows.Forms.RadioButton();
            this.others_rdPortrait = new System.Windows.Forms.RadioButton();
            this.layoutSettings_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnSetAsDefault = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.layoutPreview = new System.Windows.Forms.TableLayoutPanel();
            this.printPreview = new System.Windows.Forms.PrintPreviewControl();
            this.layoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.layoutMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.layoutSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.layoutSettings_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSetupHeaders)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.layoutSettings_Buttons.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.layoutPreview.SuspendLayout();
            this.layoutButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.groupBox1, 0, 0);
            this.layoutMain.Controls.Add(this.groupBox2, 1, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 1;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1232, 809);
            this.layoutMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutSettings);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 803);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt in";
            // 
            // layoutSettings
            // 
            this.layoutSettings.ColumnCount = 1;
            this.layoutSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSettings.Controls.Add(this.groupBox3, 0, 0);
            this.layoutSettings.Controls.Add(this.groupBox4, 0, 1);
            this.layoutSettings.Controls.Add(this.groupBox5, 0, 2);
            this.layoutSettings.Controls.Add(this.groupBox6, 0, 3);
            this.layoutSettings.Controls.Add(this.groupBox7, 0, 4);
            this.layoutSettings.Controls.Add(this.groupBox9, 0, 5);
            this.layoutSettings.Controls.Add(this.layoutSettings_Buttons, 0, 6);
            this.layoutSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSettings.Location = new System.Drawing.Point(3, 16);
            this.layoutSettings.Name = "layoutSettings";
            this.layoutSettings.RowCount = 7;
            this.layoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.layoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.layoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.layoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.layoutSettings.Size = new System.Drawing.Size(388, 784);
            this.layoutSettings.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.header_cbDraw);
            this.groupBox3.Controls.Add(this.header_cboAlign);
            this.groupBox3.Controls.Add(this.header_btnFont);
            this.groupBox3.Controls.Add(this.header_tbText);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 109);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đầu trang";
            // 
            // header_cbDraw
            // 
            this.header_cbDraw.AutoSize = true;
            this.header_cbDraw.Checked = true;
            this.header_cbDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.header_cbDraw.Location = new System.Drawing.Point(341, 79);
            this.header_cbDraw.Name = "header_cbDraw";
            this.header_cbDraw.Size = new System.Drawing.Size(35, 17);
            this.header_cbDraw.TabIndex = 3;
            this.header_cbDraw.Text = "In";
            this.header_cbDraw.UseVisualStyleBackColor = true;
            // 
            // header_cboAlign
            // 
            this.header_cboAlign.FormattingEnabled = true;
            this.header_cboAlign.Items.AddRange(new object[] {
            "Trái",
            "Giữa",
            "Phải"});
            this.header_cboAlign.Location = new System.Drawing.Point(71, 76);
            this.header_cboAlign.Name = "header_cboAlign";
            this.header_cboAlign.Size = new System.Drawing.Size(55, 21);
            this.header_cboAlign.TabIndex = 2;
            this.header_cboAlign.SelectedIndexChanged += new System.EventHandler(this.header_cboAlign_SelectedIndexChanged);
            // 
            // header_btnFont
            // 
            this.header_btnFont.Location = new System.Drawing.Point(7, 75);
            this.header_btnFont.Name = "header_btnFont";
            this.header_btnFont.Size = new System.Drawing.Size(58, 23);
            this.header_btnFont.TabIndex = 1;
            this.header_btnFont.Text = "Font";
            this.header_btnFont.UseVisualStyleBackColor = true;
            this.header_btnFont.Click += new System.EventHandler(this.header_btnFont_Click);
            // 
            // header_tbText
            // 
            this.header_tbText.Location = new System.Drawing.Point(7, 20);
            this.header_tbText.Name = "header_tbText";
            this.header_tbText.Size = new System.Drawing.Size(369, 50);
            this.header_tbText.TabIndex = 0;
            this.header_tbText.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.title_cbDraw);
            this.groupBox4.Controls.Add(this.title_cboAlign);
            this.groupBox4.Controls.Add(this.title_tbText);
            this.groupBox4.Controls.Add(this.title_btnFont);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 109);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiêu đề";
            // 
            // title_cbDraw
            // 
            this.title_cbDraw.AutoSize = true;
            this.title_cbDraw.Checked = true;
            this.title_cbDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.title_cbDraw.Location = new System.Drawing.Point(341, 77);
            this.title_cbDraw.Name = "title_cbDraw";
            this.title_cbDraw.Size = new System.Drawing.Size(35, 17);
            this.title_cbDraw.TabIndex = 4;
            this.title_cbDraw.Text = "In";
            this.title_cbDraw.UseVisualStyleBackColor = true;
            // 
            // title_cboAlign
            // 
            this.title_cboAlign.FormattingEnabled = true;
            this.title_cboAlign.Items.AddRange(new object[] {
            "Trái",
            "Giữa",
            "Phải"});
            this.title_cboAlign.Location = new System.Drawing.Point(71, 75);
            this.title_cboAlign.Name = "title_cboAlign";
            this.title_cboAlign.Size = new System.Drawing.Size(55, 21);
            this.title_cboAlign.TabIndex = 5;
            this.title_cboAlign.SelectedIndexChanged += new System.EventHandler(this.title_cboAlign_SelectedIndexChanged);
            // 
            // title_tbText
            // 
            this.title_tbText.Location = new System.Drawing.Point(7, 19);
            this.title_tbText.Name = "title_tbText";
            this.title_tbText.Size = new System.Drawing.Size(369, 50);
            this.title_tbText.TabIndex = 3;
            this.title_tbText.Text = "";
            // 
            // title_btnFont
            // 
            this.title_btnFont.Location = new System.Drawing.Point(7, 74);
            this.title_btnFont.Name = "title_btnFont";
            this.title_btnFont.Size = new System.Drawing.Size(58, 23);
            this.title_btnFont.TabIndex = 4;
            this.title_btnFont.Text = "Font";
            this.title_btnFont.UseVisualStyleBackColor = true;
            this.title_btnFont.Click += new System.EventHandler(this.title_btnFont_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.firstSentences_cbDraw);
            this.groupBox5.Controls.Add(this.firstSentences_cboAlign);
            this.groupBox5.Controls.Add(this.firstSentences_tbText);
            this.groupBox5.Controls.Add(this.firstSentences_btnFont);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 109);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Lời mở đầu";
            // 
            // firstSentences_cbDraw
            // 
            this.firstSentences_cbDraw.AutoSize = true;
            this.firstSentences_cbDraw.Checked = true;
            this.firstSentences_cbDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstSentences_cbDraw.Location = new System.Drawing.Point(341, 78);
            this.firstSentences_cbDraw.Name = "firstSentences_cbDraw";
            this.firstSentences_cbDraw.Size = new System.Drawing.Size(35, 17);
            this.firstSentences_cbDraw.TabIndex = 9;
            this.firstSentences_cbDraw.Text = "In";
            this.firstSentences_cbDraw.UseVisualStyleBackColor = true;
            // 
            // firstSentences_cboAlign
            // 
            this.firstSentences_cboAlign.FormattingEnabled = true;
            this.firstSentences_cboAlign.Items.AddRange(new object[] {
            "Trái",
            "Giữa",
            "Phải"});
            this.firstSentences_cboAlign.Location = new System.Drawing.Point(71, 75);
            this.firstSentences_cboAlign.Name = "firstSentences_cboAlign";
            this.firstSentences_cboAlign.Size = new System.Drawing.Size(55, 21);
            this.firstSentences_cboAlign.TabIndex = 8;
            this.firstSentences_cboAlign.SelectedIndexChanged += new System.EventHandler(this.firstSentences_cboAlign_SelectedIndexChanged);
            // 
            // firstSentences_tbText
            // 
            this.firstSentences_tbText.Location = new System.Drawing.Point(7, 19);
            this.firstSentences_tbText.Name = "firstSentences_tbText";
            this.firstSentences_tbText.Size = new System.Drawing.Size(369, 50);
            this.firstSentences_tbText.TabIndex = 6;
            this.firstSentences_tbText.Text = "";
            // 
            // firstSentences_btnFont
            // 
            this.firstSentences_btnFont.Location = new System.Drawing.Point(7, 74);
            this.firstSentences_btnFont.Name = "firstSentences_btnFont";
            this.firstSentences_btnFont.Size = new System.Drawing.Size(58, 23);
            this.firstSentences_btnFont.TabIndex = 7;
            this.firstSentences_btnFont.Text = "Font";
            this.firstSentences_btnFont.UseVisualStyleBackColor = true;
            this.firstSentences_btnFont.Click += new System.EventHandler(this.firstSentences_btnFont_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.layoutSettings_Content);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 348);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(382, 268);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nội dung";
            // 
            // layoutSettings_Content
            // 
            this.layoutSettings_Content.ColumnCount = 1;
            this.layoutSettings_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSettings_Content.Controls.Add(this.grdSetupHeaders, 0, 0);
            this.layoutSettings_Content.Controls.Add(this.groupBox8, 0, 1);
            this.layoutSettings_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSettings_Content.Location = new System.Drawing.Point(3, 16);
            this.layoutSettings_Content.Name = "layoutSettings_Content";
            this.layoutSettings_Content.RowCount = 2;
            this.layoutSettings_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSettings_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutSettings_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutSettings_Content.Size = new System.Drawing.Size(376, 249);
            this.layoutSettings_Content.TabIndex = 1;
            // 
            // grdSetupHeaders
            // 
            this.grdSetupHeaders.AllowUserToResizeRows = false;
            this.grdSetupHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSetupHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderId,
            this.HeaderDisplay,
            this.HeaderWidth,
            this.IsSelected});
            this.grdSetupHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSetupHeaders.Location = new System.Drawing.Point(3, 3);
            this.grdSetupHeaders.Name = "grdSetupHeaders";
            this.grdSetupHeaders.RowHeadersVisible = false;
            this.grdSetupHeaders.Size = new System.Drawing.Size(370, 193);
            this.grdSetupHeaders.TabIndex = 0;
            this.grdSetupHeaders.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdSetupHeaders_CellValidating);
            // 
            // HeaderId
            // 
            this.HeaderId.DataPropertyName = "HeaderId";
            this.HeaderId.HeaderText = "HeaderId";
            this.HeaderId.Name = "HeaderId";
            this.HeaderId.Visible = false;
            // 
            // HeaderDisplay
            // 
            this.HeaderDisplay.DataPropertyName = "HeaderDisplay";
            this.HeaderDisplay.HeaderText = "Tên cột";
            this.HeaderDisplay.MinimumWidth = 150;
            this.HeaderDisplay.Name = "HeaderDisplay";
            this.HeaderDisplay.Width = 150;
            // 
            // HeaderWidth
            // 
            this.HeaderWidth.DataPropertyName = "HeaderWidth";
            this.HeaderWidth.HeaderText = "Độ rộng";
            this.HeaderWidth.MinimumWidth = 80;
            this.HeaderWidth.Name = "HeaderWidth";
            this.HeaderWidth.Width = 80;
            // 
            // IsSelected
            // 
            this.IsSelected.DataPropertyName = "IsSelected";
            this.IsSelected.HeaderText = "Chọn";
            this.IsSelected.MinimumWidth = 45;
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.Width = 45;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.content_btnDataFont);
            this.groupBox8.Controls.Add(this.content_btnHeaderFont);
            this.groupBox8.Controls.Add(this.content_cboAlign);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 202);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(370, 44);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            // 
            // content_btnDataFont
            // 
            this.content_btnDataFont.Location = new System.Drawing.Point(87, 15);
            this.content_btnDataFont.Name = "content_btnDataFont";
            this.content_btnDataFont.Size = new System.Drawing.Size(80, 23);
            this.content_btnDataFont.TabIndex = 16;
            this.content_btnDataFont.Text = "Font nội dung";
            this.content_btnDataFont.UseVisualStyleBackColor = true;
            this.content_btnDataFont.Click += new System.EventHandler(this.content_btnDataFont_Click);
            // 
            // content_btnHeaderFont
            // 
            this.content_btnHeaderFont.Location = new System.Drawing.Point(1, 15);
            this.content_btnHeaderFont.Name = "content_btnHeaderFont";
            this.content_btnHeaderFont.Size = new System.Drawing.Size(80, 23);
            this.content_btnHeaderFont.TabIndex = 14;
            this.content_btnHeaderFont.Text = "Font tiêu đề";
            this.content_btnHeaderFont.UseVisualStyleBackColor = true;
            this.content_btnHeaderFont.Click += new System.EventHandler(this.content_btnHeaderFont_Click);
            // 
            // content_cboAlign
            // 
            this.content_cboAlign.FormattingEnabled = true;
            this.content_cboAlign.Items.AddRange(new object[] {
            "Trái",
            "Giữa",
            "Phải"});
            this.content_cboAlign.Location = new System.Drawing.Point(173, 16);
            this.content_cboAlign.Name = "content_cboAlign";
            this.content_cboAlign.Size = new System.Drawing.Size(55, 21);
            this.content_cboAlign.TabIndex = 15;
            this.content_cboAlign.SelectedIndexChanged += new System.EventHandler(this.content_cboAlign_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.footer_cboType);
            this.groupBox7.Controls.Add(this.footer_cbDraw);
            this.groupBox7.Controls.Add(this.footer_btnFont);
            this.groupBox7.Controls.Add(this.footer_cboAlign);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 622);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(382, 54);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cuối trang";
            // 
            // footer_cboType
            // 
            this.footer_cboType.FormattingEnabled = true;
            this.footer_cboType.Items.AddRange(new object[] {
            "#",
            "Page #",
            "Page #|#",
            "Page # of #",
            "Trang #",
            "Trang #|#"});
            this.footer_cboType.Location = new System.Drawing.Point(132, 20);
            this.footer_cboType.Name = "footer_cboType";
            this.footer_cboType.Size = new System.Drawing.Size(105, 21);
            this.footer_cboType.TabIndex = 13;
            this.footer_cboType.SelectedIndexChanged += new System.EventHandler(this.footer_cboType_SelectedIndexChanged);
            // 
            // footer_cbDraw
            // 
            this.footer_cbDraw.AutoSize = true;
            this.footer_cbDraw.Checked = true;
            this.footer_cbDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.footer_cbDraw.Location = new System.Drawing.Point(341, 23);
            this.footer_cbDraw.Name = "footer_cbDraw";
            this.footer_cbDraw.Size = new System.Drawing.Size(35, 17);
            this.footer_cbDraw.TabIndex = 12;
            this.footer_cbDraw.Text = "In";
            this.footer_cbDraw.UseVisualStyleBackColor = true;
            // 
            // footer_btnFont
            // 
            this.footer_btnFont.Location = new System.Drawing.Point(7, 19);
            this.footer_btnFont.Name = "footer_btnFont";
            this.footer_btnFont.Size = new System.Drawing.Size(58, 23);
            this.footer_btnFont.TabIndex = 10;
            this.footer_btnFont.Text = "Font";
            this.footer_btnFont.UseVisualStyleBackColor = true;
            this.footer_btnFont.Click += new System.EventHandler(this.footer_btnFont_Click);
            // 
            // footer_cboAlign
            // 
            this.footer_cboAlign.FormattingEnabled = true;
            this.footer_cboAlign.Items.AddRange(new object[] {
            "Trái",
            "Giữa",
            "Phải"});
            this.footer_cboAlign.Location = new System.Drawing.Point(71, 20);
            this.footer_cboAlign.Name = "footer_cboAlign";
            this.footer_cboAlign.Size = new System.Drawing.Size(55, 21);
            this.footer_cboAlign.TabIndex = 11;
            this.footer_cboAlign.SelectedIndexChanged += new System.EventHandler(this.footer_cboAlign_SelectedIndexChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.others_rdLanscape);
            this.groupBox9.Controls.Add(this.others_rdPortrait);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 682);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(382, 44);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Cài đặt khác";
            // 
            // others_rdLanscape
            // 
            this.others_rdLanscape.AutoSize = true;
            this.others_rdLanscape.Checked = true;
            this.others_rdLanscape.Location = new System.Drawing.Point(71, 19);
            this.others_rdLanscape.Name = "others_rdLanscape";
            this.others_rdLanscape.Size = new System.Drawing.Size(67, 17);
            this.others_rdLanscape.TabIndex = 1;
            this.others_rdLanscape.TabStop = true;
            this.others_rdLanscape.Text = "In ngang";
            this.others_rdLanscape.UseVisualStyleBackColor = true;
            this.others_rdLanscape.CheckedChanged += new System.EventHandler(this.others_PageType_CheckedChanged);
            // 
            // others_rdPortrait
            // 
            this.others_rdPortrait.AutoSize = true;
            this.others_rdPortrait.Location = new System.Drawing.Point(7, 20);
            this.others_rdPortrait.Name = "others_rdPortrait";
            this.others_rdPortrait.Size = new System.Drawing.Size(55, 17);
            this.others_rdPortrait.TabIndex = 0;
            this.others_rdPortrait.Text = "In dọc";
            this.others_rdPortrait.UseVisualStyleBackColor = true;
            this.others_rdPortrait.CheckedChanged += new System.EventHandler(this.others_PageType_CheckedChanged);
            // 
            // layoutSettings_Buttons
            // 
            this.layoutSettings_Buttons.ColumnCount = 4;
            this.layoutSettings_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.layoutSettings_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.layoutSettings_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.layoutSettings_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSettings_Buttons.Controls.Add(this.btnLoadSettings, 0, 0);
            this.layoutSettings_Buttons.Controls.Add(this.btnSaveSettings, 1, 0);
            this.layoutSettings_Buttons.Controls.Add(this.btnSetAsDefault, 3, 0);
            this.layoutSettings_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSettings_Buttons.Location = new System.Drawing.Point(3, 732);
            this.layoutSettings_Buttons.Name = "layoutSettings_Buttons";
            this.layoutSettings_Buttons.RowCount = 1;
            this.layoutSettings_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSettings_Buttons.Size = new System.Drawing.Size(382, 49);
            this.layoutSettings_Buttons.TabIndex = 7;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadSettings.Image")));
            this.btnLoadSettings.Location = new System.Drawing.Point(3, 3);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(106, 43);
            this.btnLoadSettings.TabIndex = 0;
            this.btnLoadSettings.Text = "Đọc thiết lập";
            this.btnLoadSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSettings.Image")));
            this.btnSaveSettings.Location = new System.Drawing.Point(115, 3);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(107, 43);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Lưu thiết lập";
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnSetAsDefault
            // 
            this.btnSetAsDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetAsDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAsDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnSetAsDefault.Image")));
            this.btnSetAsDefault.Location = new System.Drawing.Point(266, 3);
            this.btnSetAsDefault.Name = "btnSetAsDefault";
            this.btnSetAsDefault.Size = new System.Drawing.Size(113, 43);
            this.btnSetAsDefault.TabIndex = 2;
            this.btnSetAsDefault.Text = "Đặt làm mặc định";
            this.btnSetAsDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetAsDefault.UseVisualStyleBackColor = true;
            this.btnSetAsDefault.Click += new System.EventHandler(this.btnSetAsDefault_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.layoutPreview);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(403, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 803);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem trước";
            // 
            // layoutPreview
            // 
            this.layoutPreview.ColumnCount = 1;
            this.layoutPreview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPreview.Controls.Add(this.printPreview, 0, 0);
            this.layoutPreview.Controls.Add(this.layoutButtons, 0, 1);
            this.layoutPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPreview.Location = new System.Drawing.Point(3, 16);
            this.layoutPreview.Name = "layoutPreview";
            this.layoutPreview.RowCount = 2;
            this.layoutPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPreview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutPreview.Size = new System.Drawing.Size(820, 784);
            this.layoutPreview.TabIndex = 1;
            // 
            // printPreview
            // 
            this.printPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreview.Location = new System.Drawing.Point(3, 3);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(814, 728);
            this.printPreview.TabIndex = 0;
            // 
            // layoutButtons
            // 
            this.layoutButtons.ColumnCount = 6;
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutButtons.Controls.Add(this.btnPreview, 0, 0);
            this.layoutButtons.Controls.Add(this.btnZoomIn, 1, 0);
            this.layoutButtons.Controls.Add(this.btnZoomOut, 2, 0);
            this.layoutButtons.Controls.Add(this.btnPrint, 5, 0);
            this.layoutButtons.Controls.Add(this.btnExportToPDF, 4, 0);
            this.layoutButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutButtons.Location = new System.Drawing.Point(3, 737);
            this.layoutButtons.Name = "layoutButtons";
            this.layoutButtons.RowCount = 1;
            this.layoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutButtons.Size = new System.Drawing.Size(814, 44);
            this.layoutButtons.TabIndex = 1;
            // 
            // btnPreview
            // 
            this.btnPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.Location = new System.Drawing.Point(8, 3);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(84, 38);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Xem thử";
            this.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackgroundImage = global::PBDT_2D.MyResource.zoom_in_1;
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomIn.Location = new System.Drawing.Point(105, 5);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(40, 34);
            this.btnZoomIn.TabIndex = 1;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackgroundImage = global::PBDT_2D.MyResource.zoom_out_1;
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZoomOut.Location = new System.Drawing.Point(155, 5);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(5);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(40, 34);
            this.btnZoomOut.TabIndex = 2;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(722, 3);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 38);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportToPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToPDF.Image")));
            this.btnExportToPDF.Location = new System.Drawing.Point(572, 3);
            this.btnExportToPDF.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(134, 38);
            this.btnExportToPDF.TabIndex = 4;
            this.btnExportToPDF.Text = "Lưu dạng PDF";
            this.btnExportToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportToPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // VS_PrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 809);
            this.Controls.Add(this.layoutMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "VS_PrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In kết quả bắn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.layoutMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.layoutSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.layoutSettings_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSetupHeaders)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.layoutSettings_Buttons.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.layoutPreview.ResumeLayout(false);
            this.layoutButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel layoutSettings;
        private System.Windows.Forms.DataGridView grdSetupHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderWidth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.PrintPreviewControl printPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel layoutPreview;
        private System.Windows.Forms.TableLayoutPanel layoutButtons;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.RichTextBox header_tbText;
        private System.Windows.Forms.Button header_btnFont;
        private System.Windows.Forms.ComboBox header_cboAlign;
        private System.Windows.Forms.ComboBox title_cboAlign;
        private System.Windows.Forms.RichTextBox title_tbText;
        private System.Windows.Forms.Button title_btnFont;
        private System.Windows.Forms.ComboBox firstSentences_cboAlign;
        private System.Windows.Forms.RichTextBox firstSentences_tbText;
        private System.Windows.Forms.Button firstSentences_btnFont;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.CheckBox header_cbDraw;
        private System.Windows.Forms.CheckBox title_cbDraw;
        private System.Windows.Forms.CheckBox firstSentences_cbDraw;
        private System.Windows.Forms.CheckBox footer_cbDraw;
        private System.Windows.Forms.Button footer_btnFont;
        private System.Windows.Forms.ComboBox footer_cboAlign;
        private System.Windows.Forms.ComboBox footer_cboType;
        private System.Windows.Forms.TableLayoutPanel layoutSettings_Content;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button content_btnHeaderFont;
        private System.Windows.Forms.ComboBox content_cboAlign;
        private System.Windows.Forms.Button content_btnDataFont;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton others_rdLanscape;
        private System.Windows.Forms.RadioButton others_rdPortrait;
        private System.Windows.Forms.TableLayoutPanel layoutSettings_Buttons;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnSetAsDefault;
        private System.Windows.Forms.Button btnExportToPDF;
    }
}