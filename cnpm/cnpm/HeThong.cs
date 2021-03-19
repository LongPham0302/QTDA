using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnpm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DangNhap f1 = new DangNhap();
            DialogResult rs = f1.ShowDialog();
            if(rs==DialogResult.OK)
            {
                this.Show();
                f1.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void quanLyBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlybanhang f4 = new Quanlybanhang();
            f4.Show();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhanvien f3 = new Quanlynhanvien();
            f3.Show();
            
        }

        private void quanLyHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlysanpham f5 = new Quanlysanpham();
            f5.Show();
           
        }

        private void suaTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaTaiKhoan f6 = new SuaTaiKhoan();
            f6.Show();
       
        }

        private void thoatChuongTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Ban chac chan muon thoat?", "Warning!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void quanLuKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLykhachhang quanlikhachhang = new QuanLykhachhang();
            quanlikhachhang.Show();
        }
    }
}
