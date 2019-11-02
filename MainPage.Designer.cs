﻿namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btn_ManageCustomers = new System.Windows.Forms.Button();
            this.btn_ManageOrders = new System.Windows.Forms.Button();
            this.lb_FrontTitle = new System.Windows.Forms.Label();
            this.lb_CompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ManageCustomers
            // 
            this.btn_ManageCustomers.AutoSize = true;
            this.btn_ManageCustomers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ManageCustomers.BackColor = System.Drawing.Color.White;
            this.btn_ManageCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ManageCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ManageCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_ManageCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ManageCustomers.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManageCustomers.Image")));
            this.btn_ManageCustomers.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ManageCustomers.Location = new System.Drawing.Point(45, 98);
            this.btn_ManageCustomers.Name = "btn_ManageCustomers";
            this.btn_ManageCustomers.Size = new System.Drawing.Size(306, 306);
            this.btn_ManageCustomers.TabIndex = 0;
            this.btn_ManageCustomers.Text = "Manage Customers";
            this.btn_ManageCustomers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ManageCustomers.UseVisualStyleBackColor = false;
            this.btn_ManageCustomers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ManageOrders
            // 
            this.btn_ManageOrders.AutoSize = true;
            this.btn_ManageOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ManageOrders.BackColor = System.Drawing.Color.White;
            this.btn_ManageOrders.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ManageOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_ManageOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ManageOrders.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageOrders.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManageOrders.Image")));
            this.btn_ManageOrders.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ManageOrders.Location = new System.Drawing.Point(405, 98);
            this.btn_ManageOrders.Name = "btn_ManageOrders";
            this.btn_ManageOrders.Size = new System.Drawing.Size(306, 305);
            this.btn_ManageOrders.TabIndex = 1;
            this.btn_ManageOrders.Text = "Manage Orders";
            this.btn_ManageOrders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ManageOrders.UseVisualStyleBackColor = false;
            this.btn_ManageOrders.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_FrontTitle
            // 
            this.lb_FrontTitle.AutoSize = true;
            this.lb_FrontTitle.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FrontTitle.Location = new System.Drawing.Point(12, 18);
            this.lb_FrontTitle.Name = "lb_FrontTitle";
            this.lb_FrontTitle.Size = new System.Drawing.Size(725, 49);
            this.lb_FrontTitle.TabIndex = 2;
            this.lb_FrontTitle.Text = "Please select one of the following options:";
            // 
            // lb_CompanyName
            // 
            this.lb_CompanyName.AutoSize = true;
            this.lb_CompanyName.Location = new System.Drawing.Point(617, 438);
            this.lb_CompanyName.Name = "lb_CompanyName";
            this.lb_CompanyName.Size = new System.Drawing.Size(138, 13);
            this.lb_CompanyName.TabIndex = 3;
            this.lb_CompanyName.Text = "©DaphAdil Consulting 2019";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(761, 458);
            this.Controls.Add(this.lb_CompanyName);
            this.Controls.Add(this.lb_FrontTitle);
            this.Controls.Add(this.btn_ManageOrders);
            this.Controls.Add(this.btn_ManageCustomers);
            this.Name = "MainPage";
            this.Text = "BalkanExpress CRM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ManageCustomers;
        private System.Windows.Forms.Button btn_ManageOrders;
        private System.Windows.Forms.Label lb_FrontTitle;
        private System.Windows.Forms.Label lb_CompanyName;
    }
}

