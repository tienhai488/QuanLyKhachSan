namespace HotelManagement.GUI
{
    partial class StatisticsUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBox2 = new ComboBox();
            label8 = new Label();
            panel4 = new Panel();
            chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBox1 = new ComboBox();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopProducts).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(materialButton1, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1154, 189);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(702, 10);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 169);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(16, 120);
            label5.Name = "label5";
            label5.Size = new Size(84, 26);
            label5.TabIndex = 1;
            label5.Text = "10 lượt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(16, 18);
            label6.Name = "label6";
            label6.Size = new Size(284, 33);
            label6.TabIndex = 0;
            label6.Text = "Số lượng đặt phòng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSalmon;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(356, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 169);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(16, 120);
            label3.Name = "label3";
            label3.Size = new Size(170, 26);
            label3.TabIndex = 1;
            label3.Text = "1,000,000 VND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(16, 18);
            label4.Name = "label4";
            label4.Size = new Size(259, 33);
            label4.TabIndex = 0;
            label4.Text = "Doanh thu dịch vụ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 169);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 120);
            label2.Name = "label2";
            label2.Size = new Size(170, 26);
            label2.TabIndex = 1;
            label2.Text = "1,000,000 VND";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(246, 33);
            label1.TabIndex = 0;
            label1.Text = "Doanh thu phòng";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1042, 6);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(65, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Excel";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(panel5, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 189);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1154, 452);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(chartGrossRevenue);
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(461, 0);
            panel5.Margin = new Padding(0, 0, 10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(683, 452);
            panel5.TabIndex = 1;
            // 
            // chartGrossRevenue
            // 
            chartArea1.Name = "ChartArea1";
            chartGrossRevenue.ChartAreas.Add(chartArea1);
            chartGrossRevenue.Dock = DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            chartGrossRevenue.Legends.Add(legend1);
            chartGrossRevenue.Location = new Point(0, 48);
            chartGrossRevenue.Margin = new Padding(5);
            chartGrossRevenue.Name = "chartGrossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGrossRevenue.Series.Add(series1);
            chartGrossRevenue.Size = new Size(683, 404);
            chartGrossRevenue.TabIndex = 14;
            chartGrossRevenue.Text = "chartGrossRevenue";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title1";
            title1.Text = "Gross revenue";
            chartGrossRevenue.Titles.Add(title1);
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Top;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(0, 20);
            comboBox2.Margin = new Padding(0, 10, 0, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(683, 28);
            comboBox2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(0, 0, 0, 5);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 1;
            label8.Text = "Năm";
            // 
            // panel4
            // 
            panel4.Controls.Add(chartTopProducts);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 0);
            panel4.Margin = new Padding(10, 0, 0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 452);
            panel4.TabIndex = 0;
            // 
            // chartTopProducts
            // 
            chartArea2.Name = "ChartArea1";
            chartTopProducts.ChartAreas.Add(chartArea2);
            chartTopProducts.Dock = DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            chartTopProducts.Legends.Add(legend2);
            chartTopProducts.Location = new Point(0, 48);
            chartTopProducts.Margin = new Padding(5);
            chartTopProducts.Name = "chartTopProducts";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTopProducts.Series.Add(series2);
            chartTopProducts.Size = new Size(451, 404);
            chartTopProducts.TabIndex = 15;
            chartTopProducts.Text = "chartTopProducts";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "5 Best selling products";
            chartTopProducts.Titles.Add(title2);
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 20);
            comboBox1.Margin = new Padding(0, 10, 0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(451, 28);
            comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(0, 0, 0, 5);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 0;
            label7.Text = "Tháng";
            // 
            // StatisticsUI
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 641);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "StatisticsUI";
            Text = "Store statistics";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private Panel panel5;
        private Label label8;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private ComboBox comboBox2;
    }
}