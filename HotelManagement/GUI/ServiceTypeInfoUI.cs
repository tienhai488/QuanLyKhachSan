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
    public partial class ServiceTypeInfoUI : Form
    {
        private bool isEdit = false;
        private ServiceBUS serviceBUS = new ServiceBUS();
        private ServiceUI serviceUI;
        public ServiceTypeInfoUI()
        {
            InitializeComponent();
        }

        public ServiceTypeInfoUI(ServiceUI serviceUI)
        {
            InitializeComponent();
            this.serviceUI = serviceUI;
        }

        #region method
        public void fillData(ServiceType2 serviceType, string type)
        {
            txtId.Text = serviceType.Id;
            txtName.Text = serviceType.Name;

            btnSave.Text = type;
            isEdit = type == "Lưu thông tin" ? true : false;
        }

        public void addType(ServiceType2 serviceType)
        {
            if (serviceBUS.validateType(serviceType))
            {
                int result = serviceBUS.addType(serviceType);
                if (result > 0)
                {
                    MessageBox.Show("Thêm loại dịch vụ thành công!");
                    this.serviceUI.initTypeTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm loại dịch vụ không thành công!");
                }
            }
        }

        public void updateType(ServiceType2 serviceType)
        {
            if (serviceBUS.validateType(serviceType))
            {
                int result = serviceBUS.updateType(serviceType);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật loại dịch vụ thành công!");
                    this.serviceUI.initTypeTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật loại dịch vụ không thành công!");
                }
            }
        }

        #endregion


        #region event


        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;

            ServiceType2 serviceType = new ServiceType2(id, name);
            if (isEdit)
            {
                updateType(serviceType);
            }
            else
            {
                addType(serviceType);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        #endregion
    }
}
