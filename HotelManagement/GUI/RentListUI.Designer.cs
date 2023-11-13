namespace HotelManagement.GUI
{
    partial class RentListUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentListUI));
            rentTime = new Label();
            panel2 = new Panel();
            roomClean = new Label();
            panel3 = new Panel();
            roomID = new Label();
            roomStatus = new Label();
            customerName = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel2.Location = new Point(0, 125);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 0);
            panel2.Size = new Size(295, 25);
            panel2.TabIndex = 29;
            // 
            // roomClean
            // 
            roomClean.AutoSize = true;
            roomClean.BackColor = Color.Transparent;
            roomClean.Dock = DockStyle.Right;
            roomClean.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            roomClean.ForeColor = Color.FromArgb(74, 20, 140);
            roomClean.Location = new Point(204, 0);
            roomClean.Margin = new Padding(4, 0, 4, 0);
            roomClean.Name = "roomClean";
            roomClean.Size = new Size(81, 19);
            roomClean.TabIndex = 24;
            roomClean.Text = "Incharge by";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 130);
            panel3.Controls.Add(roomID);
            panel3.Controls.Add(roomStatus);
            panel3.Controls.Add(customerName);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 5, 10, 5);
            panel3.Size = new Size(295, 125);
            panel3.TabIndex = 29;
            // 
            // roomID
            // 
            roomID.AutoSize = true;
            roomID.BackColor = Color.Transparent;
            roomID.Font = new Font("Segoe UI Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomID.ForeColor = Color.FromArgb(173, 20, 87);
            roomID.Location = new Point(10, 5);
            roomID.Margin = new Padding(4, 0, 4, 0);
            roomID.Name = "roomID";
            roomID.Size = new Size(74, 21);
            roomID.TabIndex = 30;
            roomID.Text = "RoomID";
            // 
            // roomStatus
            // 
            roomStatus.AutoSize = true;
            roomStatus.BackColor = Color.Transparent;
            roomStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomStatus.ForeColor = Color.FromArgb(173, 20, 87);
            roomStatus.Location = new Point(187, 5);
            roomStatus.Margin = new Padding(4, 0, 4, 0);
            roomStatus.Name = "roomStatus";
            roomStatus.Size = new Size(98, 21);
            roomStatus.TabIndex = 31;
            roomStatus.Text = "Room Status";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.BackColor = Color.Transparent;
            customerName.Font = new Font("Segoe UI Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.Location = new Point(66, 60);
            customerName.Name = "customerName";
            customerName.Size = new Size(121, 30);
            customerName.TabIndex = 28;
            customerName.Text = "Cus Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // RoomView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panel3);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(74, 20, 140);
            Margin = new Padding(4);
            Name = "RoomView";
            Size = new Size(295, 150);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label rentTime;
        private Panel panel2;
        private Panel panel3;
        private Label customerName;
        private PictureBox pictureBox1;
        private Label roomClean;
        private Label roomID;
        private Label roomStatus;
    }
}
