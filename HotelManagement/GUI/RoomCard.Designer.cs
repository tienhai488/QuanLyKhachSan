namespace HotelManagement.GUI
{
    partial class RoomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomCard));
            pictureBox1 = new PictureBox();
            labelRoomID = new MaterialSkin.Controls.MaterialLabel();
            labelRoomType = new MaterialSkin.Controls.MaterialLabel();
            labelFromTime = new MaterialSkin.Controls.MaterialLabel();
            labelToTime = new MaterialSkin.Controls.MaterialLabel();
            labelMain = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            panel2 = new Panel();
            panel1 = new Panel();
            labelReservationStatus = new MaterialSkin.Controls.MaterialLabel();
            labelRoomStatusClean = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += card_DoubleClick;
            // 
            // labelRoomID
            // 
            labelRoomID.Anchor = AnchorStyles.None;
            labelRoomID.AutoSize = true;
            labelRoomID.Depth = 0;
            labelRoomID.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelRoomID.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelRoomID.ForeColor = Color.FromArgb(222, 0, 0, 0);
            labelRoomID.Location = new Point(18, 15);
            labelRoomID.MouseState = MaterialSkin.MouseState.HOVER;
            labelRoomID.Name = "labelRoomID";
            labelRoomID.Size = new Size(90, 24);
            labelRoomID.TabIndex = 30;
            labelRoomID.Text = "{Room ID}";
            labelRoomID.DoubleClick += card_DoubleClick;
            // 
            // labelRoomType
            // 
            labelRoomType.Anchor = AnchorStyles.None;
            labelRoomType.AutoSize = true;
            labelRoomType.Depth = 0;
            labelRoomType.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelRoomType.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelRoomType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            labelRoomType.Location = new Point(208, 15);
            labelRoomType.MouseState = MaterialSkin.MouseState.HOVER;
            labelRoomType.Name = "labelRoomType";
            labelRoomType.Size = new Size(115, 24);
            labelRoomType.TabIndex = 31;
            labelRoomType.Text = "{Room Type}";
            labelRoomType.DoubleClick += card_DoubleClick;
            // 
            // labelFromTime
            // 
            labelFromTime.AutoSize = true;
            labelFromTime.BackColor = Color.FromArgb(255, 128, 0);
            labelFromTime.Depth = 0;
            labelFromTime.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelFromTime.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            labelFromTime.Location = new Point(3, 37);
            labelFromTime.MouseState = MaterialSkin.MouseState.HOVER;
            labelFromTime.Name = "labelFromTime";
            labelFromTime.Size = new Size(38, 17);
            labelFromTime.TabIndex = 31;
            labelFromTime.Text = "From:";
            labelFromTime.DoubleClick += card_DoubleClick;
            // 
            // labelToTime
            // 
            labelToTime.AutoSize = true;
            labelToTime.Depth = 0;
            labelToTime.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelToTime.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            labelToTime.Location = new Point(199, 37);
            labelToTime.MouseState = MaterialSkin.MouseState.HOVER;
            labelToTime.Name = "labelToTime";
            labelToTime.Size = new Size(22, 17);
            labelToTime.TabIndex = 32;
            labelToTime.Text = "To:";
            labelToTime.DoubleClick += card_DoubleClick;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Depth = 0;
            labelMain.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelMain.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            labelMain.Location = new Point(81, 18);
            labelMain.MouseState = MaterialSkin.MouseState.HOVER;
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(176, 29);
            labelMain.TabIndex = 33;
            labelMain.Text = "Customer Name";
            labelMain.TextAlign = ContentAlignment.MiddleCenter;
            labelMain.DoubleClick += card_DoubleClick;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(panel2);
            materialCard1.Controls.Add(panel1);
            materialCard1.Controls.Add(labelRoomID);
            materialCard1.Controls.Add(labelRoomType);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(0);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(15);
            materialCard1.Size = new Size(399, 219);
            materialCard1.TabIndex = 34;
            materialCard1.DoubleClick += card_DoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelMain);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(15, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 93);
            panel2.TabIndex = 37;
            panel2.DoubleClick += card_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(labelReservationStatus);
            panel1.Controls.Add(labelRoomStatusClean);
            panel1.Controls.Add(labelFromTime);
            panel1.Controls.Add(labelToTime);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(15, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 63);
            panel1.TabIndex = 36;
            panel1.DoubleClick += card_DoubleClick;
            // 
            // labelReservationStatus
            // 
            labelReservationStatus.AutoSize = true;
            labelReservationStatus.Depth = 0;
            labelReservationStatus.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelReservationStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            labelReservationStatus.Location = new Point(3, 9);
            labelReservationStatus.MouseState = MaterialSkin.MouseState.HOVER;
            labelReservationStatus.Name = "labelReservationStatus";
            labelReservationStatus.Size = new Size(190, 19);
            labelReservationStatus.TabIndex = 35;
            labelReservationStatus.Text = "{Room Status Reservation}";
            labelReservationStatus.DoubleClick += card_DoubleClick;
            // 
            // labelRoomStatusClean
            // 
            labelRoomStatusClean.AutoSize = true;
            labelRoomStatusClean.Depth = 0;
            labelRoomStatusClean.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelRoomStatusClean.ForeColor = Color.FromArgb(222, 0, 0, 0);
            labelRoomStatusClean.Location = new Point(199, 9);
            labelRoomStatusClean.MouseState = MaterialSkin.MouseState.HOVER;
            labelRoomStatusClean.Name = "labelRoomStatusClean";
            labelRoomStatusClean.Size = new Size(147, 19);
            labelRoomStatusClean.TabIndex = 34;
            labelRoomStatusClean.Text = "{Room Status Clean}";
            labelRoomStatusClean.DoubleClick += card_DoubleClick;
            // 
            // RoomCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(materialCard1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(74, 20, 140);
            Margin = new Padding(10);
            Name = "RoomCard";
            Size = new Size(399, 219);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel labelRoomID;
        private MaterialSkin.Controls.MaterialLabel labelRoomType;
        private MaterialSkin.Controls.MaterialLabel labelFromTime;
        private MaterialSkin.Controls.MaterialLabel labelToTime;
        private MaterialSkin.Controls.MaterialLabel labelMain;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel labelRoomStatusClean;
        private MaterialSkin.Controls.MaterialLabel labelReservationStatus;
        private Panel panel1;
        private Panel panel2;
    }
}
