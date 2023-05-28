using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui.Models.Borrowers
{
    internal class Student: Person
    {
        public Student(string idNumber) : base(idNumber, 1) { }

        public override Borrowing? Borrow(Book book, DateOnly borrowDate, DateOnly returnDate, int loanPeriod = 1)
        {
            if (this.Borrowings.Count >= BorrowLimit)
            {
                return null;
            }

            var borrowing = new Borrowing(book, borrowDate, returnDate, loanPeriod);
            Borrowings.Add(borrowing);
            return borrowing;
        }

        protected Borrowing? GetBorrowingFromBorrowedItems(Book book)
        {
            return this.Borrowings.Find(x => x.Book.Isbn.Equals(book.Isbn));
        }
    }
}
