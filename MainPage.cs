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


        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (closeApp) //closeApp prevents getting stuck in a close loop.
            {
                //Checks to make sure that the user doesn't accidentally close the application.
                var res = MessageBox.Show(this, "Are you sure that you want to quit?", "Exit",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    e.Cancel = true;
                    timer.Interval = 6000;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    //Says goodbye to the user.
                    ExitForm exitForm = new ExitForm();
                    exitForm.Show();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        bool closeApp = true;

        void timer_Tick(object sender, EventArgs e)
        {
            closeApp = false;
            Application.Exit();     
        }
    }
}
