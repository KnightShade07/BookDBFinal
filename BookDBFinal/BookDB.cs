using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BookDBFinal
{
    static class BookDB
    {
        //Gets all the books from the Database.
        //Test
        public static List<Book> GetAllBooks()
        {


            

            SqlCommand getBooks = new SqlCommand();
            getBooks.CommandText = "SELECT Id" +
                ",ISBN" + ",Price" + ",Title";


            getBooks.Connection = con;

            con.Open(); //Communicate to the DB

            SqlDataReader rdr = getBooks.ExecuteReader();
            List<Book> bookList = new List<Book>();
            while (rdr.Read())
            {
                Book temp = new Book();
                temp.BookIBSN = Convert.ToString(rdr["ISBN"]);
                temp.Price = Convert.ToDouble(rdr["Price"]);
                temp.Title = Convert.ToString(rdr["Title"]);
                bookList.Add(temp);
            }

            con.Close(); //closes the connection to the database.
            return bookList;
            
        }

        
    } 


    }

