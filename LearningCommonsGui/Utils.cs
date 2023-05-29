using LearningCommonsGui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui
{
    internal class Utils
    {
        // utility method to check for duplicated ISBN
        public static Boolean CheckDuplicateIsbn(List<Book> books, string isbn)
        {
            if (!books.Any())
            {
                return false;
            }

            foreach (Book book in books)
            {
                if (book.Isbn.Equals(isbn))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
