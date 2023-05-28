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
            if (e.KeyCode != Keys.Enter || TxtIdNumber is null)
            {
                return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;

            bool isValidId = ValidateCredentials(TxtIdNumber.Text);

            if (!isValidId)
            {
                LabelValidation.Visible = true;
                return;
            }
            LabelValidation.Visible = false;

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