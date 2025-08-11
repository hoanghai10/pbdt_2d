namespace TBDT_2D.Forms
{
    partial class VS_UserAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VS_UserAddEdit));
            layoutMain = new TableLayoutPanel();
            tbTen = new TextBox();
            cboQuanHam = new ComboBox();
            tbChucVu = new TextBox();
            tbDonVi = new TextBox();
            tbGhiChu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            layoutButtons = new TableLayoutPanel();
            btnOK = new Button();
            btnCancel = new Button();
            layoutMain.SuspendLayout();
            layoutButtons.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            layoutMain.Controls.Add(tbTen, 1, 0);
            layoutMain.Controls.Add(cboQuanHam, 1, 1);
            layoutMain.Controls.Add(tbChucVu, 1, 2);
            layoutMain.Controls.Add(tbDonVi, 1, 3);
            layoutMain.Controls.Add(tbGhiChu, 1, 4);
            layoutMain.Controls.Add(label1, 0, 0);
            layoutMain.Controls.Add(label2, 0, 1);
            layoutMain.Controls.Add(label3, 0, 2);
            layoutMain.Controls.Add(label4, 0, 3);
            layoutMain.Controls.Add(label5, 0, 4);
            layoutMain.Controls.Add(layoutButtons, 1, 5);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(4, 3, 4, 3);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 6;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMain.Size = new Size(420, 210);
            layoutMain.TabIndex = 0;
            // 
            // tbTen
            // 
            tbTen.Dock = DockStyle.Fill;
            tbTen.Location = new Point(88, 3);
            tbTen.Margin = new Padding(4, 3, 4, 3);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(328, 23);
            tbTen.TabIndex = 0;
            // 
            // cboQuanHam
            // 
            cboQuanHam.Anchor = AnchorStyles.Left;
            cboQuanHam.FormattingEnabled = true;
            cboQuanHam.Location = new Point(88, 35);
            cboQuanHam.Margin = new Padding(4, 3, 4, 3);
            cboQuanHam.Name = "cboQuanHam";
            cboQuanHam.Size = new Size(140, 23);
            cboQuanHam.TabIndex = 1;
            // 
            // tbChucVu
            // 
            tbChucVu.Dock = DockStyle.Fill;
            tbChucVu.Location = new Point(88, 65);
            tbChucVu.Margin = new Padding(4, 3, 4, 3);
            tbChucVu.Name = "tbChucVu";
            tbChucVu.Size = new Size(328, 23);
            tbChucVu.TabIndex = 2;
            // 
            // tbDonVi
            // 
            tbDonVi.Dock = DockStyle.Fill;
            tbDonVi.Location = new Point(88, 96);
            tbDonVi.Margin = new Padding(4, 3, 4, 3);
            tbDonVi.Name = "tbDonVi";
            tbDonVi.Size = new Size(328, 23);
            tbDonVi.TabIndex = 3;
            // 
            // tbGhiChu
            // 
            tbGhiChu.Dock = DockStyle.Fill;
            tbGhiChu.Location = new Point(88, 127);
            tbGhiChu.Margin = new Padding(4, 3, 4, 3);
            tbGhiChu.Name = "tbGhiChu";
            tbGhiChu.Size = new Size(328, 23);
            tbGhiChu.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(55, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 5;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(17, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Quân hàm";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(29, 70);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Chức vụ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(39, 101);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Đơn vị";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(32, 132);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "Ghi chú";
            // 
            // layoutButtons
            // 
            layoutButtons.ColumnCount = 2;
            layoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutButtons.Controls.Add(btnOK, 0, 0);
            layoutButtons.Controls.Add(btnCancel, 1, 0);
            layoutButtons.Dock = DockStyle.Fill;
            layoutButtons.Location = new Point(88, 158);
            layoutButtons.Margin = new Padding(4, 3, 4, 3);
            layoutButtons.Name = "layoutButtons";
            layoutButtons.RowCount = 1;
            layoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutButtons.Size = new Size(328, 49);
            layoutButtons.TabIndex = 10;
            // 
            // btnOK
            // 
            btnOK.Dock = DockStyle.Fill;
            btnOK.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Image = (Image)resources.GetObject("btnOK.Image");
            btnOK.Location = new Point(12, 6);
            btnOK.Margin = new Padding(12, 6, 12, 6);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(140, 37);
            btnOK.TabIndex = 0;
            btnOK.Text = "Đồng ý";
            btnOK.TextAlign = ContentAlignment.MiddleRight;
            btnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(176, 6);
            btnCancel.Margin = new Padding(12, 6, 12, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 37);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Hủy";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // VS_UserAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 210);
            Controls.Add(layoutMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(931, 249);
            MinimizeBox = false;
            MinimumSize = new Size(436, 249);
            Name = "VS_UserAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VS_UserAddEdit";
            layoutMain.ResumeLayout(false);
            layoutMain.PerformLayout();
            layoutButtons.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.ComboBox cboQuanHam;
        private System.Windows.Forms.TextBox tbChucVu;
        private System.Windows.Forms.TextBox tbDonVi;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel layoutButtons;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}