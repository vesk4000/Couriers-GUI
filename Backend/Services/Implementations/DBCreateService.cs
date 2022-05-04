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

namespace Couriers_GUI.Backend.Services.Implementations
{
	static class DBCreateService
	{
		public static void CreateDatabase()
		{
			try
			{
				string script = CouriersDBCreateScript.sqlscript;

				// split script on GO command
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
	}
}
