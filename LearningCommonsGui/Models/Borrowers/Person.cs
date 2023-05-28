using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui.Models.Borrowers
{
    public class Person
    {
        public int BorrowLimit { get; init;}
        public string IdNumber { get; init; }
        public List<Borrowing> Borrowings { get; } = new List<Borrowing>();
        public Person(string idNumber, int borrowLimit = -1)
        {
            IdNumber = idNumber;
            if (borrowLimit < 1)
            {
                // sentinel value
                BorrowLimit = -1;
                return;
            }

            BorrowLimit = borrowLimit;
        }

        public virtual Borrowing? Borrow(Book book, DateOnly borrowDate, DateOnly returnDate, int loanPeriod = 5)
        {
            var borrowing = new Borrowing(book, borrowDate, returnDate, loanPeriod);
            Borrowings.Add(borrowing);
            return borrowing;
        }

        public int TotalPenalty()
        {
            int total = 0;
            foreach (var borrowing in Borrowings)
            {
                total += borrowing.ComputePenalty();
            }

            return total;
        }
    }
}
