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
        public static string InputChecker(string[] choices, string? input)
        {
            while (input == null || !Array.Exists(choices, element => element == input))
            {
                var choicesString = choices.ToString();
                Console.Write($"Please input a valid value [{string.Join(", ", choices)}]: ");
                input = Console.ReadLine();
            }

            return input;
        }

        public static string NullChecker(string? input)
        {
            while (input == null)
            {
                Console.Write("Please input a valid value: ");
                input = Console.ReadLine();
            }

            return input;
        }

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
