using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OWL.Forms;

namespace OWL
{
    public partial class EventTile : UserControl
    {
        public EventTile()
        {
            InitializeComponent();
        }

        int ThisEventID;
        public string TitleText
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string DateText
        {
            get => lblDate.Text;
            set => lblDate.Text = value;
        }

        public string LocationText
        {
            get => lblLocation.Text;
            set => lblLocation.Text = value;
        }

        public string DescriptionText
        {
            get => txtDesc.Text;
            set => txtDesc.Text = value;
        }

        public int EventID
        {
            get => ThisEventID;
            set => ThisEventID = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var detailsForm = new EventDetailsForm(ThisEventID);
            detailsForm.Show();

        }

        public bool EditEnabled
        {
            get => button2.Enabled;
            set => button2.Enabled = value;
        }

        public event EventHandler EditClicked;

        private void button2_Click(object sender, EventArgs e)
        {
            // Przekaż dalej do MainPage
            EditClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

