namespace WindowsFormsApp3
{
    partial class ManageOrders
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
            System.Windows.Forms.TabPage tabPage_AddOrder;
            this.btn_Invoice = new System.Windows.Forms.Button();
            this.lbl_Invoice = new System.Windows.Forms.Label();
            this.txtbox_Invoice = new System.Windows.Forms.TextBox();
            this.iNVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData1 = new WindowsFormsApp3.AppData();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.txtbox_Company = new System.Windows.Forms.TextBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Zip = new System.Windows.Forms.Label();
            this.txtbox_Zip = new System.Windows.Forms.TextBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.txtbox_State = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txtbox_City = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iNVOICETableAdapter = new WindowsFormsApp3.AppDataTableAdapters.INVOICETableAdapter();
            this.tab_ManageOrders = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iNVIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pICKUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dROPOFFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERSTATUSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERTableAdapter = new WindowsFormsApp3.AppDataTableAdapters.CUSTOMERTableAdapter();
            this.combobox_OrderStatus = new System.Windows.Forms.ComboBox();
            this.oRDERSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERSTATUSTableAdapter = new WindowsFormsApp3.AppDataTableAdapters.ORDERSTATUSTableAdapter();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_DateOfService = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_SpecialInstructions = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iNVIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pICKUPDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dROPOFFDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERSTATUSIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVOICEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            tabPage_AddOrder = new System.Windows.Forms.TabPage();
            tabPage_AddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.tab_ManageOrders.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSTATUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_AddOrder
            // 
            tabPage_AddOrder.BackColor = System.Drawing.SystemColors.Control;
            tabPage_AddOrder.Controls.Add(this.dataGridView2);
            tabPage_AddOrder.Controls.Add(this.lbl_SpecialInstructions);
            tabPage_AddOrder.Controls.Add(this.richTextBox1);
            tabPage_AddOrder.Controls.Add(this.dateTimePicker1);
            tabPage_AddOrder.Controls.Add(this.lbl_DateOfService);
            tabPage_AddOrder.Controls.Add(this.lbl_Status);
            tabPage_AddOrder.Controls.Add(this.combobox_OrderStatus);
            tabPage_AddOrder.Controls.Add(this.btn_Invoice);
            tabPage_AddOrder.Controls.Add(this.lbl_Invoice);
            tabPage_AddOrder.Controls.Add(this.txtbox_Invoice);
            tabPage_AddOrder.Controls.Add(this.lbl_Company);
            tabPage_AddOrder.Controls.Add(this.txtbox_Company);
            tabPage_AddOrder.Controls.Add(this.lbl_Email);
            tabPage_AddOrder.Controls.Add(this.txtbox_Email);
            tabPage_AddOrder.Controls.Add(this.lbl_Phone);
            tabPage_AddOrder.Controls.Add(this.txtbox_Phone);
            tabPage_AddOrder.Controls.Add(this.lbl_Zip);
            tabPage_AddOrder.Controls.Add(this.txtbox_Zip);
            tabPage_AddOrder.Controls.Add(this.lbl_State);
            tabPage_AddOrder.Controls.Add(this.txtbox_State);
            tabPage_AddOrder.Controls.Add(this.lbl_City);
            tabPage_AddOrder.Controls.Add(this.txtbox_City);
            tabPage_AddOrder.Controls.Add(this.lbl_Address);
            tabPage_AddOrder.Controls.Add(this.txtbox_Address);
            tabPage_AddOrder.Controls.Add(this.label2);
            tabPage_AddOrder.Controls.Add(this.comboBox1);
            tabPage_AddOrder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabPage_AddOrder.Location = new System.Drawing.Point(4, 22);
            tabPage_AddOrder.Name = "tabPage_AddOrder";
            tabPage_AddOrder.Padding = new System.Windows.Forms.Padding(3);
            tabPage_AddOrder.Size = new System.Drawing.Size(1020, 570);
            tabPage_AddOrder.TabIndex = 0;
            tabPage_AddOrder.Text = "Add Order";
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
            this.btn_Invoice.Click += new System.EventHandler(this.btn_Invoice_Click);
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
            // txtbox_Invoice
            // 
            this.txtbox_Invoice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "INV_ID", true));
            this.txtbox_Invoice.Enabled = false;
            this.txtbox_Invoice.Location = new System.Drawing.Point(75, 238);
            this.txtbox_Invoice.Name = "txtbox_Invoice";
            this.txtbox_Invoice.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Invoice.TabIndex = 16;
            // 
            // iNVOICEBindingSource
            // 
            this.iNVOICEBindingSource.DataMember = "INVOICE";
            this.iNVOICEBindingSource.DataSource = this.appData1;
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cUSTOMERBindingSource.DataSource = this.appData1;
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
            // txtbox_Email
            // 
            this.txtbox_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.txtbox_Email.Enabled = false;
            this.txtbox_Email.Location = new System.Drawing.Point(75, 209);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Email.TabIndex = 12;
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
            // txtbox_Phone
            // 
            this.txtbox_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.txtbox_Phone.Enabled = false;
            this.txtbox_Phone.Location = new System.Drawing.Point(75, 180);
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Phone.TabIndex = 10;
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
            // txtbox_Zip
            // 
            this.txtbox_Zip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.txtbox_Zip.Enabled = false;
            this.txtbox_Zip.Location = new System.Drawing.Point(75, 151);
            this.txtbox_Zip.Name = "txtbox_Zip";
            this.txtbox_Zip.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Zip.TabIndex = 8;
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
            // txtbox_State
            // 
            this.txtbox_State.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.txtbox_State.Enabled = false;
            this.txtbox_State.Location = new System.Drawing.Point(75, 122);
            this.txtbox_State.Name = "txtbox_State";
            this.txtbox_State.Size = new System.Drawing.Size(121, 23);
            this.txtbox_State.TabIndex = 6;
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
            // txtbox_City
            // 
            this.txtbox_City.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.txtbox_City.Enabled = false;
            this.txtbox_City.Location = new System.Drawing.Point(75, 93);
            this.txtbox_City.Name = "txtbox_City";
            this.txtbox_City.Size = new System.Drawing.Size(121, 23);
            this.txtbox_City.TabIndex = 4;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(8, 67);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(54, 15);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address:";
            this.lbl_Address.Click += new System.EventHandler(this.label3_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer:";
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
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // iNVOICETableAdapter
            // 
            this.iNVOICETableAdapter.ClearBeforeFill = true;
            // 
            // tab_ManageOrders
            // 
            this.tab_ManageOrders.Controls.Add(tabPage_AddOrder);
            this.tab_ManageOrders.Controls.Add(this.tabPage2);
            this.tab_ManageOrders.Location = new System.Drawing.Point(1, 0);
            this.tab_ManageOrders.Name = "tab_ManageOrders";
            this.tab_ManageOrders.SelectedIndex = 0;
            this.tab_ManageOrders.Size = new System.Drawing.Size(1028, 596);
            this.tab_ManageOrders.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.SearchBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.btnNew);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Orders";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(59, 113);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(194, 23);
            this.SearchBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Search:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(535, 99);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 38);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(301, 99);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 38);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(412, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 38);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(700, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNVIDDataGridViewTextBoxColumn,
            this.bOOKDATEDataGridViewTextBoxColumn,
            this.pICKUPDATEDataGridViewTextBoxColumn,
            this.dROPOFFDATEDataGridViewTextBoxColumn,
            this.cOMPANYIDDataGridViewTextBoxColumn,
            this.cUSTIDDataGridViewTextBoxColumn,
            this.oRDERSTATUSIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNVOICEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 275);
            this.dataGridView1.TabIndex = 26;
            // 
            // iNVIDDataGridViewTextBoxColumn
            // 
            this.iNVIDDataGridViewTextBoxColumn.DataPropertyName = "INV_ID";
            this.iNVIDDataGridViewTextBoxColumn.HeaderText = "INV_ID";
            this.iNVIDDataGridViewTextBoxColumn.Name = "iNVIDDataGridViewTextBoxColumn";
            // 
            // bOOKDATEDataGridViewTextBoxColumn
            // 
            this.bOOKDATEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_DATE";
            this.bOOKDATEDataGridViewTextBoxColumn.HeaderText = "BOOK_DATE";
            this.bOOKDATEDataGridViewTextBoxColumn.Name = "bOOKDATEDataGridViewTextBoxColumn";
            // 
            // pICKUPDATEDataGridViewTextBoxColumn
            // 
            this.pICKUPDATEDataGridViewTextBoxColumn.DataPropertyName = "PICKUP_DATE";
            this.pICKUPDATEDataGridViewTextBoxColumn.HeaderText = "PICKUP_DATE";
            this.pICKUPDATEDataGridViewTextBoxColumn.Name = "pICKUPDATEDataGridViewTextBoxColumn";
            // 
            // dROPOFFDATEDataGridViewTextBoxColumn
            // 
            this.dROPOFFDATEDataGridViewTextBoxColumn.DataPropertyName = "DROPOFF_DATE";
            this.dROPOFFDATEDataGridViewTextBoxColumn.HeaderText = "DROPOFF_DATE";
            this.dROPOFFDATEDataGridViewTextBoxColumn.Name = "dROPOFFDATEDataGridViewTextBoxColumn";
            // 
            // cOMPANYIDDataGridViewTextBoxColumn
            // 
            this.cOMPANYIDDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_ID";
            this.cOMPANYIDDataGridViewTextBoxColumn.HeaderText = "COMPANY_ID";
            this.cOMPANYIDDataGridViewTextBoxColumn.Name = "cOMPANYIDDataGridViewTextBoxColumn";
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            // 
            // oRDERSTATUSIDDataGridViewTextBoxColumn
            // 
            this.oRDERSTATUSIDDataGridViewTextBoxColumn.DataPropertyName = "ORDERSTATUS_ID";
            this.oRDERSTATUSIDDataGridViewTextBoxColumn.HeaderText = "ORDERSTATUS_ID";
            this.oRDERSTATUSIDDataGridViewTextBoxColumn.Name = "oRDERSTATUSIDDataGridViewTextBoxColumn";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // combobox_OrderStatus
            // 
            this.combobox_OrderStatus.DataSource = this.oRDERSTATUSBindingSource;
            this.combobox_OrderStatus.DisplayMember = "DESCRIPTION";
            this.combobox_OrderStatus.FormattingEnabled = true;
            this.combobox_OrderStatus.Location = new System.Drawing.Point(389, 9);
            this.combobox_OrderStatus.Name = "combobox_OrderStatus";
            this.combobox_OrderStatus.Size = new System.Drawing.Size(157, 23);
            this.combobox_OrderStatus.TabIndex = 19;
            this.combobox_OrderStatus.ValueMember = "ORDERSTATUS_ID";
            // 
            // oRDERSTATUSBindingSource
            // 
            this.oRDERSTATUSBindingSource.DataMember = "ORDERSTATUS";
            this.oRDERSTATUSBindingSource.DataSource = this.appData1;
            // 
            // oRDERSTATUSTableAdapter
            // 
            this.oRDERSTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(307, 12);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(79, 15);
            this.lbl_Status.TabIndex = 20;
            this.lbl_Status.Text = "Order Status:";
            this.lbl_Status.Click += new System.EventHandler(this.lbl_Status_Click);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 23);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(677, 447);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 117);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNVIDDataGridViewTextBoxColumn1,
            this.bOOKDATEDataGridViewTextBoxColumn1,
            this.pICKUPDATEDataGridViewTextBoxColumn1,
            this.dROPOFFDATEDataGridViewTextBoxColumn1,
            this.cOMPANYIDDataGridViewTextBoxColumn1,
            this.cUSTIDDataGridViewTextBoxColumn1,
            this.oRDERSTATUSIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.iNVOICEBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(225, 225);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(744, 175);
            this.dataGridView2.TabIndex = 25;
            // 
            // iNVIDDataGridViewTextBoxColumn1
            // 
            this.iNVIDDataGridViewTextBoxColumn1.DataPropertyName = "INV_ID";
            this.iNVIDDataGridViewTextBoxColumn1.HeaderText = "INV_ID";
            this.iNVIDDataGridViewTextBoxColumn1.Name = "iNVIDDataGridViewTextBoxColumn1";
            this.iNVIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bOOKDATEDataGridViewTextBoxColumn1
            // 
            this.bOOKDATEDataGridViewTextBoxColumn1.DataPropertyName = "BOOK_DATE";
            this.bOOKDATEDataGridViewTextBoxColumn1.HeaderText = "BOOK_DATE";
            this.bOOKDATEDataGridViewTextBoxColumn1.Name = "bOOKDATEDataGridViewTextBoxColumn1";
            this.bOOKDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pICKUPDATEDataGridViewTextBoxColumn1
            // 
            this.pICKUPDATEDataGridViewTextBoxColumn1.DataPropertyName = "PICKUP_DATE";
            this.pICKUPDATEDataGridViewTextBoxColumn1.HeaderText = "PICKUP_DATE";
            this.pICKUPDATEDataGridViewTextBoxColumn1.Name = "pICKUPDATEDataGridViewTextBoxColumn1";
            this.pICKUPDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dROPOFFDATEDataGridViewTextBoxColumn1
            // 
            this.dROPOFFDATEDataGridViewTextBoxColumn1.DataPropertyName = "DROPOFF_DATE";
            this.dROPOFFDATEDataGridViewTextBoxColumn1.HeaderText = "DROPOFF_DATE";
            this.dROPOFFDATEDataGridViewTextBoxColumn1.Name = "dROPOFFDATEDataGridViewTextBoxColumn1";
            this.dROPOFFDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cOMPANYIDDataGridViewTextBoxColumn1
            // 
            this.cOMPANYIDDataGridViewTextBoxColumn1.DataPropertyName = "COMPANY_ID";
            this.cOMPANYIDDataGridViewTextBoxColumn1.HeaderText = "COMPANY_ID";
            this.cOMPANYIDDataGridViewTextBoxColumn1.Name = "cOMPANYIDDataGridViewTextBoxColumn1";
            this.cOMPANYIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cUSTIDDataGridViewTextBoxColumn1
            // 
            this.cUSTIDDataGridViewTextBoxColumn1.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn1.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn1.Name = "cUSTIDDataGridViewTextBoxColumn1";
            this.cUSTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // oRDERSTATUSIDDataGridViewTextBoxColumn1
            // 
            this.oRDERSTATUSIDDataGridViewTextBoxColumn1.DataPropertyName = "ORDERSTATUS_ID";
            this.oRDERSTATUSIDDataGridViewTextBoxColumn1.HeaderText = "ORDERSTATUS_ID";
            this.oRDERSTATUSIDDataGridViewTextBoxColumn1.Name = "oRDERSTATUSIDDataGridViewTextBoxColumn1";
            this.oRDERSTATUSIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iNVOICEBindingSource1
            // 
            this.iNVOICEBindingSource1.DataMember = "INVOICE";
            this.iNVOICEBindingSource1.DataSource = this.appData1;
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 601);
            this.Controls.Add(this.tab_ManageOrders);
            this.Name = "ManageOrders";
            this.Text = "Manage Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageOrders_FormClosed);
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            tabPage_AddOrder.ResumeLayout(false);
            tabPage_AddOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.tab_ManageOrders.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSTATUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AppData appData1;
        private System.Windows.Forms.BindingSource iNVOICEBindingSource;
        private AppDataTableAdapters.INVOICETableAdapter iNVOICETableAdapter;
        private System.Windows.Forms.TabControl tab_ManageOrders;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pICKUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dROPOFFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERSTATUSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private AppDataTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txtbox_City;
        private System.Windows.Forms.Label lbl_Zip;
        private System.Windows.Forms.TextBox txtbox_Zip;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.TextBox txtbox_State;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtbox_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txtbox_Phone;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.TextBox txtbox_Company;
        private System.Windows.Forms.Label lbl_Invoice;
        private System.Windows.Forms.TextBox txtbox_Invoice;
        private System.Windows.Forms.Button btn_Invoice;
        private System.Windows.Forms.ComboBox combobox_OrderStatus;
        private System.Windows.Forms.BindingSource oRDERSTATUSBindingSource;
        private AppDataTableAdapters.ORDERSTATUSTableAdapter oRDERSTATUSTableAdapter;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_DateOfService;
        private System.Windows.Forms.Label lbl_SpecialInstructions;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pICKUPDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dROPOFFDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERSTATUSIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource iNVOICEBindingSource1;
    }
}