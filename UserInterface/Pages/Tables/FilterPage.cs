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
using Couriers_GUI.Backend.Services.ServiceModels;

namespace Couriers_GUI.UserInterface.Pages.Tables
{
	public partial class FilterPage : UserControl
	{
		public FilterPage()
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
					var name = new Components.TextBoxBlock();
					name.commonLabel1.Text = "Name";
					tableLayoutPanel2.Controls.Add(name, 0, 0);

					var phone = new Components.TextBoxBlock();
					phone.commonLabel1.Text = "Phone";
					tableLayoutPanel2.Controls.Add(phone, 0, 1);
				}
				else if(tableService is AddressService)
				{
					var address = new Components.TextBoxBlock();
					address.commonLabel1.Text = "Address";
					tableLayoutPanel2.Controls.Add(address, 0, 0);
				}
				else if(tableService is ClientService)
				{
					var name = new Components.TextBoxBlock();
					name.commonLabel1.Text = "Name";
					tableLayoutPanel2.Controls.Add(name, 0, 0);

					var phone = new Components.TextBoxBlock();
					phone.commonLabel1.Text = "Phone";
					tableLayoutPanel2.Controls.Add(phone, 0, 1);
				}
				else if (tableService is DispatcherService)
				{
					var name = new Components.TextBoxBlock();
					name.commonLabel1.Text = "Name";
					tableLayoutPanel2.Controls.Add(name, 0, 0);

					var phone = new Components.TextBoxBlock();
					phone.commonLabel1.Text = "Phone";
					tableLayoutPanel2.Controls.Add(phone, 0, 1);
				}
				else if (tableService is RecipientService)
				{
					var name = new Components.TextBoxBlock();
					name.commonLabel1.Text = "Name";
					tableLayoutPanel2.Controls.Add(name, 0, 0);
				}
				else if (tableService is TOSService)
				{
					var type = new Components.TextBoxBlock();
					type.commonLabel1.Text = "Type";
					tableLayoutPanel2.Controls.Add(type, 0, 0);
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

					var model = new Backend.Services.ServiceModels.CourierServiceModel(name.commonTextBox1.Text, phone.commonTextBox1.Text);
					
					var view = new TableView();
					Parent.Controls.Add(view);
					view.InitDataGridView();
					view.Dock = DockStyle.Fill;
					List<CourierServiceModel> filter = courierService.Filter(name.commonTextBox1.Text, phone.commonTextBox1.Text).ToList();
					view.kryptonDataGridView1.DataSource = filter;
					Parent.Controls.Remove(this);
				}
				else if(tableService is AddressService	)
				{
					var addressService = tableService as AddressService;

					var address = tableLayoutPanel2.GetControlFromPosition(0, 0) as Components.TextBoxBlock;

					var model = new Backend.Services.ServiceModels.AddressServiceModel(address.commonTextBox1.Text);
					
					var view = new TableView();
					Parent.Controls.Add(view);
					view.InitDataGridView();
					view.Dock = DockStyle.Fill;
					List<AddressServiceModel> filter = addressService.Filter(address.commonTextBox1.Text).ToList();
					view.kryptonDataGridView1.DataSource = filter;
					Parent.Controls.Remove(this);
				}
				else if(tableService is ClientService)
				{
					var clientService = tableService as ClientService;

					var name = tableLayoutPanel2.GetControlFromPosition(0, 0) as Components.TextBoxBlock;
					var phone = tableLayoutPanel2.GetControlFromPosition(0, 1) as Components.TextBoxBlock;

					var model = new Backend.Services.ServiceModels.ClientServiceModel(name.commonTextBox1.Text, phone.commonTextBox1.Text);
					
					var view = new TableView();
					Parent.Controls.Add(view);
					view.InitDataGridView();
					view.Dock = DockStyle.Fill;
					List<ClientServiceModel> filter = clientService.Filter(name.commonTextBox1.Text, phone.commonTextBox1.Text).ToList();
					view.kryptonDataGridView1.DataSource = filter;
					Parent.Controls.Remove(this);
				}
				else if (tableService is DispatcherService)
				{
					var dispatcherService = tableService as DispatcherService;

					var name = tableLayoutPanel2.GetControlFromPosition(0, 0) as Components.TextBoxBlock;
					var phone = tableLayoutPanel2.GetControlFromPosition(0, 1) as Components.TextBoxBlock;

					var model = new Backend.Services.ServiceModels.DispatcherServiceModel(name.commonTextBox1.Text, phone.commonTextBox1.Text);

					var view = new TableView();
					Parent.Controls.Add(view);
					view.InitDataGridView();
					view.Dock = DockStyle.Fill;
					List<DispatcherServiceModel> filter = dispatcherService.Filter(name.commonTextBox1.Text, phone.commonTextBox1.Text).ToList();
					view.kryptonDataGridView1.DataSource = filter;
					Parent.Controls.Remove(this);
				}
				else if (tableService is RecipientService)
				{
					var recipientService = tableService as RecipientService;

					var name = tableLayoutPanel2.GetControlFromPosition(0, 0) as Components.TextBoxBlock;

					var model = new Backend.Services.ServiceModels.RecipientServiceModel(name.commonTextBox1.Text);

					var view = new TableView();
					Parent.Controls.Add(view);
					view.InitDataGridView();
					view.Dock = DockStyle.Fill;
					List<RecipientServiceModel> filter = recipientService.Filter(name.commonTextBox1.Text).ToList();
					view.kryptonDataGridView1.DataSource = filter;
					Parent.Controls.Remove(this);
				}
				else if (tableService is TOSService)
				{
					var typeService = tableService as TOSService;

					var type = tableLayoutPanel2.GetControlFromPosition(0, 0) as Components.TextBoxBlock;

					var model = new Backend.Services.ServiceModels.TypesOfServiceServiceModel(type.commonTextBox1.Text);

					var view = new TableView();
					Parent.Controls.Add(view);
					view.InitDataGridView();
					view.Dock = DockStyle.Fill;
					List<TypesOfServiceServiceModel> filter = typeService.Filter(type.commonTextBox1.Text).ToList();
					view.kryptonDataGridView1.DataSource = filter;
					Parent.Controls.Remove(this);
				}

				//SwitchToView();
			}
			else
			{
				MessageBox.Show("FilterPage: Parent has to be a TableContainer");
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
				MessageBox.Show("FilterPage: Parent has to be a TableContainer");
				return;
			}
		}
	}
}
