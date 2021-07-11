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
    public partial class Product_perf : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter rs;
        DataTable dt = new DataTable();

        

        public Product_perf()
        {
            InitializeComponent();
            Product_perf_Load();
        }

        private void Product_perf_Load()
        {
            string st1 = "select * from dbo.overall_sales";

            //string st1 = "select * from shopMS.dbo.saleshistory";
            try
            {
                cmd = new SqlCommand(st1, conn);
                rs = new SqlDataAdapter(cmd);

                rs.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            //string temp = "";

            if (monthCB.Text == "Jan")
            {
                monthCB.Text = "01";
            }
            else if (monthCB.Text == "Feb")
            {
                monthCB.Text = "02";
            }
            else if (monthCB.Text == "Mar")
            {
                monthCB.Text = "03";
            }
            else if (monthCB.Text == "Apr")
            {
                monthCB.Text = "04";
            }
            else if (monthCB.Text == "May")
            {
                monthCB.Text = "05";
            }
            else if (monthCB.Text == "Jun")
            {
                monthCB.Text = "06";
            }
            else if (monthCB.Text == "Jul")
            {
                monthCB.Text = "07";
            }
            else if (monthCB.Text == "Aug")
            {
                monthCB.Text = "08";
            }
            else if (monthCB.Text == "Sep")
            {
                monthCB.Text = "09";
            }
            else if (monthCB.Text == "Oct")
            {
                monthCB.Text = "10";
            }
            else if (monthCB.Text == "Nov")
            {
                monthCB.Text = "11";
            }
            else if (monthCB.Text == "Dec")
            {
                monthCB.Text = "12";
            }

            //MessageBox.Show(monthCB.Text);

            string st1 = "select * from dbo.overall_sales";

            if (dayCB.Text == "--Select Day--" && monthCB.Text == "--Select Month--" && yearCB.Text != "--Select Year--")
            {
                st1 = "select * from dbo.overall_sales where CONVERT(VARCHAR(4), salesdate, 120) = '" + yearCB.Text + "'";
            }
            else if (dayCB.Text == "--Select Day--" && monthCB.Text != "--Select Month--" && yearCB.Text == "--Select Year--")
            {
                st1 = "select * from dbo.overall_sales where CONVERT(VARCHAR(2), salesdate, 110) = '" + monthCB.Text + "'";
            }
            else if (dayCB.Text != "--Select Day--" && monthCB.Text == "--Select Month--" && yearCB.Text == "--Select Year--")
            {
                st1 = "select * from dbo.overall_sales where CONVERT(VARCHAR(2), salesdate, 105) = '" + dayCB.Text + "'";
            }

            ///////Month & Year Text///////

            else if (dayCB.Text == "--Select Day--" && monthCB.Text != "--Select Month--" && yearCB.Text != "--Select Year--")
            {
                st1 = "select * from dbo.overall_sales where CONVERT(VARCHAR(7), salesdate, 120) = '" + yearCB.Text + "-" + monthCB.Text + "'";
            }

            ///////Month & Day Text///////

            else if (dayCB.Text != "--Select Day--" && monthCB.Text != "--Select Month--" && yearCB.Text == "--Select Year--")
            {
                st1 = "select * from dbo.overall_sales where convert(varchar(5), salesdate, 105) = '" + dayCB.Text + "-" + monthCB.Text + "'";
            }

            ///////Year Month Day Text///////

            else if (dayCB.Text != "--Select Day--" && monthCB.Text != "--Select Month--" && yearCB.Text != "--Select Year--")
            {
                st1 = "select * from dbo.overall_sales where CONVERT(VARCHAR(10), salesdate, 120) = '" + yearCB.Text + "-" + monthCB.Text + "-" + dayCB.Text + "'";
            }

            cmd = new SqlCommand(st1, conn);
            rs = new SqlDataAdapter(cmd);
            dt.Clear();

            rs.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminHome().ShowDialog();
            this.Close();
        }
    }
}
