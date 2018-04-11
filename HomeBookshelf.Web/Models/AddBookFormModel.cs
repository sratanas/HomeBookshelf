using HomeBookshelf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeBookshelf.Web.Models
{
    public class AddBookFormModel
    {
        public List<Location> Locations;
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        public int AuthorId { get; set; }
        public string Genre { get; set; }
        public string Location { get; set; }
    }
}