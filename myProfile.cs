using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class myProfile : UserControl
    {
        string userid;
        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
        SqlCommand cmd;

        string imagePath1 = "";

        public myProfile(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            myProfile_Onetime();
        }

        private void myProfile_Onetime()
        {
            myProfile_Dis();

            string st1 = "select * from [shopMS].[dbo].[custimage] where image_id = '" + userid + "'";

            try
            {
                cmd = new SqlCommand(st1, conn);

                conn.Open();
                SqlDataReader rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    //pic1 = rs.GetString(1);
                    byte[] a = (byte[])rs[1];
                    MemoryStream ms = new MemoryStream(a);
                    pictureBox1.Image = Image.FromStream(ms);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cleardata()
        {
            idText.Text = "";
            passText.Text = "";
            nameText.Text = "";
            phText.Text = "";
            genText.Text = "";
            dobText.Text = "";
            dateText.Text = "";
        }

        private void myProfile_Dis()
        {
            string st1 = "select * from login where userid = '" + userid + "'";
            string st2 = "select * from customer where custid = '" + userid + "'";

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
                string cphone = "";
                string cgen = "";
                string cbirth = "";
                string cjoindate = "";

                while (rs.Read())
                {
                    cname = rs.GetString(1);
                    cphone = rs.GetString(2);
                    cgen = rs.GetString(3);
                    cbirth = rs.GetString(4);
                    cjoindate = rs[5].ToString();
                }

                nameText.Text = cname;
                phText.Text = cphone;
                genText.Text = cgen;
                dobText.Text = cbirth;
                dateText.Text = cjoindate.Substring(0, 10);

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
            string st2 = "update [shopMS].[dbo].[customer] set cname = '" + nameText.Text + "',phone = '" + phText.Text + "',gender = '" + genText.Text + "',birthdate = '" + dobText.Text + "' where custid = '" + userid + "'";

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

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            

            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagePath1 = op.FileName;
                    pictureBox1.ImageLocation = imagePath1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            myProfile_Dis();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageArray1 = null;
                FileStream fs1 = new FileStream(imagePath1, FileMode.Open, FileAccess.Read);
                BinaryReader b1 = new BinaryReader(fs1);
                imageArray1 = b1.ReadBytes((int)fs1.Length);

                MessageBox.Show("Your request is accepted. Wait a moment.");
                string st1 = "update [shopMS].[dbo].[custimage] set picture = @img_1 where image_id = '" + userid + "'";

                conn.Open();
                cmd = new SqlCommand(st1, conn);
                cmd.Parameters.Add(new SqlParameter("@img_1", imageArray1));
                int x = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x + " Your Profile has been changed ! ");

                //cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void myProfile_Load(object sender, EventArgs e)
        {

        }

    }
}
