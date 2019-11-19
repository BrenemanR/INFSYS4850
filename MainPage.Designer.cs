namespace WindowsFormsApp3
{
    partial class MainPage
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
            System.Windows.Forms.TabPage tab_CreateOrder;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_SpecialInstructions = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtbox_Invoice = new System.Windows.Forms.TextBox();
            this.txtbox_Company = new System.Windows.Forms.TextBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new WindowsFormsApp3.AppData();
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.txtbox_Zip = new System.Windows.Forms.TextBox();
            this.txtbox_State = new System.Windows.Forms.TextBox();
            this.txtbox_City = new System.Windows.Forms.TextBox();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateOfService = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.combobox_OrderStatus = new System.Windows.Forms.ComboBox();
            this.btn_Invoice = new System.Windows.Forms.Button();
            this.lbl_Invoice = new System.Windows.Forms.Label();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Zip = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cUSTOMERTableAdapter = new WindowsFormsApp3.AppDataTableAdapters.CUSTOMERTableAdapter();
            this.tab_ManageCustomers = new System.Windows.Forms.TabPage();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ZipBox = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.CompanyBox = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTCOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTZIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tab_Help = new System.Windows.Forms.TabPage();
            this.tab_SearchOrders = new System.Windows.Forms.TabPage();
            this.tab_Home = new System.Windows.Forms.TabPage();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.tab_Container = new System.Windows.Forms.TabControl();
            tab_CreateOrder = new System.Windows.Forms.TabPage();
            tab_CreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.tab_ManageCustomers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_Home.SuspendLayout();
            this.tab_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_CreateOrder
            // 
            tab_CreateOrder.BackColor = System.Drawing.SystemColors.Control;
            tab_CreateOrder.Controls.Add(this.dataGridView2);
            tab_CreateOrder.Controls.Add(this.lbl_SpecialInstructions);
            tab_CreateOrder.Controls.Add(this.richTextBox1);
            tab_CreateOrder.Controls.Add(this.txtbox_Invoice);
            tab_CreateOrder.Controls.Add(this.txtbox_Company);
            tab_CreateOrder.Controls.Add(this.txtbox_Email);
            tab_CreateOrder.Controls.Add(this.txtbox_Phone);
            tab_CreateOrder.Controls.Add(this.txtbox_Zip);
            tab_CreateOrder.Controls.Add(this.txtbox_State);
            tab_CreateOrder.Controls.Add(this.txtbox_City);
            tab_CreateOrder.Controls.Add(this.txtbox_Address);
            tab_CreateOrder.Controls.Add(this.dateTimePicker1);
            tab_CreateOrder.Controls.Add(this.lbl_DateOfService);
            tab_CreateOrder.Controls.Add(this.lbl_Status);
            tab_CreateOrder.Controls.Add(this.combobox_OrderStatus);
            tab_CreateOrder.Controls.Add(this.btn_Invoice);
            tab_CreateOrder.Controls.Add(this.lbl_Invoice);
            tab_CreateOrder.Controls.Add(this.lbl_Company);
            tab_CreateOrder.Controls.Add(this.lbl_Email);
            tab_CreateOrder.Controls.Add(this.lbl_Phone);
            tab_CreateOrder.Controls.Add(this.lbl_Zip);
            tab_CreateOrder.Controls.Add(this.lbl_State);
            tab_CreateOrder.Controls.Add(this.lbl_City);
            tab_CreateOrder.Controls.Add(this.lbl_Address);
            tab_CreateOrder.Controls.Add(this.label6);
            tab_CreateOrder.Controls.Add(this.comboBox1);
            tab_CreateOrder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tab_CreateOrder.Location = new System.Drawing.Point(4, 22);
            tab_CreateOrder.Name = "tab_CreateOrder";
            tab_CreateOrder.Padding = new System.Windows.Forms.Padding(3);
            tab_CreateOrder.Size = new System.Drawing.Size(788, 423);
            tab_CreateOrder.TabIndex = 5;
            tab_CreateOrder.Text = "Create Order";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(225, 225);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(744, 175);
            this.dataGridView2.TabIndex = 25;
            // 
            // lbl_SpecialInstructions
            // 
            this.lbl_SpecialInstructions.AutoSize = true;
            this.lbl_SpecialInstructions.Location = new System.Drawing.Point(555, 450);
            this.lbl_SpecialInstructions.Name = "lbl_SpecialInstructions";
            this.lbl_SpecialInstructions.Size = new System.Drawing.Size(119, 15);
            this.lbl_SpecialInstructions.TabIndex = 24;
            this.lbl_SpecialInstructions.Text = "Special Instructions:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(677, 447);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 117);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // txtbox_Invoice
            // 
            this.txtbox_Invoice.Enabled = false;
            this.txtbox_Invoice.Location = new System.Drawing.Point(75, 238);
            this.txtbox_Invoice.Name = "txtbox_Invoice";
            this.txtbox_Invoice.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Invoice.TabIndex = 16;
            // 
            // txtbox_Company
            // 
            this.txtbox_Company.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_COMPANY", true));
            this.txtbox_Company.Enabled = false;
            this.txtbox_Company.Location = new System.Drawing.Point(75, 35);
            this.txtbox_Company.Name = "txtbox_Company";
            this.txtbox_Company.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Company.TabIndex = 14;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.txtbox_Email.Enabled = false;
            this.txtbox_Email.Location = new System.Drawing.Point(75, 209);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Email.TabIndex = 12;
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.txtbox_Phone.Enabled = false;
            this.txtbox_Phone.Location = new System.Drawing.Point(75, 180);
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Phone.TabIndex = 10;
            // 
            // txtbox_Zip
            // 
            this.txtbox_Zip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.txtbox_Zip.Enabled = false;
            this.txtbox_Zip.Location = new System.Drawing.Point(75, 151);
            this.txtbox_Zip.Name = "txtbox_Zip";
            this.txtbox_Zip.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Zip.TabIndex = 8;
            // 
            // txtbox_State
            // 
            this.txtbox_State.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.txtbox_State.Enabled = false;
            this.txtbox_State.Location = new System.Drawing.Point(75, 122);
            this.txtbox_State.Name = "txtbox_State";
            this.txtbox_State.Size = new System.Drawing.Size(121, 23);
            this.txtbox_State.TabIndex = 6;
            // 
            // txtbox_City
            // 
            this.txtbox_City.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.txtbox_City.Enabled = false;
            this.txtbox_City.Location = new System.Drawing.Point(75, 93);
            this.txtbox_City.Name = "txtbox_City";
            this.txtbox_City.Size = new System.Drawing.Size(121, 23);
            this.txtbox_City.TabIndex = 4;
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ADDRESS", true));
            this.txtbox_Address.Enabled = false;
            this.txtbox_Address.Location = new System.Drawing.Point(75, 64);
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Address.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 23);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // lbl_DateOfService
            // 
            this.lbl_DateOfService.AutoSize = true;
            this.lbl_DateOfService.Location = new System.Drawing.Point(292, 43);
            this.lbl_DateOfService.Name = "lbl_DateOfService";
            this.lbl_DateOfService.Size = new System.Drawing.Size(91, 15);
            this.lbl_DateOfService.TabIndex = 21;
            this.lbl_DateOfService.Text = "Date of Service:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(307, 12);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(79, 15);
            this.lbl_Status.TabIndex = 20;
            this.lbl_Status.Text = "Order Status:";
            // 
            // combobox_OrderStatus
            // 
            this.combobox_OrderStatus.DisplayMember = "DESCRIPTION";
            this.combobox_OrderStatus.FormattingEnabled = true;
            this.combobox_OrderStatus.Location = new System.Drawing.Point(389, 9);
            this.combobox_OrderStatus.Name = "combobox_OrderStatus";
            this.combobox_OrderStatus.Size = new System.Drawing.Size(157, 23);
            this.combobox_OrderStatus.TabIndex = 19;
            this.combobox_OrderStatus.ValueMember = "ORDERSTATUS_ID";
            // 
            // btn_Invoice
            // 
            this.btn_Invoice.Location = new System.Drawing.Point(7, 507);
            this.btn_Invoice.Name = "btn_Invoice";
            this.btn_Invoice.Size = new System.Drawing.Size(203, 60);
            this.btn_Invoice.TabIndex = 18;
            this.btn_Invoice.TabStop = false;
            this.btn_Invoice.Text = "Create Invoice";
            this.btn_Invoice.UseVisualStyleBackColor = true;
            // 
            // lbl_Invoice
            // 
            this.lbl_Invoice.AutoSize = true;
            this.lbl_Invoice.Location = new System.Drawing.Point(8, 246);
            this.lbl_Invoice.Name = "lbl_Invoice";
            this.lbl_Invoice.Size = new System.Drawing.Size(59, 15);
            this.lbl_Invoice.TabIndex = 17;
            this.lbl_Invoice.Text = "Invoice #:";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Location = new System.Drawing.Point(8, 38);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(61, 15);
            this.lbl_Company.TabIndex = 15;
            this.lbl_Company.Text = "Company:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(8, 212);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(41, 15);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(8, 183);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(44, 15);
            this.lbl_Phone.TabIndex = 11;
            this.lbl_Phone.Text = "Phone:";
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Location = new System.Drawing.Point(8, 154);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(27, 15);
            this.lbl_Zip.TabIndex = 9;
            this.lbl_Zip.Text = "Zip:";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(8, 125);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(37, 15);
            this.lbl_State.TabIndex = 7;
            this.lbl_State.Text = "State:";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(8, 96);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(31, 15);
            this.lbl_City.TabIndex = 5;
            this.lbl_City.Text = "City:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(8, 67);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(54, 15);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.cUSTOMERBindingSource;
            this.comboBox1.DisplayMember = "CUST_LNAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "CUST_LNAME";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tab_ManageCustomers
            // 
            this.tab_ManageCustomers.Controls.Add(this.SearchBox);
            this.tab_ManageCustomers.Controls.Add(this.panel1);
            this.tab_ManageCustomers.Controls.Add(this.label1);
            this.tab_ManageCustomers.Controls.Add(this.dataGridView1);
            this.tab_ManageCustomers.Controls.Add(this.btnEdit);
            this.tab_ManageCustomers.Controls.Add(this.btnCancel);
            this.tab_ManageCustomers.Controls.Add(this.btnNew);
            this.tab_ManageCustomers.Controls.Add(this.btnSave);
            this.tab_ManageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tab_ManageCustomers.Name = "tab_ManageCustomers";
            this.tab_ManageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ManageCustomers.Size = new System.Drawing.Size(788, 423);
            this.tab_ManageCustomers.TabIndex = 1;
            this.tab_ManageCustomers.Text = "Manage Customers";
            this.tab_ManageCustomers.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(60, 201);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(194, 20);
            this.SearchBox.TabIndex = 18;
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ZipLabel);
            this.panel1.Controls.Add(this.ZipBox);
            this.panel1.Controls.Add(this.CompanyLabel);
            this.panel1.Controls.Add(this.CompanyBox);
            this.panel1.Controls.Add(this.StateLabel);
            this.panel1.Controls.Add(this.StateBox);
            this.panel1.Controls.Add(this.CityLabel);
            this.panel1.Controls.Add(this.CityBox);
            this.panel1.Controls.Add(this.AddressLabel);
            this.panel1.Controls.Add(this.AddressBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FirstNameBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmailBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PhoneNumberBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LastNameBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 152);
            this.panel1.TabIndex = 0;
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(524, 26);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(25, 13);
            this.ZipLabel.TabIndex = 19;
            this.ZipLabel.Text = "Zip:";
            // 
            // ZipBox
            // 
            this.ZipBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.ZipBox.Location = new System.Drawing.Point(606, 23);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(142, 20);
            this.ZipBox.TabIndex = 18;
            this.ZipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipBox_KeyPress);
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(283, 26);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(54, 13);
            this.CompanyLabel.TabIndex = 17;
            this.CompanyLabel.Text = "Company:";
            // 
            // CompanyBox
            // 
            this.CompanyBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_COMPANY", true));
            this.CompanyBox.Location = new System.Drawing.Point(365, 23);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(142, 20);
            this.CompanyBox.TabIndex = 10;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(283, 104);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(35, 13);
            this.StateLabel.TabIndex = 16;
            this.StateLabel.Text = "State:";
            // 
            // StateBox
            // 
            this.StateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.StateBox.Location = new System.Drawing.Point(365, 101);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(142, 20);
            this.StateBox.TabIndex = 13;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(283, 78);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 15;
            this.CityLabel.Text = "City:";
            // 
            // CityBox
            // 
            this.CityBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.CityBox.Location = new System.Drawing.Point(365, 75);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(142, 20);
            this.CityBox.TabIndex = 12;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(283, 52);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Address:";
            // 
            // AddressBox
            // 
            this.AddressBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ADDRESS", true));
            this.AddressBox.Location = new System.Drawing.Point(365, 49);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(142, 20);
            this.AddressBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "First Name:";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_FNAME", true));
            this.FirstNameBox.Location = new System.Drawing.Point(96, 23);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(142, 20);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // EmailBox
            // 
            this.EmailBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.EmailBox.Location = new System.Drawing.Point(96, 101);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(142, 20);
            this.EmailBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number:";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.PhoneNumberBox.Location = new System.Drawing.Point(96, 75);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(142, 20);
            this.PhoneNumberBox.TabIndex = 2;
            this.PhoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // LastNameBox
            // 
            this.LastNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_LNAME", true));
            this.LastNameBox.Location = new System.Drawing.Point(96, 49);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(142, 20);
            this.LastNameBox.TabIndex = 1;
            this.LastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTIDDataGridViewTextBoxColumn,
            this.cUSTFNAMEDataGridViewTextBoxColumn,
            this.cUSTLNAMEDataGridViewTextBoxColumn,
            this.cUSTEMAILDataGridViewTextBoxColumn,
            this.cUSTPHONEDataGridViewTextBoxColumn,
            this.cUSTCOMPANYDataGridViewTextBoxColumn,
            this.cUSTADDRESSDataGridViewTextBoxColumn,
            this.cUSTCITYDataGridViewTextBoxColumn,
            this.cUSTSTATEDataGridViewTextBoxColumn,
            this.cUSTZIPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(767, 192);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            this.cUSTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTFNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTFNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUST_FNAME";
            this.cUSTFNAMEDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.cUSTFNAMEDataGridViewTextBoxColumn.Name = "cUSTFNAMEDataGridViewTextBoxColumn";
            this.cUSTFNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTLNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUST_LNAME";
            this.cUSTLNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.cUSTLNAMEDataGridViewTextBoxColumn.Name = "cUSTLNAMEDataGridViewTextBoxColumn";
            this.cUSTLNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTEMAILDataGridViewTextBoxColumn
            // 
            this.cUSTEMAILDataGridViewTextBoxColumn.DataPropertyName = "CUST_EMAIL";
            this.cUSTEMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.cUSTEMAILDataGridViewTextBoxColumn.Name = "cUSTEMAILDataGridViewTextBoxColumn";
            this.cUSTEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTPHONEDataGridViewTextBoxColumn
            // 
            this.cUSTPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUST_PHONE";
            this.cUSTPHONEDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cUSTPHONEDataGridViewTextBoxColumn.Name = "cUSTPHONEDataGridViewTextBoxColumn";
            this.cUSTPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTCOMPANYDataGridViewTextBoxColumn
            // 
            this.cUSTCOMPANYDataGridViewTextBoxColumn.DataPropertyName = "CUST_COMPANY";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.HeaderText = "Company";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.Name = "cUSTCOMPANYDataGridViewTextBoxColumn";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUST_ADDRESS";
            this.cUSTADDRESSDataGridViewTextBoxColumn.HeaderText = "Address";
            this.cUSTADDRESSDataGridViewTextBoxColumn.Name = "cUSTADDRESSDataGridViewTextBoxColumn";
            this.cUSTADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTCITYDataGridViewTextBoxColumn
            // 
            this.cUSTCITYDataGridViewTextBoxColumn.DataPropertyName = "CUST_CITY";
            this.cUSTCITYDataGridViewTextBoxColumn.HeaderText = "City";
            this.cUSTCITYDataGridViewTextBoxColumn.Name = "cUSTCITYDataGridViewTextBoxColumn";
            this.cUSTCITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTSTATEDataGridViewTextBoxColumn
            // 
            this.cUSTSTATEDataGridViewTextBoxColumn.DataPropertyName = "CUST_STATE";
            this.cUSTSTATEDataGridViewTextBoxColumn.HeaderText = "State";
            this.cUSTSTATEDataGridViewTextBoxColumn.Name = "cUSTSTATEDataGridViewTextBoxColumn";
            this.cUSTSTATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTZIPDataGridViewTextBoxColumn
            // 
            this.cUSTZIPDataGridViewTextBoxColumn.DataPropertyName = "CUST_ZIP";
            this.cUSTZIPDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.cUSTZIPDataGridViewTextBoxColumn.Name = "cUSTZIPDataGridViewTextBoxColumn";
            this.cUSTZIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(536, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 38);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(701, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(302, 187);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 38);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(413, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 38);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tab_Help
            // 
            this.tab_Help.Location = new System.Drawing.Point(4, 22);
            this.tab_Help.Name = "tab_Help";
            this.tab_Help.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Help.Size = new System.Drawing.Size(788, 423);
            this.tab_Help.TabIndex = 4;
            this.tab_Help.Text = "Help";
            this.tab_Help.UseVisualStyleBackColor = true;
            // 
            // tab_SearchOrders
            // 
            this.tab_SearchOrders.Location = new System.Drawing.Point(4, 22);
            this.tab_SearchOrders.Name = "tab_SearchOrders";
            this.tab_SearchOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SearchOrders.Size = new System.Drawing.Size(788, 423);
            this.tab_SearchOrders.TabIndex = 3;
            this.tab_SearchOrders.Text = "Search Orders";
            this.tab_SearchOrders.UseVisualStyleBackColor = true;
            // 
            // tab_Home
            // 
            this.tab_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_Home.BackgroundImage")));
            this.tab_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Home.Controls.Add(this.lbl_Home);
            this.tab_Home.Location = new System.Drawing.Point(4, 22);
            this.tab_Home.Name = "tab_Home";
            this.tab_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Home.Size = new System.Drawing.Size(788, 423);
            this.tab_Home.TabIndex = 0;
            this.tab_Home.Text = "Home";
            this.tab_Home.UseVisualStyleBackColor = true;
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.White;
            this.lbl_Home.Location = new System.Drawing.Point(78, 84);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(641, 44);
            this.lbl_Home.TabIndex = 21;
            this.lbl_Home.Text = "Welcome to Virtual Adil!";
            // 
            // tab_Container
            // 
            this.tab_Container.Controls.Add(this.tab_Home);
            this.tab_Container.Controls.Add(this.tab_ManageCustomers);
            this.tab_Container.Controls.Add(tab_CreateOrder);
            this.tab_Container.Controls.Add(this.tab_SearchOrders);
            this.tab_Container.Controls.Add(this.tab_Help);
            this.tab_Container.Location = new System.Drawing.Point(3, 0);
            this.tab_Container.Name = "tab_Container";
            this.tab_Container.SelectedIndex = 0;
            this.tab_Container.Size = new System.Drawing.Size(796, 449);
            this.tab_Container.TabIndex = 19;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Adil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCustomers_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageCustomers_FormClosed);
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            tab_CreateOrder.ResumeLayout(false);
            tab_CreateOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.tab_ManageCustomers.ResumeLayout(false);
            this.tab_ManageCustomers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_Home.ResumeLayout(false);
            this.tab_Home.PerformLayout();
            this.tab_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AppData appData;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private AppDataTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_SpecialInstructions;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtbox_Invoice;
        private System.Windows.Forms.TextBox txtbox_Company;
        private System.Windows.Forms.TextBox txtbox_Email;
        private System.Windows.Forms.TextBox txtbox_Phone;
        private System.Windows.Forms.TextBox txtbox_Zip;
        private System.Windows.Forms.TextBox txtbox_State;
        private System.Windows.Forms.TextBox txtbox_City;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_DateOfService;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox combobox_OrderStatus;
        private System.Windows.Forms.Button btn_Invoice;
        private System.Windows.Forms.Label lbl_Invoice;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Zip;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tab_ManageCustomers;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox ZipBox;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.TextBox CompanyBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTCOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTZIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tab_Help;
        private System.Windows.Forms.TabPage tab_SearchOrders;
        private System.Windows.Forms.TabPage tab_Home;
        private System.Windows.Forms.TabControl tab_Container;
        private System.Windows.Forms.Label lbl_Home;
    }
}