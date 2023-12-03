namespace HotelManagement.GUI
{
    partial class Main2UI
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
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            btnStatistic = new MaterialSkin.Controls.MaterialButton();
            btnAccount = new MaterialSkin.Controls.MaterialButton();
            btnStaff = new MaterialSkin.Controls.MaterialButton();
            btnCustomer = new MaterialSkin.Controls.MaterialButton();
            btnService = new MaterialSkin.Controls.MaterialButton();
            btnRoom = new MaterialSkin.Controls.MaterialButton();
            btnInvoice = new MaterialSkin.Controls.MaterialButton();
            btnRentDetail = new MaterialSkin.Controls.MaterialButton();
            btnReservation = new MaterialSkin.Controls.MaterialButton();
            btnhome = new MaterialSkin.Controls.MaterialButton();
            panelB = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panelB, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(3, 88);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1597, 912);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnStatistic);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(btnStaff);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnService);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnInvoice);
            panel1.Controls.Add(btnRentDetail);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnhome);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(165, 912);
            panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = false;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = Properties.Resources.icons8_graph_48;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 854);
            btnLogout.Margin = new Padding(0, 3, 0, 3);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(159, 55);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "LOGOUT";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnLogout.UseAccentColor = true;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStatistic.AutoSize = false;
            btnStatistic.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStatistic.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStatistic.Depth = 0;
            btnStatistic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStatistic.HighEmphasis = true;
            btnStatistic.Icon = Properties.Resources.icons8_graph_48;
            btnStatistic.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistic.Location = new Point(6, 554);
            btnStatistic.Margin = new Padding(0, 3, 0, 3);
            btnStatistic.MouseState = MaterialSkin.MouseState.HOVER;
            btnStatistic.Name = "btnStatistic";
            btnStatistic.NoAccentTextColor = Color.Empty;
            btnStatistic.Size = new Size(153, 55);
            btnStatistic.TabIndex = 10;
            btnStatistic.Text = "STATISTIC";
            btnStatistic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnStatistic.UseAccentColor = true;
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnAccount
            // 
            btnAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAccount.AutoSize = false;
            btnAccount.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAccount.Depth = 0;
            btnAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.HighEmphasis = true;
            btnAccount.Icon = Properties.Resources.icons8_change_user_48;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(6, 493);
            btnAccount.Margin = new Padding(0, 3, 0, 3);
            btnAccount.MouseState = MaterialSkin.MouseState.HOVER;
            btnAccount.Name = "btnAccount";
            btnAccount.NoAccentTextColor = Color.Empty;
            btnAccount.Size = new Size(153, 55);
            btnAccount.TabIndex = 9;
            btnAccount.Text = "ACCOUNT";
            btnAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnAccount.UseAccentColor = true;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnStaff
            // 
            btnStaff.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStaff.AutoSize = false;
            btnStaff.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStaff.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStaff.Depth = 0;
            btnStaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStaff.HighEmphasis = true;
            btnStaff.Icon = Properties.Resources.icons8_valet_48;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(6, 432);
            btnStaff.Margin = new Padding(0, 3, 0, 3);
            btnStaff.MouseState = MaterialSkin.MouseState.HOVER;
            btnStaff.Name = "btnStaff";
            btnStaff.NoAccentTextColor = Color.Empty;
            btnStaff.Size = new Size(153, 55);
            btnStaff.TabIndex = 8;
            btnStaff.Text = "STAFF";
            btnStaff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnStaff.UseAccentColor = true;
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCustomer.AutoSize = false;
            btnCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCustomer.Depth = 0;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.HighEmphasis = true;
            btnCustomer.Icon = Properties.Resources.icons8_customer_48;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(6, 371);
            btnCustomer.Margin = new Padding(0, 3, 0, 3);
            btnCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btnCustomer.Name = "btnCustomer";
            btnCustomer.NoAccentTextColor = Color.Empty;
            btnCustomer.Size = new Size(153, 55);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "CUSTOMER";
            btnCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnCustomer.UseAccentColor = true;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnService
            // 
            btnService.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnService.AutoSize = false;
            btnService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnService.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnService.Depth = 0;
            btnService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnService.HighEmphasis = true;
            btnService.Icon = Properties.Resources.icons8_janitor_48;
            btnService.ImageAlign = ContentAlignment.MiddleLeft;
            btnService.Location = new Point(6, 310);
            btnService.Margin = new Padding(0, 3, 0, 3);
            btnService.MouseState = MaterialSkin.MouseState.HOVER;
            btnService.Name = "btnService";
            btnService.NoAccentTextColor = Color.Empty;
            btnService.Size = new Size(153, 55);
            btnService.TabIndex = 6;
            btnService.Text = "SERVICE";
            btnService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnService.UseAccentColor = true;
            btnService.UseVisualStyleBackColor = true;
            btnService.Click += btnService_Click;
            // 
            // btnRoom
            // 
            btnRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRoom.AutoSize = false;
            btnRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRoom.Depth = 0;
            btnRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoom.HighEmphasis = true;
            btnRoom.Icon = Properties.Resources.icons8_bedroom_48;
            btnRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoom.Location = new Point(6, 249);
            btnRoom.Margin = new Padding(0, 3, 0, 3);
            btnRoom.MouseState = MaterialSkin.MouseState.HOVER;
            btnRoom.Name = "btnRoom";
            btnRoom.NoAccentTextColor = Color.Empty;
            btnRoom.Size = new Size(153, 55);
            btnRoom.TabIndex = 5;
            btnRoom.Text = "ROOM";
            btnRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnRoom.UseAccentColor = true;
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnInvoice.AutoSize = false;
            btnInvoice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInvoice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInvoice.Depth = 0;
            btnInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoice.HighEmphasis = true;
            btnInvoice.Icon = Properties.Resources.icons8_receipt_48;
            btnInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            btnInvoice.Location = new Point(6, 188);
            btnInvoice.Margin = new Padding(0, 3, 0, 3);
            btnInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            btnInvoice.Name = "btnInvoice";
            btnInvoice.NoAccentTextColor = Color.Empty;
            btnInvoice.Size = new Size(153, 55);
            btnInvoice.TabIndex = 4;
            btnInvoice.Text = "INVOICE";
            btnInvoice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnInvoice.UseAccentColor = true;
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnRentDetail
            // 
            btnRentDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRentDetail.AutoSize = false;
            btnRentDetail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRentDetail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRentDetail.Depth = 0;
            btnRentDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRentDetail.HighEmphasis = true;
            btnRentDetail.Icon = Properties.Resources.icons8_door_hanger_48;
            btnRentDetail.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentDetail.Location = new Point(6, 127);
            btnRentDetail.Margin = new Padding(0, 3, 0, 3);
            btnRentDetail.MouseState = MaterialSkin.MouseState.HOVER;
            btnRentDetail.Name = "btnRentDetail";
            btnRentDetail.NoAccentTextColor = Color.Empty;
            btnRentDetail.Size = new Size(153, 55);
            btnRentDetail.TabIndex = 3;
            btnRentDetail.Text = "RENT DETAIL";
            btnRentDetail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnRentDetail.UseAccentColor = true;
            btnRentDetail.UseVisualStyleBackColor = true;
            btnRentDetail.Click += btnRentDetail_Click;
            // 
            // btnReservation
            // 
            btnReservation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReservation.AutoSize = false;
            btnReservation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReservation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReservation.Depth = 0;
            btnReservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservation.HighEmphasis = true;
            btnReservation.Icon = Properties.Resources.icons8_hotel_48;
            btnReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservation.Location = new Point(6, 66);
            btnReservation.Margin = new Padding(0, 3, 0, 3);
            btnReservation.MouseState = MaterialSkin.MouseState.HOVER;
            btnReservation.Name = "btnReservation";
            btnReservation.NoAccentTextColor = Color.Empty;
            btnReservation.Size = new Size(153, 55);
            btnReservation.TabIndex = 2;
            btnReservation.Text = "RESERVATION";
            btnReservation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnReservation.UseAccentColor = true;
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnhome
            // 
            btnhome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnhome.AutoSize = false;
            btnhome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnhome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnhome.Depth = 0;
            btnhome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnhome.HighEmphasis = true;
            btnhome.Icon = Properties.Resources.icons8_marriott_hotels_48;
            btnhome.ImageAlign = ContentAlignment.MiddleLeft;
            btnhome.Location = new Point(6, 5);
            btnhome.Margin = new Padding(0, 3, 0, 3);
            btnhome.MouseState = MaterialSkin.MouseState.HOVER;
            btnhome.Name = "btnhome";
            btnhome.NoAccentTextColor = Color.Empty;
            btnhome.Size = new Size(153, 55);
            btnhome.TabIndex = 1;
            btnhome.Text = "HOME";
            btnhome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnhome.UseAccentColor = true;
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // panelB
            // 
            panelB.BackColor = Color.White;
            panelB.Dock = DockStyle.Fill;
            panelB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelB.Location = new Point(165, 0);
            panelB.Margin = new Padding(0);
            panelB.Name = "panelB";
            panelB.Size = new Size(1432, 912);
            panelB.TabIndex = 0;
            // 
            // Main2UI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 64, 122);
            ClientSize = new Size(1600, 1000);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormStyle = FormStyles.ActionBar_64;
            Margin = new Padding(4);
            Name = "Main2UI";
            Padding = new Padding(3, 88, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main2UI";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panelB;
        private MaterialSkin.Controls.MaterialButton btnhome;
        private MaterialSkin.Controls.MaterialButton btnStatistic;
        private MaterialSkin.Controls.MaterialButton btnAccount;
        private MaterialSkin.Controls.MaterialButton btnStaff;
        private MaterialSkin.Controls.MaterialButton btnCustomer;
        private MaterialSkin.Controls.MaterialButton btnService;
        private MaterialSkin.Controls.MaterialButton btnRoom;
        private MaterialSkin.Controls.MaterialButton btnInvoice;
        private MaterialSkin.Controls.MaterialButton btnRentDetail;
        private MaterialSkin.Controls.MaterialButton btnReservation;
        private MaterialSkin.Controls.MaterialButton btnLogout;
    }
}