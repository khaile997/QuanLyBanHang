namespace QuanLyBanHang.Functions
{
    partial class FrmDanhmuckhachhang
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
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label postal_codeLabel;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label countryLabel;
            this.databaseQuanLyBanHangDataSet = new QuanLyBanHang.DatabaseQuanLyBanHangDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress1 = new System.Windows.Forms.TextBox();
            this.txtpostal = new System.Windows.Forms.TextBox();
            this.txtaddress2 = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstate = new System.Windows.Forms.TextBox();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.dgvcustomers = new System.Windows.Forms.DataGridView();
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            postal_codeLabel = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(52, 30);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(73, 17);
            last_nameLabel.TabIndex = 0;
            last_nameLabel.Text = "last name:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(59, 71);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(74, 17);
            first_nameLabel.TabIndex = 2;
            first_nameLabel.Text = "first name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(80, 111);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 17);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "email:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(432, 30);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(69, 17);
            companyLabel.TabIndex = 6;
            companyLabel.Text = "company:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(449, 71);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 17);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "phone:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(432, 109);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(71, 17);
            address1Label.TabIndex = 10;
            address1Label.Text = "address1:";
            // 
            // postal_codeLabel
            // 
            postal_codeLabel.AutoSize = true;
            postal_codeLabel.Location = new System.Drawing.Point(418, 146);
            postal_codeLabel.Name = "postal_codeLabel";
            postal_codeLabel.Size = new System.Drawing.Size(85, 17);
            postal_codeLabel.TabIndex = 12;
            postal_codeLabel.Text = "postal code:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(784, 32);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(71, 17);
            address2Label.TabIndex = 14;
            address2Label.Text = "address2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(822, 69);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(33, 17);
            cityLabel.TabIndex = 16;
            cityLabel.Text = "city:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(812, 106);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(43, 17);
            stateLabel.TabIndex = 18;
            stateLabel.Text = "state:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(796, 143);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(59, 17);
            countryLabel.TabIndex = 20;
            countryLabel.Text = "country:";
            // 
            // databaseQuanLyBanHangDataSet
            // 
            this.databaseQuanLyBanHangDataSet.DataSetName = "DatabaseQuanLyBanHangDataSet";
            this.databaseQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.databaseQuanLyBanHangDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtlastname
            // 
            this.txtlastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "last_name", true));
            this.txtlastname.Location = new System.Drawing.Point(139, 25);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(166, 22);
            this.txtlastname.TabIndex = 1;
            // 
            // txtfirstname
            // 
            this.txtfirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "first_name", true));
            this.txtfirstname.Location = new System.Drawing.Point(139, 68);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(166, 22);
            this.txtfirstname.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email", true));
            this.txtemail.Location = new System.Drawing.Point(139, 109);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(166, 22);
            this.txtemail.TabIndex = 5;
            // 
            // txtcompany
            // 
            this.txtcompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "company", true));
            this.txtcompany.Location = new System.Drawing.Point(507, 27);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(164, 22);
            this.txtcompany.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone", true));
            this.txtphone.Location = new System.Drawing.Point(507, 68);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(164, 22);
            this.txtphone.TabIndex = 9;
            // 
            // txtaddress1
            // 
            this.txtaddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address1", true));
            this.txtaddress1.Location = new System.Drawing.Point(509, 106);
            this.txtaddress1.Name = "txtaddress1";
            this.txtaddress1.Size = new System.Drawing.Size(162, 22);
            this.txtaddress1.TabIndex = 11;
            // 
            // txtpostal
            // 
            this.txtpostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "postal_code", true));
            this.txtpostal.Location = new System.Drawing.Point(509, 143);
            this.txtpostal.Name = "txtpostal";
            this.txtpostal.Size = new System.Drawing.Size(162, 22);
            this.txtpostal.TabIndex = 13;
            // 
            // txtaddress2
            // 
            this.txtaddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address2", true));
            this.txtaddress2.Location = new System.Drawing.Point(861, 29);
            this.txtaddress2.Name = "txtaddress2";
            this.txtaddress2.Size = new System.Drawing.Size(168, 22);
            this.txtaddress2.TabIndex = 15;
            // 
            // txtcity
            // 
            this.txtcity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "city", true));
            this.txtcity.Location = new System.Drawing.Point(861, 66);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(168, 22);
            this.txtcity.TabIndex = 17;
            // 
            // txtstate
            // 
            this.txtstate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "state", true));
            this.txtstate.Location = new System.Drawing.Point(861, 103);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(168, 22);
            this.txtstate.TabIndex = 19;
            // 
            // txtcountry
            // 
            this.txtcountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "country", true));
            this.txtcountry.Location = new System.Drawing.Point(861, 140);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(168, 22);
            this.txtcountry.TabIndex = 21;
            // 
            // dgvcustomers
            // 
            this.dgvcustomers.AutoGenerateColumns = false;
            this.dgvcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvcustomers.DataSource = this.customersBindingSource;
            this.dgvcustomers.Location = new System.Drawing.Point(36, 187);
            this.dgvcustomers.Name = "dgvcustomers";
            this.dgvcustomers.RowTemplate.Height = 24;
            this.dgvcustomers.Size = new System.Drawing.Size(1021, 318);
            this.dgvcustomers.TabIndex = 22;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn4.HeaderText = "email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "company";
            this.dataGridViewTextBoxColumn5.HeaderText = "company";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "address1";
            this.dataGridViewTextBoxColumn7.HeaderText = "address1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "address2";
            this.dataGridViewTextBoxColumn8.HeaderText = "address2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn9.HeaderText = "city";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn10.HeaderText = "state";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "postal_code";
            this.dataGridViewTextBoxColumn11.HeaderText = "postal_code";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn12.HeaderText = "country";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(958, 525);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 33);
            this.btnthoat.TabIndex = 23;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(834, 525);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(99, 33);
            this.btnluu.TabIndex = 23;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(712, 525);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(99, 33);
            this.btnxoa.TabIndex = 23;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(588, 525);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(99, 33);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(463, 525);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(99, 33);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // FrmDanhmuckhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 571);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvcustomers);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.txtaddress2);
            this.Controls.Add(postal_codeLabel);
            this.Controls.Add(this.txtpostal);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.txtaddress1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.txtcompany);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.txtlastname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDanhmuckhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Khách Hàng";
            this.Load += new System.EventHandler(this.FrmDanhmuckhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseQuanLyBanHangDataSet databaseQuanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DatabaseQuanLyBanHangDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress1;
        private System.Windows.Forms.TextBox txtpostal;
        private System.Windows.Forms.TextBox txtaddress2;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtstate;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.DataGridView dgvcustomers;
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
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
    }
}