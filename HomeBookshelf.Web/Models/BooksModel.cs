using HomeBookshelf.Data;
using System.Collections.Generic;

namespace HomeBookshelf.Web.Models
{
    public class BooksModel 
    {

        public List<Book> Books;
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        public string Genre { get; set; }
        public string Location { get; set; }

    }
}