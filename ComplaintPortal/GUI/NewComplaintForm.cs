using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplaintPortal.DTO;
using ComplaintPortal.BL;
using System.Data.SqlClient;

namespace ComplaintPortal.GUI
{
    public partial class NewComplaintForm : Form
    {
        private ComplaintBL _compBL;
        public NewComplaintForm()
        {
            InitializeComponent();
            _compBL = new ComplaintBL();
        }

        private void PostCompBtn_Click(object sender, EventArgs e)
        {
            if (verifyDetails())
            {
                ComplaintDTO compDTO = new ComplaintDTO();
                compDTO.Description = txt_Complaint.Text;
                compDTO.Type = cmb_Complaint.Text.ToString();
                compDTO.Status = "PENDING";
                try
                {
                    _compBL.RegisterCustomerComplaint(compDTO);
                    DialogResult res = MessageBox.Show("Complaint Registered Successfuly !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if(res == DialogResult.OK)
                    {
                        this.Close();
                    }

                }catch(SqlException exception)
                {
                    MessageBox.Show("ERROR : " + exception.ToString());

                }
            }

        }
        private bool verifyDetails()
        {

            if (cmb_Complaint.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose complaint type", "ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_Complaint.Text == String.Empty)
            {
                MessageBox.Show("Please enter complaint details", "ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
