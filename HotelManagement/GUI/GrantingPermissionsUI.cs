namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data;

    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml.Linq;

    public partial class GrantingPermissionsUI : UserControl
    {
        private const int ItemWidth = 240, ItemHeight = 48, TopPadding = 16;
        private CheckBox[]? cbPermissions;
        public GrantingPermissionsUI()
        {
            BigInteger a = 0; a.Equals("");
            InitializeComponent();
            LoadPermissions();
            canEdit = LoginBO.IsPermissionGranted(Permission.GrantPermission);
        }

        private bool canEdit, editing;
        public bool Editing
        {
            get => editing;
            set
            {
                editing = canEdit && value;
                GrantingPermissionsBO.Instance
                    .Editing = editing;
                LoadPermissions();
            }
        }


        public void LoadPermissions()
        {
            var perms = Enum.GetValues<Permission>();
            IDictionary<string, Permission> dict
                = new SortedDictionary<string, Permission>(
                    Comparer<string>.Create(
                        CultureInfo.GetCultureInfo("vi-VN")
                        .CompareInfo.Compare));
            foreach (Permission permission in perms)
                dict.Add(GrantingPermissionsBO.GetPermissionName(permission), permission);
            cbPermissions ??= new CheckBox[perms.Length];
            var bo = GrantingPermissionsBO.Instance;
            var ia = bo.SelectedAccessable;
            var acc = bo.Account;
            var pg = bo.Group;
            int i = 0;
            foreach (var kv in dict)
            {
                var cb = cbPermissions[i];
                if (cb == null)
                {
                    cbPermissions[i] = cb = new CheckBox()
                    {
                        AutoSize = false,
                        Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel),
                        Location = new Point(0, 0),
                        ClientSize = new(ItemWidth, ItemHeight),
                        TabIndex = i,
                        UseVisualStyleBackColor = true
                    };
                    Controls.Add(cb);
                }
                cb.Text = kv.Key;
                cb.Tag = kv.Value;
                if (pg != null)
                {
                    bool granted = pg.IsPermissionGranted(kv.Value);
                    if (granted)
                    {
                        cb.Checked = true;
                        cb.Enabled = ia is PermissionGroup && Editing;
                    }
                    else
                    {
                        cb.Checked = acc != null && acc.IsPermissionGranted(kv.Value);
                        cb.Enabled = acc != null && Editing;
                    }
                }
                else
                {
                    if (acc != null)
                    {
                        cb.Checked = acc.IsPermissionGranted(kv.Value);
                        cb.Enabled = Editing;
                    }
                    else
                    {
                        cb.Checked = false;
                        cb.Enabled = false;
                    }
                }
                ++i;
            }
            OnResize(EventArgs.Empty);
        }

        public void SaveChange()
        {
            if (cbPermissions == null) return;
            IDictionary<Permission, bool> perms
                = new Dictionary<Permission, bool>();
            foreach (var cb in cbPermissions)
                perms.Add((Permission)cb.Tag, cb.Enabled && cb.Checked);
            GrantingPermissionsBO.Instance.SavePermissions(perms);
            Editing = false;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            var s = ClientSize;
            var w = s.Width;
            int column = w / 300;
            if (column < 1) column = 1;
            int width = w / column, leftMargin = (width - ItemWidth) / 2,
                x = 0, y = TopPadding, i = 1;
            if (cbPermissions != null)
            {
                foreach (var cb in cbPermissions)
                {
                    cb.Location = new(x + leftMargin, y);
                    cb.ClientSize = new(ItemWidth, ItemHeight);
                    if (i < column)
                    {
                        x += width;
                        ++i;
                    }
                    else
                    {
                        x = 0;
                        y += ItemHeight;
                        i = 1;
                    }
                }
                if ((uint)(i - 2) < (uint)column) y += ItemHeight;
            }
            y += TopPadding;
            s.Height = y;
            ClientSize = s;
        }
    }
}
