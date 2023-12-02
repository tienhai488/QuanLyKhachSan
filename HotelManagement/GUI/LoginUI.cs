namespace HotelManagement
{
    using HotelManagement.Business;
    using HotelManagement.GUI;

    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();

            MinimumSize = SizeFromClientSize(new(384, 384));
            LoadDefault();
        }

        private void LoadDefault()
        {
            tbUserName.Text = string.Empty;
            tbPassword.Text = string.Empty;
            txtUserNameError.Visible = false;
            txtPasswordError.Visible = false;
            txtLoginFailed.Visible = false;
            btnLogin.Enabled = false;
        }

        private void OnUserNameChanged(object sender, EventArgs e)
        {
            var bo = LoginBO.Instance;
            bo.UserName = tbUserName.Text;
            if (!bo.IsValidUserName)
            {
                txtUserNameError.Visible = true;
                btnLogin.Enabled = false;
            }
            else
            {
                txtUserNameError.Visible = false;
                btnLogin.Enabled = bo.IsValidPassword;
            }
            txtLoginFailed.Visible = false;
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            var bo = LoginBO.Instance;
            bo.Password = tbPassword.Text;
            if (!bo.IsValidPassword)
            {
                txtPasswordError.Visible = true;
                btnLogin.Enabled = false;
            }
            else
            {
                txtPasswordError.Visible = false;
                btnLogin.Enabled = bo.IsValidPassword;
            }
            txtLoginFailed.Visible = false;
        }

        private void OnSignIn(object sender, EventArgs e)
        {
            var bo = LoginBO.Instance;
            if (bo.SignIn())
            {
                Hide();
                new MainUI().ShowDialog();
                LoginBO.SignOut();
                LoadDefault();
                Show();
            }
            else txtLoginFailed.Visible = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (pnLogin is not null)
            {
                Size a = ClientSize, b = pnLogin.ClientSize;
                int x = (a.Width - b.Width) / 2,
                    y = (a.Height - b.Height) / 2;

                pnLogin.Location = new(x, y);
            }
        }
    }
}