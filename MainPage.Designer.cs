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
            this.picBox_Status = new System.Windows.Forms.PictureBox();
            this.listBox_Status = new System.Windows.Forms.ListBox();
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
            this.iNVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new WindowsFormsApp3.AppData();
            this.btn_SaveOrder = new System.Windows.Forms.Button();
            this.btn_CreateOrder = new System.Windows.Forms.Button();
            this.lbl_SpecialInstructions = new System.Windows.Forms.Label();
            this.txtboxrch_SpecialInstructions = new System.Windows.Forms.RichTextBox();
            this.txtbox_Invoice = new System.Windows.Forms.TextBox();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iNVIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.OrderSearchBox = new System.Windows.Forms.TextBox();
            this.lbl_OrderSearch = new System.Windows.Forms.Label();
            tab_CreateOrder = new System.Windows.Forms.TabPage();
            tab_CreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Status)).BeginInit();
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
            tab_CreateOrder.Controls.Add(this.picBox_Status);
            tab_CreateOrder.Controls.Add(this.listBox_Status);
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
            tab_CreateOrder.Controls.Add(this.txtbox_Invoice);
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
            tab_CreateOrder.Location = new System.Drawing.Point(4, 28);
            tab_CreateOrder.Name = "tab_CreateOrder";
            tab_CreateOrder.Padding = new System.Windows.Forms.Padding(3);
            tab_CreateOrder.Size = new System.Drawing.Size(1107, 546);
            tab_CreateOrder.TabIndex = 5;
            tab_CreateOrder.Text = "Create Order";
            // 
            // picBox_Status
            // 
            this.picBox_Status.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBox_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_Status.Enabled = false;
            this.picBox_Status.Image = global::WindowsFormsApp3.Properties.Resources.pending;
            this.picBox_Status.Location = new System.Drawing.Point(392, 372);
            this.picBox_Status.Name = "picBox_Status";
            this.picBox_Status.Size = new System.Drawing.Size(150, 150);
            this.picBox_Status.TabIndex = 65;
            this.picBox_Status.TabStop = false;
            // 
            // listBox_Status
            // 
            this.listBox_Status.Enabled = false;
            this.listBox_Status.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Status.FormattingEnabled = true;
            this.listBox_Status.ItemHeight = 33;
            this.listBox_Status.Items.AddRange(new object[] {
            "Pending Pmt",
            "In Transit",
            "Delayed",
            "Complete",
            "Cancelled"});
            this.listBox_Status.Location = new System.Drawing.Point(386, 326);
            this.listBox_Status.Name = "listBox_Status";
            this.listBox_Status.Size = new System.Drawing.Size(169, 37);
            this.listBox_Status.TabIndex = 14;
            this.listBox_Status.SelectedIndexChanged += new System.EventHandler(this.listBox_Status_SelectedIndexChanged);
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
            this.lbl_Description.Location = new System.Drawing.Point(571, 112);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(90, 19);
            this.lbl_Description.TabIndex = 62;
            this.lbl_Description.Text = "Description:";
            // 
            // txtboxrch_Description
            // 
            this.txtboxrch_Description.AcceptsTab = true;
            this.txtboxrch_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxrch_Description.Enabled = false;
            this.txtboxrch_Description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxrch_Description.Location = new System.Drawing.Point(574, 134);
            this.txtboxrch_Description.Name = "txtboxrch_Description";
            this.txtboxrch_Description.ShowSelectionMargin = true;
            this.txtboxrch_Description.Size = new System.Drawing.Size(527, 155);
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
            this.txtbox_DeliveryZip.Enabled = false;
            this.txtbox_DeliveryZip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtbox_DeliveryState.Enabled = false;
            this.txtbox_DeliveryState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtbox_DeliveryCity.Enabled = false;
            this.txtbox_DeliveryCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtbox_DeliveryAddress.Enabled = false;
            this.txtbox_DeliveryAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbl_DeliveryDate.Location = new System.Drawing.Point(19, 382);
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
            this.DropOffDatePicker.Location = new System.Drawing.Point(126, 376);
            this.DropOffDatePicker.Name = "DropOffDatePicker";
            this.DropOffDatePicker.Size = new System.Drawing.Size(238, 27);
            this.DropOffDatePicker.TabIndex = 12;
            // 
            // PickUpDatePicker
            // 
            this.PickUpDatePicker.Enabled = false;
            this.PickUpDatePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpDatePicker.Location = new System.Drawing.Point(126, 338);
            this.PickUpDatePicker.Name = "PickUpDatePicker";
            this.PickUpDatePicker.Size = new System.Drawing.Size(238, 27);
            this.PickUpDatePicker.TabIndex = 11;
            // 
            // BookDatePicker
            // 
            this.BookDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "BOOK_DATE", true));
            this.BookDatePicker.Enabled = false;
            this.BookDatePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDatePicker.Location = new System.Drawing.Point(126, 298);
            this.BookDatePicker.Name = "BookDatePicker";
            this.BookDatePicker.Size = new System.Drawing.Size(238, 27);
            this.BookDatePicker.TabIndex = 10;
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
            this.lbl_SpecialInstructions.Location = new System.Drawing.Point(571, 304);
            this.lbl_SpecialInstructions.Name = "lbl_SpecialInstructions";
            this.lbl_SpecialInstructions.Size = new System.Drawing.Size(145, 19);
            this.lbl_SpecialInstructions.TabIndex = 24;
            this.lbl_SpecialInstructions.Text = "Special Instructions:";
            // 
            // txtboxrch_SpecialInstructions
            // 
            this.txtboxrch_SpecialInstructions.Enabled = false;
            this.txtboxrch_SpecialInstructions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxrch_SpecialInstructions.Location = new System.Drawing.Point(571, 326);
            this.txtboxrch_SpecialInstructions.Name = "txtboxrch_SpecialInstructions";
            this.txtboxrch_SpecialInstructions.Size = new System.Drawing.Size(527, 196);
            this.txtboxrch_SpecialInstructions.TabIndex = 16;
            this.txtboxrch_SpecialInstructions.Text = "";
            // 
            // txtbox_Invoice
            // 
            this.txtbox_Invoice.BackColor = System.Drawing.Color.White;
            this.txtbox_Invoice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVOICEBindingSource, "INV_ID", true));
            this.txtbox_Invoice.Enabled = false;
            this.txtbox_Invoice.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Invoice.Location = new System.Drawing.Point(921, 28);
            this.txtbox_Invoice.Name = "txtbox_Invoice";
            this.txtbox_Invoice.Size = new System.Drawing.Size(121, 86);
            this.txtbox_Invoice.TabIndex = 16;
            this.txtbox_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_Company
            // 
            this.txtbox_Company.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_COMPANY", true));
            this.txtbox_Company.Enabled = false;
            this.txtbox_Company.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtbox_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.txtbox_Email.Enabled = false;
            this.txtbox_Email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Email.Location = new System.Drawing.Point(697, 6);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(161, 27);
            this.txtbox_Email.TabIndex = 3;
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.txtbox_Phone.Enabled = false;
            this.txtbox_Phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Phone.Location = new System.Drawing.Point(503, 6);
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(124, 27);
            this.txtbox_Phone.TabIndex = 2;
            // 
            // txtbox_Zip
            // 
            this.txtbox_Zip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.txtbox_Zip.Enabled = false;
            this.txtbox_Zip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Zip.Location = new System.Drawing.Point(681, 42);
            this.txtbox_Zip.Name = "txtbox_Zip";
            this.txtbox_Zip.Size = new System.Drawing.Size(177, 27);
            this.txtbox_Zip.TabIndex = 7;
            // 
            // txtbox_State
            // 
            this.txtbox_State.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.txtbox_State.Enabled = false;
            this.txtbox_State.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_State.Location = new System.Drawing.Point(491, 42);
            this.txtbox_State.Name = "txtbox_State";
            this.txtbox_State.Size = new System.Drawing.Size(136, 27);
            this.txtbox_State.TabIndex = 6;
            // 
            // txtbox_City
            // 
            this.txtbox_City.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.txtbox_City.Enabled = false;
            this.txtbox_City.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_City.Location = new System.Drawing.Point(266, 42);
            this.txtbox_City.Name = "txtbox_City";
            this.txtbox_City.Size = new System.Drawing.Size(170, 27);
            this.txtbox_City.TabIndex = 5;
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ADDRESS", true));
            this.txtbox_Address.Enabled = false;
            this.txtbox_Address.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbl_Order.Location = new System.Drawing.Point(950, 6);
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
            this.combobox_CustomerIDZ.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cUSTOMERBindingSource, "CUST_ID", true));
            this.combobox_CustomerIDZ.DataSource = this.cUSTOMERBindingSource;
            this.combobox_CustomerIDZ.DisplayMember = "CUST_LNAME";
            this.combobox_CustomerIDZ.Enabled = false;
            this.combobox_CustomerIDZ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtbox_PickupAddress.Enabled = false;
            this.txtbox_PickupAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PickupAddress.Location = new System.Drawing.Point(117, 61);
            this.txtbox_PickupAddress.Name = "txtbox_PickupAddress";
            this.txtbox_PickupAddress.Size = new System.Drawing.Size(141, 27);
            this.txtbox_PickupAddress.TabIndex = 38;
            // 
            // txtbox_PickupCity
            // 
            this.txtbox_PickupCity.Enabled = false;
            this.txtbox_PickupCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PickupCity.Location = new System.Drawing.Point(117, 94);
            this.txtbox_PickupCity.Name = "txtbox_PickupCity";
            this.txtbox_PickupCity.Size = new System.Drawing.Size(141, 27);
            this.txtbox_PickupCity.TabIndex = 41;
            // 
            // txtbox_PickupState
            // 
            this.txtbox_PickupState.Enabled = false;
            this.txtbox_PickupState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PickupState.Location = new System.Drawing.Point(117, 128);
            this.txtbox_PickupState.Name = "txtbox_PickupState";
            this.txtbox_PickupState.Size = new System.Drawing.Size(141, 27);
            this.txtbox_PickupState.TabIndex = 43;
            // 
            // txtbox_PickupZip
            // 
            this.txtbox_PickupZip.Enabled = false;
            this.txtbox_PickupZip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tab_ManageCustomers.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.SearchBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(346, 7);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(279, 27);
            this.SearchBox.TabIndex = 18;
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(278, 298);
            this.panel1.TabIndex = 0;
            // 
            // lbl_RequiredField
            // 
            this.lbl_RequiredField.AutoSize = true;
            this.lbl_RequiredField.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RequiredField.ForeColor = System.Drawing.Color.Red;
            this.lbl_RequiredField.Location = new System.Drawing.Point(13, 271);
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
            this.ZipLabel.Location = new System.Drawing.Point(13, 236);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(68, 19);
            this.ZipLabel.TabIndex = 19;
            this.ZipLabel.Text = "Zip Code";
            // 
            // ZipBox
            // 
            this.ZipBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.ZipBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CompanyLabel.Location = new System.Drawing.Point(13, 124);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(73, 19);
            this.CompanyLabel.TabIndex = 17;
            this.CompanyLabel.Text = "Company";
            // 
            // CompanyBox
            // 
            this.CompanyBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_COMPANY", true));
            this.CompanyBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyBox.Location = new System.Drawing.Point(101, 121);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(163, 27);
            this.CompanyBox.TabIndex = 10;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.Location = new System.Drawing.Point(13, 208);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(45, 19);
            this.StateLabel.TabIndex = 16;
            this.StateLabel.Text = "State";
            // 
            // StateBox
            // 
            this.StateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.StateBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateBox.Location = new System.Drawing.Point(101, 205);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(163, 27);
            this.StateBox.TabIndex = 13;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(13, 180);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 19);
            this.CityLabel.TabIndex = 15;
            this.CityLabel.Text = "City";
            // 
            // CityBox
            // 
            this.CityBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.CityBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.Location = new System.Drawing.Point(101, 177);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(163, 27);
            this.CityBox.TabIndex = 12;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(13, 152);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(63, 19);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Address";
            // 
            // AddressBox
            // 
            this.AddressBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ADDRESS", true));
            this.AddressBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.Location = new System.Drawing.Point(101, 149);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(163, 27);
            this.AddressBox.TabIndex = 11;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 12);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(82, 19);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_FNAME", true));
            this.FirstNameBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.EmailLabel.Location = new System.Drawing.Point(13, 96);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 19);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.EmailBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(101, 93);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(163, 27);
            this.EmailBox.TabIndex = 3;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(13, 68);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(65, 19);
            this.PhoneLabel.TabIndex = 5;
            this.PhoneLabel.Text = "Phone #";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.PhoneNumberBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.LastNameLabel.Location = new System.Drawing.Point(13, 40);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(80, 19);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameBox
            // 
            this.LastNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_LNAME", true));
            this.LastNameBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.Location = new System.Drawing.Point(284, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(820, 496);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
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
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 5;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(45, 358);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(184, 46);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit Customer";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew.FlatAppearance.BorderSize = 5;
            this.btnNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(45, 305);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(184, 46);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Add New Customer";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 5;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(45, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 46);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 5;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(45, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 44);
            this.btnCancel.TabIndex = 13;
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
            this.tab_SearchOrders.Controls.Add(this.lbl_OrderSearch);
            this.tab_SearchOrders.Controls.Add(this.OrderSearchBox);
            this.tab_SearchOrders.Controls.Add(this.dataGridView2);
            this.tab_SearchOrders.Location = new System.Drawing.Point(4, 28);
            this.tab_SearchOrders.Name = "tab_SearchOrders";
            this.tab_SearchOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SearchOrders.Size = new System.Drawing.Size(1107, 546);
            this.tab_SearchOrders.TabIndex = 3;
            this.tab_SearchOrders.Text = "Search Orders";
            this.tab_SearchOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNVIDDataGridViewTextBoxColumn,
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
            this.lbl_Home.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.White;
            this.lbl_Home.Location = new System.Drawing.Point(132, 100);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(826, 58);
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
            // OrderSearchBox
            // 
            this.OrderSearchBox.Location = new System.Drawing.Point(92, 30);
            this.OrderSearchBox.Name = "OrderSearchBox";
            this.OrderSearchBox.Size = new System.Drawing.Size(183, 27);
            this.OrderSearchBox.TabIndex = 1;
            this.OrderSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderSearchBox_KeyPress);
            // 
            // lbl_OrderSearch
            // 
            this.lbl_OrderSearch.AutoSize = true;
            this.lbl_OrderSearch.Location = new System.Drawing.Point(30, 33);
            this.lbl_OrderSearch.Name = "lbl_OrderSearch";
            this.lbl_OrderSearch.Size = new System.Drawing.Size(56, 19);
            this.lbl_OrderSearch.TabIndex = 2;
            this.lbl_OrderSearch.Text = "Search:";
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
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Status)).EndInit();
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
        private System.Windows.Forms.TextBox txtbox_Invoice;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iNVIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.PictureBox picBox_Status;
        private System.Windows.Forms.ListBox listBox_Status;
        private System.Windows.Forms.Label lbl_OrderStatus;
        private System.Windows.Forms.Label lbl_OrderSearch;
        private System.Windows.Forms.TextBox OrderSearchBox;
    }
}