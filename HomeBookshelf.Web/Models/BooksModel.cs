﻿using HomeBookshelf.Data;
using System.Collections.Generic;

namespace HomeBookshelf.Web.Models
{
    public class BooksModel 
    {

        public List<Book> Books;
        public List<Location> Locations;
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Genre { get; set; }
        public string Location { get; set; }

    }
}