namespace TBA2D.Forms.UserControls
{
    partial class VS_DieuKienBia
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
            this.gbBia = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.gbBia.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBia
            // 
            this.gbBia.Controls.Add(this.flowLayoutPanel1);
            this.gbBia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBia.Location = new System.Drawing.Point(0, 0);
            this.gbBia.Name = "gbBia";
            this.gbBia.Size = new System.Drawing.Size(285, 46);
            this.gbBia.TabIndex = 5;
            this.gbBia.TabStop = false;
            this.gbBia.Text = "Bia";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tbHien);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.tbAn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mốc hiện";
            // 
            // tbHien
            // 
            this.tbHien.Location = new System.Drawing.Point(60, 3);
            this.tbHien.Name = "tbHien";
            this.tbHien.Size = new System.Drawing.Size(80, 20);
            this.tbHien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mốc ẩn";
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(195, 3);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(80, 20);
            this.tbAn.TabIndex = 3;
            // 
            // VS_DieuKienBia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBia);
            this.Name = "VS_DieuKienBia";
            this.Size = new System.Drawing.Size(285, 46);
            this.gbBia.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAn;
    }
}
