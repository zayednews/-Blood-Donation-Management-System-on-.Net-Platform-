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
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }
        string Uname = null, pass = null, email = null, mobile = null, b_grp = null, city=null, country = null;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Uname = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            email = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            mobile = textBox4.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            b_grp = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            country = comboBox2.Text;
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            city = comboBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");
           Admin t = md.Admins.SingleOrDefault(x => (x.aName==Uname));
           if (t == null)
           {
               User u = md.Users.SingleOrDefault(x => x.name == Uname);
               if (u == null)
               {
                   User ut = new User();
                   ut.name = Uname;
                  
                   ut.pass = pass;
                   
                   ut.email = email;
                  
                   ut.mobile = mobile;
                 
                   ut.b_grp = b_grp;
                   
                   ut.city = city;
                  
                   ut.country = country;
                  
                   md.Users.InsertOnSubmit(ut);
                   md.SubmitChanges();

                   MessageBox.Show("You have been signed up.");
                   this.Close();

                   Login_Panel frm = new Login_Panel();
                   frm.Show();


               }
               else
               {
                   MessageBox.Show("User Name Has Already Exist.");
               }
           }
           else 
           {
               MessageBox.Show("User Name Has Already Exist.");
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Panel frm = new Login_Panel();
            frm.Show();
        }
    }
}
