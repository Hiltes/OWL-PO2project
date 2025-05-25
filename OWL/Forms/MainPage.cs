using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OWL.Services;

namespace OWL.Forms
{
    public partial class MainPage : Form
    {

        private readonly UserService _userService;
        private readonly AuthService _authService;

        public MainPage()
        {
            InitializeComponent();

        }

        private void EventTitle_Click(object sender, EventArgs e)
        {

        }

        private void EventDescMain_Click(object sender, EventArgs e)
        {

        }

        private void MainLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MainPagePanel_Visible(object sender, PaintEventArgs e)
        {
            MainPagePanel.Visible = false;
        }
        private void MainFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        public void CopyContainerWithChildren(Control original, Control parent)
        {
            Type type = original.GetType();
            Control copy = (Control)Activator.CreateInstance(type);


            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (prop.CanWrite && prop.Name != "Name")
                {
                    prop.SetValue(copy, prop.GetValue(original, null), null);
                }
            }

            // Zmiana lokalizacji, aby było widać kopię
            copy.Location = new Point(original.Location.X + original.Width + 10, original.Location.Y);

            // Dodanie do rodzica
            parent.Controls.Add(copy);

            // Rekurencyjne kopiowanie dzieci
            foreach (Control child in original.Controls)
            {
                CopyContainerWithChildren(child, copy);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsnameMain_Click(object sender, EventArgs e)
        {

        }

        private void LoadUserInformations(object sender, EventArgs e)
        {



        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Instance.Logout();

            var currentLocation = this.Location;
            this.Hide();

            var loginForm = new LoginPanel();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = currentLocation;
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void label3_download_data(object sender, EventArgs e)
        {

            string userDataName = Session.Instance.CurrentUser.Username.ToString();

            if (userDataName != null)
            {
                label3.Text = userDataName;
            }
            else
            {
                label3.Text += string.Empty;
            }
        }

        private void label4_download_data(object sender, EventArgs e)
        {

            string userDataEmail = Session.Instance.CurrentUser.Email.ToString();

            if (userDataEmail != null)
            {
                label4.Text = userDataEmail;
            }
            else
            {
                label4.Text += string.Empty;
            }
        }

        private void EmailMainLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateEButton_Click(object sender, EventArgs e)
        {


            var currentLocation = this.Location;


            var CreateEventForm = new CreateEventForm();
            CreateEventForm.StartPosition = FormStartPosition.Manual;
            CreateEventForm.Location = currentLocation;
            CreateEventForm.Show();

        }
    }
}
