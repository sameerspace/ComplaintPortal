using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplaintPortal.DTO;

namespace ComplaintPortal.DL
{
    internal class SignUpDL
    {
        DBConnection con;

        public SignUpDL()
        {
            con = new DBConnection();
        }


        public void RegisterUserInDB(UserDTO user)
        {
            con.Con.Open();
            try
            {
                if (user.Address != null)
                {
                    string sql = "INSERT INTO Users(username,password,role,address) VALUES(@username,@password,@role,@address)";
                    SqlCommand com = new SqlCommand(sql, con.Con);
                    com.Parameters.AddWithValue("@username", user.Username);
                    com.Parameters.AddWithValue("@password", user.Password);
                    com.Parameters.AddWithValue("@role", user.Role);
                    com.Parameters.AddWithValue("@address", user.Address);
                    int rows = com.ExecuteNonQuery();
                }
                else
                {
                    string sql = "INSERT INTO Users(username,password,role) VALUES(@username,@password,@role)";
                    SqlCommand com = new SqlCommand(sql, con.Con);
                    com.Parameters.AddWithValue("@username", user.Username);
                    com.Parameters.AddWithValue("@password", user.Password);
                    com.Parameters.AddWithValue("@role", user.Role);
                    int rows = com.ExecuteNonQuery();
                }
               
            }
            catch (SqlException e)
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
