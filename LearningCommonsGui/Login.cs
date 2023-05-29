using LearningCommonsGui.Models;
using LearningCommonsGui.Models.Borrowers;

namespace LearningCommonsGui
{
    public partial class LoginForm : Form
    {
        string[] idNumbers = new string[] { "s1", "s2", "s3", "e1", "e2", "e3" };

        public LoginForm()
        {
            InitializeComponent();
        }

        // check that ID exists
        private bool ValidateCredentials(string idNumber)
        {
            return idNumbers.Contains(idNumber);
        }

        private void TxtIdNumber_KeyDown(object sender, KeyEventArgs e)
        {
            // handle only if enter is pressed
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            // suppress key to disable warning sound
            e.Handled = true;
            e.SuppressKeyPress = true;

            // fetch id number from text box
            var idNumber = TxtIdNumber.Text;

            // check that input is not empty
            if (String.IsNullOrEmpty(idNumber))
            {
                LabelValidation.Text = "Enter you ID number";
                LabelValidation.Visible = true;
                return;
            }


            if (!ValidateCredentials(idNumber))
            {
                LabelValidation.Text = "Invalid ID";
                LabelValidation.Visible = true;
                return;
            }

            // Instantiate object based on the ID number. Students can only borrow 5 times.
            if (idNumber.StartsWith('s'))
            {
                Globals.User = new Student(idNumber, 5);
            } else
            {
                Globals.User = new Staff(idNumber);
            }

            // Makes sure that next form opens on the same location as the current one
            var loginFormLocation = this.Location;
            var dashboard = new Dashboard
            {
                Location = loginFormLocation,
                StartPosition = FormStartPosition.Manual
            };
            dashboard.Show();
            // Completely close the form when the dashboard is closed after logging in
            dashboard.FormClosing += delegate { this.Close(); };
            this.Hide();
        }
    }
}