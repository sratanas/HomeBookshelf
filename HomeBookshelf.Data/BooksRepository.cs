using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HomeBookshelf.Data
{
    public class BooksRepository : IBooksRepository
    {

        private DBConnection connection;

        public BooksRepository(DBConnection bookshelfConnection)
        {
            this.connection = bookshelfConnection;
        }

        public List<Book> GetBooks()
        {

            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                List<Book> bookList = new List<Book>();

                string query = @"GetAllBookInfo";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        var book = new Book();
                        Author author = new Author();


                        book.Title = reader["Title"].ToString();
                        book.AuthorFirstName = reader["FirstName"].ToString();
                        book.AuthorLastName = reader["LastName"].ToString();
                        book.Genre = reader["GenreName"].ToString();
                        book.YearPublished = Int32.Parse(reader["YearPublished"].ToString());
                        book.Location = reader["LocationName"].ToString();

                        bookList.Add(book);
                    }

                }


                return bookList;
            }
        }

        public List<Location> GetLocations()
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                List<Location> LocationList = new List<Location>();

                string query = @"GetAllLocations";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        var location = new Location();

                        location.Id = Int32.Parse(reader["Id"].ToString());
                        location.LocationName = reader["LocationName"].ToString();
                        

                        LocationList.Add(location);
                    }

                }


                return LocationList;
            }
        }

        public void AddBook(Book newBook, Author newAuthor)
        {
            using (SqlConnection connection = DBConnection.GetSqlConnection())
            {
                Book book = new Book();
                Author author = new Author();

                string query = @"AddNewBook";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Title", newBook.Title);
                command.Parameters.AddWithValue("@YearPublished", newBook.YearPublished);
                command.Parameters.AddWithValue("@AuthorFirstName", newAuthor.FirstName);
                command.Parameters.AddWithValue("@AuthorLastName", newAuthor.LastName);
                //command.Parameters.AddWithValue("@Genre", newBook.Genre);
                //command.Parameters.AddWithValue("@Location", newBook.Location);

                command.ExecuteNonQuery();

            }
        }
    }
}
