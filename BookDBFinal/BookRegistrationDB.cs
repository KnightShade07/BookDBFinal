using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookDBFinal
{
    static class BookRegistrationDB
    {
        public static void RegisterBook()
        {

            SqlConnection dbconnection = DBHelper.GetConnection();
               

                SqlCommand getRegistrations = new SqlCommand();
                getRegistrations.CommandText = "SELECT  CustomerId" + ",ISBN " +",RegDate " +
                "FROM Registration";

            getRegistrations.Connection = dbconnection;
               

                dbconnection.Open();

                SqlDataReader Regrdr = getRegistrations.ExecuteReader();
                List<Registration> regList = new List<Registration>();
                while (Regrdr.Read())
                {
                    Registration tempReg = new Registration();
                    tempReg.CustomerId = Convert.ToInt32(Regrdr["CustomerId"]);
                    tempReg.ISBN = Convert.ToString(Regrdr["ISBN"]);
                    tempReg.RegDate = Convert.ToDateTime(Regrdr["RegDate"]);
                    regList.Add(tempReg);
                    

                    
                }

                dbconnection.Close();
        }

        public static void AddReg(Registration reg)
        {
            SqlConnection dbConnection = DBHelper.GetConnection();

            //Set up a command object (query)
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = dbConnection;
            insertCmd.CommandText = "INSERT INTO Registration(CustomerId, ISBN, RegDate)" +
                                    "VALUES(@CustomerId, @ISBN, @RegDate)";

            insertCmd.Parameters.AddWithValue("@CustomerId", reg.CustomerId);
            insertCmd.Parameters.AddWithValue("@ISBN", reg.ISBN);
            insertCmd.Parameters.AddWithValue("@RegDate", reg.RegDate);

            //Open Connection
            dbConnection.Open();

            //Execute Command
            insertCmd.ExecuteNonQuery();


            //Close Connection
            dbConnection.Close();

        }
    }

    

}
