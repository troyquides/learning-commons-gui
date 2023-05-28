using LearningCommonsGui.Models.Borrowers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui.Models
{
    internal static class Globals
    {
        public static List<Book> Books = new List<Book>();
        public static Person User;
        public static bool IsStudent = false;
        public static DataTable BorrowingsDataTable = new DataTable();
    }
}
