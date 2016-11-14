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
    public partial class Login_Panel : Form
    {
        public Login_Panel()
        {
            InitializeComponent();
        }
        String user = null, pass = null;
        string lines = null;
        string path = @"C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\log.txt";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");
            Admin t = md.Admins.SingleOrDefault(x => (x.aName == user));
            if (t == null)
            {
                User u = md.Users.SingleOrDefault(x => x.name == user);
                if (u == null)
                {
                    MessageBox.Show("User name does not match.");
                }
                else
                {
                    User p = md.Users.SingleOrDefault(x => x.pass == pass && x.name== user);
                    if (p == null)
                    {
                        MessageBox.Show("User password does not match.");

                    }
                    else
                    {
                        MessageBox.Show("Access Successful");
                        lines = "User : " + user + " \tlogged at \t" + DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss") + Environment.NewLine;
            
                        this.Hide();
                        userSite frm = new userSite();
                        frm.Show();
                    }
                }
            }
            else
            {
                Admin k = md.Admins.SingleOrDefault(x => x.aPass == pass);
                if (k == null)
                {
                    MessageBox.Show("User password does not match.");

                }
                else
                {
                    MessageBox.Show("Access Successful");
                    lines = "Admin: " + user + " \tlogged at \t" + DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss")+ Environment.NewLine;
            
                    this.Hide();
                    adminSite frm = new adminSite();
                    frm.Show();
 
                }
            }

            System.IO.File.AppendAllText(path, lines);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            newUser frm = new newUser();
            frm.Show();
        }
        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Panel_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
