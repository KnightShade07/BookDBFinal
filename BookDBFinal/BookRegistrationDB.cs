﻿using System;
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
           
            
               

                SqlCommand getRegistrations = new SqlCommand();
                getRegistrations.CommandText = "SELECT  CustomerID" + "ISBN" +
                    "RegDate";
                getRegistrations.Connection = con;

                con.Open();

                SqlDataReader Regrdr = getRegistrations.ExecuteReader();
                List<Registration> regList = new List<Registration>();
                while (Regrdr.Read())
                {
                    Registration tempReg = new Registration();
                    
                }

                con.Close();
        }
    }

}
