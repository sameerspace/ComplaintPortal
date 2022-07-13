using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintPortal.DL
{
    internal class DBConnection
    {
        private SqlConnection con;
        public DBConnection()
        {

            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"complaint_db.mdf;Integrated Security=True";

            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="F:\uni work\6th Semester\Software Construction & Design\ComplaintPortal\ComplaintPortal\complaint_db.mdf";Integrated Security=True


            //string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arslan\source\repos\Lect25_W3_LA\Lect25_W3_LA\SCRS_W3.mdf;Integrated Security=True";
            con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con; }
    }
}
