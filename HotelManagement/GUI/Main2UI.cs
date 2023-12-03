using HotelManagement.Business;
using HotelManagement.Data;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Main2UI : MaterialForm
    {
        //Fields
        private Button currentButton;
        private Form activeForm;
        public Main2UI()
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
            showButton();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelB.Controls.Add(childForm);
            this.panelB.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PermissionRequired(Panel panel)
        {
            panelB.Controls.Clear();
            panel.Controls.Add(new Label()
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Permission Required!"
            });
        }

        private void showButton()
        {
            btnhome.Visible = true;
            btnReservation.Visible = LoginBO.IsPermissionGranted(Permission.UpdateReservation);
            btnRentDetail.Visible = LoginBO.IsPermissionGranted(Permission.UpdateRoomDetails);
            btnInvoice.Visible = LoginBO.IsPermissionGranted(Permission.UpdateInvoice);
            btnRoom.Visible = LoginBO.IsPermissionGranted(Permission.ReadRoom)
                || LoginBO.IsPermissionGranted(Permission.ReadRoomType)
                || LoginBO.IsPermissionGranted(Permission.ReadConvenient);
            btnService.Visible = LoginBO.IsPermissionGranted(Permission.ReadService)
                || LoginBO.IsPermissionGranted(Permission.ReadServiceType);
            btnCustomer.Visible = LoginBO.IsPermissionGranted(Permission.ReadCustomer);
            btnStaff.Visible = LoginBO.IsPermissionGranted(Permission.ReadStaff) || LoginBO.IsPermissionGranted(Permission.ReadRole);
            btnAccount.Visible = LoginBO.IsPermissionGranted(Permission.ReadAccount) || LoginBO.IsPermissionGranted(Permission.ReadPermissionGroup);
            btnStatistic.Visible = true;
            btnLogout.Visible = true;
        }
        private void AddHomeForm()
        {
            if (activeForm != null)
                activeForm.Close();
            panelB.Controls.Clear();
            frmSlideShow homeForm = new frmSlideShow();
            activeForm = homeForm;
            homeForm.TopLevel = false;
            homeForm.AutoScroll = true;
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.Dock = DockStyle.Fill;
            panelB.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void AddReservationForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.UpdateReservation))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                ReservationUI reservationForm = new ReservationUI();
                activeForm = reservationForm;
                reservationForm.AutoScroll = true;
                reservationForm.TopLevel = false;
                reservationForm.FormBorderStyle = FormBorderStyle.None;
                reservationForm.Dock = DockStyle.Fill;
                reservationForm.Show();
                panelB.Controls.Add(reservationForm);
            }
            else PermissionRequired(panelB);
        }

        private void AddRentRoomsForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.UpdateRoomDetails))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                RentRoomsUI roomForm = new RentRoomsUI();
                activeForm = roomForm;
                roomForm.AutoScroll = true;
                roomForm.TopLevel = false;
                roomForm.FormBorderStyle = FormBorderStyle.None;
                roomForm.Dock = DockStyle.Fill;
                roomForm.Show();
                panelB.Controls.Add(roomForm);
            }
            else PermissionRequired(panelB);
        }

        private void AddInvoiceListForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.UpdateInvoice))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                InvoiceListUI invoiceList = new InvoiceListUI();
                activeForm = invoiceList;
                invoiceList.AutoScroll = true;
                invoiceList.TopLevel = false;
                invoiceList.FormBorderStyle = FormBorderStyle.None;
                invoiceList.Dock = DockStyle.Fill;
                invoiceList.Show();
                panelB.Controls.Add(invoiceList);
            }
            else PermissionRequired(panelB);
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

                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                RoomUI rForm = new RoomUI();
                activeForm = rForm;
                rForm.AutoScroll = true;
                rForm.TopLevel = false;
                rForm.FormBorderStyle = FormBorderStyle.None;
                rForm.Dock = DockStyle.Fill;
                rForm.Show();
                panelB.Controls.Add(rForm);
            }
            else PermissionRequired(panelB);
        }

        private void AddServiceForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadService)
                || LoginBO.IsPermissionGranted(Permission.ReadServiceType))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                ServiceUI serviceForm = new ServiceUI();
                activeForm = serviceForm;
                serviceForm.AutoScroll = true;
                serviceForm.TopLevel = false;
                serviceForm.FormBorderStyle = FormBorderStyle.None;
                serviceForm.Dock = DockStyle.Fill;
                serviceForm.Show();
                panelB.Controls.Add(serviceForm);
            }
            else PermissionRequired(panelB);
        }

        private void AddCustomerForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadCustomer))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                CustomerUI customerForm = new CustomerUI();
                activeForm = customerForm;
                customerForm.AutoScroll = true;
                customerForm.TopLevel = false;
                customerForm.FormBorderStyle = FormBorderStyle.None;
                customerForm.Dock = DockStyle.Fill;
                customerForm.Show();
                panelB.Controls.Add(customerForm);
            }
            else PermissionRequired(panelB);
        }

        private void AddStaffOrRoleForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadStaff))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                StaffManagerUI staffForm = new StaffManagerUI();
                activeForm = staffForm;
                staffForm.AutoScroll = true;
                staffForm.TopLevel = false;
                staffForm.FormBorderStyle = FormBorderStyle.None;
                staffForm.Dock = DockStyle.Fill;
                staffForm.Show();
                panelB.Controls.Add(staffForm);
            }
            else if (LoginBO.IsPermissionGranted(Permission.ReadRole))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                RoleManagementUI roleForm = new RoleManagementUI();
                activeForm = roleForm;
                roleForm.AutoScroll = true;
                roleForm.TopLevel = false;
                roleForm.FormBorderStyle = FormBorderStyle.None;
                roleForm.Dock = DockStyle.Fill;
                roleForm.Show();
                panelB.Controls.Add(roleForm);
            }
            else PermissionRequired(panelB);
        }

        private void AddAccountOrPermissionGroupForm()
        {
            if (LoginBO.IsPermissionGranted(Permission.ReadAccount))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                AccountManagerUI accountForm = new AccountManagerUI();
                activeForm = accountForm;
                accountForm.AutoScroll = true;
                accountForm.TopLevel = false;
                accountForm.FormBorderStyle = FormBorderStyle.None;
                accountForm.Dock = DockStyle.Fill;
                accountForm.Show();
                panelB.Controls.Add(accountForm);
            }
            else if (LoginBO.IsPermissionGranted(Permission.ReadPermissionGroup))
            {
                if (activeForm != null)
                    activeForm.Close();
                panelB.Controls.Clear();
                PermissionGroupManagerUI pgForm = new PermissionGroupManagerUI();
                activeForm = pgForm;
                pgForm.AutoScroll = true;
                pgForm.TopLevel = false;
                pgForm.FormBorderStyle = FormBorderStyle.None;
                pgForm.Dock = DockStyle.Fill;
                pgForm.Show();
                panelB.Controls.Add(pgForm);
            }
            else PermissionRequired(panelB);
        }

        private void AddStatistic2Form()
        {
            if (activeForm != null)
                activeForm.Close();
            panelB.Controls.Clear();
            StatisticLayout statsForm = new StatisticLayout();
            activeForm = statsForm;
            statsForm.TopLevel = false;
            statsForm.AutoScroll = true;
            statsForm.FormBorderStyle = FormBorderStyle.None;
            statsForm.Dock = DockStyle.Fill;
            panelB.Controls.Add(statsForm);
            statsForm.Show();
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            AddHomeForm();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            AddReservationForm();
        }

        private void btnRentDetail_Click(object sender, EventArgs e)
        {
            AddRentRoomsForm();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            AddInvoiceListForm();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            AddServiceForm();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddStaffOrRoleForm();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AddAccountOrPermissionGroupForm();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            AddStatistic2Form();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không!", "Đăng xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
