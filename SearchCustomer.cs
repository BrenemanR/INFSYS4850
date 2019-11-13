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
    public partial class SearchCustomer : Form
    {
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void SearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(SearchField.Text))
                {
                    this.cUSTOMERTableAdapter.Fill(this.appData.CUSTOMER);
                    cUSTOMERBindingSource.DataSource = this.appData.CUSTOMER;
                    //dataGridView1.DataSource = cUSTOMERBindingSource;
                }
                else
                {
                    //Add the other search fields once we know everything is working.
                    var query = from o in this.appData.CUSTOMER
                                where o.CUST_FNAME.Contains(SearchField.Text) || o.CUST_LNAME.Contains(SearchField.Text) || o.CUST_PHONE == SearchField.Text || o.CUST_EMAIL == SearchField.Text 
                                || o.CUST_ADDRESS.Contains(SearchField.Text) || o.CUST_CITY.Contains(SearchField.Text) || o.CUST_COMPANY.Contains(SearchField.Text) || o.CUST_STATE.Contains(SearchField.Text)
                                || o.CUST_ZIP.Equals(SearchField.Text)
                                select o;
                    cUSTOMERBindingSource.DataSource = query.ToList();
                    //dataGridView1.DataSource = query.ToList();
                }

            }
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.appData.CUSTOMER);
            cUSTOMERBindingSource.DataSource = this.appData.CUSTOMER;

        }
    }
}
