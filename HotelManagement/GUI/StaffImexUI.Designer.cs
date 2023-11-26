namespace HotelManagement.GUI
{
    partial class StaffImexUI
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
            gvdata = new DataGridView();
            btnExport = new Button();
            btnImport = new Button();
            btnTemplate = new Button();
            panel1 = new Panel();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)gvdata).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gvdata
            // 
            gvdata.AllowUserToAddRows = false;
            gvdata.AllowUserToDeleteRows = false;
            gvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvdata.Dock = DockStyle.Fill;
            gvdata.EditMode = DataGridViewEditMode.EditProgrammatically;
            gvdata.Location = new Point(0, 40);
            gvdata.Name = "gvdata";
            gvdata.ReadOnly = true;
            gvdata.RowHeadersVisible = false;
            gvdata.RowHeadersWidth = 82;
            gvdata.RowTemplate.Height = 41;
            gvdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvdata.Size = new Size(600, 310);
            gvdata.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.Dock = DockStyle.Right;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Location = new Point(360, 0);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(120, 40);
            btnExport.TabIndex = 1;
            btnExport.Text = "Xuất...";
            btnExport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += OnExport;
            // 
            // btnImport
            // 
            btnImport.Dock = DockStyle.Right;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Location = new Point(240, 0);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(120, 40);
            btnImport.TabIndex = 1;
            btnImport.Text = "Nhập...";
            btnImport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += OnImport;
            // 
            // btnTemplate
            // 
            btnTemplate.Dock = DockStyle.Right;
            btnTemplate.FlatStyle = FlatStyle.Flat;
            btnTemplate.Location = new Point(120, 0);
            btnTemplate.Name = "btnTemplate";
            btnTemplate.Size = new Size(120, 40);
            btnTemplate.TabIndex = 1;
            btnTemplate.Text = "Xuất mẫu...";
            btnTemplate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTemplate.UseVisualStyleBackColor = true;
            btnTemplate.Click += OnExportTemplate;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTemplate);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 40);
            panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(480, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += OnSave;
            // 
            // StaffImexUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(600, 350);
            Controls.Add(gvdata);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MinimumSize = new Size(626, 421);
            Name = "StaffImexUI";
            Text = "Xem trước danh sách";
            ((System.ComponentModel.ISupportInitialize)gvdata).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvdata;
        private Button btnExport;
        private Button btnImport;
        private Button btnTemplate;
        private Panel panel1;
        private Button btnSave;
    }
}