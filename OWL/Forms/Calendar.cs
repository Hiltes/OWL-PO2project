using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWL.Forms
{
    public partial class Calendar : Form
    {
        public event Action<DateTime> DateSelected;
        public Calendar()
        {

            InitializeComponent();
            monthCalendar.DateChanged += MonthCalendar_DateChanged;

        }

        private void CalLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ApplyButtonCal_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart;
            DateSelected?.Invoke(selectedDate);
            this.Close();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar.SelectionStart.ToString("yyyy-MM-dd");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



