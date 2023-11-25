using HotelManagement.BUS;
using HotelManagement.DTO;
using HotelManagement.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class RoomInfoUI : Form
    {
        private bool isEdit = false;
        private RoomBUS roomBUS = new RoomBUS();
        private RoomUI roomUI;
        private RoomTypeBUS rtBUS = new RoomTypeBUS();
        private Convinience_RoomTypeBUS crtBUS = new Convinience_RoomTypeBUS();
        private ConvinienceBUS cBUS = new ConvinienceBUS();

        private List<String> status = new List<string>() { "Trống", "Quá hạn", "Đã đặt", "Đang sửa" };
        private List<RoomType2> roomTypeList;
        private List<Convinience_RoomType2> convinience_roomType;
        private List<Convinience2> convinience;

        public RoomInfoUI(RoomUI roomUI)
        {
            InitializeComponent();
            initCbx();
            this.roomUI = roomUI;
        }

        #region method
        public void initCbx()
        {
            listViewConvinience.Columns.Add("Convinience id", 150);
            listViewConvinience.Columns.Add("Convinience name", 150);
            listViewConvinience.Columns.Add("Quantity ", 100);
            cbbStatus.Items.AddRange(status.ToArray());
            roomTypeList = rtBUS.getAll();


            foreach (var item in roomTypeList)
            {
                cbbRoomTypeID.Items.Add(item.Id.ToString());
            }

            convinience_roomType = crtBUS.getAll();
            convinience = cBUS.getAll();
        }

        public void roomTypeIDData()
        {
            foreach (var item in roomTypeList)
            {
                if (item.Id == cbbRoomTypeID.Text)
                {
                    labelNameTypeChange.Text = item.Name;
                    labelUnitPriceChange.Text = item.UnitPrice.ToString();
                }
            }
        }

        public void convinientData()
        {
            listViewConvinience.Items.Clear();
            //foreach (var item in )
            foreach (var item in convinience_roomType)
            {
                if (cbbRoomTypeID.Text == item.RoomTypeID)
                {
                    ListViewItem listViewItem = new ListViewItem(item.ConvinienceID);
                    foreach (var item1 in convinience)
                    {
                        if (item.ConvinienceID == item1.Id)
                        {
                            listViewItem.SubItems.Add(item1.Name);
                        }
                    }
                    listViewItem.SubItems.Add(item.Quantity.ToString());

                    listViewConvinience.Items.Add(listViewItem);
                }
            }
        }

        public void fillData(Room2 room, string type)
        {
            labelTitle.Text = type;
            txbID.Enabled = false;
            txbID.Text = room.Id;
            cbbStatus.SelectedIndex = room.Status;


            btnSave.Text = type;
            isEdit = type == "Cập nhật phòng" ? true : false;
            if (isEdit)
            {
                cbbRoomTypeID.Text = room.RoomTypeID;
            }
            else
            {
                cbbRoomTypeID.SelectedIndex = 0;
            }
        }

        #endregion


        #region event
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            int status = cbbStatus.SelectedIndex;
            string roomTypeID = cbbRoomTypeID.Text;

            Room2 room = new Room2(id, status, roomTypeID);
            if (isEdit)
            {
                if (roomBUS.update(room) > 0)
                {
                    MessageBox.Show("Cập nhật phòng thành công");
                    this.roomUI.initTableRoom();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cập nhật phòng không thành công.");
                }
            }
            else
            {
                if (roomBUS.add(room) > 0)
                {
                    MessageBox.Show("Thêm phòng thành công");
                    this.roomUI.initTableRoom();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm phòng không thành công");
                }
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbStatus.SelectedIndex = 0;
            cbbRoomTypeID.SelectedIndex = 0;
        }
        #endregion


        private void cbbRoomTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            roomTypeIDData();
            convinientData();
        }
    }
}
