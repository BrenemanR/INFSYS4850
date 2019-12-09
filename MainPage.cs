using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class MainPage : Form
    {
        bool CustomerisSaved = true;
        bool CreateOrderisSaved = true;
        bool EditOrderisSaved = true;
        bool VehicleisSaved = true;
        bool editCustomer = false;
                
        public MainPage()
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
                                where 
                                o.CUST_FNAME.Equals(SearchBox.Text, StringComparison.OrdinalIgnoreCase) || 
                                o.CUST_FNAME.Contains(SearchBox.Text) || 
                                o.CUST_LNAME.Equals(SearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                o.CUST_LNAME.Contains(SearchBox.Text) || 
                                o.CUST_PHONE == SearchBox.Text ||
                                o.CUST_EMAIL == SearchBox.Text || 
                                o.CUST_ADDRESS.Equals(SearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                o.CUST_ADDRESS.Contains(SearchBox.Text) ||
                                o.CUST_CITY.Equals(SearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                o.CUST_CITY.Contains(SearchBox.Text) ||
                                o.CUST_COMPANY.Equals(SearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                o.CUST_COMPANY.Contains(SearchBox.Text) || 
                                o.CUST_STATE.Equals(SearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                o.CUST_STATE.Contains(SearchBox.Text) || 
                                o.CUST_ZIP.Equals(SearchBox.Text) ||
                                o.BROKER.Equals(SearchBox.Text) 
                                select o;
                    cUSTOMERBindingSource.DataSource = query.ToList();
                    //dataGridView1.DataSource = query.ToList();
                }

            }
        }

           
        private void btnNew_Click(object sender, EventArgs e)
        {

            dataGridView1.Enabled = false;
            btnCancel.Enabled = true;
            SearchBox.Enabled = false;
            btnSave.Enabled = true;
            editCustomer = false;
            comboBox_AccountStatus.Enabled = true;
            comboBox_Broker.Enabled = true;

            //radButt_No.Checked = true;
            try
            {
                {
                    //panel1.Enabled = true;
                    FirstNameBox.ReadOnly = false;
                    LastNameBox.ReadOnly = false;
                    EmailBox.ReadOnly = false;
                    PhoneNumberBox.ReadOnly = false;
                    CompanyBox.ReadOnly = false;
                    AddressBox.ReadOnly = false;
                    CityBox.ReadOnly = false;
                    StateBox.ReadOnly = false;
                    ZipBox.ReadOnly = false;
                   

                    btnEdit.Enabled = false; //Disables the edit button so the user is unable to edit a record while one is already open.
                    btnNew.Enabled = false; //Disables the new button so the user is unable to create a new record while already adding one.

                    this.cUSTOMERTableAdapter.Fill(this.appData.CUSTOMER);
                    cUSTOMERBindingSource.DataSource = this.appData.CUSTOMER;
                    FirstNameBox.Focus();
                    
                    this.appData.CUSTOMER.AddCUSTOMERRow(this.appData.CUSTOMER.NewCUSTOMERRow());
                    cUSTOMERBindingSource.RemoveSort(); //Resorts The table so that the new record is properly added.
                    cUSTOMERBindingSource.MoveLast();
                    comboBox_Broker.Text = "NO";
                    comboBox_AccountStatus.Text = "ACTIVE";
                    //comboBox_Broker.SelectedIndex = 1;
                    CustomerisSaved = false;
                    
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
            if (FirstNameBox.Text == "")
            {
                MessageBox.Show("Please select a customer to edit.", "NO CUSTOMER SELECTED");
                SearchBox.Text = "";
                SendKeys.Send("{ENTER}");
                SearchBox.Focus();
            }
            else
            {
                //panel1.Enabled = true;
                FirstNameBox.ReadOnly = false;
                LastNameBox.ReadOnly = false;
                EmailBox.ReadOnly = false;
                PhoneNumberBox.ReadOnly = false;
                CompanyBox.ReadOnly = false;
                AddressBox.ReadOnly = false;
                CityBox.ReadOnly = false;
                StateBox.ReadOnly = false;
                ZipBox.ReadOnly = false;
                btnNew.Enabled = false; //Disables the new button so the user is unable to create a new record while editing a previous one.
                btnEdit.Enabled = true;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
                dataGridView1.Enabled = false;
                FirstNameBox.Focus();
                CustomerisSaved = false;
                btnEdit.Enabled = false;
                editCustomer = true;
                comboBox_AccountStatus.Enabled = true;
                comboBox_Broker.Enabled = true;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (editCustomer == true)
            {
                btnEdit.Enabled = true; //Reenables the Edit Button After a new record is cancelled.
                btnNew.Enabled = true;  //Reenables the New Button After an edit is cancelled.
                btnSave.Enabled = false; //Disables the Save Button After an edit is cancelled.
                btnCancel.Enabled = false; //Disables the Cancel Button After an edit is cancelled.
                editCustomer = false;
                //panel1.Enabled = false;
                FirstNameBox.ReadOnly = true;
                LastNameBox.ReadOnly = true;
                EmailBox.ReadOnly = true;
                PhoneNumberBox.ReadOnly = true;
                CompanyBox.ReadOnly = true;
                AddressBox.ReadOnly = true;
                CityBox.ReadOnly = true;
                StateBox.ReadOnly = true;
                ZipBox.ReadOnly = true;
                dataGridView1.Enabled = true;
                SearchBox.Enabled = true;
                //cUSTOMERBindingSource.RemoveCurrent();
                cUSTOMERBindingSource.CancelEdit();
                lbl_RequiredField.Visible = false;

                //Resets all of the text to black in case the user originally entered in mistakes.
                FirstNameLabel.ForeColor = System.Drawing.Color.LightGray;
                LastNameLabel.ForeColor = System.Drawing.Color.LightGray;
                PhoneLabel.ForeColor = System.Drawing.Color.LightGray;
                EmailLabel.ForeColor = System.Drawing.Color.LightGray;
                CompanyLabel.ForeColor = System.Drawing.Color.LightGray;
                AddressLabel.ForeColor = System.Drawing.Color.LightGray;
                CityLabel.ForeColor = System.Drawing.Color.LightGray;
                StateLabel.ForeColor = System.Drawing.Color.LightGray;
                ZipLabel.ForeColor = System.Drawing.Color.LightGray;
                lbl_Broker.ForeColor = System.Drawing.Color.LightGray;
                CustomerisSaved = true;
                comboBox_Broker.Enabled = false;
                comboBox_AccountStatus.Enabled = false;
            }
            else //(editCustomer == false)
            {
                btnEdit.Enabled = true; //Reenables the Edit Button After a new record is cancelled.
                btnNew.Enabled = true;  //Reenables the New Button After an edit is cancelled.
                btnSave.Enabled = false; //Disables the Save Button After an edit is cancelled.
                btnCancel.Enabled = false; //Disables the Cancel Button After an edit is cancelled.
                //panel1.Enabled = false;
                FirstNameBox.ReadOnly = true;
                LastNameBox.ReadOnly = true;
                EmailBox.ReadOnly = true;
                PhoneNumberBox.ReadOnly = true;
                CompanyBox.ReadOnly = true;
                AddressBox.ReadOnly = true;
                CityBox.ReadOnly = true;
                StateBox.ReadOnly = true;
                ZipBox.ReadOnly = true;
                dataGridView1.Enabled = true;
                SearchBox.Enabled = true;
                editCustomer = false;
                lbl_RequiredField.Visible = false;
                //SearchBox.Text = "";
                cUSTOMERBindingSource.CancelEdit();
                cUSTOMERBindingSource.RemoveCurrent();


                //Resets all of the text to black in case the user originally entered in mistakes.
                FirstNameLabel.ForeColor = System.Drawing.Color.LightGray;
                LastNameLabel.ForeColor = System.Drawing.Color.LightGray;
                PhoneLabel.ForeColor = System.Drawing.Color.LightGray;
                EmailLabel.ForeColor = System.Drawing.Color.LightGray;
                CompanyLabel.ForeColor = System.Drawing.Color.LightGray;
                AddressLabel.ForeColor = System.Drawing.Color.LightGray;
                CityLabel.ForeColor = System.Drawing.Color.LightGray;
                StateLabel.ForeColor = System.Drawing.Color.LightGray;
                ZipLabel.ForeColor = System.Drawing.Color.LightGray;
                CustomerisSaved = true;
                comboBox_Broker.Enabled = false;
                comboBox_AccountStatus.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool noFName = false, noLName = false, noPhone = false, noEmail = false, noCompany = false, noAddress = false, noCity = false, noState = false, noZip = false, noBroke = false, noAccountStatus = false, less20 = false, less50=false;
            try
            {
                FirstNameLabel.ForeColor = System.Drawing.Color.LightGray;
                LastNameLabel.ForeColor = System.Drawing.Color.LightGray;
                PhoneLabel.ForeColor = System.Drawing.Color.LightGray;
                EmailLabel.ForeColor = System.Drawing.Color.LightGray;
                CompanyLabel.ForeColor = System.Drawing.Color.LightGray;
                AddressLabel.ForeColor = System.Drawing.Color.LightGray;
                CityLabel.ForeColor = System.Drawing.Color.LightGray;
                StateLabel.ForeColor = System.Drawing.Color.LightGray;
                ZipLabel.ForeColor = System.Drawing.Color.LightGray;
                lbl_Broker.ForeColor = System.Drawing.Color.LightGray;
                lbl_Status.ForeColor = System.Drawing.Color.LightGray;
                btnNew.Enabled = false;


                if (string.IsNullOrEmpty(FirstNameBox.Text))
                {
                    lbl_RequiredField.Visible = true;
                    FirstNameLabel.ForeColor = System.Drawing.Color.LightCoral;
                    noFName = true;
                }                              
                if (string.IsNullOrEmpty(LastNameBox.Text))
                {
                    lbl_RequiredField.Visible = true;
                    LastNameLabel.ForeColor = System.Drawing.Color.LightCoral;
                    noLName = true;
                }
                if (string.IsNullOrEmpty(EmailBox.Text)) //Checks to see if the email address field is blank
                {
                    lbl_RequiredField.Visible = true;
                    EmailLabel.ForeColor = System.Drawing.Color.LightCoral;
                    noEmail = true;
                }
                if (string.IsNullOrEmpty(PhoneNumberBox.Text))
                {
                    lbl_RequiredField.Visible = true;
                    PhoneLabel.ForeColor = System.Drawing.Color.LightCoral;
                    noPhone = true;
                }
                if (string.IsNullOrEmpty(CompanyBox.Text))
                {
                    lbl_RequiredField.Visible = true;
                    CompanyLabel.ForeColor = System.Drawing.Color.LightCoral; 
                    noCompany = true;
                }
                if (string.IsNullOrEmpty(AddressBox.Text))
                {
                    lbl_RequiredField.Visible = true;
                    AddressLabel.ForeColor = System.Drawing.Color.LightCoral;
                    noAddress = true;
                }
                if (string.IsNullOrEmpty(CityBox.Text))
                {
                    lbl_RequiredField.Visible = true;
                    CityLabel.ForeColor = System.Drawing.Color.LightCoral;
                    noCity = true;
                }
                if (string.IsNullOrEmpty(StateBox.Text))
                {
                    lbl_RequiredField.Visible = true;
                    StateLabel.ForeColor = System.Drawing.Color.LightCoral;
                    noState = true;
                }
                if (string.IsNullOrEmpty(ZipBox.Text))
                {
                    lbl_RequiredField.Visible = true;
                    ZipLabel.ForeColor = System.Drawing.Color.LightCoral;
                    noZip = true;
                }
                if (string.IsNullOrEmpty(comboBox_Broker.Text))
                {
                    lbl_RequiredField.Visible = true;
                    lbl_Broker.ForeColor = System.Drawing.Color.LightCoral;
                    noBroke = true;
                }
                if (string.IsNullOrEmpty(comboBox_AccountStatus.Text))
                {
                    lbl_RequiredField.Visible = true;
                    lbl_Status.ForeColor = System.Drawing.Color.LightCoral;
                    noAccountStatus = true;
                }
                
                if (FirstNameBox.TextLength > 20)
                {
                    FirstNameLabel.ForeColor = System.Drawing.Color.LightCoral;
                    less20 = true;
                }
                if (LastNameBox.TextLength > 20)
                {
                    LastNameLabel.ForeColor = System.Drawing.Color.LightCoral;
                    less20 = true;
                }
                if (EmailBox.TextLength > 50)
                {
                    EmailLabel.ForeColor = System.Drawing.Color.LightCoral;
                    less50 = true;
                }
                if (CompanyBox.TextLength > 50)
                {
                    CompanyLabel.ForeColor = System.Drawing.Color.LightCoral;
                    less50 = true;
                }
                if (AddressBox.TextLength > 50)
                {
                    AddressLabel.ForeColor = System.Drawing.Color.LightCoral;
                    less50 = true;
                }
                if (CityBox.TextLength > 20)
                {
                    CityLabel.ForeColor = System.Drawing.Color.LightCoral;
                    less20 = true;
                }
                if (StateBox.TextLength > 20)
                {
                    StateLabel.ForeColor = System.Drawing.Color.LightCoral;
                    less20 = true;
                }


                if (!noFName && !noLName && !noPhone && !noEmail && !noCompany && !noAddress && !noCity && !noState && !noZip &&!noBroke &&!noAccountStatus)
                {
                    if (!Regex.IsMatch(PhoneNumberBox.Text, "[0-9]{3}[0-9]{3}[0-9]{4}")) //Check to see if the phone number is properly formatted.
                    {
                        PhoneLabel.ForeColor = System.Drawing.Color.LightCoral;
                        lbl_RequiredField.Visible = true;
                        noPhone = true;
                    }
                    if (!Regex.IsMatch(EmailBox.Text, ".+@.+\\..+")) //Check to see if the email address is properly formatted.
                    {
                        EmailLabel.ForeColor = System.Drawing.Color.LightCoral;
                        lbl_RequiredField.Visible = true;
                        noEmail = true;
                    }
                    if (!Regex.IsMatch(ZipBox.Text, "[0-9]{5}")) //Check to see if the phone number is properly formatted.
                    {
                        ZipLabel.ForeColor = System.Drawing.Color.LightCoral;
                        lbl_RequiredField.Visible = true;
                        noZip = true;
                    }
                    if (comboBox_Broker.Text != "YES" && comboBox_Broker.Text != "NO")
                    {
                        lbl_Broker.ForeColor = System.Drawing.Color.LightCoral;
                        lbl_RequiredField.Visible = true;
                        noBroke = true;
                    }
                    if (comboBox_AccountStatus.Text != "ACTIVE" && comboBox_AccountStatus.Text != "INACTIVE")
                    {
                        lbl_Status.ForeColor = System.Drawing.Color.LightCoral;
                        lbl_RequiredField.Visible = true;
                        noAccountStatus = true;
                    }
                    
                    if (!noPhone && !noEmail && !noZip && !noBroke && !noAccountStatus &&!less20 &&!less50)
                    {
                        cUSTOMERBindingSource.EndEdit();
                        cUSTOMERTableAdapter.Update(appData.CUSTOMER);

                        lbl_RequiredField.Visible = false;
                        btnEdit.Enabled = true; //Reenables the Edit Button After a new record is saved.
                        btnNew.Enabled = true;  //Reenables the New Button After an edit is saved.
                                                //panel1.Enabled = false;
                        FirstNameBox.ReadOnly = true;
                        LastNameBox.ReadOnly = true;
                        EmailBox.ReadOnly = true;
                        PhoneNumberBox.ReadOnly = true;
                        CompanyBox.ReadOnly = true;
                        AddressBox.ReadOnly = true;
                        CityBox.ReadOnly = true;
                        StateBox.ReadOnly = true;
                        ZipBox.ReadOnly = true;
                        dataGridView1.Enabled = true;
                        SearchBox.Enabled = true;
                        CustomerisSaved = true;
                        btnSave.Enabled = false;
                        btnCancel.Enabled = false;
                        comboBox_Broker.Enabled = false;
                        comboBox_AccountStatus.Enabled = false;


                        //Turns all of the text back to LightGray after a successful submission.
                        FirstNameLabel.ForeColor = System.Drawing.Color.LightGray;
                        LastNameLabel.ForeColor = System.Drawing.Color.LightGray;
                        PhoneLabel.ForeColor = System.Drawing.Color.LightGray;
                        EmailLabel.ForeColor = System.Drawing.Color.LightGray;
                        CompanyLabel.ForeColor = System.Drawing.Color.LightGray;
                        AddressLabel.ForeColor = System.Drawing.Color.LightGray;
                        CityLabel.ForeColor = System.Drawing.Color.LightGray;
                        StateLabel.ForeColor = System.Drawing.Color.LightGray;
                        ZipLabel.ForeColor = System.Drawing.Color.LightGray;
                        lbl_Broker.ForeColor = System.Drawing.Color.LightGray;
                        lbl_Status.ForeColor = System.Drawing.Color.LightGray;
                    }
                    //insert error messages here
                    if (less20)
                    {
                        MessageBox.Show("The following fields cannot exceed 20 characters.\n\nFirst Name\nLast Name\nCity\nState", "INVALID ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (less50)
                    {
                        MessageBox.Show("The following fields cannot exceed 50 characters.\n\nEmail\nCompany\nAddress", "INVALID ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noPhone)
                    {
                        MessageBox.Show(PhoneNumberBox.Text + " is not a valid phone number. Please enter in 10 digits.", "INVALID Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noEmail)
                    {
                        MessageBox.Show(EmailBox.Text + " is not a valid email address. Email addresses must take the form xxxx@xxxx.xxx", "INVALID EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noZip)
                    {
                        MessageBox.Show(ZipBox.Text + " is not a valid Zip Code. Zip Codes must contain 5 digits.", "INVALID ZIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noBroke)
                    {
                        MessageBox.Show("Broker must either be YES or NO.", "INVALID ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noAccountStatus)
                    {
                        MessageBox.Show("Account Status must either be ACTIVE or INACTIVE.", "INVALID ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter in the required fields.", "INVALID ENTRY", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // TODO: This line of code loads data into the 'appData.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.appData.VEHICLE);
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
            /*if (!char.IsControl(z.KeyChar) && !char.IsDigit(z.KeyChar) && (z.KeyChar != '.'))
            {
                z.Handled = true;
            }

            if (ZipBox.Text.Length >= 5)
            {
                z.Handled = true;
            }*/
            if (ZipBox.Text.Length < 5)
            {
                if (Char.IsDigit(z.KeyChar)) return;
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
            else
            {
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }

        }


        private void PhoneNumberBox_KeyPress(object sender, KeyPressEventArgs p) //Ensures that the user is only able to enter in 10 digits for the phonen number field.
        {
            if (PhoneNumberBox.Text.Length < 10)
            {
                if (Char.IsDigit(p.KeyChar)) return;
                if (Char.IsControl(p.KeyChar)) return;
                p.Handled = true;
            }
            else
            {
                if (Char.IsControl(p.KeyChar)) return;
                p.Handled = true;
            }
/*
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
            }*/
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e) //Ensures that the user is only able to enter in Letters for the first name field.
        {
           
            /*if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (int)(Keys.Back)))
            {
                e.Handled = true;
            }*/
            //Cannot be more than 20 characters
            if (FirstNameBox.Text.Length < 20)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e) //Ensures that the user is only able to enter in Letters for the first name field.
        {
            //Cannot be more than 20 characters
            if (LastNameBox.Text.Length < 20)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void ManageCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
    
            String unsaved1 = "";
            String unsaved2 = "";
            String unsaved3 = "";
            String unsaved4 = "";

            if (closeApp) //closeApp prevents getting stuck in a close loop.
            {     
                if (!CustomerisSaved) //unsaved1
                {
                    unsaved1 = "\"Manage Customers\"\n";
                }
                if (!CreateOrderisSaved) //unsaved2
                {
                    unsaved2 = "\"Create Order\"\n";
                }
                if (!EditOrderisSaved) //unsaved3
                {
                    unsaved3 = "\"Search/Edit Orders\"\n";
                }
                if (!VehicleisSaved) //unsaved4
                {
                    unsaved4 = "\"Manage Vehicles\"\n";
                }
                if (!CustomerisSaved || !CreateOrderisSaved || !EditOrderisSaved || !VehicleisSaved)
                {
                    String warningMessage = "You have unsaved data on the following tabs: \n\n" + unsaved1 + unsaved2 + unsaved3 + unsaved4 + "\nAre you sure you want to quit?";
                    var res = MessageBox.Show(this, warningMessage, "WARNING",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (res != DialogResult.Yes)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        e.Cancel = true;
                        timer.Interval = 1600;
                        timer.Tick += new EventHandler(Timer_Tick);
                        timer.Start();
                        //Says goodbye to the user.
                        ExitForm exitForm = new ExitForm();
                        exitForm.Show();
                    }
                }
                else
                {
                    String warningMessage = "Are you sure you want to quit?";
                    var res = MessageBox.Show(this, warningMessage, "WARNING",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (res != DialogResult.Yes)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        e.Cancel = true;
                        timer.Interval = 1600;
                        timer.Tick += new EventHandler(Timer_Tick);
                        timer.Start();
                        //Says goodbye to the user.
                        ExitForm exitForm = new ExitForm();
                        exitForm.Show();
                    }
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
            
            this.appData.INVOICE.AddINVOICERow(this.appData.INVOICE.NewINVOICERow());
            iNVOICEBindingSource.RemoveSort();
            iNVOICEBindingSource.MoveLast();

            btn_SaveOrder.Visible = false;
            btn_CreateOrder.Visible = true;
            combobox_CustomerIDZ.Enabled = true;
            BookDatePicker.Enabled = false;
            PickUpDatePicker.Enabled = true;
            DropOffDatePicker.Enabled = true;
            picBox_Status.Enabled = true;
            checkBox_CopyPickupInformation.Visible = true;
            checkBox_CopyPickupInformation.Checked = false;
            checkBox_CopyDropoffInformation.Visible = true;
            checkBox_CopyDropoffInformation.Checked = false;

            txtbox_PickupAddress.ReadOnly = false;
            txtbox_PickupCity.ReadOnly = false;
            txtbox_PickupState.ReadOnly = false;
            txtbox_PickupZip.ReadOnly = false;
            txtbox_DeliveryAddress.ReadOnly = false;
            txtbox_DeliveryCity.ReadOnly = false;
            txtbox_DeliveryState.ReadOnly = false;
            txtbox_DeliveryZip.ReadOnly = false;
            txtbox_Company.ReadOnly = false;
            txtbox_Phone.ReadOnly = false;
            txtbox_Email.ReadOnly = false;
            txtbox_Address.ReadOnly = false;
            txtbox_City.ReadOnly = false;
            txtbox_State.ReadOnly = false;
            txtbox_Zip.ReadOnly = false;
            txtboxrch_Description.ReadOnly = false;
            txtboxrch_SpecialInstructions.ReadOnly = false;
            comboBox_Status.Enabled = true;
            picBox_Status.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            checkBox_CopyDropoffInformation.Visible = true;
            checkBox_CopyPickupInformation.Visible = true;
           txtbox_OrderNum.ReadOnly = false;
            comboBox_Vehicle.Enabled = true;
            btn_CancelOrder.Visible = false;
            combobox_CustomerIDZ.Enabled = true;
            txtbox_OrderNum.Text = "";
            BookDatePicker.Value = DateTime.Today;
            PickUpDatePicker.Value = DateTime.Today;
            DropOffDatePicker.Value = DateTime.Today;
            CreateOrderisSaved = false;


            btn_SaveOrder.Visible = true;
            btn_CancelOrder.Visible = true;
            btn_CreateOrder.Visible = false;
        }

        private void btn_SaveOrder_Click(object sender, EventArgs e)
        {
            bool noComp = false, noAddress = false, noCity = false, noPhone = false, noState = false, noEmail = false, noZip = false, noOrder = false, noPickAdd = false, noPickCity = false, noPickState = false, noPickZip = false, noDelAdd = false, noDelCity = false, noDelState = false, noDelZip = false, noVehicle = false, noPickDate = false, noDropDate = false, noStatus = false, noReturn = false, noCustomer = false ;

            lbl_Address.ForeColor = System.Drawing.Color.LightGray;
            lbl_City.ForeColor = System.Drawing.Color.LightGray;
            lbl_Phone.ForeColor = System.Drawing.Color.LightGray;
            lbl_State.ForeColor = System.Drawing.Color.LightGray;
            lbl_Email.ForeColor = System.Drawing.Color.LightGray;
            lbl_Zip.ForeColor = System.Drawing.Color.LightGray;
            lbl_Invoice.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupAddress.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupCity.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupState.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupZip.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryAddress.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryCity.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryState.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryZip.ForeColor = System.Drawing.Color.LightGray;
            lbl_Vehicle.ForeColor = System.Drawing.Color.LightGray;
            lbl_BookDate.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupDate.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryDate.ForeColor = System.Drawing.Color.LightGray;
            lbl_OrderStatus.ForeColor = System.Drawing.Color.LightGray;
            lbl_ReturnTrip.ForeColor = System.Drawing.Color.LightGray;
            lbl_Customer.ForeColor = System.Drawing.Color.LightGray;


            if (string.IsNullOrEmpty(txtbox_Company.Text))
            {
                noComp = true;
                lbl_Company.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_Address.Text))
            {
                noAddress = true;
                lbl_Address.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_City.Text))
            {
                noCity = true;
                lbl_City.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_Phone.Text))
            {
                noPhone = true;
                lbl_Phone.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_State.Text))
            {
                noState = true;
                lbl_State.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_Email.Text))
            {
                noEmail = true;
                lbl_Email.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_Zip.Text))
            {
                noZip = true;
                lbl_Zip.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_OrderNum.Text))
            {
                noOrder = true;
                lbl_Invoice.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_PickupAddress.Text))
            {
                noPickAdd = true;
                lbl_PickupAddress.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_PickupCity.Text))
            {
                noPickCity = true;
                lbl_PickupCity.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_PickupState.Text))
            {
                noPickState = true;
                lbl_PickupState.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_PickupZip.Text))
            {
                noPickZip = true;
                lbl_PickupZip.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_DeliveryAddress.Text))
            {
                noDelAdd = true;
                lbl_DeliveryAddress.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_DeliveryCity.Text))
            {
                noDelCity = true;
                lbl_DeliveryCity.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_DeliveryState.Text))
            {
                noDelState = true;
                lbl_DeliveryState.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_DeliveryZip.Text))
            {
                noDelZip = true;
                lbl_DeliveryZip.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(comboBox_Vehicle.Text))
            {
                noVehicle = true;
                lbl_Vehicle.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(comboBox_Status.Text))
            {
                noStatus = true;
                lbl_OrderStatus.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (!noPhone && !Regex.IsMatch(txtbox_Phone.Text, "[0-9]{3}[0-9]{3}[0-9]{4}")) //Check to see if the phone number is properly formatted.
            {
                lbl_Phone.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (!noEmail && !Regex.IsMatch(txtbox_Email.Text, ".+@.+\\..+")) //Check to see if the email address is properly formatted.
            {
                lbl_Email.ForeColor = System.Drawing.Color.LightCoral;
                
            }
            if (BookDatePicker.Value > PickUpDatePicker.Value)
            {
                lbl_PickupDate.ForeColor = System.Drawing.Color.LightCoral;               
            }
            if (PickUpDatePicker.Value > DropOffDatePicker.Value)
            {
                lbl_DeliveryDate.ForeColor = System.Drawing.Color.LightCoral;
                lbl_PickupDate.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(comboBox_ReturnTrip.Text))
            {
                noReturn = true;
                lbl_ReturnTrip.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(combobox_CustomerIDZ.Text))
            {
                noCustomer = true;
                lbl_Customer.ForeColor = System.Drawing.Color.LightCoral;
            }

            //successfull entry to the database

            if (!noComp && !noAddress && !noCity && !noPhone && !noState && !noEmail && !noZip && !noOrder && !noPickAdd && !noPickCity && !noPickState && !noPickZip && !noDelAdd && !noDelCity && !noDelState && !noDelZip && !noVehicle &&!noStatus && !noPickAdd && !noDropDate && !noReturn && !noCustomer)
            {
                if (!noPhone && !Regex.IsMatch(txtbox_Phone.Text, "[0-9]{3}[0-9]{3}[0-9]{4}")) //Check to see if the phone number is properly formatted.
                {
                    lbl_Phone.ForeColor = System.Drawing.Color.LightCoral;
                    noPhone = true;
                }
                if (!noEmail && !Regex.IsMatch(txtbox_Email.Text, ".+@.+\\..+")) //Check to see if the email address is properly formatted.
                {
                    lbl_Email.ForeColor = System.Drawing.Color.LightCoral;
                    noEmail = true;
                }
                if (!Regex.IsMatch(txtbox_DeliveryZip.Text, "[0-9]{5}")) //Check to see if the zip is properly formatted.
                {
                    lbl_DeliveryZip.ForeColor = System.Drawing.Color.LightCoral;
                    lbl_RequiredField.Visible = true;
                    noDelZip = true;
                }
                if (!Regex.IsMatch(txtbox_PickupZip.Text, "[0-9]{5}")) //Check to see if the zip is properly formatted.
                {
                    lbl_PickupZip.ForeColor = System.Drawing.Color.LightCoral;
                    lbl_RequiredField.Visible = true;
                    noPickZip = true;
                }           
                if (!Regex.IsMatch(txtbox_Zip.Text, "[0-9]{5}")) //Check to see if the zip is properly formatted.
                {
                    lbl_Zip.ForeColor = System.Drawing.Color.LightCoral;
                    lbl_RequiredField.Visible = true;
                    noZip = true;
                }
                //date validation
                if (BookDatePicker.Value > PickUpDatePicker.Value)
                {
                    noPickDate = true;
                    lbl_PickupDate.ForeColor = System.Drawing.Color.LightCoral;
                    
                }
                if (PickUpDatePicker.Value > DropOffDatePicker.Value)
                {
                    noDropDate = true;
                    lbl_DeliveryDate.ForeColor = System.Drawing.Color.LightCoral;
                    lbl_PickupDate.ForeColor = System.Drawing.Color.LightCoral;
                    
                }
                if (comboBox_ReturnTrip.Text != "YES" && comboBox_ReturnTrip.Text != "NO")
                {
                    noReturn = true;
                    lbl_ReturnTrip.ForeColor = System.Drawing.Color.LightCoral;
                }
                
                DataRow[] foundCustomer = this.appData.CUSTOMER.Select("FLNAME = '" + combobox_CustomerIDZ.Text + "'");
                if (foundCustomer.Length < 1)
                {
                    noCustomer = true;
                    lbl_Customer.ForeColor = System.Drawing.Color.LightCoral;
                }

                if (!noPhone && !noEmail && !noPickDate && !noDropDate && !noPickZip && !noDelZip && !noZip &&!noReturn && !noCustomer)
                {
                    //adds to the database
                    iNVOICETableAdapter.Insert(BookDatePicker.Value, PickUpDatePicker.Value, DropOffDatePicker.Value, combobox_CustomerIDZ.SelectedIndex + 1, comboBox_Status.Text,
                    txtbox_PickupAddress.Text, txtbox_PickupCity.Text, txtbox_PickupState.Text, txtbox_PickupZip.Text,
                    txtbox_DeliveryAddress.Text, txtbox_DeliveryCity.Text, txtbox_DeliveryState.Text, txtbox_DeliveryZip.Text, txtboxrch_SpecialInstructions.Text, txtboxrch_Description.Text, txtbox_OrderNum.Text, comboBox_Vehicle.Text, combobox_CustomerIDZ.Text, comboBox_ReturnTrip.Text);
                    this.iNVOICETableAdapter.Fill(this.appData.INVOICE);
                    iNVOICETableAdapter.Update(this.appData.INVOICE);

                    //default values after order is saved and prevents the user from changing data
                    btn_CreateOrder.Visible = true;
                    combobox_CustomerIDZ.Enabled = false;
                    BookDatePicker.Enabled = false;
                    PickUpDatePicker.Enabled = false;
                    DropOffDatePicker.Enabled = false;
                    picBox_Status.Enabled = false;
                    checkBox_CopyPickupInformation.Visible = false;
                    checkBox_CopyDropoffInformation.Visible = false;
                    txtboxrch_Description.Text = ""; //Wipes the data from the Description text box after a save.
                    txtboxrch_SpecialInstructions.Text = ""; //Wipes the data from the Description text box after a save.
                    checkBox_CopyPickupInformation.Visible = false; //dechecks the pickup check box.
                    checkBox_CopyDropoffInformation.Visible = false; //dechecks the dropoff check box.
                    btn_CancelOrder.Visible = false;
                    BookDatePicker.Value = DateTime.Today;
                    PickUpDatePicker.Value = DateTime.Today;
                    DropOffDatePicker.Value = DateTime.Today;
                    txtbox_PickupAddress.Text = "";
                    txtbox_PickupCity.Text = "";
                    txtbox_PickupState.Text = "";
                    txtbox_PickupZip.Text = "";
                    txtbox_DeliveryAddress.Text = "";
                    txtbox_DeliveryCity.Text = "";
                    txtbox_DeliveryState.Text = "";
                    txtbox_DeliveryZip.Text = "";
                    comboBox_Status.Text = "";
                    //txtbox_OrderNum.Text = "";
                    comboBox_Vehicle.Text = "";
                    picBox_Status.Image = null;
                    txtbox_Company.ReadOnly = true;
                    txtbox_Phone.ReadOnly = true;
                    txtbox_Email.ReadOnly = true;
                    txtbox_Address.ReadOnly = true;
                    txtbox_City.ReadOnly = true;
                    txtbox_State.ReadOnly = true;
                    txtbox_Zip.ReadOnly = true;
                    txtbox_PickupAddress.ReadOnly = true;
                    txtbox_PickupCity.ReadOnly = true;
                    txtbox_PickupState.ReadOnly = true;
                    txtbox_PickupZip.ReadOnly = true;
                    txtbox_DeliveryAddress.ReadOnly = true;
                    txtbox_DeliveryCity.ReadOnly = true;
                    txtbox_DeliveryState.ReadOnly = true;
                    txtbox_DeliveryZip.ReadOnly = true;
                    btn_SaveOrder.Visible = false;
                    picBox_Status.Enabled = false;
                    comboBox_Status.Enabled = false;
                    txtboxrch_Description.ReadOnly = true;
                    txtboxrch_SpecialInstructions.ReadOnly = true;
                    txtbox_OrderNum.ReadOnly = true;
                    comboBox_Vehicle.Enabled = false;
                    combobox_CustomerIDZ.Enabled = false;
                    CreateOrderisSaved = true;

                }
                else
                {
                    if (noCustomer)
                    {
                        MessageBox.Show(combobox_CustomerIDZ.Text + " is not a known customer. Please select an existing customer.", "INVALID CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (noPhone)
                    {
                        MessageBox.Show(txtbox_Phone.Text + " is not a valid phone number. Please enter in 10 digits.", "INVALID PHONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noEmail)
                    {
                        MessageBox.Show(txtbox_Email.Text + " is not a valid email address. Email addresses must take the form xxxx@xxxx.xxx", "INVALID EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noZip)
                    {
                        MessageBox.Show(txtbox_Zip.Text + " is not a valid Zip Code. Zip Codes must contain 5 digits", "INVALID ZIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noPickZip)
                    {
                        MessageBox.Show(txtbox_PickupZip.Text + " is not a valid Zip Code. Zip Codes must contain 5 digits", "INVALID ZIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noDelZip)
                    {
                        MessageBox.Show(txtbox_DeliveryZip.Text + " is not a valid Zip Code. Zip Codes must contain 5 digits", "INVALID ZIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (noPickDate)
                    {
                        MessageBox.Show("The pickup date cannot be before the booking date.", "INVALID DATE");
                    }
                    else if (noDropDate)
                    {
                        MessageBox.Show("The delivery date cannot be before the pickup date.", "Invalid Date Entry");
                    }
                    else if(noReturn)
                    {
                        MessageBox.Show("The return trip must either be YES or NO", "Invalid Entry");
                    }
                }
                

            }
            //one of the required fields is blank, so let the user know.
            else
            {                   
                {
                    MessageBox.Show("Please fill in the required fields.", "Invalid Entry");
                }
                
            }
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
            
        }

        private void btn_CopyDropOffAddress_CheckedChanged(object sender, EventArgs e)
        {
            
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

        private void OrderSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtbox_OrderSearchBox.Text))
                {
                    this.iNVOICETableAdapter.Fill(this.appData.INVOICE);
                    iNVOICEBindingSource.DataSource = this.appData.INVOICE;
                }

                else
                {
                    var query = from r in this.appData.INVOICE
                                where
                                r.INV_ID.Equals(txtbox_OrderSearchBox.Text) ||
                                r.BOOK_DATE.Equals(txtbox_OrderSearchBox.Text) ||
                                r.PICKUP_DATE.Equals(txtbox_OrderSearchBox.Text) ||
                                r.DROPOFF_DATE.Equals(txtbox_OrderSearchBox.Text) ||
                                r.CUST_ID.Equals(txtbox_OrderSearchBox.Text) ||
                                r.ORDER_STATUS.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.ORDER_STATUS.Contains(txtbox_OrderSearchBox.Text) ||
                                r.PICKUP_ADDRESS.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.PICKUP_ADDRESS.Contains(txtbox_OrderSearchBox.Text) ||
                                r.PICKUP_CITY.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.PICKUP_CITY.Contains(txtbox_OrderSearchBox.Text) ||
                                r.PICKUP_STATE.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.PICKUP_STATE.Contains(txtbox_OrderSearchBox.Text) ||
                                r.PICKUP_ZIP.Equals(txtbox_OrderSearchBox.Text) ||
                                r.DELIVERY_ADDRESS.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.DELIVERY_ADDRESS.Contains(txtbox_OrderSearchBox.Text) ||
                                r.DELIVERY_CITY.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.DELIVERY_CITY.Contains(txtbox_OrderSearchBox.Text) ||
                                r.DELIVERY_STATE.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.DELIVERY_STATE.Contains(txtbox_OrderSearchBox.Text) ||
                                r.DELIVERY_ZIP.Equals(txtbox_OrderSearchBox.Text) ||
                                r.SPECIAL_INSTRUCTIONS.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.SPECIAL_INSTRUCTIONS.Contains(txtbox_OrderSearchBox.Text) ||
                                r.DESCRIPTION.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.DESCRIPTION.Contains(txtbox_OrderSearchBox.Text) ||
                                r.VEHICLE.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.VEHICLE.Contains(txtbox_OrderSearchBox.Text) ||
                                r.ORDER_NUM.Equals(txtbox_OrderSearchBox.Text) ||
                                r.CUST_FLNAME.Equals(txtbox_OrderSearchBox.Text, StringComparison.OrdinalIgnoreCase) ||
                                r.CUST_FLNAME.Contains(txtbox_OrderSearchBox.Text)
                                
                                select r;
                    iNVOICEBindingSource.DataSource = query.ToList();
                }
            }
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image picCancelled = WindowsFormsApp3.Properties.Resources.cancelled;
            Image picPending = WindowsFormsApp3.Properties.Resources.pending;
            Image picDelayed = WindowsFormsApp3.Properties.Resources.delayed;
            Image picInTransit = WindowsFormsApp3.Properties.Resources.in_transit;
            Image picComplete = WindowsFormsApp3.Properties.Resources.complete;


            if (comboBox_Status.SelectedIndex == 0) //0 is Pending
            {
                picBox_Status.Image = picPending;
                //listBox_Status_Click(sender, e);
            }
            else if (comboBox_Status.SelectedIndex == 1) //1 is In Transit
            {
                picBox_Status.Image = picInTransit;
                //listBox_Status_Click(sender, e);
            }
            else if (comboBox_Status.SelectedIndex == 2) //2 is Delayed
            {
                picBox_Status.Image = picDelayed;
            }
            else if (comboBox_Status.SelectedIndex == 3) //3 is Complete
            {
                picBox_Status.Image = picComplete;
            }
            else if (comboBox_Status.SelectedIndex == 4) //4 is Cancelled
            {
                picBox_Status.Image = picCancelled;
            }
            else
            {
                picBox_Status.Image = null;
            }
        }

        private void btn_EditOrder_Click(object sender, EventArgs e)
        {
            if (txtbox_InvoiceIdEdit.Text == "")
            {
                MessageBox.Show("Please select an order to edit.", "NO ORDER SELECTED");
                txtbox_OrderSearchBox.Text = "";
                SendKeys.Send("{ENTER}");
                txtbox_OrderSearchBox.Focus();
            }
            else
            {
                txtbox_InvoiceIdEdit.ReadOnly = true;
                //dateTimePicker_BookingDateEdit.Enabled = true;
                dateTimePicker_PickUpDateEdit.Enabled = true;
                dateTimePicker_DeliveryDateEdit.Enabled = true;
                comboBox_OrderStatusEdit.Enabled = true;
                txtbox_OrderNumberEdit.Enabled = true;
                comboBox_VehicleEdit.Enabled = true;
                txtbox_OrderNumberEdit.ReadOnly = false;
                txtbox_PickupAddressEdit.ReadOnly = false;
                txtbox_PickupCityEdit.ReadOnly = false;
                txtbox_PickupStateEdit.ReadOnly = false;
                txtbox_PickupZipEdit.ReadOnly = false;
                txtbox_DeliveryAddressEdit.ReadOnly = false;
                txtbox_DeliveryCityEdit.ReadOnly = false;
                txtbox_DeliveryStateEdit.ReadOnly = false;
                txtbox_DeliveryZipEdit.ReadOnly = false;
                txtboxrch_DescriptionEdit.ReadOnly = false;
                txtboxrch_SpecialInstructionsEdit.ReadOnly = false;
                comboBox_CUSTFLNAMEBOX.Enabled = true;
                txtbox_OrderSearchBox.Enabled = false;
                btn_SaveOrderEdit.Visible = true;
                btn_EditOrder.Visible = false;
                comboBox_ReturnTripEdit.Enabled = true;
                btn_CancelOrderEdit.Visible = true;
                EditOrderisSaved = false;
                dataGridView2.Enabled = false;
                
            }
        }

        private void btn_SaveOrderEdit_Click(object sender, EventArgs e)
        {
            //Changes labels back to White
            lbl_PickupAddressEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupCityEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupStateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupZipEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryAddressEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryCityEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryStateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryZipEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DescriptionEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_SpecialInstructionsEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_VehicleEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_SpecialInstructionsEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DescriptionEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_OrderStatusEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_InvoiceIdEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_BookingDateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupDateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryDateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_ReturnTripEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightGray;


            bool noPickAdd = false, noPickCity = false, noPickState = false, noPickZip = false, noDelAdd = false, noDelCity = false, noDelState = false, noDelZip = false, noVehicle = false, noPickDate = false, noDropDate = false, noStatus = false, noCust = false, noOrder = false, noReturn = false, noCustFL = false;

            if (string.IsNullOrEmpty(txtbox_PickupAddressEdit.Text))
            {
                noPickAdd = true;
                lbl_PickupAddressEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_PickupCityEdit.Text))
            {
                noPickCity = true;
                lbl_PickupCityEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_PickupStateEdit.Text))
            {
                noPickState = true;
                lbl_PickupStateEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_PickupZipEdit.Text))
            {
                noPickZip = true;
                lbl_PickupZipEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_DeliveryAddressEdit.Text))
            {
                noDelAdd = true;
                lbl_DeliveryAddressEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_DeliveryCityEdit.Text))
            {
                noDelCity = true;
                lbl_DeliveryCityEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_DeliveryStateEdit.Text))
            {
                noDelState = true;
                lbl_DeliveryStateEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_DeliveryZipEdit.Text))
            {
                noDelZip = true;
                lbl_DeliveryZipEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(comboBox_OrderStatusEdit.Text))
            {
                noStatus = true;
                lbl_OrderStatusEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(comboBox_VehicleEdit.Text))
            {
                noVehicle = true;
                lbl_VehicleEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(comboBox_CUSTFLNAMEBOX.Text))
            {
                noCust = true;
                lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (string.IsNullOrEmpty(txtbox_OrderNumberEdit.Text))
            {
                noOrder = true;
                lbl_InvoiceIdEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (comboBox_ReturnTripEdit.Text != "YES" && comboBox_ReturnTripEdit.Text != "NO")
            {
                noReturn = true;
                lbl_ReturnTripEdit.ForeColor = System.Drawing.Color.LightCoral;
            }

            //date validation
            if (dateTimePicker_BookingDateEdit.Value > dateTimePicker_PickUpDateEdit.Value)
            {
                noPickDate = true;
                lbl_PickupDateEdit.ForeColor = System.Drawing.Color.LightCoral;
            }
            if (dateTimePicker_PickUpDateEdit.Value > dateTimePicker_DeliveryDateEdit.Value)
            {
                noDropDate = true;
                lbl_DeliveryDateEdit.ForeColor = System.Drawing.Color.LightCoral;
                lbl_PickupDateEdit.ForeColor = System.Drawing.Color.LightCoral;
            }

            //Zip Validation
            if (!Regex.IsMatch(txtbox_DeliveryZipEdit.Text, "[0-9]{5}")) //Check to see if the zip is properly formatted.
            {
                lbl_DeliveryZipEdit.ForeColor = System.Drawing.Color.LightCoral;
                lbl_RequiredField.Visible = true;
                noDelZip = true;
            }
            if (!Regex.IsMatch(txtbox_PickupZipEdit.Text, "[0-9]{5}")) //Check to see if the zip is properly formatted.
            {
                lbl_PickupZipEdit.ForeColor = System.Drawing.Color.LightCoral;
                lbl_RequiredField.Visible = true;
                noPickZip = true;
            }

            DataRow[] foundCustomerEdit = this.appData.CUSTOMER.Select("FLNAME = '" + comboBox_CUSTFLNAMEBOX.Text + "'");
            if (foundCustomerEdit.Length < 1)
            {
                noCustFL = true;
                lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightCoral;
            }

            //successfull entry to the database
            if (!noOrder && !noReturn && !noPickAdd && !noPickCity && !noPickState && !noPickZip && !noDelAdd && !noDelCity && !noDelState && !noDelZip && !noVehicle && !noStatus && !noPickDate && !noDropDate && !noCust && !noCustFL)
            {
                                
                iNVOICEBindingSource.EndEdit();        
                iNVOICETableAdapter.Update(appData.INVOICE);
                
                btn_EditOrder.Visible = true;
                btn_SaveOrderEdit.Visible = false;
                btn_CancelOrderEdit.Visible = false;
                //dateTimePicker_BookingDateEdit.Enabled = false;
                dateTimePicker_PickUpDateEdit.Enabled = false;
                dateTimePicker_DeliveryDateEdit.Enabled = false;
                comboBox_OrderStatusEdit.Enabled = false;
                txtbox_OrderNumberEdit.ReadOnly = true;
                txtbox_PickupAddressEdit.ReadOnly = true;
                txtbox_PickupCityEdit.ReadOnly = true;
                txtbox_PickupStateEdit.ReadOnly = true;
                txtbox_PickupZipEdit.ReadOnly = true;
                txtbox_DeliveryAddressEdit.ReadOnly = true;
                txtbox_DeliveryCityEdit.ReadOnly = true;
                txtbox_DeliveryStateEdit.ReadOnly = true;
                txtbox_DeliveryZipEdit.ReadOnly = true;
                txtboxrch_DescriptionEdit.ReadOnly = true;
                txtboxrch_SpecialInstructionsEdit.ReadOnly = true;
                comboBox_VehicleEdit.Enabled = false;
                txtbox_OrderSearchBox.Enabled = true;
                txtboxrch_SpecialInstructions.ReadOnly = true;
                txtboxrch_Description.ReadOnly = true;
                comboBox_CUSTFLNAMEBOX.Enabled = false;
                comboBox_ReturnTripEdit.Enabled = false;
                dataGridView2.Enabled = true;
                EditOrderisSaved = true;

                //Changes labels back to White
                lbl_PickupAddressEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_PickupCityEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_PickupStateEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_PickupZipEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_DeliveryAddressEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_DeliveryCityEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_DeliveryStateEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_DeliveryZipEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_DescriptionEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_SpecialInstructionsEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_VehicleEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_SpecialInstructionsEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_DescriptionEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_OrderStatusEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_InvoiceIdEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_BookingDateEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_PickupDateEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_DeliveryDateEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_ReturnTripEdit.ForeColor = System.Drawing.Color.LightGray;
                lbl_Customer.ForeColor = System.Drawing.Color.LightGray;


            }
            else
            {
                if (noCust)
                {
                    MessageBox.Show("Please fill in the required fields.", "Invalid Entry");
                }
                else if (noCustFL)
                {
                    MessageBox.Show(comboBox_CUSTFLNAMEBOX.Text + " is not a known customer. Please select an existing customer.", "INVALID CUSTOMER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (noPickZip)
                {
                    MessageBox.Show(txtbox_PickupZipEdit.Text + " is not a valid Zip Code. Zip Codes must contain 5 digits", "INVALID ZIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (noDelZip)
                {
                    MessageBox.Show(txtbox_DeliveryZipEdit.Text + " is not a valid Zip Code. Zip Codes must contain 5 digits", "INVALID ZIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (noPickDate)
                {
                    MessageBox.Show("The pickup date cannot be before the booking date.", "Invalid Date Entry");
                }
                else if (noDropDate)
                {
                    MessageBox.Show("The delivery date cannot be before the pickup date.", "Invalid Date Entry");
                }
                else if (noReturn)
                {
                    MessageBox.Show("The Return Trip must be either YES or NO.", "Invalid Entry");
                }
                else
                {
                    MessageBox.Show("Please fill in the required fields.", "Invalid Entry");
                }
                

            }

        }

        //HELP
        private void txtbox_Phone_KeyPress(object sender, KeyPressEventArgs p)
        {
            if (txtbox_Phone.Text.Length < 10)
            {
                if (Char.IsDigit(p.KeyChar)) return;
                if (Char.IsControl(p.KeyChar)) return;
                p.Handled = true;
            }
            else
            {
                if (Char.IsControl(p.KeyChar)) return;
                p.Handled = true;
            }

           /*if (!Char.IsDigit(p.KeyChar) && (p.KeyChar != (char)(Keys.Back)))
            {
                p.Handled = true;
            }
            else
            {
                // is a digit or backspace - ignore digits if length is alreay 10 - allow backspace
                if (Char.IsDigit(p.KeyChar))
                {
                    if (txtbox_Phone.Text.Length > 9)
                    {
                        p.Handled = true;
                    }
                }
            }*/
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            txtbox_FLNAME.Text = FirstNameBox.Text + " " + LastNameBox.Text;
        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            txtbox_FLNAME.Text = FirstNameBox.Text + " " + LastNameBox.Text;
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            combobox_CustomerIDZ.Enabled = false;
            BookDatePicker.Enabled = false;
            PickUpDatePicker.Enabled = false;
            DropOffDatePicker.Enabled = false;
            picBox_Status.Enabled = false;
            checkBox_CopyPickupInformation.Visible = false;
            checkBox_CopyDropoffInformation.Visible = false;
            txtboxrch_Description.Text = ""; //Wipes the data from the Description text box after a save.
            txtboxrch_SpecialInstructions.Text = ""; //Wipes the data from the Description text box after a save.
            checkBox_CopyPickupInformation.Visible = false; //dechecks the pickup check box.
            checkBox_CopyDropoffInformation.Visible = false; //dechecks the dropoff check box.
            BookDatePicker.Value = DateTime.Today;
            PickUpDatePicker.Value = DateTime.Today;
            DropOffDatePicker.Value = DateTime.Today;
            txtbox_PickupAddress.Text = "";
            txtbox_PickupCity.Text = "";
            txtbox_PickupState.Text = "";
            txtbox_PickupZip.Text = "";
            txtbox_DeliveryAddress.Text = "";
            txtbox_DeliveryCity.Text = "";
            txtbox_DeliveryState.Text = "";
            txtbox_DeliveryZip.Text = "";
            comboBox_Status.Text = "";
            txtbox_OrderNum.Text = "";
            comboBox_Vehicle.Text = "";
            txtBox_InvoiceNumber.Text = "";
            picBox_Status.Image = null;
            txtbox_Company.ReadOnly = true;
            txtbox_Phone.ReadOnly = true;
            txtbox_Email.ReadOnly = true;
            txtbox_Address.ReadOnly = true;
            txtbox_City.ReadOnly = true;
            txtbox_State.ReadOnly = true;
            txtbox_Zip.ReadOnly = true;
            txtbox_PickupAddress.ReadOnly = true;
            txtbox_PickupCity.ReadOnly = true;
            txtbox_PickupState.ReadOnly = true;
            txtbox_PickupZip.ReadOnly = true;
            txtbox_DeliveryAddress.ReadOnly = true;
            txtbox_DeliveryCity.ReadOnly = true;
            txtbox_DeliveryState.ReadOnly = true;
            txtbox_DeliveryZip.ReadOnly = true;
            btn_SaveOrder.Visible = false;
            picBox_Status.Enabled = false;
            comboBox_Status.Enabled = false;
            txtboxrch_Description.ReadOnly = true;
            txtboxrch_SpecialInstructions.ReadOnly = true;
            btn_CancelOrder.Visible = false;
            txtbox_OrderNum.ReadOnly = true;
            comboBox_Vehicle.Enabled = false;
            combobox_CustomerIDZ.Enabled = false;
            CreateOrderisSaved = true;

            //Changes labels back to White
            lbl_PickupAddress.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupCity.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupState.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupZip.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryAddress.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryCity.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryState.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryZip.ForeColor = System.Drawing.Color.LightGray;
            lbl_Description.ForeColor = System.Drawing.Color.LightGray;
            lbl_SpecialInstructions.ForeColor = System.Drawing.Color.LightGray;
            lbl_Vehicle.ForeColor = System.Drawing.Color.LightGray;
            lbl_SpecialInstructions.ForeColor = System.Drawing.Color.LightGray;
            lbl_Description.ForeColor = System.Drawing.Color.LightGray;
            lbl_Customer.ForeColor = System.Drawing.Color.LightGray;
            lbl_OrderStatus.ForeColor = System.Drawing.Color.LightGray;
            lbl_Invoice.ForeColor = System.Drawing.Color.LightGray;
            lbl_BookDate.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupDate.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryDate.ForeColor = System.Drawing.Color.LightGray;
            lbl_Customer.ForeColor = System.Drawing.Color.LightGray;
            lbl_ReturnTrip.ForeColor = System.Drawing.Color.LightGray;
            lbl_Customer.ForeColor = System.Drawing.Color.LightGray;


            iNVOICEBindingSource.CancelEdit();
            iNVOICEBindingSource.RemoveCurrent();

            btn_CreateOrder.Visible = true;
        }

        private void btn_AddVehicle_Click(object sender, EventArgs e)
        {
            btn_AddVehicle.Enabled = false;
            btn_EditVehicle.Enabled = false;
            btn_SaveVehicle.Enabled = true;
            btn_CancelVehicle.Enabled = true;
            this.appData.VEHICLE.AddVEHICLERow(this.appData.VEHICLE.NewVEHICLERow());
            vEHICLEBindingSource.RemoveSort();
            vEHICLEBindingSource.MoveLast();
            dataGridViewVehicle.Enabled = false;

            txtbox_VehicleName.ReadOnly = false;
            txtboxrch_VehicleNotes.ReadOnly = false;
            txtbox_VehicleName.Focus();
            panel_VehicleTab.Visible = true;
            VehicleisSaved = false;
                 
        }

        private void btn_SaveVehicle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_VehicleName.Text))
            {
                MessageBox.Show("Please enter the name of the vehicle.", "INVALID VEHICLE NAME");
                lbl_VehicleName.ForeColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                vEHICLEBindingSource.EndEdit();
                vEHICLETableAdapter.Update(appData.VEHICLE);
                btn_AddVehicle.Enabled = true;
                btn_SaveVehicle.Enabled = false;
                btn_EditVehicle.Enabled = true;
                btn_CancelVehicle.Enabled = false;
                dataGridViewVehicle.Enabled = true;
                txtbox_VehicleName.ReadOnly = true;
                txtboxrch_VehicleNotes.ReadOnly = true;
                panel_VehicleTab.Visible = false;
                lbl_VehicleName.ForeColor = System.Drawing.Color.LightGray;
                VehicleisSaved = true;
            }     
        }
        private void btn_EditVehicle_Click(object sender, EventArgs e)
        {
            btn_EditVehicle.Enabled = true;
            btn_AddVehicle.Enabled = false;
            btn_CancelVehicle.Enabled = true;
            btn_SaveVehicle.Enabled = true;
            dataGridViewVehicle.Enabled = false;
            txtbox_VehicleName.ReadOnly = false;
            txtboxrch_VehicleNotes.ReadOnly = false;

            txtbox_VehicleName.Focus();
            panel_VehicleTab.Visible = true;
            VehicleisSaved = false;
        }

        private void btn_CancelVehicle_Click(object sender, EventArgs e)
        {
            if (btn_EditVehicle.Enabled == true)
            {
                btn_EditVehicle.Enabled = true;
                btn_AddVehicle.Enabled = true;
                btn_CancelVehicle.Enabled = false;
                btn_SaveVehicle.Enabled = false;
                txtboxrch_VehicleNotes.ReadOnly = true;
                txtbox_VehicleName.ReadOnly = true;
                vEHICLEBindingSource.CancelEdit();
                dataGridViewVehicle.Enabled = true;
                panel_VehicleTab.Visible = false;
                lbl_VehicleName.ForeColor = System.Drawing.Color.LightGray;
                VehicleisSaved = true;

            }

            if (btn_EditVehicle.Enabled == false)
            {
                btn_EditVehicle.Enabled = true;
                btn_AddVehicle.Enabled = true;
                btn_CancelVehicle.Enabled = false;
                btn_SaveVehicle.Enabled = false;
                panel_VehicleTab.Visible = false;
                /*txtboxrch_VehicleNotes.ReadOnly = true;
                txtbox_VehicleName.ReadOnly = true;*/

                vEHICLEBindingSource.CancelEdit();
                vEHICLEBindingSource.RemoveCurrent();

                dataGridViewVehicle.Enabled = true;
                lbl_VehicleName.ForeColor = System.Drawing.Color.LightGray;
            }
            
        }

        String helpPath = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents") + "\\GitHub\\INFSYS4850\\Resources\\Help\\";
        private void btn_Help1_Click(object sender, EventArgs e)
        {
            tab_Container.SelectedTab = tab_Help;
            webBrowser1.Url = new System.Uri(helpPath + "test.html#managecustomers", System.UriKind.Absolute);           
        }

        private void btn_Help2_Click(object sender, EventArgs e)
        {
            tab_Container.SelectedTab = tab_Help;
            webBrowser1.Url = new System.Uri(helpPath + "test.html#createorders", System.UriKind.Absolute);
        }

        private void btn_Help3_Click(object sender, EventArgs e)
        {
            tab_Container.SelectedTab = tab_Help;
            webBrowser1.Url = new System.Uri(helpPath + "test.html#searchorders", System.UriKind.Absolute);            
        }

        private void btn_Help4_Click(object sender, EventArgs e)
        {
            tab_Container.SelectedTab = tab_Help;
            webBrowser1.Url = new System.Uri(helpPath + "test.html#vehiclemanager", System.UriKind.Absolute);
        }

        private void txtbox_PickupZipEdit_KeyPress(object sender, KeyPressEventArgs z)
        {
            //This is the method that makes it so that only digits can be entered in the Zip Code Field
            if (txtbox_PickupZipEdit.Text.Length < 5)
            {
                if (Char.IsDigit(z.KeyChar)) return;
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
            else
            {
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
        }

        private void txtbox_DeliveryZipEdit_KeyPress(object sender, KeyPressEventArgs z)
        {
            //This is the method that makes it so that only digits can be entered in the Zip Code Field
            if (txtbox_DeliveryZipEdit.Text.Length < 5)
            {
                if (Char.IsDigit(z.KeyChar)) return;
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
            else
            {
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
        }

        private void txtbox_Zip_KeyPress(object sender, KeyPressEventArgs z)
        {
            //This is the method that makes it so that only digits can be entered in the Zip Code Field
            if (txtbox_Zip.Text.Length < 5)
            {
                if (Char.IsDigit(z.KeyChar)) return;
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
            else
            {
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
        }

        private void txtbox_PickupZip_KeyPress(object sender, KeyPressEventArgs z)
        {
            if (txtbox_PickupZip.Text.Length < 5)
            {
                if (Char.IsDigit(z.KeyChar)) return;
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
            else
            {
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
            /*
            //This is the method that makes it so that only digits can be entered in the Zip Code Field
            if (!char.IsControl(z.KeyChar) && !char.IsDigit(z.KeyChar) && (z.KeyChar != '.'))
            {
                z.Handled = true;
            }

            if (txtbox_PickupZip.Text.Length >= 5)
            {
                z.Handled = true;
            }
            */
        }

        private void txtbox_DeliveryZip_KeyPress(object sender, KeyPressEventArgs z)
        {
            //This is the method that makes it so that only digits can be entered in the Zip Code Field
            if (txtbox_DeliveryZip.Text.Length < 5)
            {
                if (Char.IsDigit(z.KeyChar)) return;
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
            else
            {
                if (Char.IsControl(z.KeyChar)) return;
                z.Handled = true;
            }
        }

        private void btn_ClearSearch1_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
            SendKeys.Send("{ENTER}");
            SearchBox.Focus();
        }

        private void ClearSearch2_Click(object sender, EventArgs e)
        {
            txtbox_OrderSearchBox.Text = "";
            SendKeys.Send("{ENTER}");
            txtbox_OrderSearchBox.Focus();
        }

        private void btn_CancelOrderEdit_Click(object sender, EventArgs e)
        {
            //Changes labels back to White
            lbl_PickupAddressEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupCityEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupStateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupZipEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryAddressEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryCityEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryStateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryZipEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DescriptionEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_SpecialInstructionsEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_VehicleEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_SpecialInstructionsEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DescriptionEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_OrderStatusEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_InvoiceIdEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_BookingDateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_PickupDateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_DeliveryDateEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_CustomerEdit.ForeColor = System.Drawing.Color.LightGray;
            lbl_ReturnTripEdit.ForeColor = System.Drawing.Color.LightGray;
            

            btn_EditOrder.Visible = true;
            btn_SaveOrderEdit.Visible = false;
            btn_CancelOrderEdit.Visible = false;
            dateTimePicker_PickUpDateEdit.Enabled = false;
            dateTimePicker_DeliveryDateEdit.Enabled = false;
            comboBox_OrderStatusEdit.Enabled = false;
            txtbox_OrderNumberEdit.ReadOnly = true;
            txtbox_PickupAddressEdit.ReadOnly = true;
            txtbox_PickupCityEdit.ReadOnly = true;
            txtbox_PickupStateEdit.ReadOnly = true;
            txtbox_PickupZipEdit.ReadOnly = true;
            txtbox_DeliveryAddressEdit.ReadOnly = true;
            txtbox_DeliveryCityEdit.ReadOnly = true;
            txtbox_DeliveryStateEdit.ReadOnly = true;
            txtbox_DeliveryZipEdit.ReadOnly = true;
            txtboxrch_DescriptionEdit.ReadOnly = true;
            txtboxrch_SpecialInstructionsEdit.ReadOnly = true;
            comboBox_VehicleEdit.Enabled = false;
            txtbox_OrderSearchBox.Enabled = true;
            txtboxrch_SpecialInstructions.ReadOnly = true;
            txtboxrch_Description.ReadOnly = true;
            comboBox_CUSTFLNAMEBOX.Enabled = false;
            comboBox_ReturnTripEdit.Enabled = false;
            dataGridView2.Enabled = true;
            EditOrderisSaved = true;

            iNVOICEBindingSource.CancelEdit();
            
            
           
        }

        private void EmailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (EmailBox.Text.Length > 50)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void CompanyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (CompanyBox.Text.Length > 50)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void AddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (AddressBox.Text.Length > 50)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void CityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (CityBox.Text.Length > 20)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void StateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (StateBox.Text.Length > 20)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void combobox_CustomerIDZ_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtbox_Company_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (txtbox_Company.Text.Length > 50)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (txtbox_Email.Text.Length > 50)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (txtbox_Address.Text.Length > 50)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_City.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_State_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_State.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_OrderNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 10 characters
            if (txtbox_OrderNum.Text.Length > 10)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void comboBox_Vehicle_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (comboBox_Vehicle.Text.Length > 20)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_PickupAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (txtbox_PickupAddress.Text.Length < 51)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_PickupCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_PickupCity.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_PickupState_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_PickupState.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_DeliveryAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (txtbox_DeliveryAddress.Text.Length < 51)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_DeliveryCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_DeliveryCity.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_DeliveryState_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_DeliveryState.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtboxrch_Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 200 characters
            if (txtboxrch_Description.Text.Length > 200)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtboxrch_SpecialInstructions_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 200 characters
            if (txtboxrch_SpecialInstructions.Text.Length > 200)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_OrderNumberEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 10 characters
            if (txtbox_OrderNumberEdit.Text.Length > 10)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_PickupAddressEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (txtbox_PickupAddressEdit.Text.Length < 51)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_PickupCityEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_PickupCityEdit.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_PickupStateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_PickupStateEdit.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_DeliveryAddressEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (txtbox_DeliveryStateEdit.Text.Length < 51)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_DeliveryCityEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_DeliveryStateEdit.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_DeliveryStateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 20 characters
            if (txtbox_DeliveryStateEdit.Text.Length < 21)
            {
                if (Char.IsLetter(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtboxrch_DescriptionEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 200 characters
            if (txtboxrch_DescriptionEdit.Text.Length > 200)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtboxrch_SpecialInstructionsEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 200 characters
            if (txtboxrch_SpecialInstructionsEdit.Text.Length > 200)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtbox_VehicleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 50 characters
            if (txtbox_VehicleName.Text.Length > 50)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void txtboxrch_VehicleNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cannot be more than 200 characters
            if (txtboxrch_VehicleNotes.Text.Length > 200)
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }
    }
}
