namespace HotelManagement.GUI
{
    partial class CustomerInfoUI
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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnReset = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCCCD = new TextBox();
            txtFullname = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label10 = new Label();
            cbxGender = new ComboBox();
            dateTimeBirthday = new DateTimePicker();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 72);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(701, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 24);
            label1.Name = "label1";
            label1.Size = new Size(217, 24);
            label1.TabIndex = 0;
            label1.Text = "Thông tin khách hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 643);
            panel3.Name = "panel3";
            panel3.Size = new Size(701, 51);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnReset, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(701, 51);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = SystemColors.HotTrack;
            btnReset.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(446, 8);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(159, 34);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(95, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu thông tin";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Margin = new Padding(20, 0, 20, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 571);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(txtAddress, 0, 13);
            tableLayoutPanel3.Controls.Add(txtPhone, 0, 9);
            tableLayoutPanel3.Controls.Add(label9, 0, 10);
            tableLayoutPanel3.Controls.Add(label7, 0, 8);
            tableLayoutPanel3.Controls.Add(label6, 0, 6);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(txtCCCD, 0, 7);
            tableLayoutPanel3.Controls.Add(txtFullname, 0, 3);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(txtId, 0, 1);
            tableLayoutPanel3.Controls.Add(label10, 0, 12);
            tableLayoutPanel3.Controls.Add(cbxGender, 0, 5);
            tableLayoutPanel3.Controls.Add(dateTimeBirthday, 0, 11);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 14;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(701, 571);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(15, 520);
            txtAddress.Margin = new Padding(15, 0, 15, 0);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(671, 27);
            txtAddress.TabIndex = 44;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(15, 360);
            txtPhone.Margin = new Padding(15, 0, 15, 0);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(671, 27);
            txtPhone.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Bottom;
            label9.Location = new Point(15, 420);
            label9.Margin = new Padding(15, 0, 0, 0);
            label9.Name = "label9";
            label9.Size = new Size(686, 20);
            label9.TabIndex = 28;
            label9.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Location = new Point(15, 340);
            label7.Margin = new Padding(15, 0, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(686, 20);
            label7.TabIndex = 26;
            label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Location = new Point(15, 260);
            label6.Margin = new Padding(15, 0, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(686, 20);
            label6.TabIndex = 25;
            label6.Text = "CCCD/CMND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(15, 180);
            label5.Margin = new Padding(15, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(686, 20);
            label5.TabIndex = 24;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(15, 100);
            label4.Margin = new Padding(15, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(686, 20);
            label4.TabIndex = 23;
            label4.Text = "Tên khách hàng";
            // 
            // txtCCCD
            // 
            txtCCCD.Dock = DockStyle.Fill;
            txtCCCD.Location = new Point(15, 280);
            txtCCCD.Margin = new Padding(15, 0, 15, 0);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(671, 27);
            txtCCCD.TabIndex = 22;
            // 
            // txtFullname
            // 
            txtFullname.Dock = DockStyle.Fill;
            txtFullname.Location = new Point(15, 120);
            txtFullname.Margin = new Padding(15, 0, 15, 0);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(671, 27);
            txtFullname.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(15, 20);
            label2.Margin = new Padding(15, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(686, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã khách hàng";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(15, 40);
            txtId.Margin = new Padding(15, 0, 15, 0);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(671, 27);
            txtId.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Bottom;
            label10.Location = new Point(20, 500);
            label10.Margin = new Padding(20, 0, 20, 0);
            label10.Name = "label10";
            label10.Size = new Size(661, 20);
            label10.TabIndex = 35;
            label10.Text = "Địa chỉ";
            // 
            // cbxGender
            // 
            cbxGender.Dock = DockStyle.Fill;
            cbxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(15, 200);
            cbxGender.Margin = new Padding(15, 0, 15, 0);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(671, 28);
            cbxGender.TabIndex = 45;
            // 
            // dateTimeBirthday
            // 
            dateTimeBirthday.CustomFormat = "dd/MM/yyyy";
            dateTimeBirthday.Dock = DockStyle.Fill;
            dateTimeBirthday.Format = DateTimePickerFormat.Custom;
            dateTimeBirthday.Location = new Point(15, 440);
            dateTimeBirthday.Margin = new Padding(15, 0, 15, 0);
            dateTimeBirthday.Name = "dateTimeBirthday";
            dateTimeBirthday.Size = new Size(671, 27);
            dateTimeBirthday.TabIndex = 46;
            // 
            // CustomerInfoUI
            // 
            ClientSize = new Size(701, 694);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerInfoUI";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private TextBox txtId;
        private TextBox txtPhone;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtCCCD;
        private TextBox txtFullname;
        private Label label10;
        private TextBox txtAddress;
        private Button btnReset;
        private Panel panel3;
        private ComboBox cbxGender;
        private DateTimePicker dateTimeBirthday;
    }
}