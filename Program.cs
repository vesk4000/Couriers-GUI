using Couriers_GUI.User_Interface.Development;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// TODO: Write a better version of the code that determines which form to open


			if (args.Count() != 0)
			{
				if (args[0] == "test")
					Application.Run(new User_Interface.Development.TestForm());
				else
					Application.Run(new User_Interface.Form1());
			}
			else
				Application.Run(new User_Interface.Form1());
		}
	}
}
