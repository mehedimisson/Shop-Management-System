using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class LoginWindow : Form
    {
        
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string st1 = "select * from login where userid = '" + nameTx.Text + "' and password = '" + passTx.Text + "'";
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=USER-PC\RAFEE;Initial Catalog=shopMS;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand(st1, conn);
                SqlDataReader rs = cmd.ExecuteReader();

                int s1 = 0;
                while (rs.Read())
                {
                    s1 = rs.GetInt16(2);
                }

                conn.Close();

                SqlDataAdapter sdd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdd.Fill(dt);

                if (nameTx.Text == "" || passTx.Text == "")
                {
                    MessageBox.Show("Please enter both ID and Password");
                }
                else if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Invalid ID or Password");
                }
                else
                {
                    if(s1 == 0)
                    {
                        
                    }
                    else if (s1 == 1)
                    {
                        this.Hide();
                        new CustomerHome(nameTx.Text).ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        new SignUp().ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
