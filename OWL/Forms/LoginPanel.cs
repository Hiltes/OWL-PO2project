using OWL.Forms;

namespace OWL
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void LoginToServ()
        {

        }

        private void ToRegButtonClick(object sender, EventArgs e)
        {

            var currentLocation = this.Location;
            // Zamknij bie¿¹cy formularz logowania
            this.Hide();


            // Otwórz formularz Rejestracji
            var Registerform = new RegisterPanel();

            Registerform.StartPosition = FormStartPosition.Manual;
            Registerform.Location = currentLocation;

            Registerform.Closed += (s, args) => this.Close();
            Registerform.Show();
        }
    }
}
