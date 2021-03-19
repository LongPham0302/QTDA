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
    public partial class Quanlynhanvien : Form
    {
        public Quanlynhanvien()
        {
            InitializeComponent();
        }

        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from NhanVien", conn);
            DataTable tb = new DataTable();
            conn.Open();
            tb.Load(cmd.ExecuteReader());
            dataGridViewNV.DataSource = tb;
            conn.Close();
        }

        public void HienThi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from NhanVien", conn);
            DataTable tb = new DataTable();
            conn.Open();
            tb.Load(cmd.ExecuteReader());
            dataGridViewNV.DataSource = tb;
            conn.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien VALUES (@MaNV,@TenNV,@NgaySinh,@DiaChi,@SDT,@GioiTinh)", conn);
            cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", textBoxTenNV.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", textBoxNgaySinh.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", textBoxSDT.Text);
            if (checkBoxNam.Checked == true)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nam");
            }
            else
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nữ");
            }

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "NhanVien");
            dataGridViewNV.DataSource = ds.Tables["NhanVien"];
            HienThi();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien Set TenNV=@TenNV, NgaySinh=@NgaySinh, DiaChi=@DiaChi, SDT=@SDT, GioiTinh=@GioiTinh where MaNV=@MaNV", conn);
            cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", textBoxTenNV.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", textBoxNgaySinh.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", textBoxSDT.Text);
            if (checkBoxNam.Checked == true)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nam");
            }
            else
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nữ");
            }


            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "NhanVien");
            dataGridViewNV.DataSource = ds.Tables["NhanVien"];
            HienThi();
        }

        private void buttonXoaNV_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE from NhanVien where MaNV=@MaNV", conn);
            cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", textBoxTenNV.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", textBoxNgaySinh.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", textBoxSDT.Text);
            if (checkBoxNam.Checked == true)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nam");
            }
            else
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nữ");
            }

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "NhanVien");
            dataGridViewNV.DataSource = ds.Tables["NhanVien"];
            HienThi();
        }

        private void buttonTimKiemNV_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT* from NhanVien where MaNV=@MaNV", conn);
            cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", textBoxTenNV.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", textBoxNgaySinh.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", textBoxSDT.Text);
            if (checkBoxNam.Checked == true)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nam");
            }
            else
            {
                cmd.Parameters.AddWithValue("@GioiTinh", "Nữ");
            }

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "NhanVien");
            dataGridViewNV.DataSource = ds.Tables["NhanVien"];
            conn.Open();
            DataTable tb = new DataTable();
            tb.Load(cmd.ExecuteReader());
            dataGridViewNV.DataSource = tb;
            conn.Close();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id >= 0)
            {
                textBoxMaNV.Text = dataGridViewNV.Rows[id].Cells["MaNV"].Value.ToString();
                textBoxTenNV.Text = dataGridViewNV.Rows[id].Cells["TenNV"].Value.ToString();
                textBoxDiaChi.Text = dataGridViewNV.Rows[id].Cells["DiaChi"].Value.ToString();
                textBoxNgaySinh.Text = dataGridViewNV.Rows[id].Cells["NgaySinh"].Value.ToString();
                textBoxSDT.Text = dataGridViewNV.Rows[id].Cells["SDT"].Value.ToString();
                string GioiTinh = dataGridViewNV.Rows[id].Cells["GioiTinh"].Value.ToString();
                if (GioiTinh == "Nam")
                {
                    checkBoxNam.Checked = true;
                }
                else
                {
                    checkBoxNu.Checked = true;
                }

                textBoxMaNV.Enabled = false;
            }
        }
        private void ClearText()
        {
            textBoxMaNV.Clear();
            textBoxTenNV.Clear();
            textBoxDiaChi.Clear();
            textBoxNgaySinh.Clear();
            textBoxSDT.Clear();
            checkBoxNam.Checked = false;
            checkBoxNu.Checked = false;
        }

        private void buttonLamMoiNV_Click_1(object sender, EventArgs e)
        {
            ClearText();
            textBoxMaNV.Enabled = true;
        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
