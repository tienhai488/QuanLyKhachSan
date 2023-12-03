using HotelManagement.Business;
using HotelManagement.Data;

using MaterialSkin;
using MaterialSkin.Controls;

using Org.BouncyCastle.Crmf;

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
    public partial class MainUI : MaterialForm
    {
        public MainUI()
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
            addForm();
        }

        private void addForm()
        {
            AddReservationForm();
            AddInvoiceListForm();
            AddRoomForm();
            AddServiceForm();
            AddCustomerForm();
            AddStaffOrRoleForm();
            AddAccountOrPermissionGroupForm();
            AddStatistic2Form();
            AddRentRoomsForm();
        }

        private void PermissionRequired(TabPage page)
        {
            page.Controls.Add(new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Permission Required!"
            });
        }

        private void AddReservationForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.UpdateReservation))
            {
                ReservationUI reservationForm = new ReservationUI();
                reservationForm.TopLevel = false;
                reservationForm.FormBorderStyle = FormBorderStyle.None;
                reservationForm.Dock = DockStyle.Fill;
                reservationForm.Show();
                tabPage2.Controls.Add(reservationForm);
            }
            else PermissionRequired(tabPage2);
        }

        private void AddRentRoomsForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.UpdateRoomDetails))
            {
                RentRoomsUI roomForm = new RentRoomsUI();
                roomForm.TopLevel = false;
                roomForm.FormBorderStyle = FormBorderStyle.None;
                roomForm.Dock = DockStyle.Fill;
                roomForm.Show();
                tabPage3.Controls.Add(roomForm);
            }
            else PermissionRequired(tabPage3);
        }

        private void AddInvoiceListForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.UpdateInvoice))
            {
                InvoiceListUI invoiceList = new InvoiceListUI();
                invoiceList.TopLevel = false;
                invoiceList.FormBorderStyle = FormBorderStyle.None;
                invoiceList.Dock = DockStyle.Fill;
                invoiceList.Show();
                tabPage4.Controls.Add(invoiceList);
            }
            else PermissionRequired(tabPage4);
        }

        private void AddRoomForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadRoom)
                || LoginBO.IsPermissionGranted(Permission.ReadRoomType)
                || LoginBO.IsPermissionGranted(Permission.ReadConvenient))
            {
                /*ServiceUI serviceForm = new ServiceUI();
                serviceForm.TopLevel = false;
                serviceForm.FormBorderStyle = FormBorderStyle.None;
                serviceForm.Dock = DockStyle.Fill;
                serviceForm.Show();
                tabPage5.Controls.Add(serviceForm);*/

                RoomUI rForm = new RoomUI();
                rForm.TopLevel = false;
                rForm.FormBorderStyle = FormBorderStyle.None;
                rForm.Dock = DockStyle.Fill;
                rForm.Show();
                tabPage5.Controls.Add(rForm);
            }
            else PermissionRequired(tabPage5);
        }

        private void AddServiceForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadService)
                || LoginBO.IsPermissionGranted(Permission.ReadServiceType))
            {
                ServiceUI serviceForm = new ServiceUI();
                serviceForm.TopLevel = false;
                serviceForm.FormBorderStyle = FormBorderStyle.None;
                serviceForm.Dock = DockStyle.Fill;
                serviceForm.Show();
                tabPage7.Controls.Add(serviceForm);
            }
            else PermissionRequired(tabPage7);
        }

        private void AddCustomerForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadCustomer))
            {
                CustomerUI customerForm = new CustomerUI();
                customerForm.TopLevel = false;
                customerForm.FormBorderStyle = FormBorderStyle.None;
                customerForm.Dock = DockStyle.Fill;
                customerForm.Show();
                tabPage8.Controls.Add(customerForm);
            }
            else PermissionRequired(tabPage8);
        }

        private void AddStaffOrRoleForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadStaff))
            {
                StaffManagerUI staffForm = new StaffManagerUI();
                staffForm.TopLevel = false;
                staffForm.FormBorderStyle = FormBorderStyle.None;
                staffForm.Dock = DockStyle.Fill;
                staffForm.Show();
                tabPage9.Controls.Add(staffForm);
            }
            else if (LoginBO.IsPermissionGranted(Permission.ReadRole))
            {
                RoleManagementUI roleForm = new RoleManagementUI();
                roleForm.TopLevel = false;
                roleForm.FormBorderStyle = FormBorderStyle.None;
                roleForm.Dock = DockStyle.Fill;
                roleForm.Show();
                tabPage9.Controls.Add(roleForm);
            }
            else PermissionRequired(tabPage9);
        }

        private void AddAccountOrPermissionGroupForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadAccount))
            {
                AccountManagerUI accountForm = new AccountManagerUI();
                accountForm.TopLevel = false;
                accountForm.FormBorderStyle = FormBorderStyle.None;
                accountForm.Dock = DockStyle.Fill;
                accountForm.Show();
                tabPage10.Controls.Add(accountForm);
            }
            else if (LoginBO.IsPermissionGranted(Permission.ReadPermissionGroup))
            {
                PermissionGroupManagerUI pgForm = new PermissionGroupManagerUI();
                pgForm.TopLevel = false;
                pgForm.FormBorderStyle = FormBorderStyle.None;
                pgForm.Dock = DockStyle.Fill;
                pgForm.Show();
                tabPage10.Controls.Add(pgForm);
            }
            else PermissionRequired(tabPage10);
        }

        private void AddStatistic2Form()
        {
            StatisticsUI2 statsForm = new StatisticsUI2();
            statsForm.TopLevel = false;
            statsForm.FormBorderStyle = FormBorderStyle.None;
            statsForm.Dock = DockStyle.Fill;
            tabPage11.Controls.Add(statsForm);
            statsForm.Show();
        }
    }
}