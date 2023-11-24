using HotelManagement.DTO;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Linq;

namespace HotelManagement.GUI
{
    partial class UpdateService
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
            mbtnCheckOut = new MaterialSkin.Controls.MaterialButton();
            dataGridViewSelected = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewService = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mcmbServiceType = new MaterialSkin.Controls.MaterialComboBox();
            mbtnChangeQuantity = new MaterialSkin.Controls.MaterialButton();
            mbtnDelete = new MaterialSkin.Controls.MaterialButton();
            mbtnSelectService = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewService).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 662);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(mbtnCheckOut, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridViewSelected, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridViewService, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 87);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1344, 575);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // mbtnCheckOut
            // 
            mbtnCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mbtnCheckOut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnCheckOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnCheckOut.Depth = 0;
            mbtnCheckOut.HighEmphasis = true;
            mbtnCheckOut.Icon = null;
            mbtnCheckOut.Location = new Point(1212, 0);
            mbtnCheckOut.Margin = new Padding(4, 0, 4, 6);
            mbtnCheckOut.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnCheckOut.Name = "mbtnCheckOut";
            mbtnCheckOut.NoAccentTextColor = Color.Empty;
            mbtnCheckOut.Size = new Size(128, 36);
            mbtnCheckOut.TabIndex = 14;
            mbtnCheckOut.Text = "CHECK OUT TO INVOICE";
            mbtnCheckOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnCheckOut.UseAccentColor = false;
            mbtnCheckOut.UseVisualStyleBackColor = true;
            mbtnCheckOut.Click += mbtnCheckOut_Click;
            // 
            // dataGridViewSelected
            // 
            dataGridViewSelected.AllowUserToAddRows = false;
            dataGridViewSelected.AllowUserToDeleteRows = false;
            dataGridViewSelected.AllowUserToResizeColumns = false;
            dataGridViewSelected.AllowUserToResizeRows = false;
            dataGridViewSelected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSelected.BackgroundColor = Color.White;
            dataGridViewSelected.BorderStyle = BorderStyle.None;
            dataGridViewSelected.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSelected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSelected.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewSelected.Location = new Point(604, 0);
            dataGridViewSelected.Margin = new Padding(0, 0, 29, 29);
            dataGridViewSelected.Name = "dataGridViewSelected";
            dataGridViewSelected.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSelected.RowHeadersVisible = false;
            dataGridViewSelected.RowTemplate.Height = 25;
            dataGridViewSelected.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSelected.Size = new Size(575, 546);
            dataGridViewSelected.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Service ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Service Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewService
            // 
            dataGridViewService.AllowUserToAddRows = false;
            dataGridViewService.AllowUserToDeleteRows = false;
            dataGridViewService.AllowUserToResizeColumns = false;
            dataGridViewService.AllowUserToResizeRows = false;
            dataGridViewService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewService.BackgroundColor = Color.White;
            dataGridViewService.BorderStyle = BorderStyle.None;
            dataGridViewService.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewService.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewService.Location = new Point(29, 0);
            dataGridViewService.Margin = new Padding(29, 0, 29, 29);
            dataGridViewService.Name = "dataGridViewService";
            dataGridViewService.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewService.RowHeadersVisible = false;
            dataGridViewService.RowTemplate.Height = 25;
            dataGridViewService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewService.Size = new Size(546, 546);
            dataGridViewService.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Service ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Service Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Quantity";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Price/1";
            Column4.Name = "Column4";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(mbtnChangeQuantity, 3, 0);
            tableLayoutPanel1.Controls.Add(mbtnDelete, 4, 0);
            tableLayoutPanel1.Controls.Add(mbtnSelectService, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1344, 87);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(mcmbServiceType);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 87);
            panel2.TabIndex = 10;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel1.Location = new Point(29, 1);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(148, 19);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Select a service type:";
            // 
            // mcmbServiceType
            // 
            mcmbServiceType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mcmbServiceType.AutoResize = false;
            mcmbServiceType.BackColor = Color.FromArgb(255, 255, 255);
            mcmbServiceType.Depth = 0;
            mcmbServiceType.DrawMode = DrawMode.OwnerDrawVariable;
            mcmbServiceType.DropDownHeight = 174;
            mcmbServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            mcmbServiceType.DropDownWidth = 121;
            mcmbServiceType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcmbServiceType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcmbServiceType.FormattingEnabled = true;
            mcmbServiceType.IntegralHeight = false;
            mcmbServiceType.ItemHeight = 43;
            mcmbServiceType.Location = new Point(29, 23);
            mcmbServiceType.MaxDropDownItems = 4;
            mcmbServiceType.MouseState = MaterialSkin.MouseState.OUT;
            mcmbServiceType.Name = "mcmbServiceType";
            mcmbServiceType.Size = new Size(345, 49);
            mcmbServiceType.StartIndex = 0;
            mcmbServiceType.TabIndex = 9;
            mcmbServiceType.SelectedIndexChanged += mcmbServiceType_SelectedIndexChanged;
            // 
            // mbtnChangeQuantity
            // 
            mbtnChangeQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mbtnChangeQuantity.AutoSize = false;
            mbtnChangeQuantity.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnChangeQuantity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnChangeQuantity.Depth = 0;
            mbtnChangeQuantity.HighEmphasis = true;
            mbtnChangeQuantity.Icon = null;
            mbtnChangeQuantity.Location = new Point(809, 23);
            mbtnChangeQuantity.Margin = new Padding(4, 23, 29, 6);
            mbtnChangeQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnChangeQuantity.Name = "mbtnChangeQuantity";
            mbtnChangeQuantity.NoAccentTextColor = Color.Empty;
            mbtnChangeQuantity.Size = new Size(168, 36);
            mbtnChangeQuantity.TabIndex = 13;
            mbtnChangeQuantity.Text = "CHANGE QUANTITY";
            mbtnChangeQuantity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnChangeQuantity.UseAccentColor = false;
            mbtnChangeQuantity.UseVisualStyleBackColor = true;
            mbtnChangeQuantity.Click += mbtnChangeQuantity_Click;
            // 
            // mbtnDelete
            // 
            mbtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mbtnDelete.AutoSize = false;
            mbtnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnDelete.Depth = 0;
            mbtnDelete.HighEmphasis = true;
            mbtnDelete.Icon = null;
            mbtnDelete.Location = new Point(1010, 23);
            mbtnDelete.Margin = new Padding(4, 23, 29, 6);
            mbtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnDelete.Name = "mbtnDelete";
            mbtnDelete.NoAccentTextColor = Color.Empty;
            mbtnDelete.Size = new Size(168, 36);
            mbtnDelete.TabIndex = 14;
            mbtnDelete.Text = "DELETE";
            mbtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            mbtnDelete.UseAccentColor = false;
            mbtnDelete.UseVisualStyleBackColor = true;
            mbtnDelete.Click += mbtnDelete_Click;
            // 
            // mbtnSelectService
            // 
            mbtnSelectService.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mbtnSelectService.AutoSize = false;
            mbtnSelectService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnSelectService.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSelectService.Depth = 0;
            mbtnSelectService.HighEmphasis = true;
            mbtnSelectService.Icon = null;
            mbtnSelectService.Location = new Point(407, 23);
            mbtnSelectService.Margin = new Padding(4, 23, 29, 6);
            mbtnSelectService.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSelectService.Name = "mbtnSelectService";
            mbtnSelectService.NoAccentTextColor = Color.Empty;
            mbtnSelectService.Size = new Size(168, 36);
            mbtnSelectService.TabIndex = 11;
            mbtnSelectService.Text = "SELECT SERVICE";
            mbtnSelectService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSelectService.UseAccentColor = false;
            mbtnSelectService.UseVisualStyleBackColor = true;
            mbtnSelectService.Click += mbtnSelectService_Click;
            // 
            // UpdateService
            // 
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UpdateService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UPDATE SERVICE";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewService).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        public List<Service> Services = new();
        int numberOfServices = 1;

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton mbtnCheckOut;
        private DataGridView dataGridViewSelected;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridViewService;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox mcmbServiceType;
        private MaterialSkin.Controls.MaterialButton mbtnChangeQuantity;
        private MaterialSkin.Controls.MaterialButton mbtnDelete;
        private MaterialSkin.Controls.MaterialButton mbtnSelectService;
    }
}
