using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsGui.Models
{
    public class Borrowing
    {
        public static readonly int PenaltyPerDay = 5;
        public int LoanPeriod {  get; init; }
        public DateOnly ExpiryDate {  get; init; }
        public DateOnly BorrowDate { get; set; }
        public DateOnly ReturnDate { get; set; }

        public Book Book { get; }

        public Borrowing(Book book, DateOnly borrowDate, DateOnly returnDate, int loadPeriod)
        {
            // used for checking whether user has already borrowed the book
            Book = book;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            LoanPeriod = loadPeriod;
            ExpiryDate = borrowDate.AddDays(LoanPeriod);
        }

        public int ComputePenalty()
        {
            var totalDays = ReturnDate.DayNumber - ExpiryDate.DayNumber;

            if (totalDays <= 0)
            {
                return 0;
            }

            return PenaltyPerDay * totalDays;
        }
    }
}
