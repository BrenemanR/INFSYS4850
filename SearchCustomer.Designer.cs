namespace WindowsFormsApp3
{
    partial class SearchCustomer
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
            this.SearchField = new System.Windows.Forms.TextBox();
            this.SearchFieldLabel = new System.Windows.Forms.Label();
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
            this.appData = new WindowsFormsApp3.AppData();
            this.cUSTOMERTableAdapter = new WindowsFormsApp3.AppDataTableAdapters.CUSTOMERTableAdapter();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(59, 157);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(157, 20);
            this.SearchField.TabIndex = 0;
            this.SearchField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchField_KeyPress);
            // 
            // SearchFieldLabel
            // 
            this.SearchFieldLabel.AutoSize = true;
            this.SearchFieldLabel.Location = new System.Drawing.Point(12, 160);
            this.SearchFieldLabel.Name = "SearchFieldLabel";
            this.SearchFieldLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchFieldLabel.TabIndex = 1;
            this.SearchFieldLabel.Text = "Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            this.cUSTIDDataGridViewTextBoxColumn.Visible = false;
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
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(631, 1);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(138, 56);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(631, 63);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 56);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchFieldLabel);
            this.Controls.Add(this.SearchField);
            this.Name = "SearchCustomer";
            this.Text = "Search Customer";
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Label SearchFieldLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
    }
}