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
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void BtnSubmitBook_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtIsbn.Text)
                || String.IsNullOrEmpty(TxtBookTitle.Text)
                || String.IsNullOrEmpty(TxtBookAuthor.Text))
            {
                LabelBookValidation.Visible = true;
                LabelBookValidation.Text = "Please fill in all fields.";
                return;
            }


            if (Utils.CheckDuplicateIsbn(Globals.Books, TxtIsbn.Text))
            {
                LabelBookValidation.Visible = true;
                LabelBookValidation.Text = "Duplicate ISBN";
                return;
            }

            var book = new Book(TxtIsbn.Text, TxtBookTitle.Text, TxtBookAuthor.Text);

            Globals.Books.Add(book);
            this.Close();
        }
    }
}
