using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDBFinal
{

    public partial class AddBookFrm : Form
    {
        private List<Customer> allCustomers;
        
        public AddBookFrm()
        {
            InitializeComponent();
        }

        private void cbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = DBHelper.GetConnection();
            SqlCommand getCustomerID = new SqlCommand();

            getCustomerID.CommandText = "SELECT CustomerID" +
                "FROM Customer" +
                "WHERE FirstName = " + cbFirstName.Text + "AND LastName = " + cbLastName.Text;
            getCustomerID.Connection = dbConnection;
            

            Registration regBook = new Registration();
            regBook.ISBN = cbISBN.Text;
            regBook.RegDate = dtPickerBookDate.Value;
            BookRegistrationDB.AddReg(regBook);
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtPickerBookDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            //Creates Book Object
            Book book = new Book();
            book.Title = cbBookTitle.Text;
            book.BookIBSN = cbISBN.Text;
            book.Price = Decimal.Parse(cbPrice.Text);


            //adds to the database
            BookDB.Add(book);


            //close form
            Close();

            //displays info and creates a form
            AddBookFrm addBookFrm = new AddBookFrm();
            addBookFrm.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = cbFirstName.Text;
            customer.LastName = cbLastName.Text;
            customer.Title = cbBookTitle.Text;
            customer.DateOfBirth = dtpDOB.Value;

            CustomerDB.AddCustomer(customer);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Load all books
            List<Book> allBooks = BookDB.GetAllBooks();

            PopulateBookList(allBooks);

            //Load all customers

            allCustomers = CustomerDB.GetAllCustomers();

            PopulateCustomerList(allCustomers);

            //Load all Registrations

            List<Registration> allRegistrations = BookRegistrationDB.RegisterBook();

            PopulateRegList(allRegistrations);
        }

        private void PopulateBookList(List<Book> books)
        {
            foreach (Book book in books)
            {
                cbBookTitle.Items.Add(book.Title);
                cbISBN.Items.Add(book.BookIBSN);
                cbPrice.Items.Add(book.Price);
            }
        }

        private void PopulateCustomerList(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                //cbFirstName.Items.Add(customer.FirstName);
                //cbLastName.Items.Add(customer.LastName);

                cbFirstName.Items.Add(Convert.ToString(customer.CustomerId) + " " + customer.FirstName + " " + customer.LastName);
            }
        }

        private void PopulateRegList(List<Registration> registrations)
        {
            foreach (Registration registration in registrations)
            {
                cbISBN.Items.Add(registration.ISBN);

            }
        }
    }
}