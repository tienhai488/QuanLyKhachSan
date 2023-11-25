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
    public partial class ConvinienceInfoUI : Form
    {
        private bool isEdit = false;
        private RoomBUS roomBUS = new RoomBUS();
        private RoomUI roomUI;
        private RoomTypeBUS rtBUS = new RoomTypeBUS();
        private Convinience_RoomTypeBUS crtBUS = new Convinience_RoomTypeBUS();
        private ConvinienceBUS cBUS = new ConvinienceBUS();

        private List<RoomType2> roomTypeList;
        private List<Convinience_RoomType2> convinience_roomType;
        private List<Convinience2> convinience;

        public ConvinienceInfoUI(RoomUI roomUI)
        {
            InitializeComponent();
            initCbx();
            this.roomUI = roomUI;
        }

        #region method
        public void initCbx()
        {
            
        }

        public void roomTypeIDData()
        {
            
        }

        public void convinientData()
        {
            
        }

        public void fillData(Convinience2 conv, string type)
        {
            labelTitle.Text = type;
            txbID.Enabled = false;
            txbID.Text = conv.Id;


            btnSave.Text = type;
            isEdit = type == "Cập nhật tiện nghi" ? true : false;
            if (isEdit)
            {
                txbName.Text = conv.Name;
            }
            else
            {
                txbName.Text = string.Empty;
            }
        }

        #endregion


        #region event
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string name = txbName.Text;

            Convinience2 conv = new Convinience2(id, name);
            if (isEdit)
            {
                if (cBUS.update(conv) > 0)
                {
                    MessageBox.Show("Cập nhật tiện nghi thành công");
                    this.roomUI.initTableConvinience();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cập nhật tiện nghi không thành công.");
                }
            }
            else
            {
                if (cBUS.add(conv) > 0)
                {
                    MessageBox.Show("Thêm tiện nghi thành công");
                    this.roomUI.initTableConvinience();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm tiện nghi không thành công");
                }
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            //cbbStatus.SelectedIndex = 0;
            //cbbRoomTypeID.SelectedIndex = 0;
        }
        #endregion


       
    }
}
