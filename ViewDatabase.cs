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
    public partial class ViewDatabase : Form
    {
        public ViewDatabase()
        {
            InitializeComponent();
            //fillcombobox();
        }
        /*
        public void fillcombobox()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
            string sql = "select * from sysobjects where xtype='U'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        string tbname = myreader.GetString(i);
                        comboBox1.Items.Add(tbname);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } */

        private void dbNameCOMBObox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string st1 = "SELECT * FROM " + comboBox1.SelectedItem + "";
            //try
            //{
            //    SqlConnection con = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
            //    SqlCommand cmd = new SqlCommand(st1, con);
            //    SqlDataAdapter rs = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    rs.Fill(dt);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().ShowDialog();
            this.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            
            string st1 = "SELECT * FROM [shopMS].[dbo].[" + comboBox1.SelectedItem + "];";

           //MessageBox.Show("" + st1);

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(st1, con);
                SqlDataAdapter rs = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                dataGridView_database.DataSource = dt;
            }
            catch (Exception )
            {
                MessageBox.Show(" Please select a Table !");
            }
        }
    }
}
