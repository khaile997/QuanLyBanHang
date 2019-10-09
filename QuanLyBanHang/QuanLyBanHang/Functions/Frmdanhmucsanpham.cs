using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Functions
{
    public partial class Frmdanhmucsanpham : Form
    {
        public Frmdanhmucsanpham()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseQuanLyBanHangDataSet);

        }

        private void Frmdanhmucsanpham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.products);

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            FrmTrangchinh trangchinh = new FrmTrangchinh();
            this.Close();
            trangchinh.Show();
        }
    }
}
