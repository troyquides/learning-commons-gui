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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();

            Globals.BorrowingsDataTable.Columns.Add("Title", typeof(string));
            Globals.BorrowingsDataTable.Columns.Add("Author", typeof(string));
            Globals.BorrowingsDataTable.Columns.Add("Date Borrowed", typeof(DateOnly));
            Globals.BorrowingsDataTable.Columns.Add("Date Returned", typeof(DateOnly));
            Globals.BorrowingsDataTable.Columns.Add("Penalty", typeof(string));

            foreach (Borrowing borrowing in Globals.User.Borrowings)
            {
                var dataRow = Globals.BorrowingsDataTable.NewRow();
                dataRow["Title"] = borrowing.Book.Title;
                dataRow["Author"] = borrowing.Book.Author;
                dataRow["Penalty"] = borrowing.ComputePenalty();
                Globals.BorrowingsDataTable.Rows.Add(dataRow);
            }

            DataGridBorrowList.DataSource = Globals.BorrowingsDataTable;
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            var dashboardFormLocation = this.Location;
            var addBookForm = new FormAddBook
            {
                Location = dashboardFormLocation,
                StartPosition = FormStartPosition.Manual
            };
            addBookForm.FormClosing += delegate { this.Show(); };
            addBookForm.Show();
            this.Hide();
        }

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

        private void BtnBorrowBook_Click(object sender, EventArgs e)
        {
            var dashboardFormLocation = this.Location;
            var formBorrowBook = new FormBorrowBook
            {
                Location = dashboardFormLocation,
                StartPosition = FormStartPosition.Manual
            };
            formBorrowBook.FormClosing += delegate { this.Show(); };
            formBorrowBook.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.LabelWelcome.Text = $"Current User: {Globals.User.IdNumber}";
            // make sure that label is always centered regardless of width
            this.LabelWelcome.Left = this.ClientSize.Width / 2 - this.LabelWelcome.Width / 2;
        }
    }
}
