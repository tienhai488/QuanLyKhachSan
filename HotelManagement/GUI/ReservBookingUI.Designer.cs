using System.Windows.Forms;

namespace HotelManagement.GUI
{
    partial class ReservBookingUI
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
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();

            panelGender = new Panel();
            radioBtnMale = new MaterialSkin.Controls.MaterialRadioButton();
            radioBtnFemale = new MaterialSkin.Controls.MaterialRadioButton();
            txtId = new MaterialSkin.Controls.MaterialTextBox();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            txtCCCD = new MaterialSkin.Controls.MaterialTextBox();
            labelDontExist = new MaterialSkin.Controls.MaterialLabel();
            btnAddCustomer = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel7 = new Panel();
            fromTime = new DateTimePicker();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            panel5 = new Panel();
            tableRoom = new DataGridView();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            panel4 = new Panel();
            tableBook = new DataGridView();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            panel3 = new Panel();
            toTime = new DateTimePicker();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            panel6 = new Panel();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();

            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panelGender.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel7.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)tableRoom).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableBook).BeginInit();

            panel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 2);
            tableLayoutPanel1.Controls.Add(materialLabel12, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel1.Size = new Size(1232, 701);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(materialLabel2, 0, 0);
            tableLayoutPanel2.Controls.Add(materialLabel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(61, 52);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1108, 595);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Fill;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.ForeColor = SystemColors.ControlText;
            materialLabel2.Location = new Point(3, 3);
            materialLabel2.Margin = new Padding(3);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(326, 34);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Customer Information";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Fill;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(335, 3);
            materialLabel3.Margin = new Padding(3);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(770, 34);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Room Information";
            materialLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 

            panel1.Controls.Add(panelGender);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(materialLabel8);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(labelDontExist);
            panel1.Controls.Add(btnAddCustomer);
            panel1.Controls.Add(materialLabel6);
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(materialLabel1);

            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(332, 555);
            panel1.TabIndex = 4;
            // 
            // panelGender
            // 
            panelGender.Controls.Add(radioBtnMale);
            panelGender.Controls.Add(radioBtnFemale);
            panelGender.Enabled = false;
            panelGender.Location = new Point(158, 395);
            panelGender.Name = "panelGender";
            panelGender.Size = new Size(198, 59);
            panelGender.TabIndex = 22;
            // 
            // radioBtnMale
            // 
            radioBtnMale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioBtnMale.AutoSize = true;
            radioBtnMale.Checked = true;
            radioBtnMale.Depth = 0;
            radioBtnMale.Location = new Point(6, 14);
            radioBtnMale.Margin = new Padding(0);
            radioBtnMale.MouseLocation = new Point(-1, -1);
            radioBtnMale.MouseState = MaterialSkin.MouseState.HOVER;
            radioBtnMale.Name = "radioBtnMale";
            radioBtnMale.Ripple = true;
            radioBtnMale.Size = new Size(70, 37);
            radioBtnMale.TabIndex = 8;
            radioBtnMale.TabStop = true;
            radioBtnMale.Text = "Male";
            radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            radioBtnFemale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioBtnFemale.AutoSize = true;
            radioBtnFemale.Depth = 0;
            radioBtnFemale.Location = new Point(87, 14);
            radioBtnFemale.Margin = new Padding(0);
            radioBtnFemale.MouseLocation = new Point(-1, -1);
            radioBtnFemale.MouseState = MaterialSkin.MouseState.HOVER;
            radioBtnFemale.Name = "radioBtnFemale";
            radioBtnFemale.Ripple = true;
            radioBtnFemale.Size = new Size(87, 37);
            radioBtnFemale.TabIndex = 9;
            radioBtnFemale.TabStop = true;
            radioBtnFemale.Text = "Female";
            radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtId.AnimateReadOnly = false;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.LeadingIcon = null;
            txtId.Location = new Point(17, 58);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 50;
            txtId.MouseState = MaterialSkin.MouseState.OUT;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(343, 50);
            txtId.TabIndex = 21;
            txtId.Text = "";
            txtId.TrailingIcon = null;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.LeadingIcon = null;
            txtName.Location = new Point(21, 473);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(339, 50);
            txtName.TabIndex = 20;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel8.Location = new Point(17, 20);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(160, 24);
            materialLabel8.TabIndex = 7;
            materialLabel8.Text = "RESERVATION ID:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.AnimateReadOnly = false;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(17, 328);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.MaxLength = 50;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(339, 50);
            txtPhone.TabIndex = 19;
            txtPhone.Text = "";
            txtPhone.TrailingIcon = null;
            // 
            // txtCCCD
            // 
            txtCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCCCD.AnimateReadOnly = false;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Depth = 0;
            txtCCCD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCCCD.LeadingIcon = null;
            txtCCCD.Location = new Point(17, 192);
            txtCCCD.Margin = new Padding(3, 4, 3, 4);
            txtCCCD.MaxLength = 50;
            txtCCCD.MouseState = MaterialSkin.MouseState.OUT;
            txtCCCD.Multiline = false;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(339, 50);
            txtCCCD.TabIndex = 18;
            txtCCCD.Text = "";
            txtCCCD.TrailingIcon = null;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            // 
            // labelDontExist
            // 
            labelDontExist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDontExist.AutoSize = true;
            labelDontExist.Depth = 0;
            labelDontExist.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelDontExist.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelDontExist.Location = new Point(21, 566);
            labelDontExist.MouseState = MaterialSkin.MouseState.HOVER;
            labelDontExist.Name = "labelDontExist";
            labelDontExist.Size = new Size(104, 24);
            labelDontExist.TabIndex = 13;
            labelDontExist.Text = "Don't Exist?";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddCustomer.Depth = 0;
            btnAddCustomer.HighEmphasis = true;
            btnAddCustomer.Icon = null;
            btnAddCustomer.Location = new Point(191, 554);
            btnAddCustomer.Margin = new Padding(5, 8, 5, 8);
            btnAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.NoAccentTextColor = Color.Empty;
            btnAddCustomer.Size = new Size(169, 36);
            btnAddCustomer.TabIndex = 11;
            btnAddCustomer.Text = "Add Customer Info";
            btnAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddCustomer.UseAccentColor = false;
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel6.Location = new Point(21, 430);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(62, 24);
            materialLabel6.TabIndex = 5;
            materialLabel6.Text = "NAME:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.Location = new Point(17, 286);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(72, 24);
            materialLabel5.TabIndex = 3;
            materialLabel5.Text = "PHONE:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(17, 150);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(58, 24);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "CCCD:";

            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(332, 40);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 555);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel7, 0, 0);
            tableLayoutPanel4.Controls.Add(panel5, 0, 1);
            tableLayoutPanel4.Controls.Add(panel4, 0, 1);
            tableLayoutPanel4.Controls.Add(panel3, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(776, 555);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel7

            panel7.Controls.Add(fromTime);
            panel7.Controls.Add(materialLabel4);

            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(15);
            panel7.Size = new Size(388, 48);
            panel7.TabIndex = 16;
            // 
            // fromTime

            fromTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fromTime.CustomFormat = "dd/MM/yyyy";
            fromTime.Format = DateTimePickerFormat.Custom;
            fromTime.Location = new Point(97, 21);
            fromTime.Margin = new Padding(3, 4, 3, 4);
            fromTime.Name = "fromTime";
            fromTime.Size = new Size(326, 27);
            fromTime.TabIndex = 15;
            fromTime.ValueChanged += fromTime_ValueChanged;

            // 
            // materialLabel600
            // 
            materialLabel600.AutoSize = true;
            materialLabel600.Depth = 0;
            materialLabel600.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel600.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel600.Location = new Point(18, 15);
            materialLabel600.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel600.Name = "materialLabel600";
            materialLabel600.Size = new Size(61, 24);
            materialLabel600.TabIndex = 14;
            materialLabel600.Text = "FROM:";
            // 
            // panel5

            panel5.Controls.Add(tableRoom);
            panel5.Controls.Add(materialLabel11);

            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 48);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(18, 15, 18, 15);
            panel5.Size = new Size(388, 507);
            panel5.TabIndex = 3;

            // tableRoom
            // 
            tableRoom.AllowUserToAddRows = false;
            tableRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableRoom.BackgroundColor = SystemColors.Control;
            tableRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableRoom.Dock = DockStyle.Fill;
            tableRoom.Location = new Point(21, 44);
            tableRoom.Margin = new Padding(3, 4, 3, 4);
            tableRoom.MultiSelect = false;
            tableRoom.Name = "tableRoom";
            tableRoom.ReadOnly = true;
            tableRoom.RightToLeft = RightToLeft.No;
            tableRoom.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tableRoom.RowHeadersVisible = false;
            tableRoom.RowHeadersWidth = 51;
            tableRoom.RowTemplate.Height = 25;
            tableRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableRoom.Size = new Size(402, 674);
            tableRoom.TabIndex = 16;
            tableRoom.CellContentClick += tableRoom_CellContentClick;

            // 
            // materialLabel800
            // 
            materialLabel800.AutoSize = true;
            materialLabel800.Depth = 0;
            materialLabel800.Dock = DockStyle.Top;
            materialLabel800.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel800.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel800.Location = new Point(18, 15);
            materialLabel800.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel800.Name = "materialLabel800";
            materialLabel800.Size = new Size(173, 24);
            materialLabel800.TabIndex = 15;
            materialLabel800.Text = "AVAILABLE ROOM:";
            // 
            // panel4

            panel4.Controls.Add(tableBook);
            panel4.Controls.Add(materialLabel10);

            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(388, 48);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(18, 15, 18, 15);
            panel4.Size = new Size(388, 507);
            panel4.TabIndex = 2;

            // tableBook
            // 
            tableBook.AllowUserToAddRows = false;
            tableBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableBook.BackgroundColor = SystemColors.Control;
            tableBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableBook.Dock = DockStyle.Fill;
            tableBook.Location = new Point(21, 44);
            tableBook.Margin = new Padding(3, 4, 3, 4);
            tableBook.MultiSelect = false;
            tableBook.Name = "tableBook";
            tableBook.ReadOnly = true;
            tableBook.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tableBook.RowHeadersVisible = false;
            tableBook.RowHeadersWidth = 51;
            tableBook.RowTemplate.Height = 25;
            tableBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableBook.Size = new Size(402, 674);
            tableBook.TabIndex = 15;
            tableBook.CellContentClick += tableBook_CellContentClick;

            // 
            // materialLabel900
            // 
            materialLabel900.AutoSize = true;
            materialLabel900.Depth = 0;
            materialLabel900.Dock = DockStyle.Top;
            materialLabel900.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel900.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel900.Location = new Point(18, 15);
            materialLabel900.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel900.Name = "materialLabel900";
            materialLabel900.Size = new Size(163, 24);
            materialLabel900.TabIndex = 14;
            materialLabel900.Text = "SELECTED ROOM:";
            // 
            // panel3
            // 

            panel3.Controls.Add(toTime);
            panel3.Controls.Add(materialLabel9);

            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(388, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15);
            panel3.Size = new Size(388, 48);
            panel3.TabIndex = 15;
            // 
            // toTime
            // 

            toTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toTime.CustomFormat = "dd/MM/yyyy";
            toTime.Format = DateTimePickerFormat.Custom;
            toTime.Location = new Point(64, 21);
            toTime.Margin = new Padding(3, 4, 3, 4);
            toTime.Name = "toTime";
            toTime.Size = new Size(360, 27);
            toTime.TabIndex = 16;
            toTime.ValueChanged += toTime_ValueChanged;

            // 
            // materialLabel700
            // 
            materialLabel700.AutoSize = true;
            materialLabel700.Depth = 0;
            materialLabel700.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel700.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel700.Location = new Point(18, 15);
            materialLabel700.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel700.Name = "materialLabel700";
            materialLabel700.Size = new Size(32, 24);
            materialLabel700.TabIndex = 16;
            materialLabel700.Text = "TO:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.Controls.Add(panel9, 1, 0);
            tableLayoutPanel5.Controls.Add(panel6, 2, 0);
            tableLayoutPanel5.Controls.Add(panel8, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(61, 647);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1108, 54);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(mbtnSelect);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(332, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(387, 54);
            panel9.TabIndex = 4;
            // 
            // mbtnSelect
            // 
            mbtnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mbtnSelect.AutoSize = false;
            mbtnSelect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnSelect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSelect.Depth = 0;
            mbtnSelect.HighEmphasis = true;
            mbtnSelect.Icon = null;
            mbtnSelect.Location = new Point(212, 6);
            mbtnSelect.Margin = new Padding(4, 6, 4, 6);
            mbtnSelect.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSelect.Name = "mbtnSelect";
            mbtnSelect.NoAccentTextColor = Color.Empty;
            mbtnSelect.Size = new Size(158, 36);
            mbtnSelect.TabIndex = 11;
            mbtnSelect.Text = "SELECT";
            mbtnSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSelect.UseAccentColor = false;
            mbtnSelect.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 

            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(btnSave);

            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(719, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(389, 54);
            panel6.TabIndex = 1;

            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = false;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(1067, 8);
            btnCancel.Margin = new Padding(5, 8, 5, 8);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(181, 48);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancel.UseAccentColor = true;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(877, 8);
            btnSave.Margin = new Padding(5, 8, 5, 8);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(181, 48);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            // 
            // ReservBookingUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 768);
            Controls.Add(tableLayoutPanel1);
            Name = "ReservBookingUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RESERVATION";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelGender.ResumeLayout(false);
            panelGender.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)tableRoom).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableBook).EndInit();

            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Panel panel1;

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnMale;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnFemale;
        private MaterialSkin.Controls.MaterialButton btnAddCustomer;
        private MaterialSkin.Controls.MaterialLabel labelDontExist;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel6;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private Panel panel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Panel panel5;
        private DataGridView tableRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private Panel panel4;
        private DataGridView tableBook;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private Panel panel3;
        private DateTimePicker toTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtCCCD;
        private DateTimePicker fromTime;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private Panel panelGender;

    }
}