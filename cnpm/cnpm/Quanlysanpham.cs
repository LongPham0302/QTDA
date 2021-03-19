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
    public partial class Quanlysanpham : Form
    {
        public Quanlysanpham()
        {
            InitializeComponent();
        }

        private void Quanlyhanghoa_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from SanPham", conn);
            DataTable tb = new DataTable();
            conn.Open();
            tb.Load(cmd.ExecuteReader());
            dataGridViewSP.DataSource = tb;
            conn.Close();
        }

        public void HienThi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from SanPham", conn);
            DataTable tb = new DataTable();
            conn.Open();
            tb.Load(cmd.ExecuteReader());
            dataGridViewSP.DataSource = tb;
            conn.Close();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO SanPham VALUES (@MaSP,@TenSP,@SoLuong,@DonGia,@GiaNhap,@TonKho)",conn);
            cmd.Parameters.AddWithValue("@MaSP", textBoxMaSP.Text);
            cmd.Parameters.AddWithValue("@TenSP", textBoxTenSP.Text);
            cmd.Parameters.AddWithValue("@SoLuong", textBoxSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", textBoxDonGia.Text);
            cmd.Parameters.AddWithValue("@GiaNhap", textBoxGiaNhap.Text);
            cmd.Parameters.AddWithValue("@TonKho", textBoxTonKho.Text);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "SanPham");
            dataGridViewSP.DataSource = ds.Tables["SanPham"];
            HienThi();

        }

        private void buttonSuaSP_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE SanPham SET TenSP=@TenSP, SoLuong=@SoLuong, DonGia=@DonGia, GiaNhap=@GiaNhap, TonKho=@TonKho where MaSP=@MaSP", conn);
            cmd.Parameters.AddWithValue("@MaSP", textBoxMaSP.Text);
            cmd.Parameters.AddWithValue("@TenSP", textBoxTenSP.Text);
            cmd.Parameters.AddWithValue("@SoLuong", textBoxSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", textBoxDonGia.Text);
            cmd.Parameters.AddWithValue("@GiaNhap", textBoxGiaNhap.Text);
            cmd.Parameters.AddWithValue("@TonKho", textBoxTonKho.Text);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "SanPham");
            dataGridViewSP.DataSource = ds.Tables["SanPham"];
            HienThi();
        }

        private void buttonXoaSP_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE from SanPham where MaSP=@MaSP", conn);
            cmd.Parameters.AddWithValue("@MaSP", textBoxMaSP.Text);
            cmd.Parameters.AddWithValue("@TenSP", textBoxTenSP.Text);
            cmd.Parameters.AddWithValue("@SoLuong", textBoxSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", textBoxDonGia.Text);
            cmd.Parameters.AddWithValue("@GiaNhap", textBoxGiaNhap.Text);
            cmd.Parameters.AddWithValue("@TonKho", textBoxTonKho.Text);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "SanPham");
            dataGridViewSP.DataSource = ds.Tables["SanPham"];
            HienThi();
        }

        private void buttonTimKiemSP_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * from SanPham where MaSP=@MaSP", conn);
            cmd.Parameters.AddWithValue("@MaSP", textBoxMaSP.Text);
            cmd.Parameters.AddWithValue("@TenSP", textBoxTenSP.Text);
            cmd.Parameters.AddWithValue("@SoLuong", textBoxSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", textBoxDonGia.Text);
            cmd.Parameters.AddWithValue("@GiaNhap", textBoxGiaNhap.Text);
            cmd.Parameters.AddWithValue("@TonKho", textBoxTonKho.Text);

            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "SanPham");
            dataGridViewSP.DataSource = ds.Tables["SanPham"];
            DataTable tb = new DataTable();
            tb.Load(cmd.ExecuteReader());
            dataGridViewSP.DataSource = tb;
            conn.Close();
        }

        private void getdata(string MaSP)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from SanPham where MaSP=@MaSP",conn);
                    
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "sanpham");
            dataGridViewSP.DataSource = ds.Tables["sanpham"];
            conn.Close();
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int id = e.RowIndex;
                if (id >= 0)
                {
                    textBoxMaSP.Text = dataGridViewSP.Rows[id].Cells["MaSP"].Value.ToString();
                    textBoxTenSP.Text = dataGridViewSP.Rows[id].Cells["TenSP"].Value.ToString();
                    textBoxDonGia.Text = dataGridViewSP.Rows[id].Cells["DonGia"].Value.ToString();
                    textBoxGiaNhap.Text = dataGridViewSP.Rows[id].Cells["GiaNhap"].Value.ToString();
                    textBoxTonKho.Text = dataGridViewSP.Rows[id].Cells["TonKho"].Value.ToString();
                    textBoxSoLuong.Text = dataGridViewSP.Rows[id].Cells["SoLuong"].Value.ToString();
                    
                }
                textBoxMaSP.Enabled = false;
        }

        private void ClearText()
        {
            textBoxMaSP.Clear();
            textBoxTenSP.Clear();
            textBoxDonGia.Clear();
            textBoxGiaNhap.Clear();
            textBoxTonKho.Clear();
            textBoxSoLuong.Clear();
        }

        private void buttonLamMoiHH_Click(object sender, EventArgs e)
        {
            ClearText();
            textBoxMaSP.Enabled = true;
        }

        private void dataGridViewSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
