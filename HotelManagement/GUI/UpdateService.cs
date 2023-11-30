using HotelManagement.BUS;
using HotelManagement.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
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
    public partial class UpdateService : MaterialForm
    {
        public UpdateService()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Pink800,   // Main background color
            Primary.Purple900, // Darker background color
            Primary.Purple500, // Accent background color
            Accent.Amber200,   // Warm accent color for highlights
            TextShade.WHITE);    // Text color

            loadCmb();
            loadGrid();
        }

        private BindingSource bindingSourceService = new BindingSource();
        private BindingSource bindingSourceServiceType = new BindingSource();
        private ServiceBUS serviceBUS = new ServiceBUS();
        private DataTable typeTable = new DataTable();
        private DataTable serviceTable = new DataTable();
        public void loadGrid()
        {
            foreach (Service s in serviceBUS.getAllService())
            {
                string[] g = { s.Id, s.Name, s.Unit, s.UnitPrice.ToString() };
                dataGridViewService.Rows.Add(g);
            }
        }

        public void loadCmb()
        {
            mcmbServiceType.Items.Add("All services");
            mcmbServiceType.SelectedIndex = 0;
            dataGridViewService.Rows.Clear();
            foreach (Service s in serviceBUS.getAllService())
                if (!mcmbServiceType.Items.Contains(s.ServiceTypeId))
                    mcmbServiceType.Items.Add(s.ServiceTypeId);
        }


        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelected.SelectedRows.Count > 0)
            {
                dataGridViewSelected.Rows.RemoveAt(dataGridViewSelected.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void mbtnSelectService_Click(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewService.SelectedRows[0];
                Boolean flag = true;
                foreach (DataGridViewRow row in dataGridViewSelected.Rows)
                {
                    if (selectedRow.Cells[1].Value.ToString().Equals(row.Cells[1].Value.ToString()))
                    {
                        int i = Int32.Parse(row.Cells[2].Value.ToString()) + 1;
                        row.Cells[2].Value = i.ToString();
                        row.Cells[3].Value = (i * Int32.Parse(selectedRow.Cells[3].Value.ToString())).ToString();
                        flag = false; break;
                    }
                }
                if (flag)
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string name = selectedRow.Cells[1].Value.ToString();
                    string unit = selectedRow.Cells[2].Value.ToString();
                    string price = (Int32.Parse(selectedRow.Cells[2].Value.ToString()) *
                        Int32.Parse(selectedRow.Cells[3].Value.ToString())).ToString();
                    string[] g = { id, name, unit, price };
                    dataGridViewSelected.Rows.Add(g);
                }

            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void mcmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewService.Rows.Clear();
            if (mcmbServiceType.SelectedIndex == 0)
            {
                loadGrid();
            }
            else
                foreach (Service s in serviceBUS.getAllService())
                    if (mcmbServiceType.SelectedItem.ToString().Equals(s.ServiceTypeId))
                    {
                        string[] g = { s.Id, s.Name, s.Unit, s.UnitPrice.ToString() };
                        dataGridViewService.Rows.Add(g);
                    }
        }

        private void mbtnCheckOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            /*System.Windows.Forms.Application.Exit();
            int total = 0;
            foreach (DataGridViewRow row in dataGridViewSelected.Rows)
                total += Int32.Parse(row.Cells[3].Value.ToString());
            MessageBox.Show($"Total price of the service: {total}");*/
        }

        private void mbtnChangeQuantity_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewSelected.SelectedRows[0];
            DataGridViewRow serviceRow = dataGridViewService.SelectedRows[0];
            if (dataGridViewSelected.SelectedRows.Count > 0)
            {
                string q = Interaction.InputBox("Enter quantity:", "Enter quantity:", "").ToString();
                if (q.Equals(""))
                    MessageBox.Show("Enter a property.");
                else if (Int32.Parse(q) == 0)
                    dataGridViewSelected.Rows.RemoveAt(selectedRow.Index);
                else
                {
                    selectedRow.Cells[2].Value = q;
                    selectedRow.Cells[3].Value = (Int32.Parse(q) * Int32.Parse(serviceRow.Cells[3].Value.ToString())).ToString();
                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }
    }
}