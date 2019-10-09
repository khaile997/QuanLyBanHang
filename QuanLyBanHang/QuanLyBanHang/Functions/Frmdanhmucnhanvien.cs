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
    public partial class Frmdanhmucnhanvien : Form
    {
        public Frmdanhmucnhanvien()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseQuanLyBanHangDataSet);

        }

        private void Frmdanhmucnhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.employees);

        }
    }
}
