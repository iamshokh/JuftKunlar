using Magazin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool otvet = User.SignUp(RegistrLogin.Text, RegistrPassword.Text, RegistrNumber.Text);

            if (otvet == true)
            {
                MessageBox.Show("Siz ruyxatdan utdingiz");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrPassword_TextChanged(object sender, EventArgs e)
        {

            RegistrPassword.ForeColor = Color.Black;

            RegistrPassword.PasswordChar = '●';
        }
    }
}
