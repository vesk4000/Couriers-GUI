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

namespace Couriers_GUI.UserInterface.Pages.Tables
{
	public partial class AddPage : UserControl
	{
		public AddPage()
		{
			InitializeComponent();
		}

		public void Init()
		{
			if(Parent is TableContainer)
			{
				TableContainer parent = Parent as TableContainer;
				object tableService = parent.tableService;
				if(tableService is OrderService)
				{
					//tableLayoutPanel2.Controls.Add()
				}
				else if(tableService is CourierService)
				{
					tableLayoutPanel2.Controls.Add(new Components.TextBoxBlock(), 0, 0);
					//tableLayoutPanel2.Get
				}
			}
			else
			{
				MessageBox.Show("AddPageS: Parent has to be a TableContainer");
				return;
			}
		}
	}
}
