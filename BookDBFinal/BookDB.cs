using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace BookDBFinal
{
    static class BookDB
    {
        //Gets all the books from the Database.
        //Test

        
        public static List<Book> GetAllBooks()
        {


            SqlConnection dbconnection = DBHelper.GetConnection();

            SqlCommand getBooks = new SqlCommand();
            getBooks.CommandText = "SELECT Id" +
                ",ISBN" + ",Price" + ",Title";


            

            dbconnection.Open(); //Communicate to the DB

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

            dbconnection.Close(); //closes the connection to the database.
            return bookList;
            
        }

        public static void Add(Book book)
        {
            //Get a connection to the DB
            SqlConnection dbConnection = DBHelper.GetConnection();

            //Set up a command object (query)
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = dbConnection;
            insertCmd.CommandText = "INSERT INTO BOOK(ISBN, Price, Title) " +
                                    "VALUES(@ISBN, @Price, @Title)";

            insertCmd.Parameters.AddWithValue("@ISBN", book.BookIBSN);
            insertCmd.Parameters.AddWithValue( "@Price", book.Price);
            insertCmd.Parameters.AddWithValue("@Title", book.Title);

            //Open Connection
            dbConnection.Open();

            //Execute Command
            insertCmd.ExecuteNonQuery();


            //Close Connection
            dbConnection.Close();

        }

        public static void Update(Book book)
        {
            throw new NotImplementedException();
        }

        public static void Delete(Book book)
        {
            SqlConnection dbconnection = DBHelper.GetConnection();

            string query = "DELETE FROM Book " +
                "WHERE Id = @ISBN";
            SqlCommand deleteCmd = new SqlCommand(query, dbconnection);
            deleteCmd.Parameters.AddWithValue("@ISBN", book.BookIBSN);

            dbconnection.Open();

            int rows = deleteCmd.ExecuteNonQuery();

            if(rows != 1)
            {
                throw new Exception("A book was not deleted.");
            }

            dbconnection.Close();
        }

    } 


    }

