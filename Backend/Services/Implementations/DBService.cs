using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Couriers_GUI.Backend.Services.SQLDBCreateScript;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Couriers_GUI.Models;

namespace Couriers_GUI.Backend.Services.Implementations
{
	static class DBService
	{
		private static void ExecuteScript(string SQLScript)
		{
			try
			{
				string script = SQLScript;

				System.Collections.Generic.IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
										 RegexOptions.Multiline | RegexOptions.IgnoreCase);
				using (SqlConnection connection = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=.\\SQLEXPRESS;User Id={System.Security.Principal.WindowsIdentity.GetCurrent().Name};Password="))
				{
					connection.Open();
					foreach (string commandString in commandStrings)
					{
						if (commandString.Trim() != "")
						{
							using (var command = new SqlCommand(commandString.Trim(), connection))
							{
								try
								{
									command.ExecuteNonQuery();
								}
								catch (SqlException ex)
								{
									string spError = commandString.Length > 100 ? commandString.Substring(0, 100) + " ...\n..." : commandString;
									MessageBox.Show(string.Format("Please check the SqlServer script.\nLine: {0} \nError: {1} \nSQL Command: \n{2}", ex.LineNumber, ex.Message, spError), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									return;
								}
							}
						}
					}
				}
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}

		public static void CreateDB()
		{
			DeleteDB();

			ExecuteScript(CouriersDBScripts.createDBScript);
		}

		public static void DeleteDB()
		{
			if (DBService.ExistsDatabase())
				ExecuteScript(CouriersDBScripts.deleteDBScript);
		}

		public static void PopulateDB()
			=> ExecuteScript(CouriersDBScripts.populateDBScript);

		public static void CreateUSPs()
			=> ExecuteScript(CouriersDBScripts.createUSPsScript);

		public static void ReadUSPs()
			=> ExecuteScript(CouriersDBScripts.readUSPsScript);

		public static void UpdateUSPs()
			=> ExecuteScript(CouriersDBScripts.updateUSPsScript);

		public static void DeleteUSPs()
			=> ExecuteScript(CouriersDBScripts.deleteUSPsScript);

		public static void CreateAllUPSs()
        {
			CreateUSPs();
			ReadUSPs();
			UpdateUSPs();
			DeleteUSPs();
        }

		public static bool ExistsDatabase()
        {
			if (!ExistsConnection())
				return false;

			var tmpConn = new SqlConnection();
			string sqlCreateDBQuery;
			bool result = false;

			try
			{
				tmpConn = new SqlConnection("server=(local)\\SQLEXPRESS;Trusted_Connection=yes");

				sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = 'CouriersDB'");
			

				using (tmpConn)
				{
					using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
					{
						tmpConn.Open();

						object resultObj = sqlCmd.ExecuteScalar();

						int databaseID = 0;

						if (resultObj != null)
						{
							int.TryParse(resultObj.ToString(), out databaseID);
						}

						tmpConn.Close();

						result = (databaseID > 0);
					}
				}
			}
			catch
			{
				result = false;
			}

			return result;
		}

		public static bool ExistsConnection()
        {
			try
			{
				var tmpConn = new SqlConnection("server=(local)\\SQLEXPRESS;Trusted_Connection=yes");

				tmpConn.Open();

				tmpConn.Close();
			}
            catch
            {
				return false;
            }

			return true;
        }

		public static bool ExistTables()
		{
			if (!ExistsDatabase())
				return false;

			int exists = 0;

			try
			{
				using (var tmpConn = new SqlConnection("server=(local)\\SQLEXPRESS;Database=CouriersDB;Trusted_Connection=yes"))
				{
					tmpConn.Open();

					using (var cmd = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Addresses')) then 1 else 0 end", tmpConn))
					{
						exists += (int)cmd.ExecuteScalar() == 1 ? 1 : 0;
					}

					using (var cmd = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Clients')) then 1 else 0 end", tmpConn))
					{
						exists += (int)cmd.ExecuteScalar() == 1 ? 1 : 0;
					}

					using (var cmd = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Couriers')) then 1 else 0 end", tmpConn))
					{
						exists += (int)cmd.ExecuteScalar() == 1 ? 1 : 0;
					}

					using (var cmd = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Dispatchers')) then 1 else 0 end", tmpConn))
					{
						exists += (int)cmd.ExecuteScalar() == 1 ? 1 : 0;
					}

					using (var cmd = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Orders')) then 1 else 0 end", tmpConn))
					{
						exists += (int)cmd.ExecuteScalar() == 1 ? 1 : 0;
					}

					using (var cmd = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Recipients')) then 1 else 0 end", tmpConn))
					{
						exists += (int)cmd.ExecuteScalar() == 1 ? 1 : 0;
					}

					using (var cmd = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'TypesOfService')) then 1 else 0 end", tmpConn))
					{
						exists += (int)cmd.ExecuteScalar() == 1 ? 1 : 0;
					}

					tmpConn.Close();
				}
			}
			catch
			{
				exists = 0;
			}

			return exists == 7;
		}

		public static int RowsCount()
        {
			if (!ExistsDatabase())
				return 0;

			using (var ctx = new CouriersDBContext())
			{
				return ctx.Addresses.Count() + ctx.Clients.Count() + ctx.Couriers.Count() + ctx.Dispatchers.Count() + ctx.Recipients.Count() + ctx.TypesOfServices.Count() + ctx.Orders.Count();
			}
        }
	}
}
