namespace PBDT_2D.Forms.UserControls
{
    partial class VS_DieuKienBB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tbSoDan = new TextBox();
            label5 = new Label();
            cbCountHit = new CheckBox();
            cbCountFirstHit = new CheckBox();
            cbBulletRemains = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbDiemDat = new TextBox();
            tbDiemKha = new TextBox();
            tbDiemGioi = new TextBox();
            tbCountHit_Dat = new TextBox();
            tbCountHit_Kha = new TextBox();
            tbCountHit_Gioi = new TextBox();
            tbFirstHit_Dat = new TextBox();
            tbFirstHit_Kha = new TextBox();
            tbFirstHit_Gioi = new TextBox();
            cbBulletRemain_Dat = new CheckBox();
            cbBulletRemain_Kha = new CheckBox();
            cbBulletRemain_Gioi = new CheckBox();
            cbDrawHitPoint = new CheckBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(629, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tính điểm";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbSoDan, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(cbCountHit, 0, 3);
            tableLayoutPanel1.Controls.Add(cbCountFirstHit, 0, 4);
            tableLayoutPanel1.Controls.Add(cbBulletRemains, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 4, 1);
            tableLayoutPanel1.Controls.Add(label3, 3, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(tbDiemDat, 4, 2);
            tableLayoutPanel1.Controls.Add(tbDiemKha, 3, 2);
            tableLayoutPanel1.Controls.Add(tbDiemGioi, 2, 2);
            tableLayoutPanel1.Controls.Add(tbCountHit_Dat, 4, 3);
            tableLayoutPanel1.Controls.Add(tbCountHit_Kha, 3, 3);
            tableLayoutPanel1.Controls.Add(tbCountHit_Gioi, 2, 3);
            tableLayoutPanel1.Controls.Add(tbFirstHit_Dat, 4, 4);
            tableLayoutPanel1.Controls.Add(tbFirstHit_Kha, 3, 4);
            tableLayoutPanel1.Controls.Add(tbFirstHit_Gioi, 2, 4);
            tableLayoutPanel1.Controls.Add(cbBulletRemain_Dat, 4, 5);
            tableLayoutPanel1.Controls.Add(cbBulletRemain_Kha, 3, 5);
            tableLayoutPanel1.Controls.Add(cbBulletRemain_Gioi, 2, 5);
            tableLayoutPanel1.Controls.Add(cbDrawHitPoint, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 19);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Size = new Size(621, 200);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "Số đạn";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbSoDan
            // 
            tbSoDan.Dock = DockStyle.Fill;
            tbSoDan.Location = new Point(128, 3);
            tbSoDan.Margin = new Padding(4, 3, 4, 3);
            tbSoDan.Name = "tbSoDan";
            tbSoDan.Size = new Size(116, 23);
            tbSoDan.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 2);
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(4, 66);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(240, 33);
            label5.TabIndex = 17;
            label5.Text = "Điểm / Trúng mục tiêu";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbCountHit
            // 
            cbCountHit.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cbCountHit, 2);
            cbCountHit.Dock = DockStyle.Fill;
            cbCountHit.Location = new Point(4, 102);
            cbCountHit.Margin = new Padding(4, 3, 4, 3);
            cbCountHit.Name = "cbCountHit";
            cbCountHit.Size = new Size(240, 27);
            cbCountHit.TabIndex = 8;
            cbCountHit.Text = "Tính số viên trúng mục tiêu";
            cbCountHit.UseVisualStyleBackColor = true;
            cbCountHit.CheckedChanged += cbCountHit_CheckedChanged;
            // 
            // cbCountFirstHit
            // 
            cbCountFirstHit.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cbCountFirstHit, 2);
            cbCountFirstHit.Dock = DockStyle.Fill;
            cbCountFirstHit.Location = new Point(4, 135);
            cbCountFirstHit.Margin = new Padding(4, 3, 4, 3);
            cbCountFirstHit.Name = "cbCountFirstHit";
            cbCountFirstHit.Size = new Size(240, 27);
            cbCountFirstHit.TabIndex = 12;
            cbCountFirstHit.Text = "Tính thứ tự viên trúng đầu tiên";
            cbCountFirstHit.UseVisualStyleBackColor = true;
            cbCountFirstHit.CheckedChanged += cbCountFirstHit_CheckedChanged;
            // 
            // cbBulletRemains
            // 
            cbBulletRemains.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cbBulletRemains, 2);
            cbBulletRemains.Dock = DockStyle.Fill;
            cbBulletRemains.Location = new Point(4, 168);
            cbBulletRemains.Margin = new Padding(4, 3, 4, 3);
            cbBulletRemains.Name = "cbBulletRemains";
            cbBulletRemains.Size = new Size(240, 29);
            cbBulletRemains.TabIndex = 16;
            cbBulletRemains.Text = "Còn thừa đạn";
            cbBulletRemains.UseVisualStyleBackColor = true;
            cbBulletRemains.CheckedChanged += cbBulletRemains_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(500, 33);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 33);
            label4.TabIndex = 3;
            label4.Text = "Điểm đạt";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(376, 33);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 33);
            label3.TabIndex = 2;
            label3.Text = "Điểm khá";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 33);
            label2.TabIndex = 1;
            label2.Text = "Điểm giỏi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDiemDat
            // 
            tbDiemDat.Dock = DockStyle.Fill;
            tbDiemDat.Location = new Point(500, 69);
            tbDiemDat.Margin = new Padding(4, 3, 4, 3);
            tbDiemDat.Name = "tbDiemDat";
            tbDiemDat.Size = new Size(117, 23);
            tbDiemDat.TabIndex = 6;
            // 
            // tbDiemKha
            // 
            tbDiemKha.Dock = DockStyle.Fill;
            tbDiemKha.Location = new Point(376, 69);
            tbDiemKha.Margin = new Padding(4, 3, 4, 3);
            tbDiemKha.Name = "tbDiemKha";
            tbDiemKha.Size = new Size(116, 23);
            tbDiemKha.TabIndex = 5;
            // 
            // tbDiemGioi
            // 
            tbDiemGioi.Dock = DockStyle.Fill;
            tbDiemGioi.Location = new Point(252, 69);
            tbDiemGioi.Margin = new Padding(4, 3, 4, 3);
            tbDiemGioi.Name = "tbDiemGioi";
            tbDiemGioi.Size = new Size(116, 23);
            tbDiemGioi.TabIndex = 4;
            // 
            // tbCountHit_Dat
            // 
            tbCountHit_Dat.Dock = DockStyle.Fill;
            tbCountHit_Dat.Enabled = false;
            tbCountHit_Dat.Location = new Point(500, 102);
            tbCountHit_Dat.Margin = new Padding(4, 3, 4, 3);
            tbCountHit_Dat.Name = "tbCountHit_Dat";
            tbCountHit_Dat.Size = new Size(117, 23);
            tbCountHit_Dat.TabIndex = 11;
            // 
            // tbCountHit_Kha
            // 
            tbCountHit_Kha.Dock = DockStyle.Fill;
            tbCountHit_Kha.Enabled = false;
            tbCountHit_Kha.Location = new Point(376, 102);
            tbCountHit_Kha.Margin = new Padding(4, 3, 4, 3);
            tbCountHit_Kha.Name = "tbCountHit_Kha";
            tbCountHit_Kha.Size = new Size(116, 23);
            tbCountHit_Kha.TabIndex = 10;
            // 
            // tbCountHit_Gioi
            // 
            tbCountHit_Gioi.Dock = DockStyle.Fill;
            tbCountHit_Gioi.Enabled = false;
            tbCountHit_Gioi.Location = new Point(252, 102);
            tbCountHit_Gioi.Margin = new Padding(4, 3, 4, 3);
            tbCountHit_Gioi.Name = "tbCountHit_Gioi";
            tbCountHit_Gioi.Size = new Size(116, 23);
            tbCountHit_Gioi.TabIndex = 9;
            // 
            // tbFirstHit_Dat
            // 
            tbFirstHit_Dat.Dock = DockStyle.Fill;
            tbFirstHit_Dat.Enabled = false;
            tbFirstHit_Dat.Location = new Point(500, 135);
            tbFirstHit_Dat.Margin = new Padding(4, 3, 4, 3);
            tbFirstHit_Dat.Name = "tbFirstHit_Dat";
            tbFirstHit_Dat.Size = new Size(117, 23);
            tbFirstHit_Dat.TabIndex = 15;
            // 
            // tbFirstHit_Kha
            // 
            tbFirstHit_Kha.Dock = DockStyle.Fill;
            tbFirstHit_Kha.Enabled = false;
            tbFirstHit_Kha.Location = new Point(376, 135);
            tbFirstHit_Kha.Margin = new Padding(4, 3, 4, 3);
            tbFirstHit_Kha.Name = "tbFirstHit_Kha";
            tbFirstHit_Kha.Size = new Size(116, 23);
            tbFirstHit_Kha.TabIndex = 14;
            // 
            // tbFirstHit_Gioi
            // 
            tbFirstHit_Gioi.Dock = DockStyle.Fill;
            tbFirstHit_Gioi.Enabled = false;
            tbFirstHit_Gioi.Location = new Point(252, 135);
            tbFirstHit_Gioi.Margin = new Padding(4, 3, 4, 3);
            tbFirstHit_Gioi.Name = "tbFirstHit_Gioi";
            tbFirstHit_Gioi.Size = new Size(116, 23);
            tbFirstHit_Gioi.TabIndex = 13;
            // 
            // cbBulletRemain_Dat
            // 
            cbBulletRemain_Dat.AutoSize = true;
            cbBulletRemain_Dat.Dock = DockStyle.Fill;
            cbBulletRemain_Dat.Location = new Point(500, 168);
            cbBulletRemain_Dat.Margin = new Padding(4, 3, 4, 3);
            cbBulletRemain_Dat.Name = "cbBulletRemain_Dat";
            cbBulletRemain_Dat.Size = new Size(117, 29);
            cbBulletRemain_Dat.TabIndex = 20;
            cbBulletRemain_Dat.TextAlign = ContentAlignment.MiddleCenter;
            cbBulletRemain_Dat.UseVisualStyleBackColor = true;
            // 
            // cbBulletRemain_Kha
            // 
            cbBulletRemain_Kha.AutoSize = true;
            cbBulletRemain_Kha.Dock = DockStyle.Fill;
            cbBulletRemain_Kha.Location = new Point(376, 168);
            cbBulletRemain_Kha.Margin = new Padding(4, 3, 4, 3);
            cbBulletRemain_Kha.Name = "cbBulletRemain_Kha";
            cbBulletRemain_Kha.Size = new Size(116, 29);
            cbBulletRemain_Kha.TabIndex = 19;
            cbBulletRemain_Kha.TextAlign = ContentAlignment.MiddleCenter;
            cbBulletRemain_Kha.UseVisualStyleBackColor = true;
            // 
            // cbBulletRemain_Gioi
            // 
            cbBulletRemain_Gioi.AutoSize = true;
            cbBulletRemain_Gioi.Dock = DockStyle.Fill;
            cbBulletRemain_Gioi.Location = new Point(252, 168);
            cbBulletRemain_Gioi.Margin = new Padding(4, 3, 4, 3);
            cbBulletRemain_Gioi.Name = "cbBulletRemain_Gioi";
            cbBulletRemain_Gioi.Size = new Size(116, 29);
            cbBulletRemain_Gioi.TabIndex = 18;
            cbBulletRemain_Gioi.TextAlign = ContentAlignment.MiddleCenter;
            cbBulletRemain_Gioi.UseVisualStyleBackColor = true;
            // 
            // cbDrawHitPoint
            // 
            cbDrawHitPoint.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(cbDrawHitPoint, 2);
            cbDrawHitPoint.Dock = DockStyle.Fill;
            cbDrawHitPoint.Location = new Point(376, 3);
            cbDrawHitPoint.Margin = new Padding(4, 3, 4, 3);
            cbDrawHitPoint.Name = "cbDrawHitPoint";
            cbDrawHitPoint.Size = new Size(241, 27);
            cbDrawHitPoint.TabIndex = 21;
            cbDrawHitPoint.Text = "Vẽ điểm chạm";
            cbDrawHitPoint.UseVisualStyleBackColor = true;
            // 
            // VS_DieuKienBB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VS_DieuKienBB";
            Size = new Size(629, 222);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDiemGioi;
        private System.Windows.Forms.TextBox tbDiemKha;
        private System.Windows.Forms.TextBox tbDiemDat;
        private System.Windows.Forms.TextBox tbSoDan;
        private System.Windows.Forms.CheckBox cbCountHit;
        private System.Windows.Forms.TextBox tbCountHit_Gioi;
        private System.Windows.Forms.TextBox tbCountHit_Kha;
        private System.Windows.Forms.TextBox tbCountHit_Dat;
        private System.Windows.Forms.CheckBox cbCountFirstHit;
        private System.Windows.Forms.TextBox tbFirstHit_Gioi;
        private System.Windows.Forms.TextBox tbFirstHit_Kha;
        private System.Windows.Forms.TextBox tbFirstHit_Dat;
        private System.Windows.Forms.CheckBox cbBulletRemains;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbBulletRemain_Gioi;
        private System.Windows.Forms.CheckBox cbBulletRemain_Kha;
        private System.Windows.Forms.CheckBox cbBulletRemain_Dat;
        private System.Windows.Forms.CheckBox cbDrawHitPoint;
    }
}
