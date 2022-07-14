using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplaintPortal.DTO;

namespace ComplaintPortal.DL
{
    
    internal class LoginDL
    {
        private DBConnection conn;

        public LoginDL()
        {
            conn = new DBConnection();
        }

        public UserDTO? VerifyUserFromDB(UserDTO user)
        {
            conn.Con.Open();
            try
            {
                UserDTO retDto = new UserDTO();
                string sql = "SELECT * FROM Users WHERE Users.username = @username AND Users.password = @password;";
                SqlCommand com = new SqlCommand(sql, conn.Con);
                com.Parameters.AddWithValue("@username", user.Username);
                com.Parameters.AddWithValue("@password", user.Password);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    retDto.Id = reader["Id"].ToString()?.Trim();
                    retDto.Address = reader["username"].ToString()?.Trim();
                    retDto.Password = reader["password"].ToString()?.Trim();    
                    retDto.Role = reader["role"].ToString()?.Trim();    
                    if(retDto.Role == "Customer")
                    {
                        retDto.Address = reader["address"].ToString();
                    }
                    return retDto;

                }
                return null;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Con.Close();
            }
        }

    }
}
