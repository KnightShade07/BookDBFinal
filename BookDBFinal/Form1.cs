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
    //TODO: Transfer Add Customer, Add Book and Add Regististrations
    //To seperate forms.
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
            Registration regBook = new Registration();
            //implementation of string splitting.
            String[] custInput = cbCustomerDetails.Text.Split(' ');
            regBook.CustomerID = Convert.ToInt16(custInput[0]);
            regBook.ISBN = cbISBN.Text;
            regBook.RegDate = dtPickerBookDate.Value;
            BookRegistrationDB.AddReg(regBook);
            ClearFrm();
       
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

            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = cbCustomerDetails.Text;
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

                cbCustomerDetails.Items.Add(Convert.ToString(customer.CustomerId) + " " + customer.FirstName + " " + customer.LastName);
            }
        }

        private void PopulateRegList(List<Registration> registrations)
        {
            foreach (Registration registration in registrations)
            {
                cbISBN.Items.Add(registration.ISBN);

            }
        }
        public void ClearFrm()
        {
            cbCustomerDetails.Text = "";
        }

        private void btnViewCustomerList_Click(object sender, EventArgs e)
        {
            Form2 customer = new Form2();
            customer.ShowDialog();
        }
    }
}