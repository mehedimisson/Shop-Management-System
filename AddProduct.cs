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
    

    public partial class AddProduct : Form
    {
        string userid;

        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
        SqlCommand cmd;

        public AddProduct(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (/*pidtextBox.Text == "" || */pnametextBox.Text == "" || pricetextBox.Text == "" || qntyTextBox.Text == "")
            {
                MessageBox.Show("Please fill up each space. Try Again.");
                return;
            }
            check_user(35);
        
           /* string st1 = "INSERT INTO [shopMS].[dbo].[product] (pro_id,pname,price,available_units) VALUES ('" + pidtextBox.Text + "','" + pnametextBox.Text + "', '" + pricetextBox.Text + "','" + qntyTextBox.Text + "')";

            try
            {
                cmd = new SqlCommand(st1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(pnametextBox.Text + " Product Added Successfully ! Price : " + pricetextBox.Text);

                //cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
        }
        private void check_user(int count)
        {
            count++;
            string x = count + "";

            try
            {
                cmd = new SqlCommand("select * from product where pro_id = '" + x + "'", conn);
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
                    check_user(count);
                }
                else
                {
                    conn.Close();
                    insert_new_user(count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insert_new_user(int count)
        {
            //string st2 = "INSERT INTO [shopMS].[dbo].[employee](pro_id,pname,price,available_units)  VALUES ('" + count + "','" + nameText.Text + "', '" + jobComboBox.Text + "','" + salText.Text + "','" + addressTXT.Text + "','" + phoneText.Text + "')";
            string st2 = "INSERT INTO [shopMS].[dbo].[product] VALUES ('" + count + "','" + pnametextBox.Text + "', '" + pricetextBox.Text + "','" + qntyTextBox.Text + "', 0,"+qntyTextBox.Text+")";

            
            try
            {
                //MessageBox.Show(st2);
                cmd = new SqlCommand(st2, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(pnametextBox.Text + " Product Added Successfully ! Price : " + pricetextBox.Text);
                //cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
       /* private void insert_new_user(int count)
        {
            string st1 = "INSERT INTO [shopMS].[dbo].[product] (pro_id,pname,price,available_units) VALUES ('" + pidtextBox.Text + "','" + pnametextBox.Text + "', '" + pricetextBox.Text + "','" + qntyTextBox.Text + "')";

            try
            {
                cmd = new SqlCommand(st1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(pnametextBox.Text + " Product Added Successfully ! Price : " + pricetextBox.Text);
                
                //cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */

        

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeHome(userid).ShowDialog();
            this.Close();
        }
    }
    }
