using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui.Models
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string isbn, string title, string author)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
        }

        
        // Formatted text dislayed on the options of the combo box when borrowing a book @see FormBorrowBook.cs
        public string DisplayName
        {
            get
            {
                return $"{Title} by {Author} ({Isbn})";
            }
        }
    }
}
