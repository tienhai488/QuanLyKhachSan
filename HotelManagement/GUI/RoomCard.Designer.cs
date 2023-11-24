﻿namespace HotelManagement.GUI
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(18, 15);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 19);
            materialLabel1.TabIndex = 30;
            materialLabel1.Text = "{Room ID}";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(164, 15);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(103, 19);
            materialLabel2.TabIndex = 31;
            materialLabel2.Text = "{Room Status}";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel3.Location = new Point(18, 118);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(18, 17);
            materialLabel3.TabIndex = 31;
            materialLabel3.Text = "Fr:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel4.Location = new Point(74, 118);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(22, 17);
            materialLabel4.TabIndex = 32;
            materialLabel4.Text = "To:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.Location = new Point(74, 60);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(146, 24);
            materialLabel5.TabIndex = 33;
            materialLabel5.Text = "Customer Name";
            materialLabel5.Click += materialLabel5_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel6);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(0);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(15);
            materialCard1.Size = new Size(285, 150);
            materialCard1.TabIndex = 34;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel6.Location = new Point(164, 118);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(61, 17);
            materialLabel6.TabIndex = 34;
            materialLabel6.Text = "Cleaned?";
            // 
            // RoomCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(materialCard1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(74, 20, 140);
            Margin = new Padding(10);
            Name = "RoomCard";
            Size = new Size(285, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}
