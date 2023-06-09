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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();

            // bind the data source of the borrow history DataGrid. Initialize the columns
            Globals.BorrowingsDataTable.Columns.Add("Title", typeof(string));
            Globals.BorrowingsDataTable.Columns.Add("Author", typeof(string));
            Globals.BorrowingsDataTable.Columns.Add("Date Borrowed", typeof(DateOnly));
            Globals.BorrowingsDataTable.Columns.Add("Date Returned", typeof(DateOnly));
            Globals.BorrowingsDataTable.Columns.Add("Loan Period", typeof(int));
            Globals.BorrowingsDataTable.Columns.Add("Penalty", typeof(string));

            DataGridBorrowList.DataSource = Globals.BorrowingsDataTable;
        }

        // show the form to add a book
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            var dashboardFormLocation = this.Location;
            var addBookForm = new FormAddBook
            {
                Location = dashboardFormLocation,
                StartPosition = FormStartPosition.Manual
            };
            // after adding a book, show the dashboard again
            addBookForm.FormClosing += delegate { this.Show(); };
            addBookForm.Show();
            this.Hide();
        }

        // show the form to display the books added
        private void BtnShowBooks_Click(object sender, EventArgs e)
        {
            var dashboardFormLocation = this.Location;
            var formBookList = new FormBookList
            {
                Location = dashboardFormLocation,
                StartPosition = FormStartPosition.Manual
            };
            formBookList.FormClosing += delegate { this.Show(); };
            formBookList.Show();
            this.Hide();
        }

        // show the form to borrow a book
        private void BtnBorrowBook_Click(object sender, EventArgs e)
        {
            var dashboardFormLocation = this.Location;
            var formBorrowBook = new FormBorrowBook
            {
                Location = dashboardFormLocation,
                StartPosition = FormStartPosition.Manual
            };
            formBorrowBook.FormClosing += delegate
            {
                // update the displayed total penalty
                LabelPenaltyValue.Text = Globals.TotalPenalty.ToString();
                this.Show();
            };
            formBorrowBook.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // dynamically show the id number of the logged in user
            this.LabelWelcome.Text = $"Current User: {Globals.User.IdNumber}";
            // make sure that label is always centered regardless of width
            this.LabelWelcome.Left = this.ClientSize.Width / 2 - this.LabelWelcome.Width / 2;
        }
    }
}
