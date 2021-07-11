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
    public partial class EmployeeHome : Form
    {
        string userid;

        public EmployeeHome(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProduct(userid).ShowDialog();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void viewProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewProduct(userid).ShowDialog();
            this.Close();
        }

        private void purchaseHistoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewPurchaseHistory(userid).ShowDialog();
            this.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeProfile(userid).ShowDialog();
            this.Close();
        }

        private void bookingListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderToSales(userid).ShowDialog();
            this.Close();
        }
    }
}
