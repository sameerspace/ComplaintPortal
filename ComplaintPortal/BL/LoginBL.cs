using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplaintPortal.DL;
using ComplaintPortal.DTO;
using ComplaintPortal.GUI;


namespace ComplaintPortal.BL
{
    internal class LoginBL
    {
        LoginDL _loginDL;

        public LoginBL()
        {
            _loginDL = new LoginDL();
        }

        public Form VerifyUser(UserDTO user)
        {
            UserDTO? result = _loginDL.VerifyUserFromDB(user);
            if (result == null)
            {
                return new ErrorGUI();
            }
            if(result.Role == "Admin")
            {
                return new AdminForm();
            }
            else if(result.Role == "Employee")
            {
                return new EmployeeForm();
            }
            else
            {
                return new CustomerHomeForm();
            }

        }
    }
}
