namespace BalkanCRM
{
    partial class ManageCustomers
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
            this.lbl_Customers = new System.Windows.Forms.Label();
            this.btn_Show_Customer = new System.Windows.Forms.Button();
            this.btn_Add_Customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Customers
            // 
            this.lbl_Customers.AutoSize = true;
            this.lbl_Customers.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customers.Location = new System.Drawing.Point(267, 37);
            this.lbl_Customers.Name = "lbl_Customers";
            this.lbl_Customers.Size = new System.Drawing.Size(199, 49);
            this.lbl_Customers.TabIndex = 1;
            this.lbl_Customers.Text = "Customers";
            this.lbl_Customers.Click += new System.EventHandler(this.lbl_Customers_Click);
            // 
            // btn_Show_Customer
            // 
            this.btn_Show_Customer.Location = new System.Drawing.Point(448, 145);
            this.btn_Show_Customer.Name = "button1";
            this.btn_Show_Customer.Size = new System.Drawing.Size(280, 195);
            this.btn_Show_Customer.TabIndex = 2;
            this.btn_Show_Customer.Text = "Search Customer";
            this.btn_Show_Customer.UseVisualStyleBackColor = true;
            this.btn_Show_Customer.Click += new System.EventHandler(this.btn_Show_Customer_Click);
            // 
            // btn_Add_Customer
            // 
            this.btn_Add_Customer.Location = new System.Drawing.Point(50, 145);
            this.btn_Add_Customer.Name = "btn_Add_Customer";
            this.btn_Add_Customer.Size = new System.Drawing.Size(280, 195);
            this.btn_Add_Customer.TabIndex = 3;
            this.btn_Add_Customer.Text = "Add New Customer";
            this.btn_Add_Customer.UseVisualStyleBackColor = true;
            this.btn_Add_Customer.Click += new System.EventHandler(this.btn_Add_Customer_Click);
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Add_Customer);
            this.Controls.Add(this.btn_Show_Customer);
            this.Controls.Add(this.lbl_Customers);
            this.Name = "ManageCustomers";
            this.Text = "Manage Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Customers;
        private System.Windows.Forms.Button btn_Show_Customer;
        private System.Windows.Forms.Button btn_Add_Customer;
    }
}