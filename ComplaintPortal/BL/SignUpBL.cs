using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplaintPortal.DL;
using ComplaintPortal.DTO;

namespace ComplaintPortal.BL
{
    internal class SignUpBL
    {
        SignUpDL _signUpDl;

        public SignUpBL()
        {
            _signUpDl = new SignUpDL();
        }

        public void RegisterUser(UserDTO user)
        {
            try
            {
                _signUpDl.RegisterUserInDB(user);

            }catch(SqlException e)
            {
                throw e;
            }
        }
       
    }
}
