using ComplaintPortal.BL;
using ComplaintPortal.DTO;

namespace ComplaintPortal
{
    public partial class LoginForm : Form
    {
        private LoginBL _loginBL;

        public LoginForm()
        {
            InitializeComponent();
            _loginBL = new LoginBL();   
        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.ShowDialog();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (verifyCredentials())
            {
                UserDTO user = new UserDTO();
                user.Username = txt_username.Text;
                user.Password = txt_password.Text;
                _loginBL.VerifyUser(user).ShowDialog();
                
            }
        }
        private bool verifyCredentials()
        {
            if (txt_password.Text == String.Empty)
            {
                MessageBox.Show("Please enter password", "ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_username.Text == String.Empty)
            {
                MessageBox.Show("Please enter username", "ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}