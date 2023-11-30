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
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            dateTimePickerInvoice = new DateTimePicker();
            panel2 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mtxtCustomerID = new MaterialSkin.Controls.MaterialTextBox();
            panel3 = new Panel();
            mbtnSearch = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(119, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(924, 571);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            dateTimePickerInvoice.Location = new Point(3, 37);
            dateTimePickerInvoice.Name = "dateTimePickerInvoice";
            dateTimePickerInvoice.Size = new Size(242, 23);
            dateTimePickerInvoice.TabIndex = 0;
            dateTimePickerInvoice.ValueChanged += dateTimePickerInvoice_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(mtxtCustomerID);
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
            materialLabel1.Size = new Size(117, 24);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Customer ID:";
            // 
            // mtxtCustomerID
            // 
            mtxtCustomerID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtxtCustomerID.AnimateReadOnly = false;
            mtxtCustomerID.BorderStyle = BorderStyle.None;
            mtxtCustomerID.Depth = 0;
            mtxtCustomerID.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtCustomerID.LeadingIcon = null;
            mtxtCustomerID.Location = new Point(126, 25);
            mtxtCustomerID.MaxLength = 50;
            mtxtCustomerID.MouseState = MaterialSkin.MouseState.OUT;
            mtxtCustomerID.Multiline = false;
            mtxtCustomerID.Name = "mtxtCustomerID";
            mtxtCustomerID.Size = new Size(333, 50);
            mtxtCustomerID.TabIndex = 0;
            mtxtCustomerID.Text = "";
            mtxtCustomerID.TrailingIcon = null;
            // 
            // panel3
            // 
            panel3.Controls.Add(mbtnSearch);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(742, 3);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 94);
            panel3.TabIndex = 5;
            // 
            // mbtnSearch
            // 
            mbtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mbtnSearch.AutoSize = false;
            mbtnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSearch.Depth = 0;
            mbtnSearch.HighEmphasis = true;
            mbtnSearch.Icon = null;
            mbtnSearch.Location = new Point(33, 32);
            mbtnSearch.Margin = new Padding(4, 6, 4, 6);
            mbtnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSearch.Name = "mbtnSearch";
            mbtnSearch.NoAccentTextColor = Color.Empty;
            mbtnSearch.Size = new Size(148, 36);
            mbtnSearch.TabIndex = 0;
            mbtnSearch.Text = "SEARCH";
            mbtnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSearch.UseAccentColor = false;
            mbtnSearch.UseVisualStyleBackColor = true;
            mbtnSearch.Click += mbtnSearch_Click;
            // 
            // InvoiceList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 677);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "InvoiceList";
            Padding = new Padding(0);
            Text = "InvoiceList";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox mtxtCustomerID;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton mbtnSearch;
        private Panel panel3;
        private DateTimePicker dateTimePickerInvoice;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}