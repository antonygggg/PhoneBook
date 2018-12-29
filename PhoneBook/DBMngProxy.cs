using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace PhoneBook
{

	// This class is a static container class for the interface needs in order to connect with the database
	public static class DBMngProxy
	{

		/* Contacts Database string
        *private static OleDbConnection contactsDBConn, used to connect
        *ACCDB 2013 connection string
         */
		private static OleDbConnection contactsDBConn = new OleDbConnection();

		// Retrieve the path of the database file name, using the ConnectionString
		private static string GetDatabasePath()
		{
			// to null reference or out of bounds
			if (ConnectionString != null && ConnectionString != string.Empty)
			{
				return ConnectionString.Substring(ConnectionString.IndexOf("=", ConnectionString.IndexOf("Source=")) + 1);
			}
			return string.Empty;
		}

		// public interface for checking about the database existing
		public static bool DatabaseFileExists()
		{
			return File.Exists(GetDatabasePath());
		}

		// CennctionString get and set
		public static string ConnectionString
		{
			get
			{
				return DBMngProxy.contactsDBConn.ConnectionString;
			}
			set
			{
				DBMngProxy.contactsDBConn.ConnectionString = value;
			}
		}

		// Remove contact by id and return how many rows were affected
		public static int RemoveContact(int id)
		{
			return ExecuteNonQuery(String.Format("DELETE FROM ContactsTable Where id={0}", id));
		}

		// Remove all the contacts from ContactsTable
		public static int RemoveAllContacts()
		{
			return ExecuteNonQuery("DELETE FROM ContactsTable");
		}

		// Insert new contact into the database with the details from the declaration, the method returns the number of affected rows
		public static int InsertNewContact(string firstName, string lastName, string phoneNumber, string gender)
		{
			return ExecuteNonQuery(String.Format("INSERT INTO ContactsTable (firstName, lastName, phoneNumber, gender) VALUES ('{0}','{1}','{2}','{3}')",
				firstName, lastName, phoneNumber, gender));

		}

		// Update existing contact to the details from the declaration, the method returns the number of affected rows
		public static int UpdateContact(string firstName, string lastName, string phoneNumber, string gender, int id)
		{
			return ExecuteNonQuery(string.Format("UPDATE ContactsTable SET firstName='{0}', lastName='{1}', phoneNumber='{2}', gender='{3}' WHERE id={4}",
				firstName, lastName, phoneNumber, gender, id));
		}

		/* The method is checking whether an existing contact have this phone number already, the purpose of the method is to
         * avoid duplications of phone numbers
         * the method return the id if found the same phone number or -1 in other case
         */
		public static int PhoneNumberExists(string phoneNumber)
		{
			int id = -1; // default state is not found
			OleDbCommand oleDbCmd;
			try
			{
				contactsDBConn.Open(); // start connection				   
				oleDbCmd = new OleDbCommand("SELECT * FROM ContactsTable WHERE phoneNumber='" + phoneNumber + "'", contactsDBConn); // sql query
				if (oleDbCmd != null)
				{
					OleDbDataReader dr = oleDbCmd.ExecuteReader();
					if (dr != null)
					{
						dr.Read(); // moving to first row if available
						if (dr.HasRows)
						{
							id = Convert.ToInt32(dr["id"]);
						}
					}
				}
				contactsDBConn.Close(); //connection close
				return id;
			}
			catch (Exception e)
			{
				// if something wen wrong Exception will be thrown
				contactsDBConn.Close();
				throw new Exception("An error occured", e);
			}
		}

		// This is help method for executing non query sql commands, "sqlCmd" is the requaierd command, the method returns the number of affected rows
		private static int ExecuteNonQuery(string sqlCmd)
		{
			OleDbCommand oleDbCmd;
			try
			{
				int affectedRows; // prepare int for affected rows
				contactsDBConn.Open(); // start connection
				oleDbCmd = new OleDbCommand(sqlCmd, contactsDBConn);
				affectedRows = oleDbCmd.ExecuteNonQuery(); // execute the sql command
				contactsDBConn.Close(); // connection close
				return affectedRows;
			}
			catch (Exception e)
			{
				// if something wen wrong Exception will be thrown
				throw new InvalidOperationException("Data could not be read, try again later", e);
			}
		}
	}
}
