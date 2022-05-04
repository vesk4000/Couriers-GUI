using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couriers_GUI.Backend.Services;
using Couriers_GUI.Backend.Services.Implementations;

namespace Couriers_GUI.UserInterface.Pages.Tables
{
	public partial class DeletePage : UserControl
	{
		public int id;

		public DeletePage()
		{
			InitializeComponent();
		}

		public void Init()
		{
			/*if(Parent is TableContainer)
			{
				TableContainer parent = Parent as TableContainer;
				object tableService = parent.tableService;
				if(tableService is OrderService)
				{
					//tableLayoutPanel2.Controls.Add()
				}
				else if(tableService is CourierService)
				{
					var courierService = tableService as CourierService;

					var name = new Components.TextBoxBlock();
					name.commonLabel1.Text = "Name";
					//name.commonTextBox1.Text = courierService.
					tableLayoutPanel2.Controls.Add(name, 0, 0);

					var phone = new Components.TextBoxBlock();
					phone.commonLabel1.Text = "Phone";
					tableLayoutPanel2.Controls.Add(phone, 0, 1);
				}
			}
			else
			{
				MessageBox.Show("AddPage: Parent has to be a TableContainer");
				return;
			}*/
		}

		private void commonButtonAdd_Click(object sender, EventArgs e)
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
					var courierService = tableService as CourierService;
					courierService.Remove(id);
				}
				else if(tableService is AddressService)
				{
					var courierService = tableService as AddressService;
					courierService.Remove(id);
				}
				else if(tableService is ClientService)
				{
					var clientService = tableService as ClientService;
					clientService.Remove(id);
				}

				SwitchToView();
			}
			else
			{
				MessageBox.Show("AddPage: Parent has to be a TableContainer");
				return;
			}
		}

		private void SwitchToView()
		{
			var view = new TableView();
			Parent.Controls.Add(view);
			view.InitDataGridView();
			view.Dock = DockStyle.Fill;
			Parent.Controls.Remove(this);
		}

		private void commonButtonCancel_Click(object sender, EventArgs e)
		{
			if(Parent is TableContainer)
			{
				SwitchToView();
			}
			else
			{
				MessageBox.Show("AddPage: Parent has to be a TableContainer");
				return;
			}
		}
	}
}
