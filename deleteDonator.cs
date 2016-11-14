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
    public partial class deleteDonator : Form
    {
        public deleteDonator()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this Donator?", "Delete Donator", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");

                int id = int.Parse(textBox1.Text);
                Donator t = md.Donators.SingleOrDefault(x => (x.id == id));

                md.Donators.DeleteOnSubmit(t);
                md.SubmitChanges();
                MessageBox.Show("Donator Deleted ! ! !");
                this.Close();
                new userSite().Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                new deleteDonator().Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            donatorList frm = new donatorList();
            frm.Show();
        }
    }
}
