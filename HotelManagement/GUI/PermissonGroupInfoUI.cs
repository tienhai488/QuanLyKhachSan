namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data.Transfer;

    using System;
    using System.Windows.Forms;

    public partial class PermissonGroupInfoUI : UserControl
    {
        public PermissonGroupInfoUI()
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
                tbID.ReadOnly = true;
                if (value)
                {
                    tbName.ReadOnly = false;
                    var bo = PermissionGroupManagerBO.Instance;
                    lbNameError.Visible = !bo.IsValidName(tbName.Text);
                }
                else
                {
                    tbName.ReadOnly = true;
                    lbNameError.Visible = false;
                }
            }
        }

        public void LoadGroup()
        {
            var bo = PermissionGroupManagerBO.Instance;
            var a = bo.SelectedGroup;
            if (a == null)
            {
                tbID.Text = string.Empty;
                tbName.Text = string.Empty;
            }
            else
            {
                tbID.Text = a.IdString();
                tbName.Text = a.Name;
            }
        }

        public bool CanSaveGroup()
            => Editing && !lbNameError.Visible;

        public void SaveGroup()
        {
            var a = PermissionGroupManagerBO.Instance.SelectedGroup;
            if (a == null) return;
            a.Name = tbName.Text;
            Editing = false;
        }

        private void OnNameChanged(object sender, EventArgs e)
            => lbNameError.Visible = !PermissionGroupManagerBO.Instance.IsValidName(tbName.Text);

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int width = ClientSize.Width - 360, offset = width / 4, value;
            width -= offset << 1;
            value = 16 + offset;
            lbID.Left = value;
            lbName.Left = value;
            value = 144 + offset;
            tbID.Left = value;
            tbName.Left = value;
            lbNameError.Left = value;
            value = 200 + width;
            tbID.Width = value;
            tbName.Width = value;
        }
    }
}
