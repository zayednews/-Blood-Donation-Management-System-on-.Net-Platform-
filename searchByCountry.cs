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
    public partial class searchByCountry : Form
    {
        public searchByCountry()
        {
            InitializeComponent();
        }

        private void searchByCountry_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bangladesh")
            {
                string[] bd = { "Dhaka", "Chittagong" };
                for (int i = 0; i < bd.Length; i++)
                {
                    comboBox2.Items.Add(bd[i]);
                }
            }
            else if (comboBox1.Text == "India")
            {
                comboBox2.Items.Clear();
                string[] ind = { "Mombay", "Kolkata" };
                for (int i = 0; i < ind.Length; i++)
                {
                    comboBox2.Items.Add(ind[i]);
                }
            }
            else if (comboBox1.Text == "Srilanka")
            {
                comboBox2.Items.Clear();
                string[] sri = { "Kandy", "Galle" };
                for (int i = 0; i < sri.Length; i++)
                {
                    comboBox2.Items.Add(sri[i]);
                }
            }
            else if (comboBox1.Text == "Pakistan")
            {
                comboBox2.Items.Clear();
                string[] pak = { "Lahore", "Islamabad" };
                for (int i = 0; i < pak.Length; i++)
                {
                    comboBox2.Items.Add(pak[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");
            string i = comboBox1.Text;
            string j = comboBox2.Text;
            Donator t = new Donator();
            var st = from k in md.Donators
                     where k.country == i && k.city==j
                     select k;

            dataGridView1.DataSource = st;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
