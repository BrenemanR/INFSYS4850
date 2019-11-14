using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_ManageCustomers_Click(object sender, EventArgs e)
        {
            //Opens the Manage Customers form.
            ManageCustomers manageCustomers = new ManageCustomers(this);
            manageCustomers.Show();
            
            //Prevents the user from opening the form multiple times.
            btn_ManageCustomersOpened.Visible = true;
        }

        private void btn_ManageOrders_Click(object sender, EventArgs e)
        {
            //Opens the ManageOrders form.
            ManageOrders manageOrders = new ManageOrders(this);
            manageOrders.Show();

            //Prevents the user from opening the form multiple times.
            btn_ManageOrdersOpened.Visible = true;
        }

        private void btn_ManageCustomersOpened_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Manage Customers is already opened.");
        }

        private void btn_ManageOrdersOpened_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Manage Orders is already opened.");
        }
    }
}
