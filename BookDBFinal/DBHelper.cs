using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookDBFinal
{
    static class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection databaseConnection = new SqlConnection();
            databaseConnection.ConnectionString = "Data Source=DESKTOP-2GORGR5;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return databaseConnection;
        }
    }

}
