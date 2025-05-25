using System.Text.RegularExpressions;
using OWL.Forms;
using OWL.Models;
using OWL.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OWL
{
    public partial class LoginPanel : Form
    {

        private readonly AuthService _authService;

        public LoginPanel()
        {
            InitializeComponent();


            _authService = new AuthService();

            LoginButton.Click += LoginButton_Click;
            LoginBox.TextChanged += ValidateFields;
            PasswordBox.TextChanged += ValidateFields;
        }

        private void ToRegButtonClick(object sender, EventArgs e)
        {

            var currentLocation = this.Location;
            
            this.Hide();


            
            var Registerform = new RegisterPanel();

            Registerform.StartPosition = FormStartPosition.Manual;
            Registerform.Location = currentLocation;

            Registerform.Closed += (s, args) => this.Close();
            Registerform.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateLoginFields()) return;

            try
            {
                bool access = _authService.LoginUser(LoginBox.Text.Trim(), PasswordBox.Text);

                if (access)
                {
                    Session.Instance.Login(LoginBox.Text.Trim());
                    MessageBox.Show("Witaj w OWL! Zalogowano pomyœlnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    AccesGranted(sender, e);
                   
                }
                else
                {
                    HandleFailedLogin(LoginBox.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d: {ex.Message}", "B³¹d",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLoginFields()
        {
            if (string.IsNullOrWhiteSpace(LoginBox.Text) || LoginBox.Text.Length < 4)
            {
                return false;
            }

            if (PasswordBox.Text.Length < 8)
            {
                return false;
            }

            return true;
        }

        private void HandleFailedLogin(string username)
        {
            if (_authService.CheckUser(username))
            {
                MessageBox.Show("Niepoprawne has³o", "B³¹d logowania",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Nie znaleziono u¿ytkownika", "B³¹d logowania",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearForm()
        {
            LoginBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            
            bool loginValid = !string.IsNullOrWhiteSpace(LoginBox.Text) && LoginBox.Text.Length >= 4;
            bool passwordValid = PasswordBox.Text.Length >= 8;

            LoginButton.Enabled = loginValid && passwordValid;
        }

        private void AccesGranted(object sender, EventArgs e)
        {
            var currentLocation = this.Location;
            this.Hide();

            var loginForm = new MainPage();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = currentLocation;
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }





    }


}
