using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class SignUp : Form
    {
        string d = DateTime.Now.ToString("yyyy-MM-dd");
        SqlConnection conn = new SqlConnection(@"Data Source=MISSON\SQLEXPRESS;Initial Catalog=ShopMS;Integrated Security=True");
        SqlCommand cmd;
        
        string imagePath1 = "";

        public SignUp()
        {
            InitializeComponent();
            pwText.MaxLength = 3;
            phoneText.MaxLength = 11;
            nameText.MaxLength = 20;
        }

        private void cleardata()
        {
            nameText.Text = "";
            pwText.Text = "";
            phoneText.Text = "";
            maleRB.Checked = false;
            femaleRB.Checked = false;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "" || pwText.Text == "" || phoneText.Text == "")
            {
                MessageBox.Show("Please fill up each space. Try Again.");
                return;
            }
            if (maleRB.Checked == false && femaleRB.Checked == false)
            {
                MessageBox.Show("Please select gender.");
                return;
            }
            if (d == "")
            {
                MessageBox.Show("Please fill the birth date.");
                return;
            } 

            check_user(111);
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
            string valueRB = "";
            bool isChecked = maleRB.Checked;

            if (isChecked)
                valueRB = maleRB.Text;
            else
                valueRB = femaleRB.Text;

            string st1 = "INSERT INTO [shopMS].[dbo].[login] VALUES('" + count + "','" + pwText.Text + "', 1 )";
            string st2 = "INSERT INTO [shopMS].[dbo].[customer] (custid,cname,phone,gender,birthdate,joindate) VALUES('" + count + "','" + nameText.Text + "', '" + phoneText.Text + "', '" + valueRB + "', '" + dateTimePicker1.Text +"', '"+d+"')";

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
                cleardata();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //try
            //{
                byte[] imageArray1 = null;
                FileStream fs1 = new FileStream(imagePath1, FileMode.Open, FileAccess.Read);
                BinaryReader b1 = new BinaryReader(fs1);
                imageArray1 = b1.ReadBytes((int)fs1.Length);

                string cus1 = "INSERT INTO [shopMS].[dbo].[custimage] VALUES('" + count + "', @img_1)";

                conn.Open();
                cmd = new SqlCommand(cus1, conn);
                cmd.Parameters.Add(new SqlParameter("@img_1", imageArray1));
                int x = cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void UploadButton_Click(object sender, EventArgs e)
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
    }
}
