using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.BUS;
using HotelManagement.DTO;
using HotelManagement.DAO;
using HotelManagement.Ultils;
using MaterialSkin.Controls;
using Google.Protobuf.WellKnownTypes;

namespace HotelManagement.GUI
{
    public partial class ConvinienceUI : Form
    {
        private BindingSource bsconvinience = new BindingSource();
        private BindingSource bscrt = new BindingSource();
        private ConvinienceBUS convinienceBUS = new ConvinienceBUS();
        private DataTable convinientTable = new DataTable();
        private DataTable convinienttypeTable = new DataTable();
        private ConvinienceDAO convinienceDAO = new ConvinienceDAO();
        public ConvinienceUI()
        {
            InitializeComponent();
            convinientTable.Columns.Add("Mã tiện nghi");
            convinientTable.Columns.Add("Tên tiện nghi");

            convinienttypeTable.Columns.Add("Mã tiện nghi");
            convinienttypeTable.Columns.Add("Số phòng");
            convinienttypeTable.Columns.Add("Số lượng");

            initConvinientTable();
            initCTTable();
        }
        #region method
        public void initConvinientTable()
        {
            convinientTable.Rows.Clear();
            convinience.DataSource = null;
            List<Convinience> ds = new List<Convinience>();
            ds = convinienceBUS.getAllValue();
            ds.ForEach(item => { convinientTable.Rows.Add(item.Convinient_id, item.Convinient_name); });
            convinience.DataSource = convinientTable;
            bsconvinience.DataSource = convinientTable;
        }
        public void initCTTable()
        {
            convinienttypeTable.Rows.Clear();
            convinience_room_type.DataSource = null;
            List<Convinience_Room_Type> ds = new List<Convinience_Room_Type>();
            ds = convinienceBUS.getAllTypevalue();
            ds.ForEach(item => { convinienttypeTable.Rows.Add(item.Convinient_id1, item.Id_room, item.Convinient_quantity); });
            convinience_room_type.DataSource = convinienttypeTable;
            bscrt.DataSource = convinienttypeTable;
        }
        #endregion
        #region event

        #endregion

        private void convinience_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex != -1)
                {
                    string value = convinience.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
                    if (MessageBox.Show("Ban co chac muon xoa", "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        convinienceDAO.deleteConvinience(value);
                        initConvinientTable();
                    }
                }
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = convinience.Rows[index];
                if (selectedrow != null)
                {
                    textBox1.Text = selectedrow.Cells[1].Value.ToString();
                    textBox2.Text = selectedrow.Cells[2].Value.ToString();
                }
            }
        }

        private void convinience_room_type_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex != -1)
                {
                    string value = convinience_room_type.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
                    string value1 = convinience_room_type.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
                    if (MessageBox.Show("Ban co chac muon xoa", "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        convinienceDAO.deleteCRT(value, value1);
                        initCTTable();
                    }
                }
            }
            else
            {
                int index = e.RowIndex;
                DataGridViewRow selectedrow = convinience_room_type.Rows[index];
                if (selectedrow != null)
                {
                    textBox3.Text = selectedrow.Cells[1].Value.ToString();
                    textBox4.Text = selectedrow.Cells[2].Value.ToString();
                    textBox5.Text = selectedrow.Cells[3].Value.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            convinienceBUS.validateConvinience(textBox1.Text, textBox2.Text);
            Convinience convinience = new Convinience(textBox1.Text, textBox2.Text);
            convinienceDAO.addConvinience(convinience);
            initConvinientTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            convinienceBUS.validateCRT(textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text));
            Convinience_Room_Type crt = new Convinience_Room_Type(textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text));
            convinienceDAO.updateCRT(crt);
            initCTTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            convinienceBUS.validateCRT(textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text));
            Convinience_Room_Type crt = new Convinience_Room_Type(textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text));
            convinienceDAO.addCRT(crt);
            initCTTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convinienceBUS.validateConvinience(textBox1.Text, textBox2.Text);
            Convinience convinience = new Convinience(textBox1.Text, textBox2.Text);
            convinienceDAO.updateConvinience(convinience);
            initConvinientTable();
        }
    }
}
