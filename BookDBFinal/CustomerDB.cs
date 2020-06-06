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
            SqlConnection dbConnection = DBHelper.GetConnection();

            SqlCommand getCustomers = new SqlCommand();
            getCustomers.CommandText = "SELECT DateOfBirth " + ",FirstName " +
                ",LastName " +
                ",Title " +
                "FROM Customer";
            getCustomers.Connection = dbConnection;

            

            dbConnection.Open();

            SqlDataReader CustomerRdr = getCustomers.ExecuteReader();
            List<Customer> customerList = new List<Customer>();
            while (CustomerRdr.Read())
            {
                Customer tempCustomer = new Customer();
                tempCustomer.DateOfBirth = Convert.ToDateTime(CustomerRdr["DateOfBirth"]);
                tempCustomer.FirstName = Convert.ToString(CustomerRdr["FirstName"]);
                tempCustomer.LastName = Convert.ToString(CustomerRdr["LastName"]);
                tempCustomer.Title = Convert.ToString(CustomerRdr["Title"]);
                customerList.Add(tempCustomer);

            }

            dbConnection.Close();
            return customerList;
        }

        public static void AddCustomer(Customer customer)
        {
            SqlConnection dbConnection = DBHelper.GetConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = dbConnection;
            insertCmd.CommandText = "INSERT INTO Customer(DateOfBirth,FirstName,LastName,Title)" +
                "VALUES(@DateOfBirth, @FirstName, @LastName, @Title)";

            insertCmd.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
            insertCmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
            insertCmd.Parameters.AddWithValue("@LastName", customer.LastName);
            insertCmd.Parameters.AddWithValue("@Title", customer.Title);

            dbConnection.Open();

            insertCmd.ExecuteNonQuery();

            dbConnection.Close();

        }
    }

}
