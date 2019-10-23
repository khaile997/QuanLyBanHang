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

namespace QuanLyBanHang
{
    public partial class Frmcauhinh : Form
    {
        public Frmcauhinh()
        {
            InitializeComponent();
        }
        string connectionString = QuanLyBanHang.Properties.Settings.Default.DatabaseQuanLyBanHangConnectionString;

        private void Frmcauhinh_Load(object sender, EventArgs e)
        {
           
            Loaddanhmuccauhinh();
            
        }

        #region methods
        public void Loaddanhmuccauhinh()
        {
           
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM configs";

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
                        adapter.Fill(databaseQuanLyBanHangDataSet.configs);
                        // Hiển thị dữ liệu lên datagridview
                        configsBindingSource.DataSource = databaseQuanLyBanHangDataSet.configs;
                        
                        configsDataGridView.Refresh();
                        // Tắt kết nối đến Database Server
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
        public void Reset()
        {
            idTextBox.Text = "";
            valueTextBox.Text = "";
            keyTextBox.Text = "";
        }
        #endregion

        #region event
        private void btnthem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(keyTextBox.Text) || String.IsNullOrEmpty(valueTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"UPDATE configs SET [key] = @key, [value] = @value WHERE id = @id";
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
                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", idTextBox.Text);
                        command.Parameters.AddWithValue("@key", keyTextBox.Text);
                        command.Parameters.AddWithValue("@value", valueTextBox.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        // Load lại danh sách cấu hình
                        MessageBox.Show("Dữ Liệu Được Sửa Thành Công!");
                        Loaddanhmuccauhinh();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để xác nhận có chắc chắn muốn xóa hay không?
            DialogResult confirmDelete = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (confirmDelete != DialogResult.Yes)
            {
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"DELETE FROM configs WHERE id = @id";
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
                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", idTextBox.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        // Load lại danh sách cấu hình
                        MessageBox.Show("Xóa Dữ Liệu Thành Công!");
                        databaseQuanLyBanHangDataSet.Clear();
                        Loaddanhmuccauhinh();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(keyTextBox.Text) || String.IsNullOrEmpty(valueTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"INSERT INTO configs([key], [value]) VALUES(@key, @value)";

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
                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@key", keyTextBox.Text);
                        command.Parameters.AddWithValue("@value", valueTextBox.Text);
                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();
                        // Ngắt kết nối đến Database Server
                        connection.Close();
                        MessageBox.Show("Dữ Liệu Được Lưu Thành Công!");
                        // Load lại danh sách cấu hình
                        Loaddanhmuccauhinh();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


    }
}
            
        
