namespace HotelManagement.GUI
{
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    partial class StaffManagerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManagerUI));
            lbStaffs = new MaterialSkin.Controls.MaterialListBox();
            pnStaffInfo = new Panel();
            ucGranting = new GrantingPermissionsUI();
            ucStaffInfo = new StaffInfoUI();
            lbStaffInfoTitle = new Label();
            tsAppBar = new ToolStrip();
            btnBack = new ToolStripButton();
            txtTitle = new ToolStripLabel();
            tbSearchBox = new ToolStripTextBox();
            btnMore = new ToolStripDropDownButton();
            dbtnSave = new ToolStripMenuItem();
            dbtnSearch = new ToolStripMenuItem();
            dbtnAdd = new ToolStripMenuItem();
            dbtnEdit = new ToolStripMenuItem();
            dbtnDelete = new ToolStripMenuItem();
            dbtnImex = new ToolStripMenuItem();
            btnSearch = new ToolStripButton();
            pnAppBar = new Panel();
            pnStaffInfo.SuspendLayout();
            tsAppBar.SuspendLayout();
            pnAppBar.SuspendLayout();
            SuspendLayout();
            // 
            // lbStaffs
            // 
            lbStaffs.BackColor = Color.WhiteSmoke;
            lbStaffs.BorderColor = Color.LightGray;
            lbStaffs.Depth = 0;
            lbStaffs.Dock = DockStyle.Left;
            lbStaffs.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbStaffs.Location = new Point(0, 56);
            lbStaffs.MouseState = MaterialSkin.MouseState.HOVER;
            lbStaffs.Name = "lbStaffs";
            lbStaffs.SelectedIndex = -1;
            lbStaffs.SelectedItem = null;
            lbStaffs.Size = new Size(240, 544);
            lbStaffs.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            lbStaffs.TabIndex = 0;
            lbStaffs.SelectedIndexChanged += OnSelectedStaffIndex;
            // 
            // pnStaffInfo
            // 
            pnStaffInfo.AutoScroll = true;
            pnStaffInfo.BackColor = Color.FromArgb(255, 255, 255);
            pnStaffInfo.Controls.Add(ucGranting);
            pnStaffInfo.Controls.Add(ucStaffInfo);
            pnStaffInfo.Controls.Add(lbStaffInfoTitle);
            pnStaffInfo.Dock = DockStyle.Right;
            pnStaffInfo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnStaffInfo.Location = new Point(240, 56);
            pnStaffInfo.Margin = new Padding(0);
            pnStaffInfo.Name = "pnStaffInfo";
            pnStaffInfo.Size = new Size(360, 544);
            pnStaffInfo.TabIndex = 1;
            // 
            // ucGranting
            // 
            ucGranting.BackColor = Color.White;
            ucGranting.Dock = DockStyle.Top;
            ucGranting.Editing = false;
            ucGranting.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucGranting.ForeColor = Color.Black;
            ucGranting.Location = new Point(0, 744);
            ucGranting.Margin = new Padding(4, 4, 4, 4);
            ucGranting.MinimumSize = new Size(360, 0);
            ucGranting.Name = "ucGranting";
            ucGranting.Size = new Size(360, 1280);
            ucGranting.TabIndex = 1;
            // 
            // ucStaffInfo
            // 
            ucStaffInfo.BackColor = Color.White;
            ucStaffInfo.Dock = DockStyle.Top;
            ucStaffInfo.Editing = false;
            ucStaffInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucStaffInfo.ForeColor = Color.Black;
            ucStaffInfo.Location = new Point(0, 84);
            ucStaffInfo.MinimumSize = new Size(360, 660);
            ucStaffInfo.Name = "ucStaffInfo";
            ucStaffInfo.Size = new Size(360, 660);
            ucStaffInfo.TabIndex = 0;
            // 
            // lbStaffInfoTitle
            // 
            lbStaffInfoTitle.Dock = DockStyle.Top;
            lbStaffInfoTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbStaffInfoTitle.Location = new Point(0, 0);
            lbStaffInfoTitle.Name = "lbStaffInfoTitle";
            lbStaffInfoTitle.Size = new Size(326, 84);
            lbStaffInfoTitle.TabIndex = 2;
            lbStaffInfoTitle.Text = "Thông tin nhân viên";
            lbStaffInfoTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tsAppBar
            // 
            tsAppBar.BackColor = Color.White;
            tsAppBar.Dock = DockStyle.Fill;
            tsAppBar.GripStyle = ToolStripGripStyle.Hidden;
            tsAppBar.ImageScalingSize = new Size(24, 24);
            tsAppBar.Items.AddRange(new ToolStripItem[] { btnBack, txtTitle, tbSearchBox, btnMore, btnSearch });
            tsAppBar.Location = new Point(0, 0);
            tsAppBar.Name = "tsAppBar";
            tsAppBar.Padding = new Padding(0);
            tsAppBar.Size = new Size(600, 56);
            tsAppBar.TabIndex = 2;
            tsAppBar.Text = "Nhân viên";
            // 
            // btnBack
            // 
            btnBack.AutoSize = false;
            btnBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageTransparentColor = Color.Magenta;
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(56, 56);
            btnBack.Text = "Trở về";
            btnBack.Click += OnBack;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = false;
            txtTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitle.Margin = new Padding(16, 0, 0, 0);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(232, 50);
            txtTitle.Text = "Nhân viên";
            txtTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbSearchBox
            // 
            tbSearchBox.AutoSize = false;
            tbSearchBox.BorderStyle = BorderStyle.FixedSingle;
            tbSearchBox.Margin = new Padding(0);
            tbSearchBox.Name = "tbSearchBox";
            tbSearchBox.Size = new Size(248, 39);
            tbSearchBox.TextChanged += OnLookingUp;
            // 
            // btnMore
            // 
            btnMore.Alignment = ToolStripItemAlignment.Right;
            btnMore.AutoSize = false;
            btnMore.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMore.DropDownItems.AddRange(new ToolStripItem[] { dbtnSave, dbtnSearch, dbtnAdd, dbtnEdit, dbtnDelete, dbtnImex });
            btnMore.Image = (Image)resources.GetObject("btnMore.Image");
            btnMore.ImageTransparentColor = Color.Magenta;
            btnMore.Margin = new Padding(0);
            btnMore.Name = "btnMore";
            btnMore.ShowDropDownArrow = false;
            btnMore.Size = new Size(56, 56);
            btnMore.Text = "Tùy chọn khác";
            // 
            // dbtnSave
            // 
            dbtnSave.Image = (Image)resources.GetObject("dbtnSave.Image");
            dbtnSave.Name = "dbtnSave";
            dbtnSave.Size = new Size(262, 44);
            dbtnSave.Text = "Lưu";
            dbtnSave.Click += OnSave;
            // 
            // dbtnSearch
            // 
            dbtnSearch.Image = (Image)resources.GetObject("dbtnSearch.Image");
            dbtnSearch.Name = "dbtnSearch";
            dbtnSearch.Size = new Size(262, 44);
            dbtnSearch.Text = "Tìm kiếm";
            dbtnSearch.Click += OnStartSearch;
            // 
            // dbtnAdd
            // 
            dbtnAdd.Image = (Image)resources.GetObject("dbtnAdd.Image");
            dbtnAdd.Name = "dbtnAdd";
            dbtnAdd.Size = new Size(262, 44);
            dbtnAdd.Text = "Thêm";
            dbtnAdd.Click += OnAdding;
            // 
            // dbtnEdit
            // 
            dbtnEdit.Image = (Image)resources.GetObject("dbtnEdit.Image");
            dbtnEdit.Name = "dbtnEdit";
            dbtnEdit.Size = new Size(262, 44);
            dbtnEdit.Text = "Sửa";
            dbtnEdit.Click += OnEditing;
            // 
            // dbtnDelete
            // 
            dbtnDelete.Image = (Image)resources.GetObject("dbtnDelete.Image");
            dbtnDelete.Name = "dbtnDelete";
            dbtnDelete.Size = new Size(262, 44);
            dbtnDelete.Text = "Xóa";
            dbtnDelete.Click += OnDeleting;
            // 
            // dbtnImex
            // 
            dbtnImex.Image = (Image)resources.GetObject("dbtnImex.Image");
            dbtnImex.Name = "dbtnImex";
            dbtnImex.Size = new Size(262, 44);
            dbtnImex.Text = "Nhập/Xuất";
            dbtnImex.Click += OnStartImex;
            // 
            // btnSearch
            // 
            btnSearch.Alignment = ToolStripItemAlignment.Right;
            btnSearch.AutoSize = false;
            btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(56, 56);
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += OnStartSearch;
            // 
            // pnAppBar
            // 
            pnAppBar.Controls.Add(tsAppBar);
            pnAppBar.Dock = DockStyle.Top;
            pnAppBar.Location = new Point(0, 0);
            pnAppBar.Name = "pnAppBar";
            pnAppBar.Size = new Size(600, 56);
            pnAppBar.TabIndex = 2;
            // 
            // StaffManagerUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(600, 600);
            Controls.Add(pnStaffInfo);
            Controls.Add(lbStaffs);
            Controls.Add(pnAppBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Name = "StaffManagerUI";
            Text = "Nhân viên";
            pnStaffInfo.ResumeLayout(false);
            tsAppBar.ResumeLayout(false);
            tsAppBar.PerformLayout();
            pnAppBar.ResumeLayout(false);
            pnAppBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox lbStaffs;
        private StaffInfoUI ucStaffInfo;
        private GrantingPermissionsUI ucGranting;
        private Label lbStaffInfoTitle;
        private Panel pnStaffInfo;
        private ToolStrip tsAppBar;
        private ToolStripButton btnBack;
        private Panel pnAppBar;
        private ToolStripLabel txtTitle;
        private ToolStripTextBox tbSearchBox;
        private ToolStripButton btnSearch;
        private ToolStripDropDownButton btnMore;
        private ToolStripMenuItem dbtnSave;
        private ToolStripMenuItem dbtnSearch;
        private ToolStripMenuItem dbtnAdd;
        private ToolStripMenuItem dbtnEdit;
        private ToolStripMenuItem dbtnDelete;
        private ToolStripMenuItem dbtnImex;
    }
}