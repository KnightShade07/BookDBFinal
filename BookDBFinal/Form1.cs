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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            
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
            book.BookIBSN = TxtISBN.Text;
            book.Price = Decimal.Parse(txtPrice.Text);


            //adds to the database
            BookDB.Add(book);
            

            //close form
            Close();

            //display info
            //AddBookFrm bookFrm = new AddBookFrm();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = cbName.Text;
            customer.LastName = cbName.Text;
            customer.CustomerId = 0; //Placeholder //PRIMARY KEY
            customer.Title = cbBookTitle.Text;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Load all books
            List<Book> allBooks = BookDB.GetAllBooks();

            PopulateBookList(allBooks);
        }

        private void PopulateBookList(List<Book> books)
        {
            foreach(Book book in books)
            {
                cbBookTitle.Items.Add(book);
            }
        }
    }
}
