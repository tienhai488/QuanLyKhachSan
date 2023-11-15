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
            rentTime = new Label();
            panel2 = new Panel();
            roomClean = new Label();
            pictureBox1 = new PictureBox();
            customerName = new Label();
            roomStatus = new Label();
            roomID = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rentTime
            // 
            rentTime.AutoSize = true;
            rentTime.BackColor = Color.Transparent;
            rentTime.Dock = DockStyle.Left;
            rentTime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rentTime.ForeColor = Color.FromArgb(74, 20, 140);
            rentTime.Location = new Point(10, 0);
            rentTime.Margin = new Padding(4, 0, 4, 0);
            rentTime.Name = "rentTime";
            rentTime.Size = new Size(70, 19);
            rentTime.TabIndex = 25;
            rentTime.Text = "Rent Time";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(rentTime);
            panel2.Controls.Add(roomClean);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 122);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 0);
            panel2.Size = new Size(289, 25);
            panel2.TabIndex = 29;
            // 
            // roomClean
            // 
            roomClean.AutoSize = true;
            roomClean.BackColor = Color.Transparent;
            roomClean.Dock = DockStyle.Right;
            roomClean.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            roomClean.ForeColor = Color.FromArgb(74, 20, 140);
            roomClean.Location = new Point(198, 0);
            roomClean.Margin = new Padding(4, 0, 4, 0);
            roomClean.Name = "roomClean";
            roomClean.Size = new Size(81, 19);
            roomClean.TabIndex = 24;
            roomClean.Text = "Incharge by";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.BackColor = Color.Transparent;
            customerName.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.Location = new Point(69, 55);
            customerName.Name = "customerName";
            customerName.Size = new Size(121, 30);
            customerName.TabIndex = 28;
            customerName.Text = "Cus Name";
            // 
            // roomStatus
            // 
            roomStatus.AutoSize = true;
            roomStatus.BackColor = Color.Transparent;
            roomStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomStatus.ForeColor = Color.FromArgb(173, 20, 87);
            roomStatus.Location = new Point(184, 15);
            roomStatus.Margin = new Padding(4, 0, 4, 0);
            roomStatus.Name = "roomStatus";
            roomStatus.Size = new Size(98, 21);
            roomStatus.TabIndex = 31;
            roomStatus.Text = "Room Status";
            // 
            // roomID
            // 
            roomID.AutoSize = true;
            roomID.BackColor = Color.Transparent;
            roomID.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomID.ForeColor = Color.FromArgb(173, 20, 87);
            roomID.Location = new Point(13, 15);
            roomID.Margin = new Padding(4, 0, 4, 0);
            roomID.Name = "roomID";
            roomID.Size = new Size(74, 21);
            roomID.TabIndex = 30;
            roomID.Text = "RoomID";
            // 
            // RoomCard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 130);
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(roomID);
            Controls.Add(pictureBox1);
            Controls.Add(customerName);
            Controls.Add(roomStatus);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(74, 20, 140);
            Margin = new Padding(4);
            Name = "RoomCard";
            Padding = new Padding(3, 0, 3, 3);
            Size = new Size(295, 150);
            Click += RoomCard_Click;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label rentTime;
        private Panel panel2;
        private Label roomClean;
        private PictureBox pictureBox1;
        private Label customerName;
        private Label roomStatus;
        private Label roomID;
    }
}
