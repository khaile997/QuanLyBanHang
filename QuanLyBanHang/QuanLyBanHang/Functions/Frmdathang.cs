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

namespace QuanLyBanHang.Functions
{
    public partial class Frmdathang : Form
    {
        public Frmdathang()
        {
            InitializeComponent();
        }
        string connectionString = QuanLyBanHang.Properties.Settings.Default.DatabaseQuanLyBanHangConnectionString;
        private void Frmdathang_Load(object sender, EventArgs e)
        {
            //load danh mục nhân viên
            Loaddanhsachnhanvien();

        }

        #region method
        public void Loaddanhsachdonhang()
        {
            string tuNgay = dtpformdate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string denNgay = dtptodate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM orders WHERE order_date BETWEEN '{0}' AND '{1}'", tuNgay, denNgay);

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();
                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        // Đổ dữ liệu vào dataset
                        databaseQuanLyBanHangDataSet.orders.Clear();
                        adapter.Fill(databaseQuanLyBanHangDataSet.orders);
                        // Hiển thị dữ liệu
                       
                        ordersBindingSource.DataSource = databaseQuanLyBanHangDataSet.orders;
                        dgvdonhang.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        SortedDictionary<int, string> listEmployees = new SortedDictionary<int, string>();
        public void Loaddanhsachnhanvien()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM employees");
            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;   
                        // Đổ dữ liệu vào dataset
                        adapter.Fill(databaseQuanLyBanHangDataSet.employees);
                        // Hiển thị dữ liệu
                        foreach (DataRow row in databaseQuanLyBanHangDataSet.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listEmployees.Add(key, value);
                        }
                        employee_idComboBox.DataSource = new BindingSource(listEmployees, null);
                        employee_idComboBox.DisplayMember = "Value";
                        employee_idComboBox.ValueMember = "Key";
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region event
        private void btndonhang_Click(object sender, EventArgs e)
        {
            Loaddanhsachdonhang();
        }

        private void btnthemchitiet_Click(object sender, EventArgs e)
        {

        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
