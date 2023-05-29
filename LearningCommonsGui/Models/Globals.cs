using LearningCommonsGui.Models.Borrowers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui.Models
{
    // static class just to hold all the values that should be accessible by all classes
    internal static class Globals
    {
        public static List<Book> Books = new List<Book>();
        public static Person User;
        // the data table for displaying hte borrow history on the dashboard
        public static DataTable BorrowingsDataTable = new DataTable();
        public static int TotalPenalty = 0;
    }
}
