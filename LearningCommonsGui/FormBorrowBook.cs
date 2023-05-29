﻿using LearningCommonsGui.Models;
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
            LabelBorrowValidation.Visible = false;

            if (ComboSelectedBook.SelectedItem is null)
            {
                LabelBorrowValidation.Text = "No book selected";
                LabelBorrowValidation.Visible = true;
                return;
            }

            var user = Globals.User;
            if (user.Borrowings.Count >= user.BorrowLimit)
            {
                LabelBorrowValidation.Text = "Borrow limit reached";
                LabelBorrowValidation.Visible = true;
                return;
            }

            var selectedIsbn = (ComboSelectedBook.SelectedItem as dynamic).Isbn;
            var book = Globals.Books.Find(x => x.Isbn.Equals(selectedIsbn));

            if (book is null)
            {
                LabelBorrowValidation.Visible = true;
                LabelBorrowValidation.Text = $"Can't find book with ISBN {selectedIsbn}";
                return;
            }

            var borrowDate = DateOnly.FromDateTime(DatePickerBorrowDate.Value);
            var returnDate = DateOnly.FromDateTime(DatePickerReturnDate.Value);

            var borrowResult = user.Borrow(book, borrowDate, returnDate);
            if (borrowResult is not null)
            {
                var dataRow = Globals.BorrowingsDataTable.NewRow();
                dataRow["Title"] = borrowResult.Book.Title;
                dataRow["Author"] = borrowResult.Book.Author;
                dataRow["Penalty"] = borrowResult.ComputePenalty();
                Globals.BorrowingsDataTable.Rows.Add(dataRow);

                this.Close();
                return;
            }

            LabelBorrowValidation.Visible = true;
            LabelBorrowValidation.Text = $"You have reached your borrow limit of {user.BorrowLimit}";
        }
    }
}