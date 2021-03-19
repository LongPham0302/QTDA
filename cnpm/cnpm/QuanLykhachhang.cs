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
    public partial class QuanLykhachhang : Form
    {
        public QuanLykhachhang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien VALUES (@MaKhachHang,@MaSP,@DiaChi,@SoDienThoai,@TenKH,@MaHD)", conn);
            cmd.Parameters.AddWithValue("@MaKhachHang", textBox1.Text);
            cmd.Parameters.AddWithValue("@MaSP", textBox2.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBox3.Text);
            cmd.Parameters.AddWithValue("@SoDienThoai", textBox4.Text);
            cmd.Parameters.AddWithValue("@TenKH", textBox5.Text);
            cmd.Parameters.AddWithValue("@MaHD", textBox6.Text);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
            HienThi();

        }

        private void QuanLykhachhang_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from KhachHang", conn);
            DataTable tb = new DataTable();
            conn.Open();
            tb.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = tb;
            conn.Close();

        }
        public void HienThi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from KhachHang", conn);
            DataTable tb = new DataTable();
            conn.Open();
            tb.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = tb;
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE KhachHang Set MaKhachHang=@MaKhachHang, MaSP=@MaSP, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, @MaHD=@MaHD where MaKhachHang=@MaKhachHang", conn);
            cmd.Parameters.AddWithValue("@MaKhachHang", textBox1.Text);
            cmd.Parameters.AddWithValue("@MaSP", textBox2.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBox3.Text);
            cmd.Parameters.AddWithValue("@SoDienThoai", textBox4.Text);
            cmd.Parameters.AddWithValue("@TenKH", textBox5.Text);
            cmd.Parameters.AddWithValue("@MaHD", textBox6.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE from KhachHang where MaKhachHang=@MaKhachHang", conn);
            cmd.Parameters.AddWithValue("@MaKhachHang", textBox1.Text);
            cmd.Parameters.AddWithValue("@MaSP", textBox2.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBox3.Text);
            cmd.Parameters.AddWithValue("@SoDienThoai", textBox4.Text);
            cmd.Parameters.AddWithValue("@TenKH", textBox5.Text);
            cmd.Parameters.AddWithValue("@MaHD", textBox6.Text);
            
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT* from KhachHang where MaKhachHang=@MaKhachHang", conn);
            cmd.Parameters.AddWithValue("@MaKhachHang", textBox1.Text);
            cmd.Parameters.AddWithValue("@MaSP", textBox2.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBox3.Text);
            cmd.Parameters.AddWithValue("@SoDienThoai", textBox4.Text);
            cmd.Parameters.AddWithValue("@TenKH", textBox5.Text);
            cmd.Parameters.AddWithValue("@MaHD", textBox6.Text);
       

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
            conn.Open();
            DataTable tb = new DataTable();
            tb.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = tb;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearText();
            textBox1.Enabled = true;
        }
        private void ClearText()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
       
        private void getdata(string MaKhachHang)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from KhachHang where MaKhachHang=@MaKhach", conn);

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
            conn.Close();
        }

        // dataGridViewNV_CellClick
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id >= 0)
            {
                textBox1.Text = dataGridView1.Rows[id].Cells["MaKhachHang"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[id].Cells["MaSP"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[id].Cells["DiaChi"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[id].Cells["SoDienThoai"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[id].Cells["TenKH"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[id].Cells["MaHD"].Value.ToString();

            }
            textBox1.Enabled = false;
        }
    }
}


