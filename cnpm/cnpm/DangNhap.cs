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

namespace cnpm
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select* from Nguoidung where Taikhoan=@Taikhoan and Matkhau=@Matkhau", conn);
            cmd.Parameters.AddWithValue("@Taikhoan", textBox1.Text);
            cmd.Parameters.AddWithValue("@Matkhau", textBox2.Text);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau!");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Ban chac chan muon thoat?", "Warning!", MessageBoxButtons.YesNo);
            if(rs==DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength<2)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

            if (textBox2.TextLength < 2)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 2)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

            if (textBox2.TextLength < 2)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
