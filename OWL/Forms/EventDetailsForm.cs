using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OWL.Data;
using OWL.Models;
using OWL.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OWL.Forms
{
    public partial class EventDetailsForm : Form
    {
        private readonly OwlDbContext _dbContext = new OwlDbContext();
        private readonly ParticipationService _participationService;
        private readonly int _eventId;

        public EventDetailsForm(int id)
        {
            InitializeComponent();

            _eventId = id;
            _participationService = new ParticipationService(_dbContext);

            LoadGridView();
        }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadGridView()
        {
            Event? thisEvent = _dbContext.Events.FirstOrDefault(ev => ev.EventId == _eventId);
            LocLabel.Text = thisEvent.Location.Trim();
            EventDateLabel.Text = thisEvent.Date.ToString();
            DescBox.Text = thisEvent.Description;
            NameLabel.Text = thisEvent.Title.Trim();

            var participations = _participationService.GetParticipationsByEvent(_eventId)
                .Select(p => new
                {
                    Username = p.User.Username,
                    p.RegistrationDate
                })
                .ToList();

            string userName = Session.Instance.GetLocalUser().Username;
            bool ispart = participations.Any(p => p.Username == userName);
            if (ispart)
            {
                REMfromPartBTN.Enabled = true;
                AddtoPartBTN.Enabled = false;
            }
            else
            {
                REMfromPartBTN.Enabled = false;
                AddtoPartBTN.Enabled = true;
            }

            dataGridView1.DataSource = participations;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int columnCount = dataGridView1.Columns.Count;
            if (columnCount > 0)
            {
                float equalWeight = 100f / columnCount;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.FillWeight = equalWeight;
                    col.Resizable = DataGridViewTriState.False;
                }
            }

            dataGridView1.ScrollBars = ScrollBars.Vertical;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AddtoPartBTN_Click(object sender, EventArgs e)
        {
            if (!Session.Instance.IsLoggedIn)
            {
                MessageBox.Show("Aby dodać udział, musisz być zalogowany.", "Brak zalogowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Session.Instance.GetLocalUser().UserId;
            bool added = _participationService.AddParticipation(userId, _eventId);

            if (added)
            {
                MessageBox.Show("Pomyślnie dodano Twój udział w tym wydarzeniu.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView();
            }
            else
            {
                MessageBox.Show("Już bierzesz udział w tym wydarzeniu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void REMfromPartBTN_Click(object sender, EventArgs e)
        {
            if (!Session.Instance.IsLoggedIn)
            {
                MessageBox.Show("Aby usunąć udział, musisz być zalogowany.", "Brak zalogowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Session.Instance.GetLocalUser().UserId;
            bool removed = _participationService.RemoveParticipation(userId, _eventId);

            if (removed)
            {
                MessageBox.Show("Pomyślnie usunięto Twój udział z tego wydarzenia.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView();
            }
            else
            {
                MessageBox.Show("Nie masz zapisanego udziału w tym wydarzeniu.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LocLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
