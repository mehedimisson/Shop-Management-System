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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            idtxt.MaxLength = 3;
            pastxt.PasswordChar = '*';
            pastxt.MaxLength = 3;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string st1 = "select * from login where userid = '" + idtxt.Text + "' and password = '" + pastxt.Text + "'";
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
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

                if (idtxt.Text == "" || pastxt.Text == "")
                {
                    MessageBox.Show("Please enter both ID and Password");
                }
                else if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Invalid ID or Password");
                }
                else
                {
                    if (s1 == 0)
                    {
                        this.Hide();
                        new AdminHome().ShowDialog();
                        this.Close();
                    }
                    else if (s1 == 1)
                    {
                        
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().ShowDialog();
            this.Close();
        }

        private void LogInButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            string st1 = "select * from login where userid = '" + idtxt.Text + "' and password = '" + pastxt.Text + "'";
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
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

                if (idtxt.Text == "" || pastxt.Text == "")
                {
                    MessageBox.Show("Please enter both ID and Password");
                }
                else if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Invalid ID or Password");
                }
                else
                {
                    if (s1 == 0)
                    {
                        this.Hide();
                        new AdminHome().ShowDialog();
                        this.Close();
                    }
                    else if (s1 == 1)
                    {

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LogInButton_Enter(object sender, EventArgs e)
        {
            string st1 = "select * from login where userid = '" + idtxt.Text + "' and password = '" + pastxt.Text + "'";
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
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

                if (idtxt.Text == "" || pastxt.Text == "")
                {
                    MessageBox.Show("Please enter both ID and Password");
                }
                else if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Invalid ID or Password");
                }
                else
                {
                    if (s1 == 0)
                    {
                        this.Hide();
                        new AdminHome().ShowDialog();
                        this.Close();
                    }
                    else if (s1 == 1)
                    {
                        this.Hide();
                        new CustomerHome(idtxt.Text).ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        new EmployeeHome(idtxt.Text).ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
