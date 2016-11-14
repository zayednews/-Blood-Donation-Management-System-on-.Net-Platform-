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
    public partial class adminChangePass : Form
    {
        public adminChangePass()
        {
            InitializeComponent();
        }

        private void adminChangePass_Load(object sender, EventArgs e)
        {
            textBox3.Hide();
            label3.Hide();
            button2.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");

            string name = textBox1.Text;
            string pass = textBox2.Text;
            Admin t = md.Admins.SingleOrDefault(x => (x.aName == name) && (x.aPass == pass));
            if (t == null)
            {
                MessageBox.Show("Wrong Info");
                this.Close();
                new Login_Panel().Show();
            }
            else
            {
                textBox3.Show();
                label3.Show();
                button2.Show();


 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");

            string name = textBox1.Text;
            string pass = textBox3.Text;
            Admin t = md.Admins.SingleOrDefault(x => (x.aName == name) );

            t.aPass = textBox3.Text;
            
            md.SubmitChanges();
            MessageBox.Show("Updated ! ! !");
            this.Close();

            //Application.Exit();
            new Login_Panel().Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
