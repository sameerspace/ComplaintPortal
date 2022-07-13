using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplaintPortal.BL;
using ComplaintPortal.DTO;

namespace ComplaintPortal
{
    public partial class SignUpForm : Form
    {
        SignUpBL _signUpBL;
        Dictionary<int, string> roles = new Dictionary<int, string>()
        {
            { 0 , "Admin" },
            { 1 , "Employee" },
            { 2 , "Customer"},
        };

        public SignUpForm()
        {
            InitializeComponent();
            _signUpBL = new SignUpBL();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO();
            if (verifyForm())
            {
                userDTO.Username = txt_username.Text;
                userDTO.Password = txt_password.Text;
                userDTO.Role = roles[comboBox1.SelectedIndex];
                if (userDTO.Role == "Customer")
                {
                    if (txt_Address.Text == String.Empty)
                    {
                        MessageBox.Show("Please enter address", "ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    userDTO.Address = txt_Address.Text;
                }

                try
                {
                    _signUpBL.RegisterUser(userDTO);
                    DialogResult res = MessageBox.Show("Sign Up Successful. Please Login.","Success",MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show("ERROR : " + exception.ToString());
                }


            }




        }
        private bool verifyForm()
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose role", "ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txt_password.Text == String.Empty)
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 2)
            {
                txt_Address.Visible = true;
            }
        }
    }
}
