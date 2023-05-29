using LearningCommonsGui.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCommonsGui
{
    public partial class FormBorrowBook : Form
    {
        public FormBorrowBook()
        {
            InitializeComponent();
            var borrowedBooks = Globals.User.Borrowings.Select(borrowing => borrowing.Book).ToList();
            var borrowableBooks = Globals.Books.Except(borrowedBooks).ToList();
            ComboSelectedBook.DataSource = borrowableBooks;
            ComboSelectedBook.DisplayMember = "DisplayName";
        }

        private void BtnSubmitBorrow_Click(object sender, EventArgs e)
        {
            // reset validation text on every attempt
            LabelBorrowValidation.Visible = false;

            // validation for no book selected
            if (ComboSelectedBook.SelectedItem is null)
            {
                LabelBorrowValidation.Text = "No book selected";
                LabelBorrowValidation.Visible = true;
                return;
            }

            // use dynamic to access the underlying Book object for the selected item
            var selectedIsbn = (ComboSelectedBook.SelectedItem as dynamic).Isbn;
            var book = Globals.Books.Find(x => x.Isbn.Equals(selectedIsbn));

            // handle the exceptional case that no book matches the ISBN from the combo box
            if (book is null)
            {
                LabelBorrowValidation.Text = "Invalid book.";
                LabelBorrowValidation.Visible = true;
                return;
            }

            var borrowDate = DateOnly.FromDateTime(DatePickerBorrowDate.Value);
            var returnDate = DateOnly.FromDateTime(DatePickerReturnDate.Value);

            // ensure that the return and borrow date makes logical sense
            if (borrowDate >= returnDate)
            {
                LabelBorrowValidation.Visible = true;
                LabelBorrowValidation.Text = "Borrow date must be before the return date";
                return;
            }

            // Borrow method called will depend the the type of Person
            var user = Globals.User;
            var borrowResult = user.Borrow(
                book,
                borrowDate,
                returnDate,
                Decimal.ToInt32(NumericLoanPeriod.Value)
            );

            // Borrow returns null borrowing is unsuccessful
            if (borrowResult is not null)
            {
                // on successful borrow, append it to the user's borrow history on the dashboard
                var penalty = borrowResult.ComputePenalty();
                var dataRow = Globals.BorrowingsDataTable.NewRow();
                dataRow["Title"] = borrowResult.Book.Title;
                dataRow["Author"] = borrowResult.Book.Author;
                dataRow["Date Borrowed"] = borrowResult.BorrowDate;
                dataRow["Date Returned"] = borrowResult.ReturnDate;
                dataRow["Loan Period"] = borrowResult.LoanPeriod;
                dataRow["Penalty"] = penalty;
                Globals.BorrowingsDataTable.Rows.Add(dataRow);
                Globals.TotalPenalty = Globals.User.TotalPenalty();

                // hide this form then switch back to the dashboard
                this.Close();
                return;
            }

            // negative test case borrow unsuccessful
            LabelBorrowValidation.Visible = true;
            LabelBorrowValidation.Text = $"You have reached your borrow limit of {user.BorrowLimit}";
        }
    }
}
