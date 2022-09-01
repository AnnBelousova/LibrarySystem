using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_01419012_Project1
{
    class Connection
    {
        string connectionString = @"Server=ANNABELOUSOVA\SQLEXPRESS;Database=LibraryDatabase;
        Trusted_Connection=True;";
        SqlConnection connection;
        public bool connect()
        {
           connection = new SqlConnection(connectionString);
            try
            {
                // connection opens
                 connection.Open();
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
            }
            return true;
        }  
        public bool checkUser(string login, string password)
        {
            string sqlExpression = $"SELECT * FROM Librarian WHERE login = '{login}'";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
                return false;
            while (reader.Read())
            {
                string loginU = reader.GetString(0);
                string passwordU = reader.GetString(1);
                if(passwordU == password)
                {
                    return true;
                }
            }return false;
        }

        public bool add(int ISBN, string Title, string AuthorName, string Categoy, string Status, string Publisher, string DatePublish)
        {
           
            string sqlExpression = $"INSERT INTO book (ISBN, Title, AuthorName, Categoy, Status, Publisher, DatePublish) VALUES ({ISBN},'{Title}','{AuthorName}', '{Categoy}', '{Status}','{Publisher}', '{DatePublish}')";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            int number = command.ExecuteNonQuery();
            return number != 0;
        }

        public Book find(int ISBN)
        {
            string sqlExpression = $"SELECT * FROM book WHERE ISBN = {ISBN}";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
                return null;
                while (reader.Read())
                {
                    int ISBNu = reader.GetInt32(0);
                    if (ISBNu == ISBN)
                    {
                        int isbn = reader.GetInt32(0);
                        string title = reader.GetString(1);
                        string author = reader.GetString(2);
                        string category = reader.GetString(3);
                        string status = reader.GetString(4);
                        string publisher = reader.GetString(5);
                        string datepublish = reader.GetString(6);
                        Book bookN = new Book(isbn, title, author, category, status, publisher, datepublish);
                        return bookN;
                    }
                }
            return null;
        }

        public bool reserve(int ISBN, string Status)
        {
            string sqlExpression = $"UPDATE book SET Status = '{Status}' WHERE ISBN = {ISBN}";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
                return false;
            while (reader.Read())
            {
                int ISBNu = reader.GetInt32(0);
                if (ISBNu == ISBN)
                {
                    return true;
                }
            }
            return false;
        }

        public bool remove(int ISBN)
        {
            string sqlExpression = $"DELETE FROM book WHERE ISBN = {ISBN}";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
                return false;
            while (reader.Read())
            {
                int ISBNu = reader.GetInt32(0);
                if (ISBNu == ISBN)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Book> displayAll()
        {
            List<Book> book = new List<Book>();
            string sqlExpression = $"SELECT * FROM book";
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
                return new List<Book>();
            while (reader.Read())
            {
                int isbn = reader.GetInt32(0);
                string title = reader.GetString(1);
                string author = reader.GetString(2);
                string category = reader.GetString(3);
                string status = reader.GetString(4);
                string publisher = reader.GetString(5);
                string datepublish = reader.GetString(6);
                Book bookN = new Book(isbn, title, author, category, status, publisher, datepublish);
                book.Add(bookN);

            }return book;           
        }

        public bool close()
        {
            if (connection.State == ConnectionState.Open)
            {
                // connection closes
                connection.Close();
            }
            return true;
        }
    }
}
