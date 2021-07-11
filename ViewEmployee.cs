using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace project
{
    public partial class ViewEmployee : Form
    {
        SqlCommandBuilder scb;
        SqlDataAdapter sda;
        DataTable dt;

        public ViewEmployee()
        {
            InitializeComponent();
        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeManagement().ShowDialog();
            this.Close();
        }

        private void dataGridView_empView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            //string st1 = "select * from [shopMS].[dbo].[employee]";

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
                //SqlCommand cmd = new SqlCommand(st1, conn);
                sda = new SqlDataAdapter(@"select empid,ename,job,salary,address,phone from [shopMS].[dbo].[employee]", conn);
                //SqlDataAdapter rs = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                dt = new DataTable();
                //rs.Fill(dt);
                sda.Fill(dt);
                dataGridView_empView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        
        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
                sda = new SqlDataAdapter(@"select empid,ename,job,salary,address,phone from [shopMS].[dbo].[employee]", conn);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView_empView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                        
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
           // dt = new DataTable();
        }
    }
}
