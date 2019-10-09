﻿using System;
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
    public partial class Frmdanhmucdathang : Form
    {
        public Frmdanhmucdathang()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseQuanLyBanHangDataSet);

        }

        private void Frmdanhmucdathang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.order_details' table. You can move, or remove it, as needed.
            this.order_detailsTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.order_details);
            // TODO: This line of code loads data into the 'databaseQuanLyBanHangDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseQuanLyBanHangDataSet.orders);

        }
    }
}
