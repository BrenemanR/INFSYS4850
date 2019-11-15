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
            this.iNVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData1 = new WindowsFormsApp3.AppData();
            this.iNVOICETableAdapter = new WindowsFormsApp3.AppDataTableAdapters.INVOICETableAdapter();
            this.tab_ManageOrders = new System.Windows.Forms.TabControl();
            this.tabPage_AddOrder = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            this.tab_ManageOrders.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // iNVOICETableAdapter
            // 
            this.iNVOICETableAdapter.ClearBeforeFill = true;
            // 
            // tab_ManageOrders
            // 
            this.tab_ManageOrders.Controls.Add(this.tabPage_AddOrder);
            this.tab_ManageOrders.Controls.Add(this.tabPage2);
            this.tab_ManageOrders.Location = new System.Drawing.Point(1, 0);
            this.tab_ManageOrders.Name = "tab_ManageOrders";
            this.tab_ManageOrders.SelectedIndex = 0;
            this.tab_ManageOrders.Size = new System.Drawing.Size(801, 450);
            this.tab_ManageOrders.TabIndex = 0;
            // 
            // tabPage_AddOrder
            // 
            this.tabPage_AddOrder.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_AddOrder.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_AddOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AddOrder.Name = "tabPage_AddOrder";
            this.tabPage_AddOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AddOrder.Size = new System.Drawing.Size(793, 424);
            this.tabPage_AddOrder.TabIndex = 0;
            this.tabPage_AddOrder.Text = "Add Order";
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
            this.tabPage2.Size = new System.Drawing.Size(793, 424);
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
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_ManageOrders);
            this.Name = "ManageOrders";
            this.Text = "Manage Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageOrders_FormClosed);
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            this.tab_ManageOrders.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AppData appData1;
        private System.Windows.Forms.BindingSource iNVOICEBindingSource;
        private AppDataTableAdapters.INVOICETableAdapter iNVOICETableAdapter;
        private System.Windows.Forms.TabControl tab_ManageOrders;
        private System.Windows.Forms.TabPage tabPage_AddOrder;
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
    }
}