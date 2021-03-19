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
    public partial class SuaTaiKhoan : Form
    {
        public SuaTaiKhoan()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE Nguoidung SET Matkhau=@Matkhau where Taikhoan=@Taikhoan ",conn);
            cmd.Parameters.AddWithValue("@Taikhoan", textBoxTenDangNhap.Text);
            cmd.Parameters.AddWithValue("@Matkhau", textBoxMatKhauMoi.Text);

            /*string username = textBoxTenDangNhap.Text;
            string password = textBoxMatKhau.Text;
            string newpass = textBoxMatKhauMoi.Text;
            string reenterPass = textBoxNhapLai.Text;

            if(!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui long nhap lai mat khau dung voi mat khau moi !");
            }    
            else
            {

            }*/
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "Nguoidung");
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("da thay doi mat khau","Warning!");


        }
    }
}
