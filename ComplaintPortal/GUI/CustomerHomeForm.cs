using ComplaintPortal.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplaintPortal.GUI
{
    public partial class CustomerHomeForm : Form
    {
        private UserDTO user;
        public CustomerHomeForm(UserDTO user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void RegisterComplaintBtn_Click(object sender, EventArgs e)
        {
            NewComplaintForm form = new NewComplaintForm(user);
            form.ShowDialog();
        }
    }
}
