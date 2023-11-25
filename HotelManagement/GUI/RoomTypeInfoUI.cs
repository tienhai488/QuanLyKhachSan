using HotelManagement.BUS;
using HotelManagement.Data;
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
    public partial class RoomTypeInfoUI : Form
    {
        private DataTable dataTableConvinience = new DataTable();
        private DataTable dataTableConvinienceRoomType = new DataTable();

        private bool isEdit = false;
        private RoomUI roomUI;
        private RoomTypeBUS rtBUS = new RoomTypeBUS();
        private Convinience_RoomTypeBUS crtBUS = new Convinience_RoomTypeBUS();
        private ConvinienceBUS cBUS = new ConvinienceBUS();

        private List<RoomType2> roomTypeList;
        private List<Convinience_RoomType2> convinience_roomTypeList;
        private List<Convinience2> convinienceList;

        public RoomTypeInfoUI(RoomUI roomUI)
        {
            InitializeComponent();
            initCbx();
            this.roomUI = roomUI;
        }

        #region method

        public void initCbx()
        {
            createHeaderText();

            roomTypeList = rtBUS.getAll();
            convinience_roomTypeList = crtBUS.getAll();
            convinienceList = cBUS.getAll();


            dataTableConvinience.Rows.Clear();
            dtgvConvinience.DataSource = null;
            foreach (Convinience2 conv in convinienceList)
            {
                dataTableConvinience.Rows.Add(conv.Id, conv.Name);
            }

            dtgvConvinience.DataSource = dataTableConvinience;

            //Tiện nghi của loại phòng
            createHeaderText2();
            //dataTableConvinienceRoomType.Rows.Clear();
            //dtgvConvinienceRoomType.DataSource = null;
            //foreach (Convinience_RoomType2 conv_roomType in convinience_roomTypeList)
            //{
            //    dataTableConvinienceRoomType.Rows.Add(conv_roomType.ConvinienceID, conv_roomType.RoomTypeID, conv_roomType.Quantity);
            //}

            //dtgvConvinienceRoomType.DataSource = dataTableConvinienceRoomType;



        }



        public void roomTypeIDData()
        {
            //foreach (var item in roomTypeList)
            //{
            //    if (item.Id == cbbRoomTypeID.Text)
            //    {
            //        labelNameTypeChange.Text = item.Name;
            //        labelUnitPriceChange.Text = item.UnitPrice.ToString();
            //    }
            //}
        }

        public void convinientRoomTypeData()
        {
            dataTableConvinienceRoomType.Rows.Clear();
            dtgvConvinienceRoomType.DataSource = null;
            foreach (var item in convinience_roomTypeList)
            {
                if (txbID.Text == item.RoomTypeID)
                {
                    foreach (var item1 in convinienceList)
                    {
                        if (item.ConvinienceID == item1.Id)
                        {
                            dataTableConvinienceRoomType.Rows.Add(item.ConvinienceID, item1.Name, item.Quantity);
                        }
                    }
                }
            }

            dtgvConvinienceRoomType.DataSource = dataTableConvinienceRoomType;
        }

        public void createHeaderText()
        {
            dataTableConvinience.Columns.Add("Mã tiện nghi");
            dataTableConvinience.Columns.Add("Tên tiện nghi");
        }

        public void createHeaderText2()
        {
            dataTableConvinienceRoomType.Columns.Add("Mã tiện nghi");
            dataTableConvinienceRoomType.Columns.Add("Tên tiện nghi");
            dataTableConvinienceRoomType.Columns.Add("Số lượng");
        }



        //Xem kiểu sự kiện "Thêm hay sửa"
        public void fillData(RoomType2 roomType, string type)
        {
            labelTitle.Text = type;
            txbID.Enabled = false;
            txbID.Text = roomType.Id;


            btnSave.Text = type;
            isEdit = type == "Cập nhật loại phòng" ? true : false;
            if (isEdit)
            {
                txbName.Text = roomType.Name;
                txbPrice.Text = roomType.UnitPrice.ToString();
            }
            else
            {
                txbName.Text = string.Empty;
                txbPrice.Text = string.Empty;
                panel7.Visible = false;
                tableLayoutPanelThongTin.Visible = false;
            }
            convinientRoomTypeData();
        }

        #endregion


        #region event
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            String name = txbName.Text;
            String unitPrice = txbPrice.Text;


            if (!Double.TryParse(unitPrice, out double price))
            {
                MessageBox.Show("Bạn nhập giá phòng chưa đúng định dạng");
                return;
            }

            RoomType2 roomType = new RoomType2(id, name, price);

            if (!rtBUS.validate(roomType))
            {
                return;
            }
            if (isEdit)
            {
                if (rtBUS.update(roomType) > 0)
                {
                    MessageBox.Show("Cập nhật loại phòng thành công");
                    this.roomUI.initTableRoomType();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật loại phòng không thành công.");
                }
            }
            else
            {
                if (rtBUS.add(roomType) > 0)
                {
                    MessageBox.Show("Thêm loại phòng thành công");
                    this.roomUI.initTableRoomType();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm loại phòng không thành công");
                }
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            //cbbStatus.SelectedIndex = 0;
            //cbbRoomTypeID.SelectedIndex = 0;
        }
        #endregion


        private void cbbRoomTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            //roomTypeIDData();
            //convinientData();
        }

        int index = -1;
        private void dtgvConvinience_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= convinienceList.Count)
                return;
            btnActive.Text = "Thêm";
            txbQuantity.Enabled = true;
        }

        int index1 = -1;
        private void dtgvConvinienceRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index1 = e.RowIndex;
            if (index1 < 0 || index1 >= dtgvConvinienceRoomType.RowCount - 1)
                return;
            btnActive.Text = "Xóa";
            txbQuantity.Enabled = false;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if (btnActive.Text == "Thêm")
            {
                if (index < 0 || index >= convinienceList.Count)
                {
                    MessageBox.Show("Bạn chưa chọn tiện nghi muốn thêm");
                    return;
                }

                foreach (DataGridViewRow row in dtgvConvinienceRoomType.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (convinienceList[index].Id == row.Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Bạn không thể thêm tiện nghi này");
                            return;
                        }
                    }
                }

                Convinience_RoomType2 convinience_RoomType2;
                if (int.TryParse(txbQuantity.Text, out var quantity) || quantity != 0)
                {
                    convinience_RoomType2 = new Convinience_RoomType2(convinienceList[index].Id, txbID.Text, quantity);
                }
                else
                {
                    MessageBox.Show("Số lượng tiện nghi sai định dạng");
                    return;
                }
                
                if (crtBUS.add(convinience_RoomType2) > 0)
                {
                    MessageBox.Show("Thêm tiện nghi vào loại phòng thành công");
                    convinience_roomTypeList = crtBUS.getAll();
                    convinientRoomTypeData();
                }
            }
            else if(btnActive.Text == "Xóa")
            {
                if (index1 < 0 || index1 >= dtgvConvinienceRoomType.RowCount - 1)
                {
                    MessageBox.Show("Bạn chưa chọn tiện nghi muốn xóa");
                    return;
                }
                    

                for (int i = 0; i < convinience_roomTypeList.Count; i++)
                {
                    if (convinience_roomTypeList[i].ConvinienceID == dtgvConvinienceRoomType.Rows[index1].Cells[0].Value.ToString()
                        && convinience_roomTypeList[i].RoomTypeID == txbID.Text)
                    {
                        if(crtBUS.delete(convinience_roomTypeList[i].ConvinienceID, convinience_roomTypeList[i].RoomTypeID) > 0)
                        {
                            MessageBox.Show("Xóa tiện nghi khỏi loại phòng này thành công");
                            convinience_roomTypeList = crtBUS.getAll();
                            convinientRoomTypeData();
                            return;
                        }
                    }
                }
            }
        }
    }
}
