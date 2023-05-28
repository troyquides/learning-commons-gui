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

        private bool ValidateCredentials(string idNumber)
        {
            return idNumbers.Contains(idNumber);
        }

        private void TxtIdNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;

            var idNumber = TxtIdNumber.Text;

            if (String.IsNullOrEmpty(idNumber))
            {
                LabelValidation.Text = "Enter you ID number";
                LabelValidation.Visible = true;
                return;
            }

            if (!ValidateCredentials(idNumber))
            {
                LabelValidation.Visible = true;
                return;
            }
            LabelValidation.Visible = false;

            if (idNumber.StartsWith('s'))
            {
                Globals.IsStudent = true;
                Globals.User = new Student(idNumber);
            } else
            {
                Globals.User = new Staff(idNumber);
            }

            var loginFormLocation = this.Location;
            var dashboard = new Dashboard
            {
                Location = loginFormLocation,
                StartPosition = FormStartPosition.Manual
            };
            dashboard.Show();
            dashboard.FormClosing += delegate { this.Close(); };
            this.Hide();
        }
    }
}