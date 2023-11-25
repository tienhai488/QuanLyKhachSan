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
using HotelManagement.Ultils;

namespace HotelManagement.GUI
{
    public partial class RoomUI : Form
    {
        private RoomBUS roomBus = new RoomBUS();
        private RoomTypeBUS roomTypeBus = new RoomTypeBUS();
        private ConvinienceBUS convinienceBUS = new ConvinienceBUS();
        private Convinience_RoomTypeBUS convinience_RoomTypeBus = new Convinience_RoomTypeBUS();

        DataTable dataTableRoom = new DataTable();
        DataTable dataTableRoomType = new DataTable();
        DataTable dataTableConvinience = new DataTable();


        List<Room2> roomList;
        List<RoomType2> roomTypeList;
        List<Convinience2> convinienceList;
        List<Convinience_RoomType2> convinience_RoomTypeList;

        BindingSource bindingSourceRoom = new BindingSource();
        BindingSource bindingSourceRoomType = new BindingSource();
        BindingSource bindingSourceConvinience = new BindingSource();

        public RoomUI()
        {
            InitializeComponent();
            createHeadTextRoom();
            initTableRoom();

            createHeadTextRoomType();
            initTableRoomType();

            createHeadTextConvinience();
            initTableConvinience();
        }

        #region method TabPageRoom
        public void initTableRoom()
        {
            dataTableRoom.Rows.Clear();
            dtgvShowRoom.DataSource = null;
            roomList = new List<Room2>();
            roomList = roomBus.getAll();

            convinience_RoomTypeList = convinience_RoomTypeBus.getAll();
            foreach (Room2 room in roomList)
            {
                string status;
                status = checkStatus(room.Status);
                dataTableRoom.Rows.Add(room.Id, status, room.RoomTypeID);
            }

            dtgvShowRoom.DataSource = dataTableRoom;
            bindingSourceRoom.DataSource = dataTableRoom;
            initCbxFilterAllRoom();
        }

        public string checkStatus(int status)
        {
            if (status == 1)
                return "Quá hạn";
            else if (status == 2)
                return "Đã đặt";
            else if (status == 3)
                return "Đang sửa";
            else
                return "Trống";
        }


        public void createHeadTextRoom()
        {
            //dtgvShow.Columns[0].HeaderText = "Mã phòng";
            //dtgvShow.Columns[1].HeaderText = "Trạng thái";
            //dtgvShow.Columns[2].HeaderText = "Mã loại phòng";

            dataTableRoom.Columns.Add("Mã phòng");
            dataTableRoom.Columns.Add("Trạng thái");
            dataTableRoom.Columns.Add("Mã loại phòng");
        }


        public void initCbxFilterAllRoom()
        {
            FormHelpers.initCbxFilter(cbbFilterIDRoom, 0, dtgvShowRoom);
            FormHelpers.initCbxFilter(cbbFilterStateRoom, 1, dtgvShowRoom);
            FormHelpers.initCbxFilter(cbbFilterIDTypeRoom, 2, dtgvShowRoom);
        }
        #endregion




        //-----------------------------------------------------------------------------------

        #region event TabPageRoom
        int index = -1;

        private void dtgvShowRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= roomList.Count)
                return;
        }


        //private void btnAddRoom_Click(object sender, EventArgs e)
        //{
        //    RoomInfoUI roomInfoUI = new RoomInfoUI(this);
        //    Room room = new Room();
        //    string id = (roomBus.getLength() + 1).ToString("D2");
        //    room.Id = "R1" + id;
        //    roomInfoUI.fillData(room, "Thêm phòng");
        //    roomInfoUI.ShowDialog();
        //}


        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= roomList.Count)
            {
                MessageBox.Show("Bạn chưa chọn phòng nào.");
                return;
            }

            string id = roomList[index].Id;
            int status = roomList[index].Status;
            string roomTypeID = roomList[index].RoomTypeID;

            Room2 room = new Room2(id, status, roomTypeID);

            RoomInfoUI roomInfo = new RoomInfoUI(this);
            roomInfo.fillData(room, "Cập nhật phòng");
            roomInfo.ShowDialog();
            index = -1;
        }


        //private void btnDeleteRoom_Click(object sender, EventArgs e)
        //{
        //    if (index < 0 || index >= roomList.Count)
        //    {
        //        MessageBox.Show("Bạn chưa chọn phòng nào");
        //        return;
        //    }

        //    string id = roomList[index].Id;

        //    if (MessageBox.Show("Bạn có muốn xóa phòng này không", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        string status = checkStatus(roomList[index].Status);

        //        if (status == "Trống")
        //        {
        //            if (roomBus.delete(id) > 0)
        //            {
        //                MessageBox.Show("Xóa phòng thành công");
        //                initTable();
        //                index = -1;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Phòng này hiện đang được sử dụng không thể xóa");
        //        }
        //    }
        ////}


        private void btnFilterRoom_Click(object sender, EventArgs e)
        {
            string id = cbbFilterIDRoom.Text;
            string status = cbbFilterStateRoom.Text;
            string typeID = cbbFilterIDTypeRoom.Text;

            bindingSourceRoom.Filter = @$"
            `Mã phòng` like '%{id}%' and
            `Trạng thái` like '%{status}%' and
            `Mã loại phòng` like '%{typeID}%'";

            dtgvShowRoom.DataSource = bindingSourceRoom;
            initCbxFilterAllRoom();
        }


        private void btnDeleteFilterIDRoom_Click(object sender, EventArgs e)
        {
            cbbFilterIDRoom.Text = string.Empty;
        }

        private void btnDeleteFilterStatusRoom_Click(object sender, EventArgs e)
        {
            cbbFilterStateRoom.Text = string.Empty;
        }

        private void btnDeleteFilterIDTypeRoom_Click(object sender, EventArgs e)
        {
            cbbFilterIDTypeRoom.Text = string.Empty;
        }

        private void btnDeleteAllFilterRoom_Click(object sender, EventArgs e)
        {
            cbbFilterIDRoom.Text = string.Empty;
            cbbFilterStateRoom.Text = string.Empty;
            cbbFilterIDTypeRoom.Text = string.Empty;
        }
        #endregion


        //-----------------------------------------------------------------------------------



        #region method TabPageRoomType
        public void initTableRoomType()
        {
            dataTableRoomType.Rows.Clear();
            dtgvShowRoomType.DataSource = null;
            roomTypeList = new List<RoomType2>();
            roomTypeList = roomTypeBus.getAll();
            foreach (RoomType2 roomType in roomTypeList)
            {
                dataTableRoomType.Rows.Add(roomType.Id, roomType.Name, roomType.UnitPrice);
            }

            dtgvShowRoomType.DataSource = dataTableRoomType;
            bindingSourceRoomType.DataSource = dataTableRoomType;
            initCbxFilterAllRoomType();
        }

        public void createHeadTextRoomType()
        {
            //dtgvShow.Columns[0].HeaderText = "Mã phòng";
            //dtgvShow.Columns[1].HeaderText = "Trạng thái";
            //dtgvShow.Columns[2].HeaderText = "Mã loại phòng";

            dataTableRoomType.Columns.Add("Mã loại phòng");
            dataTableRoomType.Columns.Add("Tên loại phòng");
            dataTableRoomType.Columns.Add("Giá loại phòng");
        }

        public void initCbxFilterAllRoomType()
        {
            FormHelpers.initCbxFilter(cbbFilterIDRoomType, 0, dtgvShowRoomType);
            FormHelpers.initCbxFilter(cbbFilterNameRoomType, 1, dtgvShowRoomType);
        }
        #endregion



        //-----------------------------------------------------------------------------------

        #region event TabPageRoomType

        int index1 = -1;

        private void dtgvShowRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index1 = e.RowIndex;
            if (index1 < 0 || index1 >= roomList.Count)
                return;
        }

        private void btnFilterRoomType_Click(object sender, EventArgs e)
        {
            string id = cbbFilterIDRoomType.Text;
            string name = cbbFilterNameRoomType.Text;

            bindingSourceRoomType.Filter = @$"
            `Mã loại phòng` like '%{id}%' and
            `Tên loại phòng` like '%{name}%'";

            dtgvShowRoomType.DataSource = bindingSourceRoomType;
            initCbxFilterAllRoomType();
        }

        private void btnDeleteFilterIDRoomType_Click(object sender, EventArgs e)
        {
            cbbFilterIDRoomType.Text = string.Empty;
        }

        private void btnDeleteFilterNameRoomType_Click(object sender, EventArgs e)
        {
            cbbFilterNameRoomType.Text = string.Empty;
        }

        private void btnDeleteAllFilterRoomType_Click(object sender, EventArgs e)
        {
            cbbFilterIDRoomType.Text = string.Empty;
            cbbFilterNameRoomType.Text = string.Empty;
        }


        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            RoomTypeInfoUI roomTypeInfoUI = new RoomTypeInfoUI(this);
            RoomType2 roomType = new RoomType2();
            string chuoi = roomTypeBus.getMaxID().Substring(2);
            string id = (Convert.ToInt64(chuoi) + 1).ToString("D2");
            roomType.Id = "RT" + id;
            roomTypeInfoUI.fillData(roomType, "Thêm loại phòng");
            roomTypeInfoUI.ShowDialog();
        }

        private void btnEditRoomType_Click(object sender, EventArgs e)
        {
            if (index1 < 0 || index1 >= roomTypeList.Count)
            {
                MessageBox.Show("Bạn chưa chọn loại phòng nào.");
                return;
            }

            string id = roomTypeList[index1].Id;
            string name = roomTypeList[index1].Name;
            double price = roomTypeList[index1].UnitPrice;

            RoomType2 roomType = new RoomType2(id, name, price);

            RoomTypeInfoUI roomTypeInfo = new RoomTypeInfoUI(this);
            roomTypeInfo.fillData(roomType, "Cập nhật loại phòng");
            roomTypeInfo.ShowDialog();
            index1 = -1;
        }

        private void btnDeleteRoomType_Click(object sender, EventArgs e)
        {
            convinience_RoomTypeList = convinience_RoomTypeBus.getAll();
            if (index1 < 0 || index1 >= roomTypeList.Count)
            {
                MessageBox.Show("Bạn chưa chọn loại phòng nào");
                return;
            }

            string id = roomTypeList[index1].Id;

            if (MessageBox.Show("Bạn có muốn xóa loại phòng này không", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (var conv_room in convinience_RoomTypeList)
                {
                    if (id == conv_room.RoomTypeID)
                    {
                        MessageBox.Show("Loại phòng này hiện đang có tiện nghi, bạn nên xóa tiện nghi khỏi loại phòng này trước khi xóa loại phòng");
                        return;
                    }
                }
                if (roomTypeBus.delete(id) > 0)
                {
                    MessageBox.Show("Xóa loại phòng thành công");
                    initTableRoomType();
                    index = -1;
                }
            }
        }

        #endregion





        //---------------------------------------------------------------------

        #region method TabPageConvinience

        public void initTableConvinience()
        {
            dataTableConvinience.Rows.Clear();
            dtgvShowConvinience.DataSource = null;
            convinienceList = new List<Convinience2>();
            convinienceList = convinienceBUS.getAll();

            foreach (Convinience2 conv in convinienceList)
            {
                dataTableConvinience.Rows.Add(conv.Id, conv.Name);
            }

            dtgvShowConvinience.DataSource = dataTableConvinience;
            bindingSourceConvinience.DataSource = dataTableConvinience;
            initCbxFilterAllConvinience();
        }

        public void createHeadTextConvinience()
        {
            dataTableConvinience.Columns.Add("Mã tiện nghi");
            dataTableConvinience.Columns.Add("Tên tiện nghi");
        }

        public void initCbxFilterAllConvinience()
        {
            FormHelpers.initCbxFilter(cbbFilterConvinienceID, 0, dtgvShowConvinience);
            FormHelpers.initCbxFilter(cbbFilterConvinienceName, 1, dtgvShowConvinience);
        }

        #endregion



        #region event TabPageConvinience

        int index2 = -1;

        private void dtgvShowConvinience_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = e.RowIndex;
            if (index2 < 0 || index2 >= convinienceList.Count)
                return;
        }

        private void btnFilterConvinience_Click(object sender, EventArgs e)
        {
            string id = cbbFilterConvinienceID.Text;
            string name = cbbFilterConvinienceName.Text;

            bindingSourceConvinience.Filter = @$"
            `Mã tiện nghi` like '%{id}%' and
            `Tên tiện nghi` like '%{name}%'";

            dtgvShowConvinience.DataSource = bindingSourceConvinience;
            initCbxFilterAllConvinience();
        }

        private void btnDeleteFilterConvinienceID_Click(object sender, EventArgs e)
        {
            cbbFilterConvinienceID.Text = string.Empty;
        }

        private void btnDeleteFilterConvinienceName_Click(object sender, EventArgs e)
        {
            cbbFilterConvinienceName.Text = string.Empty;
        }

        private void btnDeleteAllFilterConvinience_Click(object sender, EventArgs e)
        {
            cbbFilterConvinienceID.Text = string.Empty;
            cbbFilterConvinienceName.Text = string.Empty;
        }


        private void btnAddConvinience_Click(object sender, EventArgs e)
        {
            ConvinienceInfoUI convInfoUI = new ConvinienceInfoUI(this);
            Convinience2 conv = new Convinience2();
            string chuoi = convinienceBUS.getMaxID().Substring(2);
            string id = (Convert.ToInt64(chuoi) + 1).ToString("D2");
            conv.Id = "CO" + id;
            convInfoUI.fillData(conv, "Thêm tiện nghi");
            convInfoUI.ShowDialog();
        }

        private void btnEditConvinience_Click(object sender, EventArgs e)
        {
            if (index2 < 0 || index2 >= convinienceList.Count)
            {
                MessageBox.Show("Bạn chưa chọn loại phòng nào.");
                return;
            }

            string id = convinienceList[index2].Id;
            string name = convinienceList[index2].Name;

            Convinience2 conv = new Convinience2(id, name);

            ConvinienceInfoUI convInfo = new ConvinienceInfoUI(this);
            convInfo.fillData(conv, "Cập nhật tiện nghi");
            convInfo.ShowDialog();
            index2 = -1;
        }

        #endregion





        private void btnDeleteConvinience_Click(object sender, EventArgs e)
        {
            convinienceList = convinienceBUS.getAll();
            if (index2 < 0 || index2 >= convinienceList.Count)
            {
                MessageBox.Show("Bạn chưa chọn tiện nghi nào");
                return;
            }

            string id = convinienceList[index2].Id;

            if (MessageBox.Show("Bạn có muốn xóa loại phòng này không", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (var conv_room in convinience_RoomTypeList)
                {
                    if (id == conv_room.RoomTypeID)
                    {
                        MessageBox.Show("Loại phòng này hiện đang có tiện nghi, bạn nên xóa tiện nghi khỏi loại phòng này trước khi xóa loại phòng");
                        return;
                    }
                }
                if (roomTypeBus.delete(id) > 0)
                {
                    MessageBox.Show("Xóa loại phòng thành công");
                    initTableRoomType();
                    index = -1;
                }
            }
        }
    }
}
