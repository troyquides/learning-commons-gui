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
    public partial class FormBookList : Form
    {
        public FormBookList()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            dt.Columns.Add("ISBN", typeof(string));

            foreach (Book book in Globals.Books)
            {
                var dataRow = dt.NewRow();
                dataRow["Title"] = book.Title;
                dataRow["Author"] = book.Author;
                dataRow["ISBN"] = book.Isbn;
                dt.Rows.Add(dataRow);
            }

            DataGridBookList.DataSource = dt;
        }
    }
}
