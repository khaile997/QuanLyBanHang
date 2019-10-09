using QuanLyBanHang.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FrmTrangchinh : Form
    {
        public FrmTrangchinh()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhmuckhachhang khachhang = new FrmDanhmuckhachhang();
            khachhang.Show();
            this.Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdanhmucnhanvien nhanvien = new Frmdanhmucnhanvien();
            nhanvien.Show();
            this.Hide();

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdanhmucsanpham sanpham = new Frmdanhmucsanpham();
            sanpham.Show();
            this.Hide();
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdanhmucdathang dathang = new Frmdanhmucdathang();
            dathang.Show();
            this.Hide();
        }
    }
}
