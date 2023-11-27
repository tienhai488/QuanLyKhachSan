namespace HotelManagement.GUI
{
    partial class ConvinienceUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            tabControl1 = new TabControl();
            convinienceTabpage = new TabPage();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            convinience = new DataGridView();
            DeleteColumn1 = new DataGridViewButtonColumn();
            crtTabpage = new TabPage();
            button4 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            convinience_room_type = new DataGridView();
            DeleteColumn2 = new DataGridViewButtonColumn();
            tabControl1.SuspendLayout();
            convinienceTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)convinience).BeginInit();
            crtTabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)convinience_room_type).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1033, 52);
            label1.TabIndex = 1;
            label1.Text = "CONVINIENT RECORDS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(convinienceTabpage);
            tabControl1.Controls.Add(crtTabpage);
            tabControl1.Location = new Point(12, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1009, 584);
            tabControl1.TabIndex = 2;
            // 
            // convinienceTabpage
            // 
            convinienceTabpage.Controls.Add(button2);
            convinienceTabpage.Controls.Add(button1);
            convinienceTabpage.Controls.Add(textBox2);
            convinienceTabpage.Controls.Add(textBox1);
            convinienceTabpage.Controls.Add(label4);
            convinienceTabpage.Controls.Add(label3);
            convinienceTabpage.Controls.Add(label2);
            convinienceTabpage.Controls.Add(convinience);
            convinienceTabpage.Location = new Point(4, 29);
            convinienceTabpage.Name = "convinienceTabpage";
            convinienceTabpage.Padding = new Padding(3);
            convinienceTabpage.Size = new Size(1001, 551);
            convinienceTabpage.TabIndex = 0;
            convinienceTabpage.Text = "Conviniece";
            convinienceTabpage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 265);
            button2.Name = "button2";
            button2.Size = new Size(289, 29);
            button2.TabIndex = 3;
            button2.Text = "Thêm tiện nghi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 194);
            button1.Name = "button1";
            button1.Size = new Size(289, 29);
            button1.TabIndex = 3;
            button1.Text = "Sửa bảng tiện nghi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 27);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên tiện nghi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã tiện nghi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 14);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 1;
            label2.Text = "THÔNG TIN BẢNG TIỆN NGHI";
            // 
            // convinience
            // 
            convinience.BackgroundColor = Color.Blue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            convinience.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            convinience.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            convinience.Columns.AddRange(new DataGridViewColumn[] { DeleteColumn1 });
            convinience.Location = new Point(355, 148);
            convinience.Name = "convinience";
            convinience.RowHeadersWidth = 100;
            convinience.RowTemplate.Height = 29;
            convinience.Size = new Size(600, 380);
            convinience.TabIndex = 0;
            convinience.CellContentClick += convinience_CellContentClick;
            // 
            // DeleteColumn1
            // 
            DeleteColumn1.HeaderText = "DELETE";
            DeleteColumn1.MinimumWidth = 6;
            DeleteColumn1.Name = "DeleteColumn1";
            DeleteColumn1.Text = "delete";
            DeleteColumn1.UseColumnTextForButtonValue = true;
            DeleteColumn1.Width = 125;
            // 
            // crtTabpage
            // 
            crtTabpage.Controls.Add(button4);
            crtTabpage.Controls.Add(button3);
            crtTabpage.Controls.Add(textBox5);
            crtTabpage.Controls.Add(textBox4);
            crtTabpage.Controls.Add(textBox3);
            crtTabpage.Controls.Add(label8);
            crtTabpage.Controls.Add(label7);
            crtTabpage.Controls.Add(label6);
            crtTabpage.Controls.Add(label5);
            crtTabpage.Controls.Add(convinience_room_type);
            crtTabpage.Location = new Point(4, 29);
            crtTabpage.Name = "crtTabpage";
            crtTabpage.Padding = new Padding(3);
            crtTabpage.Size = new Size(1001, 551);
            crtTabpage.TabIndex = 1;
            crtTabpage.Text = "Convinience Room Type";
            crtTabpage.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 275);
            button4.Name = "button4";
            button4.Size = new Size(287, 29);
            button4.TabIndex = 3;
            button4.Text = "Đặt thêm tiện nghi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 210);
            button3.Name = "button3";
            button3.Size = new Size(287, 29);
            button3.TabIndex = 3;
            button3.Text = "Sửa bảng crt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(159, 145);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 27);
            textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 55);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 27);
            textBox3.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 152);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 1;
            label8.Text = "Số lượng :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 105);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 1;
            label7.Text = "Số phòng :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 62);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 1;
            label6.Text = "Mã tiện nghi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 16);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 1;
            label5.Text = "THÔNG TIN CRT";
            // 
            // convinience_room_type
            // 
            convinience_room_type.BackgroundColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            convinience_room_type.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            convinience_room_type.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            convinience_room_type.Columns.AddRange(new DataGridViewColumn[] { DeleteColumn2 });
            convinience_room_type.GridColor = Color.FromArgb(128, 255, 128);
            convinience_room_type.Location = new Point(355, 148);
            convinience_room_type.Name = "convinience_room_type";
            convinience_room_type.RowHeadersWidth = 100;
            convinience_room_type.RowTemplate.Height = 29;
            convinience_room_type.Size = new Size(600, 380);
            convinience_room_type.TabIndex = 0;
            convinience_room_type.CellContentClick += convinience_room_type_CellContentClick;
            // 
            // DeleteColumn2
            // 
            DeleteColumn2.HeaderText = "DELETE";
            DeleteColumn2.MinimumWidth = 6;
            DeleteColumn2.Name = "DeleteColumn2";
            DeleteColumn2.Text = "delete";
            DeleteColumn2.UseColumnTextForButtonValue = true;
            DeleteColumn2.Width = 125;
            // 
            // ConvinienceUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 666);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConvinienceUI";
            Text = "ConvinienceUI";
            tabControl1.ResumeLayout(false);
            convinienceTabpage.ResumeLayout(false);
            convinienceTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)convinience).EndInit();
            crtTabpage.ResumeLayout(false);
            crtTabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)convinience_room_type).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage convinienceTabpage;
        private TabPage crtTabpage;
        private DataGridView convinience;
        private DataGridView convinience_room_type;
        private DataGridViewButtonColumn DeleteColumn1;
        private DataGridViewButtonColumn DeleteColumn2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button4;
        private Button button3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}