using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OWL.Forms;
using OWL.Services;

namespace OWL
{
    public partial class LoginPanel : Form
    {
        private Dictionary<Control, float> originalFontSizes = new Dictionary<Control, float>();
        private Size originalFormSize;

        private readonly AuthService _authService;

        public LoginPanel()
        {
            InitializeComponent();

            _authService = new AuthService();



            // Pod��czamy obs�ug� przycisku i walidacj� p�l
            LoginButton.Click += LoginButton_Click;
            LoginBox.TextChanged += ValidateFields;
            PasswordBox.TextChanged += ValidateFields;
            this.MinimumSize = new Size(1088, 572);
            this.AutoScaleMode = AutoScaleMode.Font;
        }

        /// <summary>
        /// Przej�cie do formularza rejestracji
        /// </summary>
        private void ToRegButtonClick(object sender, EventArgs e)
        {
            var currentLocation = this.Location;
            this.Hide();

            var registerForm = new RegisterPanel();
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = currentLocation;
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }

        /// <summary>
        /// Obs�uga klikni�cia �Zaloguj�
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateLoginFields())
                return;

            try
            {
                bool access = _authService.LoginUser(
                    LoginBox.Text.Trim(),
                    PasswordBox.Text
                );

                if (access)
                {
                    Session.Instance.Login(LoginBox.Text.Trim());
                    MessageBox.Show(
                        "Witaj w OWL! Zalogowano pomy�lnie!",
                        "Sukces",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ClearForm();
                    AccessGranted(sender, e);
                }
                else
                {
                    HandleFailedLogin(LoginBox.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Wyst�pi� b��d: {ex.Message}",
                    "B��d",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Sprawdzenie, czy pola login/has�o s� poprawnie wype�nione
        /// </summary>
        private bool ValidateLoginFields()
        {
            if (string.IsNullOrWhiteSpace(LoginBox.Text) || LoginBox.Text.Length < 4)
                return false;

            if (PasswordBox.Text.Length < 8)
                return false;

            return true;
        }

        /// <summary>
        /// Obs�uga nieudanego logowania � rozr�nienie na �nie ma u�ytkownika� lub �z�e has�o�
        /// </summary>
        private void HandleFailedLogin(string username)
        {
            if (_authService.CheckUser(username))
            {
                MessageBox.Show(
                    "Niepoprawne has�o",
                    "B��d logowania",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                MessageBox.Show(
                    "Nie znaleziono u�ytkownika",
                    "B��d logowania",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Wyczy�� pola formularza
        /// </summary>
        private void ClearForm()
        {
            LoginBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
        }

        /// <summary>
        /// Metoda, kt�ra aktywuje przycisk Zaloguj tylko gdy pola s� wype�nione
        /// </summary>
        private void ValidateFields(object sender, EventArgs e)
        {
            bool loginValid =
                !string.IsNullOrWhiteSpace(LoginBox.Text) && LoginBox.Text.Length >= 4;

            bool passwordValid = PasswordBox.Text.Length >= 8;

            LoginButton.Enabled = loginValid && passwordValid;
        }

        /// <summary>
        /// Przekierowanie do g��wnego menu aplikacji po udanym logowaniu
        /// </summary>
        private void AccessGranted(object sender, EventArgs e)
        {
            var currentLocation = this.Location;
            this.Hide();

            var main = new MainPage();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = currentLocation;
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        // (Ten event handler mo�e pozosta� pusty lub mo�esz usun��, skoro ValidateFields
        // i tak pod��czone jest do PasswordBox.TextChanged)
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void WelcomeLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
