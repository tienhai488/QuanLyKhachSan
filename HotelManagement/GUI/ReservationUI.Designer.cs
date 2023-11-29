namespace HotelManagement.GUI
{
    partial class ReservationUI
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
            cbxFilter = new ComboBox();
            panel2 = new Panel();
            btnFilter = new MaterialSkin.Controls.MaterialButton();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAddBook = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1028, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(157, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(713, 544);
            dataGridView1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel3, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(154, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(3);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(719, 80);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxFilter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 74);
            panel1.TabIndex = 3;
            // 
            // cbxFilter
            // 
            cbxFilter.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilter.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilter.FlatStyle = FlatStyle.Popup;
            cbxFilter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilter.FormattingEnabled = true;
            cbxFilter.Location = new Point(0, 19);
            cbxFilter.Margin = new Padding(5, 3, 5, 3);
            cbxFilter.Name = "cbxFilter";
            cbxFilter.Size = new Size(356, 49);
            cbxFilter.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFilter);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(359, 3);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(213, 74);
            panel2.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFilter.Depth = 0;
            btnFilter.HighEmphasis = true;
            btnFilter.Icon = null;
            btnFilter.Location = new Point(4, 19);
            btnFilter.Margin = new Padding(4, 6, 4, 6);
            btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            btnFilter.Name = "btnFilter";
            btnFilter.NoAccentTextColor = Color.Empty;
            btnFilter.Size = new Size(78, 36);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "SEARCH";
            btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFilter.UseAccentColor = false;
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(572, 3);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 74);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(876, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(149, 223);
            panel4.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnAddBook, 0, 0);
            tableLayoutPanel3.Controls.Add(btnDelete, 0, 2);
            tableLayoutPanel3.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(149, 223);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddBook.Depth = 0;
            btnAddBook.HighEmphasis = true;
            btnAddBook.Icon = null;
            btnAddBook.Location = new Point(4, 6);
            btnAddBook.Margin = new Padding(4, 6, 4, 6);
            btnAddBook.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddBook.Name = "btnAddBook";
            btnAddBook.NoAccentTextColor = Color.Empty;
            btnAddBook.Size = new Size(141, 36);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "BOOK A ROOM";
            btnAddBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddBook.UseAccentColor = false;
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(4, 154);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(141, 36);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(4, 80);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(141, 36);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ReservationUI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 630);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Margin = new Padding(4);
            Name = "ReservationUI";
            Padding = new Padding(0);
            Text = "RentDetailUI";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialButton btnAddBook;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private ComboBox cbxFilter;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnDelete;
    }
}