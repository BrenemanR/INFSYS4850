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
            this.lbl_WorkOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_WorkOrder
            // 
            this.lbl_WorkOrder.AutoSize = true;
            this.lbl_WorkOrder.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkOrder.Location = new System.Drawing.Point(29, 13);
            this.lbl_WorkOrder.Name = "lbl_WorkOrder";
            this.lbl_WorkOrder.Size = new System.Drawing.Size(232, 49);
            this.lbl_WorkOrder.TabIndex = 0;
            this.lbl_WorkOrder.Text = "Work Orders";
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_WorkOrder);
            this.Name = "ManageOrders";
            this.Text = "Manage Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageOrders_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WorkOrder;
    }
}