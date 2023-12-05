﻿using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Globalization;

namespace HotelManagement.GUI
{
    public partial class ReservationUI : MaterialForm
    {
        private ReservationBUS reservationBUS = new ReservationBUS();
        private RoomReservationBUS roomReservationBUS = new RoomReservationBUS();

        private BindingSource bindingSource = new BindingSource();
        DataTable dataTable = new DataTable();

        private System.Threading.Timer timer;
        public ReservationUI()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink700,      // Main background color (Deeper Pink)
                Primary.Purple400,    // Darker background color
                Primary.Purple300,    // Slightly lighter accent background color
                Accent.Orange400,     // Warm accent color for highlights
                TextShade.WHITE       // Light text color for better readability
            );

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Staff");
            dataTable.Columns.Add("CreatdAt");

            roomReservationBUS.loadOutDateAllRoomReservation();
            initTable();
        }

        #region method
        public void initTable()
        {
            dataTable.Rows.Clear();
            dataGridView1.DataSource = null;

            reservationBUS.getAll().ForEach(item =>
            {
                dataTable.Rows.Add(item.Id, item.Customer.FullName, item.Staff.FullName, item.CreatedAt.ToString(Configs.formatDateTime));
            });
            dataGridView1.DataSource = dataTable;
            bindingSource.DataSource = dataTable;
        }


        public string getReservationID()
        {
            int index = 1;
            var ress = reservationBUS.getAll();
            if (ress.Count > 0)
            {
                index = ress.Max(item => Functions.convertIdToInteger(item.Id, "RE")) + 1;
            }
            return "RE" + index.ToString("D5");
        }

        private void TimerCallback(object state)
        {
            if (txtIdFilter.InvokeRequired)
            {
                txtIdFilter.Invoke(new MethodInvoker(delegate
                {
                    // Thực hiện hành động cần thiết sau khi chờ đợi 500ms
                    bindingSource.Filter = @$"
                    `ID` like '%{txtIdFilter.Text}%'
                    ";

                    dataGridView1.DataSource = bindingSource;
                }));
            }
            else
            {
                // Nếu đang chạy trên luồng chính, thực hiện ngay lập tức
                bindingSource.Filter = @$"
                    `ID` like '%{txtIdFilter.Text}%'
                    ";

                dataGridView1.DataSource = bindingSource;
            }
        }
        #endregion

        #region event
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string id = getReservationID();
            ReservBookingUI reservBookingUI = new ReservBookingUI(this, id);
            reservBookingUI.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected."); ;
                return;
            }
            DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];

            DataGridViewRow selectedRow = selectedCell.OwningRow;

            string id = selectedRow.Cells[0].Value.ToString();

            ReservBookingUI reservBookingUI = new ReservBookingUI(this, id);
            reservBookingUI.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected."); ;
                return;
            }
            DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];

            DataGridViewRow selectedRow = selectedCell.OwningRow;

            string id = selectedRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Xóa phiếu đặt phòng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int count = roomReservationBUS.getLengthRoomReservationByReservationId(id);
                if (count > 0)
                {
                    MessageBox.Show("Phiếu đặt phòng đã tồn tại ds các phòng đã đặt! Vui lòng kiểm tra lại!");
                    return;
                }

                int result = reservationBUS.delete(id);
                if (result == 0)
                {
                    MessageBox.Show("Xóa phiếu đặt phòng không thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa phiếu đặt phòng thành công!");
                    initTable();
                }
            }
        }

        private void txtIdFilter_TextChanged(object sender, EventArgs e)
        {
            timer?.Change(Timeout.Infinite, Timeout.Infinite);

            // Tạo một timer mới và đặt thời gian chờ đợi là 500ms
            timer = new System.Threading.Timer(TimerCallback, null, 500, Timeout.Infinite);
        }
        #endregion
    }
}
