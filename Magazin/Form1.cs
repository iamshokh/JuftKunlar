using Magazin.Models;

namespace Magazin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string paket = User.SignIn(loginbox.Text, passwordbox.Text);

            if (paket == "Client")
            {
                this.Hide();
                Client client = new Client();
                client.Show();
            }

            else if(paket == "Admin")
            {
                this.Hide();
                Magazin magazin = new Magazin();
                magazin.Show();
            }

            else MessageBox.Show("Login yoki parol xato");
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
