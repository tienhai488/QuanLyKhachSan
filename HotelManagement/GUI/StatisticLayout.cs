using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class StatisticLayout : Form
    {
        public StatisticLayout()
        {
            InitializeComponent();

            StatisticsUI2 form1 = new StatisticsUI2();
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            form1.Show();

            StatisticsUI form2 = new StatisticsUI();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            form2.Show();

            tabPage1.Controls.Add(form1);
            tabPage2.Controls.Add(form2);
        }
    }
}
