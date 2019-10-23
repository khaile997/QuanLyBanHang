namespace QuanLyBanHang.Functions
{
    partial class Frmdanhmucnhanvien
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label avatarLabel;
            System.Windows.Forms.Label job_titleLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label postal_codeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label manager_idLabel;
            this.databaseQuanLyBanHangDataSet = new QuanLyBanHang.DatabaseQuanLyBanHangDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.employeesTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtstate = new System.Windows.Forms.TextBox();
            this.txtavatar = new System.Windows.Forms.TextBox();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtpostal = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress1 = new System.Windows.Forms.TextBox();
            this.txtaddress2 = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.dgvemployees = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.nudmanager_id = new System.Windows.Forms.NumericUpDown();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            avatarLabel = new System.Windows.Forms.Label();
            job_titleLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            postal_codeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            manager_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmanager_id)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(38, 37);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(73, 17);
            last_nameLabel.TabIndex = 1;
            last_nameLabel.Text = "last name:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(38, 71);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(74, 17);
            first_nameLabel.TabIndex = 2;
            first_nameLabel.Text = "first name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(66, 104);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 17);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(40, 138);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(72, 17);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "password:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(69, 171);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(43, 17);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "state:";
            // 
            // avatarLabel
            // 
            avatarLabel.AutoSize = true;
            avatarLabel.Location = new System.Drawing.Point(446, 37);
            avatarLabel.Name = "avatarLabel";
            avatarLabel.Size = new System.Drawing.Size(52, 17);
            avatarLabel.TabIndex = 10;
            avatarLabel.Text = "avatar:";
            // 
            // job_titleLabel
            // 
            job_titleLabel.AutoSize = true;
            job_titleLabel.Location = new System.Drawing.Point(441, 71);
            job_titleLabel.Name = "job_titleLabel";
            job_titleLabel.Size = new System.Drawing.Size(57, 17);
            job_titleLabel.TabIndex = 12;
            job_titleLabel.Text = "job title:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(414, 106);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(84, 17);
            departmentLabel.TabIndex = 14;
            departmentLabel.Text = "department:";
            // 
            // postal_codeLabel
            // 
            postal_codeLabel.AutoSize = true;
            postal_codeLabel.Location = new System.Drawing.Point(413, 173);
            postal_codeLabel.Name = "postal_codeLabel";
            postal_codeLabel.Size = new System.Drawing.Size(85, 17);
            postal_codeLabel.TabIndex = 18;
            postal_codeLabel.Text = "postal code:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(795, 39);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 17);
            phoneLabel.TabIndex = 20;
            phoneLabel.Text = "phone:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(776, 73);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(71, 17);
            address1Label.TabIndex = 22;
            address1Label.Text = "address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(776, 106);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(71, 17);
            address2Label.TabIndex = 24;
            address2Label.Text = "address2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(814, 140);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(33, 17);
            cityLabel.TabIndex = 26;
            cityLabel.Text = "city:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(788, 175);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(59, 17);
            countryLabel.TabIndex = 28;
            countryLabel.Text = "country:";
            // 
            // manager_idLabel
            // 
            manager_idLabel.AutoSize = true;
            manager_idLabel.Location = new System.Drawing.Point(415, 137);
            manager_idLabel.Name = "manager_idLabel";
            manager_idLabel.Size = new System.Drawing.Size(83, 17);
            manager_idLabel.TabIndex = 35;
            manager_idLabel.Text = "manager id:";
            // 
            // databaseQuanLyBanHangDataSet
            // 
            this.databaseQuanLyBanHangDataSet.DataSetName = "DatabaseQuanLyBanHangDataSet";
            this.databaseQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.databaseQuanLyBanHangDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.configsTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.order_detailsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtlastname
            // 
            this.txtlastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "last_name", true));
            this.txtlastname.Location = new System.Drawing.Point(117, 34);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(168, 22);
            this.txtlastname.TabIndex = 2;
            // 
            // txtfirstname
            // 
            this.txtfirstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "first_name", true));
            this.txtfirstname.Location = new System.Drawing.Point(118, 68);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(167, 22);
            this.txtfirstname.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "email", true));
            this.txtemail.Location = new System.Drawing.Point(117, 101);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(168, 22);
            this.txtemail.TabIndex = 5;
            // 
            // txtpass
            // 
            this.txtpass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "password", true));
            this.txtpass.Location = new System.Drawing.Point(118, 135);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(167, 22);
            this.txtpass.TabIndex = 7;
            // 
            // txtstate
            // 
            this.txtstate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "state", true));
            this.txtstate.Location = new System.Drawing.Point(118, 168);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(167, 22);
            this.txtstate.TabIndex = 9;
            // 
            // txtavatar
            // 
            this.txtavatar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "avatar", true));
            this.txtavatar.Location = new System.Drawing.Point(504, 34);
            this.txtavatar.Name = "txtavatar";
            this.txtavatar.Size = new System.Drawing.Size(170, 22);
            this.txtavatar.TabIndex = 11;
            // 
            // txtjob
            // 
            this.txtjob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "job_title", true));
            this.txtjob.Location = new System.Drawing.Point(504, 68);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(170, 22);
            this.txtjob.TabIndex = 13;
            // 
            // txtdepartment
            // 
            this.txtdepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "department", true));
            this.txtdepartment.Location = new System.Drawing.Point(504, 103);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(170, 22);
            this.txtdepartment.TabIndex = 15;
            // 
            // txtpostal
            // 
            this.txtpostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "postal_code", true));
            this.txtpostal.Location = new System.Drawing.Point(504, 170);
            this.txtpostal.Name = "txtpostal";
            this.txtpostal.Size = new System.Drawing.Size(170, 22);
            this.txtpostal.TabIndex = 19;
            // 
            // txtphone
            // 
            this.txtphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "phone", true));
            this.txtphone.Location = new System.Drawing.Point(853, 36);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(186, 22);
            this.txtphone.TabIndex = 21;
            // 
            // txtaddress1
            // 
            this.txtaddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "address1", true));
            this.txtaddress1.Location = new System.Drawing.Point(853, 70);
            this.txtaddress1.Name = "txtaddress1";
            this.txtaddress1.Size = new System.Drawing.Size(186, 22);
            this.txtaddress1.TabIndex = 23;
            // 
            // txtaddress2
            // 
            this.txtaddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "address2", true));
            this.txtaddress2.Location = new System.Drawing.Point(853, 103);
            this.txtaddress2.Name = "txtaddress2";
            this.txtaddress2.Size = new System.Drawing.Size(186, 22);
            this.txtaddress2.TabIndex = 25;
            // 
            // txtcity
            // 
            this.txtcity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "city", true));
            this.txtcity.Location = new System.Drawing.Point(853, 137);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(186, 22);
            this.txtcity.TabIndex = 27;
            // 
            // txtcountry
            // 
            this.txtcountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "country", true));
            this.txtcountry.Location = new System.Drawing.Point(853, 172);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(186, 22);
            this.txtcountry.TabIndex = 29;
            // 
            // dgvemployees
            // 
            this.dgvemployees.AutoGenerateColumns = false;
            this.dgvemployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dgvemployees.DataSource = this.employeesBindingSource;
            this.dgvemployees.Location = new System.Drawing.Point(41, 208);
            this.dgvemployees.Name = "dgvemployees";
            this.dgvemployees.RowTemplate.Height = 24;
            this.dgvemployees.Size = new System.Drawing.Size(1006, 351);
            this.dgvemployees.TabIndex = 30;
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn5.HeaderText = "password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "avatar";
            this.dataGridViewTextBoxColumn6.HeaderText = "avatar";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "job_title";
            this.dataGridViewTextBoxColumn7.HeaderText = "job_title";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "department";
            this.dataGridViewTextBoxColumn8.HeaderText = "department";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "manager_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "manager_id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn10.HeaderText = "phone";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "address1";
            this.dataGridViewTextBoxColumn11.HeaderText = "address1";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "address2";
            this.dataGridViewTextBoxColumn12.HeaderText = "address2";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn13.HeaderText = "city";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn14.HeaderText = "state";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "postal_code";
            this.dataGridViewTextBoxColumn15.HeaderText = "postal_code";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn16.HeaderText = "country";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(454, 573);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(99, 33);
            this.btnthem.TabIndex = 31;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(579, 573);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(99, 33);
            this.btnsua.TabIndex = 32;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(703, 573);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(99, 33);
            this.btnxoa.TabIndex = 33;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(825, 573);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(99, 33);
            this.btnluu.TabIndex = 34;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(949, 573);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 33);
            this.btnthoat.TabIndex = 35;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // nudmanager_id
            // 
            this.nudmanager_id.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "manager_id", true));
            this.nudmanager_id.Location = new System.Drawing.Point(504, 137);
            this.nudmanager_id.Name = "nudmanager_id";
            this.nudmanager_id.Size = new System.Drawing.Size(170, 22);
            this.nudmanager_id.TabIndex = 36;
            // 
            // Frmdanhmucnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 626);
            this.Controls.Add(manager_idLabel);
            this.Controls.Add(this.nudmanager_id);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvemployees);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.txtaddress2);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.txtaddress1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(postal_codeLabel);
            this.Controls.Add(this.txtpostal);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(job_titleLabel);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(avatarLabel);
            this.Controls.Add(this.txtavatar);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.txtlastname);
            this.MaximizeBox = false;
            this.Name = "Frmdanhmucnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Nhân Viên";
            this.Load += new System.EventHandler(this.Frmdanhmucnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseQuanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmanager_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseQuanLyBanHangDataSet databaseQuanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DatabaseQuanLyBanHangDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private DatabaseQuanLyBanHangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtstate;
        private System.Windows.Forms.TextBox txtavatar;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtpostal;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress1;
        private System.Windows.Forms.TextBox txtaddress2;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.DataGridView dgvemployees;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.NumericUpDown nudmanager_id;
    }
}