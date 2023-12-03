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
            panel2 = new Panel();
            labelReservationID = new Label();
            labelTagReservationID = new Label();
            panel1 = new Panel();
            labelRoomStatus = new MaterialSkin.Controls.MaterialLabel();
            labelRoomClean = new MaterialSkin.Controls.MaterialLabel();
            panelRoomCard = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelRoomCard.SuspendLayout();
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
            labelRoomID.Location = new Point(14, 14);
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
            labelRoomType.Location = new Point(198, 14);
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
            labelFromTime.Location = new Point(18, 37);
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
            labelToTime.Location = new Point(198, 37);
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
            // panel2
            // 
            panel2.Controls.Add(labelReservationID);
            panel2.Controls.Add(labelTagReservationID);
            panel2.Controls.Add(labelMain);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(14, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 93);
            panel2.TabIndex = 37;
            panel2.DoubleClick += card_DoubleClick;
            // 
            // labelReservationID
            // 
            labelReservationID.AutoSize = true;
            labelReservationID.Location = new Point(223, 65);
            labelReservationID.Name = "labelReservationID";
            labelReservationID.Size = new Size(29, 28);
            labelReservationID.TabIndex = 34;
            labelReservationID.Text = "id";
            labelReservationID.DoubleClick += card_DoubleClick;
            // 
            // labelTagReservationID
            // 
            labelTagReservationID.AutoSize = true;
            labelTagReservationID.Location = new Point(81, 65);
            labelTagReservationID.Name = "labelTagReservationID";
            labelTagReservationID.Size = new Size(136, 28);
            labelTagReservationID.TabIndex = 34;
            labelTagReservationID.Text = "ReservationID:";
            labelTagReservationID.DoubleClick += card_DoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(labelRoomStatus);
            panel1.Controls.Add(labelRoomClean);
            panel1.Controls.Add(labelFromTime);
            panel1.Controls.Add(labelToTime);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 154);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 63);
            panel1.TabIndex = 36;
            panel1.DoubleClick += card_DoubleClick;
            // 
            // labelRoomStatus
            // 
            labelRoomStatus.AutoSize = true;
            labelRoomStatus.BackColor = SystemColors.Control;
            labelRoomStatus.Depth = 0;
            labelRoomStatus.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelRoomStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            labelRoomStatus.Location = new Point(14, 9);
            labelRoomStatus.MouseState = MaterialSkin.MouseState.HOVER;
            labelRoomStatus.Name = "labelRoomStatus";
            labelRoomStatus.Size = new Size(103, 19);
            labelRoomStatus.TabIndex = 35;
            labelRoomStatus.Text = "{Room Status}";
            labelRoomStatus.DoubleClick += card_DoubleClick;
            // 
            // labelRoomClean
            // 
            labelRoomClean.AutoSize = true;
            labelRoomClean.Depth = 0;
            labelRoomClean.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelRoomClean.ForeColor = Color.FromArgb(222, 0, 0, 0);
            labelRoomClean.Location = new Point(198, 9);
            labelRoomClean.MouseState = MaterialSkin.MouseState.HOVER;
            labelRoomClean.Name = "labelRoomClean";
            labelRoomClean.Size = new Size(147, 19);
            labelRoomClean.TabIndex = 34;
            labelRoomClean.Text = "{Room Status Clean}";
            labelRoomClean.DoubleClick += card_DoubleClick;
            // 
            // panelRoomCard
            // 
            panelRoomCard.BackColor = SystemColors.Control;
            panelRoomCard.Controls.Add(panel1);
            panelRoomCard.Controls.Add(labelRoomType);
            panelRoomCard.Controls.Add(labelRoomID);
            panelRoomCard.Controls.Add(panel2);
            panelRoomCard.Dock = DockStyle.Fill;
            panelRoomCard.Location = new Point(0, 0);
            panelRoomCard.Name = "panelRoomCard";
            panelRoomCard.Size = new Size(362, 217);
            panelRoomCard.TabIndex = 38;
            panelRoomCard.DoubleClick += card_DoubleClick;
            // 
            // RoomCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panelRoomCard);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(74, 20, 140);
            Margin = new Padding(10);
            Name = "RoomCard";
            Size = new Size(362, 217);
            DoubleClick += card_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelRoomCard.ResumeLayout(false);
            panelRoomCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel labelRoomID;
        private MaterialSkin.Controls.MaterialLabel labelRoomType;
        private MaterialSkin.Controls.MaterialLabel labelFromTime;
        private MaterialSkin.Controls.MaterialLabel labelToTime;
        private MaterialSkin.Controls.MaterialLabel labelMain;
        private MaterialSkin.Controls.MaterialLabel labelRoomClean;
        private MaterialSkin.Controls.MaterialLabel labelRoomStatus;
        private Panel panel1;
        private Panel panel2;
        private Label labelTagReservationID;
        private Label labelReservationID;
        private Panel panelRoomCard;
    }
}
