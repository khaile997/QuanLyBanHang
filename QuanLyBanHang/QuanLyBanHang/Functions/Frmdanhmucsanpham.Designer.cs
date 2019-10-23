namespace QuanLyBanHang.Functions
{
    partial class Frmdanhmucsanpham
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
            System.Windows.Forms.Label product_codeLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label standard_costLabel;
            System.Windows.Forms.Label list_priceLabel;
            System.Windows.Forms.Label target_levelLabel;
            System.Windows.Forms.Label reorder_levelLabel;
            System.Windows.Forms.Label minimum_reorder_quantityLabel;
            System.Windows.Forms.Label quantity_per_unitLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.Windows.Forms.Label categoryLabel;
            this.databaseQuanLyBanHangDataSet = new QuanLyBanHang.DatabaseQuanLyBanHangDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.productsTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            this.txtproduct_code = new System.Windows.Forms.TextBox();
            this.txtproduct_name = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtstandard_cost = new System.Windows.Forms.TextBox();
            this.txtlist_price = new System.Windows.Forms.TextBox();
            this.nudtarget_level = new System.Windows.Forms.NumericUpDown();
            this.nudreorder_level = new System.Windows.Forms.NumericUpDown();
            this.nudminimum_reorder_quantity = new System.Windows.Forms.NumericUpDown();
            this.txtquantity_per_unit = new System.Windows.Forms.TextBox();
            this.txtdiscontinued = new System.Windows.Forms.TextBox();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            product_codeLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            standard_costLabel = new System.Windows.Forms.Label();
            list_priceLabel = new System.Windows.Forms.Label();
            target_levelLabel = new System.Windows.Forms.Label();
            reorder_levelLabel = new System.Windows.Forms.Label();
            minimum_reorder_quantityLabel = new System.Windows.Forms.Label();
            quantity_per_unitLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtarget_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudreorder_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudminimum_reorder_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // product_codeLabel
            // 
            product_codeLabel.AutoSize = true;
            product_codeLabel.Location = new System.Drawing.Point(47, 28);
            product_codeLabel.Name = "product_codeLabel";
            product_codeLabel.Size = new System.Drawing.Size(95, 17);
            product_codeLabel.TabIndex = 1;
            product_codeLabel.Text = "product code:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(43, 60);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(99, 17);
            product_nameLabel.TabIndex = 2;
            product_nameLabel.Text = "product name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(61, 93);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(81, 17);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "description:";
            // 
            // standard_costLabel
            // 
            standard_costLabel.AutoSize = true;
            standard_costLabel.Location = new System.Drawing.Point(44, 126);
            standard_costLabel.Name = "standard_costLabel";
            standard_costLabel.Size = new System.Drawing.Size(98, 17);
            standard_costLabel.TabIndex = 6;
            standard_costLabel.Text = "standard cost:";
            // 
            // list_priceLabel
            // 
            list_priceLabel.AutoSize = true;
            list_priceLabel.Location = new System.Drawing.Point(474, 28);
            list_priceLabel.Name = "list_priceLabel";
            list_priceLabel.Size = new System.Drawing.Size(64, 17);
            list_priceLabel.TabIndex = 8;
            list_priceLabel.Text = "list price:";
            // 
            // target_levelLabel
            // 
            target_levelLabel.AutoSize = true;
            target_levelLabel.Location = new System.Drawing.Point(456, 57);
            target_levelLabel.Name = "target_levelLabel";
            target_levelLabel.Size = new System.Drawing.Size(82, 17);
            target_levelLabel.TabIndex = 10;
            target_levelLabel.Text = "target level:";
            // 
            // reorder_levelLabel
            // 
            reorder_levelLabel.AutoSize = true;
            reorder_levelLabel.Location = new System.Drawing.Point(446, 90);
            reorder_levelLabel.Name = "reorder_levelLabel";
            reorder_levelLabel.Size = new System.Drawing.Size(92, 17);
            reorder_levelLabel.TabIndex = 12;
            reorder_levelLabel.Text = "reorder level:";
            // 
            // minimum_reorder_quantityLabel
            // 
            minimum_reorder_quantityLabel.AutoSize = true;
            minimum_reorder_quantityLabel.Location = new System.Drawing.Point(366, 123);
            minimum_reorder_quantityLabel.Name = "minimum_reorder_quantityLabel";
            minimum_reorder_quantityLabel.Size = new System.Drawing.Size(172, 17);
            minimum_reorder_quantityLabel.TabIndex = 14;
            minimum_reorder_quantityLabel.Text = "minimum reorder quantity:";
            // 
            // quantity_per_unitLabel
            // 
            quantity_per_unitLabel.AutoSize = true;
            quantity_per_unitLabel.Location = new System.Drawing.Point(748, 30);
            quantity_per_unitLabel.Name = "quantity_per_unitLabel";
            quantity_per_unitLabel.Size = new System.Drawing.Size(114, 17);
            quantity_per_unitLabel.TabIndex = 16;
            quantity_per_unitLabel.Text = "quantity per unit:";
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(770, 62);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(92, 17);
            discontinuedLabel.TabIndex = 18;
            discontinuedLabel.Text = "discontinued:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(795, 95);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(67, 17);
            categoryLabel.TabIndex = 20;
            categoryLabel.Text = "category:";
            // 
            // databaseQuanLyBanHangDataSet
            // 
            this.databaseQuanLyBanHangDataSet.DataSetName = "DatabaseQuanLyBanHangDataSet";
            this.databaseQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.databaseQuanLyBanHangDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtproduct_code
            // 
            this.txtproduct_code.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_code", true));
            this.txtproduct_code.Location = new System.Drawing.Point(148, 25);
            this.txtproduct_code.Name = "txtproduct_code";
            this.txtproduct_code.Size = new System.Drawing.Size(164, 22);
            this.txtproduct_code.TabIndex = 2;
            // 
            // txtproduct_name
            // 
            this.txtproduct_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_name", true));
            this.txtproduct_name.Location = new System.Drawing.Point(148, 57);
            this.txtproduct_name.Name = "txtproduct_name";
            this.txtproduct_name.Size = new System.Drawing.Size(164, 22);
            this.txtproduct_name.TabIndex = 3;
            // 
            // txtdescription
            // 
            this.txtdescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "description", true));
            this.txtdescription.Location = new System.Drawing.Point(148, 90);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(164, 22);
            this.txtdescription.TabIndex = 5;
            // 
            // txtstandard_cost
            // 
            this.txtstandard_cost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "standard_cost", true));
            this.txtstandard_cost.Location = new System.Drawing.Point(148, 123);
            this.txtstandard_cost.Name = "txtstandard_cost";
            this.txtstandard_cost.Size = new System.Drawing.Size(164, 22);
            this.txtstandard_cost.TabIndex = 7;
            // 
            // txtlist_price
            // 
            this.txtlist_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "list_price", true));
            this.txtlist_price.Location = new System.Drawing.Point(544, 25);
            this.txtlist_price.Name = "txtlist_price";
            this.txtlist_price.Size = new System.Drawing.Size(145, 22);
            this.txtlist_price.TabIndex = 9;
            // 
            // nudtarget_level
            // 
            this.nudtarget_level.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "target_level", true));
            this.nudtarget_level.Location = new System.Drawing.Point(544, 57);
            this.nudtarget_level.Name = "nudtarget_level";
            this.nudtarget_level.Size = new System.Drawing.Size(145, 22);
            this.nudtarget_level.TabIndex = 11;
            // 
            // nudreorder_level
            // 
            this.nudreorder_level.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "reorder_level", true));
            this.nudreorder_level.Location = new System.Drawing.Point(544, 90);
            this.nudreorder_level.Name = "nudreorder_level";
            this.nudreorder_level.Size = new System.Drawing.Size(145, 22);
            this.nudreorder_level.TabIndex = 13;
            // 
            // nudminimum_reorder_quantity
            // 
            this.nudminimum_reorder_quantity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "minimum_reorder_quantity", true));
            this.nudminimum_reorder_quantity.Location = new System.Drawing.Point(544, 123);
            this.nudminimum_reorder_quantity.Name = "nudminimum_reorder_quantity";
            this.nudminimum_reorder_quantity.Size = new System.Drawing.Size(145, 22);
            this.nudminimum_reorder_quantity.TabIndex = 15;
            // 
            // txtquantity_per_unit
            // 
            this.txtquantity_per_unit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "quantity_per_unit", true));
            this.txtquantity_per_unit.Location = new System.Drawing.Point(868, 27);
            this.txtquantity_per_unit.Name = "txtquantity_per_unit";
            this.txtquantity_per_unit.Size = new System.Drawing.Size(161, 22);
            this.txtquantity_per_unit.TabIndex = 17;
            // 
            // txtdiscontinued
            // 
            this.txtdiscontinued.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "discontinued", true));
            this.txtdiscontinued.Location = new System.Drawing.Point(868, 59);
            this.txtdiscontinued.Name = "txtdiscontinued";
            this.txtdiscontinued.Size = new System.Drawing.Size(161, 22);
            this.txtdiscontinued.TabIndex = 19;
            // 
            // txtcategory
            // 
            this.txtcategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "category", true));
            this.txtcategory.Location = new System.Drawing.Point(868, 92);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(161, 22);
            this.txtcategory.TabIndex = 21;
            // 
            // dgvproducts
            // 
            this.dgvproducts.AutoGenerateColumns = false;
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvproducts.DataSource = this.productsBindingSource;
            this.dgvproducts.Location = new System.Drawing.Point(12, 176);
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.RowTemplate.Height = 24;
            this.dgvproducts.Size = new System.Drawing.Size(1066, 363);
            this.dgvproducts.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "product_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "standard_cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "standard_cost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "list_price";
            this.dataGridViewTextBoxColumn6.HeaderText = "list_price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "target_level";
            this.dataGridViewTextBoxColumn7.HeaderText = "target_level";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "reorder_level";
            this.dataGridViewTextBoxColumn8.HeaderText = "reorder_level";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "minimum_reorder_quantity";
            this.dataGridViewTextBoxColumn9.HeaderText = "minimum_reorder_quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "quantity_per_unit";
            this.dataGridViewTextBoxColumn10.HeaderText = "quantity_per_unit";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "discontinued";
            this.dataGridViewTextBoxColumn11.HeaderText = "discontinued";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn12.HeaderText = "category";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(477, 558);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(99, 33);
            this.btnthem.TabIndex = 36;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(602, 558);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(99, 33);
            this.btnsua.TabIndex = 37;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(726, 558);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(99, 33);
            this.btnxoa.TabIndex = 38;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(848, 558);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(99, 33);
            this.btnluu.TabIndex = 39;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(972, 558);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 33);
            this.btnthoat.TabIndex = 40;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Frmdanhmucsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 625);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvproducts);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(discontinuedLabel);
            this.Controls.Add(this.txtdiscontinued);
            this.Controls.Add(quantity_per_unitLabel);
            this.Controls.Add(this.txtquantity_per_unit);
            this.Controls.Add(minimum_reorder_quantityLabel);
            this.Controls.Add(this.nudminimum_reorder_quantity);
            this.Controls.Add(reorder_levelLabel);
            this.Controls.Add(this.nudreorder_level);
            this.Controls.Add(target_levelLabel);
            this.Controls.Add(this.nudtarget_level);
            this.Controls.Add(list_priceLabel);
            this.Controls.Add(this.txtlist_price);
            this.Controls.Add(standard_costLabel);
            this.Controls.Add(this.txtstandard_cost);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.txtproduct_name);
            this.Controls.Add(product_codeLabel);
            this.Controls.Add(this.txtproduct_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frmdanhmucsanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Sản Phẩm";
            this.Load += new System.EventHandler(this.Frmdanhmucsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtarget_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudreorder_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudminimum_reorder_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseQuanLyBanHangDataSet databaseQuanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DatabaseQuanLyBanHangDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtproduct_code;
        private System.Windows.Forms.TextBox txtproduct_name;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtstandard_cost;
        private System.Windows.Forms.TextBox txtlist_price;
        private System.Windows.Forms.NumericUpDown nudtarget_level;
        private System.Windows.Forms.NumericUpDown nudreorder_level;
        private System.Windows.Forms.NumericUpDown nudminimum_reorder_quantity;
        private System.Windows.Forms.TextBox txtquantity_per_unit;
        private System.Windows.Forms.TextBox txtdiscontinued;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
    }
}