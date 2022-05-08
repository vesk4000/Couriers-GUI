using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couriers_GUI.Backend.Services.Implementations;

namespace Couriers_GUI.UserInterface.Pages
{
	public partial class ServerPage : UserControl
	{
		public ServerPage()
		{
			InitializeComponent();
		}

		private void commonButton1_Click(object sender, EventArgs e)
		{
			DBService.CreateDB();
			DBService.PopulateDB();
			DBService.CreateAllUPSs();
		}
	}
}
