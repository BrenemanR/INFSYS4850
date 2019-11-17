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
    public partial class ManageCustomers : Form
    {
        bool isSaved = true;
        
        public ManageCustomers()
        {
            InitializeComponent();
        }
        private MainPage mainPage;
        public ManageCustomers(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
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
                                where o.CUST_FNAME.Contains(SearchBox.Text) || o.CUST_LNAME.Contains(SearchBox.Text) || o.CUST_PHONE == SearchBox.Text || o.CUST_EMAIL == SearchBox.Text || o.CUST_ADDRESS.Contains(SearchBox.Text)
                                || o.CUST_CITY.Contains(SearchBox.Text) || o.CUST_COMPANY.Contains(SearchBox.Text) || o.CUST_STATE.Contains(SearchBox.Text) || o.CUST_ZIP.Equals(SearchBox.Text)
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
                if (MessageBox.Show("Are you sure you want to delete this record? Record will not be deleted unitl the save button is pressed.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    cUSTOMERBindingSource.RemoveCurrent();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Opens the CreateCustomer form. Currently not being used
            CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.Show();
            //Need to prevents the user from opening the form multiple times.
              
            try
            {
                panel1.Enabled = true;
                btnEdit.Enabled = false; //Disables the edit button so the user is unable to edit a record while one is already open.
                btnNew.Enabled = false; //Disables the new button so the user is unable to create a new record while already adding one.
                FirstNameBox.Focus();
                this.appData.CUSTOMER.AddCUSTOMERRow(this.appData.CUSTOMER.NewCUSTOMERRow());
                cUSTOMERBindingSource.MoveLast();
                isSaved = false;
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
            btnNew.Enabled = false; //Disables the new button so the user is unable to create a new record while editing a previous one.
            FirstNameBox.Focus();
            isSaved = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true; //Reenables the Edit Button After a new record is cancelled.
            btnNew.Enabled = true;  //Reenables the New Button After an edit is cancelled.
            panel1.Enabled = false;
            cUSTOMERBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                    cUSTOMERBindingSource.EndEdit();
                if (string.IsNullOrEmpty(FirstNameBox.Text))
                {

                    MessageBox.Show(FirstNameBox.Text, "First name cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnNew.Enabled = false;
                    panel1.Enabled = true;

                }

                if (EmailBox.Text.Length == 0) //Checks to see if the email address field is blank
                {
                    MessageBox.Show(EmailBox.Text, "Email Address cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnNew.Enabled = false;
                    panel1.Enabled = true;

                }
                
                
                if (!EmailBox.Text.Contains("@")) //Check to see if the email address contains an '@' symbol.
                {
                    MessageBox.Show(EmailBox.Text, "INVALID EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnNew.Enabled = false;
                    panel1.Enabled = true;

                }




                else
                {
                    cUSTOMERTableAdapter.Update(this.appData.CUSTOMER);
                    btnEdit.Enabled = true; //Reenables the Edit Button After a new record is saved.
                    btnNew.Enabled = true;  //Reenables the New Button After an edit is saved.
                    panel1.Enabled = false;
                    isSaved = true;
                }

                
                


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

        private void ZipBox_KeyPress(object sender, KeyPressEventArgs z)
        {
            //This is the method that makes it so that only digits can be entered in the Zip Code Field
            if (!char.IsControl(z.KeyChar) && !char.IsDigit(z.KeyChar) && (z.KeyChar != '.'))
            {
                z.Handled = true;
            }

            if (ZipBox.Text.Length >= 5)
            {
                z.Handled = true;
            }

        }

        
        private void ManageCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Allows the user to re-open the form once it's closed.
            mainPage.Controls["btn_ManageCustomersOpened"].Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cUSTOMERBindingSource.EndEdit();
                if (string.IsNullOrEmpty(FirstNameBox.Text))
                {

                    MessageBox.Show(FirstNameBox.Text, "First name cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnNew.Enabled = false;
                    panel1.Enabled = true;

                }
                else
                {
                    cUSTOMERTableAdapter.Update(this.appData.CUSTOMER);
                    btnEdit.Enabled = true; //Reenables the Edit Button After a new record is saved.
                    btnNew.Enabled = true;  //Reenables the New Button After an edit is saved.
                    panel1.Enabled = false;
                    isSaved = true;
                }

                btnEdit.Enabled = true; //Reenables the Edit Button After a new record is saved.
                                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cUSTOMERBindingSource.ResetBindings(false);
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit Manage Customers?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("There might be unsaved changes. Would you like to save?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //saves then closes the form
                    try
                    {
                        cUSTOMERBindingSource.EndEdit();
                        if (string.IsNullOrEmpty(FirstNameBox.Text))
                        {

                            MessageBox.Show(FirstNameBox.Text, "First name cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnNew.Enabled = false;
                            panel1.Enabled = true;

                        }
                        else
                        {
                            cUSTOMERTableAdapter.Update(this.appData.CUSTOMER);
                            btnEdit.Enabled = true; //Reenables the Edit Button After a new record is saved.
                            btnNew.Enabled = true;  //Reenables the New Button After an edit is saved.
                            panel1.Enabled = false;
                            isSaved = true;
                            MessageBox.Show("Your data has been saved.");
                            this.Close();
                        }

                        btnEdit.Enabled = true; //Reenables the Edit Button After a new record is saved.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cUSTOMERBindingSource.ResetBindings(false);
                    }
                    
                    
                }
                
                else if (dialogResult == DialogResult.No)
                {
                    //closes the form without saving
                    this.Close();
                }
            }
            
            
        }

        private void PhoneNumberBox_KeyPress(object sender, KeyPressEventArgs e) //Ensures that the user is only able to enter in 10 digits for the phonen number field.
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                // is a digit or backspace - ignore digits if length is alreay 10 - allow backspace
                if (Char.IsDigit(e.KeyChar))
                {
                    if (PhoneNumberBox.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e) //Ensures that the user is only able to enter in Letters for the first name field.
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (int)(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e) //Ensures that the user is only able to enter in Letters for the first name field.
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (int)(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
