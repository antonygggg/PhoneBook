using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace PhoneBook
{
	/* This is the main form of the program
     * here you can watch all the contacts and change settings
     */
	public partial class FormMain : Form
	{
		// This static is needed to be proxy for the vcf generate methods and the saveFileDialog
		public static string vcfHelper;

		// The default gender to be displayed
		private readonly byte defaultSearchGenderIndex = 0;

		// Constructor
		public FormMain()
		{
			InitializeComponent();
			this.comboBoxGender.SelectedIndex = defaultSearchGenderIndex; // select "All" as default value
																		  // Set Connection string for DBMngProxy
			DBMngProxy.ConnectionString = ConfigurationManager.ConnectionStrings["PhoneBook.Properties.Settings.ContactsDBConnectionString"].ConnectionString;
			// Load local settings
			LoadConfigurations();
			// Validate that the database was not modified since the last run
			ValidateDataSource();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'contactsDBDataSet.ContactsTable' table. You can move, or remove it, as needed.
			this.contactsTableTableAdapter.Fill(this.contactsDBDataSet.ContactsTable);
			this.dataGridViewContacts.CurrentCell = null; // remove the auto selection of the first row

		}

		/* This function is used by other object to "force" reloading of the GridView data
         * the main purpose of it, is to refresh immediately when new user is created or an existing user was updated
         * by the "FormNewContact"
         */
		public void ReloadData()
		{
			// Reload GridView data
			this.contactsTableTableAdapter.Fill(this.contactsDBDataSet.ContactsTable);
			// Updates the search group header
			this.groupBoxSearch.Text = "Search ( " + this.contactsTableBindingSource.Count + " )";
		}

		// Simple exit
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit(); // simple exit
		}

		// Simple copy of the cell content when the user clicks on it, if this option is active
		private void dataGridViewContacts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// Checking if auto copy is on
			if (this.copyOnClickToolStripMenuItem.Checked)
			{
				// clipboard text is set to the clicked cell content ( only if the contect is not empty ), there is also row and column check to avoid out of bound
				if (e.RowIndex >= 0 && e.ColumnIndex > 2 && this.dataGridViewContacts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					System.Windows.Forms.Clipboard.SetText(this.dataGridViewContacts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
				}
			}
		}

		// Configuration save interface, the default config file is "PhoneBook.exe.config"
		private void SaveSettingInConfigurationFile(string key, string value)
		{
			try
			{
				Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
				config.AppSettings.Settings[key].Value = value;
				config.Save(ConfigurationSaveMode.Minimal);
			}
			catch (Exception e)
			{
				throw new Exception("There was error to save setting key", e);
			}
		}

		// This is help method for loading the application configuration file in order to countinue a=the last run
		private void LoadConfigurations()
		{
			try
			{
				// search bar visibility
				this.searchBarToolStripMenuItem.Checked = System.Convert.ToBoolean(ConfigurationManager.AppSettings["searchBarToolStripMenuItem.Checked"]);
				// copy cell content on click
				this.copyOnClickToolStripMenuItem.Checked = System.Convert.ToBoolean(ConfigurationManager.AppSettings["copyOnClickToolStripMenuItem.Checked"]);
				// displaying of warning prompt before removing contact
				this.disablePromptToolStripMenuItem.Checked = System.Convert.ToBoolean(ConfigurationManager.AppSettings["disablePromptToolStripMenuItem.Checked"]);
			}
			catch (Exception e)
			{
				// in case of error the default values will be set
				this.searchBarToolStripMenuItem.Checked = true;
				this.copyOnClickToolStripMenuItem.Checked = false;
				this.copyOnClickToolStripMenuItem.Checked = true;
				MessageBox.Show("Configuration file error \n\r" + e.Message);

			}
		}

		/* This function starts when "edit" or "remove" are clicked
 *  this algorythem makes different between  edit or remove and trigger the relevant action
 */
		private void dataGridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return; // avoid from header clicks
			}

			// the remove link is at the 0 index
			if (e.ColumnIndex == 0)
			{
				this.RemoveContact(int.Parse(this.dataGridViewContacts.Rows[e.RowIndex].Cells["id"].Value.ToString()));
			}
			// the update link is at the 1 index
			if (e.ColumnIndex == 1)
			{
				string fn = this.dataGridViewContacts.Rows[e.RowIndex].Cells["firstName"].Value.ToString();
				string ln = this.dataGridViewContacts.Rows[e.RowIndex].Cells["lastName"].Value.ToString();
				string pn = this.dataGridViewContacts.Rows[e.RowIndex].Cells["phoneNumber"].Value.ToString();
				string g = this.dataGridViewContacts.Rows[e.RowIndex].Cells["gender"].Value.ToString();
				int id = int.Parse(this.dataGridViewContacts.Rows[e.RowIndex].Cells["id"].Value.ToString());
				this.UpdateContact(fn, ln, pn, g, id);
			}
			// Contact vCard save for single contact
			if (e.ColumnIndex == 2)
			{
				string fn = this.dataGridViewContacts.Rows[e.RowIndex].Cells["firstName"].Value.ToString();
				string ln = this.dataGridViewContacts.Rows[e.RowIndex].Cells["lastName"].Value.ToString();
				// form the namme of the file, for example vCard_1.1.2001
				this.saveFileDialogMain.FileName = fn + "_" + ln + "_vCard";
				// prepare the file content via the static string vcfHelper
				FormMain.vcfHelper = GenerateVCFSingle(this.dataGridViewContacts.Rows[e.RowIndex]);
				// set the user Desktop to be the default save path
				this.saveFileDialogMain.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				this.saveFileDialogMain.ShowDialog();
			}
		}

		/* This validation checks that the database was not modified out side of the programn since the last run,  using sha1
         * if it was the program will terminate
         */
		public bool ValidateDataSource()
		{
			// if the database file was not found the program will terminate
			if (!DBMngProxy.DatabaseFileExists())
			{
				MessageBox.Show("Database was not found, please reinstall the program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0); // close the program
			}
			return true;
		}

		#region Search prepare

		// Clear the textboxes for new search and focus the relevant control
		private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitSearch();
			this.searchBarToolStripMenuItem.Checked = true; //turn search group into visible
			this.textBoxSearchFirstName.Focus();
		}

		private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitSearch();
			this.searchBarToolStripMenuItem.Checked = true; //turn search group into visible
			this.textBoxSerachLastName.Focus();
		}

		private void phoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitSearch();
			this.searchBarToolStripMenuItem.Checked = true; //turn search group into visible
			this.textBoxSearchPhoneNumber.Focus();
		}

		private void maleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitSearch();
			this.searchBarToolStripMenuItem.Checked = true; //turn search group into visible
			this.comboBoxGender.SelectedIndex = 1;
			this.textBoxSearchFirstName.Focus();
		}

		private void femaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitSearch();
			this.searchBarToolStripMenuItem.Checked = true; //turn search group into visible
			this.comboBoxGender.SelectedIndex = 2;
			this.textBoxSearchFirstName.Focus();
		}

		private void resetSearchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitSearch();
			this.searchBarToolStripMenuItem.Checked = true; // turn search group into visible
			this.comboBoxGender.SelectedIndex = defaultSearchGenderIndex;
		}

		// This function resets all the controls, sets the gender  comboBox to "All"
		private void InitSearch()
		{
			this.textBoxSearchFirstName.Clear();
			this.textBoxSerachLastName.Clear();
			this.textBoxSearchPhoneNumber.Clear();
			this.comboBoxGender.SelectedIndex = this.defaultSearchGenderIndex;
			this.ReloadData();
		}

		#endregion

		#region Live Search

		/* Live Search
         * these methods are activated each time one of the four inputs inside the group are changed
         * for the textbox the Text and for the comboBox the SelectedIndex
         * the MaxLength of each textbox is 12 chars
        */
		private void textBoxSearchFirstName_TextChanged(object sender, EventArgs e)
		{
			UpdateLiveSearch();
		}

		private void textBoxSerachLastName_TextChanged(object sender, EventArgs e)
		{
			UpdateLiveSearch();
		}

		private void textBoxSearchPhoneNumber_TextChanged(object sender, EventArgs e)
		{
			UpdateLiveSearch();
		}

		private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateLiveSearch();
		}

		/* Search function based on four filters, the logic connection of the search is AND, each match
         * is based on contents ( LIKE '%string%' ) except the gender that should equals
         */
		private void UpdateLiveSearch()
		{
			// this makes SQL based filter according to the search parameters
			this.contactsTableBindingSource.Filter = String.Format(@"firstName LIKE '%{0}%'
                                                AND lastName LIKE '%{1}%'
                                                AND phoneNumber LIKE '%{2}%'
                                                AND ( gender='{3}' OR 'All'='{3}' )",
												this.textBoxSearchFirstName.Text, this.textBoxSerachLastName.Text, this.textBoxSearchPhoneNumber.Text, this.comboBoxGender.SelectedItem.ToString().ToLower());
			this.ReloadData(); // set the group text
			this.dataGridViewContacts.CurrentCell = null; // remove the auto selection of the first row

		}

		#endregion

		#region Save vcf methods

		/* Save the record into a vCard
        */

		// prepare save dialog for saving the vcf file
		private void saveAsvcfToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// this option is available only if there are contacts
			if (this.contactsTableBindingSource.Count > 0)
			{
				// form the namme of the file, for example vCard_1.1.2001
				this.saveFileDialogMain.FileName = "vCard_" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
				// prepare the file content via the static string vcfHelper
				FormMain.vcfHelper = this.GenerateVCF();
				// set the user Desktop to be the default save path
				this.saveFileDialogMain.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				this.saveFileDialogMain.ShowDialog();
			}
			else
			{
				MessageBox.Show("There are no contacts to save");
			}
		}

		// Save vCard,  this is the final save action after the user click "Save" in the save dialog
		private void saveFileDialogMain_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				System.IO.File.WriteAllText(saveFileDialogMain.FileName, FormMain.vcfHelper);
			}
			catch (Exception exp)
			{
				throw new Exception("There was an error to save in this direction", exp);
			}
		}

		private string GenerateVCFSingle(DataGridViewRow row)
		{
			StringBuilder sb = new StringBuilder(); // used to avoid messing with string new line chars
			sb.AppendLine("BEGIN:VCARD"); // begin
			sb.AppendLine("VERSION:2.1"); // version
			sb.AppendLine("N:" + row.Cells["lastName"].Value.ToString() + ";" + row.Cells["firstName"].Value.ToString()); // name
			sb.AppendLine("FN:" + row.Cells["firstName"].Value.ToString() + " " + row.Cells["lastName"].Value.ToString()); // first name
			sb.AppendLine("TEL;CELL;VOICE:" + row.Cells["phoneNumber"].Value.ToString()); // phone number
			sb.AppendLine("END:VCARD"); //end
			return sb.ToString();
		}

		// This method generate vcf from GridView's data and return it string that represent it 
		private string GenerateVCF()
		{
			StringBuilder sb = new StringBuilder(); // used to avoid messing with string new line chars
			foreach (DataGridViewRow row in this.dataGridViewContacts.Rows)
			{
				// for each contact there is section
				sb.AppendLine("BEGIN:VCARD"); // begin
				sb.AppendLine("VERSION:2.1"); // version
				sb.AppendLine("N:" + row.Cells["lastName"].Value.ToString() + ";" + row.Cells["firstName"].Value.ToString()); // name
				sb.AppendLine("FN:" + row.Cells["firstName"].Value.ToString() + " " + row.Cells["lastName"].Value.ToString()); // first name
				sb.AppendLine("TEL;CELL;VOICE:" + row.Cells["phoneNumber"].Value.ToString()); // phone number
				sb.AppendLine("END:VCARD"); //end
			}
			return sb.ToString();
		}

		#endregion

		#region Contact add, update and remove

		// Open the form for new contact, this constractor doesnt trigger the updateMode
		private void newContactToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormNewContact nc = new FormNewContact(this);
			nc.Show();
			// Reload data after a new contact maybe was added
			this.ReloadData();
		}

		// This method will confirm that the user really want to remove all the contacts
		private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RemoveAllContacts();
		}

		// Remove contact from the database ( and of course from the GridView ), int "id" is the unique identical of the contact
		private void RemoveContact(int id)
		{
			// Checking if the user is sure about the action or if he disabled the confirm prompt
			if (this.disablePromptToolStripMenuItem.Checked || MessageBox.Show("Are you sure?", "You are about to remove this contact from the list", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				// if the contact was successfully removed
				if (DBMngProxy.RemoveContact(id) == 1)
				{
					this.ReloadData(); //reload the GridView data
					return;
				}
				// if nothing wasnt returned until now, somthing went wrong and nothing was removed
				MessageBox.Show("Something went wrong, nothing was removed");
			}
		}

		// Open the "FormNewContacts" in updateMode using the suitable constructor with the user information from the declaration
		private void UpdateContact(string firstName, string LastName, string phoneNumber, string gender, int id)
		{
			// FormNewContact will do the whole update
			FormNewContact nc = new FormNewContact(this, firstName, LastName, phoneNumber, gender, id);
			nc.Show();
			this.ReloadData(); // reload date
		}

		// Remove all the contacts
		private void RemoveAllContacts()
		{
			if (MessageBox.Show("Are you sure?", this.contactsTableBindingSource.Count + " will be remove(d)", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				DBMngProxy.RemoveAllContacts();
			}
			this.ReloadData(); // reload date
		}

		#endregion

		#region Local options and configuration

		// Save the disable prompt setting for the next time
		private void disablePromptToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
		{
			// save the settings in the default configuration file
			this.SaveSettingInConfigurationFile("disablePromptToolStripMenuItem.Checked", this.disablePromptToolStripMenuItem.Checked.ToString());
		}

		// Save the click on copy settings for the next time
		private void copyOnClickToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
		{
			// save the settings in the default configuration file
			this.SaveSettingInConfigurationFile("copyOnClickToolStripMenuItem.Checked", this.copyOnClickToolStripMenuItem.Checked.ToString());
		}

		// Hide the search bar
		private void searchBarToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
		{
			this.groupBoxSearch.Visible = searchBarToolStripMenuItem.Checked;
			// adjust the datagridview size and location for using the whole available space
			this.dataGridViewContacts.Location = new Point(this.dataGridViewContacts.Location.X, searchBarToolStripMenuItem.Checked ? 96 : 27);
			this.dataGridViewContacts.Size = new Size(this.dataGridViewContacts.Size.Width, searchBarToolStripMenuItem.Checked ? this.dataGridViewContacts.Height - 69 : this.dataGridViewContacts.Height + 69);
			// save the config for the next load
			this.SaveSettingInConfigurationFile("searchBarToolStripMenuItem.Checked", searchBarToolStripMenuItem.Checked.ToString());
		}

		#endregion

		#region  Clear buttons

		/* The actions for the "x" buttons
         * each button clears his fitting textbox
         */
		private void linkLabelClearFirstName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// first name textbox
			this.textBoxSearchFirstName.Clear();
		}

		private void linkLabelClearLastName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// last name textbox
			this.textBoxSerachLastName.Clear();
		}

		private void linkLabelClearPhoneNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// phone number textbox
			this.textBoxSearchPhoneNumber.Clear();
		}

		#endregion

	}
}
