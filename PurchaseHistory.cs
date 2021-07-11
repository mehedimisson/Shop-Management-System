using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class PurchaseHistory : UserControl
    {
        string userid;

        public PurchaseHistory(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }
        
        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            string st1 = "select * from saleshistory where cust_id = '" + userid + "'";

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(st1, conn);
                SqlDataAdapter rs = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
    }
}
