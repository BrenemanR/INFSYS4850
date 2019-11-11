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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void lbl_Customers_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_Customer_Click(object sender, EventArgs e)
        {

        }
    }
}
