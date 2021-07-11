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

namespace project
{
    public partial class AdminHistory : Form
    {
        public AdminHistory()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().ShowDialog();
            this.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string st1 = "SELECT * FROM [shopMS].[dbo].[saleshistory];";

            //MessageBox.Show("" + st1);

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(st1, con);
                SqlDataAdapter rs = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                rs.Fill(dt);
                //dataGridView_database.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Database Refreshed");
        }

        private void AdminHistory_Load(object sender, EventArgs e)
        {
            string st1 = "SELECT * FROM [shopMS].[dbo].[saleshistory];";

            //MessageBox.Show("" + st1);

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(st1, con);
                SqlDataAdapter rs = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                rs.Fill(dt);
                //dataGridView_database.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        }
    }

