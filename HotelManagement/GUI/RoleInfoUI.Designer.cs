namespace HotelManagement.GUI
{
    partial class RoleInfoUI
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
            lbID = new Label();
            lbName = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
            lbNameError = new Label();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(16, 20);
            lbID.Name = "lbID";
            lbID.Size = new Size(28, 21);
            lbID.TabIndex = 0;
            lbID.Text = "ID:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(16, 72);
            lbName.Name = "lbName";
            lbName.Size = new Size(128, 21);
            lbName.TabIndex = 0;
            lbName.Text = "Tên chức vụ:";
            // 
            // tbID
            // 
            tbID.BackColor = Color.White;
            tbID.BorderStyle = BorderStyle.FixedSingle;
            tbID.Location = new Point(144, 16);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(200, 29);
            tbID.TabIndex = 0;
            tbID.TabStop = false;
            // 
            // tbName
            // 
            tbName.BackColor = Color.White;
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Location = new Point(144, 68);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(200, 29);
            tbName.TabIndex = 1;
            tbName.TextChanged += OnNameChanged;
            // 
            // lbNameError
            // 
            lbNameError.AutoSize = true;
            lbNameError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbNameError.ForeColor = Color.Red;
            lbNameError.Location = new Point(144, 100);
            lbNameError.Name = "lbNameError";
            lbNameError.Size = new Size(179, 15);
            lbNameError.TabIndex = 0;
            lbNameError.Text = "Tên chức vụ không hợp lệ!";
            // 
            // PermissonGroupInfoUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tbName);
            Controls.Add(tbID);
            Controls.Add(lbNameError);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ForeColor = Color.Black;
            MinimumSize = new Size(360, 136);
            Name = "PermissonGroupInfoUI";
            Size = new Size(360, 136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID, lbName;
        private TextBox tbID, tbName;
        private Label lbNameError;
    }
}
