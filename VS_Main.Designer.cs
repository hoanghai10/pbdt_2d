namespace TBDT_2D.Forms
{
    partial class VS_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VS_Main));
            layoutMain = new TableLayoutPanel();
            layoutLeft = new TableLayoutPanel();
            leftTop_gbLoaiSung = new GroupBox();
            leftTop_cboLoaiSung = new ComboBox();
            leftMid_gbDSBB = new GroupBox();
            leftMid_grdDSBB = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TenBB = new DataGridViewTextBoxColumn();
            IdSung = new DataGridViewTextBoxColumn();
            SoLuongDan = new DataGridViewTextBoxColumn();
            DanhSachBia = new DataGridViewTextBoxColumn();
            ThuTuSapXep2D = new DataGridViewTextBoxColumn();
            ThoiGianAnHien = new DataGridViewTextBoxColumn();
            DiemGioi = new DataGridViewTextBoxColumn();
            DiemKha = new DataGridViewTextBoxColumn();
            DiemDat = new DataGridViewTextBoxColumn();
            ScoreType = new DataGridViewTextBoxColumn();
            DisplayType = new DataGridViewTextBoxColumn();
            BiaDKKha = new DataGridViewTextBoxColumn();
            BiaKoTrungTruDiem = new DataGridViewTextBoxColumn();
            BiaKoDuocBan = new DataGridViewTextBoxColumn();
            TotalHitCheck = new DataGridViewCheckBoxColumn();
            TotalHit_Gioi = new DataGridViewTextBoxColumn();
            TotalHit_Kha = new DataGridViewTextBoxColumn();
            TotalHit_Dat = new DataGridViewTextBoxColumn();
            FirstHitCheck = new DataGridViewCheckBoxColumn();
            FirstHit_Gioi = new DataGridViewTextBoxColumn();
            FirstHit_Kha = new DataGridViewTextBoxColumn();
            FirstHit_Dat = new DataGridViewTextBoxColumn();
            BulletRemainsCheck = new DataGridViewCheckBoxColumn();
            BulletRemain_Gioi = new DataGridViewCheckBoxColumn();
            BulletRemain_Kha = new DataGridViewCheckBoxColumn();
            BulletRemain_Dat = new DataGridViewCheckBoxColumn();
            DrawHitPoint = new DataGridViewCheckBoxColumn();
            leftBot_gbConnect = new GroupBox();
            leftBot_lblConnect = new Label();
            leftBot_gbOtherFunctions = new GroupBox();
            leftBot_layoutOtherFunctions = new TableLayoutPanel();
            leftbot_btngv = new Button();
            leftBot_btnUser = new Button();
            leftBot_btnCrewSetup = new Button();
            leftBot_btnSearch = new Button();
            layout_Center = new TableLayoutPanel();
            midTop_gbHABB = new GroupBox();
            midTop_picHABB = new PictureBox();
            midBot_gbMainFunctions = new GroupBox();
            layout_MidBot = new TableLayoutPanel();
            midBot_btnStop = new Button();
            midBot_btnViewHABeBan = new Button();
            midBot_btnStart = new Button();
            layoutRight = new TableLayoutPanel();
            rightTop_gbDieuKienBB = new GroupBox();
            rightTop_layoutDieuKienBB = new FlowLayoutPanel();
            rightBot_gbDKBBFunctions = new GroupBox();
            rightBot_layoutBtnsDKBB = new TableLayoutPanel();
            rightBot_btnEditDKBB = new Button();
            rightBot_btnCancelDKBB = new Button();
            layoutMain.SuspendLayout();
            layoutLeft.SuspendLayout();
            leftTop_gbLoaiSung.SuspendLayout();
            leftMid_gbDSBB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leftMid_grdDSBB).BeginInit();
            leftBot_gbConnect.SuspendLayout();
            leftBot_gbOtherFunctions.SuspendLayout();
            leftBot_layoutOtherFunctions.SuspendLayout();
            layout_Center.SuspendLayout();
            midTop_gbHABB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)midTop_picHABB).BeginInit();
            midBot_gbMainFunctions.SuspendLayout();
            layout_MidBot.SuspendLayout();
            layoutRight.SuspendLayout();
            rightTop_gbDieuKienBB.SuspendLayout();
            rightBot_gbDKBBFunctions.SuspendLayout();
            rightBot_layoutBtnsDKBB.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 3;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 292F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.94118F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.05882F));
            layoutMain.Controls.Add(layoutLeft, 0, 0);
            layoutMain.Controls.Add(layout_Center, 1, 0);
            layoutMain.Controls.Add(layoutRight, 2, 0);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(4, 3, 4, 3);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 1;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(1433, 858);
            layoutMain.TabIndex = 0;
            // 
            // layoutLeft
            // 
            layoutLeft.ColumnCount = 1;
            layoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutLeft.Controls.Add(leftTop_gbLoaiSung, 0, 0);
            layoutLeft.Controls.Add(leftMid_gbDSBB, 0, 1);
            layoutLeft.Controls.Add(leftBot_gbConnect, 0, 3);
            layoutLeft.Controls.Add(leftBot_gbOtherFunctions, 0, 2);
            layoutLeft.Dock = DockStyle.Fill;
            layoutLeft.Location = new Point(4, 3);
            layoutLeft.Margin = new Padding(4, 3, 4, 3);
            layoutLeft.Name = "layoutLeft";
            layoutLeft.RowCount = 4;
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 288F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            layoutLeft.Size = new Size(284, 852);
            layoutLeft.TabIndex = 0;
            // 
            // leftTop_gbLoaiSung
            // 
            leftTop_gbLoaiSung.Controls.Add(leftTop_cboLoaiSung);
            leftTop_gbLoaiSung.Dock = DockStyle.Fill;
            leftTop_gbLoaiSung.Location = new Point(4, 3);
            leftTop_gbLoaiSung.Margin = new Padding(4, 3, 4, 3);
            leftTop_gbLoaiSung.Name = "leftTop_gbLoaiSung";
            leftTop_gbLoaiSung.Padding = new Padding(4, 3, 4, 3);
            leftTop_gbLoaiSung.Size = new Size(276, 52);
            leftTop_gbLoaiSung.TabIndex = 0;
            leftTop_gbLoaiSung.TabStop = false;
            leftTop_gbLoaiSung.Text = "Súng";
            // 
            // leftTop_cboLoaiSung
            // 
            leftTop_cboLoaiSung.Dock = DockStyle.Fill;
            leftTop_cboLoaiSung.DropDownStyle = ComboBoxStyle.DropDownList;
            leftTop_cboLoaiSung.FormattingEnabled = true;
            leftTop_cboLoaiSung.Location = new Point(4, 19);
            leftTop_cboLoaiSung.Margin = new Padding(4, 3, 4, 3);
            leftTop_cboLoaiSung.Name = "leftTop_cboLoaiSung";
            leftTop_cboLoaiSung.Size = new Size(268, 23);
            leftTop_cboLoaiSung.TabIndex = 0;
            // 
            // leftMid_gbDSBB
            // 
            leftMid_gbDSBB.Controls.Add(leftMid_grdDSBB);
            leftMid_gbDSBB.Dock = DockStyle.Fill;
            leftMid_gbDSBB.Location = new Point(4, 61);
            leftMid_gbDSBB.Margin = new Padding(4, 3, 4, 3);
            leftMid_gbDSBB.Name = "leftMid_gbDSBB";
            leftMid_gbDSBB.Padding = new Padding(4, 3, 4, 3);
            leftMid_gbDSBB.Size = new Size(276, 448);
            leftMid_gbDSBB.TabIndex = 1;
            leftMid_gbDSBB.TabStop = false;
            leftMid_gbDSBB.Text = "Danh sách bài bắn";
            // 
            // leftMid_grdDSBB
            // 
            leftMid_grdDSBB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            leftMid_grdDSBB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leftMid_grdDSBB.Columns.AddRange(new DataGridViewColumn[] { Id, TenBB, IdSung, SoLuongDan, DanhSachBia, ThuTuSapXep2D, ThoiGianAnHien, DiemGioi, DiemKha, DiemDat, ScoreType, DisplayType, BiaDKKha, BiaKoTrungTruDiem, BiaKoDuocBan, TotalHitCheck, TotalHit_Gioi, TotalHit_Kha, TotalHit_Dat, FirstHitCheck, FirstHit_Gioi, FirstHit_Kha, FirstHit_Dat, BulletRemainsCheck, BulletRemain_Gioi, BulletRemain_Kha, BulletRemain_Dat, DrawHitPoint });
            leftMid_grdDSBB.Dock = DockStyle.Fill;
            leftMid_grdDSBB.Location = new Point(4, 19);
            leftMid_grdDSBB.Margin = new Padding(4, 3, 4, 3);
            leftMid_grdDSBB.MultiSelect = false;
            leftMid_grdDSBB.Name = "leftMid_grdDSBB";
            leftMid_grdDSBB.ReadOnly = true;
            leftMid_grdDSBB.RowTemplate.Resizable = DataGridViewTriState.False;
            leftMid_grdDSBB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            leftMid_grdDSBB.Size = new Size(268, 426);
            leftMid_grdDSBB.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // TenBB
            // 
            TenBB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenBB.DataPropertyName = "TenBB";
            TenBB.HeaderText = "Tên bài bắn";
            TenBB.MinimumWidth = 100;
            TenBB.Name = "TenBB";
            TenBB.ReadOnly = true;
            // 
            // IdSung
            // 
            IdSung.DataPropertyName = "IdSung";
            IdSung.HeaderText = "IdSung";
            IdSung.Name = "IdSung";
            IdSung.ReadOnly = true;
            IdSung.Visible = false;
            // 
            // SoLuongDan
            // 
            SoLuongDan.DataPropertyName = "SoLuongDan";
            SoLuongDan.HeaderText = "SoLuongDan";
            SoLuongDan.Name = "SoLuongDan";
            SoLuongDan.ReadOnly = true;
            SoLuongDan.Visible = false;
            // 
            // DanhSachBia
            // 
            DanhSachBia.DataPropertyName = "DanhSachBia";
            DanhSachBia.HeaderText = "DanhSachBia";
            DanhSachBia.Name = "DanhSachBia";
            DanhSachBia.ReadOnly = true;
            DanhSachBia.Visible = false;
            // 
            // ThuTuSapXep2D
            // 
            ThuTuSapXep2D.DataPropertyName = "ThuTuSapXep2D";
            ThuTuSapXep2D.HeaderText = "ThuTuSapXep2D";
            ThuTuSapXep2D.Name = "ThuTuSapXep2D";
            ThuTuSapXep2D.ReadOnly = true;
            ThuTuSapXep2D.Visible = false;
            // 
            // ThoiGianAnHien
            // 
            ThoiGianAnHien.DataPropertyName = "ThoiGianAnHien";
            ThoiGianAnHien.HeaderText = "ThoiGianAnHien";
            ThoiGianAnHien.Name = "ThoiGianAnHien";
            ThoiGianAnHien.ReadOnly = true;
            ThoiGianAnHien.Visible = false;
            // 
            // DiemGioi
            // 
            DiemGioi.DataPropertyName = "DiemGioi";
            DiemGioi.HeaderText = "DiemGioi";
            DiemGioi.Name = "DiemGioi";
            DiemGioi.ReadOnly = true;
            DiemGioi.Visible = false;
            // 
            // DiemKha
            // 
            DiemKha.DataPropertyName = "DiemKha";
            DiemKha.HeaderText = "DiemKha";
            DiemKha.Name = "DiemKha";
            DiemKha.ReadOnly = true;
            DiemKha.Visible = false;
            // 
            // DiemDat
            // 
            DiemDat.DataPropertyName = "DiemDat";
            DiemDat.HeaderText = "DiemDat";
            DiemDat.Name = "DiemDat";
            DiemDat.ReadOnly = true;
            DiemDat.Visible = false;
            // 
            // ScoreType
            // 
            ScoreType.DataPropertyName = "ScoreType";
            ScoreType.HeaderText = "ScoreType";
            ScoreType.Name = "ScoreType";
            ScoreType.ReadOnly = true;
            ScoreType.Visible = false;
            // 
            // DisplayType
            // 
            DisplayType.DataPropertyName = "DisplayType";
            DisplayType.HeaderText = "DisplayType";
            DisplayType.Name = "DisplayType";
            DisplayType.ReadOnly = true;
            DisplayType.Visible = false;
            // 
            // BiaDKKha
            // 
            BiaDKKha.DataPropertyName = "BiaDKKha";
            BiaDKKha.HeaderText = "BiaDKKha";
            BiaDKKha.Name = "BiaDKKha";
            BiaDKKha.ReadOnly = true;
            BiaDKKha.Visible = false;
            // 
            // BiaKoTrungTruDiem
            // 
            BiaKoTrungTruDiem.DataPropertyName = "BiaKoTrungTruDiem";
            BiaKoTrungTruDiem.HeaderText = "BiaKoTrungTruDiem";
            BiaKoTrungTruDiem.Name = "BiaKoTrungTruDiem";
            BiaKoTrungTruDiem.ReadOnly = true;
            BiaKoTrungTruDiem.Visible = false;
            // 
            // BiaKoDuocBan
            // 
            BiaKoDuocBan.DataPropertyName = "BiaKoDuocBan";
            BiaKoDuocBan.HeaderText = "BiaKoDuocBan";
            BiaKoDuocBan.Name = "BiaKoDuocBan";
            BiaKoDuocBan.ReadOnly = true;
            BiaKoDuocBan.Visible = false;
            // 
            // TotalHitCheck
            // 
            TotalHitCheck.DataPropertyName = "TotalHitCheck";
            TotalHitCheck.HeaderText = "TotalHitCheck";
            TotalHitCheck.Name = "TotalHitCheck";
            TotalHitCheck.ReadOnly = true;
            TotalHitCheck.Visible = false;
            // 
            // TotalHit_Gioi
            // 
            TotalHit_Gioi.DataPropertyName = "TotalHit_Gioi";
            TotalHit_Gioi.HeaderText = "TotalHit_Gioi";
            TotalHit_Gioi.Name = "TotalHit_Gioi";
            TotalHit_Gioi.ReadOnly = true;
            TotalHit_Gioi.Visible = false;
            // 
            // TotalHit_Kha
            // 
            TotalHit_Kha.DataPropertyName = "TotalHit_Kha";
            TotalHit_Kha.HeaderText = "TotalHit_Kha";
            TotalHit_Kha.Name = "TotalHit_Kha";
            TotalHit_Kha.ReadOnly = true;
            TotalHit_Kha.Visible = false;
            // 
            // TotalHit_Dat
            // 
            TotalHit_Dat.DataPropertyName = "TotalHit_Dat";
            TotalHit_Dat.HeaderText = "TotalHit_Dat";
            TotalHit_Dat.Name = "TotalHit_Dat";
            TotalHit_Dat.ReadOnly = true;
            TotalHit_Dat.Visible = false;
            // 
            // FirstHitCheck
            // 
            FirstHitCheck.DataPropertyName = "FirstHitCheck";
            FirstHitCheck.HeaderText = "FirstHitCheck";
            FirstHitCheck.Name = "FirstHitCheck";
            FirstHitCheck.ReadOnly = true;
            FirstHitCheck.Visible = false;
            // 
            // FirstHit_Gioi
            // 
            FirstHit_Gioi.DataPropertyName = "FirstHit_Gioi";
            FirstHit_Gioi.HeaderText = "FirstHit_Gioi";
            FirstHit_Gioi.Name = "FirstHit_Gioi";
            FirstHit_Gioi.ReadOnly = true;
            FirstHit_Gioi.Visible = false;
            // 
            // FirstHit_Kha
            // 
            FirstHit_Kha.DataPropertyName = "FirstHit_Kha";
            FirstHit_Kha.HeaderText = "FirstHit_Kha";
            FirstHit_Kha.Name = "FirstHit_Kha";
            FirstHit_Kha.ReadOnly = true;
            FirstHit_Kha.Visible = false;
            // 
            // FirstHit_Dat
            // 
            FirstHit_Dat.DataPropertyName = "FirstHit_Dat";
            FirstHit_Dat.HeaderText = "FirstHit_Dat";
            FirstHit_Dat.Name = "FirstHit_Dat";
            FirstHit_Dat.ReadOnly = true;
            FirstHit_Dat.Visible = false;
            // 
            // BulletRemainsCheck
            // 
            BulletRemainsCheck.DataPropertyName = "BulletRemainsCheck";
            BulletRemainsCheck.HeaderText = "BulletRemainsCheck";
            BulletRemainsCheck.Name = "BulletRemainsCheck";
            BulletRemainsCheck.ReadOnly = true;
            BulletRemainsCheck.Visible = false;
            // 
            // BulletRemain_Gioi
            // 
            BulletRemain_Gioi.DataPropertyName = "BulletRemain_Gioi";
            BulletRemain_Gioi.HeaderText = "BulletRemain_Gioi";
            BulletRemain_Gioi.Name = "BulletRemain_Gioi";
            BulletRemain_Gioi.ReadOnly = true;
            BulletRemain_Gioi.Visible = false;
            // 
            // BulletRemain_Kha
            // 
            BulletRemain_Kha.DataPropertyName = "BulletRemain_Kha";
            BulletRemain_Kha.HeaderText = "BulletRemain_Kha";
            BulletRemain_Kha.Name = "BulletRemain_Kha";
            BulletRemain_Kha.ReadOnly = true;
            BulletRemain_Kha.Visible = false;
            // 
            // BulletRemain_Dat
            // 
            BulletRemain_Dat.DataPropertyName = "BulletRemain_Dat";
            BulletRemain_Dat.HeaderText = "BulletRemain_Dat";
            BulletRemain_Dat.Name = "BulletRemain_Dat";
            BulletRemain_Dat.ReadOnly = true;
            BulletRemain_Dat.Visible = false;
            // 
            // DrawHitPoint
            // 
            DrawHitPoint.DataPropertyName = "DrawHitPoint";
            DrawHitPoint.HeaderText = "DrawHitPoint";
            DrawHitPoint.Name = "DrawHitPoint";
            DrawHitPoint.ReadOnly = true;
            DrawHitPoint.Visible = false;
            // 
            // leftBot_gbConnect
            // 
            leftBot_gbConnect.Controls.Add(leftBot_lblConnect);
            leftBot_gbConnect.Dock = DockStyle.Fill;
            leftBot_gbConnect.Location = new Point(4, 803);
            leftBot_gbConnect.Margin = new Padding(4, 3, 4, 3);
            leftBot_gbConnect.Name = "leftBot_gbConnect";
            leftBot_gbConnect.Padding = new Padding(4, 3, 4, 3);
            leftBot_gbConnect.Size = new Size(276, 46);
            leftBot_gbConnect.TabIndex = 2;
            leftBot_gbConnect.TabStop = false;
            // 
            // leftBot_lblConnect
            // 
            leftBot_lblConnect.AutoSize = true;
            leftBot_lblConnect.Dock = DockStyle.Fill;
            leftBot_lblConnect.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftBot_lblConnect.ForeColor = Color.Red;
            leftBot_lblConnect.Location = new Point(4, 19);
            leftBot_lblConnect.Margin = new Padding(4, 0, 4, 0);
            leftBot_lblConnect.Name = "leftBot_lblConnect";
            leftBot_lblConnect.Size = new Size(87, 17);
            leftBot_lblConnect.TabIndex = 0;
            leftBot_lblConnect.Text = "Chưa kết nối";
            // 
            // leftBot_gbOtherFunctions
            // 
            leftBot_gbOtherFunctions.Controls.Add(leftBot_layoutOtherFunctions);
            leftBot_gbOtherFunctions.Dock = DockStyle.Fill;
            leftBot_gbOtherFunctions.Location = new Point(4, 515);
            leftBot_gbOtherFunctions.Margin = new Padding(4, 3, 4, 3);
            leftBot_gbOtherFunctions.Name = "leftBot_gbOtherFunctions";
            leftBot_gbOtherFunctions.Padding = new Padding(4, 3, 4, 3);
            leftBot_gbOtherFunctions.Size = new Size(276, 282);
            leftBot_gbOtherFunctions.TabIndex = 3;
            leftBot_gbOtherFunctions.TabStop = false;
            // 
            // leftBot_layoutOtherFunctions
            // 
            leftBot_layoutOtherFunctions.ColumnCount = 1;
            leftBot_layoutOtherFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftBot_layoutOtherFunctions.Controls.Add(leftbot_btngv, 0, 0);
            leftBot_layoutOtherFunctions.Controls.Add(leftBot_btnUser, 0, 1);
            leftBot_layoutOtherFunctions.Controls.Add(leftBot_btnCrewSetup, 0, 2);
            leftBot_layoutOtherFunctions.Controls.Add(leftBot_btnSearch, 0, 3);
            leftBot_layoutOtherFunctions.Dock = DockStyle.Fill;
            leftBot_layoutOtherFunctions.Location = new Point(4, 19);
            leftBot_layoutOtherFunctions.Margin = new Padding(4, 3, 4, 3);
            leftBot_layoutOtherFunctions.Name = "leftBot_layoutOtherFunctions";
            leftBot_layoutOtherFunctions.RowCount = 4;
            leftBot_layoutOtherFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            leftBot_layoutOtherFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            leftBot_layoutOtherFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            leftBot_layoutOtherFunctions.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            leftBot_layoutOtherFunctions.Size = new Size(268, 260);
            leftBot_layoutOtherFunctions.TabIndex = 0;
            // 
            // leftbot_btngv
            // 
            leftbot_btngv.Dock = DockStyle.Fill;
            leftbot_btngv.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftbot_btngv.Location = new Point(12, 12);
            leftbot_btngv.Margin = new Padding(12);
            leftbot_btngv.Name = "leftbot_btngv";
            leftbot_btngv.Size = new Size(244, 41);
            leftbot_btngv.TabIndex = 3;
            leftbot_btngv.Text = "Quản lý giáo vụ";
            leftbot_btngv.TextImageRelation = TextImageRelation.ImageBeforeText;
            leftbot_btngv.UseVisualStyleBackColor = true;
            // 
            // leftBot_btnUser
            // 
            leftBot_btnUser.Dock = DockStyle.Fill;
            leftBot_btnUser.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftBot_btnUser.Location = new Point(12, 77);
            leftBot_btnUser.Margin = new Padding(12);
            leftBot_btnUser.Name = "leftBot_btnUser";
            leftBot_btnUser.Size = new Size(244, 41);
            leftBot_btnUser.TabIndex = 0;
            leftBot_btnUser.Text = "Quản lý học viên";
            leftBot_btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            leftBot_btnUser.UseVisualStyleBackColor = true;
            // 
            // leftBot_btnCrewSetup
            // 
            leftBot_btnCrewSetup.BackgroundImageLayout = ImageLayout.None;
            leftBot_btnCrewSetup.Dock = DockStyle.Fill;
            leftBot_btnCrewSetup.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftBot_btnCrewSetup.Image = (Image)resources.GetObject("leftBot_btnCrewSetup.Image");
            leftBot_btnCrewSetup.Location = new Point(12, 142);
            leftBot_btnCrewSetup.Margin = new Padding(12);
            leftBot_btnCrewSetup.Name = "leftBot_btnCrewSetup";
            leftBot_btnCrewSetup.Size = new Size(244, 41);
            leftBot_btnCrewSetup.TabIndex = 1;
            leftBot_btnCrewSetup.Text = "Quản lý kíp bắn";
            leftBot_btnCrewSetup.TextImageRelation = TextImageRelation.ImageBeforeText;
            leftBot_btnCrewSetup.UseVisualStyleBackColor = true;
            // 
            // leftBot_btnSearch
            // 
            leftBot_btnSearch.Dock = DockStyle.Fill;
            leftBot_btnSearch.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftBot_btnSearch.Image = (Image)resources.GetObject("leftBot_btnSearch.Image");
            leftBot_btnSearch.Location = new Point(12, 207);
            leftBot_btnSearch.Margin = new Padding(12);
            leftBot_btnSearch.Name = "leftBot_btnSearch";
            leftBot_btnSearch.Size = new Size(244, 41);
            leftBot_btnSearch.TabIndex = 2;
            leftBot_btnSearch.Text = "Kết quả bắn";
            leftBot_btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            leftBot_btnSearch.UseVisualStyleBackColor = true;
            // 
            // layout_Center
            // 
            layout_Center.ColumnCount = 1;
            layout_Center.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout_Center.Controls.Add(midTop_gbHABB, 0, 0);
            layout_Center.Controls.Add(midBot_gbMainFunctions, 0, 1);
            layout_Center.Dock = DockStyle.Fill;
            layout_Center.Location = new Point(296, 3);
            layout_Center.Margin = new Padding(4, 3, 4, 3);
            layout_Center.Name = "layout_Center";
            layout_Center.RowCount = 2;
            layout_Center.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout_Center.RowStyles.Add(new RowStyle(SizeType.Absolute, 202F));
            layout_Center.Size = new Size(710, 852);
            layout_Center.TabIndex = 1;
            // 
            // midTop_gbHABB
            // 
            midTop_gbHABB.Controls.Add(midTop_picHABB);
            midTop_gbHABB.Dock = DockStyle.Fill;
            midTop_gbHABB.Location = new Point(4, 3);
            midTop_gbHABB.Margin = new Padding(4, 3, 4, 3);
            midTop_gbHABB.Name = "midTop_gbHABB";
            midTop_gbHABB.Padding = new Padding(4, 3, 4, 3);
            midTop_gbHABB.Size = new Size(702, 644);
            midTop_gbHABB.TabIndex = 0;
            midTop_gbHABB.TabStop = false;
            midTop_gbHABB.Text = "Hình ảnh bài bắn";
            // 
            // midTop_picHABB
            // 
            midTop_picHABB.Dock = DockStyle.Fill;
            midTop_picHABB.Location = new Point(4, 19);
            midTop_picHABB.Margin = new Padding(4, 3, 4, 3);
            midTop_picHABB.Name = "midTop_picHABB";
            midTop_picHABB.Size = new Size(694, 622);
            midTop_picHABB.SizeMode = PictureBoxSizeMode.Zoom;
            midTop_picHABB.TabIndex = 0;
            midTop_picHABB.TabStop = false;
            // 
            // midBot_gbMainFunctions
            // 
            midBot_gbMainFunctions.Controls.Add(layout_MidBot);
            midBot_gbMainFunctions.Dock = DockStyle.Fill;
            midBot_gbMainFunctions.Location = new Point(4, 653);
            midBot_gbMainFunctions.Margin = new Padding(4, 3, 4, 3);
            midBot_gbMainFunctions.Name = "midBot_gbMainFunctions";
            midBot_gbMainFunctions.Padding = new Padding(4, 3, 4, 3);
            midBot_gbMainFunctions.Size = new Size(702, 196);
            midBot_gbMainFunctions.TabIndex = 1;
            midBot_gbMainFunctions.TabStop = false;
            // 
            // layout_MidBot
            // 
            layout_MidBot.ColumnCount = 3;
            layout_MidBot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            layout_MidBot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout_MidBot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            layout_MidBot.Controls.Add(midBot_btnStop, 2, 0);
            layout_MidBot.Controls.Add(midBot_btnViewHABeBan, 1, 0);
            layout_MidBot.Controls.Add(midBot_btnStart, 0, 0);
            layout_MidBot.Dock = DockStyle.Fill;
            layout_MidBot.Location = new Point(4, 19);
            layout_MidBot.Margin = new Padding(4, 3, 4, 3);
            layout_MidBot.Name = "layout_MidBot";
            layout_MidBot.RowCount = 1;
            layout_MidBot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout_MidBot.Size = new Size(694, 174);
            layout_MidBot.TabIndex = 1;
            // 
            // midBot_btnStop
            // 
            midBot_btnStop.Dock = DockStyle.Fill;
            midBot_btnStop.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            midBot_btnStop.Image = (Image)resources.GetObject("midBot_btnStop.Image");
            midBot_btnStop.Location = new Point(531, 12);
            midBot_btnStop.Margin = new Padding(12);
            midBot_btnStop.Name = "midBot_btnStop";
            midBot_btnStop.Size = new Size(151, 150);
            midBot_btnStop.TabIndex = 2;
            midBot_btnStop.Text = "Kết thúc";
            midBot_btnStop.TextImageRelation = TextImageRelation.ImageBeforeText;
            midBot_btnStop.UseVisualStyleBackColor = true;
            // 
            // midBot_btnViewHABeBan
            // 
            midBot_btnViewHABeBan.Dock = DockStyle.Fill;
            midBot_btnViewHABeBan.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            midBot_btnViewHABeBan.Image = (Image)resources.GetObject("midBot_btnViewHABeBan.Image");
            midBot_btnViewHABeBan.Location = new Point(187, 46);
            midBot_btnViewHABeBan.Margin = new Padding(12, 46, 12, 46);
            midBot_btnViewHABeBan.Name = "midBot_btnViewHABeBan";
            midBot_btnViewHABeBan.Size = new Size(320, 82);
            midBot_btnViewHABeBan.TabIndex = 1;
            midBot_btnViewHABeBan.Text = "Xem hình ảnh bệ bắn";
            midBot_btnViewHABeBan.TextAlign = ContentAlignment.MiddleRight;
            midBot_btnViewHABeBan.TextImageRelation = TextImageRelation.ImageBeforeText;
            midBot_btnViewHABeBan.UseVisualStyleBackColor = true;
            // 
            // midBot_btnStart
            // 
            midBot_btnStart.Dock = DockStyle.Fill;
            midBot_btnStart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            midBot_btnStart.Image = (Image)resources.GetObject("midBot_btnStart.Image");
            midBot_btnStart.Location = new Point(12, 12);
            midBot_btnStart.Margin = new Padding(12);
            midBot_btnStart.Name = "midBot_btnStart";
            midBot_btnStart.Size = new Size(151, 150);
            midBot_btnStart.TabIndex = 0;
            midBot_btnStart.Text = "Chuẩn bị";
            midBot_btnStart.TextAlign = ContentAlignment.MiddleRight;
            midBot_btnStart.TextImageRelation = TextImageRelation.ImageBeforeText;
            midBot_btnStart.UseVisualStyleBackColor = true;
            // 
            // layoutRight
            // 
            layoutRight.ColumnCount = 1;
            layoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutRight.Controls.Add(rightTop_gbDieuKienBB, 0, 0);
            layoutRight.Controls.Add(rightBot_gbDKBBFunctions, 0, 1);
            layoutRight.Dock = DockStyle.Fill;
            layoutRight.Location = new Point(1014, 3);
            layoutRight.Margin = new Padding(4, 3, 4, 3);
            layoutRight.Name = "layoutRight";
            layoutRight.RowCount = 2;
            layoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            layoutRight.Size = new Size(415, 852);
            layoutRight.TabIndex = 2;
            // 
            // rightTop_gbDieuKienBB
            // 
            rightTop_gbDieuKienBB.Controls.Add(rightTop_layoutDieuKienBB);
            rightTop_gbDieuKienBB.Dock = DockStyle.Fill;
            rightTop_gbDieuKienBB.Location = new Point(4, 3);
            rightTop_gbDieuKienBB.Margin = new Padding(4, 3, 4, 3);
            rightTop_gbDieuKienBB.Name = "rightTop_gbDieuKienBB";
            rightTop_gbDieuKienBB.Padding = new Padding(4, 3, 4, 3);
            rightTop_gbDieuKienBB.Size = new Size(407, 754);
            rightTop_gbDieuKienBB.TabIndex = 0;
            rightTop_gbDieuKienBB.TabStop = false;
            rightTop_gbDieuKienBB.Text = "Điều kiện bài bắn";
            // 
            // rightTop_layoutDieuKienBB
            // 
            rightTop_layoutDieuKienBB.AutoScroll = true;
            rightTop_layoutDieuKienBB.Dock = DockStyle.Fill;
            rightTop_layoutDieuKienBB.FlowDirection = FlowDirection.TopDown;
            rightTop_layoutDieuKienBB.Location = new Point(4, 19);
            rightTop_layoutDieuKienBB.Margin = new Padding(4, 3, 4, 3);
            rightTop_layoutDieuKienBB.Name = "rightTop_layoutDieuKienBB";
            rightTop_layoutDieuKienBB.Size = new Size(399, 732);
            rightTop_layoutDieuKienBB.TabIndex = 0;
            // 
            // rightBot_gbDKBBFunctions
            // 
            rightBot_gbDKBBFunctions.Controls.Add(rightBot_layoutBtnsDKBB);
            rightBot_gbDKBBFunctions.Dock = DockStyle.Fill;
            rightBot_gbDKBBFunctions.Location = new Point(4, 763);
            rightBot_gbDKBBFunctions.Margin = new Padding(4, 3, 4, 3);
            rightBot_gbDKBBFunctions.Name = "rightBot_gbDKBBFunctions";
            rightBot_gbDKBBFunctions.Padding = new Padding(4, 3, 4, 3);
            rightBot_gbDKBBFunctions.Size = new Size(407, 86);
            rightBot_gbDKBBFunctions.TabIndex = 1;
            rightBot_gbDKBBFunctions.TabStop = false;
            // 
            // rightBot_layoutBtnsDKBB
            // 
            rightBot_layoutBtnsDKBB.ColumnCount = 2;
            rightBot_layoutBtnsDKBB.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            rightBot_layoutBtnsDKBB.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            rightBot_layoutBtnsDKBB.Controls.Add(rightBot_btnEditDKBB, 0, 0);
            rightBot_layoutBtnsDKBB.Controls.Add(rightBot_btnCancelDKBB, 1, 0);
            rightBot_layoutBtnsDKBB.Dock = DockStyle.Fill;
            rightBot_layoutBtnsDKBB.Location = new Point(4, 19);
            rightBot_layoutBtnsDKBB.Margin = new Padding(4, 3, 4, 3);
            rightBot_layoutBtnsDKBB.Name = "rightBot_layoutBtnsDKBB";
            rightBot_layoutBtnsDKBB.RowCount = 1;
            rightBot_layoutBtnsDKBB.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightBot_layoutBtnsDKBB.Size = new Size(399, 64);
            rightBot_layoutBtnsDKBB.TabIndex = 0;
            // 
            // rightBot_btnEditDKBB
            // 
            rightBot_btnEditDKBB.Dock = DockStyle.Fill;
            rightBot_btnEditDKBB.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rightBot_btnEditDKBB.Image = (Image)resources.GetObject("rightBot_btnEditDKBB.Image");
            rightBot_btnEditDKBB.Location = new Point(12, 0);
            rightBot_btnEditDKBB.Margin = new Padding(12, 0, 12, 12);
            rightBot_btnEditDKBB.Name = "rightBot_btnEditDKBB";
            rightBot_btnEditDKBB.Size = new Size(175, 52);
            rightBot_btnEditDKBB.TabIndex = 0;
            rightBot_btnEditDKBB.Text = "Sửa điều kiện";
            rightBot_btnEditDKBB.TextAlign = ContentAlignment.MiddleRight;
            rightBot_btnEditDKBB.TextImageRelation = TextImageRelation.ImageBeforeText;
            rightBot_btnEditDKBB.UseVisualStyleBackColor = true;
            // 
            // rightBot_btnCancelDKBB
            // 
            rightBot_btnCancelDKBB.Dock = DockStyle.Fill;
            rightBot_btnCancelDKBB.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rightBot_btnCancelDKBB.Image = (Image)resources.GetObject("rightBot_btnCancelDKBB.Image");
            rightBot_btnCancelDKBB.Location = new Point(211, 0);
            rightBot_btnCancelDKBB.Margin = new Padding(12, 0, 12, 12);
            rightBot_btnCancelDKBB.Name = "rightBot_btnCancelDKBB";
            rightBot_btnCancelDKBB.Size = new Size(176, 52);
            rightBot_btnCancelDKBB.TabIndex = 1;
            rightBot_btnCancelDKBB.Text = "Hủy";
            rightBot_btnCancelDKBB.TextAlign = ContentAlignment.MiddleRight;
            rightBot_btnCancelDKBB.TextImageRelation = TextImageRelation.ImageBeforeText;
            rightBot_btnCancelDKBB.UseVisualStyleBackColor = true;
            // 
            // VS_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 858);
            Controls.Add(layoutMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1192, 880);
            Name = "VS_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trường bắn điện tử - Trung tâm nghiên cứu ứng dụng CNC - Tecapro";
            WindowState = FormWindowState.Maximized;
            layoutMain.ResumeLayout(false);
            layoutLeft.ResumeLayout(false);
            leftTop_gbLoaiSung.ResumeLayout(false);
            leftMid_gbDSBB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)leftMid_grdDSBB).EndInit();
            leftBot_gbConnect.ResumeLayout(false);
            leftBot_gbConnect.PerformLayout();
            leftBot_gbOtherFunctions.ResumeLayout(false);
            leftBot_layoutOtherFunctions.ResumeLayout(false);
            layout_Center.ResumeLayout(false);
            midTop_gbHABB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)midTop_picHABB).EndInit();
            midBot_gbMainFunctions.ResumeLayout(false);
            layout_MidBot.ResumeLayout(false);
            layoutRight.ResumeLayout(false);
            rightTop_gbDieuKienBB.ResumeLayout(false);
            rightBot_gbDKBBFunctions.ResumeLayout(false);
            rightBot_layoutBtnsDKBB.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TableLayoutPanel layoutLeft;
        private System.Windows.Forms.GroupBox leftTop_gbLoaiSung;
        private System.Windows.Forms.ComboBox leftTop_cboLoaiSung;
        private System.Windows.Forms.GroupBox leftMid_gbDSBB;
        private System.Windows.Forms.DataGridView leftMid_grdDSBB;
        private System.Windows.Forms.TableLayoutPanel layout_Center;
        private System.Windows.Forms.GroupBox midTop_gbHABB;
        private System.Windows.Forms.PictureBox midTop_picHABB;
        private System.Windows.Forms.TableLayoutPanel layout_MidBot;
        private System.Windows.Forms.Button midBot_btnStart;
        private System.Windows.Forms.Button midBot_btnViewHABeBan;
        private System.Windows.Forms.Button midBot_btnStop;
        private System.Windows.Forms.TableLayoutPanel layoutRight;
        private System.Windows.Forms.GroupBox rightTop_gbDieuKienBB;
        private System.Windows.Forms.FlowLayoutPanel rightTop_layoutDieuKienBB;
        private System.Windows.Forms.GroupBox leftBot_gbConnect;
        private System.Windows.Forms.Label leftBot_lblConnect;
        private System.Windows.Forms.GroupBox leftBot_gbOtherFunctions;
        private System.Windows.Forms.GroupBox rightBot_gbDKBBFunctions;
        private System.Windows.Forms.GroupBox midBot_gbMainFunctions;
        private System.Windows.Forms.TableLayoutPanel rightBot_layoutBtnsDKBB;
        private System.Windows.Forms.Button rightBot_btnEditDKBB;
        private System.Windows.Forms.Button rightBot_btnCancelDKBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhSachBia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuTuSapXep2D;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianAnHien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGioi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiaDKKha;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiaKoTrungTruDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn BiaKoDuocBan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TotalHitCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHit_Gioi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHit_Kha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHit_Dat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FirstHitCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstHit_Gioi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstHit_Kha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstHit_Dat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BulletRemainsCheck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BulletRemain_Gioi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BulletRemain_Kha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BulletRemain_Dat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DrawHitPoint;
        private System.Windows.Forms.TableLayoutPanel leftBot_layoutOtherFunctions;
        private System.Windows.Forms.Button leftBot_btnUser;
        private System.Windows.Forms.Button leftBot_btnCrewSetup;
        private System.Windows.Forms.Button leftBot_btnSearch;
        private Button leftbot_btngv;
    }
}