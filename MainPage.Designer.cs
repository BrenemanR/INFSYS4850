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
            this.comboBox_Vehicle = new System.Windows.Forms.ComboBox();
            this.lbl_Vehicle = new System.Windows.Forms.Label();
            this.txtBox_InvoiceNumber = new System.Windows.Forms.TextBox();
            this.iNVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new WindowsFormsApp3.AppData();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.picBox_Status = new System.Windows.Forms.PictureBox();
            this.lbl_OrderStatus = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txtboxrch_Description = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox_CopyDropoffInformation = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_DeliveryZip = new System.Windows.Forms.TextBox();
            this.lbl_DeliveryCity = new System.Windows.Forms.Label();
            this.txtbox_DeliveryState = new System.Windows.Forms.TextBox();
            this.lbl_DeliveryState = new System.Windows.Forms.Label();
            this.txtbox_DeliveryCity = new System.Windows.Forms.TextBox();
            this.lbl_DropoffInformatin = new System.Windows.Forms.Label();
            this.txtbox_DeliveryAddress = new System.Windows.Forms.TextBox();
            this.lbl_DeliveryAddress = new System.Windows.Forms.Label();
            this.lbl_DeliveryDate = new System.Windows.Forms.Label();
            this.lbl_PickupDate = new System.Windows.Forms.Label();
            this.lbl_BookDate = new System.Windows.Forms.Label();
            this.DropOffDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PickUpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BookDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_SaveOrder = new System.Windows.Forms.Button();
            this.btn_CreateOrder = new System.Windows.Forms.Button();
            this.lbl_SpecialInstructions = new System.Windows.Forms.Label();
            this.txtboxrch_SpecialInstructions = new System.Windows.Forms.RichTextBox();
            this.txtbox_OrderNum = new System.Windows.Forms.TextBox();
            this.txtbox_Company = new System.Windows.Forms.TextBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.txtbox_Zip = new System.Windows.Forms.TextBox();
            this.txtbox_State = new System.Windows.Forms.TextBox();
            this.txtbox_City = new System.Windows.Forms.TextBox();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.lbl_Order = new System.Windows.Forms.Label();
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
            this.checkBox_CopyPickupInformation = new System.Windows.Forms.CheckBox();
            this.txtbox_PickupAddress = new System.Windows.Forms.TextBox();
            this.txtbox_PickupCity = new System.Windows.Forms.TextBox();
            this.txtbox_PickupState = new System.Windows.Forms.TextBox();
            this.txtbox_PickupZip = new System.Windows.Forms.TextBox();
            this.lbl_PickupZip = new System.Windows.Forms.Label();
            this.lbl_PickupState = new System.Windows.Forms.Label();
            this.lbl_PickupCity = new System.Windows.Forms.Label();
            this.lbl_PickupAddress = new System.Windows.Forms.Label();
            this.lbl_PickupInfo = new System.Windows.Forms.Label();
            this.tab_ManageCustomers = new System.Windows.Forms.TabPage();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_Broker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_RequiredField = new System.Windows.Forms.Label();
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BROKER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTCOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTZIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tab_Help = new System.Windows.Forms.TabPage();
            this.tab_SearchOrders = new System.Windows.Forms.TabPage();
            this.comboBox_VehicleEdit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_OrderNumberEdit = new System.Windows.Forms.TextBox();
            this.lbl_OrderNumberEdit = new System.Windows.Forms.Label();
            this.combobox_OrderStatusEdit = new System.Windows.Forms.ComboBox();
            this.btn_SaveOrderEdit = new System.Windows.Forms.Button();
            this.btn_EditOrder = new System.Windows.Forms.Button();
            this.dateTimePicker_DeliveryDateEdit = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_PickUpDateEdit = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_BookingDateEdit = new System.Windows.Forms.DateTimePicker();
            this.lbl_SpecialInstructionsEdit = new System.Windows.Forms.Label();
            this.txtboxrch_SpecailInstructionsEdit = new System.Windows.Forms.RichTextBox();
            this.lbl_DescriptionEdit = new System.Windows.Forms.Label();
            this.txtboxrch_DescriptionEdit = new System.Windows.Forms.RichTextBox();
            this.txtbox_DeliveryZipEdit = new System.Windows.Forms.TextBox();
            this.lbl_DeliveryZipEdit = new System.Windows.Forms.Label();
            this.txtbox_DeliveryStateEdit = new System.Windows.Forms.TextBox();
            this.lbl_DeliveryStateEdit = new System.Windows.Forms.Label();
            this.txtbox_DeliveryCityEdit = new System.Windows.Forms.TextBox();
            this.lbl_DeliveryCityEdit = new System.Windows.Forms.Label();
            this.txtbox_DeliveryAddressEdit = new System.Windows.Forms.TextBox();
            this.lbl_DeliveryAddressEdit = new System.Windows.Forms.Label();
            this.txtbox_PickUpZipEdit = new System.Windows.Forms.TextBox();
            this.lbl_PickUpZipEdit = new System.Windows.Forms.Label();
            this.txtbox_PickupStateEdit = new System.Windows.Forms.TextBox();
            this.lbl_PickUpStateEdit = new System.Windows.Forms.Label();
            this.txtbox_PickupCityEdit = new System.Windows.Forms.TextBox();
            this.lbl_PickUpCityEdit = new System.Windows.Forms.Label();
            this.txtbox_PickupAddressEdit = new System.Windows.Forms.TextBox();
            this.lbl_PickupAddressEdit = new System.Windows.Forms.Label();
            this.lbl_OrderStatusEdit = new System.Windows.Forms.Label();
            this.txtboxCustomerIdEdit = new System.Windows.Forms.TextBox();
            this.lbl_CustomerIdEdit = new System.Windows.Forms.Label();
            this.lbl_DeliveryDateEdit = new System.Windows.Forms.Label();
            this.lbl_BookingDateEdit = new System.Windows.Forms.Label();
            this.lbl_PickupDateEdit = new System.Windows.Forms.Label();
            this.txtbox_InvoiceIdEdit = new System.Windows.Forms.TextBox();
            this.lbl_InvoiceIdEdit = new System.Windows.Forms.Label();
            this.lbl_OrderSearch = new System.Windows.Forms.Label();
            this.txtbox_OrderSearchBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iNVIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEHICLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICKUP_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICKUP_CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICKUP_STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICKUP_ZIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELIVERY_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELIVERY_CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELIVERY_STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELIVERY_ZIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pICKUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dROPOFFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Home = new System.Windows.Forms.TabPage();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.tab_Container = new System.Windows.Forms.TabControl();
            this.cUSTOMERTableAdapter = new WindowsFormsApp3.AppDataTableAdapters.CUSTOMERTableAdapter();
            this.iNVOICETableAdapter = new WindowsFormsApp3.AppDataTableAdapters.INVOICETableAdapter();
            this.oRDERSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERSTATUSTableAdapter = new WindowsFormsApp3.AppDataTableAdapters.ORDERSTATUSTableAdapter();
            tab_CreateOrder = new System.Windows.Forms.TabPage();
            tab_CreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Status)).BeginInit();
            this.panel3.SuspendLayout();
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
            tab_CreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            tab_CreateOrder.Controls.Add(this.comboBox_Vehicle);
            tab_CreateOrder.Controls.Add(this.lbl_Vehicle);
            tab_CreateOrder.Controls.Add(this.txtBox_InvoiceNumber);
            tab_CreateOrder.Controls.Add(this.label2);
            tab_CreateOrder.Controls.Add(this.comboBox_Status);
            tab_CreateOrder.Controls.Add(this.picBox_Status);
            tab_CreateOrder.Controls.Add(this.lbl_OrderStatus);
            tab_CreateOrder.Controls.Add(this.lbl_Description);
            tab_CreateOrder.Controls.Add(this.txtboxrch_Description);
            tab_CreateOrder.Controls.Add(this.panel3);
            tab_CreateOrder.Controls.Add(this.lbl_DeliveryDate);
            tab_CreateOrder.Controls.Add(this.lbl_PickupDate);
            tab_CreateOrder.Controls.Add(this.lbl_BookDate);
            tab_CreateOrder.Controls.Add(this.DropOffDatePicker);
            tab_CreateOrder.Controls.Add(this.PickUpDatePicker);
            tab_CreateOrder.Controls.Add(this.BookDatePicker);
            tab_CreateOrder.Controls.Add(this.btn_SaveOrder);
            tab_CreateOrder.Controls.Add(this.btn_CreateOrder);
            tab_CreateOrder.Controls.Add(this.lbl_SpecialInstructions);
            tab_CreateOrder.Controls.Add(this.txtboxrch_SpecialInstructions);
            tab_CreateOrder.Controls.Add(this.txtbox_OrderNum);
            tab_CreateOrder.Controls.Add(this.txtbox_Company);
            tab_CreateOrder.Controls.Add(this.txtbox_Email);
            tab_CreateOrder.Controls.Add(this.txtbox_Phone);
            tab_CreateOrder.Controls.Add(this.txtbox_Zip);
            tab_CreateOrder.Controls.Add(this.txtbox_State);
            tab_CreateOrder.Controls.Add(this.txtbox_City);
            tab_CreateOrder.Controls.Add(this.txtbox_Address);
            tab_CreateOrder.Controls.Add(this.lbl_Order);
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
            tab_CreateOrder.ForeColor = System.Drawing.SystemColors.ControlLight;
            tab_CreateOrder.Location = new System.Drawing.Point(4, 28);
            tab_CreateOrder.Name = "tab_CreateOrder";
            tab_CreateOrder.Padding = new System.Windows.Forms.Padding(3);
            tab_CreateOrder.Size = new System.Drawing.Size(1107, 546);
            tab_CreateOrder.TabIndex = 5;
            tab_CreateOrder.Text = "Create Order";
            // 
            // comboBox_Vehicle
            // 
            this.comboBox_Vehicle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_Vehicle.Enabled = false;
            this.comboBox_Vehicle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Vehicle.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_Vehicle.FormattingEnabled = true;
            this.comboBox_Vehicle.Items.AddRange(new object[] {
            "Vehicle 1",
            "Vehicle 2",
            "Vehicle 3"});
            this.comboBox_Vehicle.Location = new System.Drawing.Point(918, 83);
            this.comboBox_Vehicle.Name = "comboBox_Vehicle";
            this.comboBox_Vehicle.Size = new System.Drawing.Size(173, 27);
            this.comboBox_Vehicle.TabIndex = 70;
            // 
            // lbl_Vehicle
            // 
            this.lbl_Vehicle.AutoSize = true;
            this.lbl_Vehicle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vehicle.Location = new System.Drawing.Point(814, 86);
            this.lbl_Vehicle.Name = "lbl_Vehicle";
            this.lbl_Vehicle.Size = new System.Drawing.Size(98, 19);
            this.lbl_Vehicle.TabIndex = 69;
            this.lbl_Vehicle.Text = "Vehicle Used:";
            // 
            // txtBox_InvoiceNumber
            // 
            this.txtBox_InvoiceNumber.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBox_InvoiceNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "INV_ID", true));
            this.txtBox_InvoiceNumber.Enabled = false;
            this.txtBox_InvoiceNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_InvoiceNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBox_InvoiceNumber.Location = new System.Drawing.Point(951, 9);
            this.txtBox_InvoiceNumber.Name = "txtBox_InvoiceNumber";
            this.txtBox_InvoiceNumber.Size = new System.Drawing.Size(140, 27);
            this.txtBox_InvoiceNumber.TabIndex = 66;
            this.txtBox_InvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(871, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Invoice #:";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_Status.Enabled = false;
            this.comboBox_Status.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Pending",
            "In Transit",
            "Delayed",
            "Complete",
            "Cancelled"});
            this.comboBox_Status.Location = new System.Drawing.Point(386, 326);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(169, 41);
            this.comboBox_Status.TabIndex = 13;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox_Status_SelectedIndexChanged);
            // 
            // picBox_Status
            // 
            this.picBox_Status.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picBox_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_Status.Enabled = false;
            this.picBox_Status.Location = new System.Drawing.Point(392, 372);
            this.picBox_Status.Name = "picBox_Status";
            this.picBox_Status.Size = new System.Drawing.Size(150, 150);
            this.picBox_Status.TabIndex = 65;
            this.picBox_Status.TabStop = false;
            // 
            // lbl_OrderStatus
            // 
            this.lbl_OrderStatus.AutoSize = true;
            this.lbl_OrderStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderStatus.Location = new System.Drawing.Point(382, 304);
            this.lbl_OrderStatus.Name = "lbl_OrderStatus";
            this.lbl_OrderStatus.Size = new System.Drawing.Size(100, 19);
            this.lbl_OrderStatus.TabIndex = 63;
            this.lbl_OrderStatus.Text = "Order Status:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(570, 101);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(90, 19);
            this.lbl_Description.TabIndex = 62;
            this.lbl_Description.Text = "Description:";
            // 
            // txtboxrch_Description
            // 
            this.txtboxrch_Description.AcceptsTab = true;
            this.txtboxrch_Description.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxrch_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxrch_Description.Enabled = false;
            this.txtboxrch_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxrch_Description.ForeColor = System.Drawing.SystemColors.Window;
            this.txtboxrch_Description.Location = new System.Drawing.Point(571, 123);
            this.txtboxrch_Description.Name = "txtboxrch_Description";
            this.txtboxrch_Description.ShowSelectionMargin = true;
            this.txtboxrch_Description.Size = new System.Drawing.Size(527, 166);
            this.txtboxrch_Description.TabIndex = 15;
            this.txtboxrch_Description.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox_CopyDropoffInformation);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtbox_DeliveryZip);
            this.panel3.Controls.Add(this.lbl_DeliveryCity);
            this.panel3.Controls.Add(this.txtbox_DeliveryState);
            this.panel3.Controls.Add(this.lbl_DeliveryState);
            this.panel3.Controls.Add(this.txtbox_DeliveryCity);
            this.panel3.Controls.Add(this.lbl_DropoffInformatin);
            this.panel3.Controls.Add(this.txtbox_DeliveryAddress);
            this.panel3.Controls.Add(this.lbl_DeliveryAddress);
            this.panel3.Location = new System.Drawing.Point(292, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 203);
            this.panel3.TabIndex = 58;
            // 
            // checkBox_CopyDropoffInformation
            // 
            this.checkBox_CopyDropoffInformation.AutoSize = true;
            this.checkBox_CopyDropoffInformation.Enabled = false;
            this.checkBox_CopyDropoffInformation.Location = new System.Drawing.Point(10, 37);
            this.checkBox_CopyDropoffInformation.Name = "checkBox_CopyDropoffInformation";
            this.checkBox_CopyDropoffInformation.Size = new System.Drawing.Size(137, 19);
            this.checkBox_CopyDropoffInformation.TabIndex = 9;
            this.checkBox_CopyDropoffInformation.Text = "Copy Customer Data";
            this.checkBox_CopyDropoffInformation.UseVisualStyleBackColor = true;
            this.checkBox_CopyDropoffInformation.CheckedChanged += new System.EventHandler(this.checkBox_CopyDropoffInformation_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 57;
            this.label7.Text = "Delivery Zip:";
            // 
            // txtbox_DeliveryZip
            // 
            this.txtbox_DeliveryZip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_DeliveryZip.Enabled = false;
            this.txtbox_DeliveryZip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_DeliveryZip.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_DeliveryZip.Location = new System.Drawing.Point(127, 160);
            this.txtbox_DeliveryZip.Name = "txtbox_DeliveryZip";
            this.txtbox_DeliveryZip.Size = new System.Drawing.Size(131, 27);
            this.txtbox_DeliveryZip.TabIndex = 56;
            // 
            // lbl_DeliveryCity
            // 
            this.lbl_DeliveryCity.AutoSize = true;
            this.lbl_DeliveryCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeliveryCity.Location = new System.Drawing.Point(3, 98);
            this.lbl_DeliveryCity.Name = "lbl_DeliveryCity";
            this.lbl_DeliveryCity.Size = new System.Drawing.Size(95, 19);
            this.lbl_DeliveryCity.TabIndex = 53;
            this.lbl_DeliveryCity.Text = "Delivery City:";
            // 
            // txtbox_DeliveryState
            // 
            this.txtbox_DeliveryState.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_DeliveryState.Enabled = false;
            this.txtbox_DeliveryState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_DeliveryState.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_DeliveryState.Location = new System.Drawing.Point(127, 128);
            this.txtbox_DeliveryState.Name = "txtbox_DeliveryState";
            this.txtbox_DeliveryState.Size = new System.Drawing.Size(131, 27);
            this.txtbox_DeliveryState.TabIndex = 54;
            // 
            // lbl_DeliveryState
            // 
            this.lbl_DeliveryState.AutoSize = true;
            this.lbl_DeliveryState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeliveryState.Location = new System.Drawing.Point(3, 131);
            this.lbl_DeliveryState.Name = "lbl_DeliveryState";
            this.lbl_DeliveryState.Size = new System.Drawing.Size(103, 19);
            this.lbl_DeliveryState.TabIndex = 55;
            this.lbl_DeliveryState.Text = "Delivery State:";
            // 
            // txtbox_DeliveryCity
            // 
            this.txtbox_DeliveryCity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_DeliveryCity.Enabled = false;
            this.txtbox_DeliveryCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_DeliveryCity.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_DeliveryCity.Location = new System.Drawing.Point(127, 96);
            this.txtbox_DeliveryCity.Name = "txtbox_DeliveryCity";
            this.txtbox_DeliveryCity.Size = new System.Drawing.Size(131, 27);
            this.txtbox_DeliveryCity.TabIndex = 52;
            // 
            // lbl_DropoffInformatin
            // 
            this.lbl_DropoffInformatin.AutoSize = true;
            this.lbl_DropoffInformatin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DropoffInformatin.Location = new System.Drawing.Point(6, 5);
            this.lbl_DropoffInformatin.Name = "lbl_DropoffInformatin";
            this.lbl_DropoffInformatin.Size = new System.Drawing.Size(236, 26);
            this.lbl_DropoffInformatin.TabIndex = 48;
            this.lbl_DropoffInformatin.Text = "DROPOFF INFORMATION:";
            // 
            // txtbox_DeliveryAddress
            // 
            this.txtbox_DeliveryAddress.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_DeliveryAddress.Enabled = false;
            this.txtbox_DeliveryAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_DeliveryAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_DeliveryAddress.Location = new System.Drawing.Point(127, 66);
            this.txtbox_DeliveryAddress.Name = "txtbox_DeliveryAddress";
            this.txtbox_DeliveryAddress.Size = new System.Drawing.Size(131, 27);
            this.txtbox_DeliveryAddress.TabIndex = 49;
            // 
            // lbl_DeliveryAddress
            // 
            this.lbl_DeliveryAddress.AutoSize = true;
            this.lbl_DeliveryAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeliveryAddress.Location = new System.Drawing.Point(3, 69);
            this.lbl_DeliveryAddress.Name = "lbl_DeliveryAddress";
            this.lbl_DeliveryAddress.Size = new System.Drawing.Size(122, 19);
            this.lbl_DeliveryAddress.TabIndex = 51;
            this.lbl_DeliveryAddress.Text = "Delivery Address:";
            // 
            // lbl_DeliveryDate
            // 
            this.lbl_DeliveryDate.AutoSize = true;
            this.lbl_DeliveryDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeliveryDate.Location = new System.Drawing.Point(19, 383);
            this.lbl_DeliveryDate.Name = "lbl_DeliveryDate";
            this.lbl_DeliveryDate.Size = new System.Drawing.Size(101, 19);
            this.lbl_DeliveryDate.TabIndex = 35;
            this.lbl_DeliveryDate.Text = "Delivery Date:";
            // 
            // lbl_PickupDate
            // 
            this.lbl_PickupDate.AutoSize = true;
            this.lbl_PickupDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupDate.Location = new System.Drawing.Point(20, 344);
            this.lbl_PickupDate.Name = "lbl_PickupDate";
            this.lbl_PickupDate.Size = new System.Drawing.Size(90, 19);
            this.lbl_PickupDate.TabIndex = 34;
            this.lbl_PickupDate.Text = "Pickup Date:";
            // 
            // lbl_BookDate
            // 
            this.lbl_BookDate.AutoSize = true;
            this.lbl_BookDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookDate.Location = new System.Drawing.Point(20, 304);
            this.lbl_BookDate.Name = "lbl_BookDate";
            this.lbl_BookDate.Size = new System.Drawing.Size(100, 19);
            this.lbl_BookDate.TabIndex = 33;
            this.lbl_BookDate.Text = "Booking Date:";
            // 
            // DropOffDatePicker
            // 
            this.DropOffDatePicker.Enabled = false;
            this.DropOffDatePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropOffDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DropOffDatePicker.Location = new System.Drawing.Point(126, 377);
            this.DropOffDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DropOffDatePicker.MinDate = new System.DateTime(2019, 11, 24, 0, 0, 0, 0);
            this.DropOffDatePicker.Name = "DropOffDatePicker";
            this.DropOffDatePicker.Size = new System.Drawing.Size(238, 27);
            this.DropOffDatePicker.TabIndex = 12;
            this.DropOffDatePicker.Value = new System.DateTime(2019, 11, 26, 0, 0, 0, 0);
            // 
            // PickUpDatePicker
            // 
            this.PickUpDatePicker.Enabled = false;
            this.PickUpDatePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PickUpDatePicker.Location = new System.Drawing.Point(126, 338);
            this.PickUpDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.PickUpDatePicker.MinDate = new System.DateTime(2019, 11, 24, 0, 0, 0, 0);
            this.PickUpDatePicker.Name = "PickUpDatePicker";
            this.PickUpDatePicker.Size = new System.Drawing.Size(238, 27);
            this.PickUpDatePicker.TabIndex = 11;
            this.PickUpDatePicker.Value = new System.DateTime(2019, 11, 26, 0, 0, 0, 0);
            // 
            // BookDatePicker
            // 
            this.BookDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "BOOK_DATE", true));
            this.BookDatePicker.Enabled = false;
            this.BookDatePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookDatePicker.Location = new System.Drawing.Point(126, 298);
            this.BookDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.BookDatePicker.MinDate = new System.DateTime(2019, 11, 24, 0, 0, 0, 0);
            this.BookDatePicker.Name = "BookDatePicker";
            this.BookDatePicker.Size = new System.Drawing.Size(238, 27);
            this.BookDatePicker.TabIndex = 10;
            // 
            // btn_SaveOrder
            // 
            this.btn_SaveOrder.Enabled = false;
            this.btn_SaveOrder.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveOrder.Location = new System.Drawing.Point(222, 429);
            this.btn_SaveOrder.Name = "btn_SaveOrder";
            this.btn_SaveOrder.Size = new System.Drawing.Size(149, 93);
            this.btn_SaveOrder.TabIndex = 17;
            this.btn_SaveOrder.Text = "Save Order";
            this.btn_SaveOrder.UseVisualStyleBackColor = true;
            this.btn_SaveOrder.Click += new System.EventHandler(this.btn_SaveOrder_Click);
            // 
            // btn_CreateOrder
            // 
            this.btn_CreateOrder.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateOrder.Location = new System.Drawing.Point(35, 429);
            this.btn_CreateOrder.Name = "btn_CreateOrder";
            this.btn_CreateOrder.Size = new System.Drawing.Size(149, 93);
            this.btn_CreateOrder.TabIndex = 18;
            this.btn_CreateOrder.Text = "Create Order";
            this.btn_CreateOrder.UseVisualStyleBackColor = true;
            this.btn_CreateOrder.Click += new System.EventHandler(this.btn_CreateOrder_Click);
            // 
            // lbl_SpecialInstructions
            // 
            this.lbl_SpecialInstructions.AutoSize = true;
            this.lbl_SpecialInstructions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SpecialInstructions.Location = new System.Drawing.Point(570, 306);
            this.lbl_SpecialInstructions.Name = "lbl_SpecialInstructions";
            this.lbl_SpecialInstructions.Size = new System.Drawing.Size(145, 19);
            this.lbl_SpecialInstructions.TabIndex = 24;
            this.lbl_SpecialInstructions.Text = "Special Instructions:";
            // 
            // txtboxrch_SpecialInstructions
            // 
            this.txtboxrch_SpecialInstructions.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxrch_SpecialInstructions.Enabled = false;
            this.txtboxrch_SpecialInstructions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxrch_SpecialInstructions.ForeColor = System.Drawing.SystemColors.Window;
            this.txtboxrch_SpecialInstructions.Location = new System.Drawing.Point(571, 328);
            this.txtboxrch_SpecialInstructions.Name = "txtboxrch_SpecialInstructions";
            this.txtboxrch_SpecialInstructions.Size = new System.Drawing.Size(527, 194);
            this.txtboxrch_SpecialInstructions.TabIndex = 16;
            this.txtboxrch_SpecialInstructions.Text = "";
            // 
            // txtbox_OrderNum
            // 
            this.txtbox_OrderNum.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_OrderNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "ORDER_NUM", true));
            this.txtbox_OrderNum.Enabled = false;
            this.txtbox_OrderNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_OrderNum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_OrderNum.Location = new System.Drawing.Point(951, 42);
            this.txtbox_OrderNum.Name = "txtbox_OrderNum";
            this.txtbox_OrderNum.Size = new System.Drawing.Size(140, 27);
            this.txtbox_OrderNum.TabIndex = 16;
            this.txtbox_OrderNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_Company
            // 
            this.txtbox_Company.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Company.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_COMPANY", true));
            this.txtbox_Company.Enabled = false;
            this.txtbox_Company.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Company.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_Company.Location = new System.Drawing.Point(297, 6);
            this.txtbox_Company.Name = "txtbox_Company";
            this.txtbox_Company.Size = new System.Drawing.Size(130, 27);
            this.txtbox_Company.TabIndex = 1;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.appData;
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.txtbox_Email.Enabled = false;
            this.txtbox_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Email.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_Email.Location = new System.Drawing.Point(697, 6);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(161, 27);
            this.txtbox_Email.TabIndex = 3;
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.txtbox_Phone.Enabled = false;
            this.txtbox_Phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Phone.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_Phone.Location = new System.Drawing.Point(503, 6);
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(124, 27);
            this.txtbox_Phone.TabIndex = 2;
            // 
            // txtbox_Zip
            // 
            this.txtbox_Zip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Zip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.txtbox_Zip.Enabled = false;
            this.txtbox_Zip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Zip.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_Zip.Location = new System.Drawing.Point(681, 42);
            this.txtbox_Zip.Name = "txtbox_Zip";
            this.txtbox_Zip.Size = new System.Drawing.Size(177, 27);
            this.txtbox_Zip.TabIndex = 7;
            // 
            // txtbox_State
            // 
            this.txtbox_State.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_State.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.txtbox_State.Enabled = false;
            this.txtbox_State.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_State.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_State.Location = new System.Drawing.Point(491, 42);
            this.txtbox_State.Name = "txtbox_State";
            this.txtbox_State.Size = new System.Drawing.Size(136, 27);
            this.txtbox_State.TabIndex = 6;
            // 
            // txtbox_City
            // 
            this.txtbox_City.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_City.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.txtbox_City.Enabled = false;
            this.txtbox_City.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_City.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_City.Location = new System.Drawing.Point(266, 42);
            this.txtbox_City.Name = "txtbox_City";
            this.txtbox_City.Size = new System.Drawing.Size(170, 27);
            this.txtbox_City.TabIndex = 5;
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ADDRESS", true));
            this.txtbox_Address.Enabled = false;
            this.txtbox_Address.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Address.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_Address.Location = new System.Drawing.Point(78, 42);
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(133, 27);
            this.txtbox_Address.TabIndex = 4;
            this.txtbox_Address.TextChanged += new System.EventHandler(this.txtbox_Address_TextChanged);
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order.Location = new System.Drawing.Point(871, 45);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(65, 19);
            this.lbl_Order.TabIndex = 17;
            this.lbl_Order.Text = "Order #:";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(216, 9);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(77, 19);
            this.lbl_Company.TabIndex = 15;
            this.lbl_Company.Text = "Company:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(641, 9);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(50, 19);
            this.lbl_Email.TabIndex = 13;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(440, 9);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(57, 19);
            this.lbl_Phone.TabIndex = 11;
            this.lbl_Phone.Text = "Phone:";
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zip.Location = new System.Drawing.Point(641, 45);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(34, 19);
            this.lbl_Zip.TabIndex = 9;
            this.lbl_Zip.Text = "Zip:";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.Location = new System.Drawing.Point(440, 45);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(49, 19);
            this.lbl_State.TabIndex = 7;
            this.lbl_State.Text = "State:";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(216, 45);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(39, 19);
            this.lbl_City.TabIndex = 5;
            this.lbl_City.Text = "City:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(9, 45);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(67, 19);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer:";
            // 
            // combobox_CustomerIDZ
            // 
            this.combobox_CustomerIDZ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_CustomerIDZ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_CustomerIDZ.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.combobox_CustomerIDZ.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cUSTOMERBindingSource, "CUST_ID", true));
            this.combobox_CustomerIDZ.DataSource = this.cUSTOMERBindingSource;
            this.combobox_CustomerIDZ.DisplayMember = "CUST_LNAME";
            this.combobox_CustomerIDZ.Enabled = false;
            this.combobox_CustomerIDZ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_CustomerIDZ.ForeColor = System.Drawing.SystemColors.Window;
            this.combobox_CustomerIDZ.FormattingEnabled = true;
            this.combobox_CustomerIDZ.Location = new System.Drawing.Point(90, 6);
            this.combobox_CustomerIDZ.Name = "combobox_CustomerIDZ";
            this.combobox_CustomerIDZ.Size = new System.Drawing.Size(121, 27);
            this.combobox_CustomerIDZ.TabIndex = 0;
            this.combobox_CustomerIDZ.ValueMember = "CUST_ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox_CopyPickupInformation);
            this.panel2.Controls.Add(this.txtbox_PickupAddress);
            this.panel2.Controls.Add(this.txtbox_PickupCity);
            this.panel2.Controls.Add(this.txtbox_PickupState);
            this.panel2.Controls.Add(this.txtbox_PickupZip);
            this.panel2.Controls.Add(this.lbl_PickupZip);
            this.panel2.Controls.Add(this.lbl_PickupState);
            this.panel2.Controls.Add(this.lbl_PickupCity);
            this.panel2.Controls.Add(this.lbl_PickupAddress);
            this.panel2.Controls.Add(this.lbl_PickupInfo);
            this.panel2.Location = new System.Drawing.Point(13, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 203);
            this.panel2.TabIndex = 47;
            // 
            // checkBox_CopyPickupInformation
            // 
            this.checkBox_CopyPickupInformation.AutoSize = true;
            this.checkBox_CopyPickupInformation.Enabled = false;
            this.checkBox_CopyPickupInformation.Location = new System.Drawing.Point(10, 37);
            this.checkBox_CopyPickupInformation.Name = "checkBox_CopyPickupInformation";
            this.checkBox_CopyPickupInformation.Size = new System.Drawing.Size(137, 19);
            this.checkBox_CopyPickupInformation.TabIndex = 8;
            this.checkBox_CopyPickupInformation.Text = "Copy Customer Data";
            this.checkBox_CopyPickupInformation.UseVisualStyleBackColor = true;
            this.checkBox_CopyPickupInformation.CheckedChanged += new System.EventHandler(this.checkBox_CopyPickupInformation_CheckedChanged);
            // 
            // txtbox_PickupAddress
            // 
            this.txtbox_PickupAddress.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_PickupAddress.Enabled = false;
            this.txtbox_PickupAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PickupAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_PickupAddress.Location = new System.Drawing.Point(117, 61);
            this.txtbox_PickupAddress.Name = "txtbox_PickupAddress";
            this.txtbox_PickupAddress.Size = new System.Drawing.Size(141, 27);
            this.txtbox_PickupAddress.TabIndex = 38;
            // 
            // txtbox_PickupCity
            // 
            this.txtbox_PickupCity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_PickupCity.Enabled = false;
            this.txtbox_PickupCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PickupCity.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_PickupCity.Location = new System.Drawing.Point(117, 94);
            this.txtbox_PickupCity.Name = "txtbox_PickupCity";
            this.txtbox_PickupCity.Size = new System.Drawing.Size(141, 27);
            this.txtbox_PickupCity.TabIndex = 41;
            // 
            // txtbox_PickupState
            // 
            this.txtbox_PickupState.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_PickupState.Enabled = false;
            this.txtbox_PickupState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PickupState.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_PickupState.Location = new System.Drawing.Point(117, 128);
            this.txtbox_PickupState.Name = "txtbox_PickupState";
            this.txtbox_PickupState.Size = new System.Drawing.Size(141, 27);
            this.txtbox_PickupState.TabIndex = 43;
            // 
            // txtbox_PickupZip
            // 
            this.txtbox_PickupZip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbox_PickupZip.Enabled = false;
            this.txtbox_PickupZip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PickupZip.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbox_PickupZip.Location = new System.Drawing.Point(117, 161);
            this.txtbox_PickupZip.Name = "txtbox_PickupZip";
            this.txtbox_PickupZip.Size = new System.Drawing.Size(141, 27);
            this.txtbox_PickupZip.TabIndex = 45;
            // 
            // lbl_PickupZip
            // 
            this.lbl_PickupZip.AutoSize = true;
            this.lbl_PickupZip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupZip.Location = new System.Drawing.Point(9, 164);
            this.lbl_PickupZip.Name = "lbl_PickupZip";
            this.lbl_PickupZip.Size = new System.Drawing.Size(79, 19);
            this.lbl_PickupZip.TabIndex = 46;
            this.lbl_PickupZip.Text = "Pickup Zip:";
            // 
            // lbl_PickupState
            // 
            this.lbl_PickupState.AutoSize = true;
            this.lbl_PickupState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupState.Location = new System.Drawing.Point(9, 130);
            this.lbl_PickupState.Name = "lbl_PickupState";
            this.lbl_PickupState.Size = new System.Drawing.Size(92, 19);
            this.lbl_PickupState.TabIndex = 44;
            this.lbl_PickupState.Text = "Pickup State:";
            // 
            // lbl_PickupCity
            // 
            this.lbl_PickupCity.AutoSize = true;
            this.lbl_PickupCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupCity.Location = new System.Drawing.Point(9, 98);
            this.lbl_PickupCity.Name = "lbl_PickupCity";
            this.lbl_PickupCity.Size = new System.Drawing.Size(84, 19);
            this.lbl_PickupCity.TabIndex = 42;
            this.lbl_PickupCity.Text = "Pickup City:";
            // 
            // lbl_PickupAddress
            // 
            this.lbl_PickupAddress.AutoSize = true;
            this.lbl_PickupAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupAddress.Location = new System.Drawing.Point(7, 64);
            this.lbl_PickupAddress.Name = "lbl_PickupAddress";
            this.lbl_PickupAddress.Size = new System.Drawing.Size(111, 19);
            this.lbl_PickupAddress.TabIndex = 40;
            this.lbl_PickupAddress.Text = "Pickup Address:";
            // 
            // lbl_PickupInfo
            // 
            this.lbl_PickupInfo.AutoSize = true;
            this.lbl_PickupInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupInfo.Location = new System.Drawing.Point(6, 5);
            this.lbl_PickupInfo.Name = "lbl_PickupInfo";
            this.lbl_PickupInfo.Size = new System.Drawing.Size(216, 26);
            this.lbl_PickupInfo.TabIndex = 37;
            this.lbl_PickupInfo.Text = "PICKUP INFORMATION:";
            // 
            // tab_ManageCustomers
            // 
            this.tab_ManageCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_ManageCustomers.Controls.Add(this.SearchBox);
            this.tab_ManageCustomers.Controls.Add(this.panel1);
            this.tab_ManageCustomers.Controls.Add(this.dataGridView1);
            this.tab_ManageCustomers.Controls.Add(this.label1);
            this.tab_ManageCustomers.Controls.Add(this.btnEdit);
            this.tab_ManageCustomers.Controls.Add(this.btnNew);
            this.tab_ManageCustomers.Controls.Add(this.btnSave);
            this.tab_ManageCustomers.Controls.Add(this.btnCancel);
            this.tab_ManageCustomers.Location = new System.Drawing.Point(4, 28);
            this.tab_ManageCustomers.Name = "tab_ManageCustomers";
            this.tab_ManageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ManageCustomers.Size = new System.Drawing.Size(1107, 546);
            this.tab_ManageCustomers.TabIndex = 1;
            this.tab_ManageCustomers.Text = "Manage Customers";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchBox.Location = new System.Drawing.Point(346, 7);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(279, 27);
            this.SearchBox.TabIndex = 18;
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_Broker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_RequiredField);
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
            this.panel1.Controls.Add(this.FirstNameLabel);
            this.panel1.Controls.Add(this.FirstNameBox);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.EmailBox);
            this.panel1.Controls.Add(this.PhoneLabel);
            this.panel1.Controls.Add(this.PhoneNumberBox);
            this.panel1.Controls.Add(this.LastNameLabel);
            this.panel1.Controls.Add(this.LastNameBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 328);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_Broker
            // 
            this.comboBox_Broker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cUSTOMERBindingSource, "BROKER", true));
            this.comboBox_Broker.FormattingEnabled = true;
            this.comboBox_Broker.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBox_Broker.Location = new System.Drawing.Point(137, 268);
            this.comboBox_Broker.Name = "comboBox_Broker";
            this.comboBox_Broker.Size = new System.Drawing.Size(121, 27);
            this.comboBox_Broker.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(13, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Is this a Broker?";
            // 
            // lbl_RequiredField
            // 
            this.lbl_RequiredField.AutoSize = true;
            this.lbl_RequiredField.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RequiredField.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_RequiredField.Location = new System.Drawing.Point(13, 296);
            this.lbl_RequiredField.Name = "lbl_RequiredField";
            this.lbl_RequiredField.Size = new System.Drawing.Size(216, 19);
            this.lbl_RequiredField.TabIndex = 20;
            this.lbl_RequiredField.Text = "*Please fill in the required fields";
            this.lbl_RequiredField.Visible = false;
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipLabel.ForeColor = System.Drawing.Color.LightGray;
            this.ZipLabel.Location = new System.Drawing.Point(13, 236);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(68, 19);
            this.ZipLabel.TabIndex = 19;
            this.ZipLabel.Text = "Zip Code";
            // 
            // ZipBox
            // 
            this.ZipBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ZipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZipBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.ZipBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ZipBox.Location = new System.Drawing.Point(101, 233);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(163, 27);
            this.ZipBox.TabIndex = 18;
            this.ZipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipBox_KeyPress);
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.ForeColor = System.Drawing.Color.LightGray;
            this.CompanyLabel.Location = new System.Drawing.Point(13, 124);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(73, 19);
            this.CompanyLabel.TabIndex = 17;
            this.CompanyLabel.Text = "Company";
            // 
            // CompanyBox
            // 
            this.CompanyBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CompanyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_COMPANY", true));
            this.CompanyBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CompanyBox.Location = new System.Drawing.Point(101, 121);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(163, 27);
            this.CompanyBox.TabIndex = 10;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.ForeColor = System.Drawing.Color.LightGray;
            this.StateLabel.Location = new System.Drawing.Point(13, 208);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(45, 19);
            this.StateLabel.TabIndex = 16;
            this.StateLabel.Text = "State";
            // 
            // StateBox
            // 
            this.StateBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.StateBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateBox.ForeColor = System.Drawing.SystemColors.Window;
            this.StateBox.Location = new System.Drawing.Point(101, 205);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(163, 27);
            this.StateBox.TabIndex = 13;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.Color.LightGray;
            this.CityLabel.Location = new System.Drawing.Point(13, 180);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 19);
            this.CityLabel.TabIndex = 15;
            this.CityLabel.Text = "City";
            // 
            // CityBox
            // 
            this.CityBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CityBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.CityBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CityBox.Location = new System.Drawing.Point(101, 177);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(163, 27);
            this.CityBox.TabIndex = 12;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.LightGray;
            this.AddressLabel.Location = new System.Drawing.Point(13, 152);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(63, 19);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Address";
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ADDRESS", true));
            this.AddressBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.ForeColor = System.Drawing.SystemColors.Window;
            this.AddressBox.Location = new System.Drawing.Point(101, 149);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(163, 27);
            this.AddressBox.TabIndex = 11;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 12);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(82, 19);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_FNAME", true));
            this.FirstNameBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.FirstNameBox.Location = new System.Drawing.Point(101, 9);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(163, 27);
            this.FirstNameBox.TabIndex = 1;
            this.FirstNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.LightGray;
            this.EmailLabel.Location = new System.Drawing.Point(13, 96);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 19);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.EmailBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailBox.Location = new System.Drawing.Point(101, 93);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(163, 27);
            this.EmailBox.TabIndex = 3;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.LightGray;
            this.PhoneLabel.Location = new System.Drawing.Point(13, 68);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(65, 19);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Phone #";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PhoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.PhoneNumberBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PhoneNumberBox.Location = new System.Drawing.Point(101, 65);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(163, 27);
            this.PhoneNumberBox.TabIndex = 2;
            this.PhoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberBox_KeyPress);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.LastNameLabel.Location = new System.Drawing.Point(13, 40);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(80, 19);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameBox
            // 
            this.LastNameBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_LNAME", true));
            this.LastNameBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LastNameBox.Location = new System.Drawing.Point(101, 37);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(163, 27);
            this.LastNameBox.TabIndex = 1;
            this.LastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameBox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTIDDataGridViewTextBoxColumn,
            this.BROKER,
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
            this.dataGridView1.Location = new System.Drawing.Point(284, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(820, 496);
            this.dataGridView1.TabIndex = 3;
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            this.cUSTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTIDDataGridViewTextBoxColumn.Width = 48;
            // 
            // BROKER
            // 
            this.BROKER.DataPropertyName = "BROKER";
            this.BROKER.HeaderText = "BROKER";
            this.BROKER.Name = "BROKER";
            this.BROKER.ReadOnly = true;
            // 
            // cUSTFNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTFNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTFNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUST_FNAME";
            this.cUSTFNAMEDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.cUSTFNAMEDataGridViewTextBoxColumn.Name = "cUSTFNAMEDataGridViewTextBoxColumn";
            this.cUSTFNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTFNAMEDataGridViewTextBoxColumn.Width = 104;
            // 
            // cUSTLNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTLNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUST_LNAME";
            this.cUSTLNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.cUSTLNAMEDataGridViewTextBoxColumn.Name = "cUSTLNAMEDataGridViewTextBoxColumn";
            this.cUSTLNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTLNAMEDataGridViewTextBoxColumn.Width = 103;
            // 
            // cUSTEMAILDataGridViewTextBoxColumn
            // 
            this.cUSTEMAILDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTEMAILDataGridViewTextBoxColumn.DataPropertyName = "CUST_EMAIL";
            this.cUSTEMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.cUSTEMAILDataGridViewTextBoxColumn.Name = "cUSTEMAILDataGridViewTextBoxColumn";
            this.cUSTEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTEMAILDataGridViewTextBoxColumn.Width = 70;
            // 
            // cUSTPHONEDataGridViewTextBoxColumn
            // 
            this.cUSTPHONEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUST_PHONE";
            this.cUSTPHONEDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cUSTPHONEDataGridViewTextBoxColumn.Name = "cUSTPHONEDataGridViewTextBoxColumn";
            this.cUSTPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTPHONEDataGridViewTextBoxColumn.Width = 74;
            // 
            // cUSTCOMPANYDataGridViewTextBoxColumn
            // 
            this.cUSTCOMPANYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTCOMPANYDataGridViewTextBoxColumn.DataPropertyName = "CUST_COMPANY";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.HeaderText = "Company";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.Name = "cUSTCOMPANYDataGridViewTextBoxColumn";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTCOMPANYDataGridViewTextBoxColumn.Width = 94;
            // 
            // cUSTADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSTADDRESSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUST_ADDRESS";
            this.cUSTADDRESSDataGridViewTextBoxColumn.HeaderText = "Address";
            this.cUSTADDRESSDataGridViewTextBoxColumn.Name = "cUSTADDRESSDataGridViewTextBoxColumn";
            this.cUSTADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTADDRESSDataGridViewTextBoxColumn.Width = 86;
            // 
            // cUSTCITYDataGridViewTextBoxColumn
            // 
            this.cUSTCITYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTCITYDataGridViewTextBoxColumn.DataPropertyName = "CUST_CITY";
            this.cUSTCITYDataGridViewTextBoxColumn.HeaderText = "City";
            this.cUSTCITYDataGridViewTextBoxColumn.Name = "cUSTCITYDataGridViewTextBoxColumn";
            this.cUSTCITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTCITYDataGridViewTextBoxColumn.Width = 59;
            // 
            // cUSTSTATEDataGridViewTextBoxColumn
            // 
            this.cUSTSTATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTSTATEDataGridViewTextBoxColumn.DataPropertyName = "CUST_STATE";
            this.cUSTSTATEDataGridViewTextBoxColumn.HeaderText = "State";
            this.cUSTSTATEDataGridViewTextBoxColumn.Name = "cUSTSTATEDataGridViewTextBoxColumn";
            this.cUSTSTATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTSTATEDataGridViewTextBoxColumn.Width = 67;
            // 
            // cUSTZIPDataGridViewTextBoxColumn
            // 
            this.cUSTZIPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSTZIPDataGridViewTextBoxColumn.DataPropertyName = "CUST_ZIP";
            this.cUSTZIPDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.cUSTZIPDataGridViewTextBoxColumn.Name = "cUSTZIPDataGridViewTextBoxColumn";
            this.cUSTZIPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSTZIPDataGridViewTextBoxColumn.Width = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(284, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 5;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(45, 388);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(184, 46);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit Customer";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew.FlatAppearance.BorderSize = 5;
            this.btnNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(45, 335);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(184, 46);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Add New Customer";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 5;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(45, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 46);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 5;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(45, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 44);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tab_Help
            // 
            this.tab_Help.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_Help.BackgroundImage")));
            this.tab_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tab_Help.Location = new System.Drawing.Point(4, 28);
            this.tab_Help.Name = "tab_Help";
            this.tab_Help.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Help.Size = new System.Drawing.Size(1107, 546);
            this.tab_Help.TabIndex = 4;
            this.tab_Help.Text = "Help";
            // 
            // tab_SearchOrders
            // 
            this.tab_SearchOrders.Controls.Add(this.comboBox_VehicleEdit);
            this.tab_SearchOrders.Controls.Add(this.label4);
            this.tab_SearchOrders.Controls.Add(this.txtbox_OrderNumberEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_OrderNumberEdit);
            this.tab_SearchOrders.Controls.Add(this.combobox_OrderStatusEdit);
            this.tab_SearchOrders.Controls.Add(this.btn_SaveOrderEdit);
            this.tab_SearchOrders.Controls.Add(this.btn_EditOrder);
            this.tab_SearchOrders.Controls.Add(this.dateTimePicker_DeliveryDateEdit);
            this.tab_SearchOrders.Controls.Add(this.dateTimePicker_PickUpDateEdit);
            this.tab_SearchOrders.Controls.Add(this.dateTimePicker_BookingDateEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_SpecialInstructionsEdit);
            this.tab_SearchOrders.Controls.Add(this.txtboxrch_SpecailInstructionsEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_DescriptionEdit);
            this.tab_SearchOrders.Controls.Add(this.txtboxrch_DescriptionEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_DeliveryZipEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_DeliveryZipEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_DeliveryStateEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_DeliveryStateEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_DeliveryCityEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_DeliveryCityEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_DeliveryAddressEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_DeliveryAddressEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_PickUpZipEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_PickUpZipEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_PickupStateEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_PickUpStateEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_PickupCityEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_PickUpCityEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_PickupAddressEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_PickupAddressEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_OrderStatusEdit);
            this.tab_SearchOrders.Controls.Add(this.txtboxCustomerIdEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_CustomerIdEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_DeliveryDateEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_BookingDateEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_PickupDateEdit);
            this.tab_SearchOrders.Controls.Add(this.txtbox_InvoiceIdEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_InvoiceIdEdit);
            this.tab_SearchOrders.Controls.Add(this.lbl_OrderSearch);
            this.tab_SearchOrders.Controls.Add(this.txtbox_OrderSearchBox);
            this.tab_SearchOrders.Controls.Add(this.dataGridView2);
            this.tab_SearchOrders.Location = new System.Drawing.Point(4, 28);
            this.tab_SearchOrders.Name = "tab_SearchOrders";
            this.tab_SearchOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SearchOrders.Size = new System.Drawing.Size(1107, 546);
            this.tab_SearchOrders.TabIndex = 3;
            this.tab_SearchOrders.Text = "Search Orders";
            this.tab_SearchOrders.UseVisualStyleBackColor = true;
            // 
            // comboBox_VehicleEdit
            // 
            this.comboBox_VehicleEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox_VehicleEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "VEHICLE", true));
            this.comboBox_VehicleEdit.Enabled = false;
            this.comboBox_VehicleEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_VehicleEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_VehicleEdit.FormattingEnabled = true;
            this.comboBox_VehicleEdit.Items.AddRange(new object[] {
            "Vehicle 1",
            "Vehicle 2",
            "Vehicle 3"});
            this.comboBox_VehicleEdit.Location = new System.Drawing.Point(172, 221);
            this.comboBox_VehicleEdit.Name = "comboBox_VehicleEdit";
            this.comboBox_VehicleEdit.Size = new System.Drawing.Size(173, 27);
            this.comboBox_VehicleEdit.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "Vehicle Used:";
            // 
            // txtbox_OrderNumberEdit
            // 
            this.txtbox_OrderNumberEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "ORDER_NUM", true));
            this.txtbox_OrderNumberEdit.Enabled = false;
            this.txtbox_OrderNumberEdit.Location = new System.Drawing.Point(859, 221);
            this.txtbox_OrderNumberEdit.Name = "txtbox_OrderNumberEdit";
            this.txtbox_OrderNumberEdit.Size = new System.Drawing.Size(154, 27);
            this.txtbox_OrderNumberEdit.TabIndex = 42;
            // 
            // lbl_OrderNumberEdit
            // 
            this.lbl_OrderNumberEdit.AutoSize = true;
            this.lbl_OrderNumberEdit.Location = new System.Drawing.Point(781, 220);
            this.lbl_OrderNumberEdit.Name = "lbl_OrderNumberEdit";
            this.lbl_OrderNumberEdit.Size = new System.Drawing.Size(62, 19);
            this.lbl_OrderNumberEdit.TabIndex = 41;
            this.lbl_OrderNumberEdit.Text = "Order #:";
            // 
            // combobox_OrderStatusEdit
            // 
            this.combobox_OrderStatusEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "ORDER_STATUS", true));
            this.combobox_OrderStatusEdit.Enabled = false;
            this.combobox_OrderStatusEdit.FormattingEnabled = true;
            this.combobox_OrderStatusEdit.Items.AddRange(new object[] {
            "Pending",
            "In Transit",
            "Delayed",
            "Complete",
            "Cancelled"});
            this.combobox_OrderStatusEdit.Location = new System.Drawing.Point(124, 193);
            this.combobox_OrderStatusEdit.Name = "combobox_OrderStatusEdit";
            this.combobox_OrderStatusEdit.Size = new System.Drawing.Size(121, 27);
            this.combobox_OrderStatusEdit.TabIndex = 40;
            // 
            // btn_SaveOrderEdit
            // 
            this.btn_SaveOrderEdit.Enabled = false;
            this.btn_SaveOrderEdit.Location = new System.Drawing.Point(198, 275);
            this.btn_SaveOrderEdit.Name = "btn_SaveOrderEdit";
            this.btn_SaveOrderEdit.Size = new System.Drawing.Size(147, 61);
            this.btn_SaveOrderEdit.TabIndex = 39;
            this.btn_SaveOrderEdit.Text = "Save Order";
            this.btn_SaveOrderEdit.UseVisualStyleBackColor = true;
            this.btn_SaveOrderEdit.Click += new System.EventHandler(this.btn_SaveOrderEdit_Click);
            // 
            // btn_EditOrder
            // 
            this.btn_EditOrder.Location = new System.Drawing.Point(45, 275);
            this.btn_EditOrder.Name = "btn_EditOrder";
            this.btn_EditOrder.Size = new System.Drawing.Size(147, 61);
            this.btn_EditOrder.TabIndex = 38;
            this.btn_EditOrder.Text = "Edit Order";
            this.btn_EditOrder.UseVisualStyleBackColor = true;
            this.btn_EditOrder.Click += new System.EventHandler(this.btn_EditOrder_Click);
            // 
            // dateTimePicker_DeliveryDateEdit
            // 
            this.dateTimePicker_DeliveryDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "DROPOFF_DATE", true));
            this.dateTimePicker_DeliveryDateEdit.Enabled = false;
            this.dateTimePicker_DeliveryDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DeliveryDateEdit.Location = new System.Drawing.Point(124, 129);
            this.dateTimePicker_DeliveryDateEdit.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_DeliveryDateEdit.MinDate = new System.DateTime(2019, 11, 24, 0, 0, 0, 0);
            this.dateTimePicker_DeliveryDateEdit.Name = "dateTimePicker_DeliveryDateEdit";
            this.dateTimePicker_DeliveryDateEdit.Size = new System.Drawing.Size(221, 27);
            this.dateTimePicker_DeliveryDateEdit.TabIndex = 37;
            // 
            // dateTimePicker_PickUpDateEdit
            // 
            this.dateTimePicker_PickUpDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "PICKUP_DATE", true));
            this.dateTimePicker_PickUpDateEdit.Enabled = false;
            this.dateTimePicker_PickUpDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_PickUpDateEdit.Location = new System.Drawing.Point(124, 96);
            this.dateTimePicker_PickUpDateEdit.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_PickUpDateEdit.MinDate = new System.DateTime(2019, 11, 24, 0, 0, 0, 0);
            this.dateTimePicker_PickUpDateEdit.Name = "dateTimePicker_PickUpDateEdit";
            this.dateTimePicker_PickUpDateEdit.Size = new System.Drawing.Size(221, 27);
            this.dateTimePicker_PickUpDateEdit.TabIndex = 36;
            // 
            // dateTimePicker_BookingDateEdit
            // 
            this.dateTimePicker_BookingDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "BOOK_DATE", true));
            this.dateTimePicker_BookingDateEdit.Enabled = false;
            this.dateTimePicker_BookingDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_BookingDateEdit.Location = new System.Drawing.Point(124, 63);
            this.dateTimePicker_BookingDateEdit.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_BookingDateEdit.MinDate = new System.DateTime(2019, 11, 24, 0, 0, 0, 0);
            this.dateTimePicker_BookingDateEdit.Name = "dateTimePicker_BookingDateEdit";
            this.dateTimePicker_BookingDateEdit.Size = new System.Drawing.Size(221, 27);
            this.dateTimePicker_BookingDateEdit.TabIndex = 35;
            // 
            // lbl_SpecialInstructionsEdit
            // 
            this.lbl_SpecialInstructionsEdit.AutoSize = true;
            this.lbl_SpecialInstructionsEdit.Location = new System.Drawing.Point(704, 296);
            this.lbl_SpecialInstructionsEdit.Name = "lbl_SpecialInstructionsEdit";
            this.lbl_SpecialInstructionsEdit.Size = new System.Drawing.Size(139, 19);
            this.lbl_SpecialInstructionsEdit.TabIndex = 34;
            this.lbl_SpecialInstructionsEdit.Text = "Special Instructions:";
            // 
            // txtboxrch_SpecailInstructionsEdit
            // 
            this.txtboxrch_SpecailInstructionsEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "SPECIAL_INSTRUCTIONS", true));
            this.txtboxrch_SpecailInstructionsEdit.Enabled = false;
            this.txtboxrch_SpecailInstructionsEdit.Location = new System.Drawing.Point(849, 257);
            this.txtboxrch_SpecailInstructionsEdit.Name = "txtboxrch_SpecailInstructionsEdit";
            this.txtboxrch_SpecailInstructionsEdit.Size = new System.Drawing.Size(238, 96);
            this.txtboxrch_SpecailInstructionsEdit.TabIndex = 33;
            this.txtboxrch_SpecailInstructionsEdit.Text = "";
            // 
            // lbl_DescriptionEdit
            // 
            this.lbl_DescriptionEdit.AutoSize = true;
            this.lbl_DescriptionEdit.Location = new System.Drawing.Point(351, 296);
            this.lbl_DescriptionEdit.Name = "lbl_DescriptionEdit";
            this.lbl_DescriptionEdit.Size = new System.Drawing.Size(87, 19);
            this.lbl_DescriptionEdit.TabIndex = 32;
            this.lbl_DescriptionEdit.Text = "Description:";
            // 
            // txtboxrch_DescriptionEdit
            // 
            this.txtboxrch_DescriptionEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "DESCRIPTION", true));
            this.txtboxrch_DescriptionEdit.Enabled = false;
            this.txtboxrch_DescriptionEdit.Location = new System.Drawing.Point(444, 257);
            this.txtboxrch_DescriptionEdit.Name = "txtboxrch_DescriptionEdit";
            this.txtboxrch_DescriptionEdit.Size = new System.Drawing.Size(238, 96);
            this.txtboxrch_DescriptionEdit.TabIndex = 31;
            this.txtboxrch_DescriptionEdit.Text = "";
            // 
            // txtbox_DeliveryZipEdit
            // 
            this.txtbox_DeliveryZipEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "DELIVERY_ZIP", true));
            this.txtbox_DeliveryZipEdit.Enabled = false;
            this.txtbox_DeliveryZipEdit.Location = new System.Drawing.Point(717, 160);
            this.txtbox_DeliveryZipEdit.Name = "txtbox_DeliveryZipEdit";
            this.txtbox_DeliveryZipEdit.Size = new System.Drawing.Size(100, 27);
            this.txtbox_DeliveryZipEdit.TabIndex = 30;
            // 
            // lbl_DeliveryZipEdit
            // 
            this.lbl_DeliveryZipEdit.AutoSize = true;
            this.lbl_DeliveryZipEdit.Location = new System.Drawing.Point(604, 163);
            this.lbl_DeliveryZipEdit.Name = "lbl_DeliveryZipEdit";
            this.lbl_DeliveryZipEdit.Size = new System.Drawing.Size(90, 19);
            this.lbl_DeliveryZipEdit.TabIndex = 29;
            this.lbl_DeliveryZipEdit.Text = "Delivery Zip:";
            // 
            // txtbox_DeliveryStateEdit
            // 
            this.txtbox_DeliveryStateEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "DELIVERY_STATE", true));
            this.txtbox_DeliveryStateEdit.Enabled = false;
            this.txtbox_DeliveryStateEdit.Location = new System.Drawing.Point(717, 127);
            this.txtbox_DeliveryStateEdit.Name = "txtbox_DeliveryStateEdit";
            this.txtbox_DeliveryStateEdit.Size = new System.Drawing.Size(100, 27);
            this.txtbox_DeliveryStateEdit.TabIndex = 28;
            // 
            // lbl_DeliveryStateEdit
            // 
            this.lbl_DeliveryStateEdit.AutoSize = true;
            this.lbl_DeliveryStateEdit.Location = new System.Drawing.Point(604, 130);
            this.lbl_DeliveryStateEdit.Name = "lbl_DeliveryStateEdit";
            this.lbl_DeliveryStateEdit.Size = new System.Drawing.Size(107, 19);
            this.lbl_DeliveryStateEdit.TabIndex = 27;
            this.lbl_DeliveryStateEdit.Text = "Delivery State: ";
            // 
            // txtbox_DeliveryCityEdit
            // 
            this.txtbox_DeliveryCityEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "DELIVERY_CITY", true));
            this.txtbox_DeliveryCityEdit.Enabled = false;
            this.txtbox_DeliveryCityEdit.Location = new System.Drawing.Point(717, 94);
            this.txtbox_DeliveryCityEdit.Name = "txtbox_DeliveryCityEdit";
            this.txtbox_DeliveryCityEdit.Size = new System.Drawing.Size(100, 27);
            this.txtbox_DeliveryCityEdit.TabIndex = 26;
            // 
            // lbl_DeliveryCityEdit
            // 
            this.lbl_DeliveryCityEdit.AutoSize = true;
            this.lbl_DeliveryCityEdit.Location = new System.Drawing.Point(612, 94);
            this.lbl_DeliveryCityEdit.Name = "lbl_DeliveryCityEdit";
            this.lbl_DeliveryCityEdit.Size = new System.Drawing.Size(99, 19);
            this.lbl_DeliveryCityEdit.TabIndex = 25;
            this.lbl_DeliveryCityEdit.Text = "Delivery City: ";
            // 
            // txtbox_DeliveryAddressEdit
            // 
            this.txtbox_DeliveryAddressEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "DELIVERY_ADDRESS", true));
            this.txtbox_DeliveryAddressEdit.Enabled = false;
            this.txtbox_DeliveryAddressEdit.Location = new System.Drawing.Point(717, 61);
            this.txtbox_DeliveryAddressEdit.Name = "txtbox_DeliveryAddressEdit";
            this.txtbox_DeliveryAddressEdit.Size = new System.Drawing.Size(100, 27);
            this.txtbox_DeliveryAddressEdit.TabIndex = 24;
            // 
            // lbl_DeliveryAddressEdit
            // 
            this.lbl_DeliveryAddressEdit.AutoSize = true;
            this.lbl_DeliveryAddressEdit.Location = new System.Drawing.Point(589, 64);
            this.lbl_DeliveryAddressEdit.Name = "lbl_DeliveryAddressEdit";
            this.lbl_DeliveryAddressEdit.Size = new System.Drawing.Size(122, 19);
            this.lbl_DeliveryAddressEdit.TabIndex = 23;
            this.lbl_DeliveryAddressEdit.Text = "Delivery Address:";
            // 
            // txtbox_PickUpZipEdit
            // 
            this.txtbox_PickUpZipEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "PICKUP_ZIP", true));
            this.txtbox_PickUpZipEdit.Enabled = false;
            this.txtbox_PickUpZipEdit.Location = new System.Drawing.Point(483, 163);
            this.txtbox_PickUpZipEdit.Name = "txtbox_PickUpZipEdit";
            this.txtbox_PickUpZipEdit.Size = new System.Drawing.Size(100, 27);
            this.txtbox_PickUpZipEdit.TabIndex = 22;
            // 
            // lbl_PickUpZipEdit
            // 
            this.lbl_PickUpZipEdit.AutoSize = true;
            this.lbl_PickUpZipEdit.Location = new System.Drawing.Point(398, 166);
            this.lbl_PickUpZipEdit.Name = "lbl_PickUpZipEdit";
            this.lbl_PickUpZipEdit.Size = new System.Drawing.Size(79, 19);
            this.lbl_PickUpZipEdit.TabIndex = 21;
            this.lbl_PickUpZipEdit.Text = "Pickup Zip:";
            // 
            // txtbox_PickupStateEdit
            // 
            this.txtbox_PickupStateEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "PICKUP_STATE", true));
            this.txtbox_PickupStateEdit.Enabled = false;
            this.txtbox_PickupStateEdit.Location = new System.Drawing.Point(483, 130);
            this.txtbox_PickupStateEdit.Name = "txtbox_PickupStateEdit";
            this.txtbox_PickupStateEdit.Size = new System.Drawing.Size(100, 27);
            this.txtbox_PickupStateEdit.TabIndex = 20;
            // 
            // lbl_PickUpStateEdit
            // 
            this.lbl_PickUpStateEdit.AutoSize = true;
            this.lbl_PickUpStateEdit.Location = new System.Drawing.Point(385, 133);
            this.lbl_PickUpStateEdit.Name = "lbl_PickUpStateEdit";
            this.lbl_PickUpStateEdit.Size = new System.Drawing.Size(92, 19);
            this.lbl_PickUpStateEdit.TabIndex = 19;
            this.lbl_PickUpStateEdit.Text = "Pickup State:";
            // 
            // txtbox_PickupCityEdit
            // 
            this.txtbox_PickupCityEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "PICKUP_CITY", true));
            this.txtbox_PickupCityEdit.Enabled = false;
            this.txtbox_PickupCityEdit.Location = new System.Drawing.Point(483, 94);
            this.txtbox_PickupCityEdit.Name = "txtbox_PickupCityEdit";
            this.txtbox_PickupCityEdit.Size = new System.Drawing.Size(100, 27);
            this.txtbox_PickupCityEdit.TabIndex = 18;
            // 
            // lbl_PickUpCityEdit
            // 
            this.lbl_PickUpCityEdit.AutoSize = true;
            this.lbl_PickUpCityEdit.Location = new System.Drawing.Point(393, 97);
            this.lbl_PickUpCityEdit.Name = "lbl_PickUpCityEdit";
            this.lbl_PickUpCityEdit.Size = new System.Drawing.Size(84, 19);
            this.lbl_PickUpCityEdit.TabIndex = 17;
            this.lbl_PickUpCityEdit.Text = "Pickup City:";
            // 
            // txtbox_PickupAddressEdit
            // 
            this.txtbox_PickupAddressEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "PICKUP_ADDRESS", true));
            this.txtbox_PickupAddressEdit.Enabled = false;
            this.txtbox_PickupAddressEdit.Location = new System.Drawing.Point(483, 61);
            this.txtbox_PickupAddressEdit.Name = "txtbox_PickupAddressEdit";
            this.txtbox_PickupAddressEdit.Size = new System.Drawing.Size(100, 27);
            this.txtbox_PickupAddressEdit.TabIndex = 16;
            // 
            // lbl_PickupAddressEdit
            // 
            this.lbl_PickupAddressEdit.AutoSize = true;
            this.lbl_PickupAddressEdit.Location = new System.Drawing.Point(366, 64);
            this.lbl_PickupAddressEdit.Name = "lbl_PickupAddressEdit";
            this.lbl_PickupAddressEdit.Size = new System.Drawing.Size(111, 19);
            this.lbl_PickupAddressEdit.TabIndex = 15;
            this.lbl_PickupAddressEdit.Text = "Pickup Address:";
            // 
            // lbl_OrderStatusEdit
            // 
            this.lbl_OrderStatusEdit.AutoSize = true;
            this.lbl_OrderStatusEdit.Location = new System.Drawing.Point(17, 196);
            this.lbl_OrderStatusEdit.Name = "lbl_OrderStatusEdit";
            this.lbl_OrderStatusEdit.Size = new System.Drawing.Size(94, 19);
            this.lbl_OrderStatusEdit.TabIndex = 13;
            this.lbl_OrderStatusEdit.Text = "Order Status:";
            // 
            // txtboxCustomerIdEdit
            // 
            this.txtboxCustomerIdEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "CUST_ID", true));
            this.txtboxCustomerIdEdit.Enabled = false;
            this.txtboxCustomerIdEdit.Location = new System.Drawing.Point(124, 160);
            this.txtboxCustomerIdEdit.Name = "txtboxCustomerIdEdit";
            this.txtboxCustomerIdEdit.Size = new System.Drawing.Size(100, 27);
            this.txtboxCustomerIdEdit.TabIndex = 12;
            // 
            // lbl_CustomerIdEdit
            // 
            this.lbl_CustomerIdEdit.AutoSize = true;
            this.lbl_CustomerIdEdit.Location = new System.Drawing.Point(17, 163);
            this.lbl_CustomerIdEdit.Name = "lbl_CustomerIdEdit";
            this.lbl_CustomerIdEdit.Size = new System.Drawing.Size(93, 19);
            this.lbl_CustomerIdEdit.TabIndex = 11;
            this.lbl_CustomerIdEdit.Text = "Customer ID:";
            // 
            // lbl_DeliveryDateEdit
            // 
            this.lbl_DeliveryDateEdit.AutoSize = true;
            this.lbl_DeliveryDateEdit.Location = new System.Drawing.Point(17, 130);
            this.lbl_DeliveryDateEdit.Name = "lbl_DeliveryDateEdit";
            this.lbl_DeliveryDateEdit.Size = new System.Drawing.Size(101, 19);
            this.lbl_DeliveryDateEdit.TabIndex = 9;
            this.lbl_DeliveryDateEdit.Text = "Delivery Date:";
            // 
            // lbl_BookingDateEdit
            // 
            this.lbl_BookingDateEdit.AutoSize = true;
            this.lbl_BookingDateEdit.Location = new System.Drawing.Point(18, 64);
            this.lbl_BookingDateEdit.Name = "lbl_BookingDateEdit";
            this.lbl_BookingDateEdit.Size = new System.Drawing.Size(100, 19);
            this.lbl_BookingDateEdit.TabIndex = 7;
            this.lbl_BookingDateEdit.Text = "Booking Date:";
            // 
            // lbl_PickupDateEdit
            // 
            this.lbl_PickupDateEdit.AutoSize = true;
            this.lbl_PickupDateEdit.Location = new System.Drawing.Point(28, 97);
            this.lbl_PickupDateEdit.Name = "lbl_PickupDateEdit";
            this.lbl_PickupDateEdit.Size = new System.Drawing.Size(90, 19);
            this.lbl_PickupDateEdit.TabIndex = 5;
            this.lbl_PickupDateEdit.Text = "Pickup Date:";
            // 
            // txtbox_InvoiceIdEdit
            // 
            this.txtbox_InvoiceIdEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "INV_ID", true));
            this.txtbox_InvoiceIdEdit.Enabled = false;
            this.txtbox_InvoiceIdEdit.Location = new System.Drawing.Point(859, 196);
            this.txtbox_InvoiceIdEdit.Name = "txtbox_InvoiceIdEdit";
            this.txtbox_InvoiceIdEdit.Size = new System.Drawing.Size(154, 27);
            this.txtbox_InvoiceIdEdit.TabIndex = 4;
            // 
            // lbl_InvoiceIdEdit
            // 
            this.lbl_InvoiceIdEdit.AutoSize = true;
            this.lbl_InvoiceIdEdit.Location = new System.Drawing.Point(781, 196);
            this.lbl_InvoiceIdEdit.Name = "lbl_InvoiceIdEdit";
            this.lbl_InvoiceIdEdit.Size = new System.Drawing.Size(71, 19);
            this.lbl_InvoiceIdEdit.TabIndex = 3;
            this.lbl_InvoiceIdEdit.Text = "Invoice #:";
            // 
            // lbl_OrderSearch
            // 
            this.lbl_OrderSearch.AutoSize = true;
            this.lbl_OrderSearch.Location = new System.Drawing.Point(62, 33);
            this.lbl_OrderSearch.Name = "lbl_OrderSearch";
            this.lbl_OrderSearch.Size = new System.Drawing.Size(56, 19);
            this.lbl_OrderSearch.TabIndex = 2;
            this.lbl_OrderSearch.Text = "Search:";
            // 
            // txtbox_OrderSearchBox
            // 
            this.txtbox_OrderSearchBox.Location = new System.Drawing.Point(124, 30);
            this.txtbox_OrderSearchBox.Name = "txtbox_OrderSearchBox";
            this.txtbox_OrderSearchBox.Size = new System.Drawing.Size(183, 27);
            this.txtbox_OrderSearchBox.TabIndex = 1;
            this.txtbox_OrderSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderSearchBox_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNVIDDataGridViewTextBoxColumn,
            this.VEHICLE,
            this.ORDER_NUM,
            this.PICKUP_ADDRESS,
            this.PICKUP_CITY,
            this.PICKUP_STATE,
            this.PICKUP_ZIP,
            this.DELIVERY_ADDRESS,
            this.DELIVERY_CITY,
            this.DELIVERY_STATE,
            this.DELIVERY_ZIP,
            this.bOOKDATEDataGridViewTextBoxColumn,
            this.pICKUPDATEDataGridViewTextBoxColumn,
            this.dROPOFFDATEDataGridViewTextBoxColumn,
            this.oRDERSTATUSDataGridViewTextBoxColumn,
            this.cUSTIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.iNVOICEBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 375);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1095, 164);
            this.dataGridView2.TabIndex = 0;
            // 
            // iNVIDDataGridViewTextBoxColumn
            // 
            this.iNVIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iNVIDDataGridViewTextBoxColumn.DataPropertyName = "INV_ID";
            this.iNVIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iNVIDDataGridViewTextBoxColumn.Name = "iNVIDDataGridViewTextBoxColumn";
            this.iNVIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNVIDDataGridViewTextBoxColumn.Width = 48;
            // 
            // VEHICLE
            // 
            this.VEHICLE.DataPropertyName = "VEHICLE";
            this.VEHICLE.HeaderText = "VEHICLE";
            this.VEHICLE.Name = "VEHICLE";
            this.VEHICLE.ReadOnly = true;
            // 
            // ORDER_NUM
            // 
            this.ORDER_NUM.DataPropertyName = "ORDER_NUM";
            this.ORDER_NUM.HeaderText = "ORDER_NUM";
            this.ORDER_NUM.Name = "ORDER_NUM";
            this.ORDER_NUM.ReadOnly = true;
            // 
            // PICKUP_ADDRESS
            // 
            this.PICKUP_ADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PICKUP_ADDRESS.DataPropertyName = "PICKUP_ADDRESS";
            this.PICKUP_ADDRESS.HeaderText = "Pickup Address";
            this.PICKUP_ADDRESS.Name = "PICKUP_ADDRESS";
            this.PICKUP_ADDRESS.ReadOnly = true;
            this.PICKUP_ADDRESS.Width = 121;
            // 
            // PICKUP_CITY
            // 
            this.PICKUP_CITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PICKUP_CITY.DataPropertyName = "PICKUP_CITY";
            this.PICKUP_CITY.HeaderText = "Pickup City";
            this.PICKUP_CITY.Name = "PICKUP_CITY";
            this.PICKUP_CITY.ReadOnly = true;
            this.PICKUP_CITY.Width = 96;
            // 
            // PICKUP_STATE
            // 
            this.PICKUP_STATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PICKUP_STATE.DataPropertyName = "PICKUP_STATE";
            this.PICKUP_STATE.HeaderText = "Pickup State";
            this.PICKUP_STATE.Name = "PICKUP_STATE";
            this.PICKUP_STATE.ReadOnly = true;
            this.PICKUP_STATE.Width = 104;
            // 
            // PICKUP_ZIP
            // 
            this.PICKUP_ZIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PICKUP_ZIP.DataPropertyName = "PICKUP_ZIP";
            this.PICKUP_ZIP.HeaderText = "Pickup Zip Code";
            this.PICKUP_ZIP.Name = "PICKUP_ZIP";
            this.PICKUP_ZIP.ReadOnly = true;
            this.PICKUP_ZIP.Width = 96;
            // 
            // DELIVERY_ADDRESS
            // 
            this.DELIVERY_ADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DELIVERY_ADDRESS.DataPropertyName = "DELIVERY_ADDRESS";
            this.DELIVERY_ADDRESS.HeaderText = "Delivery Address";
            this.DELIVERY_ADDRESS.Name = "DELIVERY_ADDRESS";
            this.DELIVERY_ADDRESS.ReadOnly = true;
            this.DELIVERY_ADDRESS.Width = 131;
            // 
            // DELIVERY_CITY
            // 
            this.DELIVERY_CITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DELIVERY_CITY.DataPropertyName = "DELIVERY_CITY";
            this.DELIVERY_CITY.HeaderText = "Delivery City";
            this.DELIVERY_CITY.Name = "DELIVERY_CITY";
            this.DELIVERY_CITY.ReadOnly = true;
            this.DELIVERY_CITY.Width = 106;
            // 
            // DELIVERY_STATE
            // 
            this.DELIVERY_STATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DELIVERY_STATE.DataPropertyName = "DELIVERY_STATE";
            this.DELIVERY_STATE.HeaderText = "Delivery State";
            this.DELIVERY_STATE.Name = "DELIVERY_STATE";
            this.DELIVERY_STATE.ReadOnly = true;
            this.DELIVERY_STATE.Width = 114;
            // 
            // DELIVERY_ZIP
            // 
            this.DELIVERY_ZIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DELIVERY_ZIP.DataPropertyName = "DELIVERY_ZIP";
            this.DELIVERY_ZIP.HeaderText = "Delivery Zip";
            this.DELIVERY_ZIP.Name = "DELIVERY_ZIP";
            this.DELIVERY_ZIP.ReadOnly = true;
            this.DELIVERY_ZIP.Width = 102;
            // 
            // bOOKDATEDataGridViewTextBoxColumn
            // 
            this.bOOKDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bOOKDATEDataGridViewTextBoxColumn.DataPropertyName = "BOOK_DATE";
            this.bOOKDATEDataGridViewTextBoxColumn.HeaderText = "Book Date";
            this.bOOKDATEDataGridViewTextBoxColumn.Name = "bOOKDATEDataGridViewTextBoxColumn";
            this.bOOKDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKDATEDataGridViewTextBoxColumn.Width = 93;
            // 
            // pICKUPDATEDataGridViewTextBoxColumn
            // 
            this.pICKUPDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pICKUPDATEDataGridViewTextBoxColumn.DataPropertyName = "PICKUP_DATE";
            this.pICKUPDATEDataGridViewTextBoxColumn.HeaderText = "Pickup Date";
            this.pICKUPDATEDataGridViewTextBoxColumn.Name = "pICKUPDATEDataGridViewTextBoxColumn";
            this.pICKUPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pICKUPDATEDataGridViewTextBoxColumn.Width = 102;
            // 
            // dROPOFFDATEDataGridViewTextBoxColumn
            // 
            this.dROPOFFDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dROPOFFDATEDataGridViewTextBoxColumn.DataPropertyName = "DROPOFF_DATE";
            this.dROPOFFDATEDataGridViewTextBoxColumn.HeaderText = "Dropoff Date";
            this.dROPOFFDATEDataGridViewTextBoxColumn.Name = "dROPOFFDATEDataGridViewTextBoxColumn";
            this.dROPOFFDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dROPOFFDATEDataGridViewTextBoxColumn.Width = 107;
            // 
            // oRDERSTATUSDataGridViewTextBoxColumn
            // 
            this.oRDERSTATUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.oRDERSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ORDER_STATUS";
            this.oRDERSTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.oRDERSTATUSDataGridViewTextBoxColumn.Name = "oRDERSTATUSDataGridViewTextBoxColumn";
            this.oRDERSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERSTATUSDataGridViewTextBoxColumn.Width = 74;
            // 
            // cUSTIDDataGridViewTextBoxColumn1
            // 
            this.cUSTIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cUSTIDDataGridViewTextBoxColumn1.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn1.HeaderText = "Customer";
            this.cUSTIDDataGridViewTextBoxColumn1.Name = "cUSTIDDataGridViewTextBoxColumn1";
            this.cUSTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cUSTIDDataGridViewTextBoxColumn1.Width = 96;
            // 
            // tab_Home
            // 
            this.tab_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_Home.BackgroundImage")));
            this.tab_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Home.Controls.Add(this.lbl_Home);
            this.tab_Home.Location = new System.Drawing.Point(4, 28);
            this.tab_Home.Name = "tab_Home";
            this.tab_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Home.Size = new System.Drawing.Size(1107, 546);
            this.tab_Home.TabIndex = 0;
            this.tab_Home.Text = "Home";
            this.tab_Home.UseVisualStyleBackColor = true;
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.White;
            this.lbl_Home.Location = new System.Drawing.Point(301, 111);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(554, 55);
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
            this.tab_Container.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Container.Location = new System.Drawing.Point(3, 0);
            this.tab_Container.Name = "tab_Container";
            this.tab_Container.SelectedIndex = 0;
            this.tab_Container.Size = new System.Drawing.Size(1115, 578);
            this.tab_Container.TabIndex = 19;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 579);
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
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Status)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tab_ManageCustomers.ResumeLayout(false);
            this.tab_ManageCustomers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_SearchOrders.ResumeLayout(false);
            this.tab_SearchOrders.PerformLayout();
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
        private System.Windows.Forms.RichTextBox txtboxrch_SpecialInstructions;
        private System.Windows.Forms.TextBox txtbox_OrderNum;
        private System.Windows.Forms.TextBox txtbox_Company;
        private System.Windows.Forms.TextBox txtbox_Email;
        private System.Windows.Forms.TextBox txtbox_Phone;
        private System.Windows.Forms.TextBox txtbox_Zip;
        private System.Windows.Forms.TextBox txtbox_State;
        private System.Windows.Forms.TextBox txtbox_City;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.Label lbl_Order;
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
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label lbl_RequiredField;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.RichTextBox txtboxrch_Description;
        private System.Windows.Forms.PictureBox picBox_Status;
        private System.Windows.Forms.Label lbl_OrderStatus;
        private System.Windows.Forms.Label lbl_OrderSearch;
        private System.Windows.Forms.TextBox txtbox_OrderSearchBox;
        private System.Windows.Forms.TextBox txtbox_InvoiceIdEdit;
        private System.Windows.Forms.Label lbl_InvoiceIdEdit;
        private System.Windows.Forms.Label lbl_DeliveryDateEdit;
        private System.Windows.Forms.Label lbl_BookingDateEdit;
        private System.Windows.Forms.Label lbl_PickupDateEdit;
        private System.Windows.Forms.TextBox txtboxCustomerIdEdit;
        private System.Windows.Forms.Label lbl_CustomerIdEdit;
        private System.Windows.Forms.Label lbl_OrderStatusEdit;
        private System.Windows.Forms.TextBox txtbox_PickupAddressEdit;
        private System.Windows.Forms.Label lbl_PickupAddressEdit;
        private System.Windows.Forms.TextBox txtbox_PickupStateEdit;
        private System.Windows.Forms.Label lbl_PickUpStateEdit;
        private System.Windows.Forms.TextBox txtbox_PickupCityEdit;
        private System.Windows.Forms.Label lbl_PickUpCityEdit;
        private System.Windows.Forms.TextBox txtbox_PickUpZipEdit;
        private System.Windows.Forms.Label lbl_PickUpZipEdit;
        private System.Windows.Forms.TextBox txtbox_DeliveryCityEdit;
        private System.Windows.Forms.Label lbl_DeliveryCityEdit;
        private System.Windows.Forms.TextBox txtbox_DeliveryAddressEdit;
        private System.Windows.Forms.Label lbl_DeliveryAddressEdit;
        private System.Windows.Forms.TextBox txtbox_DeliveryZipEdit;
        private System.Windows.Forms.Label lbl_DeliveryZipEdit;
        private System.Windows.Forms.TextBox txtbox_DeliveryStateEdit;
        private System.Windows.Forms.Label lbl_DeliveryStateEdit;
        private System.Windows.Forms.Label lbl_SpecialInstructionsEdit;
        private System.Windows.Forms.RichTextBox txtboxrch_SpecailInstructionsEdit;
        private System.Windows.Forms.Label lbl_DescriptionEdit;
        private System.Windows.Forms.RichTextBox txtboxrch_DescriptionEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DeliveryDateEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PickUpDateEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BookingDateEdit;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.TextBox txtBox_InvoiceNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Vehicle;
        private System.Windows.Forms.Label lbl_Vehicle;
        private System.Windows.Forms.ComboBox combobox_OrderStatusEdit;
        private System.Windows.Forms.Button btn_SaveOrderEdit;
        private System.Windows.Forms.Button btn_EditOrder;
        private System.Windows.Forms.TextBox txtbox_OrderNumberEdit;
        private System.Windows.Forms.Label lbl_OrderNumberEdit;
        private System.Windows.Forms.ComboBox comboBox_Broker;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BROKER;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTCOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTZIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEHICLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICKUP_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICKUP_CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICKUP_STATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICKUP_ZIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELIVERY_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELIVERY_CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELIVERY_STATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELIVERY_ZIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pICKUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dROPOFFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBox_VehicleEdit;
        private System.Windows.Forms.Label label4;
    }
}