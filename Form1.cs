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
    public partial class AdminHome : Form
    {
       // string userid;
        public AdminHome()
        {
            InitializeComponent();
            //this.userid = userid;
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //EmployeeManagement em1 = new EmployeeManagement();
            new EmployeeManagement().ShowDialog();
            this.Close();
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Product_perf().ShowDialog();
            this.Close();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHistory().ShowDialog();
            this.Close();
        }

        private void databaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewDatabase().ShowDialog();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminProfile().ShowDialog();
            this.Close();
        }
    }
}
