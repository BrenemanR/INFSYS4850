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
            this.txtbox_DeliveryZip = new System.Windows.Forms.TextBox();
            this.txtbox_DeliveryState = new System.Windows.Forms.TextBox();
            this.txtbox_DeliveryCity = new System.Windows.Forms.TextBox();
            this.lbl_DeliveryAddress = new System.Windows.Forms.Label();
            this.txtbox_DeliveryAddress = new System.Windows.Forms.TextBox();
            this.lbl_DropoffInformatin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_DeliveryCity = new System.Windows.Forms.Label();
            this.lbl_DeliveryState = new System.Windows.Forms.Label();
            this.lbl_PickupZip = new System.Windows.Forms.Label();
            this.txtbox_PickupZip = new System.Windows.Forms.TextBox();
            this.lbl_PickupState = new System.Windows.Forms.Label();
            this.txtbox_PickupState = new System.Windows.Forms.TextBox();
            this.lbl_PickupCity = new System.Windows.Forms.Label();
            this.txtbox_PickupCity = new System.Windows.Forms.TextBox();
            this.lbl_PickupAddress = new System.Windows.Forms.Label();
            this.txtbox_PickupAddress = new System.Windows.Forms.TextBox();
            this.lbl_PickupInfo = new System.Windows.Forms.Label();
            this.combobox_OrderStatus = new System.Windows.Forms.ComboBox();
            this.lbl_DeliveryDate = new System.Windows.Forms.Label();
            this.lbl_PickupDate = new System.Windows.Forms.Label();
            this.lbl_BookDate = new System.Windows.Forms.Label();
            this.DropOffDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PickUpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BookDatePicker = new System.Windows.Forms.DateTimePicker();
            this.iNVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new WindowsFormsApp3.AppData();
            this.btn_SaveOrder = new System.Windows.Forms.Button();
            this.btn_CreateOrder = new System.Windows.Forms.Button();
            this.lbl_SpecialInstructions = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtbox_Invoice = new System.Windows.Forms.TextBox();
            this.txtbox_Company = new System.Windows.Forms.TextBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.txtbox_Zip = new System.Windows.Forms.TextBox();
            this.txtbox_State = new System.Windows.Forms.TextBox();
            this.txtbox_City = new System.Windows.Forms.TextBox();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
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
            this.combobox_CustomerIDZ = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iNVIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pICKUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dROPOFFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Home = new System.Windows.Forms.TabPage();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.tab_Container = new System.Windows.Forms.TabControl();
            this.iNVOICETableAdapter = new WindowsFormsApp3.AppDataTableAdapters.INVOICETableAdapter();
            this.oRDERSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERSTATUSTableAdapter = new WindowsFormsApp3.AppDataTableAdapters.ORDERSTATUSTableAdapter();
            this.checkBox_CopyDropoffInformation = new System.Windows.Forms.CheckBox();
            this.checkBox_CopyPickupInformation = new System.Windows.Forms.CheckBox();
            tab_CreateOrder = new System.Windows.Forms.TabPage();
            tab_CreateOrder.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.tab_ManageCustomers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_SearchOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tab_Home.SuspendLayout();
            this.tab_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSTATUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_CreateOrder
            // 
            tab_CreateOrder.BackColor = System.Drawing.SystemColors.Control;
            tab_CreateOrder.Controls.Add(this.txtbox_DeliveryZip);
            tab_CreateOrder.Controls.Add(this.txtbox_DeliveryState);
            tab_CreateOrder.Controls.Add(this.txtbox_DeliveryCity);
            tab_CreateOrder.Controls.Add(this.lbl_DeliveryAddress);
            tab_CreateOrder.Controls.Add(this.txtbox_DeliveryAddress);
            tab_CreateOrder.Controls.Add(this.lbl_DropoffInformatin);
            tab_CreateOrder.Controls.Add(this.panel3);
            tab_CreateOrder.Controls.Add(this.lbl_PickupZip);
            tab_CreateOrder.Controls.Add(this.txtbox_PickupZip);
            tab_CreateOrder.Controls.Add(this.lbl_PickupState);
            tab_CreateOrder.Controls.Add(this.txtbox_PickupState);
            tab_CreateOrder.Controls.Add(this.lbl_PickupCity);
            tab_CreateOrder.Controls.Add(this.txtbox_PickupCity);
            tab_CreateOrder.Controls.Add(this.lbl_PickupAddress);
            tab_CreateOrder.Controls.Add(this.txtbox_PickupAddress);
            tab_CreateOrder.Controls.Add(this.lbl_PickupInfo);
            tab_CreateOrder.Controls.Add(this.combobox_OrderStatus);
            tab_CreateOrder.Controls.Add(this.lbl_DeliveryDate);
            tab_CreateOrder.Controls.Add(this.lbl_PickupDate);
            tab_CreateOrder.Controls.Add(this.lbl_BookDate);
            tab_CreateOrder.Controls.Add(this.DropOffDatePicker);
            tab_CreateOrder.Controls.Add(this.PickUpDatePicker);
            tab_CreateOrder.Controls.Add(this.BookDatePicker);
            tab_CreateOrder.Controls.Add(this.btn_SaveOrder);
            tab_CreateOrder.Controls.Add(this.btn_CreateOrder);
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
            tab_CreateOrder.Controls.Add(this.lbl_Status);
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
            tab_CreateOrder.Controls.Add(this.combobox_CustomerIDZ);
            tab_CreateOrder.Controls.Add(this.panel2);
            tab_CreateOrder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tab_CreateOrder.Location = new System.Drawing.Point(4, 22);
            tab_CreateOrder.Name = "tab_CreateOrder";
            tab_CreateOrder.Padding = new System.Windows.Forms.Padding(3);
            tab_CreateOrder.Size = new System.Drawing.Size(788, 423);
            tab_CreateOrder.TabIndex = 5;
            tab_CreateOrder.Text = "Create Order";
            tab_CreateOrder.Click += new System.EventHandler(this.tab_CreateOrder_Click);
            // 
            // txtbox_DeliveryZip
            // 
            this.txtbox_DeliveryZip.Enabled = false;
            this.txtbox_DeliveryZip.Location = new System.Drawing.Point(380, 206);
            this.txtbox_DeliveryZip.Name = "txtbox_DeliveryZip";
            this.txtbox_DeliveryZip.Size = new System.Drawing.Size(125, 23);
            this.txtbox_DeliveryZip.TabIndex = 56;
            // 
            // txtbox_DeliveryState
            // 
            this.txtbox_DeliveryState.Enabled = false;
            this.txtbox_DeliveryState.Location = new System.Drawing.Point(380, 177);
            this.txtbox_DeliveryState.Name = "txtbox_DeliveryState";
            this.txtbox_DeliveryState.Size = new System.Drawing.Size(125, 23);
            this.txtbox_DeliveryState.TabIndex = 54;
            // 
            // txtbox_DeliveryCity
            // 
            this.txtbox_DeliveryCity.Enabled = false;
            this.txtbox_DeliveryCity.Location = new System.Drawing.Point(380, 148);
            this.txtbox_DeliveryCity.Name = "txtbox_DeliveryCity";
            this.txtbox_DeliveryCity.Size = new System.Drawing.Size(125, 23);
            this.txtbox_DeliveryCity.TabIndex = 52;
            // 
            // lbl_DeliveryAddress
            // 
            this.lbl_DeliveryAddress.AutoSize = true;
            this.lbl_DeliveryAddress.Location = new System.Drawing.Point(280, 122);
            this.lbl_DeliveryAddress.Name = "lbl_DeliveryAddress";
            this.lbl_DeliveryAddress.Size = new System.Drawing.Size(99, 15);
            this.lbl_DeliveryAddress.TabIndex = 51;
            this.lbl_DeliveryAddress.Text = "Delivery Address";
            // 
            // txtbox_DeliveryAddress
            // 
            this.txtbox_DeliveryAddress.Enabled = false;
            this.txtbox_DeliveryAddress.Location = new System.Drawing.Point(380, 119);
            this.txtbox_DeliveryAddress.Name = "txtbox_DeliveryAddress";
            this.txtbox_DeliveryAddress.Size = new System.Drawing.Size(125, 23);
            this.txtbox_DeliveryAddress.TabIndex = 49;
            // 
            // lbl_DropoffInformatin
            // 
            this.lbl_DropoffInformatin.AutoSize = true;
            this.lbl_DropoffInformatin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DropoffInformatin.Location = new System.Drawing.Point(282, 75);
            this.lbl_DropoffInformatin.Name = "lbl_DropoffInformatin";
            this.lbl_DropoffInformatin.Size = new System.Drawing.Size(145, 15);
            this.lbl_DropoffInformatin.TabIndex = 48;
            this.lbl_DropoffInformatin.Text = "DROPOFF INFORMATION:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox_CopyDropoffInformation);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lbl_DeliveryCity);
            this.panel3.Controls.Add(this.lbl_DeliveryState);
            this.panel3.Location = new System.Drawing.Point(276, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 172);
            this.panel3.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Delivery Zip:";
            // 
            // lbl_DeliveryCity
            // 
            this.lbl_DeliveryCity.AutoSize = true;
            this.lbl_DeliveryCity.Location = new System.Drawing.Point(6, 87);
            this.lbl_DeliveryCity.Name = "lbl_DeliveryCity";
            this.lbl_DeliveryCity.Size = new System.Drawing.Size(79, 15);
            this.lbl_DeliveryCity.TabIndex = 53;
            this.lbl_DeliveryCity.Text = "Delivery City:";
            // 
            // lbl_DeliveryState
            // 
            this.lbl_DeliveryState.AutoSize = true;
            this.lbl_DeliveryState.Location = new System.Drawing.Point(4, 116);
            this.lbl_DeliveryState.Name = "lbl_DeliveryState";
            this.lbl_DeliveryState.Size = new System.Drawing.Size(85, 15);
            this.lbl_DeliveryState.TabIndex = 55;
            this.lbl_DeliveryState.Text = "Delivery State:";
            // 
            // lbl_PickupZip
            // 
            this.lbl_PickupZip.AutoSize = true;
            this.lbl_PickupZip.Location = new System.Drawing.Point(9, 209);
            this.lbl_PickupZip.Name = "lbl_PickupZip";
            this.lbl_PickupZip.Size = new System.Drawing.Size(67, 15);
            this.lbl_PickupZip.TabIndex = 46;
            this.lbl_PickupZip.Text = "Pickup Zip:";
            // 
            // txtbox_PickupZip
            // 
            this.txtbox_PickupZip.Enabled = false;
            this.txtbox_PickupZip.Location = new System.Drawing.Point(107, 206);
            this.txtbox_PickupZip.Name = "txtbox_PickupZip";
            this.txtbox_PickupZip.Size = new System.Drawing.Size(125, 23);
            this.txtbox_PickupZip.TabIndex = 45;
            // 
            // lbl_PickupState
            // 
            this.lbl_PickupState.AutoSize = true;
            this.lbl_PickupState.Location = new System.Drawing.Point(9, 180);
            this.lbl_PickupState.Name = "lbl_PickupState";
            this.lbl_PickupState.Size = new System.Drawing.Size(77, 15);
            this.lbl_PickupState.TabIndex = 44;
            this.lbl_PickupState.Text = "Pickup State:";
            // 
            // txtbox_PickupState
            // 
            this.txtbox_PickupState.Enabled = false;
            this.txtbox_PickupState.Location = new System.Drawing.Point(107, 177);
            this.txtbox_PickupState.Name = "txtbox_PickupState";
            this.txtbox_PickupState.Size = new System.Drawing.Size(125, 23);
            this.txtbox_PickupState.TabIndex = 43;
            // 
            // lbl_PickupCity
            // 
            this.lbl_PickupCity.AutoSize = true;
            this.lbl_PickupCity.Location = new System.Drawing.Point(9, 151);
            this.lbl_PickupCity.Name = "lbl_PickupCity";
            this.lbl_PickupCity.Size = new System.Drawing.Size(71, 15);
            this.lbl_PickupCity.TabIndex = 42;
            this.lbl_PickupCity.Text = "Pickup City:";
            this.lbl_PickupCity.Click += new System.EventHandler(this.lbl_PickupCity_Click);
            // 
            // txtbox_PickupCity
            // 
            this.txtbox_PickupCity.Enabled = false;
            this.txtbox_PickupCity.Location = new System.Drawing.Point(107, 148);
            this.txtbox_PickupCity.Name = "txtbox_PickupCity";
            this.txtbox_PickupCity.Size = new System.Drawing.Size(125, 23);
            this.txtbox_PickupCity.TabIndex = 41;
            // 
            // lbl_PickupAddress
            // 
            this.lbl_PickupAddress.AutoSize = true;
            this.lbl_PickupAddress.Location = new System.Drawing.Point(7, 122);
            this.lbl_PickupAddress.Name = "lbl_PickupAddress";
            this.lbl_PickupAddress.Size = new System.Drawing.Size(94, 15);
            this.lbl_PickupAddress.TabIndex = 40;
            this.lbl_PickupAddress.Text = "Pickup Address:";
            // 
            // txtbox_PickupAddress
            // 
            this.txtbox_PickupAddress.Enabled = false;
            this.txtbox_PickupAddress.Location = new System.Drawing.Point(107, 119);
            this.txtbox_PickupAddress.Name = "txtbox_PickupAddress";
            this.txtbox_PickupAddress.Size = new System.Drawing.Size(125, 23);
            this.txtbox_PickupAddress.TabIndex = 38;
            // 
            // lbl_PickupInfo
            // 
            this.lbl_PickupInfo.AutoSize = true;
            this.lbl_PickupInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupInfo.Location = new System.Drawing.Point(9, 75);
            this.lbl_PickupInfo.Name = "lbl_PickupInfo";
            this.lbl_PickupInfo.Size = new System.Drawing.Size(132, 15);
            this.lbl_PickupInfo.TabIndex = 37;
            this.lbl_PickupInfo.Text = "PICKUP INFORMATION:";
            // 
            // combobox_OrderStatus
            // 
            this.combobox_OrderStatus.Enabled = false;
            this.combobox_OrderStatus.FormattingEnabled = true;
            this.combobox_OrderStatus.Items.AddRange(new object[] {
            "PENDING",
            "IN TRANSIT",
            "COMPLETE",
            "CANCELLED",
            "DELAYED"});
            this.combobox_OrderStatus.Location = new System.Drawing.Point(328, 394);
            this.combobox_OrderStatus.Name = "combobox_OrderStatus";
            this.combobox_OrderStatus.Size = new System.Drawing.Size(200, 23);
            this.combobox_OrderStatus.TabIndex = 36;
            // 
            // lbl_DeliveryDate
            // 
            this.lbl_DeliveryDate.AutoSize = true;
            this.lbl_DeliveryDate.Location = new System.Drawing.Point(240, 348);
            this.lbl_DeliveryDate.Name = "lbl_DeliveryDate";
            this.lbl_DeliveryDate.Size = new System.Drawing.Size(83, 15);
            this.lbl_DeliveryDate.TabIndex = 35;
            this.lbl_DeliveryDate.Text = "Delivery Date:";
            // 
            // lbl_PickupDate
            // 
            this.lbl_PickupDate.AutoSize = true;
            this.lbl_PickupDate.Location = new System.Drawing.Point(240, 301);
            this.lbl_PickupDate.Name = "lbl_PickupDate";
            this.lbl_PickupDate.Size = new System.Drawing.Size(75, 15);
            this.lbl_PickupDate.TabIndex = 34;
            this.lbl_PickupDate.Text = "Pickup Date:";
            // 
            // lbl_BookDate
            // 
            this.lbl_BookDate.AutoSize = true;
            this.lbl_BookDate.Location = new System.Drawing.Point(240, 252);
            this.lbl_BookDate.Name = "lbl_BookDate";
            this.lbl_BookDate.Size = new System.Drawing.Size(82, 15);
            this.lbl_BookDate.TabIndex = 33;
            this.lbl_BookDate.Text = "Booking Date:";
            // 
            // DropOffDatePicker
            // 
            this.DropOffDatePicker.Enabled = false;
            this.DropOffDatePicker.Location = new System.Drawing.Point(328, 342);
            this.DropOffDatePicker.Name = "DropOffDatePicker";
            this.DropOffDatePicker.Size = new System.Drawing.Size(200, 23);
            this.DropOffDatePicker.TabIndex = 32;
            // 
            // PickUpDatePicker
            // 
            this.PickUpDatePicker.Enabled = false;
            this.PickUpDatePicker.Location = new System.Drawing.Point(328, 295);
            this.PickUpDatePicker.Name = "PickUpDatePicker";
            this.PickUpDatePicker.Size = new System.Drawing.Size(200, 23);
            this.PickUpDatePicker.TabIndex = 31;
            // 
            // BookDatePicker
            // 
            this.BookDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "BOOK_DATE", true));
            this.BookDatePicker.Enabled = false;
            this.BookDatePicker.Location = new System.Drawing.Point(328, 249);
            this.BookDatePicker.Name = "BookDatePicker";
            this.BookDatePicker.Size = new System.Drawing.Size(200, 23);
            this.BookDatePicker.TabIndex = 30;
            // 
            // iNVOICEBindingSource
            // 
            this.iNVOICEBindingSource.DataMember = "INVOICE";
            this.iNVOICEBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_SaveOrder
            // 
            this.btn_SaveOrder.Enabled = false;
            this.btn_SaveOrder.Location = new System.Drawing.Point(549, 339);
            this.btn_SaveOrder.Name = "btn_SaveOrder";
            this.btn_SaveOrder.Size = new System.Drawing.Size(149, 56);
            this.btn_SaveOrder.TabIndex = 28;
            this.btn_SaveOrder.Text = "Save Order";
            this.btn_SaveOrder.UseVisualStyleBackColor = true;
            this.btn_SaveOrder.Click += new System.EventHandler(this.btn_SaveOrder_Click);
            // 
            // btn_CreateOrder
            // 
            this.btn_CreateOrder.Location = new System.Drawing.Point(549, 260);
            this.btn_CreateOrder.Name = "btn_CreateOrder";
            this.btn_CreateOrder.Size = new System.Drawing.Size(149, 56);
            this.btn_CreateOrder.TabIndex = 26;
            this.btn_CreateOrder.Text = "Create Order";
            this.btn_CreateOrder.UseVisualStyleBackColor = true;
            this.btn_CreateOrder.Click += new System.EventHandler(this.btn_CreateOrder_Click);
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
            this.txtbox_Invoice.Location = new System.Drawing.Point(618, 228);
            this.txtbox_Invoice.Name = "txtbox_Invoice";
            this.txtbox_Invoice.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Invoice.TabIndex = 16;
            // 
            // txtbox_Company
            // 
            this.txtbox_Company.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_COMPANY", true));
            this.txtbox_Company.Enabled = false;
            this.txtbox_Company.Location = new System.Drawing.Point(276, 6);
            this.txtbox_Company.Name = "txtbox_Company";
            this.txtbox_Company.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Company.TabIndex = 14;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.appData;
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.txtbox_Email.Enabled = false;
            this.txtbox_Email.Location = new System.Drawing.Point(652, 9);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Email.TabIndex = 12;
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.txtbox_Phone.Enabled = false;
            this.txtbox_Phone.Location = new System.Drawing.Point(461, 6);
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Phone.TabIndex = 10;
            // 
            // txtbox_Zip
            // 
            this.txtbox_Zip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.txtbox_Zip.Enabled = false;
            this.txtbox_Zip.Location = new System.Drawing.Point(652, 35);
            this.txtbox_Zip.Name = "txtbox_Zip";
            this.txtbox_Zip.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Zip.TabIndex = 8;
            // 
            // txtbox_State
            // 
            this.txtbox_State.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.txtbox_State.Enabled = false;
            this.txtbox_State.Location = new System.Drawing.Point(461, 35);
            this.txtbox_State.Name = "txtbox_State";
            this.txtbox_State.Size = new System.Drawing.Size(121, 23);
            this.txtbox_State.TabIndex = 6;
            // 
            // txtbox_City
            // 
            this.txtbox_City.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.txtbox_City.Enabled = false;
            this.txtbox_City.Location = new System.Drawing.Point(276, 35);
            this.txtbox_City.Name = "txtbox_City";
            this.txtbox_City.Size = new System.Drawing.Size(121, 23);
            this.txtbox_City.TabIndex = 4;
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ADDRESS", true));
            this.txtbox_Address.Enabled = false;
            this.txtbox_Address.Location = new System.Drawing.Point(76, 35);
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(121, 23);
            this.txtbox_Address.TabIndex = 2;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(236, 394);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(79, 15);
            this.lbl_Status.TabIndex = 20;
            this.lbl_Status.Text = "Order Status:";
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
            this.lbl_Invoice.Location = new System.Drawing.Point(551, 236);
            this.lbl_Invoice.Name = "lbl_Invoice";
            this.lbl_Invoice.Size = new System.Drawing.Size(59, 15);
            this.lbl_Invoice.TabIndex = 17;
            this.lbl_Invoice.Text = "Invoice #:";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Location = new System.Drawing.Point(209, 9);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(61, 15);
            this.lbl_Company.TabIndex = 15;
            this.lbl_Company.Text = "Company:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(601, 12);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(41, 15);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(409, 9);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(44, 15);
            this.lbl_Phone.TabIndex = 11;
            this.lbl_Phone.Text = "Phone:";
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Location = new System.Drawing.Point(601, 38);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(27, 15);
            this.lbl_Zip.TabIndex = 9;
            this.lbl_Zip.Text = "Zip:";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(409, 38);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(37, 15);
            this.lbl_State.TabIndex = 7;
            this.lbl_State.Text = "State:";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(209, 38);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(31, 15);
            this.lbl_City.TabIndex = 5;
            this.lbl_City.Text = "City:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(9, 38);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(54, 15);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer:";
            // 
            // combobox_CustomerIDZ
            // 
            this.combobox_CustomerIDZ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_CustomerIDZ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_CustomerIDZ.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cUSTOMERBindingSource, "CUST_ID", true));
            this.combobox_CustomerIDZ.DataSource = this.cUSTOMERBindingSource;
            this.combobox_CustomerIDZ.DisplayMember = "CUST_LNAME";
            this.combobox_CustomerIDZ.Enabled = false;
            this.combobox_CustomerIDZ.FormattingEnabled = true;
            this.combobox_CustomerIDZ.Location = new System.Drawing.Point(76, 6);
            this.combobox_CustomerIDZ.Name = "combobox_CustomerIDZ";
            this.combobox_CustomerIDZ.Size = new System.Drawing.Size(121, 23);
            this.combobox_CustomerIDZ.TabIndex = 0;
            this.combobox_CustomerIDZ.ValueMember = "CUST_ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox_CopyPickupInformation);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 172);
            this.panel2.TabIndex = 47;
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
            this.tab_SearchOrders.Controls.Add(this.dataGridView2);
            this.tab_SearchOrders.Location = new System.Drawing.Point(4, 22);
            this.tab_SearchOrders.Name = "tab_SearchOrders";
            this.tab_SearchOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SearchOrders.Size = new System.Drawing.Size(788, 423);
            this.tab_SearchOrders.TabIndex = 3;
            this.tab_SearchOrders.Text = "Search Orders";
            this.tab_SearchOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNVIDDataGridViewTextBoxColumn,
            this.bOOKDATEDataGridViewTextBoxColumn,
            this.pICKUPDATEDataGridViewTextBoxColumn,
            this.dROPOFFDATEDataGridViewTextBoxColumn,
            this.cUSTIDDataGridViewTextBoxColumn1,
            this.oRDERSTATUSDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.iNVOICEBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(18, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(742, 150);
            this.dataGridView2.TabIndex = 0;
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
            // cUSTIDDataGridViewTextBoxColumn1
            // 
            this.cUSTIDDataGridViewTextBoxColumn1.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn1.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn1.Name = "cUSTIDDataGridViewTextBoxColumn1";
            // 
            // oRDERSTATUSDataGridViewTextBoxColumn
            // 
            this.oRDERSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ORDER_STATUS";
            this.oRDERSTATUSDataGridViewTextBoxColumn.HeaderText = "ORDER_STATUS";
            this.oRDERSTATUSDataGridViewTextBoxColumn.Name = "oRDERSTATUSDataGridViewTextBoxColumn";
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
            // iNVOICETableAdapter
            // 
            this.iNVOICETableAdapter.ClearBeforeFill = true;
            // 
            // oRDERSTATUSBindingSource
            // 
            this.oRDERSTATUSBindingSource.DataMember = "ORDERSTATUS";
            this.oRDERSTATUSBindingSource.DataSource = this.appData;
            // 
            // oRDERSTATUSTableAdapter
            // 
            this.oRDERSTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox_CopyDropoffInformation
            // 
            this.checkBox_CopyDropoffInformation.AutoSize = true;
            this.checkBox_CopyDropoffInformation.Enabled = false;
            this.checkBox_CopyDropoffInformation.Location = new System.Drawing.Point(33, 29);
            this.checkBox_CopyDropoffInformation.Name = "checkBox_CopyDropoffInformation";
            this.checkBox_CopyDropoffInformation.Size = new System.Drawing.Size(137, 19);
            this.checkBox_CopyDropoffInformation.TabIndex = 59;
            this.checkBox_CopyDropoffInformation.Text = "Copy Customer Data";
            this.checkBox_CopyDropoffInformation.UseVisualStyleBackColor = true;
            this.checkBox_CopyDropoffInformation.CheckedChanged += new System.EventHandler(this.checkBox_CopyDropoffInformation_CheckedChanged);
            // 
            // checkBox_CopyPickupInformation
            // 
            this.checkBox_CopyPickupInformation.AutoSize = true;
            this.checkBox_CopyPickupInformation.Enabled = false;
            this.checkBox_CopyPickupInformation.Location = new System.Drawing.Point(9, 30);
            this.checkBox_CopyPickupInformation.Name = "checkBox_CopyPickupInformation";
            this.checkBox_CopyPickupInformation.Size = new System.Drawing.Size(137, 19);
            this.checkBox_CopyPickupInformation.TabIndex = 60;
            this.checkBox_CopyPickupInformation.Text = "Copy Customer Data";
            this.checkBox_CopyPickupInformation.UseVisualStyleBackColor = true;
            this.checkBox_CopyPickupInformation.CheckedChanged += new System.EventHandler(this.checkBox_CopyPickupInformation_CheckedChanged);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tab_ManageCustomers.ResumeLayout(false);
            this.tab_ManageCustomers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_SearchOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tab_Home.ResumeLayout(false);
            this.tab_Home.PerformLayout();
            this.tab_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSTATUSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AppData appData;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private AppDataTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
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
        private System.Windows.Forms.ComboBox combobox_CustomerIDZ;
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
        private System.Windows.Forms.Button btn_SaveOrder;
        private System.Windows.Forms.Button btn_CreateOrder;
        private System.Windows.Forms.BindingSource iNVOICEBindingSource;
        private AppDataTableAdapters.INVOICETableAdapter iNVOICETableAdapter;
        private System.Windows.Forms.DateTimePicker DropOffDatePicker;
        private System.Windows.Forms.DateTimePicker PickUpDatePicker;
        private System.Windows.Forms.DateTimePicker BookDatePicker;
        private System.Windows.Forms.BindingSource oRDERSTATUSBindingSource;
        private AppDataTableAdapters.ORDERSTATUSTableAdapter oRDERSTATUSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERSTATUSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_BookDate;
        private System.Windows.Forms.Label lbl_DeliveryDate;
        private System.Windows.Forms.Label lbl_PickupDate;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox combobox_OrderStatus;
        private System.Windows.Forms.TextBox txtbox_PickupAddress;
        private System.Windows.Forms.Label lbl_PickupInfo;
        private System.Windows.Forms.Label lbl_PickupZip;
        private System.Windows.Forms.TextBox txtbox_PickupZip;
        private System.Windows.Forms.Label lbl_PickupState;
        private System.Windows.Forms.TextBox txtbox_PickupState;
        private System.Windows.Forms.Label lbl_PickupCity;
        private System.Windows.Forms.TextBox txtbox_PickupCity;
        private System.Windows.Forms.Label lbl_PickupAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pICKUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dROPOFFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_DeliveryZip;
        private System.Windows.Forms.Label lbl_DeliveryState;
        private System.Windows.Forms.TextBox txtbox_DeliveryState;
        private System.Windows.Forms.Label lbl_DeliveryCity;
        private System.Windows.Forms.TextBox txtbox_DeliveryCity;
        private System.Windows.Forms.Label lbl_DeliveryAddress;
        private System.Windows.Forms.TextBox txtbox_DeliveryAddress;
        private System.Windows.Forms.Label lbl_DropoffInformatin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox_CopyDropoffInformation;
        private System.Windows.Forms.CheckBox checkBox_CopyPickupInformation;
    }
}