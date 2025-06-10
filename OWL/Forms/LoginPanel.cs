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



            // Pod³¹czamy obs³ugê przycisku i walidacjê pól
            LoginButton.Click += LoginButton_Click;
            LoginBox.TextChanged += ValidateFields;
            PasswordBox.TextChanged += ValidateFields;
            this.MinimumSize = new Size(1088, 572);
            this.AutoScaleMode = AutoScaleMode.Font;
        }

        /// <summary>
        /// Przejœcie do formularza rejestracji
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
        /// Obs³uga klikniêcia „Zaloguj”
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
                        "Witaj w OWL! Zalogowano pomyœlnie!",
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
                    $"Wyst¹pi³ b³¹d: {ex.Message}",
                    "B³¹d",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Sprawdzenie, czy pola login/has³o s¹ poprawnie wype³nione
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
        /// Obs³uga nieudanego logowania – rozró¿nienie na „nie ma u¿ytkownika” lub „z³e has³o”
        /// </summary>
        private void HandleFailedLogin(string username)
        {
            if (_authService.CheckUser(username))
            {
                MessageBox.Show(
                    "Niepoprawne has³o",
                    "B³¹d logowania",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                MessageBox.Show(
                    "Nie znaleziono u¿ytkownika",
                    "B³¹d logowania",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Wyczyœæ pola formularza
        /// </summary>
        private void ClearForm()
        {
            LoginBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
        }

        /// <summary>
        /// Metoda, która aktywuje przycisk Zaloguj tylko gdy pola s¹ wype³nione
        /// </summary>
        private void ValidateFields(object sender, EventArgs e)
        {
            bool loginValid =
                !string.IsNullOrWhiteSpace(LoginBox.Text) && LoginBox.Text.Length >= 4;

            bool passwordValid = PasswordBox.Text.Length >= 8;

            LoginButton.Enabled = loginValid && passwordValid;
        }

        /// <summary>
        /// Przekierowanie do g³ównego menu aplikacji po udanym logowaniu
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

        // (Ten event handler mo¿e pozostaæ pusty lub mo¿esz usun¹æ, skoro ValidateFields
        // i tak pod³¹czone jest do PasswordBox.TextChanged)
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
