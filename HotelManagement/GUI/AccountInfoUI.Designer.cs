namespace HotelManagement.GUI
{
    using System;

    partial class AccountInfoUI
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
            lbUID = new Label();
            lbUserName = new Label();
            lbPassword = new Label();
            lbStatus = new Label();
            tbUID = new TextBox();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            lbUserNameError = new Label();
            lbPasswordError = new Label();
            cbStatus = new CheckBox();
            SuspendLayout();
            // 
            // lbUID
            // 
            lbUID.AutoSize = true;
            lbUID.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbUID.Location = new Point(16, 20);
            lbUID.Name = "lbUID";
            lbUID.Size = new Size(39, 21);
            lbUID.TabIndex = 0;
            lbUID.Text = "UID:";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbUserName.Location = new Point(16, 72);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(121, 21);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Tên người dùng:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbPassword.Location = new Point(16, 124);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(78, 21);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Mật khẩu:";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbStatus.Location = new Point(16, 176);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(82, 21);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "Trạng thái:";
            // 
            // tbUID
            // 
            tbUID.BackColor = Color.White;
            tbUID.BorderStyle = BorderStyle.FixedSingle;
            tbUID.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUID.Location = new Point(144, 16);
            tbUID.Name = "tbUID";
            tbUID.ReadOnly = true;
            tbUID.Size = new Size(200, 29);
            tbUID.TabIndex = 0;
            tbUID.TabStop = false;
            // 
            // tbUserName
            // 
            tbUserName.BackColor = Color.White;
            tbUserName.BorderStyle = BorderStyle.FixedSingle;
            tbUserName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUserName.Location = new Point(144, 68);
            tbUserName.Name = "tbUserName";
            tbUserName.ReadOnly = true;
            tbUserName.Size = new Size(200, 29);
            tbUserName.TabIndex = 1;
            tbUserName.TextChanged += OnUserNameChanged;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.White;
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.Location = new Point(144, 120);
            tbPassword.Name = "tbPassword";
            tbPassword.ReadOnly = true;
            tbPassword.Size = new Size(200, 29);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += OnPasswordChanged;
            // 
            // lbUserNameError
            // 
            lbUserNameError.AutoSize = true;
            lbUserNameError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbUserNameError.ForeColor = Color.Red;
            lbUserNameError.Location = new Point(144, 100);
            lbUserNameError.Name = "lbUserNameError";
            lbUserNameError.Size = new Size(174, 15);
            lbUserNameError.TabIndex = 0;
            lbUserNameError.Text = "Tên người dùng không hợp lệ!";
            // 
            // lbPasswordError
            // 
            lbPasswordError.AutoSize = true;
            lbPasswordError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbPasswordError.ForeColor = Color.Red;
            lbPasswordError.Location = new Point(144, 152);
            lbPasswordError.Name = "lbPasswordError";
            lbPasswordError.Size = new Size(139, 15);
            lbPasswordError.TabIndex = 0;
            lbPasswordError.Text = "Mật khẩu không hợp lệ!";
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbStatus.ForeColor = Color.Black;
            cbStatus.Location = new Point(144, 174);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(110, 27);
            cbStatus.TabIndex = 3;
            cbStatus.Text = "Bị vô hiệu";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // AccountInfoUI
            // 
            BackColor = Color.White;
            Controls.Add(cbStatus);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(tbUID);
            Controls.Add(lbStatus);
            Controls.Add(lbPasswordError);
            Controls.Add(lbPassword);
            Controls.Add(lbUserNameError);
            Controls.Add(lbUserName);
            Controls.Add(lbUID);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            MinimumSize = new Size(360, 240);
            Name = "AccountInfoUI";
            Size = new Size(360, 240);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUID, lbUserName, lbPassword, lbStatus;
        private TextBox tbUID, tbUserName, tbPassword;
        private Label lbUserNameError, lbPasswordError;
        private CheckBox cbStatus;
    }
}
