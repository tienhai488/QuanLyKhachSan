namespace HotelManagement.GUI
{
    partial class CustomerUI
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnDelFilterID = new Button();
            cbxFilterID = new ComboBox();
            tabPage8 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            cbxFilterName = new ComboBox();
            cbxDeleteFilterName = new Button();
            tabPage9 = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            cbxFilterGender = new ComboBox();
            cbxDeleteFilterGender = new Button();
            tabPage10 = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            cbxFilterCCCD = new ComboBox();
            cbxDeleteFilterCCCD = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnFilter = new Button();
            btnDeleteAllFilter = new Button();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnAddCustomer = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tabPage8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabPage9.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabPage10.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = SystemColors.HotTrack;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 3, 5, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1557, 727);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 3);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1157, 721);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(5, 3, 5, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1157, 721);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 206);
            panel3.Margin = new Padding(5, 3, 5, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1147, 512);
            panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = SystemColors.Desktop;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(5, 3, 5, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 3, 5, 3);
            groupBox2.Size = new Size(1147, 512);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(5, 35);
            dataGridView1.Margin = new Padding(5, 3, 5, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1137, 474);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 3);
            panel2.Margin = new Padding(5, 3, 5, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 197);
            panel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(5, 3, 5, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 3, 5, 3);
            groupBox3.Size = new Size(1147, 197);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filter";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tabControl2, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 35);
            tableLayoutPanel3.Margin = new Padding(5, 3, 5, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(1137, 159);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Controls.Add(tabPage9);
            tabControl2.Controls.Add(tabPage10);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(5, 3);
            tabControl2.Margin = new Padding(5, 3, 5, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1127, 100);
            tabControl2.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel6);
            tabPage4.Location = new Point(4, 40);
            tabPage4.Margin = new Padding(5, 3, 5, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1119, 56);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Mã KH";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.Controls.Add(btnDelFilterID, 1, 0);
            tableLayoutPanel6.Controls.Add(cbxFilterID, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(5, 3, 5, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1119, 56);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btnDelFilterID
            // 
            btnDelFilterID.BackColor = Color.FromArgb(74, 20, 140);
            btnDelFilterID.Dock = DockStyle.Fill;
            btnDelFilterID.FlatAppearance.BorderSize = 0;
            btnDelFilterID.FlatStyle = FlatStyle.Flat;
            btnDelFilterID.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelFilterID.ForeColor = SystemColors.ButtonHighlight;
            btnDelFilterID.Location = new Point(788, 3);
            btnDelFilterID.Margin = new Padding(5, 3, 5, 3);
            btnDelFilterID.Name = "btnDelFilterID";
            btnDelFilterID.Size = new Size(326, 50);
            btnDelFilterID.TabIndex = 3;
            btnDelFilterID.Text = "Xóa";
            btnDelFilterID.UseVisualStyleBackColor = false;
            btnDelFilterID.Click += btnDelFilterID_Click;
            // 
            // cbxFilterID
            // 
            cbxFilterID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilterID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilterID.Dock = DockStyle.Fill;
            cbxFilterID.FlatStyle = FlatStyle.Popup;
            cbxFilterID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilterID.FormattingEnabled = true;
            cbxFilterID.Location = new Point(5, 3);
            cbxFilterID.Margin = new Padding(5, 3, 5, 3);
            cbxFilterID.Name = "cbxFilterID";
            cbxFilterID.Size = new Size(773, 49);
            cbxFilterID.TabIndex = 4;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(tableLayoutPanel4);
            tabPage8.Location = new Point(4, 29);
            tabPage8.Margin = new Padding(5, 3, 5, 3);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1119, 75);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "Tên KH";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Controls.Add(cbxFilterName, 0, 0);
            tableLayoutPanel4.Controls.Add(cbxDeleteFilterName, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1119, 75);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // cbxFilterName
            // 
            cbxFilterName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilterName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilterName.Dock = DockStyle.Fill;
            cbxFilterName.FlatStyle = FlatStyle.Popup;
            cbxFilterName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilterName.FormattingEnabled = true;
            cbxFilterName.Location = new Point(5, 3);
            cbxFilterName.Margin = new Padding(5, 3, 5, 3);
            cbxFilterName.Name = "cbxFilterName";
            cbxFilterName.Size = new Size(773, 49);
            cbxFilterName.TabIndex = 5;
            // 
            // cbxDeleteFilterName
            // 
            cbxDeleteFilterName.BackColor = Color.FromArgb(74, 20, 140);
            cbxDeleteFilterName.Dock = DockStyle.Fill;
            cbxDeleteFilterName.FlatAppearance.BorderSize = 0;
            cbxDeleteFilterName.FlatStyle = FlatStyle.Flat;
            cbxDeleteFilterName.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDeleteFilterName.ForeColor = SystemColors.ButtonHighlight;
            cbxDeleteFilterName.Location = new Point(788, 3);
            cbxDeleteFilterName.Margin = new Padding(5, 3, 5, 3);
            cbxDeleteFilterName.Name = "cbxDeleteFilterName";
            cbxDeleteFilterName.Size = new Size(326, 69);
            cbxDeleteFilterName.TabIndex = 3;
            cbxDeleteFilterName.Text = "Xóa";
            cbxDeleteFilterName.UseVisualStyleBackColor = false;
            cbxDeleteFilterName.Click += cbxDeleteFilterName_Click;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(tableLayoutPanel7);
            tabPage9.Location = new Point(4, 29);
            tabPage9.Margin = new Padding(0);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(1119, 75);
            tabPage9.TabIndex = 3;
            tabPage9.Text = "Giới Tính";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.Controls.Add(cbxFilterGender, 0, 0);
            tableLayoutPanel7.Controls.Add(cbxDeleteFilterGender, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(5, 3, 5, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1119, 75);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // cbxFilterGender
            // 
            cbxFilterGender.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilterGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilterGender.Dock = DockStyle.Fill;
            cbxFilterGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFilterGender.FlatStyle = FlatStyle.Popup;
            cbxFilterGender.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilterGender.FormattingEnabled = true;
            cbxFilterGender.Location = new Point(5, 3);
            cbxFilterGender.Margin = new Padding(5, 3, 5, 3);
            cbxFilterGender.Name = "cbxFilterGender";
            cbxFilterGender.Size = new Size(773, 49);
            cbxFilterGender.TabIndex = 5;
            // 
            // cbxDeleteFilterGender
            // 
            cbxDeleteFilterGender.BackColor = Color.FromArgb(74, 20, 140);
            cbxDeleteFilterGender.Dock = DockStyle.Fill;
            cbxDeleteFilterGender.FlatAppearance.BorderSize = 0;
            cbxDeleteFilterGender.FlatStyle = FlatStyle.Flat;
            cbxDeleteFilterGender.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDeleteFilterGender.ForeColor = SystemColors.ButtonHighlight;
            cbxDeleteFilterGender.Location = new Point(788, 3);
            cbxDeleteFilterGender.Margin = new Padding(5, 3, 5, 3);
            cbxDeleteFilterGender.Name = "cbxDeleteFilterGender";
            cbxDeleteFilterGender.Size = new Size(326, 69);
            cbxDeleteFilterGender.TabIndex = 3;
            cbxDeleteFilterGender.Text = "Xóa";
            cbxDeleteFilterGender.UseVisualStyleBackColor = false;
            cbxDeleteFilterGender.Click += cbxDeleteFilterGender_Click;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(tableLayoutPanel8);
            tabPage10.Location = new Point(4, 29);
            tabPage10.Margin = new Padding(5, 3, 5, 3);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(1119, 75);
            tabPage10.TabIndex = 4;
            tabPage10.Text = "CCCD";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.Controls.Add(cbxFilterCCCD, 0, 0);
            tableLayoutPanel8.Controls.Add(cbxDeleteFilterCCCD, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(5, 3, 5, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1119, 75);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // cbxFilterCCCD
            // 
            cbxFilterCCCD.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilterCCCD.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilterCCCD.Dock = DockStyle.Fill;
            cbxFilterCCCD.FlatStyle = FlatStyle.Popup;
            cbxFilterCCCD.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilterCCCD.FormattingEnabled = true;
            cbxFilterCCCD.Location = new Point(5, 3);
            cbxFilterCCCD.Margin = new Padding(5, 3, 5, 3);
            cbxFilterCCCD.Name = "cbxFilterCCCD";
            cbxFilterCCCD.Size = new Size(773, 49);
            cbxFilterCCCD.TabIndex = 5;
            // 
            // cbxDeleteFilterCCCD
            // 
            cbxDeleteFilterCCCD.BackColor = Color.FromArgb(74, 20, 140);
            cbxDeleteFilterCCCD.Dock = DockStyle.Fill;
            cbxDeleteFilterCCCD.FlatAppearance.BorderSize = 0;
            cbxDeleteFilterCCCD.FlatStyle = FlatStyle.Flat;
            cbxDeleteFilterCCCD.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cbxDeleteFilterCCCD.ForeColor = SystemColors.ButtonHighlight;
            cbxDeleteFilterCCCD.Location = new Point(788, 3);
            cbxDeleteFilterCCCD.Margin = new Padding(5, 3, 5, 3);
            cbxDeleteFilterCCCD.Name = "cbxDeleteFilterCCCD";
            cbxDeleteFilterCCCD.Size = new Size(326, 69);
            cbxDeleteFilterCCCD.TabIndex = 3;
            cbxDeleteFilterCCCD.Text = "Xóa";
            cbxDeleteFilterCCCD.UseVisualStyleBackColor = false;
            cbxDeleteFilterCCCD.Click += cbxDeleteFilterCCCD_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnFilter, 1, 0);
            tableLayoutPanel5.Controls.Add(btnDeleteAllFilter, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(5, 109);
            tableLayoutPanel5.Margin = new Padding(5, 3, 5, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1127, 47);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.MediumAquamarine;
            btnFilter.Dock = DockStyle.Fill;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.ForeColor = SystemColors.ButtonHighlight;
            btnFilter.Location = new Point(568, 3);
            btnFilter.Margin = new Padding(5, 3, 5, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(554, 41);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnDeleteAllFilter
            // 
            btnDeleteAllFilter.BackColor = Color.White;
            btnDeleteAllFilter.Dock = DockStyle.Fill;
            btnDeleteAllFilter.FlatAppearance.BorderColor = Color.FromArgb(173, 20, 87);
            btnDeleteAllFilter.FlatAppearance.BorderSize = 0;
            btnDeleteAllFilter.FlatStyle = FlatStyle.Flat;
            btnDeleteAllFilter.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAllFilter.ForeColor = Color.FromArgb(173, 20, 87);
            btnDeleteAllFilter.Location = new Point(5, 3);
            btnDeleteAllFilter.Margin = new Padding(5, 3, 5, 3);
            btnDeleteAllFilter.Name = "btnDeleteAllFilter";
            btnDeleteAllFilter.Size = new Size(553, 41);
            btnDeleteAllFilter.TabIndex = 0;
            btnDeleteAllFilter.Text = "Xóa tất cả";
            btnDeleteAllFilter.UseVisualStyleBackColor = false;
            btnDeleteAllFilter.Click += btnDeleteAllFilter_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1172, 3);
            panel4.Margin = new Padding(5, 3, 5, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 721);
            panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5, 3, 5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 3, 5, 3);
            groupBox1.Size = new Size(380, 721);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnUpdateCustomer);
            panel5.Controls.Add(btnDeleteCustomer);
            panel5.Controls.Add(btnAddCustomer);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(5, 35);
            panel5.Margin = new Padding(5, 3, 5, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(370, 683);
            panel5.TabIndex = 0;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateCustomer.BackColor = Color.FromArgb(255, 224, 130);
            btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            btnUpdateCustomer.FlatStyle = FlatStyle.Flat;
            btnUpdateCustomer.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateCustomer.ForeColor = SystemColors.Control;
            btnUpdateCustomer.Location = new Point(6, 83);
            btnUpdateCustomer.Margin = new Padding(14, 13, 14, 13);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(364, 58);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "Cập nhật khách hàng";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteCustomer.BackColor = Color.FromArgb(173, 20, 87);
            btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteCustomer.ForeColor = SystemColors.Control;
            btnDeleteCustomer.Location = new Point(6, 153);
            btnDeleteCustomer.Margin = new Padding(14, 13, 14, 13);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(364, 58);
            btnDeleteCustomer.TabIndex = 1;
            btnDeleteCustomer.Text = "Xóa khách hàng";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddCustomer.BackColor = Color.DeepSkyBlue;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCustomer.ForeColor = SystemColors.Control;
            btnAddCustomer.Location = new Point(6, 13);
            btnAddCustomer.Margin = new Padding(14, 13, 14, 13);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(364, 58);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Thêm khách hàng";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // CustomerUI
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 727);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "CustomerUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerUI";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tabPage10.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnDelFilterID;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnFilter;
        private Button btnDeleteAllFilter;
        private Panel panel4;
        private GroupBox groupBox1;
        private Panel panel5;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private Button btnAddCustomer;
        private ComboBox cbxFilterID;
        private TableLayoutPanel tableLayoutPanel4;
        private Button cbxDeleteFilterName;
        private TableLayoutPanel tableLayoutPanel7;
        private Button cbxDeleteFilterGender;
        private TableLayoutPanel tableLayoutPanel8;
        private Button cbxDeleteFilterCCCD;
        private ComboBox cbxFilterName;
        private ComboBox cbxFilterGender;
        private ComboBox cbxFilterCCCD;
    }
}