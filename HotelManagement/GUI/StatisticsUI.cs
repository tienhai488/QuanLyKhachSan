using HotelManagement.Business;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement.GUI
{
    public partial class StatisticsUI : Form
    {
        private RentRoomDetailBUS rentRoomDetailBUS = new RentRoomDetailBUS();
        private RoomReservationBUS roomReservationBUS = new RoomReservationBUS();
        public StatisticsUI()
        {
            InitializeComponent();

            loadData();
            initCbxMonth();
            initCbxYear();
        }

        public void initCbxMonth()
        {
            cbxMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbxMonth.Items.Add(i.ToString());
            }
            cbxMonth.Text = DateTime.Now.Month.ToString();
        }

        public void initCbxYear()
        {
            cbxYear.Items.Clear();

            for (int i = rentRoomDetailBUS.getYearMin(); i <= DateTime.Now.Year; i++)
            {
                cbxYear.Items.Add(i.ToString());
            }
            cbxYear.Text = DateTime.Now.Year.ToString();
        }

        public void loadData()
        {
            loadChartSplie();
            loadChartPie();


        }


        public void loadChartSplie()
        {
            chartLine.Series.Clear();

            //addChartSplie("Doanh thu phòng", Color.FromArgb(80, 222, 44, 44), 1);
            //addChartSplie("Doanh thu dịch vụ", Color.FromArgb(80, 169, 232, 74), 2);
            //addChartSplie("Tổng doanh thu", Color.FromArgb(80, 222, 44, 44), 3);

            addChartSplie("Doanh thu phòng", Color.Yellow, 1);
            addChartSplie("Doanh thu dịch vụ", Color.Blue, 2);
            addChartSplie("Tổng doanh thu", Color.Red, 3);

            chartLine.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chartLine.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            chartLine.ChartAreas[0].AxisX.Minimum = 1;
            chartLine.ChartAreas[0].AxisX.Maximum = 12;
        }

        public void addChartSplie(string title, Color color, int type)
        {
            Series series = new Series(title);
            series.ChartType = SeriesChartType.Spline;

            int year = DateTime.Now.Year;
            int.TryParse(cbxYear.Text, out year);
            for (int i = 1; i <= 12; i++)
            {
                double total = 0;
                if (type == 1)
                {
                    total += rentRoomDetailBUS.getTotalRoomRevenueInMonth(i, year);
                }
                else if (type == 2)
                {
                    total += rentRoomDetailBUS.getTotalServiceRevenueInMonth(i, year);
                }
                else if (type == 3)
                {
                    total += rentRoomDetailBUS.getTotalRoomRevenueInMonth(i, year);
                    total += rentRoomDetailBUS.getTotalServiceRevenueInMonth(i, year);
                }
                series.Points.AddXY(i, total);
            }

            series.BorderWidth = 5;
            series.Color = color;

            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 10;

            chartLine.Series.Add(series);


        }

        public void loadChartPie()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int.TryParse(cbxMonth.Text, out month);
            int.TryParse(cbxYear.Text, out year);
            chartPie.Series.Clear();

            Series series = new Series("pie");
            series.ChartType = SeriesChartType.Pie;

            double totalRoomRevenue = rentRoomDetailBUS.getTotalRoomRevenueInMonth(month, year);
            double totalServiceRevenue = rentRoomDetailBUS.getTotalServiceRevenueInMonth(month, year);

            // Thêm dữ liệu cho biểu đồ pie
            series.Points.Add(totalRoomRevenue);
            series.Points.Add(totalServiceRevenue);

            // Đặt màu sắc cho từng điểm dữ liệu với alpha
            series.Points[0].Color = Color.Yellow;
            series.Points[1].Color = Color.Blue;

            series.Points[0].LegendText = "Doanh thu phòng";
            series.Points[1].LegendText = "Doanh thu dịch vụ";

            foreach (DataPoint point in series.Points)
            {
                point.IsValueShownAsLabel = true;
                point.Label = "#PERCENT{P0}"; // Format phần trăm
            }

            series.ToolTip = $"Doanh thu phòng {totalRoomRevenue.ToString("N0")} VND\n Doanh thu dịch vụ {totalServiceRevenue.ToString("N0")} VND";


            // Thêm Series vào Chart
            chartPie.Series.Add(series);



            lbRoomRevenue.Text = totalRoomRevenue.ToString("N0") + " VND";
            lbServiceRevenue.Text = totalServiceRevenue.ToString("N0") + " VND";
            lbCountRoomBooked.Text = roomReservationBUS.getLengthRentRoomInMonth(month, year) + " lượt";

        }

        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChartPie();
        }

        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
