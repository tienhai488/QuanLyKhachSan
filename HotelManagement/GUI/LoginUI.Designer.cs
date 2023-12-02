namespace HotelManagement
{
    using MaterialSkin.Controls;

    partial class LoginUI
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
            Label txtTitle;
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            txtUserNameLabel = new Label();
            pnLogin = new Panel();
            txtLoginFailed = new Label();
            txtPasswordError = new Label();
            txtUserNameError = new Label();
            btnLogin = new Button();
            txtPasswordLabel = new Label();
            txtTitle = new Label();
            pnLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 29F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtTitle.Location = new Point(96, 28);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(167, 40);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Đăng nhập";
            txtTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.BorderStyle = BorderStyle.FixedSingle;
            tbUserName.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUserName.Location = new Point(40, 140);
            tbUserName.Margin = new Padding(0);
            tbUserName.Name = "tbUserName";
            tbUserName.ShortcutsEnabled = false;
            tbUserName.Size = new Size(280, 35);
            tbUserName.TabIndex = 3;
            tbUserName.TextChanged += OnUserNameChanged;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.Location = new Point(40, 220);
            tbPassword.Margin = new Padding(0);
            tbPassword.Name = "tbPassword";
            tbPassword.ShortcutsEnabled = false;
            tbPassword.Size = new Size(280, 35);
            tbPassword.TabIndex = 4;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += OnPasswordChanged;
            // 
            // txtUserNameLabel
            // 
            txtUserNameLabel.AutoSize = true;
            txtUserNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUserNameLabel.Location = new Point(48, 124);
            txtUserNameLabel.Name = "txtUserNameLabel";
            txtUserNameLabel.Size = new Size(111, 21);
            txtUserNameLabel.TabIndex = 5;
            txtUserNameLabel.Text = "Tên đăng nhập";
            // 
            // pnLogin
            // 
            pnLogin.BackColor = SystemColors.Window;
            pnLogin.Controls.Add(txtLoginFailed);
            pnLogin.Controls.Add(txtPasswordError);
            pnLogin.Controls.Add(txtUserNameError);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(txtPasswordLabel);
            pnLogin.Controls.Add(txtUserNameLabel);
            pnLogin.Controls.Add(txtTitle);
            pnLogin.Controls.Add(tbPassword);
            pnLogin.Controls.Add(tbUserName);
            pnLogin.Location = new Point(12, 12);
            pnLogin.Margin = new Padding(0);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(360, 360);
            pnLogin.TabIndex = 6;
            // 
            // txtLoginFailed
            // 
            txtLoginFailed.AutoSize = true;
            txtLoginFailed.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtLoginFailed.ForeColor = Color.Red;
            txtLoginFailed.Location = new Point(61, 88);
            txtLoginFailed.Name = "txtLoginFailed";
            txtLoginFailed.Size = new Size(246, 15);
            txtLoginFailed.TabIndex = 10;
            txtLoginFailed.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            // 
            // txtPasswordError
            // 
            txtPasswordError.AutoSize = true;
            txtPasswordError.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtPasswordError.ForeColor = Color.Red;
            txtPasswordError.Location = new Point(48, 255);
            txtPasswordError.Name = "txtPasswordError";
            txtPasswordError.Size = new Size(139, 15);
            txtPasswordError.TabIndex = 9;
            txtPasswordError.Text = "Mật khẩu không hợp lệ!";
            // 
            // txtUserNameError
            // 
            txtUserNameError.AutoSize = true;
            txtUserNameError.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtUserNameError.ForeColor = Color.Red;
            txtUserNameError.Location = new Point(48, 175);
            txtUserNameError.Name = "txtUserNameError";
            txtUserNameError.Size = new Size(168, 15);
            txtUserNameError.TabIndex = 8;
            txtUserNameError.Text = "Tên đăng nhập không hợp lệ!";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLight;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(120, 296);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 36);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += OnSignIn;
            // 
            // txtPasswordLabel
            // 
            txtPasswordLabel.AutoSize = true;
            txtPasswordLabel.BackColor = Color.Transparent;
            txtPasswordLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPasswordLabel.Location = new Point(48, 204);
            txtPasswordLabel.Name = "txtPasswordLabel";
            txtPasswordLabel.Size = new Size(75, 21);
            txtPasswordLabel.TabIndex = 6;
            txtPasswordLabel.Text = "Mật khẩu";
            // 
            // LoginUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(366, 337);
            Controls.Add(pnLogin);
            Margin = new Padding(0);
            MinimumSize = new Size(384, 384);
            Name = "LoginUI";
            StartPosition = FormStartPosition.CenterScreen;
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLogin;
        private Label txtTitle;
        private Label txtLoginFailed;
        private Label txtUserNameLabel;
        private TextBox tbUserName;
        private Label txtUserNameError;
        private Label txtPasswordLabel;
        private TextBox tbPassword;
        private Label txtPasswordError;
        private Button btnLogin;
    }
}