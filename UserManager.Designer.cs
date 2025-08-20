namespace PBDT_2D
{
    partial class UserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            grdUsers = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ThuTu = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            QuanHamId = new DataGridViewTextBoxColumn();
            QuanHam = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            NamSinh = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabQLGQ = new TabPage();
            gbFilter = new GroupBox();
            layoutFilter = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            filterTenGV = new TextBox();
            groupBox2 = new GroupBox();
            filterQuanHamGV = new ComboBox();
            groupBox3 = new GroupBox();
            filterNamSinhGV = new TextBox();
            btnResetFilter = new Button();
            tabQLHV = new TabPage();
            groupBox9 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            d = new GroupBox();
            filterNamSinhHV = new TextBox();
            groupBox8 = new GroupBox();
            filterTenHV = new TextBox();
            groupBox7 = new GroupBox();
            filterQuanHamHV = new ComboBox();
            groupBox6 = new GroupBox();
            filterChucVu = new TextBox();
            groupBox4 = new GroupBox();
            filterDonVi = new TextBox();
            groupBox5 = new GroupBox();
            filterGhiChu = new TextBox();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).BeginInit();
            tabControl1.SuspendLayout();
            tabQLGQ.SuspendLayout();
            gbFilter.SuspendLayout();
            layoutFilter.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabQLHV.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            d.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(grdUsers, 0, 1);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.Size = new Size(1304, 928);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel3.Controls.Add(button1, 1, 0);
            tableLayoutPanel3.Controls.Add(button3, 2, 0);
            tableLayoutPanel3.Controls.Add(button2, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 856);
            tableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1296, 69);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(783, 12);
            button1.Margin = new Padding(12);
            button1.Name = "button1";
            button1.Size = new Size(151, 45);
            button1.TabIndex = 0;
            button1.Text = "Xóa";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDelete_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(958, 12);
            button3.Margin = new Padding(12);
            button3.Name = "button3";
            button3.Size = new Size(151, 45);
            button3.TabIndex = 1;
            button3.Text = "Sửa";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnEdit_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1133, 12);
            button2.Margin = new Padding(12);
            button2.Name = "button2";
            button2.Size = new Size(151, 45);
            button2.TabIndex = 2;
            button2.Text = "Thêm";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAdd_Click;
            // 
            // grdUsers
            // 
            grdUsers.AllowUserToResizeRows = false;
            grdUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsers.Columns.AddRange(new DataGridViewColumn[] { Id, ThuTu, HoTen, QuanHamId, QuanHam, ChucVu, DonVi, GhiChu, NamSinh });
            grdUsers.Dock = DockStyle.Fill;
            grdUsers.Location = new Point(4, 123);
            grdUsers.Margin = new Padding(4, 3, 4, 3);
            grdUsers.MultiSelect = false;
            grdUsers.Name = "grdUsers";
            grdUsers.RowHeadersVisible = false;
            grdUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsers.Size = new Size(1296, 727);
            grdUsers.TabIndex = 1;
            grdUsers.CellDoubleClick += grdUsers_CellDoubleClick;
            grdUsers.SelectionChanged += grdUsers_SelectionChanged;
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
            ThuTu.Width = 50;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Tên";
            HoTen.MinimumWidth = 150;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 200;
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
            QuanHam.MinimumWidth = 50;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabQLGQ);
            tabControl1.Controls.Add(tabQLHV);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1298, 114);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Click += btnResetFilterHV_Click;
            // 
            // tabQLGQ
            // 
            tabQLGQ.Controls.Add(gbFilter);
            tabQLGQ.Location = new Point(4, 24);
            tabQLGQ.Name = "tabQLGQ";
            tabQLGQ.Padding = new Padding(3);
            tabQLGQ.Size = new Size(1290, 86);
            tabQLGQ.TabIndex = 0;
            tabQLGQ.Text = "Quản lý giáo quan";
            tabQLGQ.UseVisualStyleBackColor = true;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(layoutFilter);
            gbFilter.Dock = DockStyle.Fill;
            gbFilter.Location = new Point(3, 3);
            gbFilter.Margin = new Padding(4, 3, 4, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(4, 3, 4, 3);
            gbFilter.Size = new Size(1284, 80);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Lọc";
            // 
            // layoutFilter
            // 
            layoutFilter.ColumnCount = 4;
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            layoutFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            layoutFilter.Controls.Add(groupBox1, 0, 0);
            layoutFilter.Controls.Add(groupBox2, 1, 0);
            layoutFilter.Controls.Add(groupBox3, 2, 0);
            layoutFilter.Controls.Add(btnResetFilter, 3, 0);
            layoutFilter.Dock = DockStyle.Fill;
            layoutFilter.Location = new Point(4, 19);
            layoutFilter.Margin = new Padding(4, 3, 4, 3);
            layoutFilter.Name = "layoutFilter";
            layoutFilter.RowCount = 1;
            layoutFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutFilter.Size = new Size(1276, 58);
            layoutFilter.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(filterTenGV);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(377, 52);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên";
            // 
            // filterTenGV
            // 
            filterTenGV.Dock = DockStyle.Fill;
            filterTenGV.Location = new Point(4, 19);
            filterTenGV.Margin = new Padding(4, 3, 4, 3);
            filterTenGV.Name = "filterTenGV";
            filterTenGV.Size = new Size(369, 23);
            filterTenGV.TabIndex = 0;
            filterTenGV.TextChanged += FilterChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(filterQuanHamGV);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(389, 3);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(377, 52);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quân hàm";
            // 
            // filterQuanHamGV
            // 
            filterQuanHamGV.Dock = DockStyle.Fill;
            filterQuanHamGV.FormattingEnabled = true;
            filterQuanHamGV.Location = new Point(4, 19);
            filterQuanHamGV.Margin = new Padding(4, 3, 4, 3);
            filterQuanHamGV.Name = "filterQuanHamGV";
            filterQuanHamGV.Size = new Size(369, 23);
            filterQuanHamGV.TabIndex = 0;
            filterQuanHamGV.TextChanged += FilterChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(filterNamSinhGV);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(774, 3);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(377, 52);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Năm sinh";
            // 
            // filterNamSinhGV
            // 
            filterNamSinhGV.Dock = DockStyle.Fill;
            filterNamSinhGV.Location = new Point(4, 19);
            filterNamSinhGV.Margin = new Padding(4, 3, 4, 3);
            filterNamSinhGV.Name = "filterNamSinhGV";
            filterNamSinhGV.Size = new Size(369, 23);
            filterNamSinhGV.TabIndex = 0;
            filterNamSinhGV.TextChanged += FilterChanged;
            // 
            // btnResetFilter
            // 
            btnResetFilter.Dock = DockStyle.Fill;
            btnResetFilter.Image = (Image)resources.GetObject("btnResetFilter.Image");
            btnResetFilter.Location = new Point(1167, 12);
            btnResetFilter.Margin = new Padding(12);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(97, 34);
            btnResetFilter.TabIndex = 10;
            btnResetFilter.Text = "Cài đặt lại";
            btnResetFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilterGV_Click;
            // 
            // tabQLHV
            // 
            tabQLHV.Controls.Add(groupBox9);
            tabQLHV.Location = new Point(4, 24);
            tabQLHV.Name = "tabQLHV";
            tabQLHV.Padding = new Padding(3);
            tabQLHV.Size = new Size(1290, 86);
            tabQLHV.TabIndex = 1;
            tabQLHV.Text = "Quản lý học viên";
            tabQLHV.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tableLayoutPanel2);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Location = new Point(3, 3);
            groupBox9.Margin = new Padding(4, 3, 4, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(4, 3, 4, 3);
            groupBox9.Size = new Size(1284, 80);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            groupBox9.Text = "Lọc";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            tableLayoutPanel2.Controls.Add(d, 5, 0);
            tableLayoutPanel2.Controls.Add(groupBox8, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox7, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox6, 2, 0);
            tableLayoutPanel2.Controls.Add(groupBox4, 3, 0);
            tableLayoutPanel2.Controls.Add(groupBox5, 4, 0);
            tableLayoutPanel2.Controls.Add(button4, 6, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 19);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1276, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // d
            // 
            d.Controls.Add(filterNamSinhHV);
            d.Dock = DockStyle.Fill;
            d.Location = new Point(964, 3);
            d.Margin = new Padding(4, 3, 4, 3);
            d.Name = "d";
            d.Padding = new Padding(4, 3, 4, 3);
            d.Size = new Size(184, 52);
            d.TabIndex = 11;
            d.TabStop = false;
            d.Text = "Năm sinh";
            // 
            // filterNamSinhHV
            // 
            filterNamSinhHV.Dock = DockStyle.Fill;
            filterNamSinhHV.Location = new Point(4, 19);
            filterNamSinhHV.Margin = new Padding(4, 3, 4, 3);
            filterNamSinhHV.Name = "filterNamSinhHV";
            filterNamSinhHV.Size = new Size(176, 23);
            filterNamSinhHV.TabIndex = 0;
            filterNamSinhHV.TextChanged += FilterChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(filterTenHV);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.Location = new Point(4, 3);
            groupBox8.Margin = new Padding(4, 3, 4, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(4, 3, 4, 3);
            groupBox8.Size = new Size(184, 52);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Tên";
            // 
            // filterTenHV
            // 
            filterTenHV.Dock = DockStyle.Fill;
            filterTenHV.Location = new Point(4, 19);
            filterTenHV.Margin = new Padding(4, 3, 4, 3);
            filterTenHV.Name = "filterTenHV";
            filterTenHV.Size = new Size(176, 23);
            filterTenHV.TabIndex = 0;
            filterTenHV.TextChanged += FilterChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(filterQuanHamHV);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(196, 3);
            groupBox7.Margin = new Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4, 3, 4, 3);
            groupBox7.Size = new Size(184, 52);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Quân hàm";
            // 
            // filterQuanHamHV
            // 
            filterQuanHamHV.Dock = DockStyle.Fill;
            filterQuanHamHV.FormattingEnabled = true;
            filterQuanHamHV.Location = new Point(4, 19);
            filterQuanHamHV.Margin = new Padding(4, 3, 4, 3);
            filterQuanHamHV.Name = "filterQuanHamHV";
            filterQuanHamHV.Size = new Size(176, 23);
            filterQuanHamHV.TabIndex = 0;
            filterQuanHamHV.TextChanged += FilterChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(filterChucVu);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(388, 3);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(184, 52);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chức vụ";
            // 
            // filterChucVu
            // 
            filterChucVu.Dock = DockStyle.Fill;
            filterChucVu.Location = new Point(4, 19);
            filterChucVu.Margin = new Padding(4, 3, 4, 3);
            filterChucVu.Name = "filterChucVu";
            filterChucVu.Size = new Size(176, 23);
            filterChucVu.TabIndex = 0;
            filterChucVu.TextChanged += FilterChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(filterDonVi);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(580, 3);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(184, 52);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Đơn vị";
            // 
            // filterDonVi
            // 
            filterDonVi.Dock = DockStyle.Fill;
            filterDonVi.Location = new Point(4, 19);
            filterDonVi.Margin = new Padding(4, 3, 4, 3);
            filterDonVi.Name = "filterDonVi";
            filterDonVi.Size = new Size(176, 23);
            filterDonVi.TabIndex = 0;
            filterDonVi.TextChanged += FilterChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(filterGhiChu);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(772, 3);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(184, 52);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ghi chú";
            // 
            // filterGhiChu
            // 
            filterGhiChu.Dock = DockStyle.Fill;
            filterGhiChu.Location = new Point(4, 19);
            filterGhiChu.Margin = new Padding(4, 3, 4, 3);
            filterGhiChu.Name = "filterGhiChu";
            filterGhiChu.Size = new Size(176, 23);
            filterGhiChu.TabIndex = 0;
            filterGhiChu.TextChanged += FilterChanged;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1164, 12);
            button4.Margin = new Padding(12);
            button4.Name = "button4";
            button4.Size = new Size(100, 34);
            button4.TabIndex = 10;
            button4.Text = "Cài đặt lại";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // UserManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 928);
            Controls.Add(tableLayoutPanel1);
            Name = "UserManager";
            Text = "UserManager";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdUsers).EndInit();
            tabControl1.ResumeLayout(false);
            tabQLGQ.ResumeLayout(false);
            gbFilter.ResumeLayout(false);
            layoutFilter.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabQLHV.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            d.ResumeLayout(false);
            d.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabQLGQ;
        private TabPage tabQLHV;
        private GroupBox gbFilter;
        private TableLayoutPanel layoutFilter;
        private GroupBox groupBox1;
        private TextBox filterTenGV;
        private GroupBox groupBox2;
        private ComboBox filterQuanHamGV;
        private GroupBox groupBox3;
        private TextBox filterNamSinhGV;
        private Button btnResetFilter;
        private GroupBox groupBox9;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox8;
        private TextBox filterTenHV;
        private GroupBox groupBox7;
        private ComboBox filterQuanHamHV;
        private GroupBox groupBox6;
        private TextBox filterChucVu;
        private GroupBox groupBox4;
        private TextBox filterDonVi;
        private GroupBox groupBox5;
        private TextBox filterGhiChu;
        private Button button4;
        private DataGridView grdUsers;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button3;
        private Button button2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ThuTu;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn QuanHamId;
        private DataGridViewTextBoxColumn QuanHam;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn NamSinh;
        private GroupBox d;
        private TextBox filterNamSinhHV;
    }
}