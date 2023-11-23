using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagement.GUI
{
    public partial class ServiceInfoUI : Form
    {
        private bool isEdit = false;
        private ServiceUI serviceUI;
        private ServiceBUS serviceBUS = new ServiceBUS();
        public ServiceInfoUI()
        {
            InitializeComponent();
            initCbxServiceType();
        }

        public ServiceInfoUI(ServiceUI serviceUI)
        {
            InitializeComponent();
            this.serviceUI = serviceUI;
            initCbxServiceType();
        }

        #region method
        public void initCbxServiceType()
        {
            List<ServiceType2> list = serviceBUS.getAllType();
            cbxServiceType.DataSource = null;
            cbxServiceType.DataSource = list;
            cbxServiceType.DisplayMember = "name";
            cbxServiceType.ValueMember = "id";
        }
        public void fillData(Service2 service, string type)
        {
            txtId.Text = service.Id;
            txtName.Text = service.Name;
            txtUnit.Text = service.Unit;
            txtUnitPrice.Text = service.Unit_price.ToString();

            if (service.Service_type_id == "")
            {
                if (service.Service_type_name != "")
                {
                    cbxServiceType.Text = service.Service_type_name;
                }
            }
            else
            {
                cbxServiceType.SelectedValue = service.Service_type_id;
            }

            btnSave.Text = type;
            isEdit = type == "Lưu thông tin" ? true : false;
        }

        public void addService(string id, string name, string unit, string unitPrice, string serviceTypeId)
        {
            if (serviceBUS.validateService(name, unit, unitPrice))
            {
                Service2 service = new Service2(id, name, Double.Parse(unitPrice), unit, serviceTypeId, "");
                int result = serviceBUS.addService(service);
                if (result > 0)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!");
                    this.serviceUI.initServiceTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ không thành công!");
                }
            }
        }

        public void updateService(string id, string name, string unit, string unitPrice, string serviceTypeId)
        {
            if (serviceBUS.validateService(name, unit, unitPrice))
            {
                Service2 service = new Service2(id, name, Double.Parse(unitPrice), unit, serviceTypeId, "");
                int result = serviceBUS.updateService(service);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công!");
                    this.serviceUI.initServiceTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật dịch vụ không thành công!");
                }
            }
        }

        #endregion


        #region event

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string unit = txtUnit.Text;
            string unitPrice = txtUnitPrice.Text;
            string serviceTypeId = cbxServiceType.SelectedValue.ToString();

            if (isEdit)
            {
                updateService(id, name, unit, unitPrice, serviceTypeId);
            }
            else
            {
                addService(id, name, unit, unitPrice, serviceTypeId);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUnit.Text = "";
            txtUnitPrice.Text = "";
            cbxServiceType.SelectedIndex = 0;
        }


        #endregion


    }
}
