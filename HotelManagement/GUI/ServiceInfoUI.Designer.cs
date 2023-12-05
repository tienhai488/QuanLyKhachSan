namespace HotelManagement.GUI
{
    partial class ServiceInfoUI
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnReset = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtUnit = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtUnitPrice = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            cbxServiceType = new ComboBox();
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
            panel1.Size = new Size(459, 72);
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
            tableLayoutPanel2.Size = new Size(459, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 26);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 0;
            label1.Text = "Thông tin dịch vụ";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 477);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 51);
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
            tableLayoutPanel1.Size = new Size(459, 51);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = SystemColors.HotTrack;
            btnReset.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(264, 8);
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
            btnSave.Location = new Point(35, 8);
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
            panel2.Size = new Size(459, 405);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(txtUnit, 0, 9);
            tableLayoutPanel3.Controls.Add(label7, 0, 8);
            tableLayoutPanel3.Controls.Add(label6, 0, 6);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(txtUnitPrice, 0, 7);
            tableLayoutPanel3.Controls.Add(txtName, 0, 3);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(txtId, 0, 1);
            tableLayoutPanel3.Controls.Add(cbxServiceType, 0, 5);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 10;
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
            tableLayoutPanel3.Size = new Size(459, 405);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtUnit
            // 
            txtUnit.Dock = DockStyle.Fill;
            txtUnit.Location = new Point(15, 360);
            txtUnit.Margin = new Padding(15, 0, 15, 0);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(429, 23);
            txtUnit.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Bottom;
            label7.Location = new Point(15, 345);
            label7.Margin = new Padding(15, 0, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(444, 15);
            label7.TabIndex = 26;
            label7.Text = "Đơn vị";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Location = new Point(15, 265);
            label6.Margin = new Padding(15, 0, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(444, 15);
            label6.TabIndex = 25;
            label6.Text = "Giá dịch vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(15, 185);
            label5.Margin = new Padding(15, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(444, 15);
            label5.TabIndex = 24;
            label5.Text = "Loại dịch vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Location = new Point(15, 105);
            label4.Margin = new Padding(15, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(444, 15);
            label4.TabIndex = 23;
            label4.Text = "Tên dịch vụ";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Dock = DockStyle.Fill;
            txtUnitPrice.Location = new Point(15, 280);
            txtUnitPrice.Margin = new Padding(15, 0, 15, 0);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(429, 23);
            txtUnitPrice.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(15, 120);
            txtName.Margin = new Padding(15, 0, 15, 0);
            txtName.Name = "txtName";
            txtName.Size = new Size(429, 23);
            txtName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(15, 25);
            label2.Margin = new Padding(15, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(444, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã dịch vụ";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(15, 40);
            txtId.Margin = new Padding(15, 0, 15, 0);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(429, 23);
            txtId.TabIndex = 1;
            // 
            // cbxServiceType
            // 
            cbxServiceType.Dock = DockStyle.Fill;
            cbxServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxServiceType.FormattingEnabled = true;
            cbxServiceType.Location = new Point(15, 200);
            cbxServiceType.Margin = new Padding(15, 0, 15, 0);
            cbxServiceType.Name = "cbxServiceType";
            cbxServiceType.Size = new Size(429, 23);
            cbxServiceType.TabIndex = 45;
            // 
            // ServiceInfoUI
            // 
            ClientSize = new Size(459, 528);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ServiceInfoUI";
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
        private TextBox txtUnit;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtUnitPrice;
        private TextBox txtName;
        private Button btnReset;
        private Panel panel3;
        private ComboBox cbxServiceType;
    }

    #endregion
}
