using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui.Models.Borrowers
{
    public class Student: Person
    {
        public Student(string idNumber, int borrowLimit) : base(idNumber, borrowLimit) { }

        public override Borrowing? Borrow(Book book, DateOnly borrowDate, DateOnly returnDate, int loanPeriod = 1)
        {
            // we check for borrow limit for student objects. This guard clause is not present in
            // Person or Staff class
            if (this.Borrowings.Count >= BorrowLimit)
            {
                return null;
            }

            var borrowing = new Borrowing(book, borrowDate, returnDate, loanPeriod);
            Borrowings.Add(borrowing);
            return borrowing;
        }
    }
}
