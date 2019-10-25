namespace QuanLyBanHang.Functions
{
    partial class Frmdathang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label shipped_dateLabel;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label ship_address1Label;
            System.Windows.Forms.Label ship_address2Label;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_stateLabel;
            System.Windows.Forms.Label ship_postal_codeLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label shipping_feeLabel;
            System.Windows.Forms.Label payment_typeLabel;
            System.Windows.Forms.Label paid_dateLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label discountLabel;
            this.databaseQuanLyBanHangDataSet = new QuanLyBanHang.DatabaseQuanLyBanHangDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            this.order_detailsTableAdapter = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.order_detailsTableAdapter();
            this.dgvdonhang = new System.Windows.Forms.DataGridView();
            this.grbdanhsachdonhang = new System.Windows.Forms.GroupBox();
            this.btndonhang = new System.Windows.Forms.Button();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.dtpformdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbthongtindonhang = new System.Windows.Forms.GroupBox();
            this.order_statusTextBox = new System.Windows.Forms.TextBox();
            this.paid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_typeTextBox = new System.Windows.Forms.TextBox();
            this.shipping_feeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ship_countryTextBox = new System.Windows.Forms.TextBox();
            this.ship_postal_codeTextBox = new System.Windows.Forms.TextBox();
            this.ship_stateTextBox = new System.Windows.Forms.TextBox();
            this.ship_cityTextBox = new System.Windows.Forms.TextBox();
            this.ship_address2TextBox = new System.Windows.Forms.TextBox();
            this.ship_address1TextBox = new System.Windows.Forms.TextBox();
            this.ship_nameTextBox = new System.Windows.Forms.TextBox();
            this.shipped_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customer_idComboBox = new System.Windows.Forms.ComboBox();
            this.employee_idComboBox = new System.Windows.Forms.ComboBox();
            this.grbchitietdonhang = new System.Windows.Forms.GroupBox();
            this.dgvchitietdonhang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnthemchitiet = new System.Windows.Forms.Button();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.unit_priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.product_idComboBox = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btninhoadon = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippeddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipaddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipaddress2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippostalcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employee_idLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            shipped_dateLabel = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            ship_address1Label = new System.Windows.Forms.Label();
            ship_address2Label = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_stateLabel = new System.Windows.Forms.Label();
            ship_postal_codeLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            shipping_feeLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            order_statusLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonhang)).BeginInit();
            this.grbdanhsachdonhang.SuspendLayout();
            this.grbthongtindonhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipping_feeNumericUpDown)).BeginInit();
            this.grbchitietdonhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietdonhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(17, 28);
            employee_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(66, 13);
            employee_idLabel.TabIndex = 0;
            employee_idLabel.Text = "employee id:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(20, 56);
            customer_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 2;
            customer_idLabel.Text = "customer id:";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(25, 86);
            order_dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(58, 13);
            order_dateLabel.TabIndex = 4;
            order_dateLabel.Text = "order date:";
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(13, 110);
            shipped_dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(71, 13);
            shipped_dateLabel.TabIndex = 6;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(25, 136);
            ship_nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(58, 13);
            ship_nameLabel.TabIndex = 8;
            ship_nameLabel.Text = "ship name:";
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(8, 160);
            ship_address1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(75, 13);
            ship_address1Label.TabIndex = 10;
            ship_address1Label.Text = "ship address1:";
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(261, 28);
            ship_address2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(75, 13);
            ship_address2Label.TabIndex = 12;
            ship_address2Label.Text = "ship address2:";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(290, 54);
            ship_cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(48, 13);
            ship_cityLabel.TabIndex = 14;
            ship_cityLabel.Text = "ship city:";
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(282, 78);
            ship_stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(55, 13);
            ship_stateLabel.TabIndex = 16;
            ship_stateLabel.Text = "ship state:";
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(250, 104);
            ship_postal_codeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(87, 13);
            ship_postal_codeLabel.TabIndex = 18;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(270, 129);
            ship_countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(67, 13);
            ship_countryLabel.TabIndex = 20;
            ship_countryLabel.Text = "ship country:";
            // 
            // shipping_feeLabel
            // 
            shipping_feeLabel.AutoSize = true;
            shipping_feeLabel.Location = new System.Drawing.Point(270, 154);
            shipping_feeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shipping_feeLabel.Name = "shipping_feeLabel";
            shipping_feeLabel.Size = new System.Drawing.Size(67, 13);
            shipping_feeLabel.TabIndex = 22;
            shipping_feeLabel.Text = "shipping fee:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(469, 28);
            payment_typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel.TabIndex = 24;
            payment_typeLabel.Text = "payment type:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(488, 54);
            paid_dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(54, 13);
            paid_dateLabel.TabIndex = 26;
            paid_dateLabel.Text = "paid date:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(476, 80);
            order_statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(65, 13);
            order_statusLabel.TabIndex = 28;
            order_statusLabel.Text = "order status:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(13, 24);
            product_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(57, 13);
            product_idLabel.TabIndex = 0;
            product_idLabel.Text = "product id:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(178, 24);
            quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(47, 13);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "quantity:";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(328, 27);
            unit_priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(53, 13);
            unit_priceLabel.TabIndex = 4;
            unit_priceLabel.Text = "unit price:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(488, 27);
            discountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(50, 13);
            discountLabel.TabIndex = 6;
            discountLabel.Text = "discount:";
            // 
            // databaseQuanLyBanHangDataSet
            // 
            this.databaseQuanLyBanHangDataSet.DataSetName = "DatabaseQuanLyBanHangDataSet";
            this.databaseQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.databaseQuanLyBanHangDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = this.order_detailsTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // order_detailsTableAdapter
            // 
            this.order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvdonhang
            // 
            this.dgvdonhang.AutoGenerateColumns = false;
            this.dgvdonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.shippeddateDataGridViewTextBoxColumn,
            this.shipnameDataGridViewTextBoxColumn,
            this.shipaddress1DataGridViewTextBoxColumn,
            this.shipaddress2DataGridViewTextBoxColumn,
            this.shipcityDataGridViewTextBoxColumn,
            this.shipstateDataGridViewTextBoxColumn,
            this.shippostalcodeDataGridViewTextBoxColumn,
            this.shipcountryDataGridViewTextBoxColumn,
            this.shippingfeeDataGridViewTextBoxColumn,
            this.paymenttypeDataGridViewTextBoxColumn,
            this.paiddateDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn});
            this.dgvdonhang.DataSource = this.ordersBindingSource;
            this.dgvdonhang.Location = new System.Drawing.Point(6, 129);
            this.dgvdonhang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdonhang.Name = "dgvdonhang";
            this.dgvdonhang.RowTemplate.Height = 24;
            this.dgvdonhang.Size = new System.Drawing.Size(254, 312);
            this.dgvdonhang.TabIndex = 1;
            this.dgvdonhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdonhang_CellClick);
            // 
            // grbdanhsachdonhang
            // 
            this.grbdanhsachdonhang.Controls.Add(this.btndonhang);
            this.grbdanhsachdonhang.Controls.Add(this.dgvdonhang);
            this.grbdanhsachdonhang.Controls.Add(this.dtptodate);
            this.grbdanhsachdonhang.Controls.Add(this.dtpformdate);
            this.grbdanhsachdonhang.Controls.Add(this.label2);
            this.grbdanhsachdonhang.Controls.Add(this.label1);
            this.grbdanhsachdonhang.Location = new System.Drawing.Point(9, 10);
            this.grbdanhsachdonhang.Margin = new System.Windows.Forms.Padding(2);
            this.grbdanhsachdonhang.Name = "grbdanhsachdonhang";
            this.grbdanhsachdonhang.Padding = new System.Windows.Forms.Padding(2);
            this.grbdanhsachdonhang.Size = new System.Drawing.Size(266, 443);
            this.grbdanhsachdonhang.TabIndex = 2;
            this.grbdanhsachdonhang.TabStop = false;
            this.grbdanhsachdonhang.Text = "Danh sách đơn hàng";
            // 
            // btndonhang
            // 
            this.btndonhang.Location = new System.Drawing.Point(11, 86);
            this.btndonhang.Margin = new System.Windows.Forms.Padding(2);
            this.btndonhang.Name = "btndonhang";
            this.btndonhang.Size = new System.Drawing.Size(242, 30);
            this.btndonhang.TabIndex = 5;
            this.btndonhang.Text = "Lấy Danh Sách Đơn Hàng";
            this.btndonhang.UseVisualStyleBackColor = true;
            this.btndonhang.Click += new System.EventHandler(this.btndonhang_Click);
            // 
            // dtptodate
            // 
            this.dtptodate.Location = new System.Drawing.Point(68, 55);
            this.dtptodate.Margin = new System.Windows.Forms.Padding(2);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(187, 20);
            this.dtptodate.TabIndex = 4;
            // 
            // dtpformdate
            // 
            this.dtpformdate.Location = new System.Drawing.Point(68, 25);
            this.dtpformdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpformdate.Name = "dtpformdate";
            this.dtpformdate.Size = new System.Drawing.Size(187, 20);
            this.dtpformdate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Form Date:";
            // 
            // grbthongtindonhang
            // 
            this.grbthongtindonhang.Controls.Add(order_statusLabel);
            this.grbthongtindonhang.Controls.Add(this.order_statusTextBox);
            this.grbthongtindonhang.Controls.Add(paid_dateLabel);
            this.grbthongtindonhang.Controls.Add(this.paid_dateDateTimePicker);
            this.grbthongtindonhang.Controls.Add(payment_typeLabel);
            this.grbthongtindonhang.Controls.Add(this.payment_typeTextBox);
            this.grbthongtindonhang.Controls.Add(shipping_feeLabel);
            this.grbthongtindonhang.Controls.Add(this.shipping_feeNumericUpDown);
            this.grbthongtindonhang.Controls.Add(ship_countryLabel);
            this.grbthongtindonhang.Controls.Add(this.ship_countryTextBox);
            this.grbthongtindonhang.Controls.Add(ship_postal_codeLabel);
            this.grbthongtindonhang.Controls.Add(this.ship_postal_codeTextBox);
            this.grbthongtindonhang.Controls.Add(ship_stateLabel);
            this.grbthongtindonhang.Controls.Add(this.ship_stateTextBox);
            this.grbthongtindonhang.Controls.Add(ship_cityLabel);
            this.grbthongtindonhang.Controls.Add(this.ship_cityTextBox);
            this.grbthongtindonhang.Controls.Add(ship_address2Label);
            this.grbthongtindonhang.Controls.Add(this.ship_address2TextBox);
            this.grbthongtindonhang.Controls.Add(ship_address1Label);
            this.grbthongtindonhang.Controls.Add(this.ship_address1TextBox);
            this.grbthongtindonhang.Controls.Add(ship_nameLabel);
            this.grbthongtindonhang.Controls.Add(this.ship_nameTextBox);
            this.grbthongtindonhang.Controls.Add(shipped_dateLabel);
            this.grbthongtindonhang.Controls.Add(this.shipped_dateDateTimePicker);
            this.grbthongtindonhang.Controls.Add(order_dateLabel);
            this.grbthongtindonhang.Controls.Add(this.order_dateDateTimePicker);
            this.grbthongtindonhang.Controls.Add(customer_idLabel);
            this.grbthongtindonhang.Controls.Add(this.customer_idComboBox);
            this.grbthongtindonhang.Controls.Add(employee_idLabel);
            this.grbthongtindonhang.Controls.Add(this.employee_idComboBox);
            this.grbthongtindonhang.Location = new System.Drawing.Point(279, 18);
            this.grbthongtindonhang.Margin = new System.Windows.Forms.Padding(2);
            this.grbthongtindonhang.Name = "grbthongtindonhang";
            this.grbthongtindonhang.Padding = new System.Windows.Forms.Padding(2);
            this.grbthongtindonhang.Size = new System.Drawing.Size(739, 188);
            this.grbthongtindonhang.TabIndex = 3;
            this.grbthongtindonhang.TabStop = false;
            this.grbthongtindonhang.Text = "Thông Tin Đơn Hàng";
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_status", true));
            this.order_statusTextBox.Location = new System.Drawing.Point(546, 77);
            this.order_statusTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(184, 20);
            this.order_statusTextBox.TabIndex = 29;
            // 
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(546, 50);
            this.paid_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.paid_dateDateTimePicker.TabIndex = 27;
            // 
            // payment_typeTextBox
            // 
            this.payment_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.payment_typeTextBox.Location = new System.Drawing.Point(546, 26);
            this.payment_typeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.payment_typeTextBox.Name = "payment_typeTextBox";
            this.payment_typeTextBox.Size = new System.Drawing.Size(184, 20);
            this.payment_typeTextBox.TabIndex = 25;
            // 
            // shipping_feeNumericUpDown
            // 
            this.shipping_feeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "shipping_fee", true));
            this.shipping_feeNumericUpDown.Location = new System.Drawing.Point(341, 154);
            this.shipping_feeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.shipping_feeNumericUpDown.Name = "shipping_feeNumericUpDown";
            this.shipping_feeNumericUpDown.Size = new System.Drawing.Size(116, 20);
            this.shipping_feeNumericUpDown.TabIndex = 23;
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_country", true));
            this.ship_countryTextBox.Location = new System.Drawing.Point(341, 127);
            this.ship_countryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(116, 20);
            this.ship_countryTextBox.TabIndex = 21;
            // 
            // ship_postal_codeTextBox
            // 
            this.ship_postal_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_postal_code", true));
            this.ship_postal_codeTextBox.Location = new System.Drawing.Point(341, 102);
            this.ship_postal_codeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ship_postal_codeTextBox.Name = "ship_postal_codeTextBox";
            this.ship_postal_codeTextBox.Size = new System.Drawing.Size(116, 20);
            this.ship_postal_codeTextBox.TabIndex = 19;
            // 
            // ship_stateTextBox
            // 
            this.ship_stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_state", true));
            this.ship_stateTextBox.Location = new System.Drawing.Point(341, 76);
            this.ship_stateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ship_stateTextBox.Name = "ship_stateTextBox";
            this.ship_stateTextBox.Size = new System.Drawing.Size(116, 20);
            this.ship_stateTextBox.TabIndex = 17;
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_city", true));
            this.ship_cityTextBox.Location = new System.Drawing.Point(341, 51);
            this.ship_cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(116, 20);
            this.ship_cityTextBox.TabIndex = 15;
            // 
            // ship_address2TextBox
            // 
            this.ship_address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address2", true));
            this.ship_address2TextBox.Location = new System.Drawing.Point(341, 26);
            this.ship_address2TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ship_address2TextBox.Name = "ship_address2TextBox";
            this.ship_address2TextBox.Size = new System.Drawing.Size(116, 20);
            this.ship_address2TextBox.TabIndex = 13;
            // 
            // ship_address1TextBox
            // 
            this.ship_address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address1", true));
            this.ship_address1TextBox.Location = new System.Drawing.Point(88, 158);
            this.ship_address1TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ship_address1TextBox.Name = "ship_address1TextBox";
            this.ship_address1TextBox.Size = new System.Drawing.Size(113, 20);
            this.ship_address1TextBox.TabIndex = 11;
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_name", true));
            this.ship_nameTextBox.Location = new System.Drawing.Point(87, 133);
            this.ship_nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(114, 20);
            this.ship_nameTextBox.TabIndex = 9;
            // 
            // shipped_dateDateTimePicker
            // 
            this.shipped_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "shipped_date", true));
            this.shipped_dateDateTimePicker.Location = new System.Drawing.Point(88, 107);
            this.shipped_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.shipped_dateDateTimePicker.Name = "shipped_dateDateTimePicker";
            this.shipped_dateDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.shipped_dateDateTimePicker.TabIndex = 7;
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_date", true));
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(88, 83);
            this.order_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.order_dateDateTimePicker.TabIndex = 5;
            // 
            // customer_idComboBox
            // 
            this.customer_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "customer_id", true));
            this.customer_idComboBox.FormattingEnabled = true;
            this.customer_idComboBox.Location = new System.Drawing.Point(88, 54);
            this.customer_idComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.customer_idComboBox.Name = "customer_idComboBox";
            this.customer_idComboBox.Size = new System.Drawing.Size(113, 21);
            this.customer_idComboBox.TabIndex = 3;
            // 
            // employee_idComboBox
            // 
            this.employee_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "employee_id", true));
            this.employee_idComboBox.FormattingEnabled = true;
            this.employee_idComboBox.Location = new System.Drawing.Point(88, 26);
            this.employee_idComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.employee_idComboBox.Name = "employee_idComboBox";
            this.employee_idComboBox.Size = new System.Drawing.Size(113, 21);
            this.employee_idComboBox.TabIndex = 1;
            // 
            // grbchitietdonhang
            // 
            this.grbchitietdonhang.Controls.Add(this.dgvchitietdonhang);
            this.grbchitietdonhang.Controls.Add(this.btnthemchitiet);
            this.grbchitietdonhang.Controls.Add(discountLabel);
            this.grbchitietdonhang.Controls.Add(this.discountNumericUpDown);
            this.grbchitietdonhang.Controls.Add(unit_priceLabel);
            this.grbchitietdonhang.Controls.Add(this.unit_priceNumericUpDown);
            this.grbchitietdonhang.Controls.Add(quantityLabel);
            this.grbchitietdonhang.Controls.Add(this.quantityNumericUpDown);
            this.grbchitietdonhang.Controls.Add(product_idLabel);
            this.grbchitietdonhang.Controls.Add(this.product_idComboBox);
            this.grbchitietdonhang.Location = new System.Drawing.Point(279, 210);
            this.grbchitietdonhang.Margin = new System.Windows.Forms.Padding(2);
            this.grbchitietdonhang.Name = "grbchitietdonhang";
            this.grbchitietdonhang.Padding = new System.Windows.Forms.Padding(2);
            this.grbchitietdonhang.Size = new System.Drawing.Size(739, 242);
            this.grbchitietdonhang.TabIndex = 4;
            this.grbchitietdonhang.TabStop = false;
            this.grbchitietdonhang.Text = "Thông Tin Chi Tiết Đơn Hàng";
            // 
            // dgvchitietdonhang
            // 
            this.dgvchitietdonhang.AutoGenerateColumns = false;
            this.dgvchitietdonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitietdonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvchitietdonhang.DataSource = this.order_detailsBindingSource;
            this.dgvchitietdonhang.Location = new System.Drawing.Point(4, 47);
            this.dgvchitietdonhang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvchitietdonhang.Name = "dgvchitietdonhang";
            this.dgvchitietdonhang.RowTemplate.Height = 24;
            this.dgvchitietdonhang.Size = new System.Drawing.Size(730, 193);
            this.dgvchitietdonhang.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "unit_price";
            this.dataGridViewTextBoxColumn6.HeaderText = "unit_price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn7.HeaderText = "discount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "order_detail_status";
            this.dataGridViewTextBoxColumn8.HeaderText = "order_detail_status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "date_allocated";
            this.dataGridViewTextBoxColumn9.HeaderText = "date_allocated";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataMember = "order_details";
            this.order_detailsBindingSource.DataSource = this.databaseQuanLyBanHangDataSet;
            // 
            // btnthemchitiet
            // 
            this.btnthemchitiet.Location = new System.Drawing.Point(641, 18);
            this.btnthemchitiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnthemchitiet.Name = "btnthemchitiet";
            this.btnthemchitiet.Size = new System.Drawing.Size(93, 27);
            this.btnthemchitiet.TabIndex = 8;
            this.btnthemchitiet.Text = "Thêm Chi Tiết";
            this.btnthemchitiet.UseVisualStyleBackColor = true;
            this.btnthemchitiet.Click += new System.EventHandler(this.btnthemchitiet_Click);
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "discount", true));
            this.discountNumericUpDown.Location = new System.Drawing.Point(542, 27);
            this.discountNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.discountNumericUpDown.TabIndex = 7;
            // 
            // unit_priceNumericUpDown
            // 
            this.unit_priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "unit_price", true));
            this.unit_priceNumericUpDown.Location = new System.Drawing.Point(385, 27);
            this.unit_priceNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.unit_priceNumericUpDown.Name = "unit_priceNumericUpDown";
            this.unit_priceNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.unit_priceNumericUpDown.TabIndex = 5;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "quantity", true));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(230, 24);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.quantityNumericUpDown.TabIndex = 3;
            // 
            // product_idComboBox
            // 
            this.product_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "product_id", true));
            this.product_idComboBox.FormattingEnabled = true;
            this.product_idComboBox.Location = new System.Drawing.Point(74, 21);
            this.product_idComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.product_idComboBox.Name = "product_idComboBox";
            this.product_idComboBox.Size = new System.Drawing.Size(101, 21);
            this.product_idComboBox.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(567, 465);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(74, 27);
            this.btnthem.TabIndex = 24;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(661, 465);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(74, 27);
            this.btnsua.TabIndex = 25;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(754, 465);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(74, 27);
            this.btnxoa.TabIndex = 26;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(845, 465);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(74, 27);
            this.btnluu.TabIndex = 27;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(938, 465);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(74, 27);
            this.btnthoat.TabIndex = 28;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btninhoadon
            // 
            this.btninhoadon.Location = new System.Drawing.Point(476, 465);
            this.btninhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(74, 27);
            this.btninhoadon.TabIndex = 24;
            this.btninhoadon.Text = "In Hóa Đơn";
            this.btninhoadon.UseVisualStyleBackColor = true;
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // shippeddateDataGridViewTextBoxColumn
            // 
            this.shippeddateDataGridViewTextBoxColumn.DataPropertyName = "shipped_date";
            this.shippeddateDataGridViewTextBoxColumn.HeaderText = "shipped_date";
            this.shippeddateDataGridViewTextBoxColumn.Name = "shippeddateDataGridViewTextBoxColumn";
            // 
            // shipnameDataGridViewTextBoxColumn
            // 
            this.shipnameDataGridViewTextBoxColumn.DataPropertyName = "ship_name";
            this.shipnameDataGridViewTextBoxColumn.HeaderText = "ship_name";
            this.shipnameDataGridViewTextBoxColumn.Name = "shipnameDataGridViewTextBoxColumn";
            this.shipnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // shipaddress1DataGridViewTextBoxColumn
            // 
            this.shipaddress1DataGridViewTextBoxColumn.DataPropertyName = "ship_address1";
            this.shipaddress1DataGridViewTextBoxColumn.HeaderText = "ship_address1";
            this.shipaddress1DataGridViewTextBoxColumn.Name = "shipaddress1DataGridViewTextBoxColumn";
            this.shipaddress1DataGridViewTextBoxColumn.Visible = false;
            // 
            // shipaddress2DataGridViewTextBoxColumn
            // 
            this.shipaddress2DataGridViewTextBoxColumn.DataPropertyName = "ship_address2";
            this.shipaddress2DataGridViewTextBoxColumn.HeaderText = "ship_address2";
            this.shipaddress2DataGridViewTextBoxColumn.Name = "shipaddress2DataGridViewTextBoxColumn";
            this.shipaddress2DataGridViewTextBoxColumn.Visible = false;
            // 
            // shipcityDataGridViewTextBoxColumn
            // 
            this.shipcityDataGridViewTextBoxColumn.DataPropertyName = "ship_city";
            this.shipcityDataGridViewTextBoxColumn.HeaderText = "ship_city";
            this.shipcityDataGridViewTextBoxColumn.Name = "shipcityDataGridViewTextBoxColumn";
            this.shipcityDataGridViewTextBoxColumn.Visible = false;
            // 
            // shipstateDataGridViewTextBoxColumn
            // 
            this.shipstateDataGridViewTextBoxColumn.DataPropertyName = "ship_state";
            this.shipstateDataGridViewTextBoxColumn.HeaderText = "ship_state";
            this.shipstateDataGridViewTextBoxColumn.Name = "shipstateDataGridViewTextBoxColumn";
            this.shipstateDataGridViewTextBoxColumn.Visible = false;
            // 
            // shippostalcodeDataGridViewTextBoxColumn
            // 
            this.shippostalcodeDataGridViewTextBoxColumn.DataPropertyName = "ship_postal_code";
            this.shippostalcodeDataGridViewTextBoxColumn.HeaderText = "ship_postal_code";
            this.shippostalcodeDataGridViewTextBoxColumn.Name = "shippostalcodeDataGridViewTextBoxColumn";
            this.shippostalcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // shipcountryDataGridViewTextBoxColumn
            // 
            this.shipcountryDataGridViewTextBoxColumn.DataPropertyName = "ship_country";
            this.shipcountryDataGridViewTextBoxColumn.HeaderText = "ship_country";
            this.shipcountryDataGridViewTextBoxColumn.Name = "shipcountryDataGridViewTextBoxColumn";
            this.shipcountryDataGridViewTextBoxColumn.Visible = false;
            // 
            // shippingfeeDataGridViewTextBoxColumn
            // 
            this.shippingfeeDataGridViewTextBoxColumn.DataPropertyName = "shipping_fee";
            this.shippingfeeDataGridViewTextBoxColumn.HeaderText = "shipping_fee";
            this.shippingfeeDataGridViewTextBoxColumn.Name = "shippingfeeDataGridViewTextBoxColumn";
            this.shippingfeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymenttypeDataGridViewTextBoxColumn
            // 
            this.paymenttypeDataGridViewTextBoxColumn.DataPropertyName = "payment_type";
            this.paymenttypeDataGridViewTextBoxColumn.HeaderText = "payment_type";
            this.paymenttypeDataGridViewTextBoxColumn.Name = "paymenttypeDataGridViewTextBoxColumn";
            this.paymenttypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // paiddateDataGridViewTextBoxColumn
            // 
            this.paiddateDataGridViewTextBoxColumn.DataPropertyName = "paid_date";
            this.paiddateDataGridViewTextBoxColumn.HeaderText = "paid_date";
            this.paiddateDataGridViewTextBoxColumn.Name = "paiddateDataGridViewTextBoxColumn";
            this.paiddateDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            this.orderstatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // Frmdathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 514);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grbchitietdonhang);
            this.Controls.Add(this.grbthongtindonhang);
            this.Controls.Add(this.grbdanhsachdonhang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Frmdathang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Hàng";
            this.Load += new System.EventHandler(this.Frmdathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdonhang)).EndInit();
            this.grbdanhsachdonhang.ResumeLayout(false);
            this.grbdanhsachdonhang.PerformLayout();
            this.grbthongtindonhang.ResumeLayout(false);
            this.grbthongtindonhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipping_feeNumericUpDown)).EndInit();
            this.grbchitietdonhang.ResumeLayout(false);
            this.grbchitietdonhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietdonhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit_priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseQuanLyBanHangDataSet databaseQuanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DatabaseQuanLyBanHangDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvdonhang;
        private System.Windows.Forms.GroupBox grbdanhsachdonhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndonhang;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.DateTimePicker dtpformdate;
        private System.Windows.Forms.GroupBox grbthongtindonhang;
        private DatabaseQuanLyBanHangDataSetTableAdapters.order_detailsTableAdapter order_detailsTableAdapter;
        private System.Windows.Forms.TextBox order_statusTextBox;
        private System.Windows.Forms.DateTimePicker paid_dateDateTimePicker;
        private System.Windows.Forms.TextBox payment_typeTextBox;
        private System.Windows.Forms.NumericUpDown shipping_feeNumericUpDown;
        private System.Windows.Forms.TextBox ship_countryTextBox;
        private System.Windows.Forms.TextBox ship_postal_codeTextBox;
        private System.Windows.Forms.TextBox ship_stateTextBox;
        private System.Windows.Forms.TextBox ship_cityTextBox;
        private System.Windows.Forms.TextBox ship_address2TextBox;
        private System.Windows.Forms.TextBox ship_address1TextBox;
        private System.Windows.Forms.TextBox ship_nameTextBox;
        private System.Windows.Forms.DateTimePicker shipped_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker order_dateDateTimePicker;
        private System.Windows.Forms.ComboBox customer_idComboBox;
        private System.Windows.Forms.ComboBox employee_idComboBox;
        private System.Windows.Forms.GroupBox grbchitietdonhang;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private System.Windows.Forms.DataGridView dgvchitietdonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnthemchitiet;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.NumericUpDown unit_priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.ComboBox product_idComboBox;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btninhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippeddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipaddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipaddress2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippostalcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
    }
}