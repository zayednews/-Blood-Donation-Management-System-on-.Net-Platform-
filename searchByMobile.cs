using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation
{
    public partial class searchByMobile : Form
    {
        public searchByMobile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");
            string i = textBox1.Text;
            Donator t = new Donator();
            var st = from k in md.Donators
                     where k.mobile == i
                     select k;

            dataGridView1.DataSource = st;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
