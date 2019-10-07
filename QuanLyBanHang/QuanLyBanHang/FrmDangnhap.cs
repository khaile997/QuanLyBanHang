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
    public partial class FrmDangnhap : Form
    {
        public FrmDangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txttendangnhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được rỗng!");
            }
            else if(txtmatkhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được rỗng!");
            }
            else if(txttendangnhap.Text != "admin" && txtmatkhau.Text != "123456")
            {
                MessageBox.Show("Đăng nhập không thành công! Vui lòng kiểm tra lại tài khoản và mật khẩu.");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!");
                FrmTrangchinh frm = new FrmTrangchinh();
                frm.Show();
                this.Hide();
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
