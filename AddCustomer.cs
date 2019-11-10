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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(SearchBox.Text))
                {
                    this.cUSTOMERTableAdapter.Fill(this.appData.CUSTOMER);
                    cUSTOMERBindingSource.DataSource = this.appData.CUSTOMER;
                    //dataGridView1.DataSource = cUSTOMERBindingSource;
                }
                else
                {
                    //Add the other search fields once we know everything is working.
                    var query = from o in this.appData.CUSTOMER
                                where o.CUST_FNAME.Contains(SearchBox.Text) || o.CUST_LNAME.Contains(SearchBox.Text) || o.CUST_PHONE == SearchBox.Text || o.CUST_EMAIL == SearchBox.Text
                                select o;
                    cUSTOMERBindingSource.DataSource = query.ToList();
                    //dataGridView1.DataSource = query.ToList();
                }

            }
        }

            private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    cUSTOMERBindingSource.RemoveCurrent();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                FirstNameBox.Focus();
                this.appData.CUSTOMER.AddCUSTOMERRow(this.appData.CUSTOMER.NewCUSTOMERRow());
                cUSTOMERBindingSource.MoveLast();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cUSTOMERBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            FirstNameBox.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            cUSTOMERBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                    cUSTOMERBindingSource.EndEdit();
                    cUSTOMERTableAdapter.Update(this.appData.CUSTOMER);
                    panel1.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cUSTOMERBindingSource.ResetBindings(false);
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.appData.CUSTOMER);
            cUSTOMERBindingSource.DataSource = this.appData.CUSTOMER;

        }
    }
}
