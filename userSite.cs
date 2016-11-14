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
    public partial class userSite : Form
    {
        public userSite()
        {
            InitializeComponent();
        }

        private void userSite_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            addDonator frm = new addDonator();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            updateDonator frm = new updateDonator();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            deleteDonator frm = new deleteDonator();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new searchDonator().Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new donatorList().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new updateUserInfo().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login_Panel().Show();
        }
    }
}
