namespace BalkanCRM
{
    partial class AddCustomer
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTCOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTZIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new BalkanCRM.AppData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cUSTOMERTableAdapter = new BalkanCRM.AppDataTableAdapters.CUSTOMERTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seachByFirstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seachByLastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByCompnayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTIDDataGridViewTextBoxColumn,
            this.cUSTFNAMEDataGridViewTextBoxColumn,
            this.cUSTLNAMEDataGridViewTextBoxColumn,
            this.cUSTCOMPANYDataGridViewTextBoxColumn,
            this.cUSTADDRESSDataGridViewTextBoxColumn,
            this.cUSTCITYDataGridViewTextBoxColumn,
            this.cUSTSTATEDataGridViewTextBoxColumn,
            this.cUSTZIPDataGridViewTextBoxColumn,
            this.cUSTEMAILDataGridViewTextBoxColumn,
            this.cUSTPHONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 182);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            // 
            // cUSTFNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTFNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUST_FNAME";
            this.cUSTFNAMEDataGridViewTextBoxColumn.HeaderText = "CUST_FNAME";
            this.cUSTFNAMEDataGridViewTextBoxColumn.Name = "cUSTFNAMEDataGridViewTextBoxColumn";
            // 
            // cUSTLNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUST_LNAME";
            this.cUSTLNAMEDataGridViewTextBoxColumn.HeaderText = "CUST_LNAME";
            this.cUSTLNAMEDataGridViewTextBoxColumn.Name = "cUSTLNAMEDataGridViewTextBoxColumn";
            // 
            // cUSTCOMPANYDataGridViewTextBoxColumn
            // 
            this.cUSTCOMPANYDataGridViewTextBoxColumn.DataPropertyName = "CUST_COMPANY";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.HeaderText = "CUST_COMPANY";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.Name = "cUSTCOMPANYDataGridViewTextBoxColumn";
            // 
            // cUSTADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUST_ADDRESS";
            this.cUSTADDRESSDataGridViewTextBoxColumn.HeaderText = "CUST_ADDRESS";
            this.cUSTADDRESSDataGridViewTextBoxColumn.Name = "cUSTADDRESSDataGridViewTextBoxColumn";
            // 
            // cUSTCITYDataGridViewTextBoxColumn
            // 
            this.cUSTCITYDataGridViewTextBoxColumn.DataPropertyName = "CUST_CITY";
            this.cUSTCITYDataGridViewTextBoxColumn.HeaderText = "CUST_CITY";
            this.cUSTCITYDataGridViewTextBoxColumn.Name = "cUSTCITYDataGridViewTextBoxColumn";
            // 
            // cUSTSTATEDataGridViewTextBoxColumn
            // 
            this.cUSTSTATEDataGridViewTextBoxColumn.DataPropertyName = "CUST_STATE";
            this.cUSTSTATEDataGridViewTextBoxColumn.HeaderText = "CUST_STATE";
            this.cUSTSTATEDataGridViewTextBoxColumn.Name = "cUSTSTATEDataGridViewTextBoxColumn";
            // 
            // cUSTZIPDataGridViewTextBoxColumn
            // 
            this.cUSTZIPDataGridViewTextBoxColumn.DataPropertyName = "CUST_ZIP";
            this.cUSTZIPDataGridViewTextBoxColumn.HeaderText = "CUST_ZIP";
            this.cUSTZIPDataGridViewTextBoxColumn.Name = "cUSTZIPDataGridViewTextBoxColumn";
            // 
            // cUSTEMAILDataGridViewTextBoxColumn
            // 
            this.cUSTEMAILDataGridViewTextBoxColumn.DataPropertyName = "CUST_EMAIL";
            this.cUSTEMAILDataGridViewTextBoxColumn.HeaderText = "CUST_EMAIL";
            this.cUSTEMAILDataGridViewTextBoxColumn.Name = "cUSTEMAILDataGridViewTextBoxColumn";
            // 
            // cUSTPHONEDataGridViewTextBoxColumn
            // 
            this.cUSTPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUST_PHONE";
            this.cUSTPHONEDataGridViewTextBoxColumn.HeaderText = "CUST_PHONE";
            this.cUSTPHONEDataGridViewTextBoxColumn.Name = "cUSTPHONEDataGridViewTextBoxColumn";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FirstNameBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmailBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PhoneNumberBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LastNameBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 155);
            this.panel1.TabIndex = 4;
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
            this.FirstNameBox.TabIndex = 0;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(60, 211);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(307, 20);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(586, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(667, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(424, 214);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(505, 214);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByIDToolStripMenuItem,
            this.seachByFirstNameToolStripMenuItem,
            this.seachByLastNameToolStripMenuItem,
            this.searchByCompnayToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchByIDToolStripMenuItem
            // 
            this.searchByIDToolStripMenuItem.Name = "searchByIDToolStripMenuItem";
            this.searchByIDToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.searchByIDToolStripMenuItem.Text = "Search by ID";
            // 
            // seachByFirstNameToolStripMenuItem
            // 
            this.seachByFirstNameToolStripMenuItem.Name = "seachByFirstNameToolStripMenuItem";
            this.seachByFirstNameToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.seachByFirstNameToolStripMenuItem.Text = "Seach by First Name";
            // 
            // seachByLastNameToolStripMenuItem
            // 
            this.seachByLastNameToolStripMenuItem.Name = "seachByLastNameToolStripMenuItem";
            this.seachByLastNameToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.seachByLastNameToolStripMenuItem.Text = "Seach by Last Name";
            // 
            // searchByCompnayToolStripMenuItem
            // 
            this.searchByCompnayToolStripMenuItem.Name = "searchByCompnayToolStripMenuItem";
            this.searchByCompnayToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.searchByCompnayToolStripMenuItem.Text = "Search by Compnay";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private AppData appData;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private AppDataTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTCOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTZIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seachByFirstNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seachByLastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByCompnayToolStripMenuItem;
    }
}