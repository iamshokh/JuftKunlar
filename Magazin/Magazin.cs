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
    public partial class Magazin : Form
    {
        public Magazin()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.View();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var products = Product.View();
            dataGridView1.DataSource = products;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product.Add(Name.Text, Convert.ToDecimal(Price.Text), Convert.ToInt32(Count.Text), Unit.Text, Category.Text);
            UpdateDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Product.Delete(Convert.ToInt32(Id.Text));
            UpdateDataGridView();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Product.Update(Id.Text, ..... ... . . );
            UpdateDataGridView();
        }
    }
}
