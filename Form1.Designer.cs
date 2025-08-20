namespace PBDT_2D
{
    partial class VS_MainManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHuanLuyen = new RJButton();
            btnUser = new RJButton();
            SuspendLayout();
            // 
            // btnHuanLuyen
            // 
            btnHuanLuyen.BackColor = Color.PaleVioletRed;
            btnHuanLuyen.BackgroundColor = Color.PaleVioletRed;
            btnHuanLuyen.BorderColor = Color.PaleVioletRed;
            btnHuanLuyen.BorderRadius = 16;
            btnHuanLuyen.BorderSize = 0;
            btnHuanLuyen.FlatAppearance.BorderSize = 0;
            btnHuanLuyen.FlatStyle = FlatStyle.Flat;
            btnHuanLuyen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuanLuyen.ForeColor = Color.White;
            btnHuanLuyen.Location = new Point(98, 93);
            btnHuanLuyen.Name = "btnHuanLuyen";
            btnHuanLuyen.Size = new Size(150, 40);
            btnHuanLuyen.TabIndex = 2;
            btnHuanLuyen.Text = "Huấn luyện";
            btnHuanLuyen.TextColor = Color.White;
            btnHuanLuyen.UseVisualStyleBackColor = false;
            btnHuanLuyen.Click += btnHuanLuyen_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.PaleVioletRed;
            btnUser.BackgroundColor = Color.PaleVioletRed;
            btnUser.BorderColor = Color.PaleVioletRed;
            btnUser.BorderRadius = 16;
            btnUser.BorderSize = 0;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(289, 93);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(150, 40);
            btnUser.TabIndex = 3;
            btnUser.Text = "Người dùng";
            btnUser.TextColor = Color.White;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // VS_MainManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 304);
            Controls.Add(btnUser);
            Controls.Add(btnHuanLuyen);
            Name = "VS_MainManager";
            Text = "Chức năng ";
            ResumeLayout(false);
        }

        #endregion
        private RJButton btnHuanLuyen;
        private RJButton btnUser;
    }
}
