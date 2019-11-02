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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        //Opens the ManageOrders form when clicked
        {
            ManageOrders manageOrders = new ManageOrders();
            /*Commented out this section because it wasn't working. Trying to prevent the
                form from being opened multiple times.

            bool status = CheckOpened("ManageOrders");
            if (status == true) {
                string message = "ManageOrders is already opened.";
                string title = "Alert";
                MessageBox.Show(message, title);
            }
            else
            {*/
            manageOrders.Show();
            //}
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
    }
}
