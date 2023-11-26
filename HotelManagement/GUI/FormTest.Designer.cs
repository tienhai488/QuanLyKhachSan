namespace HotelManagement.GUI
{
    partial class FormTest
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProducts).BeginInit();
            SuspendLayout();
            // 
            // chartGrossRevenue
            // 
            chartArea2.Name = "ChartArea1";
            chartGrossRevenue.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            chartGrossRevenue.Legends.Add(legend2);
            chartGrossRevenue.Location = new Point(-23, 98);
            chartGrossRevenue.Margin = new Padding(5);
            chartGrossRevenue.Name = "chartGrossRevenue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGrossRevenue.Series.Add(series2);
            chartGrossRevenue.Size = new Size(846, 255);
            chartGrossRevenue.TabIndex = 13;
            chartGrossRevenue.Text = "chartGrossRevenue";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Gross revenue";
            chartGrossRevenue.Titles.Add(title2);
            chartGrossRevenue.Click += chartGrossRevenue_Click;
            // 
            // chartTopProducts
            // 
            chartArea3.Name = "ChartArea1";
            chartTopProducts.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            chartTopProducts.Legends.Add(legend3);
            chartTopProducts.Location = new Point(422, 77);
            chartTopProducts.Margin = new Padding(5);
            chartTopProducts.Name = "chartTopProducts";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartTopProducts.Series.Add(series3);
            chartTopProducts.Size = new Size(320, 495);
            chartTopProducts.TabIndex = 14;
            chartTopProducts.Text = "chartTopProducts";
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title3.Name = "Title1";
            title3.Text = "5 Best selling products";
            chartTopProducts.Titles.Add(title3);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 648);
            Controls.Add(chartTopProducts);
            Controls.Add(chartGrossRevenue);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartGrossRevenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTopProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
    }
}