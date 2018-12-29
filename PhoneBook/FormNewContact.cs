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
using System.Globalization;

namespace PhoneBook
{
    // This Form is used to insert new contact into the database or update one
    public partial class FormNewContact : Form
    {
        // The default gender to be displayed
        private readonly byte defaultGenderIndex = 0;
        // Consider the purpose of the instance, between insert new user or to update exisitng
        private bool updateMode;
        // This property is needed for updating existing user
        private int updateId;
        // This should keep reference to the main for in order to reload the data after each insert or update using ReloadData
        private FormMain sender;

        #region Constructors

        // Constructor for adding new contact
        public FormNewContact(FormMain sender)
        {
            InitializeComponent();
            this.comboBoxGender.SelectedIndex = defaultGenderIndex; // select "Male" as default Gender value
            this.sender = sender; // gives access to ReloadData for dynamic data reload
            this.updateMode = false;


        }

        // Constructor for updating contact
        public FormNewContact(FormMain sender, string fn, string ln, string pn, string g, int id)
        {
            InitializeComponent();
            this.textBoxFirstName.Text = fn;
            this.textBoxLastName.Text = ln;
            this.textBoxPhoneNumber.Text = pn;
            this.defaultGenderIndex = (byte)((g == "male") ? 0 : 1); // "male" index is 0 and female 1
            this.comboBoxGender.SelectedIndex = (g == "male") ? 0 : 1; // "male" index is 0 and female 1
            this.sender = sender; // gives access to ReloadData for dynamic data reload
            this.updateMode = true;
            this.updateId = id;
            this.Text = "Update contact"; // window text
            this.buttonAddNew.Text = "Update"; // the action of this button in update mode is updating
        }

        #endregion

        // This method is taking care about the user application to add or update contact
        private void AddUpdateAction()
        {
            // convert the string to title case ( only the first letter is capital )
            string firstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.textBoxFirstName.Text);
            // convert the string to title case ( only the first letter is capital )
            string lastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.textBoxLastName.Text);
            string phoneNumber = this.textBoxPhoneNumber.Text;
            string gender = this.comboBoxGender.SelectedItem.ToString();
            // validate that names and phone are valid
            if (ValidateFormInput())
            {
                // update case
                if (updateMode)
                {
                    // there is message only if message occurred
                    if (DBMngProxy.UpdateContact(firstName, lastName, phoneNumber, gender, this.updateId) != 1)
                    {
                        MessageBox.Show("Please try again later", "There was a problem to update this contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // new contact case
                else
                {
                    // there is message only if message occurred
                    if (DBMngProxy.InsertNewContact(firstName, lastName, phoneNumber, gender) != 1)
                    {
                        MessageBox.Show("Please try again later", "There was a problem add new contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            this.sender.ReloadData();
        }

        #region Buttons action

        // The button action is to active add or update related to the updateMode
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            AddUpdateAction();
        }

        // Cancel the application and close the form
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "All the data will be lost", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        // Form reset
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // reset is clears the form input controls, only for new contact application
            if (updateMode)
            {
                MessageBox.Show("reset cant be used for update applications");
                return;
            }
            if (MessageBox.Show("reset current application?", "All the data will be lost!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.textBoxFirstName.Clear();
                this.textBoxLastName.Clear();
                this.textBoxPhoneNumber.Clear();
                this.comboBoxGender.SelectedIndex = defaultGenderIndex;
                this.textBoxFirstName.Focus();
            }
        }

        #endregion

        #region Enter press

        // Active the add or update action when enter is pressed by the user

        // Pressed on form
        private void FormNewContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.AddUpdateAction();
            }
        }

        // Pressed on first name
        private void textBoxFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.AddUpdateAction();
            }
        }

        // Pressed on last name
        private void textBoxLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.AddUpdateAction();
            }
        }

        // Pressed on phone number
        private void textBoxPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.AddUpdateAction();
            }
        }

        #endregion

        #region Input validation

        /* Form inputs check
         * only english letters for names, valid phone numbers
         * phone numbers can not be duplicated
        */
        private bool ValidateFormInput()
        {
            bool c = this.ValidateName(this.textBoxFirstName.Text)
                && this.ValidateName(this.textBoxLastName.Text)
                && this.ValidatePhoneNumber(this.textBoxPhoneNumber.Text);
            // checking for phone number duplications is needed only when new contact is added
            int otherId = ValidatePhoneNumberExists(this.textBoxPhoneNumber.Text);
            if (updateMode)
            {
                return c && (otherId == this.updateId || otherId == -1);
            }
            return c && otherId == -1;
        }

        // Valide names, only english letters are allowed
        private bool ValidateName(string name)
        {
            // Regular expression for only english letters check
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Name can only contain english letters", "Unaccepted chars");
                return false;
            }
            // Checking that the name is not too long ( max length is 36 chars )
            if (name.Length >= 50)
            {
                MessageBox.Show("The maximum name length is 36 chars please fix it", "this name is too long");
                return false;
            }

            return true;
        }

        // Validate phone number ( by the standarts of Israel )
        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Regular expression for valid phone numbers, Credit : http://www.lehavi.com/post/8
            if (!Regex.IsMatch(phoneNumber, @"^0\d([\d]{0,1})([-]{0,1})\d{7}$"))
            {
                MessageBox.Show("This number doesnt seems to be valid phone number", "Unaccepted chars");
                return false;
            }
            // Checking that the string have logic length
            if (phoneNumber.Length > 10 || phoneNumber.Length < 9)
            {
                MessageBox.Show("This number doesnt seems to be valid phone number", "Unaccepted length");
                return false;
            }

            return true;
        }

        // Validate that the desired phone number doesnt already exits, the method return
        private int ValidatePhoneNumberExists(string phoneNumber)
        {
            int otherId = DBMngProxy.PhoneNumberExists(phoneNumber);
            // in case of update
            if (updateMode)
            {

                if (otherId != this.updateId && otherId != -1)
                {
                    MessageBox.Show("Please enter other phone number", "This phone number is already in use by other contact");
                    this.textBoxPhoneNumber.Clear();
                    this.textBoxPhoneNumber.Focus();
                }
            }
            else
            {
                if (otherId != -1)
                {
                    MessageBox.Show("Please enter other phone number", "This phone number is already in use by other contact");
                    this.textBoxPhoneNumber.Clear();
                    this.textBoxPhoneNumber.Focus();
                }
            }
            return otherId;
        }

        #endregion
    }
}
