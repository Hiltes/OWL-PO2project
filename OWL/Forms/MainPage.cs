using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OWL.Models;
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
            LoadEventTiles();
        }

        private void EventTitle_Click(object sender, EventArgs e) { }

        private void EventDescMain_Click(object sender, EventArgs e) { }

        private void MainLabel1_Click(object sender, EventArgs e) { }

        private void MainFlowPanel_Paint(object sender, PaintEventArgs e) { }

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

            copy.Location = new Point(original.Location.X + original.Width + 10, original.Location.Y);
            parent.Controls.Add(copy);

            foreach (Control child in original.Controls)
            {
                CopyContainerWithChildren(child, copy);
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void UsnameMain_Click(object sender, EventArgs e) { }

        private void LoadUserInformations(object sender, EventArgs e) { }

        private void MainPanel_Paint(object sender, PaintEventArgs e) { }

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
            string userDataName = Session.Instance.CurrentUser?.Username;
            label3.Text = userDataName ?? string.Empty;
        }

        private void label4_download_data(object sender, EventArgs e)
        {
            string userDataEmail = Session.Instance.CurrentUser?.Email;
            label4.Text = userDataEmail ?? string.Empty;
        }

        private void EmailMainLabel_Click(object sender, EventArgs e) { }

        private void CreateEButton_Click(object sender, EventArgs e)
        {
            var currentLocation = this.Location;
            var createEventForm = new CreateEventForm();
            createEventForm.StartPosition = FormStartPosition.Manual;
            createEventForm.Location = currentLocation;
            createEventForm.Show();
        }

        private void EventGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadEventTiles();
        }

        public void LoadEventTiles()
        {
            using (var db = new OwlDbContext())
            {
                var events = db.Events
                               .Include(e => e.Organizer)
                               .ToList();

                flowLayoutPanel1.Controls.Clear();

                var currentUser = Session.Instance.CurrentUser;

                foreach (var ev in events)
                {
                    var tile = new EventTile
                    {
                        Width = 250,
                        Height = 230,
                        TitleText = ev.Title,
                        DateText = ev.Date,
                        LocationText = ev.Location,
                        DescriptionText = ev.Description.Length > 100
                            ? ev.Description.Substring(0, 100) + "…"
                            : ev.Description,
                        EventID = ev.EventId,
                        EditEnabled = currentUser != null && currentUser.UserId == ev.OrganizerId
                    };

                    tile.EditClicked += (s, args) =>
                    {
                        using (var editForm = new CreateEventForm(ev.EventId))
                        {
                            if (editForm.ShowDialog() == DialogResult.OK)
                            {
                                LoadEventTiles(); // Odśwież kafelki
                            }
                        }
                    };

                    flowLayoutPanel1.Controls.Add(tile);
                }
            }
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            LoadEventTiles(); // Odświeżenie po kliknięciu przycisku
        }
    }
}
