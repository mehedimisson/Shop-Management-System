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
    public partial class CartWindow : Form
    {
        string userid;
        DataTable dt = new DataTable();
        string deleteString = "";
        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
        SqlCommand cmd;

        public CartWindow(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            CartWindow_Display();
        }

        private void CartWindow_Display()
        {
            string st1 = "select * from ordercartlist where cust_id = '" + userid + "'";

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
                cmd = new SqlCommand("select * from orderlist where order_id = '" + x + "'", conn);
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
                dvgrid.DataSource = dt;

                for (int i = 0; i < dvgrid.Rows.Count; i++)
                {
                    string st1 = "INSERT INTO [shopMS].[dbo].[orderlist] VALUES('" + count++ + "','" + dvgrid.Rows[i].Cells[1].Value + "','" + dvgrid.Rows[i].Cells[2].Value + "','" + dvgrid.Rows[i].Cells[3].Value + "','" + dvgrid.Rows[i].Cells[4].Value + "', " + dvgrid.Rows[i].Cells[5].Value + ", " + dvgrid.Rows[i].Cells[6].Value + ", convert(varchar(10), '" + dvgrid.Rows[i].Cells[7].Value + "', 120))";

                    cmd = new SqlCommand(st1, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //MessageBox.Show(st1);
                }
                MessageBox.Show("Your Orders are Complete.");

                cmd = new SqlCommand("Delete from [shopMS].[dbo].[ordercartlist]", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                dt.Clear();
                CartWindow_Display();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dvgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow cellrow = dvgrid.Rows[e.RowIndex];
            deleteString = cellrow.Cells[0].Value.ToString();
            //MessageBox.Show(deleteString);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(deleteString);
                    cmd = new SqlCommand("select * from ordercartlist where cart_id = '" + deleteString + "'", conn);
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

                    //MessageBox.Show(st1);
                    cmd = new SqlCommand(st1, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string st2 ="Delete from [shopMS].[dbo].[ordercartlist] where cart_id = '" + deleteString + "'";
                    //essageBox.Show(st2);

                    cmd = new SqlCommand(st2, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    dt.Clear();
                    CartWindow_Display();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerHome(userid).ShowDialog();
            this.Close();
        }
    }
}
