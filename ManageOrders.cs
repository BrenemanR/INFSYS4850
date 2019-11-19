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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        private MainPage mainPage;

        public ManageOrders(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
    

        private void ManageOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Allows the user to re-open the form once it's closed.
            mainPage.Controls["btn_ManageOrdersOpened"].Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData1.ORDERSTATUS' table. You can move, or remove it, as needed.
            this.oRDERSTATUSTableAdapter.Fill(this.appData1.ORDERSTATUS);
            // TODO: This line of code loads data into the 'appData1.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.appData1.CUSTOMER);
            // TODO: This line of code loads data into the 'appData1.INVOICE' table. You can move, or remove it, as needed.
            this.iNVOICETableAdapter.Fill(this.appData1.INVOICE);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            this.appData1.INVOICE.AddINVOICERow(this.appData1.INVOICE.NewINVOICERow());
            iNVOICEBindingSource.RemoveSort();
            iNVOICEBindingSource.MoveLast();
            cUSTOMERTableAdapter.Update(this.appData1.CUSTOMER);
            iNVOICETableAdapter.Update(this.appData1.INVOICE);
            //iNVOICETableAdapter.Insert(this.appData1.INVOICE);
         
        }

        private void lbl_Status_Click(object sender, EventArgs e)
        {

        }
    }
}
