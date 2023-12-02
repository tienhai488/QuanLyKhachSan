namespace HotelManagement.GUI
{
    partial class RentRoomsUI
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
            panel4 = new Panel();
            panelRoomClean = new Panel();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton10 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton11 = new MaterialSkin.Controls.MaterialRadioButton();
            label3 = new Label();
            panel3 = new Panel();
            panelRoomType = new Panel();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            label2 = new Label();
            panel2 = new Panel();
            panelRoomStatus = new Panel();
            materialRadioButton8 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton7 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton6 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            label1 = new Label();
            flowLayoutRooms = new FlowLayoutPanel();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            datetimeFilter = new DateTimePicker();
            panel7 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtFilter = new MaterialSkin.Controls.MaterialTextBox();
            panel8 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panelRoomClean.SuspendLayout();
            panel3.SuspendLayout();
            panelRoomType.SuspendLayout();
            panel2.SuspendLayout();
            panelRoomStatus.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutRooms, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 111);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1484, 812);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 812);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelRoomClean);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 483);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(17, 20, 17, 20);
            panel4.Size = new Size(222, 297);
            panel4.TabIndex = 2;
            // 
            // panelRoomClean
            // 
            panelRoomClean.Controls.Add(materialRadioButton2);
            panelRoomClean.Controls.Add(materialRadioButton4);
            panelRoomClean.Controls.Add(materialRadioButton10);
            panelRoomClean.Controls.Add(materialRadioButton11);
            panelRoomClean.Dock = DockStyle.Fill;
            panelRoomClean.Location = new Point(17, 57);
            panelRoomClean.Name = "panelRoomClean";
            panelRoomClean.Size = new Size(188, 220);
            panelRoomClean.TabIndex = 0;
            // 
            // materialRadioButton2
            // 
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Dock = DockStyle.Top;
            materialRadioButton2.Location = new Point(0, 111);
            materialRadioButton2.Margin = new Padding(0);
            materialRadioButton2.MouseLocation = new Point(-1, -1);
            materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton2.Name = "materialRadioButton2";
            materialRadioButton2.Ripple = true;
            materialRadioButton2.Size = new Size(188, 37);
            materialRadioButton2.TabIndex = 17;
            materialRadioButton2.TabStop = true;
            materialRadioButton2.Text = "Maintaining";
            materialRadioButton2.UseVisualStyleBackColor = true;
            materialRadioButton2.MouseUp += roomClean_MouseUp;
            // 
            // materialRadioButton4
            // 
            materialRadioButton4.AutoSize = true;
            materialRadioButton4.Depth = 0;
            materialRadioButton4.Dock = DockStyle.Top;
            materialRadioButton4.Location = new Point(0, 74);
            materialRadioButton4.Margin = new Padding(0);
            materialRadioButton4.MouseLocation = new Point(-1, -1);
            materialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton4.Name = "materialRadioButton4";
            materialRadioButton4.Ripple = true;
            materialRadioButton4.Size = new Size(188, 37);
            materialRadioButton4.TabIndex = 16;
            materialRadioButton4.TabStop = true;
            materialRadioButton4.Text = "NotCleanedYet";
            materialRadioButton4.UseVisualStyleBackColor = true;
            materialRadioButton4.MouseUp += roomClean_MouseUp;
            // 
            // materialRadioButton10
            // 
            materialRadioButton10.AutoSize = true;
            materialRadioButton10.Depth = 0;
            materialRadioButton10.Dock = DockStyle.Top;
            materialRadioButton10.Location = new Point(0, 37);
            materialRadioButton10.Margin = new Padding(0);
            materialRadioButton10.MouseLocation = new Point(-1, -1);
            materialRadioButton10.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton10.Name = "materialRadioButton10";
            materialRadioButton10.Ripple = true;
            materialRadioButton10.Size = new Size(188, 37);
            materialRadioButton10.TabIndex = 15;
            materialRadioButton10.TabStop = true;
            materialRadioButton10.Text = "Cleaned";
            materialRadioButton10.UseVisualStyleBackColor = true;
            materialRadioButton10.MouseUp += roomClean_MouseUp;
            // 
            // materialRadioButton11
            // 
            materialRadioButton11.AutoSize = true;
            materialRadioButton11.Checked = true;
            materialRadioButton11.Depth = 0;
            materialRadioButton11.Dock = DockStyle.Top;
            materialRadioButton11.Location = new Point(0, 0);
            materialRadioButton11.Margin = new Padding(0);
            materialRadioButton11.MouseLocation = new Point(-1, -1);
            materialRadioButton11.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton11.Name = "materialRadioButton11";
            materialRadioButton11.Ripple = true;
            materialRadioButton11.Size = new Size(188, 37);
            materialRadioButton11.TabIndex = 14;
            materialRadioButton11.TabStop = true;
            materialRadioButton11.Text = "All";
            materialRadioButton11.UseVisualStyleBackColor = true;
            materialRadioButton11.MouseUp += roomClean_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 224, 130);
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(175, 37);
            label3.TabIndex = 3;
            label3.Text = "Room Clean";
            // 
            // panel3
            // 
            panel3.Controls.Add(panelRoomType);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 262);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(17, 20, 17, 20);
            panel3.Size = new Size(222, 221);
            panel3.TabIndex = 1;
            // 
            // panelRoomType
            // 
            panelRoomType.AutoScroll = true;
            panelRoomType.Controls.Add(materialRadioButton1);
            panelRoomType.Dock = DockStyle.Fill;
            panelRoomType.Location = new Point(17, 57);
            panelRoomType.Name = "panelRoomType";
            panelRoomType.Size = new Size(188, 144);
            panelRoomType.TabIndex = 0;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Checked = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Dock = DockStyle.Top;
            materialRadioButton1.Location = new Point(0, 0);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(188, 37);
            materialRadioButton1.TabIndex = 16;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "All";
            materialRadioButton1.UseVisualStyleBackColor = true;
            materialRadioButton1.MouseUp += roomType_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 130);
            label2.Location = new Point(17, 20);
            label2.Name = "label2";
            label2.Size = new Size(168, 37);
            label2.TabIndex = 2;
            label2.Text = "Room Type";
            // 
            // panel2
            // 
            panel2.Controls.Add(panelRoomStatus);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(17, 20, 17, 20);
            panel2.Size = new Size(222, 262);
            panel2.TabIndex = 0;
            // 
            // panelRoomStatus
            // 
            panelRoomStatus.AutoScroll = true;
            panelRoomStatus.Controls.Add(materialRadioButton8);
            panelRoomStatus.Controls.Add(materialRadioButton7);
            panelRoomStatus.Controls.Add(materialRadioButton6);
            panelRoomStatus.Controls.Add(materialRadioButton5);
            panelRoomStatus.Dock = DockStyle.Fill;
            panelRoomStatus.Location = new Point(17, 57);
            panelRoomStatus.Name = "panelRoomStatus";
            panelRoomStatus.Size = new Size(188, 185);
            panelRoomStatus.TabIndex = 15;
            // 
            // materialRadioButton8
            // 
            materialRadioButton8.AutoSize = true;
            materialRadioButton8.Depth = 0;
            materialRadioButton8.Dock = DockStyle.Top;
            materialRadioButton8.Location = new Point(0, 111);
            materialRadioButton8.Margin = new Padding(0);
            materialRadioButton8.MouseLocation = new Point(-1, -1);
            materialRadioButton8.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton8.Name = "materialRadioButton8";
            materialRadioButton8.Ripple = true;
            materialRadioButton8.Size = new Size(188, 37);
            materialRadioButton8.TabIndex = 13;
            materialRadioButton8.TabStop = true;
            materialRadioButton8.Text = "Rented";
            materialRadioButton8.UseVisualStyleBackColor = true;
            materialRadioButton8.MouseUp += roomStatus_MouseUp;
            // 
            // materialRadioButton7
            // 
            materialRadioButton7.AutoSize = true;
            materialRadioButton7.Depth = 0;
            materialRadioButton7.Dock = DockStyle.Top;
            materialRadioButton7.Location = new Point(0, 74);
            materialRadioButton7.Margin = new Padding(0);
            materialRadioButton7.MouseLocation = new Point(-1, -1);
            materialRadioButton7.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton7.Name = "materialRadioButton7";
            materialRadioButton7.Ripple = true;
            materialRadioButton7.Size = new Size(188, 37);
            materialRadioButton7.TabIndex = 12;
            materialRadioButton7.TabStop = true;
            materialRadioButton7.Text = "Booked";
            materialRadioButton7.UseVisualStyleBackColor = true;
            materialRadioButton7.MouseUp += roomStatus_MouseUp;
            // 
            // materialRadioButton6
            // 
            materialRadioButton6.AutoSize = true;
            materialRadioButton6.Depth = 0;
            materialRadioButton6.Dock = DockStyle.Top;
            materialRadioButton6.Location = new Point(0, 37);
            materialRadioButton6.Margin = new Padding(0);
            materialRadioButton6.MouseLocation = new Point(-1, -1);
            materialRadioButton6.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton6.Name = "materialRadioButton6";
            materialRadioButton6.Ripple = true;
            materialRadioButton6.Size = new Size(188, 37);
            materialRadioButton6.TabIndex = 11;
            materialRadioButton6.TabStop = true;
            materialRadioButton6.Text = "Empty";
            materialRadioButton6.UseVisualStyleBackColor = true;
            materialRadioButton6.MouseUp += roomStatus_MouseUp;
            // 
            // materialRadioButton5
            // 
            materialRadioButton5.AutoSize = true;
            materialRadioButton5.Checked = true;
            materialRadioButton5.Depth = 0;
            materialRadioButton5.Dock = DockStyle.Top;
            materialRadioButton5.Location = new Point(0, 0);
            materialRadioButton5.Margin = new Padding(0);
            materialRadioButton5.MouseLocation = new Point(-1, -1);
            materialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton5.Name = "materialRadioButton5";
            materialRadioButton5.Ripple = true;
            materialRadioButton5.Size = new Size(188, 37);
            materialRadioButton5.TabIndex = 10;
            materialRadioButton5.TabStop = true;
            materialRadioButton5.Text = "All";
            materialRadioButton5.UseVisualStyleBackColor = true;
            materialRadioButton5.MouseUp += roomStatus_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 130);
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 1;
            label1.Text = "Room Status";
            // 
            // flowLayoutRooms
            // 
            flowLayoutRooms.AutoScroll = true;
            flowLayoutRooms.BackColor = Color.White;
            flowLayoutRooms.Dock = DockStyle.Fill;
            flowLayoutRooms.Location = new Point(222, 0);
            flowLayoutRooms.Margin = new Padding(0);
            flowLayoutRooms.Name = "flowLayoutRooms";
            flowLayoutRooms.Padding = new Padding(17, 20, 17, 20);
            flowLayoutRooms.Size = new Size(1262, 812);
            flowLayoutRooms.TabIndex = 1;
            flowLayoutRooms.MouseUp += roomStatus_MouseUp;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 4);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1484, 107);
            panel5.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Controls.Add(panel6, 0, 0);
            tableLayoutPanel2.Controls.Add(panel7, 1, 0);
            tableLayoutPanel2.Controls.Add(panel8, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1484, 107);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(datetimeFilter);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 107);
            panel6.TabIndex = 9;
            // 
            // datetimeFilter
            // 
            datetimeFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datetimeFilter.CustomFormat = "dd/MM/yyyy";
            datetimeFilter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            datetimeFilter.Format = DateTimePickerFormat.Custom;
            datetimeFilter.Location = new Point(0, 31);
            datetimeFilter.Margin = new Padding(3, 4, 3, 4);
            datetimeFilter.Name = "datetimeFilter";
            datetimeFilter.Size = new Size(218, 39);
            datetimeFilter.TabIndex = 3;
            datetimeFilter.ValueChanged += datetimeFilter_ValueChanged;
            // 
            // panel7
            // 
            panel7.Controls.Add(materialLabel1);
            panel7.Controls.Add(txtFilter);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(222, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(742, 107);
            panel7.TabIndex = 10;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            materialLabel1.Location = new Point(8, 10);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(44, 14);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "RoomID";
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFilter.AnimateReadOnly = false;
            txtFilter.BorderStyle = BorderStyle.None;
            txtFilter.Depth = 0;
            txtFilter.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFilter.LeadingIcon = null;
            txtFilter.Location = new Point(0, 31);
            txtFilter.Margin = new Padding(3, 4, 3, 4);
            txtFilter.MaxLength = 50;
            txtFilter.MouseState = MaterialSkin.MouseState.OUT;
            txtFilter.Multiline = false;
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(739, 50);
            txtFilter.TabIndex = 9;
            txtFilter.Text = "";
            txtFilter.TrailingIcon = null;
            txtFilter.KeyUp += txtFilter_KeyUp;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(964, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(520, 107);
            panel8.TabIndex = 11;
            // 
            // RentRoomsUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 927);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel5);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RentRoomsUI";
            Padding = new Padding(3, 4, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomUI";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelRoomClean.ResumeLayout(false);
            panelRoomClean.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelRoomType.ResumeLayout(false);
            panelRoomType.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelRoomStatus.ResumeLayout(false);
            panelRoomStatus.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private FlowLayoutPanel flowLayoutRooms;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private DateTimePicker datetimeFilter;
        private Panel panel7;
        private MaterialSkin.Controls.MaterialTextBox txtFilter;
        private Panel panel8;
        private Panel panelRoomStatus;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton8;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton7;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton6;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private Panel panelRoomClean;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton10;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton11;
        private Panel panelRoomType;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}