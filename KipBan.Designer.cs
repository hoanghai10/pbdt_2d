namespace PBDT_2D
{
    partial class KipBan
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            grdTeacher = new DataGridView();
            teacher_Id = new DataGridViewTextBoxColumn();
            teacher_ThuTu = new DataGridViewTextBoxColumn();
            teacher_QuanHamId = new DataGridViewTextBoxColumn();
            teacher_Ten = new DataGridViewTextBoxColumn();
            teacher_QuanHam = new DataGridViewTextBoxColumn();
            teacher_NamSinh = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            grdUsersShooting = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ThuTu = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            QuanHamId = new DataGridViewTextBoxColumn();
            QuanHam = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            NamSinh = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTeacher).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsersShooting).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7809191F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2544174F));
            tableLayoutPanel1.Size = new Size(929, 566);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grdTeacher);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 399);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(923, 71);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giáo viên";
            // 
            // grdTeacher
            // 
            grdTeacher.AllowUserToResizeRows = false;
            grdTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTeacher.Columns.AddRange(new DataGridViewColumn[] { teacher_Id, teacher_ThuTu, teacher_QuanHamId, teacher_Ten, teacher_QuanHam, teacher_NamSinh });
            grdTeacher.Dock = DockStyle.Fill;
            grdTeacher.Location = new Point(3, 19);
            grdTeacher.Margin = new Padding(4, 3, 4, 3);
            grdTeacher.MultiSelect = false;
            grdTeacher.Name = "grdTeacher";
            grdTeacher.RowHeadersVisible = false;
            grdTeacher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTeacher.Size = new Size(917, 49);
            grdTeacher.TabIndex = 1;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(grdUsersShooting);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(923, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách học viên";
            // 
            // grdUsersShooting
            // 
            grdUsersShooting.AllowUserToResizeRows = false;
            grdUsersShooting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsersShooting.Columns.AddRange(new DataGridViewColumn[] { Id, ThuTu, Ten, QuanHamId, QuanHam, ChucVu, DonVi, GhiChu, NamSinh });
            grdUsersShooting.Dock = DockStyle.Fill;
            grdUsersShooting.Location = new Point(3, 19);
            grdUsersShooting.Margin = new Padding(4, 3, 4, 3);
            grdUsersShooting.MultiSelect = false;
            grdUsersShooting.Name = "grdUsersShooting";
            grdUsersShooting.RowHeadersVisible = false;
            grdUsersShooting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsersShooting.Size = new Size(917, 368);
            grdUsersShooting.TabIndex = 2;
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
            // KipBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 566);
            Controls.Add(tableLayoutPanel1);
            Name = "KipBan";
            Text = "KipBan";
            Load += KipBan_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdTeacher).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdUsersShooting).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView grdUsersShooting;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ThuTu;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn QuanHamId;
        private DataGridViewTextBoxColumn QuanHam;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn NamSinh;
        private DataGridView grdTeacher;
        private DataGridViewTextBoxColumn teacher_Id;
        private DataGridViewTextBoxColumn teacher_ThuTu;
        private DataGridViewTextBoxColumn teacher_QuanHamId;
        private DataGridViewTextBoxColumn teacher_Ten;
        private DataGridViewTextBoxColumn teacher_QuanHam;
        private DataGridViewTextBoxColumn teacher_NamSinh;
    }
}