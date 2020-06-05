using System;
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
            DBHelper.GetConnection();

            SqlCommand getCustomers = new SqlCommand();
            getCustomers.CommandText = "SELECT CustomerID" + ",DateOfBirth" +
                ",FirstName" +
                ",LastName" +
                ",Title";
            getCustomers.Connection = DBHelper.GetConnection();

            DBHelper.GetConnection.Open();

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
