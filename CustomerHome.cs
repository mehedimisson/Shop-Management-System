using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class CustomerHome : Form
    {
        string userid;

        public CustomerHome(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            homeBtn_Ex();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeBtn_Ex();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(new myProfile(userid));
        }

        private void itemBtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(new PurchaseHistory(userid));
        }

        private void homeBtn_Ex()
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(new ProductHome(userid));
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }
    }
}
