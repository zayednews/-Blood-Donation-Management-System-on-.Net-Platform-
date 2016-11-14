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
    public partial class adminSite : Form
    {
        public adminSite()
        {
            InitializeComponent();
        }

        private void adminSite_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new userList().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you Access this site you have to login again to access in Admin Site. \nAre you agree??", "Warning ! ! !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                new userSite().Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new deleteUser().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login_Panel().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new addAdmin().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new adminChangePass().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(@"C:\Users\USER-PC\Desktop\c sharp\Final Project\Blood_Donation\log.txt");
            
        }
    }
}
