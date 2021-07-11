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
    public partial class EmployeeManagement : Form
    {
        /*string userid;
        public  AdminHome(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        } */

        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().ShowDialog();
            this.Close();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Addemployee().ShowDialog();
            this.Close();
        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewEmployee().ShowDialog();
            this.Close();
        }

        private void prmtEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void rmvEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
