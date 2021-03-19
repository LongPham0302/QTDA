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
    public partial class Quanlybanhang : Form
    {
        public Quanlybanhang()
        {
            InitializeComponent();
        }

        private void buttonThoatBH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLamMoiBH_Click(object sender, EventArgs e)
        {
            ClearText();
            HienThi();
            textBoxMaHD.Enabled = true;
        }

        private void ClearText()
        {
            textBoxMaHD.Clear();
            textBoxNgaymua.Clear();
            textBoxMaNV.ResetText();
            textBoxTenNV.Clear();
            textBoxTenKH.Clear();
            textBoxDiaChi.Clear();
            textBoxSDT.Clear();
            textBoxMaDH.ResetText();
            textBoxTenDH.Clear();
            textBoxDonGia.Clear();
            textBoxSoLuong.Clear();
            textBoxThanhTienn.Clear();
            textBoxTenDH.Clear();
        }

        public void HienThi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from ChiTietHoaDon", conn);
            DataTable tb = new DataTable();
            conn.Open();
            tb.Load(cmd.ExecuteReader());
            HoaDonBanHang.DataSource = tb;
            conn.Close();
        }

        private void Quanlybanhang_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        

        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietHoaDon VALUES (@MaHD,@NgayBan,@TenNV,@MaNV,@TenKH,@SDT,@DiaChi,@ThanhTien,@MaSP,@SoLuong,@DonGia,@TenVL)", conn);
            cmd.Parameters.AddWithValue("@MaHD", textBoxMaHD.Text);
            cmd.Parameters.AddWithValue("@NgayBan", textBoxNgaymua.Text);
            cmd.Parameters.AddWithValue("@TenNV",textBoxTenNV.Text);
            cmd.Parameters.AddWithValue("@MaNV",textBoxMaNV.Text);
            cmd.Parameters.AddWithValue("@TenKH",textBoxTenKH.Text);
            cmd.Parameters.AddWithValue("@SDT",textBoxSDT.Text);
            cmd.Parameters.AddWithValue("@DiaChi",textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("@ThanhTien",textBoxThanhTienn.Text);
            cmd.Parameters.AddWithValue("@MaSP",textBoxMaDH.Text);
            cmd.Parameters.AddWithValue("@SoLuong",textBoxSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia",textBoxDonGia.Text);
            cmd.Parameters.AddWithValue("@TenVL", textBoxDonGia.Text);


            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "ChiTietHoaDon");
            HoaDonBanHang.DataSource = ds.Tables["ChiTietHoaDon"];
            HienThi();
        }

        private void buttonSuaHD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE ChiTietHoaDon SET NgayBan=@NgayBan,TenNV=@TenNV,MaNV=@MaNV,TenKH=@TenKH,SDT=@SDT,DiaChi=@DiaChi,ThanhTien=@ThanhTien,MaSP=@MaSP,SoLuong=@SoLuong,DonGia=@DonGia, TenVL= @TenVL where MaHD=@MaHD", conn);
            cmd.Parameters.AddWithValue("@MaHD", textBoxMaHD.Text);
            cmd.Parameters.AddWithValue("@NgayBan", textBoxNgaymua.Text);
            cmd.Parameters.AddWithValue("@TenNV", textBoxTenNV.Text);
            cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
            cmd.Parameters.AddWithValue("@TenKH", textBoxTenKH.Text);
            cmd.Parameters.AddWithValue("@SDT", textBoxSDT.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", textBoxThanhTienn.Text);
            cmd.Parameters.AddWithValue("@MaSP", textBoxMaDH.Text);
            cmd.Parameters.AddWithValue("@SoLuong", textBoxSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", textBoxDonGia.Text);
            cmd.Parameters.AddWithValue("@TenVL", textBoxTenDH.Text);


            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "ChiTietHoaDon");
            HoaDonBanHang.DataSource = ds.Tables["ChiTietHoaDon"];
            HienThi();
        }

        private void buttonXoaHD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4JVOR\SQLEXPRESS;Initial Catalog=vlxd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE from ChiTietHoaDon where MaHD=@MaHD", conn);
            cmd.Parameters.AddWithValue("@MaHD", textBoxMaHD.Text);
            cmd.Parameters.AddWithValue("@NgayBan", textBoxNgaymua.Text);
            cmd.Parameters.AddWithValue("@TenNV", textBoxTenNV.Text);
            cmd.Parameters.AddWithValue("@MaNV", textBoxMaNV.Text);
            cmd.Parameters.AddWithValue("@TenKH", textBoxTenKH.Text);
            cmd.Parameters.AddWithValue("@SDT", textBoxSDT.Text);
            cmd.Parameters.AddWithValue("@DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", textBoxThanhTienn.Text);
            cmd.Parameters.AddWithValue("@MaSP", textBoxMaDH.Text);
            cmd.Parameters.AddWithValue("@SoLuong", textBoxSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", textBoxDonGia.Text);
            cmd.Parameters.AddWithValue("@TenVL", textBoxTenDH.Text);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "ChiTietHoaDon");
            HoaDonBanHang.DataSource = ds.Tables["ChiTietHoaDon"];
            HienThi();
        }

        private void buttonInHD_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Hóa đơn in thành công", "Warning!", MessageBoxButtons.OK);
        }

        private void HoaDonBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id >= 0)
            {
                textBoxMaHD.Text = HoaDonBanHang.Rows[id].Cells["MaHD"].Value.ToString();
                textBoxMaDH.Text = HoaDonBanHang.Rows[id].Cells["MaSP"].Value.ToString();
                textBoxSoLuong.Text = HoaDonBanHang.Rows[id].Cells["SoLuong"].Value.ToString();
                textBoxDonGia.Text = HoaDonBanHang.Rows[id].Cells["DonGia"].Value.ToString();
                textBoxThanhTienn.Text = HoaDonBanHang.Rows[id].Cells["ThanhTien"].Value.ToString();
                textBoxMaHD.Text = HoaDonBanHang.Rows[id].Cells["MaHD"].Value.ToString();
                textBoxNgaymua.Text = HoaDonBanHang.Rows[id].Cells["NgayBan"].Value.ToString();
                textBoxMaNV.Text = HoaDonBanHang.Rows[id].Cells["MaNV"].Value.ToString();
                textBoxTenNV.Text = HoaDonBanHang.Rows[id].Cells["TenNV"].Value.ToString();
                textBoxTenKH.Text = HoaDonBanHang.Rows[id].Cells["TenKH"].Value.ToString();
                textBoxDiaChi.Text = HoaDonBanHang.Rows[id].Cells["DiaChi"].Value.ToString();
                textBoxSDT.Text = HoaDonBanHang.Rows[id].Cells["SDT"].Value.ToString();
                textBoxTenDH.Text = HoaDonBanHang.Rows[id].Cells["TenVL"].Value.ToString();
                HienThi();
            }
            textBoxMaHD.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelTenDongHo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxThanhTien_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dongia;
            int soluong;
            int thanhtien;
            dongia = Convert.ToInt16(textBoxDonGia.Text);
            soluong = Convert.ToInt16(textBoxSoLuong.Text);
            thanhtien = soluong * dongia;
            textBoxThanhTienn.Text = thanhtien.ToString();
        }

        private void HoaDonBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelDiaChi_Click(object sender, EventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
