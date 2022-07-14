using ComplaintPortal.DL;
using ComplaintPortal.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintPortal.BL
{
    internal class ComplaintBL
    {
        private ComplaintDL _compDL;

        public ComplaintBL()
        {
            _compDL = new ComplaintDL();    
        }

        public void RegisterCustomerComplaint(ComplaintDTO complaint)
        {
            try
            {
               _compDL.RegisterCustomerComplaintInDB(complaint);
            }catch(SqlException e)
            {
                throw e;
            }
        }
    }
}
