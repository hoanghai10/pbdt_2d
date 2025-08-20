namespace PBDT_2D.Forms
{
    partial class VS_GiaoVuAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VS_GiaoVuAddEdit));
            layoutMain = new TableLayoutPanel();
            tbTen = new TextBox();
            tbNamSinh = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCancel = new Button();
            btnOK = new Button();
            cboQuanHam = new ComboBox();
            layoutMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            layoutMain.Controls.Add(tbTen, 1, 0);
            layoutMain.Controls.Add(tbNamSinh, 1, 2);
            layoutMain.Controls.Add(label1, 0, 0);
            layoutMain.Controls.Add(label2, 0, 1);
            layoutMain.Controls.Add(label3, 0, 2);
            layoutMain.Controls.Add(tableLayoutPanel1, 1, 3);
            layoutMain.Controls.Add(cboQuanHam, 1, 1);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(4, 3, 4, 3);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 4;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMain.Size = new Size(420, 210);
            layoutMain.TabIndex = 0;
            // 
            // tbTen
            // 
            tbTen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbTen.Location = new Point(88, 14);
            tbTen.Margin = new Padding(4, 3, 4, 3);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(328, 23);
            tbTen.TabIndex = 0;
            // 
            // tbNamSinh
            // 
            tbNamSinh.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbNamSinh.Location = new Point(88, 118);
            tbNamSinh.Margin = new Padding(4, 3, 4, 3);
            tbNamSinh.Name = "tbNamSinh";
            tbNamSinh.Size = new Size(328, 23);
            tbNamSinh.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(55, 18);
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
            label2.Location = new Point(17, 70);
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
            label3.Location = new Point(22, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Năm sinh";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel1.Controls.Add(btnOK, 0, 0);
            tableLayoutPanel1.Location = new Point(87, 159);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(329, 39);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(176, 6);
            btnCancel.Margin = new Padding(12, 6, 12, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 27);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Dock = DockStyle.Fill;
            btnOK.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Image = (Image)resources.GetObject("btnOK.Image");
            btnOK.Location = new Point(12, 6);
            btnOK.Margin = new Padding(12, 6, 12, 6);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(140, 27);
            btnOK.TabIndex = 1;
            btnOK.Text = "Đồng ý";
            btnOK.TextAlign = ContentAlignment.MiddleRight;
            btnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // cboQuanHam
            // 
            cboQuanHam.Anchor = AnchorStyles.Left;
            cboQuanHam.FormattingEnabled = true;
            cboQuanHam.Location = new Point(88, 66);
            cboQuanHam.Margin = new Padding(4, 3, 4, 3);
            cboQuanHam.Name = "cboQuanHam";
            cboQuanHam.Size = new Size(140, 23);
            cboQuanHam.TabIndex = 1;
            // 
            // VS_GiaoVuAddEdit
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
            MinimumSize = new Size(436, 100);
            Name = "VS_GiaoVuAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VS_UserAddEdit";
            layoutMain.ResumeLayout(false);
            layoutMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.ComboBox cboQuanHam;
        private System.Windows.Forms.TextBox tbNamSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnOK;
        private Button btnCancel;
    }
}