namespace PBDT_2D
{
    partial class VS_DanhSachPhuTrach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VS_DanhSachPhuTrach));
            gbFilter = new GroupBox();
            layoutFilter = new TableLayoutPanel();
            groupBox15 = new GroupBox();
            tbFilterNamSinhHv = new TextBox();
            groupBox1 = new GroupBox();
            tbFilterTenHv = new TextBox();
            groupBox2 = new GroupBox();
            cboFilterQuanHamHv = new ComboBox();
            groupBox3 = new GroupBox();
            tbFilterChucVu = new TextBox();
            groupBox4 = new GroupBox();
            tbFilterDonVi = new TextBox();
            groupBox5 = new GroupBox();
            tbFilterGhiChu = new TextBox();
            btnResetFilterHv = new Button();
            groupBox6 = new GroupBox();
            layoutTeacher = new TableLayoutPanel();
            grdTeacher = new DataGridView();
            teacher_Id = new DataGridViewTextBoxColumn();
            teacher_ThuTu = new DataGridViewTextBoxColumn();
            teacher_QuanHamId = new DataGridViewTextBoxColumn();
            teacher_Ten = new DataGridViewTextBoxColumn();
            teacher_QuanHam = new DataGridViewTextBoxColumn();
            teacher_NamSinh = new DataGridViewTextBoxColumn();
            btnRemoveTeacher = new Button();
            grdUsersShooting = new DataGridView();
            layoutMain = new TableLayoutPanel();
            groupBox9 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox10 = new GroupBox();
            tbFilterTenGv = new TextBox();
            groupBox11 = new GroupBox();
            cbFilterQuanHamGv = new ComboBox();
            groupBox12 = new GroupBox();
            tbFilterNamSinhGv = new TextBox();
            btnResetFilterGv = new Button();
            layoutCrewDetail = new TableLayoutPanel();
            grdSung = new DataGridView();
            GunId = new DataGridViewTextBoxColumn();
            layoutUserShootingButtons = new TableLayoutPanel();
            btnUserUp = new Button();
            btnUserDown = new Button();
            btnRemoveUser = new Button();
            lblSetupTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPickTeacher = new Button();
            groupBox8 = new GroupBox();
            grdGiaoVienList = new DataGridView();
            gvList_Id = new DataGridViewTextBoxColumn();
            gvList_ThuTu = new DataGridViewTextBoxColumn();
            gvList_Ten = new DataGridViewTextBoxColumn();
            gvList_QuanHamId = new DataGridViewTextBoxColumn();
            gvList_QuanHam = new DataGridViewTextBoxColumn();
            gvList_NamSinh = new DataGridViewTextBoxColumn();
            btnPickCrew = new Button();
            groupBox7 = new GroupBox();
            grdUsersList = new DataGridView();
            userList_Id = new DataGridViewTextBoxColumn();
            userList_ThuTu = new DataGridViewTextBoxColumn();
            userList_Ten = new DataGridViewTextBoxColumn();
            userList_QuanHamId = new DataGridViewTextBoxColumn();
            userList_QuanHam = new DataGridViewTextBoxColumn();
            userList_ChucVu = new DataGridViewTextBoxColumn();
            userList_DonVi = new DataGridViewTextBoxColumn();
            userList_GhiChu = new DataGridViewTextBoxColumn();
            NamSinhHv = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ThuTu = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            QuanHamId = new DataGridViewTextBoxColumn();
            QuanHam = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            NamSinh = new DataGridViewTextBoxColumn();
            gbFilter.SuspendLayout();
            layoutFilter.SuspendLayout();
            groupBox15.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            layoutTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdUsersShooting).BeginInit();
            layoutMain.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            layoutCrewDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSung).BeginInit();
            layoutUserShootingButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdGiaoVienList).BeginInit();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsersList).BeginInit();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(layoutFilter);
            gbFilter.Dock = DockStyle.Fill;
            gbFilter.Location = new Point(4, 761);
            gbFilter.Margin = new Padding(4, 3, 4, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(4, 3, 4, 3);
            gbFilter.Size = new Size(1609, 86);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Lọc học viên";
            // 
            // layoutFilter
            // 
            layoutFilter.ColumnCount = 7;
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            layoutFilter.Controls.Add(groupBox15, 5, 0);
            layoutFilter.Controls.Add(groupBox1, 0, 0);
            layoutFilter.Controls.Add(groupBox2, 1, 0);
            layoutFilter.Controls.Add(groupBox3, 2, 0);
            layoutFilter.Controls.Add(groupBox4, 3, 0);
            layoutFilter.Controls.Add(groupBox5, 4, 0);
            layoutFilter.Controls.Add(btnResetFilterHv, 6, 0);
            layoutFilter.Dock = DockStyle.Fill;
            layoutFilter.Location = new Point(4, 19);
            layoutFilter.Margin = new Padding(4, 3, 4, 3);
            layoutFilter.Name = "layoutFilter";
            layoutFilter.RowCount = 1;
            layoutFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutFilter.Size = new Size(1601, 64);
            layoutFilter.TabIndex = 0;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(tbFilterNamSinhHv);
            groupBox15.Dock = DockStyle.Fill;
            groupBox15.Location = new Point(1239, 3);
            groupBox15.Margin = new Padding(4, 3, 4, 3);
            groupBox15.Name = "groupBox15";
            groupBox15.Padding = new Padding(4, 3, 4, 3);
            groupBox15.Size = new Size(239, 58);
            groupBox15.TabIndex = 6;
            groupBox15.TabStop = false;
            groupBox15.Text = "Năm sinh";
            // 
            // tbFilterNamSinhHv
            // 
            tbFilterNamSinhHv.Dock = DockStyle.Fill;
            tbFilterNamSinhHv.Location = new Point(4, 19);
            tbFilterNamSinhHv.Margin = new Padding(4, 3, 4, 3);
            tbFilterNamSinhHv.Name = "tbFilterNamSinhHv";
            tbFilterNamSinhHv.Size = new Size(231, 23);
            tbFilterNamSinhHv.TabIndex = 0;
            tbFilterNamSinhHv.TextChanged += tbFilterNamSinhHv_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbFilterTenHv);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(239, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên";
            // 
            // tbFilterTenHv
            // 
            tbFilterTenHv.Dock = DockStyle.Fill;
            tbFilterTenHv.Location = new Point(4, 19);
            tbFilterTenHv.Margin = new Padding(4, 3, 4, 3);
            tbFilterTenHv.Name = "tbFilterTenHv";
            tbFilterTenHv.Size = new Size(231, 23);
            tbFilterTenHv.TabIndex = 0;
            tbFilterTenHv.TextChanged += tbFilterTen_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboFilterQuanHamHv);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(251, 3);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(239, 58);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quân hàm";
            // 
            // cboFilterQuanHamHv
            // 
            cboFilterQuanHamHv.Dock = DockStyle.Fill;
            cboFilterQuanHamHv.FormattingEnabled = true;
            cboFilterQuanHamHv.Location = new Point(4, 19);
            cboFilterQuanHamHv.Margin = new Padding(4, 3, 4, 3);
            cboFilterQuanHamHv.Name = "cboFilterQuanHamHv";
            cboFilterQuanHamHv.Size = new Size(231, 23);
            cboFilterQuanHamHv.TabIndex = 0;
            cboFilterQuanHamHv.SelectedIndexChanged += cboFilterQuanHam_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbFilterChucVu);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(498, 3);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(239, 58);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức vụ";
            // 
            // tbFilterChucVu
            // 
            tbFilterChucVu.Dock = DockStyle.Fill;
            tbFilterChucVu.Location = new Point(4, 19);
            tbFilterChucVu.Margin = new Padding(4, 3, 4, 3);
            tbFilterChucVu.Name = "tbFilterChucVu";
            tbFilterChucVu.Size = new Size(231, 23);
            tbFilterChucVu.TabIndex = 0;
            tbFilterChucVu.TextChanged += tbFilterChucVu_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbFilterDonVi);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(745, 3);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(239, 58);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Đơn vị";
            // 
            // tbFilterDonVi
            // 
            tbFilterDonVi.Dock = DockStyle.Fill;
            tbFilterDonVi.Location = new Point(4, 19);
            tbFilterDonVi.Margin = new Padding(4, 3, 4, 3);
            tbFilterDonVi.Name = "tbFilterDonVi";
            tbFilterDonVi.Size = new Size(231, 23);
            tbFilterDonVi.TabIndex = 0;
            tbFilterDonVi.TextChanged += tbFilterDonVi_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tbFilterGhiChu);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(992, 3);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(239, 58);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ghi chú";
            // 
            // tbFilterGhiChu
            // 
            tbFilterGhiChu.Dock = DockStyle.Fill;
            tbFilterGhiChu.Location = new Point(4, 19);
            tbFilterGhiChu.Margin = new Padding(4, 3, 4, 3);
            tbFilterGhiChu.Name = "tbFilterGhiChu";
            tbFilterGhiChu.Size = new Size(231, 23);
            tbFilterGhiChu.TabIndex = 0;
            tbFilterGhiChu.TextChanged += tbFilterGhiChu_TextChanged;
            // 
            // btnResetFilterHv
            // 
            btnResetFilterHv.Dock = DockStyle.Fill;
            btnResetFilterHv.Image = (Image)resources.GetObject("btnResetFilterHv.Image");
            btnResetFilterHv.Location = new Point(1491, 9);
            btnResetFilterHv.Margin = new Padding(9);
            btnResetFilterHv.Name = "btnResetFilterHv";
            btnResetFilterHv.Size = new Size(101, 46);
            btnResetFilterHv.TabIndex = 5;
            btnResetFilterHv.Text = "Cài đặt lại";
            btnResetFilterHv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetFilterHv.UseVisualStyleBackColor = true;
            btnResetFilterHv.Click += btnResetFilterHv_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(layoutTeacher);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(4, 332);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(1609, 86);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Phụ trách kíp bắn";
            // 
            // layoutTeacher
            // 
            layoutTeacher.ColumnCount = 3;
            layoutTeacher.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            layoutTeacher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutTeacher.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            layoutTeacher.Controls.Add(grdTeacher, 1, 0);
            layoutTeacher.Controls.Add(btnRemoveTeacher, 2, 0);
            layoutTeacher.Dock = DockStyle.Fill;
            layoutTeacher.Location = new Point(4, 19);
            layoutTeacher.Margin = new Padding(4, 3, 4, 3);
            layoutTeacher.Name = "layoutTeacher";
            layoutTeacher.RowCount = 1;
            layoutTeacher.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTeacher.Size = new Size(1601, 64);
            layoutTeacher.TabIndex = 0;
            // 
            // grdTeacher
            // 
            grdTeacher.AllowUserToResizeRows = false;
            grdTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTeacher.Columns.AddRange(new DataGridViewColumn[] { teacher_Id, teacher_ThuTu, teacher_QuanHamId, teacher_Ten, teacher_QuanHam, teacher_NamSinh });
            grdTeacher.Dock = DockStyle.Fill;
            grdTeacher.Location = new Point(60, 3);
            grdTeacher.Margin = new Padding(4, 3, 4, 3);
            grdTeacher.MultiSelect = false;
            grdTeacher.Name = "grdTeacher";
            grdTeacher.RowHeadersVisible = false;
            grdTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTeacher.Size = new Size(1481, 58);
            grdTeacher.TabIndex = 0;
            grdTeacher.SelectionChanged += grdTeacher_SelectionChanged;
            // 
            // teacher_Id
            // 
            teacher_Id.DataPropertyName = "Id";
            teacher_Id.HeaderText = "Id";
            teacher_Id.Name = "teacher_Id";
            teacher_Id.Visible = false;
            // 
            // teacher_ThuTu
            // 
            teacher_ThuTu.DataPropertyName = "ThuTu";
            teacher_ThuTu.HeaderText = "STT";
            teacher_ThuTu.Name = "teacher_ThuTu";
            teacher_ThuTu.Visible = false;
            // 
            // teacher_QuanHamId
            // 
            teacher_QuanHamId.DataPropertyName = "QuanHamId";
            teacher_QuanHamId.HeaderText = "QuanHamId";
            teacher_QuanHamId.Name = "teacher_QuanHamId";
            teacher_QuanHamId.Visible = false;
            // 
            // teacher_Ten
            // 
            teacher_Ten.DataPropertyName = "HoTen";
            teacher_Ten.HeaderText = "Tên";
            teacher_Ten.MinimumWidth = 150;
            teacher_Ten.Name = "teacher_Ten";
            teacher_Ten.ReadOnly = true;
            teacher_Ten.Width = 200;
            // 
            // teacher_QuanHam
            // 
            teacher_QuanHam.DataPropertyName = "QuanHam";
            teacher_QuanHam.HeaderText = "Quân hàm";
            teacher_QuanHam.MinimumWidth = 80;
            teacher_QuanHam.Name = "teacher_QuanHam";
            teacher_QuanHam.ReadOnly = true;
            // 
            // teacher_NamSinh
            // 
            teacher_NamSinh.DataPropertyName = "NamSinh";
            teacher_NamSinh.HeaderText = "Năm sinh";
            teacher_NamSinh.Name = "teacher_NamSinh";
            // 
            // btnRemoveTeacher
            // 
            btnRemoveTeacher.BackgroundImage = (Image)resources.GetObject("btnRemoveTeacher.BackgroundImage");
            btnRemoveTeacher.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemoveTeacher.Dock = DockStyle.Fill;
            btnRemoveTeacher.Location = new Point(1549, 3);
            btnRemoveTeacher.Margin = new Padding(4, 3, 4, 3);
            btnRemoveTeacher.Name = "btnRemoveTeacher";
            btnRemoveTeacher.Size = new Size(48, 58);
            btnRemoveTeacher.TabIndex = 1;
            btnRemoveTeacher.UseVisualStyleBackColor = true;
            btnRemoveTeacher.Click += btnRemoveTeacher_Click;
            // 
            // grdUsersShooting
            // 
            grdUsersShooting.AllowUserToResizeRows = false;
            grdUsersShooting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsersShooting.Columns.AddRange(new DataGridViewColumn[] { Id, ThuTu, Ten, QuanHamId, QuanHam, ChucVu, DonVi, GhiChu, NamSinh });
            grdUsersShooting.Dock = DockStyle.Fill;
            grdUsersShooting.Location = new Point(62, 60);
            grdUsersShooting.Margin = new Padding(4, 3, 4, 3);
            grdUsersShooting.MultiSelect = false;
            grdUsersShooting.Name = "grdUsersShooting";
            grdUsersShooting.RowHeadersVisible = false;
            grdUsersShooting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsersShooting.Size = new Size(1485, 260);
            grdUsersShooting.TabIndex = 1;
            grdUsersShooting.SelectionChanged += grdUsersShooting_SelectionChanged;
            // 
            // layoutMain
            // 
            layoutMain.BackColor = SystemColors.Control;
            layoutMain.ColumnCount = 1;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMain.Controls.Add(groupBox9, 0, 4);
            layoutMain.Controls.Add(layoutCrewDetail, 0, 0);
            layoutMain.Controls.Add(gbFilter, 0, 3);
            layoutMain.Controls.Add(groupBox6, 0, 1);
            layoutMain.Controls.Add(tableLayoutPanel1, 0, 2);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(4, 3, 4, 3);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 5;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 329F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            layoutMain.Size = new Size(1617, 942);
            layoutMain.TabIndex = 1;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tableLayoutPanel2);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Location = new Point(4, 853);
            groupBox9.Margin = new Padding(4, 3, 4, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(4, 3, 4, 3);
            groupBox9.Size = new Size(1609, 86);
            groupBox9.TabIndex = 6;
            groupBox9.TabStop = false;
            groupBox9.Text = "Lọc giáo viên ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(groupBox10, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox11, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox12, 2, 0);
            tableLayoutPanel2.Controls.Add(btnResetFilterGv, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 19);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1601, 64);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(tbFilterTenGv);
            groupBox10.Dock = DockStyle.Fill;
            groupBox10.Location = new Point(4, 3);
            groupBox10.Margin = new Padding(4, 3, 4, 3);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(4, 3, 4, 3);
            groupBox10.Size = new Size(486, 58);
            groupBox10.TabIndex = 0;
            groupBox10.TabStop = false;
            groupBox10.Text = "Tên";
            // 
            // tbFilterTenGv
            // 
            tbFilterTenGv.Dock = DockStyle.Fill;
            tbFilterTenGv.Location = new Point(4, 19);
            tbFilterTenGv.Margin = new Padding(4, 3, 4, 3);
            tbFilterTenGv.Name = "tbFilterTenGv";
            tbFilterTenGv.Size = new Size(478, 23);
            tbFilterTenGv.TabIndex = 0;
            tbFilterTenGv.TextChanged += tbFilterTenGv_TextChanged;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(cbFilterQuanHamGv);
            groupBox11.Dock = DockStyle.Fill;
            groupBox11.Location = new Point(498, 3);
            groupBox11.Margin = new Padding(4, 3, 4, 3);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(4, 3, 4, 3);
            groupBox11.Size = new Size(486, 58);
            groupBox11.TabIndex = 1;
            groupBox11.TabStop = false;
            groupBox11.Text = "Quân hàm";
            // 
            // cbFilterQuanHamGv
            // 
            cbFilterQuanHamGv.Dock = DockStyle.Fill;
            cbFilterQuanHamGv.FormattingEnabled = true;
            cbFilterQuanHamGv.Location = new Point(4, 19);
            cbFilterQuanHamGv.Margin = new Padding(4, 3, 4, 3);
            cbFilterQuanHamGv.Name = "cbFilterQuanHamGv";
            cbFilterQuanHamGv.Size = new Size(478, 23);
            cbFilterQuanHamGv.TabIndex = 0;
            cbFilterQuanHamGv.SelectedIndexChanged += cbFilterQuanHamGv_SelectedIndexChanged;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(tbFilterNamSinhGv);
            groupBox12.Dock = DockStyle.Fill;
            groupBox12.Location = new Point(992, 3);
            groupBox12.Margin = new Padding(4, 3, 4, 3);
            groupBox12.Name = "groupBox12";
            groupBox12.Padding = new Padding(4, 3, 4, 3);
            groupBox12.Size = new Size(486, 58);
            groupBox12.TabIndex = 2;
            groupBox12.TabStop = false;
            groupBox12.Text = "Năm sinh";
            // 
            // tbFilterNamSinhGv
            // 
            tbFilterNamSinhGv.Dock = DockStyle.Fill;
            tbFilterNamSinhGv.Location = new Point(4, 19);
            tbFilterNamSinhGv.Margin = new Padding(4, 3, 4, 3);
            tbFilterNamSinhGv.Name = "tbFilterNamSinhGv";
            tbFilterNamSinhGv.Size = new Size(478, 23);
            tbFilterNamSinhGv.TabIndex = 0;
            tbFilterNamSinhGv.TextChanged += tbFilterNamSinhGv_TextChanged;
            // 
            // btnResetFilterGv
            // 
            btnResetFilterGv.Dock = DockStyle.Fill;
            btnResetFilterGv.Image = (Image)resources.GetObject("btnResetFilterGv.Image");
            btnResetFilterGv.Location = new Point(1491, 9);
            btnResetFilterGv.Margin = new Padding(9);
            btnResetFilterGv.Name = "btnResetFilterGv";
            btnResetFilterGv.Size = new Size(101, 46);
            btnResetFilterGv.TabIndex = 5;
            btnResetFilterGv.Text = "Cài đặt lại";
            btnResetFilterGv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetFilterGv.UseVisualStyleBackColor = true;
            btnResetFilterGv.Click += btnResetFilterGv_Click;
            // 
            // layoutCrewDetail
            // 
            layoutCrewDetail.BackColor = SystemColors.Control;
            layoutCrewDetail.ColumnCount = 3;
            layoutCrewDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            layoutCrewDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutCrewDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            layoutCrewDetail.Controls.Add(grdSung, 0, 1);
            layoutCrewDetail.Controls.Add(grdUsersShooting, 1, 1);
            layoutCrewDetail.Controls.Add(layoutUserShootingButtons, 2, 1);
            layoutCrewDetail.Controls.Add(lblSetupTitle, 1, 0);
            layoutCrewDetail.Dock = DockStyle.Fill;
            layoutCrewDetail.Location = new Point(4, 3);
            layoutCrewDetail.Margin = new Padding(4, 3, 4, 3);
            layoutCrewDetail.Name = "layoutCrewDetail";
            layoutCrewDetail.RowCount = 2;
            layoutCrewDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 17.78523F));
            layoutCrewDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 82.21477F));
            layoutCrewDetail.Size = new Size(1609, 323);
            layoutCrewDetail.TabIndex = 0;
            // 
            // grdSung
            // 
            grdSung.AllowUserToResizeColumns = false;
            grdSung.AllowUserToResizeRows = false;
            grdSung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSung.Columns.AddRange(new DataGridViewColumn[] { GunId });
            grdSung.Dock = DockStyle.Fill;
            grdSung.Location = new Point(4, 60);
            grdSung.Margin = new Padding(4, 3, 4, 3);
            grdSung.MultiSelect = false;
            grdSung.Name = "grdSung";
            grdSung.RowHeadersVisible = false;
            grdSung.ScrollBars = ScrollBars.None;
            grdSung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSung.Size = new Size(50, 260);
            grdSung.TabIndex = 0;
            grdSung.SelectionChanged += grdSung_SelectionChanged;
            // 
            // GunId
            // 
            GunId.DataPropertyName = "GunId";
            GunId.HeaderText = "Súng";
            GunId.Name = "GunId";
            GunId.ReadOnly = true;
            // 
            // layoutUserShootingButtons
            // 
            layoutUserShootingButtons.BackColor = SystemColors.Control;
            layoutUserShootingButtons.ColumnCount = 1;
            layoutUserShootingButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutUserShootingButtons.Controls.Add(btnUserUp, 0, 0);
            layoutUserShootingButtons.Controls.Add(btnUserDown, 0, 1);
            layoutUserShootingButtons.Controls.Add(btnRemoveUser, 0, 2);
            layoutUserShootingButtons.Dock = DockStyle.Fill;
            layoutUserShootingButtons.Location = new Point(1555, 60);
            layoutUserShootingButtons.Margin = new Padding(4, 3, 4, 3);
            layoutUserShootingButtons.Name = "layoutUserShootingButtons";
            layoutUserShootingButtons.RowCount = 3;
            layoutUserShootingButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutUserShootingButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutUserShootingButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            layoutUserShootingButtons.Size = new Size(50, 260);
            layoutUserShootingButtons.TabIndex = 2;
            // 
            // btnUserUp
            // 
            btnUserUp.Dock = DockStyle.Fill;
            btnUserUp.Image = (Image)resources.GetObject("btnUserUp.Image");
            btnUserUp.Location = new Point(4, 3);
            btnUserUp.Margin = new Padding(4, 3, 4, 3);
            btnUserUp.Name = "btnUserUp";
            btnUserUp.Size = new Size(42, 95);
            btnUserUp.TabIndex = 0;
            btnUserUp.UseVisualStyleBackColor = true;
            btnUserUp.Click += btnUserUp_Click;
            // 
            // btnUserDown
            // 
            btnUserDown.Dock = DockStyle.Fill;
            btnUserDown.Image = (Image)resources.GetObject("btnUserDown.Image");
            btnUserDown.Location = new Point(4, 104);
            btnUserDown.Margin = new Padding(4, 3, 4, 3);
            btnUserDown.Name = "btnUserDown";
            btnUserDown.Size = new Size(42, 95);
            btnUserDown.TabIndex = 1;
            btnUserDown.UseVisualStyleBackColor = true;
            btnUserDown.Click += btnUserDown_Click;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.BackgroundImage = (Image)resources.GetObject("btnRemoveUser.BackgroundImage");
            btnRemoveUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemoveUser.Dock = DockStyle.Fill;
            btnRemoveUser.Location = new Point(4, 205);
            btnRemoveUser.Margin = new Padding(4, 3, 4, 3);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(42, 52);
            btnRemoveUser.TabIndex = 2;
            btnRemoveUser.UseVisualStyleBackColor = true;
            btnRemoveUser.Click += btnRemoveUser_Click;
            // 
            // lblSetupTitle
            // 
            lblSetupTitle.AutoSize = true;
            lblSetupTitle.Dock = DockStyle.Fill;
            lblSetupTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSetupTitle.Location = new Point(62, 0);
            lblSetupTitle.Margin = new Padding(4, 0, 4, 0);
            lblSetupTitle.Name = "lblSetupTitle";
            lblSetupTitle.Size = new Size(1485, 57);
            lblSetupTitle.TabIndex = 3;
            lblSetupTitle.Text = "Danh sách huấn luyện";
            lblSetupTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(btnPickTeacher, 3, 0);
            tableLayoutPanel1.Controls.Add(groupBox8, 2, 0);
            tableLayoutPanel1.Controls.Add(btnPickCrew, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 424);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1611, 331);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnPickTeacher
            // 
            btnPickTeacher.BackgroundImage = (Image)resources.GetObject("btnPickTeacher.BackgroundImage");
            btnPickTeacher.BackgroundImageLayout = ImageLayout.Zoom;
            btnPickTeacher.Dock = DockStyle.Fill;
            btnPickTeacher.Location = new Point(1564, 3);
            btnPickTeacher.Margin = new Padding(4, 3, 4, 3);
            btnPickTeacher.Name = "btnPickTeacher";
            btnPickTeacher.Size = new Size(43, 325);
            btnPickTeacher.TabIndex = 5;
            btnPickTeacher.UseVisualStyleBackColor = true;
            btnPickTeacher.Click += btnPickTeacher_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(grdGiaoVienList);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.Location = new Point(1036, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(521, 325);
            groupBox8.TabIndex = 4;
            groupBox8.TabStop = false;
            groupBox8.Text = "Danh sách giáo viên";
            // 
            // grdGiaoVienList
            // 
            grdGiaoVienList.AllowUserToResizeRows = false;
            grdGiaoVienList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdGiaoVienList.Columns.AddRange(new DataGridViewColumn[] { gvList_Id, gvList_ThuTu, gvList_Ten, gvList_QuanHamId, gvList_QuanHam, gvList_NamSinh });
            grdGiaoVienList.Dock = DockStyle.Fill;
            grdGiaoVienList.Location = new Point(3, 19);
            grdGiaoVienList.Margin = new Padding(4, 3, 4, 3);
            grdGiaoVienList.MultiSelect = false;
            grdGiaoVienList.Name = "grdGiaoVienList";
            grdGiaoVienList.RowHeadersVisible = false;
            grdGiaoVienList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdGiaoVienList.Size = new Size(515, 303);
            grdGiaoVienList.TabIndex = 2;
            grdGiaoVienList.SelectionChanged += grdGiaoVien_SelectionChanged;
            // 
            // gvList_Id
            // 
            gvList_Id.DataPropertyName = "Id";
            gvList_Id.HeaderText = "Id";
            gvList_Id.Name = "gvList_Id";
            gvList_Id.Visible = false;
            // 
            // gvList_ThuTu
            // 
            gvList_ThuTu.DataPropertyName = "ThuTu";
            gvList_ThuTu.HeaderText = "STT";
            gvList_ThuTu.Name = "gvList_ThuTu";
            gvList_ThuTu.ReadOnly = true;
            gvList_ThuTu.Resizable = DataGridViewTriState.False;
            gvList_ThuTu.Width = 50;
            // 
            // gvList_Ten
            // 
            gvList_Ten.DataPropertyName = "HoTen";
            gvList_Ten.HeaderText = "Tên";
            gvList_Ten.MinimumWidth = 150;
            gvList_Ten.Name = "gvList_Ten";
            gvList_Ten.ReadOnly = true;
            gvList_Ten.Width = 200;
            // 
            // gvList_QuanHamId
            // 
            gvList_QuanHamId.DataPropertyName = "QuanHamId";
            gvList_QuanHamId.HeaderText = "QuanHamId";
            gvList_QuanHamId.Name = "gvList_QuanHamId";
            gvList_QuanHamId.Visible = false;
            // 
            // gvList_QuanHam
            // 
            gvList_QuanHam.DataPropertyName = "QuanHam";
            gvList_QuanHam.HeaderText = "Quân hàm";
            gvList_QuanHam.MinimumWidth = 50;
            gvList_QuanHam.Name = "gvList_QuanHam";
            gvList_QuanHam.ReadOnly = true;
            // 
            // gvList_NamSinh
            // 
            gvList_NamSinh.DataPropertyName = "NamSinh";
            gvList_NamSinh.HeaderText = "Năm sinh";
            gvList_NamSinh.Name = "gvList_NamSinh";
            // 
            // btnPickCrew
            // 
            btnPickCrew.BackgroundImage = (Image)resources.GetObject("btnPickCrew.BackgroundImage");
            btnPickCrew.BackgroundImageLayout = ImageLayout.Zoom;
            btnPickCrew.Dock = DockStyle.Fill;
            btnPickCrew.Location = new Point(982, 3);
            btnPickCrew.Margin = new Padding(4, 3, 4, 3);
            btnPickCrew.Name = "btnPickCrew";
            btnPickCrew.Size = new Size(47, 325);
            btnPickCrew.TabIndex = 3;
            btnPickCrew.UseVisualStyleBackColor = true;
            btnPickCrew.Click += btnPickCrew_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(grdUsersList);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(3, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(972, 325);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Danh sách học viên";
            // 
            // grdUsersList
            // 
            grdUsersList.AllowUserToResizeRows = false;
            grdUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsersList.Columns.AddRange(new DataGridViewColumn[] { userList_Id, userList_ThuTu, userList_Ten, userList_QuanHamId, userList_QuanHam, userList_ChucVu, userList_DonVi, userList_GhiChu, NamSinhHv });
            grdUsersList.Dock = DockStyle.Fill;
            grdUsersList.Location = new Point(3, 19);
            grdUsersList.Margin = new Padding(4, 3, 4, 3);
            grdUsersList.MultiSelect = false;
            grdUsersList.Name = "grdUsersList";
            grdUsersList.RowHeadersVisible = false;
            grdUsersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsersList.Size = new Size(966, 303);
            grdUsersList.TabIndex = 2;
            grdUsersList.SelectionChanged += grdUsersList_SelectionChanged;
            // 
            // userList_Id
            // 
            userList_Id.DataPropertyName = "Id";
            userList_Id.HeaderText = "Id";
            userList_Id.Name = "userList_Id";
            userList_Id.Visible = false;
            // 
            // userList_ThuTu
            // 
            userList_ThuTu.DataPropertyName = "ThuTu";
            userList_ThuTu.HeaderText = "STT";
            userList_ThuTu.Name = "userList_ThuTu";
            userList_ThuTu.ReadOnly = true;
            userList_ThuTu.Resizable = DataGridViewTriState.False;
            userList_ThuTu.Width = 50;
            // 
            // userList_Ten
            // 
            userList_Ten.DataPropertyName = "Ten";
            userList_Ten.HeaderText = "Tên";
            userList_Ten.MinimumWidth = 150;
            userList_Ten.Name = "userList_Ten";
            userList_Ten.ReadOnly = true;
            userList_Ten.Width = 200;
            // 
            // userList_QuanHamId
            // 
            userList_QuanHamId.DataPropertyName = "QuanHamId";
            userList_QuanHamId.HeaderText = "QuanHamId";
            userList_QuanHamId.Name = "userList_QuanHamId";
            userList_QuanHamId.Visible = false;
            // 
            // userList_QuanHam
            // 
            userList_QuanHam.DataPropertyName = "QuanHam";
            userList_QuanHam.HeaderText = "Quân hàm";
            userList_QuanHam.MinimumWidth = 50;
            userList_QuanHam.Name = "userList_QuanHam";
            userList_QuanHam.ReadOnly = true;
            // 
            // userList_ChucVu
            // 
            userList_ChucVu.DataPropertyName = "ChucVu";
            userList_ChucVu.HeaderText = "Chức vụ";
            userList_ChucVu.MinimumWidth = 100;
            userList_ChucVu.Name = "userList_ChucVu";
            userList_ChucVu.ReadOnly = true;
            userList_ChucVu.Width = 150;
            // 
            // userList_DonVi
            // 
            userList_DonVi.DataPropertyName = "DonVi";
            userList_DonVi.HeaderText = "Đơn vị";
            userList_DonVi.MinimumWidth = 100;
            userList_DonVi.Name = "userList_DonVi";
            userList_DonVi.ReadOnly = true;
            userList_DonVi.Width = 150;
            // 
            // userList_GhiChu
            // 
            userList_GhiChu.DataPropertyName = "GhiChu";
            userList_GhiChu.HeaderText = "Ghi chú";
            userList_GhiChu.MinimumWidth = 100;
            userList_GhiChu.Name = "userList_GhiChu";
            userList_GhiChu.ReadOnly = true;
            userList_GhiChu.Width = 150;
            // 
            // NamSinhHv
            // 
            NamSinhHv.DataPropertyName = "NamSinh";
            NamSinhHv.HeaderText = "Năm sinh";
            NamSinhHv.Name = "NamSinhHv";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // ThuTu
            // 
            ThuTu.DataPropertyName = "ThuTu";
            ThuTu.HeaderText = "STT";
            ThuTu.Name = "ThuTu";
            ThuTu.ReadOnly = true;
            ThuTu.Resizable = DataGridViewTriState.False;
            ThuTu.Visible = false;
            ThuTu.Width = 50;
            // 
            // Ten
            // 
            Ten.DataPropertyName = "Ten";
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 150;
            Ten.Name = "Ten";
            Ten.ReadOnly = true;
            Ten.Width = 200;
            // 
            // QuanHamId
            // 
            QuanHamId.DataPropertyName = "QuanHamId";
            QuanHamId.HeaderText = "QuanHamId";
            QuanHamId.Name = "QuanHamId";
            QuanHamId.Visible = false;
            // 
            // QuanHam
            // 
            QuanHam.DataPropertyName = "QuanHam";
            QuanHam.HeaderText = "Quân hàm";
            QuanHam.MinimumWidth = 80;
            QuanHam.Name = "QuanHam";
            QuanHam.ReadOnly = true;
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 100;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            ChucVu.Width = 150;
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 100;
            DonVi.Name = "DonVi";
            DonVi.ReadOnly = true;
            DonVi.Width = 150;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 100;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            GhiChu.Width = 150;
            // 
            // NamSinh
            // 
            NamSinh.DataPropertyName = "NamSinh";
            NamSinh.HeaderText = "Năm Sinh";
            NamSinh.Name = "NamSinh";
            // 
            // VS_DanhSachPhuTrach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 942);
            Controls.Add(layoutMain);
            Name = "VS_DanhSachPhuTrach";
            Text = "VS_DanhSachPhuTrach";
            WindowState = FormWindowState.Maximized;
            FormClosed += VS_CrewSetup_FormClosed;
            Load += VS_CrewSetup_Load;
            gbFilter.ResumeLayout(false);
            layoutFilter.ResumeLayout(false);
            groupBox15.ResumeLayout(false);
            groupBox15.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            layoutTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdTeacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdUsersShooting).EndInit();
            layoutMain.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            layoutCrewDetail.ResumeLayout(false);
            layoutCrewDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSung).EndInit();
            layoutUserShootingButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdGiaoVienList).EndInit();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdUsersList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbFilter;
        private TableLayoutPanel layoutFilter;
        private GroupBox groupBox1;
        private TextBox tbFilterTenHv;
        private GroupBox groupBox2;
        private ComboBox cboFilterQuanHamHv;
        private GroupBox groupBox3;
        private TextBox tbFilterChucVu;
        private GroupBox groupBox4;
        private TextBox tbFilterDonVi;
        private GroupBox groupBox5;
        private TextBox tbFilterGhiChu;
        private Button btnResetFilterHv;
        private GroupBox groupBox6;
        private TableLayoutPanel layoutTeacher;
        private DataGridView grdTeacher;
        private Button btnRemoveTeacher;
        private DataGridView grdUsersShooting;
        private TableLayoutPanel layoutMain;
        private TableLayoutPanel layoutCrewDetail;
        private DataGridView grdSung;
        private DataGridViewTextBoxColumn GunId;
        private TableLayoutPanel layoutUserShootingButtons;
        private Button btnUserUp;
        private Button btnUserDown;
        private Button btnRemoveUser;
        private Label lblSetupTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox7;
        private DataGridView grdUsersList;
        private Button btnPickCrew;
        private GroupBox groupBox8;
        private DataGridView grdGiaoVienList;
        private Button btnPickTeacher;
        private GroupBox groupBox9;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox10;
        private TextBox tbFilterTenGv;
        private GroupBox groupBox11;
        private ComboBox cbFilterQuanHamGv;
        private GroupBox groupBox12;
        private TextBox tbFilterNamSinhGv;
        private Button btnResetFilterGv;
        private GroupBox groupBox15;
        private TextBox tbFilterNamSinhHv;
        private DataGridViewTextBoxColumn teacher_Id;
        private DataGridViewTextBoxColumn teacher_ThuTu;
        private DataGridViewTextBoxColumn teacher_QuanHamId;
        private DataGridViewTextBoxColumn teacher_Ten;
        private DataGridViewTextBoxColumn teacher_QuanHam;
        private DataGridViewTextBoxColumn teacher_NamSinh;
        private DataGridViewTextBoxColumn userList_Id;
        private DataGridViewTextBoxColumn userList_ThuTu;
        private DataGridViewTextBoxColumn userList_Ten;
        private DataGridViewTextBoxColumn userList_QuanHamId;
        private DataGridViewTextBoxColumn userList_QuanHam;
        private DataGridViewTextBoxColumn userList_ChucVu;
        private DataGridViewTextBoxColumn userList_DonVi;
        private DataGridViewTextBoxColumn userList_GhiChu;
        private DataGridViewTextBoxColumn NamSinhHv;
        private DataGridViewTextBoxColumn gvList_Id;
        private DataGridViewTextBoxColumn gvList_ThuTu;
        private DataGridViewTextBoxColumn gvList_Ten;
        private DataGridViewTextBoxColumn gvList_QuanHamId;
        private DataGridViewTextBoxColumn gvList_QuanHam;
        private DataGridViewTextBoxColumn gvList_NamSinh;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ThuTu;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn QuanHamId;
        private DataGridViewTextBoxColumn QuanHam;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn NamSinh;
    }
}