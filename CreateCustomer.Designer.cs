namespace WindowsFormsApp3
{
    partial class CreateCustomer
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
            this.lbl_Company = new System.Windows.Forms.Label();
            this.txtbox_Company = new System.Windows.Forms.TextBox();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.txtbox_FName = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtbox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.txtbox_LName = new System.Windows.Forms.TextBox();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.appData = new WindowsFormsApp3.AppData();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new WindowsFormsApp3.AppDataTableAdapters.CUSTOMERTableAdapter();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_Zip = new System.Windows.Forms.Label();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.txtbox_City = new System.Windows.Forms.TextBox();
            this.txtbox_State = new System.Windows.Forms.TextBox();
            this.txtbox_Zip = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company.Location = new System.Drawing.Point(12, 300);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(124, 33);
            this.lbl_Company.TabIndex = 27;
            this.lbl_Company.Text = "Company:";
            // 
            // txtbox_Company
            // 
            this.txtbox_Company.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_COMPANY", true));
            this.txtbox_Company.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Company.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_Company.Location = new System.Drawing.Point(213, 297);
            this.txtbox_Company.Name = "txtbox_Company";
            this.txtbox_Company.Size = new System.Drawing.Size(222, 40);
            this.txtbox_Company.TabIndex = 26;
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FName.Location = new System.Drawing.Point(12, 27);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(140, 33);
            this.lbl_FName.TabIndex = 25;
            this.lbl_FName.Text = "First Name:";
            // 
            // txtbox_FName
            // 
            this.txtbox_FName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_FNAME", true));
            this.txtbox_FName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_FName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_FName.Location = new System.Drawing.Point(213, 24);
            this.txtbox_FName.Name = "txtbox_FName";
            this.txtbox_FName.Size = new System.Drawing.Size(222, 40);
            this.txtbox_FName.TabIndex = 18;
            this.txtbox_FName.TextChanged += new System.EventHandler(this.txtbox_FName_TextChanged);
            this.txtbox_FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_FName_KeyPress);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(12, 232);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(82, 33);
            this.lbl_Email.TabIndex = 24;
            this.lbl_Email.Text = "Email:";
            // 
            // txtbox_Email
            // 
            this.txtbox_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_EMAIL", true));
            this.txtbox_Email.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_Email.Location = new System.Drawing.Point(213, 229);
            this.txtbox_Email.Name = "txtbox_Email";
            this.txtbox_Email.Size = new System.Drawing.Size(222, 40);
            this.txtbox_Email.TabIndex = 21;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(12, 162);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(186, 33);
            this.lbl_Phone.TabIndex = 23;
            this.lbl_Phone.Text = "Phone Number:";
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_PHONE", true));
            this.txtbox_Phone.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_Phone.Location = new System.Drawing.Point(213, 159);
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(222, 40);
            this.txtbox_Phone.TabIndex = 20;
            this.txtbox_Phone.TextChanged += new System.EventHandler(this.txtbox_Phone_TextChanged);
            this.txtbox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Phone_KeyPress);
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LName.Location = new System.Drawing.Point(12, 93);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(137, 33);
            this.lbl_LName.TabIndex = 22;
            this.lbl_LName.Text = "Last Name:";
            // 
            // txtbox_LName
            // 
            this.txtbox_LName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_LNAME", true));
            this.txtbox_LName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_LName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_LName.Location = new System.Drawing.Point(213, 93);
            this.txtbox_LName.Name = "txtbox_LName";
            this.txtbox_LName.Size = new System.Drawing.Size(222, 40);
            this.txtbox_LName.TabIndex = 19;
            this.txtbox_LName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_LName_KeyPress);
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateCustomer.FlatAppearance.BorderSize = 2;
            this.btnCreateCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateCustomer.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCreateCustomer.Location = new System.Drawing.Point(352, 374);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(312, 46);
            this.btnCreateCustomer.TabIndex = 29;
            this.btnCreateCustomer.Text = "Create Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = false;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.appData;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(554, 27);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(110, 33);
            this.lbl_Address.TabIndex = 30;
            this.lbl_Address.Text = "Address:";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.Location = new System.Drawing.Point(554, 93);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(63, 33);
            this.lbl_City.TabIndex = 31;
            this.lbl_City.Text = "City:";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.Location = new System.Drawing.Point(554, 162);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(78, 33);
            this.lbl_State.TabIndex = 32;
            this.lbl_State.Text = "State:";
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zip.Location = new System.Drawing.Point(554, 232);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(116, 33);
            this.lbl_Zip.TabIndex = 33;
            this.lbl_Zip.Text = "Zip Code:";
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ADDRESS", true));
            this.txtbox_Address.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Address.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_Address.Location = new System.Drawing.Point(670, 24);
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(222, 40);
            this.txtbox_Address.TabIndex = 34;
            // 
            // txtbox_City
            // 
            this.txtbox_City.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_CITY", true));
            this.txtbox_City.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_City.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_City.Location = new System.Drawing.Point(670, 93);
            this.txtbox_City.Name = "txtbox_City";
            this.txtbox_City.Size = new System.Drawing.Size(222, 40);
            this.txtbox_City.TabIndex = 35;
            // 
            // txtbox_State
            // 
            this.txtbox_State.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_STATE", true));
            this.txtbox_State.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_State.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_State.Location = new System.Drawing.Point(670, 162);
            this.txtbox_State.Name = "txtbox_State";
            this.txtbox_State.Size = new System.Drawing.Size(222, 40);
            this.txtbox_State.TabIndex = 36;
            // 
            // txtbox_Zip
            // 
            this.txtbox_Zip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUST_ZIP", true));
            this.txtbox_Zip.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Zip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbox_Zip.Location = new System.Drawing.Point(670, 229);
            this.txtbox_Zip.Name = "txtbox_Zip";
            this.txtbox_Zip.Size = new System.Drawing.Size(222, 40);
            this.txtbox_Zip.TabIndex = 37;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(490, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 94);
            this.dataGridView1.TabIndex = 38;
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
            this.cUSTFNAMEDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.cUSTFNAMEDataGridViewTextBoxColumn.Name = "cUSTFNAMEDataGridViewTextBoxColumn";
            // 
            // cUSTLNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUST_LNAME";
            this.cUSTLNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.cUSTLNAMEDataGridViewTextBoxColumn.Name = "cUSTLNAMEDataGridViewTextBoxColumn";
            // 
            // cUSTEMAILDataGridViewTextBoxColumn
            // 
            this.cUSTEMAILDataGridViewTextBoxColumn.DataPropertyName = "CUST_EMAIL";
            this.cUSTEMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.cUSTEMAILDataGridViewTextBoxColumn.Name = "cUSTEMAILDataGridViewTextBoxColumn";
            // 
            // cUSTPHONEDataGridViewTextBoxColumn
            // 
            this.cUSTPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUST_PHONE";
            this.cUSTPHONEDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cUSTPHONEDataGridViewTextBoxColumn.Name = "cUSTPHONEDataGridViewTextBoxColumn";
            // 
            // cUSTCOMPANYDataGridViewTextBoxColumn
            // 
            this.cUSTCOMPANYDataGridViewTextBoxColumn.DataPropertyName = "CUST_COMPANY";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.HeaderText = "Company";
            this.cUSTCOMPANYDataGridViewTextBoxColumn.Name = "cUSTCOMPANYDataGridViewTextBoxColumn";
            // 
            // cUSTADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUST_ADDRESS";
            this.cUSTADDRESSDataGridViewTextBoxColumn.HeaderText = "Address";
            this.cUSTADDRESSDataGridViewTextBoxColumn.Name = "cUSTADDRESSDataGridViewTextBoxColumn";
            // 
            // cUSTCITYDataGridViewTextBoxColumn
            // 
            this.cUSTCITYDataGridViewTextBoxColumn.DataPropertyName = "CUST_CITY";
            this.cUSTCITYDataGridViewTextBoxColumn.HeaderText = "City";
            this.cUSTCITYDataGridViewTextBoxColumn.Name = "cUSTCITYDataGridViewTextBoxColumn";
            // 
            // cUSTSTATEDataGridViewTextBoxColumn
            // 
            this.cUSTSTATEDataGridViewTextBoxColumn.DataPropertyName = "CUST_STATE";
            this.cUSTSTATEDataGridViewTextBoxColumn.HeaderText = "State";
            this.cUSTSTATEDataGridViewTextBoxColumn.Name = "cUSTSTATEDataGridViewTextBoxColumn";
            // 
            // cUSTZIPDataGridViewTextBoxColumn
            // 
            this.cUSTZIPDataGridViewTextBoxColumn.DataPropertyName = "CUST_ZIP";
            this.cUSTZIPDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.cUSTZIPDataGridViewTextBoxColumn.Name = "cUSTZIPDataGridViewTextBoxColumn";
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbox_Zip);
            this.Controls.Add(this.txtbox_State);
            this.Controls.Add(this.txtbox_City);
            this.Controls.Add(this.txtbox_Address);
            this.Controls.Add(this.lbl_Zip);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.txtbox_Company);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.txtbox_FName);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txtbox_Email);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.txtbox_Phone);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.txtbox_LName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.CreateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.TextBox txtbox_Company;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.TextBox txtbox_FName;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtbox_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txtbox_Phone;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.TextBox txtbox_LName;
        private System.Windows.Forms.Button btnCreateCustomer;
        private AppData appData;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private AppDataTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_Zip;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.TextBox txtbox_City;
        private System.Windows.Forms.TextBox txtbox_State;
        private System.Windows.Forms.TextBox txtbox_Zip;
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
    }
}