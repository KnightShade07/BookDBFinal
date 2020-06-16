using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDBFinal
{
    public partial class AddCustomerFrm : Form
    {
        private List<Customer> allCustomers;
        public AddCustomerFrm()
        {
            InitializeComponent();
        }

        private void btnDBAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = cbCustomerDetails.Text;
            customer.Title = cbBookTitle.Text;
            customer.DateOfBirth = dtpDOB.Value;

            CustomerDB.AddCustomer(customer);
        }

        private void PopulateCustomerList(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                //cbFirstName.Items.Add(customer.FirstName);
                //cbLastName.Items.Add(customer.LastName);

                cbCustomerDetails.Items.Add(Convert.ToString(customer.CustomerId) + " " + customer.FirstName + " " + customer.LastName);
            }
        }

        private void PopulateBookList(List<Book> books)
        {
            foreach (Book book in books)
            {
                cbBookTitle.Items.Add(Convert.ToString(book.Title) + " " + book.Price + " " + book.BookIBSN);
            }
        }

        private void AddCustomerFrm_Load(object sender, EventArgs e)
        {
            allCustomers = CustomerDB.GetAllCustomers();

            PopulateCustomerList(allCustomers);

            //Load all books
            List<Book> allBooks = BookDB.GetAllBooks();

            PopulateBookList(allBooks);
        }
    }
}
