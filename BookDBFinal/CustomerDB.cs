﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookDBFinal
{
    static class CustomerDB
    {
        public static List<Customer> GetAllCustomers()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-2GORGR5;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlCommand getCustomers = new SqlCommand();
            getCustomers.CommandText = "SELECT CustomerID" + ",DateOfBirth" +
                ",FirstName" +
                ",LastName" +
                ",Title";
            getCustomers.Connection = con;

            con.Open();

            SqlDataReader CustomerRdr = getCustomers.ExecuteReader();
            List<Customer> customerList = new List<Customer>();
            while (CustomerRdr.Read())
            {
                Customer tempCustomer = new Customer();
                tempCustomer.CustomerId = Convert.ToInt32(CustomerRdr["CustomerID"]);
                tempCustomer.DateOfBirth = Convert.ToDateTime(CustomerRdr["DateOfBirth"]);
                tempCustomer.FirstName = Convert.ToString(CustomerRdr["FirstName"]);
                tempCustomer.LastName = Convert.ToString(CustomerRdr["LastName"]);
                tempCustomer.Title = Convert.ToString(CustomerRdr["Title"]);
                customerList.Add(tempCustomer);

            }
            con.Close();
            return customerList;
        }
    }

}
