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
            Loaddanhsachkhachhang();
            Loaddanhsachsanpham();

            this.FormStatus = "View";
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

        public void Loadchitietdonhang(int iddonhnag)
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM order_details WHERE order_id = {0}", iddonhnag);

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
                        databaseQuanLyBanHangDataSet.order_details.Clear();
                        adapter.Fill(databaseQuanLyBanHangDataSet.order_details);

                        // Hiển thị dữ liệu
                        order_detailsBindingSource.DataSource = databaseQuanLyBanHangDataSet.order_details;
                        dgvchitietdonhang.Refresh();

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
        SortedDictionary<int, string> listCustumoer = new SortedDictionary<int, string>();
        SortedDictionary<int, string> listProduct = new SortedDictionary<int, string>();
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

        public void Loaddanhsachkhachhang()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM customers");

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
                            listCustumoer.Add(key, value);
                        }
                        customer_idComboBox.DataSource = new BindingSource(listCustumoer, null);
                        customer_idComboBox.DisplayMember = "Value";
                        customer_idComboBox.ValueMember = "Key";

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

        public void Loaddanhsachsanpham()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM products");

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
                        adapter.Fill(databaseQuanLyBanHangDataSet.products);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in databaseQuanLyBanHangDataSet.products.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["product_name"].ToString();
                            listProduct.Add(key, value);
                        }
                        product_idComboBox.DataSource = new BindingSource(listProduct, null);
                        product_idComboBox.DisplayMember = "Value";
                        product_idComboBox.ValueMember = "Key";

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

        public void ClearData()
        {
            employee_idComboBox.Text = "";
            customer_idComboBox.Text = "";
            // Clear thông tin Đơn hàng
            order_dateDateTimePicker.Value = DateTime.Now;
            shipped_dateDateTimePicker.Value = DateTime.Now;
            ship_nameTextBox.Text = "";
            ship_address1TextBox.Text = "";
            ship_address2TextBox.Text = "";
            ship_cityTextBox.Text = "";
            ship_countryTextBox.Text = "";
            ship_postal_codeTextBox.Text = "";
            ship_stateTextBox.Text = "";
            shipping_feeNumericUpDown.Value = 0;
            payment_typeTextBox.Text = "";
            paid_dateDateTimePicker.Value = DateTime.Now;
            order_statusTextBox.Text = "";
            // Clear thông tin chi tiết đơn hàng

            product_idComboBox.Text = "";
            quantityNumericUpDown.Value = 0;
            unit_priceNumericUpDown.Value = 0;
            discountNumericUpDown.Value = 0;
            databaseQuanLyBanHangDataSet.order_details.Clear();
        }
        #endregion

        #region event
        private void btndonhang_Click(object sender, EventArgs e)
        {
            Loaddanhsachdonhang();
        }

        private void btnthemchitiet_Click(object sender, EventArgs e)
        {
            // Chuẩn bị dữ liệu thêm dòng mới
            int orderId = 0;
            int productId = ((KeyValuePair<int, string>)product_idComboBox.SelectedItem).Key;
            decimal soLuong = quantityNumericUpDown.Value;
            decimal donGia = unit_priceNumericUpDown.Value;
            decimal giamGia = discountNumericUpDown.Value;
            string status = "On Order";
            string dateAllocated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Thêm vào grid order_details
            databaseQuanLyBanHangDataSet.order_details.Rows.Add(orderId, productId, soLuong, donGia, giamGia, status, dateAllocated);

            // Clear dữ liệu
            product_idComboBox.Text = "";
            quantityNumericUpDown.Value = 0;
            unit_priceNumericUpDown.Value = 0;
            discountNumericUpDown.Value = 0;
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ClearData();
            this.FormStatus = "Create";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Xử lý theo từng trường hợp
            switch (this.FormStatus)
            {
                // Xử lý Lưu cho trường hợp Thêm mới dữ liệu
                case "Create":
                    // Tạo câu lệnh để thực thi đến database
                    string queryString = @"INSERT INTO orders(employee_id, customer_id, order_date, shipped_date, ship_name, ship_address1, ship_address2, ship_city, ship_state, ship_postal_code, ship_country, shipping_fee, payment_type, paid_date, order_status)"
                                       + " VALUES(@employee_id, @customer_id, @order_date, @shipped_date, @ship_name, @ship_address1, @ship_address2, @ship_city, @ship_state, @ship_postal_code, @ship_country, @shipping_fee, @payment_type, @paid_date, @order_status);"
                                       + " SELECT CAST(scope_identity() AS int)";

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
                                command.Parameters.AddWithValue("@employee_id", ((KeyValuePair<int, string>)employee_idComboBox.SelectedItem).Key);
                                command.Parameters.AddWithValue("@customer_id", ((KeyValuePair<int, string>)customer_idComboBox.SelectedItem).Key);
                                command.Parameters.AddWithValue("@order_date", order_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                command.Parameters.AddWithValue("@shipped_date", shipped_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                command.Parameters.AddWithValue("@ship_name", ship_nameTextBox.Text);
                                command.Parameters.AddWithValue("@ship_address1", ship_address1TextBox.Text);
                                command.Parameters.AddWithValue("@ship_address2", ship_address2TextBox.Text);
                                command.Parameters.AddWithValue("@ship_city", ship_cityTextBox.Text);
                                command.Parameters.AddWithValue("@ship_state", ship_stateTextBox.Text);
                                command.Parameters.AddWithValue("@ship_postal_code", ship_postal_codeTextBox.Text);
                                command.Parameters.AddWithValue("@ship_country", ship_countryTextBox.Text);
                                command.Parameters.AddWithValue("@shipping_fee", shipping_feeNumericUpDown.Value);
                                command.Parameters.AddWithValue("@payment_type", payment_typeTextBox.Text);
                                command.Parameters.AddWithValue("@paid_date", paid_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                command.Parameters.AddWithValue("@order_status", order_statusTextBox.Text);

                                // Thực thi câu lệnh INSERT order và lấy ORDER_ID
                                int orderIdInserted = (int)command.ExecuteScalar();

                                // Insert table Order_details
                                foreach (DataRow row in databaseQuanLyBanHangDataSet.order_details.Rows)
                                {
                                    int orderId = orderIdInserted;
                                    int productId = Convert.ToInt32(row["product_id"]);
                                    decimal soLuong = Convert.ToInt32(row["quantity"]);
                                    decimal donGia = Convert.ToInt32(row["unit_price"]);
                                    decimal giamGia = Convert.ToInt32(row["discount"]);
                                    string status = row["order_detail_status"].ToString();
                                    string dateAllocated = row["date_allocated"].ToString();

                                    string subQueryString = @"INSERT INTO order_details(order_id, product_id, quantity, unit_price, discount, order_detail_status, date_allocated)"
                                       + " VALUES(@order_id, @product_id, @quantity, @unit_price, @discount, @order_detail_status, @date_allocated)";

                                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                                    using (SqlCommand subCommand = new SqlCommand(subQueryString, connection))
                                    {
                                        // Truyền dữ liệu vào đúng tham số
                                        subCommand.CommandType = CommandType.Text;
                                        subCommand.Parameters.AddWithValue("@order_id", orderId);
                                        subCommand.Parameters.AddWithValue("@product_id", productId);
                                        subCommand.Parameters.AddWithValue("@quantity", soLuong);
                                        subCommand.Parameters.AddWithValue("@unit_price", donGia);
                                        subCommand.Parameters.AddWithValue("@discount", giamGia);
                                        subCommand.Parameters.AddWithValue("@order_detail_status", status);
                                        subCommand.Parameters.AddWithValue("@date_allocated", dateAllocated);

                                        subCommand.ExecuteNonQuery();
                                    }
                                }

                                // Ngắt kết nối đến Database Server
                                connection.Close();

                                // Load lại danh sách cấu hình
                                //LoadDanhMucCauHinh();
                            }
                            catch (Exception ex)
                            {
                                // Hiển thị thông báo nếu có lỗi
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    break;
                // Xử lý Lưu cho trường hợp Sửa dữ liệu
                case "Edit":
                    // TODO: xử lý lưu
                    break;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region StatusForm
        string formStatus = "View";

        public string FormStatus
        {
             get
            {
                return formStatus;
            }
            set
            {
                formStatus = value;
                // Thay đổi trạng thái của các Controls tương ứng với Trạng thái của Form
                switch (formStatus)
                {
                    case "View":
                        // Danh sách Đơn hàng
                        dtpformdate.Enabled = true;
                        dtptodate.Enabled = true;
                        btndonhang.Enabled = true;

                        // Thông tin Đơn hàng
                        grbthongtindonhang.Enabled = false;

                        // Thông tin Chi tiết Đơn hàng
                        grbchitietdonhang.Enabled = false;
                        break;
                    case "Create":
                        // Danh sách Đơn hàng
                        dtpformdate.Enabled = false;
                        dtptodate.Enabled = false;
                        btndonhang.Enabled = false;

                        // Thông tin Đơn hàng
                        grbthongtindonhang.Enabled = true;

                        // Thông tin Chi tiết Đơn hàng
                        grbchitietdonhang.Enabled = true;
                        break;
                    case "Edit":
                        // Danh sách Đơn hàng
                        dtpformdate.Enabled = false;
                        dtptodate.Enabled = false;
                        btndonhang.Enabled = false;

                        // Thông tin Đơn hàng
                        grbthongtindonhang.Enabled = true;

                        // Thông tin Chi tiết Đơn hàng
                        grbchitietdonhang.Enabled = true;
                        break;
                }
            }
        }
        #endregion

        private void dgvdonhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ xử lý Binding khi Form đang ở trạng thái "View"
            if (this.FormStatus != "View")
            {
                return;
            }

            // Nếu đang chọn dòng dữ liệu (RowIndex > 0)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.dgvdonhang.Rows[e.RowIndex];

                // Binding vào các ComboBox tương ứng
                // - ComboBox Nhân viên (Employee)
                if (row.Cells["employeeidDataGridViewTextBoxColumn"].Value != null && row.Cells["employeeidDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    var idEmployee = Convert.ToInt32(row.Cells["employeeidDataGridViewTextBoxColumn"].Value);
                    employee_idComboBox.SelectedItem = employee_idComboBox.Items.Cast<KeyValuePair<int, string>>().First(item => item.Key == idEmployee);
                }

                // - ComboBox Khách hàng (Customer)
                if (row.Cells["customeridDataGridViewTextBoxColumn"].Value != null && row.Cells["customeridDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    var idCustomer = Convert.ToInt32(row.Cells["customeridDataGridViewTextBoxColumn"].Value);
                    customer_idComboBox.SelectedItem = customer_idComboBox.Items.Cast<KeyValuePair<int, string>>().First(item => item.Key == idCustomer);
                }

                // Binding vào các textbox thông tin Order tương ứng
                // TODO: bổ sung đầy đủ Binding cho các trường cần thiết
                if (row.Cells["orderdateDataGridViewTextBoxColumn"].Value != null && row.Cells["orderdateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    order_dateDateTimePicker.Text = row.Cells["orderdateDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (row.Cells["shipnameDataGridViewTextBoxColumn"].Value != null && row.Cells["shipnameDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    ship_nameTextBox.Text = row.Cells["shipnameDataGridViewTextBoxColumn"].Value.ToString();
                }

                // Load chi tiết đơn hàng bởi ID đơn hàng
                if (row.Cells["idDataGridViewTextBoxColumn"].Value != null && row.Cells["idDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    var idDonHang = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                    Loadchitietdonhang(idDonHang);
                }
            }
        }

    }
}
