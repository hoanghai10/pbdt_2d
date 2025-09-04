namespace PBDT_2D.Forms
{
    partial class VS_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VS_Search));
            layoutMain = new TableLayoutPanel();
            layoutLeftPanel = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            layoutConditions = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            layoutCond_Time = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            cond_dpFrom = new DateTimePicker();
            cond_dpTo = new DateTimePicker();
            groupBox4 = new GroupBox();
            layoutCond_Ex = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            cond_cboGunType = new ComboBox();
            cond_cboEx = new ComboBox();
            groupBox5 = new GroupBox();
            grdCrews = new DataGridView();
            KB_Id = new DataGridViewTextBoxColumn();
            KB_ThoiGianBatDau = new DataGridViewTextBoxColumn();
            KB_ThoiGianKetThuc = new DataGridViewTextBoxColumn();
            KB_IdBaiBan = new DataGridViewTextBoxColumn();
            KB_TenBaiBanFull = new DataGridViewTextBoxColumn();
            KB_IsSelected = new DataGridViewCheckBoxColumn();
            KB_IdNguoiDung = new DataGridViewTextBoxColumn();
            groupBox6 = new GroupBox();
            layoutCond_Teacher = new TableLayoutPanel();
            label5 = new Label();
            cond_cboTeacher = new ComboBox();
            groupBox2 = new GroupBox();
            layoutButtons = new TableLayoutPanel();
            btnSearch = new Button();
            btnPrint = new Button();
            grdSearchResult = new DataGridView();
            IdKetQua = new DataGridViewTextBoxColumn();
            IDBaiBan = new DataGridViewTextBoxColumn();
            TenBaiBanFull = new DataGridViewTextBoxColumn();
            TGBatDau = new DataGridViewTextBoxColumn();
            TGKetThuc = new DataGridViewTextBoxColumn();
            ND_Id = new DataGridViewTextBoxColumn();
            ND_Ten = new DataGridViewTextBoxColumn();
            ND_QuanHam = new DataGridViewTextBoxColumn();
            ND_ChucVu = new DataGridViewTextBoxColumn();
            ND_DonVi = new DataGridViewTextBoxColumn();
            ND_GhiChu = new DataGridViewTextBoxColumn();
            ND_IdSungBan = new DataGridViewTextBoxColumn();
            ND_ThanhTich = new DataGridViewTextBoxColumn();
            ND_TongDiem = new DataGridViewTextBoxColumn();
            ND_XepLoai = new DataGridViewTextBoxColumn();
            IsSelected = new DataGridViewCheckBoxColumn();
            layoutMain.SuspendLayout();
            layoutLeftPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            layoutConditions.SuspendLayout();
            groupBox3.SuspendLayout();
            layoutCond_Time.SuspendLayout();
            groupBox4.SuspendLayout();
            layoutCond_Ex.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCrews).BeginInit();
            groupBox6.SuspendLayout();
            layoutCond_Teacher.SuspendLayout();
            groupBox2.SuspendLayout();
            layoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSearchResult).BeginInit();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 408F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMain.Controls.Add(layoutLeftPanel, 0, 0);
            layoutMain.Controls.Add(grdSearchResult, 1, 0);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(4, 3, 4, 3);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 1;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(1148, 878);
            layoutMain.TabIndex = 0;
            // 
            // layoutLeftPanel
            // 
            layoutLeftPanel.BackColor = SystemColors.Control;
            layoutLeftPanel.ColumnCount = 1;
            layoutLeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutLeftPanel.Controls.Add(groupBox1, 0, 0);
            layoutLeftPanel.Controls.Add(groupBox2, 0, 1);
            layoutLeftPanel.Dock = DockStyle.Fill;
            layoutLeftPanel.Location = new Point(4, 3);
            layoutLeftPanel.Margin = new Padding(4, 3, 4, 3);
            layoutLeftPanel.Name = "layoutLeftPanel";
            layoutLeftPanel.RowCount = 2;
            layoutLeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutLeftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 173F));
            layoutLeftPanel.Size = new Size(400, 872);
            layoutLeftPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(layoutConditions);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(392, 693);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Điều kiện tìm kiếm";
            // 
            // layoutConditions
            // 
            layoutConditions.BackColor = SystemColors.Control;
            layoutConditions.ColumnCount = 1;
            layoutConditions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutConditions.Controls.Add(groupBox3, 0, 0);
            layoutConditions.Controls.Add(groupBox4, 0, 1);
            layoutConditions.Controls.Add(groupBox5, 0, 3);
            layoutConditions.Controls.Add(groupBox6, 0, 2);
            layoutConditions.Dock = DockStyle.Fill;
            layoutConditions.Location = new Point(4, 18);
            layoutConditions.Margin = new Padding(4, 3, 4, 3);
            layoutConditions.Name = "layoutConditions";
            layoutConditions.RowCount = 4;
            layoutConditions.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            layoutConditions.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            layoutConditions.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            layoutConditions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutConditions.Size = new Size(384, 672);
            layoutConditions.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(layoutCond_Time);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(4, 3);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(376, 109);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thời gian";
            // 
            // layoutCond_Time
            // 
            layoutCond_Time.ColumnCount = 2;
            layoutCond_Time.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            layoutCond_Time.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutCond_Time.Controls.Add(label1, 0, 0);
            layoutCond_Time.Controls.Add(label2, 0, 1);
            layoutCond_Time.Controls.Add(cond_dpFrom, 1, 0);
            layoutCond_Time.Controls.Add(cond_dpTo, 1, 1);
            layoutCond_Time.Dock = DockStyle.Fill;
            layoutCond_Time.Location = new Point(4, 18);
            layoutCond_Time.Margin = new Padding(4, 3, 4, 3);
            layoutCond_Time.Name = "layoutCond_Time";
            layoutCond_Time.RowCount = 2;
            layoutCond_Time.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutCond_Time.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutCond_Time.Size = new Size(368, 88);
            layoutCond_Time.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 44);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(4, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 44);
            label2.TabIndex = 1;
            label2.Text = "Đến ngày";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cond_dpFrom
            // 
            cond_dpFrom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cond_dpFrom.CustomFormat = "dddd dd/MM/yyyy";
            cond_dpFrom.Format = DateTimePickerFormat.Custom;
            cond_dpFrom.Location = new Point(121, 11);
            cond_dpFrom.Margin = new Padding(4, 3, 4, 3);
            cond_dpFrom.Name = "cond_dpFrom";
            cond_dpFrom.Size = new Size(243, 22);
            cond_dpFrom.TabIndex = 2;
            cond_dpFrom.ValueChanged += cond_dpFrom_ValueChanged;
            // 
            // cond_dpTo
            // 
            cond_dpTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cond_dpTo.CustomFormat = "dddd dd/MM/yyyy";
            cond_dpTo.Format = DateTimePickerFormat.Custom;
            cond_dpTo.Location = new Point(121, 55);
            cond_dpTo.Margin = new Padding(4, 3, 4, 3);
            cond_dpTo.Name = "cond_dpTo";
            cond_dpTo.Size = new Size(243, 22);
            cond_dpTo.TabIndex = 3;
            cond_dpTo.ValueChanged += cond_dpTo_ValueChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(layoutCond_Ex);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(4, 118);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(376, 109);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bài bắn";
            // 
            // layoutCond_Ex
            // 
            layoutCond_Ex.ColumnCount = 2;
            layoutCond_Ex.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            layoutCond_Ex.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutCond_Ex.Controls.Add(label3, 0, 0);
            layoutCond_Ex.Controls.Add(label4, 0, 1);
            layoutCond_Ex.Controls.Add(cond_cboGunType, 1, 0);
            layoutCond_Ex.Controls.Add(cond_cboEx, 1, 1);
            layoutCond_Ex.Dock = DockStyle.Fill;
            layoutCond_Ex.Location = new Point(4, 18);
            layoutCond_Ex.Margin = new Padding(4, 3, 4, 3);
            layoutCond_Ex.Name = "layoutCond_Ex";
            layoutCond_Ex.RowCount = 2;
            layoutCond_Ex.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutCond_Ex.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutCond_Ex.Size = new Size(368, 88);
            layoutCond_Ex.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 44);
            label3.TabIndex = 0;
            label3.Text = "Loại súng";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(4, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 44);
            label4.TabIndex = 1;
            label4.Text = "Bài bắn";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cond_cboGunType
            // 
            cond_cboGunType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cond_cboGunType.FormattingEnabled = true;
            cond_cboGunType.Location = new Point(121, 10);
            cond_cboGunType.Margin = new Padding(4, 3, 4, 3);
            cond_cboGunType.Name = "cond_cboGunType";
            cond_cboGunType.Size = new Size(243, 24);
            cond_cboGunType.TabIndex = 2;
            cond_cboGunType.SelectedIndexChanged += cond_cboGunType_SelectedIndexChanged;
            // 
            // cond_cboEx
            // 
            cond_cboEx.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cond_cboEx.FormattingEnabled = true;
            cond_cboEx.Location = new Point(121, 54);
            cond_cboEx.Margin = new Padding(4, 3, 4, 3);
            cond_cboEx.Name = "cond_cboEx";
            cond_cboEx.Size = new Size(243, 24);
            cond_cboEx.TabIndex = 3;
            cond_cboEx.SelectedIndexChanged += cond_cboEx_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(grdCrews);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(4, 302);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(376, 367);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kíp bắn";
            // 
            // grdCrews
            // 
            grdCrews.AllowUserToResizeRows = false;
            grdCrews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCrews.Columns.AddRange(new DataGridViewColumn[] { KB_Id, KB_ThoiGianBatDau, KB_ThoiGianKetThuc, KB_IdBaiBan, KB_TenBaiBanFull, KB_IsSelected, KB_IdNguoiDung });
            grdCrews.Dock = DockStyle.Fill;
            grdCrews.Location = new Point(4, 18);
            grdCrews.Margin = new Padding(4, 3, 4, 3);
            grdCrews.Name = "grdCrews";
            grdCrews.RowHeadersVisible = false;
            grdCrews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCrews.Size = new Size(368, 346);
            grdCrews.TabIndex = 0;
            // 
            // KB_Id
            // 
            KB_Id.DataPropertyName = "Id";
            KB_Id.HeaderText = "Id";
            KB_Id.Name = "KB_Id";
            KB_Id.ReadOnly = true;
            KB_Id.Visible = false;
            // 
            // KB_ThoiGianBatDau
            // 
            KB_ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            KB_ThoiGianBatDau.HeaderText = "Thời gian";
            KB_ThoiGianBatDau.MinimumWidth = 150;
            KB_ThoiGianBatDau.Name = "KB_ThoiGianBatDau";
            KB_ThoiGianBatDau.ReadOnly = true;
            KB_ThoiGianBatDau.Width = 150;
            // 
            // KB_ThoiGianKetThuc
            // 
            KB_ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            KB_ThoiGianKetThuc.HeaderText = "ThoiGianKetThuc";
            KB_ThoiGianKetThuc.Name = "KB_ThoiGianKetThuc";
            KB_ThoiGianKetThuc.ReadOnly = true;
            KB_ThoiGianKetThuc.Visible = false;
            // 
            // KB_IdBaiBan
            // 
            KB_IdBaiBan.DataPropertyName = "IdBaiBan";
            KB_IdBaiBan.HeaderText = "IdBaiBan";
            KB_IdBaiBan.Name = "KB_IdBaiBan";
            KB_IdBaiBan.ReadOnly = true;
            KB_IdBaiBan.Visible = false;
            // 
            // KB_TenBaiBanFull
            // 
            KB_TenBaiBanFull.DataPropertyName = "TenBaiBanFull";
            KB_TenBaiBanFull.HeaderText = "Bài bắn";
            KB_TenBaiBanFull.MinimumWidth = 100;
            KB_TenBaiBanFull.Name = "KB_TenBaiBanFull";
            KB_TenBaiBanFull.ReadOnly = true;
            // 
            // KB_IsSelected
            // 
            KB_IsSelected.DataPropertyName = "IsSelected";
            KB_IsSelected.HeaderText = "Chọn";
            KB_IsSelected.MinimumWidth = 60;
            KB_IsSelected.Name = "KB_IsSelected";
            KB_IsSelected.Width = 60;
            // 
            // KB_IdNguoiDung
            // 
            KB_IdNguoiDung.DataPropertyName = "IdNguoiDung";
            KB_IdNguoiDung.HeaderText = "IdNguoiDung";
            KB_IdNguoiDung.Name = "KB_IdNguoiDung";
            KB_IdNguoiDung.Visible = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(layoutCond_Teacher);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(4, 233);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(376, 63);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Phụ trách kíp bắn";
            // 
            // layoutCond_Teacher
            // 
            layoutCond_Teacher.ColumnCount = 2;
            layoutCond_Teacher.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            layoutCond_Teacher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutCond_Teacher.Controls.Add(label5, 0, 0);
            layoutCond_Teacher.Controls.Add(cond_cboTeacher, 1, 0);
            layoutCond_Teacher.Dock = DockStyle.Fill;
            layoutCond_Teacher.Location = new Point(4, 18);
            layoutCond_Teacher.Margin = new Padding(4, 3, 4, 3);
            layoutCond_Teacher.Name = "layoutCond_Teacher";
            layoutCond_Teacher.RowCount = 1;
            layoutCond_Teacher.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutCond_Teacher.Size = new Size(368, 42);
            layoutCond_Teacher.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 42);
            label5.TabIndex = 0;
            label5.Text = "Họ tên";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cond_cboTeacher
            // 
            cond_cboTeacher.Dock = DockStyle.Fill;
            cond_cboTeacher.FormattingEnabled = true;
            cond_cboTeacher.Location = new Point(121, 3);
            cond_cboTeacher.Margin = new Padding(4, 3, 4, 3);
            cond_cboTeacher.Name = "cond_cboTeacher";
            cond_cboTeacher.Size = new Size(243, 24);
            cond_cboTeacher.TabIndex = 1;
            cond_cboTeacher.SelectedIndexChanged += cond_cboTeacher_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(layoutButtons);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(4, 699);
            groupBox2.Margin = new Padding(4, 0, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(392, 170);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // layoutButtons
            // 
            layoutButtons.ColumnCount = 1;
            layoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutButtons.Controls.Add(btnSearch, 0, 0);
            layoutButtons.Controls.Add(btnPrint, 0, 1);
            layoutButtons.Dock = DockStyle.Fill;
            layoutButtons.Location = new Point(4, 19);
            layoutButtons.Margin = new Padding(4, 0, 4, 3);
            layoutButtons.Name = "layoutButtons";
            layoutButtons.RowCount = 2;
            layoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutButtons.Size = new Size(384, 148);
            layoutButtons.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(6, 6);
            btnSearch.Margin = new Padding(6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(372, 62);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Hiện kết quả bắn";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPrint
            // 
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.Location = new Point(6, 80);
            btnPrint.Margin = new Padding(6);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(372, 62);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "In kết quả bắn";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // grdSearchResult
            // 
            grdSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSearchResult.Columns.AddRange(new DataGridViewColumn[] { IdKetQua, IDBaiBan, TenBaiBanFull, TGBatDau, TGKetThuc, ND_Id, ND_Ten, ND_QuanHam, ND_ChucVu, ND_DonVi, ND_GhiChu, ND_IdSungBan, ND_ThanhTich, ND_TongDiem, ND_XepLoai, IsSelected });
            grdSearchResult.Dock = DockStyle.Fill;
            grdSearchResult.Location = new Point(412, 3);
            grdSearchResult.Margin = new Padding(4, 3, 4, 3);
            grdSearchResult.Name = "grdSearchResult";
            grdSearchResult.RowHeadersVisible = false;
            grdSearchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSearchResult.Size = new Size(732, 872);
            grdSearchResult.TabIndex = 1;
            // 
            // IdKetQua
            // 
            IdKetQua.DataPropertyName = "IdKetQua";
            IdKetQua.HeaderText = "IdKetQua";
            IdKetQua.Name = "IdKetQua";
            IdKetQua.ReadOnly = true;
            IdKetQua.Visible = false;
            // 
            // IDBaiBan
            // 
            IDBaiBan.DataPropertyName = "IDBaiBan";
            IDBaiBan.HeaderText = "IDBaiBan";
            IDBaiBan.Name = "IDBaiBan";
            IDBaiBan.ReadOnly = true;
            IDBaiBan.Visible = false;
            // 
            // TenBaiBanFull
            // 
            TenBaiBanFull.DataPropertyName = "TenBaiBanFull";
            TenBaiBanFull.HeaderText = "Bài bắn";
            TenBaiBanFull.MinimumWidth = 80;
            TenBaiBanFull.Name = "TenBaiBanFull";
            TenBaiBanFull.ReadOnly = true;
            TenBaiBanFull.Width = 80;
            // 
            // TGBatDau
            // 
            TGBatDau.DataPropertyName = "TGBatDau";
            TGBatDau.HeaderText = "Bắt đầu";
            TGBatDau.MinimumWidth = 100;
            TGBatDau.Name = "TGBatDau";
            TGBatDau.ReadOnly = true;
            // 
            // TGKetThuc
            // 
            TGKetThuc.DataPropertyName = "TGKetThuc";
            TGKetThuc.HeaderText = "Kết thúc";
            TGKetThuc.MinimumWidth = 100;
            TGKetThuc.Name = "TGKetThuc";
            TGKetThuc.ReadOnly = true;
            // 
            // ND_Id
            // 
            ND_Id.DataPropertyName = "ND_Id";
            ND_Id.HeaderText = "ND_Id";
            ND_Id.Name = "ND_Id";
            ND_Id.ReadOnly = true;
            ND_Id.Visible = false;
            // 
            // ND_Ten
            // 
            ND_Ten.DataPropertyName = "ND_Ten";
            ND_Ten.HeaderText = "Người bắn";
            ND_Ten.MinimumWidth = 150;
            ND_Ten.Name = "ND_Ten";
            ND_Ten.ReadOnly = true;
            ND_Ten.Width = 200;
            // 
            // ND_QuanHam
            // 
            ND_QuanHam.DataPropertyName = "ND_QuanHam";
            ND_QuanHam.HeaderText = "ND_QuanHam";
            ND_QuanHam.Name = "ND_QuanHam";
            ND_QuanHam.ReadOnly = true;
            ND_QuanHam.Visible = false;
            // 
            // ND_ChucVu
            // 
            ND_ChucVu.DataPropertyName = "ND_ChucVu";
            ND_ChucVu.HeaderText = "ND_ChucVu";
            ND_ChucVu.Name = "ND_ChucVu";
            ND_ChucVu.ReadOnly = true;
            ND_ChucVu.Visible = false;
            // 
            // ND_DonVi
            // 
            ND_DonVi.DataPropertyName = "ND_DonVi";
            ND_DonVi.HeaderText = "ND_DonVi";
            ND_DonVi.Name = "ND_DonVi";
            ND_DonVi.ReadOnly = true;
            ND_DonVi.Visible = false;
            // 
            // ND_GhiChu
            // 
            ND_GhiChu.DataPropertyName = "ND_GhiChu";
            ND_GhiChu.HeaderText = "ND_GhiChu";
            ND_GhiChu.Name = "ND_GhiChu";
            ND_GhiChu.ReadOnly = true;
            ND_GhiChu.Visible = false;
            // 
            // ND_IdSungBan
            // 
            ND_IdSungBan.DataPropertyName = "ND_IdSungBan";
            ND_IdSungBan.HeaderText = "Số súng";
            ND_IdSungBan.MinimumWidth = 75;
            ND_IdSungBan.Name = "ND_IdSungBan";
            ND_IdSungBan.ReadOnly = true;
            ND_IdSungBan.Width = 75;
            // 
            // ND_ThanhTich
            // 
            ND_ThanhTich.DataPropertyName = "ND_ThanhTich";
            ND_ThanhTich.HeaderText = "Thành tích";
            ND_ThanhTich.MinimumWidth = 200;
            ND_ThanhTich.Name = "ND_ThanhTich";
            ND_ThanhTich.ReadOnly = true;
            ND_ThanhTich.Width = 500;
            // 
            // ND_TongDiem
            // 
            ND_TongDiem.DataPropertyName = "ND_TongDiem";
            ND_TongDiem.HeaderText = "Tổng điểm";
            ND_TongDiem.MinimumWidth = 90;
            ND_TongDiem.Name = "ND_TongDiem";
            ND_TongDiem.ReadOnly = true;
            ND_TongDiem.Width = 90;
            // 
            // ND_XepLoai
            // 
            ND_XepLoai.DataPropertyName = "ND_XepLoai";
            ND_XepLoai.HeaderText = "Xếp loại";
            ND_XepLoai.MinimumWidth = 90;
            ND_XepLoai.Name = "ND_XepLoai";
            ND_XepLoai.ReadOnly = true;
            ND_XepLoai.Width = 90;
            // 
            // IsSelected
            // 
            IsSelected.DataPropertyName = "IsSelected";
            IsSelected.HeaderText = "Chọn";
            IsSelected.MinimumWidth = 50;
            IsSelected.Name = "IsSelected";
            IsSelected.Width = 50;
            // 
            // VS_Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 878);
            Controls.Add(layoutMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1164, 917);
            Name = "VS_Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm kiếm kết quả bắn";
            WindowState = FormWindowState.Maximized;
            layoutMain.ResumeLayout(false);
            layoutLeftPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            layoutConditions.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            layoutCond_Time.ResumeLayout(false);
            layoutCond_Time.PerformLayout();
            groupBox4.ResumeLayout(false);
            layoutCond_Ex.ResumeLayout(false);
            layoutCond_Ex.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdCrews).EndInit();
            groupBox6.ResumeLayout(false);
            layoutCond_Teacher.ResumeLayout(false);
            layoutCond_Teacher.PerformLayout();
            groupBox2.ResumeLayout(false);
            layoutButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSearchResult).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TableLayoutPanel layoutLeftPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel layoutButtons;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TableLayoutPanel layoutConditions;
        private System.Windows.Forms.DataGridView grdSearchResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel layoutCond_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cond_dpFrom;
        private System.Windows.Forms.DateTimePicker cond_dpTo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel layoutCond_Ex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cond_cboGunType;
        private System.Windows.Forms.ComboBox cond_cboEx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBaiBanFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_QuanHam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_IdSungBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_ThanhTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_TongDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND_XepLoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridView grdCrews;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel layoutCond_Teacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cond_cboTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn KB_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KB_ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KB_ThoiGianKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KB_IdBaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KB_TenBaiBanFull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn KB_IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn KB_IdNguoiDung;
    }
}