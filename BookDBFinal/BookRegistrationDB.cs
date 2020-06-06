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
                getRegistrations.CommandText = "SELECT  CustomerId" + "ISBN";
               

                dbconnection.Open();

                SqlDataReader Regrdr = getRegistrations.ExecuteReader();
                List<Registration> regList = new List<Registration>();
                while (Regrdr.Read())
                {
                    Registration tempReg = new Registration();
                    tempReg.CustomerId = Convert.ToInt32(Regrdr["CustomerId"]);
                    tempReg.ISBN = Convert.ToString(Regrdr["ISBN"]);
                    regList.Add(tempReg);
                    

                    
                }

                dbconnection.Close();
        }

        public static void AddReg(Registration reg)
        {

        }
    }

    

}
