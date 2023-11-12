namespace HotelManagement.GUI
{
    partial class RoomView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomView));
            rentTime = new Label();
            roomClean = new Label();
            roomStatus = new Label();
            roomID = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            customerName = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
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
            rentTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rentTime.ForeColor = Color.White;
            rentTime.Location = new Point(15, 0);
            rentTime.Margin = new Padding(4, 0, 4, 0);
            rentTime.Name = "rentTime";
            rentTime.Size = new Size(95, 25);
            rentTime.TabIndex = 25;
            rentTime.Text = "Rent Time";
            // 
            // roomClean
            // 
            roomClean.AutoSize = true;
            roomClean.BackColor = Color.Transparent;
            roomClean.Dock = DockStyle.Right;
            roomClean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            roomClean.ForeColor = Color.White;
            roomClean.Location = new Point(204, 0);
            roomClean.Margin = new Padding(4, 0, 4, 0);
            roomClean.Name = "roomClean";
            roomClean.Size = new Size(81, 25);
            roomClean.TabIndex = 24;
            roomClean.Text = "Cleaned";
            // 
            // roomStatus
            // 
            roomStatus.AutoSize = true;
            roomStatus.BackColor = Color.Transparent;
            roomStatus.Dock = DockStyle.Right;
            roomStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            roomStatus.ForeColor = Color.FromArgb(255, 224, 130);
            roomStatus.Location = new Point(170, 15);
            roomStatus.Margin = new Padding(4, 0, 4, 0);
            roomStatus.Name = "roomStatus";
            roomStatus.Size = new Size(115, 25);
            roomStatus.TabIndex = 23;
            roomStatus.Text = "Room Status";
            // 
            // roomID
            // 
            roomID.AutoSize = true;
            roomID.BackColor = Color.Transparent;
            roomID.Dock = DockStyle.Left;
            roomID.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point);
            roomID.ForeColor = Color.FromArgb(255, 224, 130);
            roomID.Location = new Point(15, 15);
            roomID.Margin = new Padding(4, 0, 4, 0);
            roomID.Name = "roomID";
            roomID.Size = new Size(88, 25);
            roomID.TabIndex = 22;
            roomID.Text = "RoomID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(173, 20, 87);
            panel1.Controls.Add(roomID);
            panel1.Controls.Add(roomStatus);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(300, 40);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 20, 140);
            panel2.Controls.Add(rentTime);
            panel2.Controls.Add(roomClean);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 125);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15, 0, 15, 0);
            panel2.Size = new Size(300, 25);
            panel2.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(173, 20, 87);
            panel3.Controls.Add(customerName);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 40);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15);
            panel3.Size = new Size(300, 85);
            panel3.TabIndex = 29;
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.BackColor = Color.Gainsboro;
            customerName.Font = new Font("Segoe UI Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.Location = new Point(71, 25);
            customerName.Name = "customerName";
            customerName.Size = new Size(202, 32);
            customerName.TabIndex = 28;
            customerName.Text = "Customer Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // RoomView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(74, 20, 140);
            Margin = new Padding(4);
            Name = "RoomView";
            Size = new Size(300, 150);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label rentTime;
        private Label roomClean;
        private Label roomStatus;
        private Label roomID;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label customerName;
        private PictureBox pictureBox1;
    }
}
