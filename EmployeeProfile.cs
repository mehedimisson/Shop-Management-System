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
    public partial class EmployeeProfile : Form
    {
        string userid;

        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
        SqlCommand cmd;

        public EmployeeProfile(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void cleardata()
        {
            idText.Text = "";
            passText.Text = "";
            nameText.Text = "";
            phText.Text = "";
            jobText.Text = "";
            addText.Text = "";
            salText.Text = "";
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            string st1 = "select * from login where userid = '" + userid + "'";
            string st2 = "select * from employee where empid = '" + userid + "'";

            try
            {
                cmd = new SqlCommand(st1, conn);

                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();

                string s1 = "";
                string s2 = "";

                while (rs.Read())
                {
                    s1 = rs.GetString(0);
                    s2 = rs.GetString(1);
                }

                idText.Text = s1;
                passText.Text = s2;
                conn.Close();

                cmd = new SqlCommand(st2, conn);
                conn.Open();
                rs = cmd.ExecuteReader();

                string cname = "";
                string cJob = "";
                string cSal = "";
                string cAdd = "";
                string cphn = "";

                while (rs.Read())
                {
                    cname = rs.GetString(1);
                    cJob = rs.GetString(2);
                    cSal = rs.GetDecimal(3).ToString();
                    cAdd = rs.GetString(4);
                    cphn = rs.GetString(5);
                }

                nameText.Text = cname;
                phText.Text = cphn;
                jobText.Text = cJob;
                salText.Text = cSal;
                addText.Text = cAdd;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string st1 = "update [shopMS].[dbo].[login] set password = '" + passText.Text + "' where userid = '" + userid + "'";
            string st2 = "update [shopMS].[dbo].[employee] set ename = '" + nameText.Text + "',phone = '" + phText.Text + "',job = '" + jobText.Text + "',salary = '" + salText.Text + "',address = '" + addText.Text + "' where empid = '" + userid + "'";

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

                cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            string st1 = "select * from login where userid = '" + userid + "'";
            string st2 = "select * from employee where empid = '" + userid + "'";

            try
            {
                cmd = new SqlCommand(st1, conn);

                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();

                string s1 = "";
                string s2 = "";

                while (rs.Read())
                {
                    s1 = rs.GetString(0);
                    s2 = rs.GetString(1);
                }

                idText.Text = s1;
                passText.Text = s2;
                conn.Close();

                cmd = new SqlCommand(st2, conn);
                conn.Open();
                rs = cmd.ExecuteReader();

                string cname = "";
                string cJob = "";
                string cSal = "";
                string cAdd = "";
                string cphn = "";

                while (rs.Read())
                {
                    cname = rs.GetString(1);
                    cJob = rs.GetString(2);
                    cSal = rs.GetDecimal(3).ToString();
                    cAdd = rs.GetString(4);
                    cphn = rs.GetString(5);
                }

                nameText.Text = cname;
                phText.Text = cphn;
                jobText.Text = cJob;
                salText.Text = cSal;
                addText.Text = cAdd;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void refBtn_Click_1(object sender, EventArgs e)
        {
            string st1 = "select * from login where userid = '" + userid + "'";
            string st2 = "select * from employee where empid = '" + userid + "'";

            try
            {
                cmd = new SqlCommand(st1, conn);

                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();

                string s1 = "";
                string s2 = "";

                while (rs.Read())
                {
                    s1 = rs.GetString(0);
                    s2 = rs.GetString(1);
                }

                idText.Text = s1;
                passText.Text = s2;
                conn.Close();

                cmd = new SqlCommand(st2, conn);
                conn.Open();
                rs = cmd.ExecuteReader();

                string cname = "";
                string cJob = "";
                string cSal = "";
                string cAdd = "";
                string cphn = "";

                while (rs.Read())
                {
                    cname = rs.GetString(1);
                    cJob = rs.GetString(2);
                    cSal = rs.GetDecimal(3).ToString();
                    cAdd = rs.GetString(4);
                    cphn = rs.GetString(5);
                }

                nameText.Text = cname;
                phText.Text = cphn;
                jobText.Text = cJob;
                salText.Text = cSal;
                addText.Text = cAdd;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeHome(userid).ShowDialog();
            this.Close();
        }
    }
}
