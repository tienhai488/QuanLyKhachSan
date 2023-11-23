namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data.Transfer;

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class AccountInfoUI : UserControl
    {
        public AccountInfoUI()
        {
            InitializeComponent();
            Editing = false;
        }

        private bool editing;
        public bool Editing
        {
            get => editing;
            set
            {
                editing = value;
                tbUID.ReadOnly = true;
                if (value)
                {
                    tbUserName.ReadOnly = false;
                    tbPassword.ReadOnly = false;
                    var bo = AccountManagerBO.Instance;
                    lbUserNameError.Visible = !bo.IsValidUserName(tbUserName.Text);
                    lbPasswordError.Visible = !bo.IsValidPassword(tbPassword.Text);
                    cbStatus.Enabled = bo.CanDisable;
                }
                else
                {
                    tbUserName.ReadOnly = true;
                    tbPassword.ReadOnly = true;
                    lbUserNameError.Visible = false;
                    lbPasswordError.Visible = false;
                    cbStatus.Enabled = false;
                }
            }
        }

        public void LoadAccount()
        {
            var bo = AccountManagerBO.Instance;
            var a = bo.SelectedAccount;
            if (a == null)
            {
                tbUID.Text = string.Empty;
                tbUserName.Text = string.Empty;
                tbPassword.Text = string.Empty;
                cbStatus.Checked = false;
                cbStatus.Enabled = false;
            }
            else
            {
                tbUID.Text = a.UidString();
                tbUserName.Text = a.UserName;
                tbPassword.Text = a.Password;
                cbStatus.Checked = a.Disabled;
                cbStatus.Enabled = editing && bo.CanDisable;
            }
        }

        public bool CanSaveAccount()
            => Editing && !lbUserNameError.Visible
                && !lbPasswordError.Visible;

        public void SaveAccount()
        {
            var a = AccountManagerBO.Instance.SelectedAccount;
            if (a == null) return;
            a.UserName = tbUserName.Text;
            a.Password = tbPassword.Text;
            a.Disabled = cbStatus.Checked;
            Editing = false;
        }

        private void OnUserNameChanged(object sender, EventArgs e)
            => lbUserNameError.Visible = !AccountManagerBO.Instance.IsValidUserName(tbUserName.Text);

        private void OnPasswordChanged(object sender, EventArgs e)
            => lbPasswordError.Visible = !AccountManagerBO.Instance.IsValidPassword(tbPassword.Text);

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int width = Size.Width - 360, offset = width / 4, value;
            width -= offset << 1;
            value = 16 + offset;
            lbUID.Left = value;
            lbUserName.Left = value;
            lbPassword.Left = value;
            lbStatus.Left = value;
            value = 144 + offset;
            tbUID.Left = value;
            tbUserName.Left = value;
            lbUserNameError.Left = value;
            tbPassword.Left = value;
            lbPasswordError.Left = value;
            cbStatus.Left = value;
            value = 200 + width;
            tbUID.Width = value;
            tbUserName.Width = value;
            tbPassword.Width = value;
        }
    }
}
