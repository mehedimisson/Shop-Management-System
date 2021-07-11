using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class OrderToSales : Form
    {
        string userid;
        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();

        string orderNum = "1";
        string delNum = "1";

        public OrderToSales(string userid)
        {
            InitializeComponent();
            OrderToSales_Display();
            this.userid = userid;
        }

        private void OrderToSales_Display()
        {
            string st1 = "select * from [shopMS].[dbo].[orderlist]";

            try
            {
                cmd = new SqlCommand(st1, conn);
                SqlDataAdapter rs = new SqlDataAdapter(cmd);
                rs.Fill(dt);
                dvgrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow cellrow = dvgrid.Rows[e.RowIndex];
            orderNum = cellrow.Cells[0].Value.ToString();
            delNum = cellrow.Cells[0].Value.ToString();
        }

        private void confBtn_Click(object sender, EventArgs e)
        {
            order_sales(0);
        }

        private void order_sales(int count)
        {
            count++;
            string x = count + "";

            try
            {
                cmd = new SqlCommand("select * from saleshistory where sale_id = '" + x + "'", conn);
                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();

                string newId = "";
                while (rs.Read())
                {
                    newId = rs.GetString(0);
                }
                if (x == newId)
                {
                    conn.Close();
                    order_sales(count);
                }
                else
                {
                    conn.Close();
                    insert_sales(count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert_sales(int count)
        {
            try
            {
                cmd = new SqlCommand("select * from orderlist where order_id = '" + orderNum + "'", conn);
                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();

                string st1 = "";
                while (rs.Read())
                {
                    string n1 = rs.GetString(1);
                    string n2 = rs.GetString(2);
                    string n3 = rs.GetString(3);
                    string n4 = rs.GetString(4);
                    int n5 = rs.GetInt16(5);
                    decimal n6 = rs.GetDecimal(6);
                    string n7 = rs[7].ToString();

                    st1 = "INSERT INTO [shopMS].[dbo].[saleshistory] VALUES('" + count++ + "','" + n1 + "','" + n2 + "','" + n3 + "','" + n4 + "', " + n5 + ", " + n6 + ", convert(varchar(10), '" + n7 + "', 120))";
                }
                conn.Close();


                cmd = new SqlCommand(st1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(st1);

                cmd = new SqlCommand("Delete from [shopMS].[dbo].[orderlist] where order_id = '" + orderNum + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Complete.");

                dt.Clear();
                OrderToSales_Display();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from orderlist where order_id = '" + delNum + "'", conn);
                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();


                string p_id = "";
                int order_quantity = 0;

                while (rs.Read())
                {
                    p_id = rs.GetString(3);
                    order_quantity = rs.GetInt16(5);
                }
                conn.Close();

                string st1 = "update [shopMS].[dbo].[product] set available_units = available_units + " + order_quantity + ", sold_units = sold_units - " + order_quantity + " where pro_id = '" + p_id + "'";

                MessageBox.Show(st1);

                cmd = new SqlCommand(st1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                cmd = new SqlCommand("Delete from [shopMS].[dbo].[orderlist] where order_id = '" + delNum + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                dt.Clear();
                OrderToSales_Display();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dvgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeHome(userid).ShowDialog();
            this.Close();
        }
    }
}
