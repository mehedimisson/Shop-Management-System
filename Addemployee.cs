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
    public partial class Addemployee : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
        SqlCommand cmd;

        public Addemployee()
        {
            InitializeComponent();
            pwText.MaxLength = 3;
            phoneText.MaxLength = 11;
            salText.MaxLength = 5;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeManagement().ShowDialog();
            this.Close();
        }

        private void empAddButton_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "" || pwText.Text == "" || phoneText.Text == "")
            {
                MessageBox.Show("Please fill up each space. Try Again.");
                return;
            }

           /* if (ACCButton.Checked == false && mngrButton.Checked == false && clkButton.Checked == false && slmnButton.Checked == false)
            {
                MessageBox.Show("Please select a Job.");
                return;
            } */
              
            if (salText.Text == "")
            {
                MessageBox.Show("Please Provide Salary");
                return;
            }

            check_user(333);
        }

        private void check_user(int count)
        {
            count++;
            string x = count + "";

            try
            {
                cmd = new SqlCommand("select * from login where userid = '" + x + "'", conn);
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
            /* string valueRB = "";
            bool isChecked = slmnButton.Checked || ;

            if (isChecked)
                valueRB = slmnButton.Text;
            else if (isChecked)
                valueRB = ACCButton.Text;
            else if (isChecked)
                valueRB = mngrButton.Text;
            else
                valueRB = clkButton.Text;
                */

            string st1 = "INSERT INTO [shopMS].[dbo].[login] VALUES('" + count + "','" + pwText.Text + "', 2 )";
            string st2 = "INSERT INTO [shopMS].[dbo].[employee] VALUES ('" + count + "','" + nameText.Text + "', '" + jobComboBox.Text + "','" + salText.Text + "','" + addressTXT.Text + "','" + phoneText.Text + "')";

            try
            {
                cmd = new SqlCommand(st1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                cmd = new SqlCommand(st2, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sign Up Completed ! Welcome "+nameText.Text);
                //cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
