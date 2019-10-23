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
            khachhang.MdiParent = this;
            khachhang.Show();
           
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdanhmucnhanvien nhanvien = new Frmdanhmucnhanvien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
    

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdanhmucsanpham sanpham = new Frmdanhmucsanpham();
            sanpham.MdiParent = this;
            sanpham.Show();
            
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdathang dathang = new Frmdathang();
            dathang.MdiParent = this;
            dathang.Show();
           
        }

        private void cấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcauhinh cauhinh = new Frmcauhinh();
            cauhinh.MdiParent = this;
            cauhinh.Show();
            
        }

        private void đặtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmdanhmucdathang dmdathang = new Frmdanhmucdathang();
            dmdathang.MdiParent = this;
            dmdathang.Show();
        }
    }
}
