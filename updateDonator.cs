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
    public partial class updateDonator : Form
    {
        public updateDonator()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");

            int id = int.Parse(textBox1.Text);
            Donator t = md.Donators.SingleOrDefault(x => (x.id == id));
            textBox2.Text = t.name;
            textBox3.Text = t.email;
            textBox4.Text = t.mobile;
            comboBox1.Text = t.b_grp;
            comboBox2.Text = t.country;
            comboBox3.Text = t.city;
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox2.Text == "Bangladesh")
            {
                string[] bd = { "Dhaka", "Chittagong" };
                for (int i = 0; i < bd.Length; i++)
                {
                    comboBox3.Items.Add(bd[i]);
                }
            }
            else if (comboBox2.Text == "India")
            {
                comboBox3.Items.Clear();
                string[] ind = { "Mombay", "Kolkata" };
                for (int i = 0; i < ind.Length; i++)
                {
                    comboBox3.Items.Add(ind[i]);
                }
            }
            else if (comboBox2.Text == "Srilanka")
            {
                comboBox3.Items.Clear();
                string[] sri = { "Kandy", "Galle" };
                for (int i = 0; i < sri.Length; i++)
                {
                    comboBox3.Items.Add(sri[i]);
                }
            }
            else if (comboBox2.Text == "Pakistan")
            {
                comboBox3.Items.Clear();
                string[] pak = { "Lahore", "Islamabad" };
                for (int i = 0; i < pak.Length; i++)
                {
                    comboBox3.Items.Add(pak[i]);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");

            int id = int.Parse(textBox1.Text);
            Donator t = md.Donators.SingleOrDefault(x => (x.id == id));

             t.name=textBox2.Text ;
             t.email=textBox3.Text ;
             t.mobile=textBox4.Text ;
             t.b_grp=comboBox1.Text ;
             t.country=comboBox2.Text ;
             t.city=comboBox3.Text ;
             md.SubmitChanges();
             MessageBox.Show("Updated ! ! !");
             this.Hide();
             userSite frm = new userSite();
             frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            donatorList frm = new donatorList();
            frm.Show();
        }
    }
}
