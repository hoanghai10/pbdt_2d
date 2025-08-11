namespace PBDT_2D
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tabControl1 = new TabControl();
            tabQLGV = new TabPage();
            tabQLHV = new TabPage();
            imageList1 = new ImageList(components);
            btnDelete = new Button();
            btnAdd = new Button();
            layoutFunctions = new TableLayoutPanel();
            btnEdit = new Button();
            filterNamSinh = new TextBox();
            filterQuanHam = new ComboBox();
            filterTen = new TextBox();
            layoutFilter = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnResetFilter = new Button();
            QuanHam = new DataGridViewTextBoxColumn();
            NamSinh = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            QuanHamId = new DataGridViewTextBoxColumn();
            ThuTu = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            layoutMain = new TableLayoutPanel();
            grdGiaoVu = new DataGridView();
            gbFilter = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            filterGhiChu = new TextBox();
            groupBox5 = new GroupBox();
            filterDonVi = new TextBox();
            groupBox4 = new GroupBox();
            filterChucVu = new TextBox();
            groupBox6 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox7 = new GroupBox();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox8 = new GroupBox();
            groupBox9 = new GroupBox();
            GhiChu = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            grdUsers = new DataGridView();
            tabControl1.SuspendLayout();
            tabQLGV.SuspendLayout();
            tabQLHV.SuspendLayout();
            layoutFunctions.SuspendLayout();
            layoutFilter.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            layoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdGiaoVu).BeginInit();
            gbFilter.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabQLGV);
            tabControl1.Controls.Add(tabQLHV);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1248, 892);
            tabControl1.TabIndex = 0;
            // 
            // tabQLGV
            // 
            tabQLGV.Controls.Add(layoutMain);
            tabQLGV.Location = new Point(4, 24);
            tabQLGV.Name = "tabQLGV";
            tabQLGV.Padding = new Padding(3);
            tabQLGV.Size = new Size(1240, 864);
            tabQLGV.TabIndex = 0;
            tabQLGV.Text = "Quản lý giáo vụ";
            tabQLGV.UseVisualStyleBackColor = true;
            // 
            // tabQLHV
            // 
            tabQLHV.Controls.Add(tableLayoutPanel3);
            tabQLHV.Location = new Point(4, 24);
            tabQLHV.Name = "tabQLHV";
            tabQLHV.Padding = new Padding(3);
            tabQLHV.Size = new Size(1240, 864);
            tabQLHV.TabIndex = 1;
            tabQLHV.Text = "Quản lý học viên";
            tabQLHV.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(713, 12);
            btnDelete.Margin = new Padding(12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 51);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(1063, 12);
            btnAdd.Margin = new Padding(12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 51);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // layoutFunctions
            // 
            layoutFunctions.ColumnCount = 4;
            layoutFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            layoutFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            layoutFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            layoutFunctions.Controls.Add(btnDelete, 1, 0);
            layoutFunctions.Controls.Add(btnEdit, 2, 0);
            layoutFunctions.Controls.Add(btnAdd, 3, 0);
            layoutFunctions.Dock = DockStyle.Fill;
            layoutFunctions.Location = new Point(4, 780);
            layoutFunctions.Margin = new Padding(4, 3, 4, 3);
            layoutFunctions.Name = "layoutFunctions";
            layoutFunctions.RowCount = 1;
            layoutFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutFunctions.Size = new Size(1226, 75);
            layoutFunctions.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(888, 12);
            btnEdit.Margin = new Padding(12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(151, 51);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // filterNamSinh
            // 
            filterNamSinh.Dock = DockStyle.Fill;
            filterNamSinh.Location = new Point(4, 19);
            filterNamSinh.Margin = new Padding(4, 3, 4, 3);
            filterNamSinh.Name = "filterNamSinh";
            filterNamSinh.Size = new Size(350, 23);
            filterNamSinh.TabIndex = 0;
            // 
            // filterQuanHam
            // 
            filterQuanHam.Dock = DockStyle.Fill;
            filterQuanHam.FormattingEnabled = true;
            filterQuanHam.Location = new Point(4, 19);
            filterQuanHam.Margin = new Padding(4, 3, 4, 3);
            filterQuanHam.Name = "filterQuanHam";
            filterQuanHam.Size = new Size(350, 23);
            filterQuanHam.TabIndex = 0;
            // 
            // filterTen
            // 
            filterTen.Dock = DockStyle.Fill;
            filterTen.Location = new Point(4, 19);
            filterTen.Margin = new Padding(4, 3, 4, 3);
            filterTen.Name = "filterTen";
            filterTen.Size = new Size(350, 23);
            filterTen.TabIndex = 0;
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
            layoutFilter.Size = new Size(1218, 64);
            layoutFilter.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(filterTen);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(358, 58);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(filterQuanHam);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(370, 3);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(358, 58);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quân hàm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(filterNamSinh);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(736, 3);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(358, 58);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Năm sinh";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Dock = DockStyle.Fill;
            btnResetFilter.Image = (Image)resources.GetObject("btnResetFilter.Image");
            btnResetFilter.Location = new Point(1110, 12);
            btnResetFilter.Margin = new Padding(12);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(96, 40);
            btnResetFilter.TabIndex = 10;
            btnResetFilter.Text = "Cài đặt lại";
            btnResetFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetFilter.UseVisualStyleBackColor = true;
            // 
            // QuanHam
            // 
            QuanHam.DataPropertyName = "QuanHam";
            QuanHam.HeaderText = "Quân hàm";
            QuanHam.MinimumWidth = 50;
            QuanHam.Name = "QuanHam";
            QuanHam.ReadOnly = true;
            // 
            // NamSinh
            // 
            NamSinh.DataPropertyName = "NamSinh";
            NamSinh.HeaderText = "Năm sinh";
            NamSinh.MinimumWidth = 50;
            NamSinh.Name = "NamSinh";
            NamSinh.ReadOnly = true;
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
            // ThuTu
            // 
            ThuTu.DataPropertyName = "ThuTu";
            ThuTu.HeaderText = "STT";
            ThuTu.Name = "ThuTu";
            ThuTu.ReadOnly = true;
            ThuTu.Resizable = DataGridViewTriState.False;
            ThuTu.Width = 50;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 1;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMain.Controls.Add(grdGiaoVu, 0, 0);
            layoutMain.Controls.Add(gbFilter, 0, 1);
            layoutMain.Controls.Add(layoutFunctions, 0, 2);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(3, 3);
            layoutMain.Margin = new Padding(4, 3, 4, 3);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 3;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            layoutMain.Size = new Size(1234, 858);
            layoutMain.TabIndex = 1;
            // 
            // grdGiaoVu
            // 
            grdGiaoVu.AllowUserToResizeRows = false;
            grdGiaoVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdGiaoVu.Columns.AddRange(new DataGridViewColumn[] { Id, ThuTu, QuanHamId, HoTen, NamSinh, QuanHam });
            grdGiaoVu.Dock = DockStyle.Fill;
            grdGiaoVu.Location = new Point(4, 3);
            grdGiaoVu.Margin = new Padding(4, 3, 4, 3);
            grdGiaoVu.MultiSelect = false;
            grdGiaoVu.Name = "grdGiaoVu";
            grdGiaoVu.RowHeadersVisible = false;
            grdGiaoVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdGiaoVu.Size = new Size(1226, 679);
            grdGiaoVu.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(layoutFilter);
            gbFilter.Dock = DockStyle.Fill;
            gbFilter.Location = new Point(4, 688);
            gbFilter.Margin = new Padding(4, 3, 4, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(4, 3, 4, 3);
            gbFilter.Size = new Size(1226, 86);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Lọc";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(713, 12);
            button1.Margin = new Padding(12);
            button1.Name = "button1";
            button1.Size = new Size(151, 51);
            button1.TabIndex = 0;
            button1.Text = "Xóa";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1063, 12);
            button2.Margin = new Padding(12);
            button2.Name = "button2";
            button2.Size = new Size(151, 51);
            button2.TabIndex = 2;
            button2.Text = "Thêm";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 780);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1226, 75);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(888, 12);
            button3.Margin = new Padding(12);
            button3.Name = "button3";
            button3.Size = new Size(151, 51);
            button3.TabIndex = 1;
            button3.Text = "Sửa";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1107, 12);
            button4.Margin = new Padding(12);
            button4.Name = "button4";
            button4.Size = new Size(99, 40);
            button4.TabIndex = 10;
            button4.Text = "Cài đặt lại";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // filterGhiChu
            // 
            filterGhiChu.Dock = DockStyle.Fill;
            filterGhiChu.Location = new Point(4, 19);
            filterGhiChu.Margin = new Padding(4, 3, 4, 3);
            filterGhiChu.Name = "filterGhiChu";
            filterGhiChu.Size = new Size(203, 23);
            filterGhiChu.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(filterGhiChu);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(880, 3);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(211, 58);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ghi chú";
            // 
            // filterDonVi
            // 
            filterDonVi.Dock = DockStyle.Fill;
            filterDonVi.Location = new Point(4, 19);
            filterDonVi.Margin = new Padding(4, 3, 4, 3);
            filterDonVi.Name = "filterDonVi";
            filterDonVi.Size = new Size(203, 23);
            filterDonVi.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(filterDonVi);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(661, 3);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(211, 58);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Đơn vị";
            // 
            // filterChucVu
            // 
            filterChucVu.Dock = DockStyle.Fill;
            filterChucVu.Location = new Point(4, 19);
            filterChucVu.Margin = new Padding(4, 3, 4, 3);
            filterChucVu.Name = "filterChucVu";
            filterChucVu.Size = new Size(203, 23);
            filterChucVu.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(filterChucVu);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(442, 3);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(211, 58);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chức vụ";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(4, 19);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(comboBox1);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(223, 3);
            groupBox7.Margin = new Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4, 3, 4, 3);
            groupBox7.Size = new Size(211, 58);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Quân hàm";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(4, 19);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            tableLayoutPanel2.Controls.Add(groupBox8, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox7, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox6, 2, 0);
            tableLayoutPanel2.Controls.Add(groupBox4, 3, 0);
            tableLayoutPanel2.Controls.Add(groupBox5, 4, 0);
            tableLayoutPanel2.Controls.Add(button4, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 19);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1218, 64);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox1);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.Location = new Point(4, 3);
            groupBox8.Margin = new Padding(4, 3, 4, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(4, 3, 4, 3);
            groupBox8.Size = new Size(211, 58);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Tên";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tableLayoutPanel2);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Location = new Point(4, 688);
            groupBox9.Margin = new Padding(4, 3, 4, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(4, 3, 4, 3);
            groupBox9.Size = new Size(1226, 86);
            groupBox9.TabIndex = 1;
            groupBox9.TabStop = false;
            groupBox9.Text = "Lọc";
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
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 100;
            DonVi.Name = "DonVi";
            DonVi.ReadOnly = true;
            DonVi.Width = 150;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "QuanHam";
            dataGridViewTextBoxColumn1.HeaderText = "Quân hàm";
            dataGridViewTextBoxColumn1.MinimumWidth = 50;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "QuanHamId";
            dataGridViewTextBoxColumn2.HeaderText = "QuanHamId";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Visible = false;
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
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "ThuTu";
            dataGridViewTextBoxColumn3.HeaderText = "STT";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            dataGridViewTextBoxColumn4.HeaderText = "Id";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(grdUsers, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox9, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel3.Size = new Size(1234, 858);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // grdUsers
            // 
            grdUsers.AllowUserToResizeRows = false;
            grdUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn3, Ten, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn1, ChucVu, DonVi, GhiChu });
            grdUsers.Dock = DockStyle.Fill;
            grdUsers.Location = new Point(4, 3);
            grdUsers.Margin = new Padding(4, 3, 4, 3);
            grdUsers.MultiSelect = false;
            grdUsers.Name = "grdUsers";
            grdUsers.RowHeadersVisible = false;
            grdUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsers.Size = new Size(1226, 679);
            grdUsers.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 892);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            tabQLGV.ResumeLayout(false);
            tabQLHV.ResumeLayout(false);
            layoutFunctions.ResumeLayout(false);
            layoutFilter.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            layoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdGiaoVu).EndInit();
            gbFilter.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabQLGV;
        private TabPage tabQLHV;
        private ImageList imageList1;
        private TableLayoutPanel layoutMain;
        private DataGridView grdGiaoVu;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ThuTu;
        private DataGridViewTextBoxColumn QuanHamId;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NamSinh;
        private DataGridViewTextBoxColumn QuanHam;
        private GroupBox gbFilter;
        private TableLayoutPanel layoutFilter;
        private GroupBox groupBox1;
        private TextBox filterTen;
        private GroupBox groupBox2;
        private ComboBox filterQuanHam;
        private GroupBox groupBox3;
        private TextBox filterNamSinh;
        private Button btnResetFilter;
        private TableLayoutPanel layoutFunctions;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView grdUsers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn GhiChu;
        private GroupBox groupBox9;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox8;
        private TextBox textBox1;
        private GroupBox groupBox7;
        private ComboBox comboBox1;
        private GroupBox groupBox6;
        private TextBox filterChucVu;
        private GroupBox groupBox4;
        private TextBox filterDonVi;
        private GroupBox groupBox5;
        private TextBox filterGhiChu;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}