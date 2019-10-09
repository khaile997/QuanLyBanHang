namespace QuanLyBanHang.Functions
{
    partial class Frmdanhmucdathang
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
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label order_detail_statusLabel;
            System.Windows.Forms.Label date_allocatedLabel;
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label product_idLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.databaseQuanLyBanHangDataSet = new QuanLyBanHang.DatabaseQuanLyBanHangDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            this.dtporder_date = new System.Windows.Forms.DateTimePicker();
            this.dtpshipped_date = new System.Windows.Forms.DateTimePicker();
            this.txtship_name = new System.Windows.Forms.TextBox();
            this.txtship_address1 = new System.Windows.Forms.TextBox();
            this.txtship_address2 = new System.Windows.Forms.TextBox();
            this.txtship_city = new System.Windows.Forms.TextBox();
            this.txtship_state = new System.Windows.Forms.TextBox();
            this.txtship_postal = new System.Windows.Forms.TextBox();
            this.txtship_country = new System.Windows.Forms.TextBox();
            this.txtshipping_fee = new System.Windows.Forms.TextBox();
            this.txtpayment_type = new System.Windows.Forms.TextBox();
            this.dtppaid_date = new System.Windows.Forms.DateTimePicker();
            this.txtorder_status = new System.Windows.Forms.TextBox();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_detailsTableAdapter = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.order_detailsTableAdapter();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtunit_price = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtorder_detail_status = new System.Windows.Forms.TextBox();
            this.txtdate_allocated = new System.Windows.Forms.DateTimePicker();
            this.dgvorder_details = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.nudemployee_id = new System.Windows.Forms.NumericUpDown();
            this.nudcustomer_id = new System.Windows.Forms.NumericUpDown();
            this.order_detailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nudproduct_id = new System.Windows.Forms.NumericUpDown();
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
            quantityLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            order_detail_statusLabel = new System.Windows.Forms.Label();
            date_allocatedLabel = new System.Windows.Forms.Label();
            employee_idLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudemployee_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcustomer_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudproduct_id)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(customer_idLabel);
            this.groupBox1.Controls.Add(this.nudcustomer_id);
            this.groupBox1.Controls.Add(employee_idLabel);
            this.groupBox1.Controls.Add(this.nudemployee_id);
            this.groupBox1.Controls.Add(order_statusLabel);
            this.groupBox1.Controls.Add(this.txtorder_status);
            this.groupBox1.Controls.Add(paid_dateLabel);
            this.groupBox1.Controls.Add(this.dtppaid_date);
            this.groupBox1.Controls.Add(payment_typeLabel);
            this.groupBox1.Controls.Add(this.txtpayment_type);
            this.groupBox1.Controls.Add(shipping_feeLabel);
            this.groupBox1.Controls.Add(this.txtshipping_fee);
            this.groupBox1.Controls.Add(ship_countryLabel);
            this.groupBox1.Controls.Add(this.txtship_country);
            this.groupBox1.Controls.Add(ship_postal_codeLabel);
            this.groupBox1.Controls.Add(this.txtship_postal);
            this.groupBox1.Controls.Add(ship_stateLabel);
            this.groupBox1.Controls.Add(this.txtship_state);
            this.groupBox1.Controls.Add(ship_cityLabel);
            this.groupBox1.Controls.Add(this.txtship_city);
            this.groupBox1.Controls.Add(ship_address2Label);
            this.groupBox1.Controls.Add(this.txtship_address2);
            this.groupBox1.Controls.Add(ship_address1Label);
            this.groupBox1.Controls.Add(this.txtship_address1);
            this.groupBox1.Controls.Add(ship_nameLabel);
            this.groupBox1.Controls.Add(this.txtship_name);
            this.groupBox1.Controls.Add(shipped_dateLabel);
            this.groupBox1.Controls.Add(this.dtpshipped_date);
            this.groupBox1.Controls.Add(order_dateLabel);
            this.groupBox1.Controls.Add(this.dtporder_date);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(product_idLabel);
            this.groupBox2.Controls.Add(this.nudproduct_id);
            this.groupBox2.Controls.Add(this.dgvorder_details);
            this.groupBox2.Controls.Add(date_allocatedLabel);
            this.groupBox2.Controls.Add(this.txtdate_allocated);
            this.groupBox2.Controls.Add(order_detail_statusLabel);
            this.groupBox2.Controls.Add(this.txtorder_detail_status);
            this.groupBox2.Controls.Add(discountLabel);
            this.groupBox2.Controls.Add(this.txtdiscount);
            this.groupBox2.Controls.Add(unit_priceLabel);
            this.groupBox2.Controls.Add(this.txtunit_price);
            this.groupBox2.Controls.Add(quantityLabel);
            this.groupBox2.Controls.Add(this.txtquantity);
            this.groupBox2.Location = new System.Drawing.Point(13, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 370);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết Đơn Hàng";
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
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(59, 97);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(78, 17);
            order_dateLabel.TabIndex = 4;
            order_dateLabel.Text = "order date:";
            // 
            // dtporder_date
            // 
            this.dtporder_date.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_date", true));
            this.dtporder_date.Location = new System.Drawing.Point(143, 93);
            this.dtporder_date.Name = "dtporder_date";
            this.dtporder_date.Size = new System.Drawing.Size(200, 22);
            this.dtporder_date.TabIndex = 5;
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(43, 129);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(94, 17);
            shipped_dateLabel.TabIndex = 6;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // dtpshipped_date
            // 
            this.dtpshipped_date.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "shipped_date", true));
            this.dtpshipped_date.Location = new System.Drawing.Point(143, 125);
            this.dtpshipped_date.Name = "dtpshipped_date";
            this.dtpshipped_date.Size = new System.Drawing.Size(200, 22);
            this.dtpshipped_date.TabIndex = 7;
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(60, 163);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(77, 17);
            ship_nameLabel.TabIndex = 8;
            ship_nameLabel.Text = "ship name:";
            // 
            // txtship_name
            // 
            this.txtship_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_name", true));
            this.txtship_name.Location = new System.Drawing.Point(143, 160);
            this.txtship_name.Name = "txtship_name";
            this.txtship_name.Size = new System.Drawing.Size(155, 22);
            this.txtship_name.TabIndex = 9;
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(36, 197);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(101, 17);
            ship_address1Label.TabIndex = 10;
            ship_address1Label.Text = "ship address1:";
            // 
            // txtship_address1
            // 
            this.txtship_address1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address1", true));
            this.txtship_address1.Location = new System.Drawing.Point(143, 194);
            this.txtship_address1.Name = "txtship_address1";
            this.txtship_address1.Size = new System.Drawing.Size(155, 22);
            this.txtship_address1.TabIndex = 11;
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(401, 37);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(101, 17);
            ship_address2Label.TabIndex = 12;
            ship_address2Label.Text = "ship address2:";
            // 
            // txtship_address2
            // 
            this.txtship_address2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address2", true));
            this.txtship_address2.Location = new System.Drawing.Point(508, 34);
            this.txtship_address2.Name = "txtship_address2";
            this.txtship_address2.Size = new System.Drawing.Size(166, 22);
            this.txtship_address2.TabIndex = 13;
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(439, 68);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(63, 17);
            ship_cityLabel.TabIndex = 14;
            ship_cityLabel.Text = "ship city:";
            // 
            // txtship_city
            // 
            this.txtship_city.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_city", true));
            this.txtship_city.Location = new System.Drawing.Point(508, 65);
            this.txtship_city.Name = "txtship_city";
            this.txtship_city.Size = new System.Drawing.Size(166, 22);
            this.txtship_city.TabIndex = 15;
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(429, 98);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(73, 17);
            ship_stateLabel.TabIndex = 16;
            ship_stateLabel.Text = "ship state:";
            // 
            // txtship_state
            // 
            this.txtship_state.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_state", true));
            this.txtship_state.Location = new System.Drawing.Point(508, 95);
            this.txtship_state.Name = "txtship_state";
            this.txtship_state.Size = new System.Drawing.Size(166, 22);
            this.txtship_state.TabIndex = 17;
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(387, 130);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(115, 17);
            ship_postal_codeLabel.TabIndex = 18;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // txtship_postal
            // 
            this.txtship_postal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_postal_code", true));
            this.txtship_postal.Location = new System.Drawing.Point(508, 127);
            this.txtship_postal.Name = "txtship_postal";
            this.txtship_postal.Size = new System.Drawing.Size(166, 22);
            this.txtship_postal.TabIndex = 19;
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(413, 160);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(89, 17);
            ship_countryLabel.TabIndex = 20;
            ship_countryLabel.Text = "ship country:";
            // 
            // txtship_country
            // 
            this.txtship_country.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_country", true));
            this.txtship_country.Location = new System.Drawing.Point(508, 157);
            this.txtship_country.Name = "txtship_country";
            this.txtship_country.Size = new System.Drawing.Size(166, 22);
            this.txtship_country.TabIndex = 21;
            // 
            // shipping_feeLabel
            // 
            shipping_feeLabel.AutoSize = true;
            shipping_feeLabel.Location = new System.Drawing.Point(413, 194);
            shipping_feeLabel.Name = "shipping_feeLabel";
            shipping_feeLabel.Size = new System.Drawing.Size(89, 17);
            shipping_feeLabel.TabIndex = 22;
            shipping_feeLabel.Text = "shipping fee:";
            // 
            // txtshipping_fee
            // 
            this.txtshipping_fee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "shipping_fee", true));
            this.txtshipping_fee.Location = new System.Drawing.Point(508, 191);
            this.txtshipping_fee.Name = "txtshipping_fee";
            this.txtshipping_fee.Size = new System.Drawing.Size(166, 22);
            this.txtshipping_fee.TabIndex = 23;
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(723, 39);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(97, 17);
            payment_typeLabel.TabIndex = 24;
            payment_typeLabel.Text = "payment type:";
            // 
            // txtpayment_type
            // 
            this.txtpayment_type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.txtpayment_type.Location = new System.Drawing.Point(826, 36);
            this.txtpayment_type.Name = "txtpayment_type";
            this.txtpayment_type.Size = new System.Drawing.Size(179, 22);
            this.txtpayment_type.TabIndex = 25;
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(749, 70);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(71, 17);
            paid_dateLabel.TabIndex = 26;
            paid_dateLabel.Text = "paid date:";
            // 
            // dtppaid_date
            // 
            this.dtppaid_date.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.dtppaid_date.Location = new System.Drawing.Point(826, 66);
            this.dtppaid_date.Name = "dtppaid_date";
            this.dtppaid_date.Size = new System.Drawing.Size(200, 22);
            this.dtppaid_date.TabIndex = 27;
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(732, 100);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(88, 17);
            order_statusLabel.TabIndex = 28;
            order_statusLabel.Text = "order status:";
            // 
            // txtorder_status
            // 
            this.txtorder_status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_status", true));
            this.txtorder_status.Location = new System.Drawing.Point(826, 97);
            this.txtorder_status.Name = "txtorder_status";
            this.txtorder_status.Size = new System.Drawing.Size(179, 22);
            this.txtorder_status.TabIndex = 29;
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataMember = "order_details";
            this.order_detailsBindingSource.DataSource = this.databaseQuanLyBanHangDataSet;
            // 
            // order_detailsTableAdapter
            // 
            this.order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(187, 26);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(62, 17);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "quantity:";
            // 
            // txtquantity
            // 
            this.txtquantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "quantity", true));
            this.txtquantity.Location = new System.Drawing.Point(190, 46);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(132, 22);
            this.txtquantity.TabIndex = 3;
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(347, 26);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(70, 17);
            unit_priceLabel.TabIndex = 4;
            unit_priceLabel.Text = "unit price:";
            // 
            // txtunit_price
            // 
            this.txtunit_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "unit_price", true));
            this.txtunit_price.Location = new System.Drawing.Point(350, 46);
            this.txtunit_price.Name = "txtunit_price";
            this.txtunit_price.Size = new System.Drawing.Size(123, 22);
            this.txtunit_price.TabIndex = 5;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(496, 26);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(65, 17);
            discountLabel.TabIndex = 6;
            discountLabel.Text = "discount:";
            // 
            // txtdiscount
            // 
            this.txtdiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "discount", true));
            this.txtdiscount.Location = new System.Drawing.Point(499, 46);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(136, 22);
            this.txtdiscount.TabIndex = 7;
            // 
            // order_detail_statusLabel
            // 
            order_detail_statusLabel.AutoSize = true;
            order_detail_statusLabel.Location = new System.Drawing.Point(663, 26);
            order_detail_statusLabel.Name = "order_detail_statusLabel";
            order_detail_statusLabel.Size = new System.Drawing.Size(126, 17);
            order_detail_statusLabel.TabIndex = 8;
            order_detail_statusLabel.Text = "order detail status:";
            // 
            // txtorder_detail_status
            // 
            this.txtorder_detail_status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "order_detail_status", true));
            this.txtorder_detail_status.Location = new System.Drawing.Point(666, 46);
            this.txtorder_detail_status.Name = "txtorder_detail_status";
            this.txtorder_detail_status.Size = new System.Drawing.Size(143, 22);
            this.txtorder_detail_status.TabIndex = 9;
            // 
            // date_allocatedLabel
            // 
            date_allocatedLabel.AutoSize = true;
            date_allocatedLabel.Location = new System.Drawing.Point(843, 26);
            date_allocatedLabel.Name = "date_allocatedLabel";
            date_allocatedLabel.Size = new System.Drawing.Size(101, 17);
            date_allocatedLabel.TabIndex = 10;
            date_allocatedLabel.Text = "date allocated:";
            // 
            // txtdate_allocated
            // 
            this.txtdate_allocated.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "date_allocated", true));
            this.txtdate_allocated.Location = new System.Drawing.Point(846, 46);
            this.txtdate_allocated.Name = "txtdate_allocated";
            this.txtdate_allocated.Size = new System.Drawing.Size(200, 22);
            this.txtdate_allocated.TabIndex = 11;
            // 
            // dgvorder_details
            // 
            this.dgvorder_details.AutoGenerateColumns = false;
            this.dgvorder_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorder_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvorder_details.DataSource = this.order_detailsBindingSource;
            this.dgvorder_details.Location = new System.Drawing.Point(37, 83);
            this.dgvorder_details.Name = "dgvorder_details";
            this.dgvorder_details.RowTemplate.Height = 24;
            this.dgvorder_details.Size = new System.Drawing.Size(1009, 267);
            this.dgvorder_details.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unit_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "unit_price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "discount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "order_detail_status";
            this.dataGridViewTextBoxColumn6.HeaderText = "order_detail_status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date_allocated";
            this.dataGridViewTextBoxColumn7.HeaderText = "date_allocated";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(477, 619);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 33);
            this.btnthem.TabIndex = 36;
            this.btnthem.Text = "Thêm Đơn Hàng";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(630, 619);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(99, 33);
            this.btnsua.TabIndex = 37;
            this.btnsua.Text = "Sửa ĐH";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(754, 619);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(99, 33);
            this.btnxoa.TabIndex = 38;
            this.btnxoa.Text = "Xóa ĐH";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(876, 619);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(99, 33);
            this.btnluu.TabIndex = 39;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(1000, 619);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 33);
            this.btnthoat.TabIndex = 40;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(49, 34);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(88, 17);
            employee_idLabel.TabIndex = 29;
            employee_idLabel.Text = "employee id:";
            // 
            // nudemployee_id
            // 
            this.nudemployee_id.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "employee_id", true));
            this.nudemployee_id.Location = new System.Drawing.Point(143, 34);
            this.nudemployee_id.Name = "nudemployee_id";
            this.nudemployee_id.Size = new System.Drawing.Size(145, 22);
            this.nudemployee_id.TabIndex = 30;
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(52, 68);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(85, 17);
            customer_idLabel.TabIndex = 30;
            customer_idLabel.Text = "customer id:";
            // 
            // nudcustomer_id
            // 
            this.nudcustomer_id.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "customer_id", true));
            this.nudcustomer_id.Location = new System.Drawing.Point(143, 65);
            this.nudcustomer_id.Name = "nudcustomer_id";
            this.nudcustomer_id.Size = new System.Drawing.Size(145, 22);
            this.nudcustomer_id.TabIndex = 31;
            // 
            // order_detailsBindingSource1
            // 
            this.order_detailsBindingSource1.DataMember = "fk_order_details__orders";
            this.order_detailsBindingSource1.DataSource = this.ordersBindingSource;
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(34, 26);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(75, 17);
            product_idLabel.TabIndex = 12;
            product_idLabel.Text = "product id:";
            // 
            // nudproduct_id
            // 
            this.nudproduct_id.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource1, "product_id", true));
            this.nudproduct_id.Location = new System.Drawing.Point(37, 49);
            this.nudproduct_id.Name = "nudproduct_id";
            this.nudproduct_id.Size = new System.Drawing.Size(127, 22);
            this.nudproduct_id.TabIndex = 13;
            // 
            // Frmdanhmucdathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 678);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frmdanhmucdathang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Đặt Hàng";
            this.Load += new System.EventHandler(this.Frmdanhmucdathang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudemployee_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcustomer_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudproduct_id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DatabaseQuanLyBanHangDataSet databaseQuanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DatabaseQuanLyBanHangDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtorder_status;
        private System.Windows.Forms.DateTimePicker dtppaid_date;
        private System.Windows.Forms.TextBox txtpayment_type;
        private System.Windows.Forms.TextBox txtshipping_fee;
        private System.Windows.Forms.TextBox txtship_country;
        private System.Windows.Forms.TextBox txtship_postal;
        private System.Windows.Forms.TextBox txtship_state;
        private System.Windows.Forms.TextBox txtship_city;
        private System.Windows.Forms.TextBox txtship_address2;
        private System.Windows.Forms.TextBox txtship_address1;
        private System.Windows.Forms.TextBox txtship_name;
        private System.Windows.Forms.DateTimePicker dtpshipped_date;
        private System.Windows.Forms.DateTimePicker dtporder_date;
        private DatabaseQuanLyBanHangDataSetTableAdapters.order_detailsTableAdapter order_detailsTableAdapter;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private System.Windows.Forms.DataGridView dgvorder_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DateTimePicker txtdate_allocated;
        private System.Windows.Forms.TextBox txtorder_detail_status;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtunit_price;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.NumericUpDown nudcustomer_id;
        private System.Windows.Forms.NumericUpDown nudemployee_id;
        private System.Windows.Forms.NumericUpDown nudproduct_id;
        private System.Windows.Forms.BindingSource order_detailsBindingSource1;
    }
}