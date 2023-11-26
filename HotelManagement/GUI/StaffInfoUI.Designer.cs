namespace HotelManagement.GUI
{
    partial class StaffInfoUI
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
            lbFullName = new Label();
            lbGender = new Label();
            lbBirthday = new Label();
            tbID = new TextBox();
            tbFullName = new TextBox();
            lbFullNameError = new Label();
            lbAddress = new Label();
            lbCitizenId = new Label();
            lbCitizenIdError = new Label();
            lbPhone = new Label();
            lbPhoneError = new Label();
            lbRole = new Label();
            tbAddress = new TextBox();
            tbCitizenId = new TextBox();
            tbPhone = new TextBox();
            lbSalary = new Label();
            lbAccount = new Label();
            lbGroup = new Label();
            lbStatus = new Label();
            tbSalary = new TextBox();
            cbStatus = new CheckBox();
            dpBirthday = new DateTimePicker();
            cbGender = new ComboBox();
            cbRole = new ComboBox();
            cbAccount = new ComboBox();
            cbGroup = new ComboBox();
            lbAddressError = new Label();
            lbSalaryError = new Label();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbID.Location = new Point(16, 20);
            lbID.Name = "lbID";
            lbID.Size = new Size(28, 21);
            lbID.TabIndex = 0;
            lbID.Text = "ID:";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbFullName.Location = new Point(16, 72);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(108, 21);
            lbFullName.TabIndex = 0;
            lbFullName.Text = "Tên nhân viên:";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbGender.Location = new Point(16, 124);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(73, 21);
            lbGender.TabIndex = 0;
            lbGender.Text = "Giới tính:";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbBirthday.Location = new Point(16, 176);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(83, 21);
            lbBirthday.TabIndex = 0;
            lbBirthday.Text = "Ngày sinh:";
            // 
            // tbID
            // 
            tbID.BackColor = Color.White;
            tbID.BorderStyle = BorderStyle.FixedSingle;
            tbID.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbID.Location = new Point(144, 16);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(200, 29);
            tbID.TabIndex = 0;
            tbID.TabStop = false;
            // 
            // tbFullName
            // 
            tbFullName.BackColor = Color.White;
            tbFullName.BorderStyle = BorderStyle.FixedSingle;
            tbFullName.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbFullName.Location = new Point(144, 68);
            tbFullName.Name = "tbFullName";
            tbFullName.ReadOnly = true;
            tbFullName.Size = new Size(200, 29);
            tbFullName.TabIndex = 1;
            tbFullName.TextChanged += OnFullNameChanged;
            // 
            // lbFullNameError
            // 
            lbFullNameError.AutoSize = true;
            lbFullNameError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbFullNameError.ForeColor = Color.Red;
            lbFullNameError.Location = new Point(144, 100);
            lbFullNameError.Name = "lbFullNameError";
            lbFullNameError.Size = new Size(164, 15);
            lbFullNameError.TabIndex = 0;
            lbFullNameError.Text = "Tên nhân viên không hợp lệ!";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbAddress.Location = new Point(16, 228);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(60, 21);
            lbAddress.TabIndex = 0;
            lbAddress.Text = "Địa chỉ:";
            // 
            // lbCitizenId
            // 
            lbCitizenId.AutoSize = true;
            lbCitizenId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbCitizenId.Location = new Point(16, 280);
            lbCitizenId.Name = "lbCitizenId";
            lbCitizenId.Size = new Size(107, 21);
            lbCitizenId.TabIndex = 0;
            lbCitizenId.Text = "CCCD/CMND:";
            // 
            // lbCitizenIdError
            // 
            lbCitizenIdError.AutoSize = true;
            lbCitizenIdError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbCitizenIdError.ForeColor = Color.Red;
            lbCitizenIdError.Location = new Point(144, 308);
            lbCitizenIdError.Name = "lbCitizenIdError";
            lbCitizenIdError.Size = new Size(158, 15);
            lbCitizenIdError.TabIndex = 0;
            lbCitizenIdError.Text = "CCCD/CMND không hợp lệ!";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbPhone.Location = new Point(16, 332);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(104, 21);
            lbPhone.TabIndex = 0;
            lbPhone.Text = "Số điện thoại:";
            // 
            // lbPhoneError
            // 
            lbPhoneError.AutoSize = true;
            lbPhoneError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbPhoneError.ForeColor = Color.Red;
            lbPhoneError.Location = new Point(144, 360);
            lbPhoneError.Name = "lbPhoneError";
            lbPhoneError.Size = new Size(160, 15);
            lbPhoneError.TabIndex = 0;
            lbPhoneError.Text = "Số điện thoại không hợp lệ!";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbRole.Location = new Point(16, 384);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(69, 21);
            lbRole.TabIndex = 0;
            lbRole.Text = "Chức vụ:";
            // 
            // tbAddress
            // 
            tbAddress.BackColor = Color.White;
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbAddress.Location = new Point(144, 224);
            tbAddress.Name = "tbAddress";
            tbAddress.ReadOnly = true;
            tbAddress.Size = new Size(200, 29);
            tbAddress.TabIndex = 4;
            tbAddress.TabStop = false;
            tbAddress.TextChanged += OnAddressChanged;
            // 
            // tbCitizenId
            // 
            tbCitizenId.BackColor = Color.White;
            tbCitizenId.BorderStyle = BorderStyle.FixedSingle;
            tbCitizenId.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCitizenId.Location = new Point(144, 276);
            tbCitizenId.Name = "tbCitizenId";
            tbCitizenId.ReadOnly = true;
            tbCitizenId.Size = new Size(200, 29);
            tbCitizenId.TabIndex = 5;
            tbCitizenId.TextChanged += OnCitizenIdChanged;
            // 
            // tbPhone
            // 
            tbPhone.BackColor = Color.White;
            tbPhone.BorderStyle = BorderStyle.FixedSingle;
            tbPhone.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPhone.Location = new Point(144, 328);
            tbPhone.Name = "tbPhone";
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(200, 29);
            tbPhone.TabIndex = 6;
            tbPhone.TextChanged += OnPhoneNumberChanged;
            // 
            // lbSalary
            // 
            lbSalary.AutoSize = true;
            lbSalary.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbSalary.Location = new Point(16, 436);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(58, 21);
            lbSalary.TabIndex = 0;
            lbSalary.Text = "Lương:";
            // 
            // lbAccount
            // 
            lbAccount.AutoSize = true;
            lbAccount.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbAccount.Location = new Point(16, 488);
            lbAccount.Name = "lbAccount";
            lbAccount.Size = new Size(78, 21);
            lbAccount.TabIndex = 0;
            lbAccount.Text = "Tài khoản:";
            // 
            // lbGroup
            // 
            lbGroup.AutoSize = true;
            lbGroup.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbGroup.Location = new Point(16, 540);
            lbGroup.Name = "lbGroup";
            lbGroup.Size = new Size(104, 21);
            lbGroup.TabIndex = 0;
            lbGroup.Text = "Nhóm quyền:";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbStatus.Location = new Point(16, 592);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(82, 21);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "Trạng thái:";
            // 
            // tbSalary
            // 
            tbSalary.BackColor = Color.White;
            tbSalary.BorderStyle = BorderStyle.FixedSingle;
            tbSalary.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSalary.Location = new Point(144, 432);
            tbSalary.Name = "tbSalary";
            tbSalary.ReadOnly = true;
            tbSalary.Size = new Size(200, 29);
            tbSalary.TabIndex = 8;
            tbSalary.TabStop = false;
            tbSalary.TextChanged += OnSalaryChanged;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbStatus.ForeColor = Color.Black;
            cbStatus.Location = new Point(144, 589);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(127, 27);
            cbStatus.TabIndex = 11;
            cbStatus.Text = "Đã nghỉ việc";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // dpBirthday
            // 
            dpBirthday.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dpBirthday.Format = DateTimePickerFormat.Short;
            dpBirthday.Location = new Point(144, 172);
            dpBirthday.Name = "dpBirthday";
            dpBirthday.Size = new Size(200, 29);
            dpBirthday.TabIndex = 3;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(144, 120);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(200, 29);
            cbGender.TabIndex = 2;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(144, 380);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(200, 29);
            cbRole.TabIndex = 7;
            // 
            // cbAccount
            // 
            cbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAccount.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbAccount.FormattingEnabled = true;
            cbAccount.Location = new Point(144, 484);
            cbAccount.Name = "cbAccount";
            cbAccount.Size = new Size(200, 29);
            cbAccount.TabIndex = 9;
            cbAccount.SelectedIndexChanged += OnPermissionsInfoChanged;
            // 
            // cbGroup
            // 
            cbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroup.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbGroup.FormattingEnabled = true;
            cbGroup.Location = new Point(144, 536);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(200, 29);
            cbGroup.TabIndex = 10;
            cbGroup.SelectedIndexChanged += OnPermissionsInfoChanged;
            // 
            // lbAddressError
            // 
            lbAddressError.AutoSize = true;
            lbAddressError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbAddressError.ForeColor = Color.Red;
            lbAddressError.Location = new Point(144, 256);
            lbAddressError.Name = "lbAddressError";
            lbAddressError.Size = new Size(124, 15);
            lbAddressError.TabIndex = 0;
            lbAddressError.Text = "Địa chỉ không hợp lệ!";
            // 
            // lbSalaryError
            // 
            lbSalaryError.AutoSize = true;
            lbSalaryError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbSalaryError.ForeColor = Color.Red;
            lbSalaryError.Location = new Point(144, 464);
            lbSalaryError.Name = "lbSalaryError";
            lbSalaryError.Size = new Size(123, 15);
            lbSalaryError.TabIndex = 0;
            lbSalaryError.Text = "Lương không hợp lệ!";
            // 
            // StaffInfoUI
            // 
            BackColor = Color.White;
            Controls.Add(cbGroup);
            Controls.Add(cbAccount);
            Controls.Add(cbRole);
            Controls.Add(cbGender);
            Controls.Add(dpBirthday);
            Controls.Add(cbStatus);
            Controls.Add(tbPhone);
            Controls.Add(tbCitizenId);
            Controls.Add(tbFullName);
            Controls.Add(tbSalary);
            Controls.Add(tbAddress);
            Controls.Add(tbID);
            Controls.Add(lbStatus);
            Controls.Add(lbRole);
            Controls.Add(lbSalaryError);
            Controls.Add(lbPhoneError);
            Controls.Add(lbGroup);
            Controls.Add(lbBirthday);
            Controls.Add(lbPhone);
            Controls.Add(lbAddressError);
            Controls.Add(lbCitizenIdError);
            Controls.Add(lbAccount);
            Controls.Add(lbGender);
            Controls.Add(lbCitizenId);
            Controls.Add(lbSalary);
            Controls.Add(lbFullNameError);
            Controls.Add(lbAddress);
            Controls.Add(lbFullName);
            Controls.Add(lbID);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            MinimumSize = new Size(360, 660);
            Name = "StaffInfoUI";
            Size = new Size(360, 660);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID, lbFullName, lbGender, lbBirthday, lbAccount, lbGroup;
        private TextBox tbID;
        private TextBox tbFullName;
        private Label lbFullNameError;
        private CheckBox cbStatus;
        private Label lbAddress;
        private Label lbCitizenId;
        private Label lbCitizenIdError;
        private Label lbPhone;
        private Label lbPhoneError;
        private Label lbRole;
        private TextBox tbAddress;
        private TextBox tbCitizenId;
        private TextBox tbPhone;
        private Label lbSalary;
        private Label lbStatus;
        private TextBox tbSalary;
        private DateTimePicker dpBirthday;
        private ComboBox cbGender;
        private ComboBox cbRole;
        private ComboBox cbAccount;
        private ComboBox cbGroup;
        private Label lbAddressError;
        private Label lbSalaryError;
    }
}
