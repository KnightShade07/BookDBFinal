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
        public static List<Registration> RegisterBook()
        {

            SqlConnection dbconnection = DBHelper.GetConnection();


            SqlCommand getRegistrations = new SqlCommand();
            getRegistrations.CommandText = "SELECT ISBN " + 
                ",RegDate " + ",CustomerID " +
                "FROM Registration";

            getRegistrations.Connection = dbconnection;


            dbconnection.Open();

            SqlDataReader Regrdr = getRegistrations.ExecuteReader();
            List<Registration> regList = new List<Registration>();
            while (Regrdr.Read())
            {
                Registration tempReg = new Registration();
                tempReg.ISBN = Convert.ToString(Regrdr["ISBN"]);
                tempReg.RegDate = Convert.ToDateTime(Regrdr["RegDate"]);
                tempReg.CustomerID = Convert.ToInt16(Regrdr["CustomerID"]);
                regList.Add(tempReg);



            }

            dbconnection.Close();
            return regList;
        }

        public static void AddReg(Registration reg)
        {
            SqlConnection dbConnection = DBHelper.GetConnection();

            //Set up a command object (query)
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = dbConnection;
            insertCmd.CommandText = "INSERT INTO Registration(ISBN, RegDate, CustomerID)" +
                                    "VALUES(@ISBN, @RegDate, CustomerID)";

            insertCmd.Parameters.AddWithValue("@ISBN", reg.ISBN);
            insertCmd.Parameters.AddWithValue("@RegDate", reg.RegDate);
            insertCmd.Parameters.AddWithValue("@CustomerID", reg.CustomerID);
            
            



            //Open Connection
            dbConnection.Open();

            //Execute Command
            insertCmd.ExecuteNonQuery();


            //Close Connection
            dbConnection.Close();

        }
    }



}