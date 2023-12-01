namespace HotelManagement.GUI
{
    partial class InvoiceListUI
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
            dataGridViewInvoice = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            dateTimePickerInvoice = new DateTimePicker();
            panel2 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtRentRoomId = new MaterialSkin.Controls.MaterialTextBox();
            panel3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(dataGridViewInvoice, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1163, 677);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.AllowUserToAddRows = false;
            dataGridViewInvoice.AllowUserToDeleteRows = false;
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInvoice.BackgroundColor = SystemColors.Control;
            dataGridViewInvoice.BorderStyle = BorderStyle.None;
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Dock = DockStyle.Fill;
            dataGridViewInvoice.Location = new Point(119, 103);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.ReadOnly = true;
            dataGridViewInvoice.RowHeadersVisible = false;
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.RowTemplate.Height = 25;
            dataGridViewInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInvoice.Size = new Size(924, 571);
            dataGridViewInvoice.TabIndex = 5;
            dataGridViewInvoice.DoubleClick += dataGridViewInvoice_DoubleClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel3, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(116, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(3);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(930, 100);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePickerInvoice);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 94);
            panel1.TabIndex = 3;
            // 
            // dateTimePickerInvoice
            // 
            dateTimePickerInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerInvoice.CustomFormat = "dd/MM/yyyy";
            dateTimePickerInvoice.Format = DateTimePickerFormat.Custom;
            dateTimePickerInvoice.Location = new Point(3, 37);
            dateTimePickerInvoice.Name = "dateTimePickerInvoice";
            dateTimePickerInvoice.Size = new Size(242, 27);
            dateTimePickerInvoice.TabIndex = 0;
            dateTimePickerInvoice.ValueChanged += dateTimePickerInvoice_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(txtRentRoomId);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(280, 3);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 94);
            panel2.TabIndex = 4;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(3, 36);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(127, 24);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Rent Room ID:";
            // 
            // txtRentRoomId
            // 
            txtRentRoomId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRentRoomId.AnimateReadOnly = false;
            txtRentRoomId.BorderStyle = BorderStyle.None;
            txtRentRoomId.Depth = 0;
            txtRentRoomId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRentRoomId.LeadingIcon = null;
            txtRentRoomId.Location = new Point(126, 25);
            txtRentRoomId.MaxLength = 50;
            txtRentRoomId.MouseState = MaterialSkin.MouseState.OUT;
            txtRentRoomId.Multiline = false;
            txtRentRoomId.Name = "txtRentRoomId";
            txtRentRoomId.Size = new Size(333, 50);
            txtRentRoomId.TabIndex = 0;
            txtRentRoomId.Text = "";
            txtRentRoomId.TrailingIcon = null;
            txtRentRoomId.TextChanged += txtRentRoomId_TextChanged;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(742, 3);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 94);
            panel3.TabIndex = 5;
            // 
            // InvoiceListUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 677);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "InvoiceListUI";
            Padding = new Padding(0);
            Text = "InvoiceList";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewInvoice;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtRentRoomId;
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dateTimePickerInvoice;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}