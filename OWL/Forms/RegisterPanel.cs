using OWL.Models;
using OWL.Services;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OWL.Forms
{
    public partial class RegisterPanel : Form
    {
        private readonly AuthService _authService;

        public RegisterPanel()
        {
            InitializeComponent();
            _authService = new AuthService();

            RegisterButton.Click += RegisterButton_Click;
            EmailBox.TextChanged += ValidateFields;
            LoginBox.TextChanged += ValidateFields;
            PasswordBox.TextChanged += ValidateFields;
            PasswordConfirmBox.TextChanged += ValidateFields;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!ValidateRegistration())
                return;

            try
            {
                bool success = _authService.RegisterUser( LoginBox.Text.Trim(), EmailBox.Text.Trim(), PasswordBox.Text );


                if (success)
                {
                    MessageBox.Show("Rejestracja zakończona pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                    ClearForm();

                    BackToLoginButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Użytkownik o podanym loginie lub emailu już istnieje",
                        "Błąd rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
                EmailBox.Text = string.Empty;
    LoginBox.Text = string.Empty;
    PasswordBox.Text = string.Empty;
    PasswordConfirmBox.Text = string.Empty;
    RegisterButton.Enabled = false;
        }

        private bool ValidateRegistration()
        {
            if (!Regex.IsMatch(EmailBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(LoginBox.Text) || LoginBox.Text.Length < 4)
            {
                return false;
            }

            if (PasswordBox.Text.Length < 8)
            {
                return false;
            }

            if (PasswordBox.Text != PasswordConfirmBox.Text)
            {
                return false;
            }

            return true;
        }

        private void ValidateFields(object sender, EventArgs e)
        {
            bool emailValid = Regex.IsMatch(EmailBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool loginValid = !string.IsNullOrWhiteSpace(LoginBox.Text) && LoginBox.Text.Length >= 4;
            bool passwordValid = PasswordBox.Text.Length >= 8;
            bool passwordsMatch = PasswordBox.Text == PasswordConfirmBox.Text;

            RegisterButton.Enabled = emailValid && loginValid && passwordValid && passwordsMatch;
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields(sender, e);
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields(sender, e);
        }

        private void PasswordConfirmBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields(sender, e);
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields(sender, e);
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            var currentLocation = this.Location;
            this.Hide();

            var loginForm = new LoginPanel();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = currentLocation;
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

    }
}