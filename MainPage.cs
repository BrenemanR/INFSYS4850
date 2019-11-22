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
        bool isSaved = true;
                
        public MainPage()
        {
            InitializeComponent();
            
        }
        /*private MainPage mainPage;
        public ManageCustomers(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }*/


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
            //CreateCustomer createCustomer = new CreateCustomer();
            //createCustomer.Show();
            //Need to prevents the user from opening the form multiple times.


            dataGridView1.Enabled = false;
            btnCancel.Enabled = false;
            SearchBox.Enabled = false;

            try
            {
                {
                    panel1.Enabled = true;
                    btnEdit.Enabled = false; //Disables the edit button so the user is unable to edit a record while one is already open.
                    btnNew.Enabled = false; //Disables the new button so the user is unable to create a new record while already adding one.
                    FirstNameBox.Focus();
                    this.appData.CUSTOMER.AddCUSTOMERRow(this.appData.CUSTOMER.NewCUSTOMERRow());
                    cUSTOMERBindingSource.RemoveSort(); //Resorts The table so that the new record is properly added.
                    cUSTOMERBindingSource.MoveLast();
                    isSaved = false;
                }

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
            dataGridView1.Enabled = true;
            cUSTOMERBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*bool dataFilled = false;
            while (dataFilled == false)
            {*/
            
                try
                {
                    cUSTOMERBindingSource.EndEdit();
                    if (string.IsNullOrEmpty(FirstNameBox.Text))
                    {
                        //MessageBox.Show(FirstNameBox.Text, "First name cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbl_RequiredField.Visible = true;
                        FirstNameLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }

                    if (string.IsNullOrEmpty(EmailBox.Text)) //Checks to see if the email address field is blank
                    {
                        //MessageBox.Show(EmailBox.Text, "Email Address cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbl_RequiredField.Visible = true;
                        EmailLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }          
                    if (string.IsNullOrEmpty(LastNameBox.Text))
                    {
                        lbl_RequiredField.Visible = true;
                        LastNameLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }
                    if (string.IsNullOrEmpty(PhoneNumberBox.Text))
                    {
                        lbl_RequiredField.Visible = true;
                        PhoneLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }
                    if (string.IsNullOrEmpty(CompanyBox.Text))
                    {
                        lbl_RequiredField.Visible = true;
                        CompanyLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }
                    if (string.IsNullOrEmpty(AddressBox.Text))
                    {
                        lbl_RequiredField.Visible = true;
                        AddressLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }
                    if (string.IsNullOrEmpty(CityBox.Text))
                    {
                        lbl_RequiredField.Visible = true;
                        CityLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }
                    if (string.IsNullOrEmpty(StateBox.Text))
                    {
                        lbl_RequiredField.Visible = true;
                        StateLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }
                    if (string.IsNullOrEmpty(ZipBox.Text))
                    {
                        lbl_RequiredField.Visible = true;
                        ZipLabel.ForeColor = System.Drawing.Color.Red;
                        btnNew.Enabled = false;
                        panel1.Enabled = true;
                    }

                    else
                    {
                        if (!Regex.IsMatch(EmailBox.Text, ".+@.+\\..+")) //Check to see if the email address is properly formatted.
                        {
                            MessageBox.Show(EmailBox.Text + " is not a valid email address. Email addresses must take the form xxxx@xxxx.xxx", "INVALID EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EmailLabel.ForeColor = System.Drawing.Color.Red;
                            lbl_RequiredField.Visible = true;
                            btnNew.Enabled = false;
                            panel1.Enabled = true;
                            FirstNameLabel.ForeColor = System.Drawing.Color.Black;
                            LastNameLabel.ForeColor = System.Drawing.Color.Black;
                            PhoneLabel.ForeColor = System.Drawing.Color.Black;
                            CompanyLabel.ForeColor = System.Drawing.Color.Black;
                            AddressLabel.ForeColor = System.Drawing.Color.Black;
                            CityLabel.ForeColor = System.Drawing.Color.Black;
                            StateLabel.ForeColor = System.Drawing.Color.Black;
                            ZipLabel.ForeColor = System.Drawing.Color.Black;
                        }
                        else
                        {
                            cUSTOMERTableAdapter.Update(this.appData.CUSTOMER);
                            lbl_RequiredField.Visible = false;
                            btnEdit.Enabled = true; //Reenables the Edit Button After a new record is saved.
                            btnNew.Enabled = true;  //Reenables the New Button After an edit is saved.
                            panel1.Enabled = false;
                            dataGridView1.Enabled = true;
                            SearchBox.Enabled = true;
                            isSaved = true;
                            FirstNameLabel.ForeColor = System.Drawing.Color.Black;
                            LastNameLabel.ForeColor = System.Drawing.Color.Black;
                            PhoneLabel.ForeColor = System.Drawing.Color.Black;
                            EmailLabel.ForeColor = System.Drawing.Color.Black;
                            CompanyLabel.ForeColor = System.Drawing.Color.Black;
                            AddressLabel.ForeColor = System.Drawing.Color.Black;
                            CityLabel.ForeColor = System.Drawing.Color.Black;
                            StateLabel.ForeColor = System.Drawing.Color.Black;
                            ZipLabel.ForeColor = System.Drawing.Color.Black;
                            //dataFilled = true;
                        }

                    }

                }
            

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cUSTOMERBindingSource.ResetBindings(false);
                }
            //} this bracket is for the while statement that's commented out above
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.ORDERSTATUS' table. You can move, or remove it, as needed.
            this.oRDERSTATUSTableAdapter.Fill(this.appData.ORDERSTATUS);
            // TODO: This line of code loads data into the 'appData.INVOICE' table. You can move, or remove it, as needed.
            this.iNVOICETableAdapter.Fill(this.appData.INVOICE);
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
            //mainPage.Controls["btn_ManageCustomersOpened"].Visible = false;
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

        private void ManageCustomers_FormClosing(object sender, FormClosingEventArgs e)
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
                    timer.Tick += new EventHandler(Timer_Tick);
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

        void Timer_Tick(object sender, EventArgs e)
        {
            closeApp = false;
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            tab_Container.Enabled = true;

        }

       

        private void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            /*this.appData.CUSTOMER.AddCUSTOMERRow(this.appData.CUSTOMER.NewCUSTOMERRow());
            cUSTOMERBindingSource.RemoveSort(); //Resorts The table so that the new record is properly added.
            cUSTOMERBindingSource.MoveLast();
            isSaved = false;
            */


            this.appData.INVOICE.AddINVOICERow(this.appData.INVOICE.NewINVOICERow());
            iNVOICEBindingSource.RemoveSort();
            iNVOICEBindingSource.MoveLast();

            btn_CreateOrder.Enabled = false;
            combobox_CustomerIDZ.Enabled = true;
            BookDatePicker.Enabled = true;
            PickUpDatePicker.Enabled = true;
            DropOffDatePicker.Enabled = true;
            combobox_OrderStatus.Enabled = true;
            checkBox_CopyPickupInformation.Enabled = true;
            checkBox_CopyDropoffInformation.Enabled = true;
            txtbox_PickupAddress.Enabled = true;
            txtbox_PickupCity.Enabled = true;
            txtbox_PickupState.Enabled = true;
            txtbox_PickupZip.Enabled = true;
            txtbox_DeliveryAddress.Enabled = true;
            txtbox_DeliveryCity.Enabled = true;
            txtbox_DeliveryState.Enabled = true;
            txtbox_DeliveryZip.Enabled = true;

            btn_SaveOrder.Enabled = true;

        }

        private void btn_SaveOrder_Click(object sender, EventArgs e)
        {
            //this.cUSTOMERTableAdapter.Fill(this.appData.CUSTOMER);

            
            iNVOICETableAdapter.Insert(BookDatePicker.Value, PickUpDatePicker.Value, DropOffDatePicker.Value, combobox_CustomerIDZ.SelectedIndex+1, combobox_OrderStatus.Text, 
                txtbox_PickupAddress.Text, txtbox_PickupCity.Text, txtbox_PickupState.Text, txtbox_PickupZip.Text, 
                txtbox_DeliveryAddress.Text, txtbox_DeliveryCity.Text, txtbox_DeliveryState.Text,txtbox_DeliveryZip.Text, txtboxrch_SpecialInstructions.Text, txtboxrch_Description.Text);

            this.iNVOICETableAdapter.Fill(this.appData.INVOICE);
            iNVOICETableAdapter.Update(this.appData.INVOICE);

            btn_CreateOrder.Enabled = true;

            combobox_CustomerIDZ.Enabled = false;
            BookDatePicker.Enabled = false;
            PickUpDatePicker.Enabled = false;
            DropOffDatePicker.Enabled = false;
            combobox_OrderStatus.Enabled = false;
            checkBox_CopyPickupInformation.Enabled = false;
            checkBox_CopyDropoffInformation.Enabled = false;
            txtbox_PickupAddress.Enabled = false;
            txtbox_PickupCity.Enabled = false;
            txtbox_PickupState.Enabled = false;
            txtbox_PickupZip.Enabled = false;
            txtbox_DeliveryAddress.Enabled = false;
            txtbox_DeliveryCity.Enabled = false;
            txtbox_DeliveryState.Enabled = false;
            txtbox_DeliveryZip.Enabled = false;

            btn_SaveOrder.Enabled = false;

            
        }

        
        private void CopyAddressToPickup_Click(object sender, EventArgs e)
        {
            txtbox_PickupAddress.Text = txtbox_Address.Text;
            txtbox_PickupCity.Text = txtbox_City.Text;
            txtbox_PickupState.Text = txtbox_State.Text;
            txtbox_PickupZip.Text = txtbox_Zip.Text;
        }

        private void btn_CopyDropOffAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            txtbox_DeliveryAddress.Text = txtbox_Address.Text;
            txtbox_DeliveryCity.Text = txtbox_City.Text;
            txtbox_DeliveryState.Text = txtbox_State.Text;
            txtbox_DeliveryZip.Text = txtbox_Zip.Text;
            */
        }

        private void btn_CopyDropOffAddress_CheckedChanged(object sender, EventArgs e)
        {
            /*
            txtbox_DeliveryAddress.Text = txtbox_Address.Text;
            txtbox_DeliveryCity.Text = txtbox_City.Text;
            txtbox_DeliveryState.Text = txtbox_State.Text;
            txtbox_DeliveryZip.Text = txtbox_Zip.Text;
            */
        }

        private void btn_CopyDropOffAddress_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox_CopyDropoffInformation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CopyDropoffInformation.Checked)
            {
                txtbox_DeliveryAddress.Text = txtbox_Address.Text;
                txtbox_DeliveryCity.Text = txtbox_City.Text;
                txtbox_DeliveryState.Text = txtbox_State.Text;
                txtbox_DeliveryZip.Text = txtbox_Zip.Text;
            }

            if (checkBox_CopyDropoffInformation.Checked == false)
            {
                txtbox_DeliveryAddress.Text = "";
                txtbox_DeliveryCity.Text = "";
                txtbox_DeliveryState.Text = "";
                txtbox_DeliveryZip.Text = "";
            }
        }

        private void checkBox_CopyPickupInformation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CopyPickupInformation.Checked)
            {
                txtbox_PickupAddress.Text = txtbox_Address.Text;
                txtbox_PickupCity.Text = txtbox_City.Text;
                txtbox_PickupState.Text = txtbox_State.Text;
                txtbox_PickupZip.Text = txtbox_Zip.Text;
            }

            if (checkBox_CopyPickupInformation.Checked == false)
            {
                txtbox_PickupAddress.Text = "";
                txtbox_PickupCity.Text = "";
                txtbox_PickupState.Text = "";
                txtbox_PickupZip.Text = "";
            }
        }
    }

}
