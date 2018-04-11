﻿namespace HomeBookshelf.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public int AuthorId { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        public string Genre { get; set; }
        public string Location { get; set; }

    }
}
