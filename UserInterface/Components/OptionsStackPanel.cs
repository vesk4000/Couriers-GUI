using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couriers_GUI.Backend.Services.Implementations;
using Couriers_GUI.Backend.Services.ServiceModels;
using Couriers_GUI.UserInterface.Pages.Tables;
using System.Drawing;

namespace Couriers_GUI.UserInterface.Components
{
	public class OptionsStackPanel : StackPanel
	{
		public List<Control> options = new List<Control>();
		public object tableService;
		public TableView tableView;


		public OptionsStackPanel() : base() { }

		
		public OptionsStackPanel(
			string header,
			object tableService,
			string leftButtonName,
			Action<OptionsStackPanel> leftButtonAction,
			TableView tableView,
			object model = null,
			bool validate = true,
			bool addOptions = true
		) : base(header)
		{
			this.tableService = tableService;
			this.tableView = tableView;

			BackColor = InterfaceSingleton.LIGHT_BACKGROUND;

			if(addOptions)
				AddOptions(model);

			var validationLabel = new CommonLabel();
			validationLabel.Text = "Parameters entered are invalid!";
			validationLabel.ForeColor = Color.Red;
			validationLabel.Visible = false;
			AddControl(validationLabel);

			var dualButtons = new DualButtonBlock
			(
				() =>
				{
					if(validate)
					{
						if(AreOptionsValid())
						{
							leftButtonAction.Invoke(this);
							SwitchToTableView();
						}
						else
							validationLabel.Visible = true;
					}
				},
				SwitchToTableView
			);
			dualButtons.commonButton1.Text = leftButtonName;
			dualButtons.commonButton2.Text = "Cancel";
			AddControl(dualButtons);
		}


		public void AddOptions(object serviceModel = null)
		{
			if(tableService is OrderService)
			{
				if(serviceModel is null)
					serviceModel = new OrderDetailsServiceModel(DateTime.Now, DateTime.Now, "", "", "", "", "", "", "");

				OrderDetailsServiceModel model = new OrderDetailsServiceModel(DateTime.Now, DateTime.Now, "", "", "", "", "", "", "");

				if(serviceModel is OrderFilterServiceModel)
				{
					var modelFilter = serviceModel as OrderFilterServiceModel;

					var orderDate = new DatePickerBlock();
					orderDate.commonLabel1.Text = "Order Date:";
					orderDate.commonDateTimePicker1.Value = modelFilter.OrderDateFrom;
					orderDate.commonDateTimePicker2.Value = modelFilter.OrderDateTo;
					AddControl(orderDate);
					options.Add(orderDate);

					var receiveDate = new DatePickerBlock();
					receiveDate.commonLabel1.Text = "Receive Date:";
					receiveDate.commonDateTimePicker1.Value = modelFilter.ReceiveDateFrom;
					receiveDate.commonDateTimePicker2.Value = modelFilter.ReceiveDateTo;
					AddControl(receiveDate);
					options.Add(receiveDate);
				}
				else if(serviceModel is OrderDetailsServiceModel)
				{
					model = serviceModel as OrderDetailsServiceModel;

					var orderDate = new SingleDatePickerBlock();
					orderDate.commonLabel1.Text = "Order Date:";
					orderDate.commonDateTimePicker1.Value = model.OrderDate;
					AddControl(orderDate);
					options.Add(orderDate);

					var receiveDate = new SingleDatePickerBlock();
					receiveDate.commonLabel1.Text = "Receive Date:";
					receiveDate.commonDateTimePicker1.Value = model.ReceiveDate;
					AddControl(receiveDate);
					options.Add(receiveDate);
				}

				var total = new TextBoxBlock();
				total.commonLabel1.Text = "Total";
				total.commonTextBox1.Text = model.Total;
				AddControl(total);
				options.Add(total);
				
				var address = new CompletableTextBoxBlock();
				address.commonLabel1.Text = "Address";
				address.completableTextBox1.Text = model.Address;
				address.completableTextBox1.dataSource = new AddressService().AllString().ToList();
				AddControl(address);
				options.Add(address);
			}
			else if(tableService is CourierService)
			{
				CourierServiceModel courierServiceModel; 
				if(serviceModel is null)
					courierServiceModel = new CourierServiceModel("", "");
				else
					courierServiceModel = serviceModel as CourierServiceModel;
				
				var name = new TextBoxBlock();
				name.commonLabel1.Text = "Name";
				name.commonTextBox1.Text = courierServiceModel.Name;
				AddControl(name);
				options.Add(name);

				var phone = new TextBoxBlock();
				phone.commonLabel1.Text = "Phone";
				phone.commonTextBox1.Text = courierServiceModel.PhoneNumber;
				AddControl(phone);
				options.Add(phone);
			}
		}


		public object GetOptions()
		{
			object ans = null;

			if(tableService is OrderService)
			{
				var total = options[2] as TextBoxBlock;
				var address = options[3] as CompletableTextBoxBlock;

				var model = new OrderDetailsServiceModel(DateTime.Now, DateTime.Now, total.commonTextBox1.Text, address.completableTextBox1.Text, null, null, null, null, null);

				if(options[0] is DatePickerBlock)
				{
					var orderDate = options[0] as DatePickerBlock;
					var receiveDate = options[1] as DatePickerBlock;
					var modelFilter = new OrderFilterServiceModel
					(
						orderDate.commonDateTimePicker1.Value,
						orderDate.commonDateTimePicker2.Value,
						receiveDate.commonDateTimePicker1.Value,
						receiveDate.commonDateTimePicker2.Value,
						model.Total,
						model.Address,
						model.Client,
						model.Courier,
						model.Dispatcher,
						model.Recipient,
						model.Type
					);
					return modelFilter;
				}
				else
				{
					var orderDate = options[0] as SingleDatePickerBlock;
					var receiveDate = options[1] as SingleDatePickerBlock;
					model.OrderDate = orderDate.commonDateTimePicker1.Value;
					model.ReceiveDate = receiveDate.commonDateTimePicker1.Value;
				}
				return model;
			}
			else if(tableService is CourierService)
			{
				var name = options[0] as TextBoxBlock;
				var phone = options[1] as TextBoxBlock;
				return new CourierServiceModel(name.commonTextBox1.Text, phone.commonTextBox1.Text);
			}

			return ans;
		}


		public void SwitchToTableView()
		{
			if (Parent is TableContainer && tableView is TableView)
			{
				Parent.Controls.Add(tableView);
				tableView.InitDataGridView();
				Parent.Controls.Remove(this);
			}
			else
				MessageBox.Show("OptionsStackPanel: Parent must be TableContainer and tableView must not be null!");

		}


		public bool AreOptionsValid()
		{
			if(tableService is OrderService)
			{
				return true;
			}
			if(tableService is CourierService)
			{
				return (tableService as CourierService).Validate(GetOptions() as CourierServiceModel);
			}
			return false;
		}



	}
}
