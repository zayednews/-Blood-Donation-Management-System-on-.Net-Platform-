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
    public partial class searchDonator : Form
    {
        public searchDonator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new searchById().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new searchByName().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new searchByEmail().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new searchByMobile().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new searchByBlood().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            new userSite().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new searchByCountry().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new donatorList().Show();
        }
    }
}
