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
	public partial class EditPage : UserControl
	{
		public int id;

		public EditPage()
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
					var courierService = tableService as CourierService;

					var name = new Components.TextBoxBlock();
					name.commonLabel1.Text = "Name";
					//name.commonTextBox1.Text = courierService.
					tableLayoutPanel2.Controls.Add(name, 0, 0);

					var phone = new Components.TextBoxBlock();
					phone.commonLabel1.Text = "Phone";
					tableLayoutPanel2.Controls.Add(phone, 0, 1);
				}
				else if(tableService is AddressService)
				{
					var addressService = tableService as AddressService;

					var address = new Components.TextBoxBlock();
					address.commonLabel1.Text = "Address";
					tableLayoutPanel2.Controls.Add(address, 0, 0);
				}
				else if(tableService is ClientService)
				{
					var clientService = tableService as ClientService;

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
			}
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

					var name = tableLayoutPanel2.GetControlFromPosition(0, 0) as Components.TextBoxBlock;
					var phone = tableLayoutPanel2.GetControlFromPosition(0, 1) as Components.TextBoxBlock;

					var model = new Backend.Services.ServiceModels.CourierServiceModel(id, name.commonTextBox1.Text, phone.commonTextBox1.Text);
					if(courierService.Validate(model))
					{
						courierService.Edit(model);
					}
					else
					{
						commonLabel2.Visible = true;
						return;
					}
				}
				else if(tableService is AddressService)
				{
					var addressService = tableService as AddressService;

					var address = tableLayoutPanel2.GetControlFromPosition(0, 0) as Components.TextBoxBlock;

					var model = new Backend.Services.ServiceModels.AddressServiceModel(id, address.commonTextBox1.Text);
					if(addressService.Validate(model))
					{
						addressService.Edit(model);
					}
					else
					{
						commonLabel2.Visible = true;
						return;
					}
				}
				else if(tableService is ClientService)
				{
					var clientService = tableService as ClientService;

					var name = tableLayoutPanel2.GetControlFromPosition(0, 0) as Components.TextBoxBlock;
					var phone = tableLayoutPanel2.GetControlFromPosition(0, 1) as Components.TextBoxBlock;

					var model = new Backend.Services.ServiceModels.ClientServiceModel(id, name.commonTextBox1.Text, phone.commonTextBox1.Text);
					if(clientService.Validate(model))
					{
						clientService.Edit(model);
					}
					else
					{
						commonLabel2.Visible = true;
						return;
					}
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
