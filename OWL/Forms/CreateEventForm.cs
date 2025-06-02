using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OWL.Data;
using OWL.Models;
using OWL.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OWL.Forms
{
    public partial class CreateEventForm : Form

    {

        private readonly EventService _eventService;
        private readonly OwlDbContext _db = new OwlDbContext();

        int EventId;
        Event? thisEvent;

        public CreateEventForm()
        {
            InitializeComponent();

            _eventService = new EventService();

            textBox1.TextChanged += EnableBtn;
            DescBoxCEF.TextChanged += EnableBtn;
            LocBox.TextChanged += EnableBtn;
            DaBox.TextChanged += EnableBtn;



        }

        public CreateEventForm(int ID)
        {
            InitializeComponent();

            _eventService = new EventService();

            textBox1.TextChanged += EnableBtn;
            DescBoxCEF.TextChanged += EnableBtn;
            LocBox.TextChanged += EnableBtn;
            DaBox.TextChanged += EnableBtn;
            EventId = ID;
            thisEvent = _db.Events.FirstOrDefault(ev => ev.EventId == this.EventId);
            ActivateDel_Btn();
            AddToFields();


        }


        private void CEFMainLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (WithoutLocCheckbox.Checked)
            {
                LocBox.Text = "Wydarzenie zdalne";
                LocBox.Enabled = false;
            }
            else
            {
                LocBox.Enabled = true;
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateEventForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void CrtEVBtm_Click(object sender, EventArgs e)
        {
            if (!ValidateAllFields())
            {
                MessageBox.Show("Proszę wypełnić wszystkie wymagane pola", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                User localUser = Session.Instance.GetLocalUser();

                using (var context = new OwlDbContext())
                {
                    var freshUser = context.Users.Find(localUser.UserId);
                    if (freshUser == null)
                    {
                        MessageBox.Show("Nie znaleziono użytkownika w bazie danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (EventId == 0)
                    {

                        bool result = _eventService.NewEvent(
                            textBox1.Text.Trim(),
                            DescBoxCEF.Text.Trim(),
                            DaBox.Text.Trim(),
                            LocBox.Text.Trim(),
                            freshUser);

                        if (result)
                        {
                            MessageBox.Show("Wydarzenie zostało utworzone!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();


                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wydarzenie o podanej nazwie już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool result2 = _eventService.EditEvent(
                            textBox1.Text.Trim(),
                            DescBoxCEF.Text.Trim(),
                            DaBox.Text.Trim(),
                            LocBox.Text.Trim(),
                            freshUser, thisEvent);


                        if (result2)
                        {
                            MessageBox.Show("Zmiany Wprowadzone!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wystąpił błąd podczas edycji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }


                }
            }
            catch (DbUpdateException dbEx)
            {
                string errorDetails = dbEx.InnerException?.Message ?? dbEx.Message;
                MessageBox.Show($"Błąd bazy danych: {errorDetails}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpnCalBtn_Click(object sender, EventArgs e)
        {
            var currentLocation = this.Location;


            var calendarForm = new Calendar();
            calendarForm.StartPosition = FormStartPosition.Manual;
            calendarForm.Location = currentLocation;

            calendarForm.DateSelected += (selectedDate) =>
            {
                DaBox.Text = selectedDate.ToString("yyyy-MM-dd");
            };

            calendarForm.Show();
        }



        private bool ValidateAllFields()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(DescBoxCEF.Text) || string.IsNullOrWhiteSpace(LocBox.Text) || string.IsNullOrWhiteSpace(DaBox.Text))
            {
                return false;
            }

            return true;
        }

        private void EnableBtn(object sender, EventArgs e)
        {

            bool textBox1Valid = !string.IsNullOrWhiteSpace(textBox1.Text);
            bool DescBoxCEFValid = !string.IsNullOrWhiteSpace(DescBoxCEF.Text);
            bool LocBoxValid = !string.IsNullOrWhiteSpace(LocBox.Text);
            bool DaBoxValid = !string.IsNullOrWhiteSpace(DaBox.Text);

            CrtEVBtm.Enabled = textBox1Valid && DescBoxCEFValid && LocBoxValid && DaBoxValid;
        }
        private void ClearForm()
        {
            textBox1.Text = string.Empty;
            DescBoxCEF.Text = string.Empty;
            LocBox.Text = string.Empty;
            DaBox.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            _db.Events.Remove(thisEvent);
            _db.SaveChanges();
            MessageBox.Show("Usunięto Wydarzenie!","Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreateEventForm.ActiveForm.Close();        }

        private void ActivateDel_Btn()
        {
            if(EventId != 0)
            {
                DelBtn.Enabled = true;
            }

        }
        private void AddToFields()
        {
            textBox1.Text = thisEvent.Title.Trim();
            DescBoxCEF.Text = thisEvent.Description.Trim();
            LocBox.Text = thisEvent.Location.Trim();
            DaBox.Text = thisEvent.Date;
            if(LocBox.Text == "Wydarzenie zdalne")
            {
                WithoutLocCheckbox.Checked = true;
                LocBox.Enabled = false;
            }

        }
    }
}
