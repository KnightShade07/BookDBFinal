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
    public partial class AddBookFrm : Form
    {
        public AddBookFrm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Book> allBooks = BookDB.GetAllBooks();

            PopulateBookList(allBooks);
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

        private void btnDBAddBook_Click(object sender, EventArgs e)
        {
            //Creates Book Object
            Book book = new Book();
            book.Title = cbBookTitle.Text;
            book.BookIBSN = cbISBN.Text;
            book.Price = Decimal.Parse(cbPrice.Text);


            //adds to the database
            BookDB.Add(book);
        }
    }
}
