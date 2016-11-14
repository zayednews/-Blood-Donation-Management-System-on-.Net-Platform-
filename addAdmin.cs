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
    public partial class addAdmin : Form
    {
        public addAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blood_donation_databaseDataContext md = new blood_donation_databaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\Blood_Donation\blood_donation_database.mdf;Integrated Security=True;Connect Timeout=30");
            Admin t = md.Admins.SingleOrDefault(x => (x.aName == textBox1.Text));
            if (t == null)
            {
                User u = md.Users.SingleOrDefault(x => x.name == textBox1.Text);
                if (u == null)
                {
                    Admin ut = new Admin();
                    ut.aName = textBox1.Text;

                    ut.aPass = textBox2.Text;

                    

                    md.Admins.InsertOnSubmit(ut);
                    md.SubmitChanges();

                    MessageBox.Show("New Admin Added.");
                    this.Close();

                    

                }
                else
                {
                    MessageBox.Show("User Name Has Already Exist.");
                }
            }
            else
            {
                MessageBox.Show("Admin Name Has Already Exist.");
            }
        }
    }
}
