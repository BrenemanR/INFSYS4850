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
    public partial class CreateCustomer : Form
    {
        bool isSaved = true;
        public CreateCustomer()
        {
            InitializeComponent();
            
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            
            try
            {
                cUSTOMERBindingSource.EndEdit();
                if (string.IsNullOrEmpty(txtbox_FName.Text))
                {

                    MessageBox.Show(txtbox_FName.Text, "First name cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //btnNew.Enabled = false;
                    //panel1.Enabled = true;

                }

                if (string.IsNullOrEmpty(txtbox_LName.Text))
                {

                    MessageBox.Show(txtbox_LName.Text, "Last name cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //btnNew.Enabled = false;
                    //panel1.Enabled = true;

                }

                if (txtbox_Email.Text.Length == 0) //Checks to see if the email address field is blank
                {
                    MessageBox.Show(txtbox_Email.Text, "Email Address cannot be blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //btnNew.Enabled = false;
                    //panel1.Enabled = true;

                }


                if (!txtbox_Email.Text.Contains("@")) //Check to see if the email address contains an '@' symbol.
                {
                    MessageBox.Show(txtbox_Email.Text, "INVALID EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //btnNew.Enabled = false;
                    //panel1.Enabled = true;

                }

                else
                {

                    
                    cUSTOMERTableAdapter.Update(this.appData.CUSTOMER);
                    //btnEdit.Enabled = true; //Reenables the Edit Button After a new record is saved.
                    //btnNew.Enabled = true;  //Reenables the New Button After an edit is saved.
                    //panel1.Enabled = false;
                    isSaved = true;
                    Form.ActiveForm.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cUSTOMERBindingSource.ResetBindings(false);
            }
        }

        private void txtbox_FName_TextChanged(object sender, EventArgs e)
        {
                                        
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.appData.CUSTOMER);
            cUSTOMERBindingSource.DataSource = this.appData.CUSTOMER;

        }

        private void txtbox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Phone_KeyPress(object sender, KeyPressEventArgs e)
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
                        if (txtbox_Phone.Text.Length > 9)
                        {
                            e.Handled = true;
                        }
                    }
                }
        }

        private void txtbox_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (int)(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txtbox_LName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != (int)(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
