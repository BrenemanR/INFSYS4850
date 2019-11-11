using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalkanCRM
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ManageCustomers_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
            btn_ManageCustomers.Enabled = false;
            btn_ManageCustomers.Visible = false;
            btn_ManageCustomersAlreadyOpen.Visible = true;
        }

        private void btn_ManageOrders_Click(object sender, EventArgs e)
        //Opens the ManageOrders form when clicked
        {
            ManageOrders manageOrders = new ManageOrders();
            manageOrders.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private bool CheckOpened(string name)
        //Attempt to prevent the form from being opened multiple times. Requires some additional work.
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_ManageCustomersAlreadyOpen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Manage Customers is already open.");
        }
    }
}
