using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class ProductHome : UserControl
    {
        //
        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string userid;
        string cname = "";
        string pid = "";
        string p_name = "";
        int p_quan = 0;

        public ProductHome(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            ProductHome_Display();
        }

        private void ProductHome_Display()
        {
            string st1 = "select * from product";

            try
            {

                cmd = new SqlCommand(st1, conn);
                SqlDataAdapter rs = new SqlDataAdapter(cmd);
                rs.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow cellrow = dataGridView1.Rows[e.RowIndex];
            idText.Text = cellrow.Cells[0].Value.ToString();
            nameText.Text = cellrow.Cells[1].Value.ToString();
            priceText.Text = cellrow.Cells[2].Value.ToString();
            quanText.Text = cellrow.Cells[3].Value.ToString();
        }

        private void cleardata()
        {
            idText.Text = "";
            nameText.Text = "";
            priceText.Text = "";
            quanText.Text = "";
            orderquanText.Text = "";
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            if (idText.Text == "" || nameText.Text == "" || priceText.Text == "" || quanText.Text == "" || orderquanText.Text == "")
            {
                MessageBox.Show("Please fill up each space. Try Again.");
                return;
            }

            try
            {
                cmd = new SqlCommand("select * from product where pro_id = '" + idText.Text + "'", conn);
                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    pid = rs.GetString(0);
                    p_name = rs.GetString(1);
                    p_quan = rs.GetInt16(3);
                }
                conn.Close();

                int hwwQuantity = Convert.ToInt16(orderquanText.Text);
                if (hwwQuantity <= 0)
                {
                    orderquanText.Text = "";
                    MessageBox.Show("Invalid Input! Please Try Again.");
                }
                else if (p_quan <= 0)
                {
                    cleardata();
                    MessageBox.Show("Out of Stock !!!");
                }
                else if (hwwQuantity > p_quan)
                {
                    orderquanText.Text = "";
                    MessageBox.Show("Order is more than available quantity. Try Again Please.");
                }


                string st1 = "update [shopMS].[dbo].[product] set available_units = available_units - " + orderquanText.Text + ", sold_units = sold_units + " + orderquanText.Text + " where pro_id = '" + idText.Text + "'";

                cmd = new SqlCommand(st1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                cmd = new SqlCommand("select * from customer where custid = '" + userid + "'", conn);
                conn.Open();
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    cname = rs.GetString(1);
                }
                conn.Close();

                order_sales(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            string query = "INSERT INTO [shopMS].[dbo].[orderlist] VALUES('" + count + "','" + userid + "','" + cname + "','" + pid + "','" + p_name + "', " + orderquanText.Text + ", (" + orderquanText.Text + "*" + priceText.Text + "), convert(varchar(12),getdate(),107))";
            try
            {
                cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                cleardata();
                MessageBox.Show("Thank you for your order.");
                dt.Clear();
                ProductHome_Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        /// Add to Cart code ///
        //

        private void putCartBtn_Click(object sender, EventArgs e)
        {
            if (idText.Text == "" || nameText.Text == "" || priceText.Text == "" || quanText.Text == "" || orderquanText.Text == "")
            {
                MessageBox.Show("Please fill up each space. Try Again.");
                return;
            }

            try
            {
                cmd = new SqlCommand("select * from product where pro_id = '" + idText.Text + "'", conn);
                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    pid = rs.GetString(0);
                    p_name = rs.GetString(1);
                    p_quan = rs.GetInt16(3);
                }
                conn.Close();

                int hwwQuantity = Convert.ToInt16(orderquanText.Text);
                if (hwwQuantity <= 0)
                {
                    orderquanText.Text = "";
                    MessageBox.Show("Invalid Input! Please Try Again.");
                }
                else if (p_quan <= 0)
                {
                    cleardata();
                    MessageBox.Show("Out of Stock !!!");
                }
                else if (hwwQuantity > p_quan)
                {
                    orderquanText.Text = "";
                    MessageBox.Show("Order is more than available quantity. Try Again Please.");
                }


                string st1 = "update [shopMS].[dbo].[product] set available_units = available_units - " + orderquanText.Text + ", sold_units = sold_units + " + orderquanText.Text + " where pro_id = '" + idText.Text + "'";

                cmd = new SqlCommand(st1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                cmd = new SqlCommand("select * from customer where custid = '" + userid + "'", conn);
                conn.Open();
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    cname = rs.GetString(1);
                }
                conn.Close();

                order_sales_cart(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void order_sales_cart(int count)
        {
            count++;
            string x = count + "";

            try
            {
                cmd = new SqlCommand("select * from ordercartlist where cart_id = '" + x + "'", conn);
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
                    order_sales_cart(count);
                }
                else
                {
                    conn.Close();
                    insert_sales_cart(count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert_sales_cart(int count)
        {
            string query = "INSERT INTO [shopMS].[dbo].[ordercartlist] VALUES('" + count + "','" + userid + "','" + cname + "','" + pid + "','" + p_name + "', " + orderquanText.Text + ", (" + orderquanText.Text + "*" + priceText.Text + "), convert(varchar(12),getdate(),107))";
            try
            {
                cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                cleardata();
                dt.Clear();
                ProductHome_Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void goCartBtn_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            new CartWindow(userid).ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
            ProductHome_Display();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }
    }
}
