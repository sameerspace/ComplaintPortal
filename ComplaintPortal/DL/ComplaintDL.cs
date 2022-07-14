using ComplaintPortal.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ComplaintPortal.DL
{
    internal class ComplaintDL
    {
        DBConnection con;

        public ComplaintDL()
        {
            con = new DBConnection();   
        }

        public void RegisterCustomerComplaintInDB(ComplaintDTO complaint)
        {
            con.Con.Open();
            string sql = "INSERT INTO Complaints(type,description,status,customerId) VALUES(@type,@description,@status,@uid);";
            SqlCommand com = new SqlCommand(sql, con.Con);
            com.Parameters.AddWithValue("@type",complaint.Type);
            com.Parameters.AddWithValue("@description", complaint.Description);
            com.Parameters.AddWithValue("@status", complaint.Status);
            com.Parameters.AddWithValue("@uid",complaint.CustomerID);
            try
            {
                com.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                throw e;
            }
            finally
            {
                con.Con.Close();
            }
        }
    }
}
