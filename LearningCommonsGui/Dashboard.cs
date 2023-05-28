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
    }
}
