using System;
using System.Drawing;
using System.Windows.Forms;

namespace OWL.Forms
{
    public partial class RegisterPanel : Form
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            var currentLocation = this.Location;

            // Zamknij bieżący formularz rejestracji
            this.Hide();

            // Otwórz formularz logowania
            var loginForm = new LoginPanel();

            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = currentLocation;

            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}