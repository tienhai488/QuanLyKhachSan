﻿namespace HotelManagement.GUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            lbCountRoomBooked = new Label();
            label6 = new Label();
            panel2 = new Panel();
            lbServiceRevenue = new Label();
            label4 = new Label();
            panel1 = new Panel();
            lbRoomRevenue = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            chartLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cbxYear = new ComboBox();
            label8 = new Label();
            panel4 = new Panel();
            chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cbxMonth = new ComboBox();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartLine).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4827461F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0345039F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4827461F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
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
            panel3.Controls.Add(lbCountRoomBooked);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(765, 10);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 169);
            panel3.TabIndex = 2;
            // 
            // lbCountRoomBooked
            // 
            lbCountRoomBooked.AutoSize = true;
            lbCountRoomBooked.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountRoomBooked.ForeColor = SystemColors.ButtonHighlight;
            lbCountRoomBooked.Location = new Point(16, 120);
            lbCountRoomBooked.Name = "lbCountRoomBooked";
            lbCountRoomBooked.Size = new Size(84, 26);
            lbCountRoomBooked.TabIndex = 1;
            lbCountRoomBooked.Text = "10 lượt";
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
            panel2.Controls.Add(lbServiceRevenue);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(407, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 169);
            panel2.TabIndex = 1;
            // 
            // lbServiceRevenue
            // 
            lbServiceRevenue.AutoSize = true;
            lbServiceRevenue.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbServiceRevenue.ForeColor = SystemColors.ButtonHighlight;
            lbServiceRevenue.Location = new Point(16, 120);
            lbServiceRevenue.Name = "lbServiceRevenue";
            lbServiceRevenue.Size = new Size(170, 26);
            lbServiceRevenue.TabIndex = 1;
            lbServiceRevenue.Text = "1,000,000 VND";
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
            panel1.Controls.Add(lbRoomRevenue);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 169);
            panel1.TabIndex = 0;
            // 
            // lbRoomRevenue
            // 
            lbRoomRevenue.AutoSize = true;
            lbRoomRevenue.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbRoomRevenue.ForeColor = SystemColors.ButtonHighlight;
            lbRoomRevenue.Location = new Point(16, 120);
            lbRoomRevenue.Name = "lbRoomRevenue";
            lbRoomRevenue.Size = new Size(170, 26);
            lbRoomRevenue.TabIndex = 1;
            lbRoomRevenue.Text = "1,000,000 VND";
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
            // 
            // panel5
            // 
            panel5.Controls.Add(chartLine);
            panel5.Controls.Add(cbxYear);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(461, 0);
            panel5.Margin = new Padding(0, 0, 10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(683, 452);
            panel5.TabIndex = 1;
            // 
            // chartLine
            // 
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            chartLine.ChartAreas.Add(chartArea1);
            chartLine.Dock = DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            chartLine.Legends.Add(legend1);
            chartLine.Location = new Point(0, 48);
            chartLine.Name = "chartLine";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderWidth = 3;
            series1.LabelToolTip = "data";
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 3;
            series1.MarkerColor = Color.FromArgb(255, 128, 0);
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            chartLine.Series.Add(series1);
            chartLine.Size = new Size(683, 404);
            chartLine.TabIndex = 3;
            chartLine.Text = "chart1";
            // 
            // cbxYear
            // 
            cbxYear.Dock = DockStyle.Top;
            cbxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxYear.FormattingEnabled = true;
            cbxYear.Location = new Point(0, 20);
            cbxYear.Margin = new Padding(0, 10, 0, 0);
            cbxYear.Name = "cbxYear";
            cbxYear.Size = new Size(683, 28);
            cbxYear.TabIndex = 2;
            cbxYear.SelectedIndexChanged += cbxYear_SelectedIndexChanged;
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
            panel4.Controls.Add(chartPie);
            panel4.Controls.Add(cbxMonth);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 0);
            panel4.Margin = new Padding(10, 0, 0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 452);
            panel4.TabIndex = 0;
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            chartPie.ChartAreas.Add(chartArea2);
            chartPie.Dock = DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            chartPie.Legends.Add(legend2);
            chartPie.Location = new Point(0, 48);
            chartPie.Name = "chartPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPie.Series.Add(series2);
            chartPie.Size = new Size(451, 404);
            chartPie.TabIndex = 2;
            chartPie.Text = "chart2";
            // 
            // cbxMonth
            // 
            cbxMonth.Dock = DockStyle.Top;
            cbxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMonth.FormattingEnabled = true;
            cbxMonth.Location = new Point(0, 20);
            cbxMonth.Margin = new Padding(0, 10, 0, 0);
            cbxMonth.Name = "cbxMonth";
            cbxMonth.Size = new Size(451, 28);
            cbxMonth.TabIndex = 1;
            cbxMonth.SelectedIndexChanged += cbxMonth_SelectedIndexChanged;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartLine).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label lbRoomRevenue;
        private Panel panel3;
        private Label lbCountRoomBooked;
        private Label label6;
        private Panel panel2;
        private Label lbServiceRevenue;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private ComboBox cbxMonth;
        private Label label7;
        private Panel panel5;
        private Label label8;
        private ComboBox cbxYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
    }
}