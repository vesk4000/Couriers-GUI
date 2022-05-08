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
			validationLabel.StateCommon.ShortText.Color1 = Color.OrangeRed;
			validationLabel.StateCommon.ShortText.Color2 = validationLabel.StateCommon.ShortText.Color1;
			validationLabel.StateCommon.ShortText.Font = new Font(validationLabel.StateCommon.ShortText.Font.Name, validationLabel.StateCommon.ShortText.Font.Size, FontStyle.Bold);
			validationLabel.Visible = false;
			AddCenteredControl(validationLabel);

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
					else
					{
						leftButtonAction.Invoke(this);
						SwitchToTableView();
					}
				},
				SwitchToTableView
			);
			dualButtons.commonButton1.Text = leftButtonName;
			dualButtons.commonButton2.Text = "Cancel";
			dualButtons.Anchor = AnchorStyles.Top;
			AddControl(dualButtons);
		}


		public void AddOptions(object serviceModel = null)
		{
			if(tableService is OrderService)
			{
				if(serviceModel is null)
					serviceModel = new OrderDetailsServiceModel(DateTime.Now, DateTime.Now, "", "", "", "", "", "", "");
				
				OrderDetailsServiceModel model = new OrderDetailsServiceModel(DateTime.Now, DateTime.Now, "", "", "", "", "", "", "");

				if(serviceModel is OrderDetailsServiceModel)
					model = serviceModel as OrderDetailsServiceModel;

				if(serviceModel is OrderFilterServiceModel)
				{
					var modelFilter = serviceModel as OrderFilterServiceModel;

					var orderDate = new DatePickerBlock();
					orderDate.commonLabel1.Text = "Order Date";
					orderDate.commonDateTimePicker1.Value = modelFilter.OrderDateFrom;
					orderDate.commonDateTimePicker2.Value = modelFilter.OrderDateTo;
					AddCenteredControl(orderDate);
					options.Add(orderDate);

					var receiveDate = new DatePickerBlock();
					receiveDate.commonLabel1.Text = "Receive Date";
					receiveDate.commonDateTimePicker1.Value = modelFilter.ReceiveDateFrom;
					receiveDate.commonDateTimePicker2.Value = modelFilter.ReceiveDateTo;
					AddCenteredControl(receiveDate);
					options.Add(receiveDate);

					var total = new NumberRangeBlock();
					total.commonLabel1.Text = "Total";
					total.commonTextBox1.Text = modelFilter.TotalFrom;
					total.commonTextBox2.Text = modelFilter.TotalTo;
					AddCenteredControl(total);
					options.Add(total);

					model.Dispatcher = modelFilter.Dispatcher;
					model.Address = modelFilter.Address;
					model.Client = modelFilter.Client;
					model.Courier = modelFilter.Courier;
					model.Recipient = modelFilter.Recipient;
					model.Type = modelFilter.Type;
				}
				else if(serviceModel is OrderDetailsServiceModel)
				{
					model = serviceModel as OrderDetailsServiceModel;

					var orderDate = new SingleDatePickerBlock();
					orderDate.commonLabel1.Text = "Order Date";
					orderDate.commonDateTimePicker1.Value = model.OrderDate;
					AddCenteredControl(orderDate);
					options.Add(orderDate);

					var receiveDate = new SingleDatePickerBlock();
					receiveDate.commonLabel1.Text = "Receive Date";
					receiveDate.commonDateTimePicker1.Value = model.ReceiveDate;
					AddCenteredControl(receiveDate);
					options.Add(receiveDate);

					var total = new TextBoxBlock();
					total.commonLabel1.Text = "Total";
					total.commonTextBox1.Text = model.Total.Split(" ")[0];
					AddCenteredControl(total);
					options.Add(total);
				}
				
				var address = new CompletableTextBoxBlock();
				address.commonLabel1.Text = "Address";
				address.completableTextBox1.Text = model.Address;
				address.completableTextBox1.dataSource = new AddressService().AllString().ToList();
				AddCenteredControl(address);
				options.Add(address);


				var type = new CompletableTextBoxBlock();
				type.commonLabel1.Text = "Type of Order";
				type.completableTextBox1.Text = model.Type;
				type.completableTextBox1.dataSource = new TOSService().AllString().ToList();
				AddCenteredControl(type);
				options.Add(type);

				var dispatcher = new CompletableTextBoxBlock();
				dispatcher.commonLabel1.Text = "Dispatcher";
				dispatcher.completableTextBox1.Text = model.Dispatcher;
				dispatcher.completableTextBox1.dataSource = new DispatcherService().AllString().ToList();
				AddCenteredControl(dispatcher);
				options.Add(dispatcher);

				var client = new CompletableTextBoxBlock();
				client.commonLabel1.Text = "Client";
				client.completableTextBox1.Text = model.Client;
				client.completableTextBox1.dataSource = new ClientService().AllString().ToList();
				AddCenteredControl(client);
				options.Add(client);

				var courier = new CompletableTextBoxBlock();
				courier.commonLabel1.Text = "Courier";
				courier.completableTextBox1.Text = model.Courier;
				courier.completableTextBox1.dataSource = new CourierService().AllString().ToList();
				AddCenteredControl(courier);
				options.Add(courier);

				var recipient = new CompletableTextBoxBlock();
				recipient.commonLabel1.Text = "Recipient";
				recipient.completableTextBox1.Text = model.Recipient;
				recipient.completableTextBox1.dataSource = new RecipientService().AllString().ToList();
				AddCenteredControl(recipient);
				options.Add(recipient);
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
				AddCenteredControl(name);
				options.Add(name);

				var phone = new TextBoxBlock();
				phone.commonLabel1.Text = "Phone";
				phone.commonTextBox1.Text = courierServiceModel.PhoneNumber;
				AddCenteredControl(phone);
				options.Add(phone);
			}
		}


		public void AddCenteredControl(Control control)
		{
			control.Anchor = AnchorStyles.Top;
			AddControl(control);
		}

		public object GetOptions()
		{
			object ans = null;

			if(tableService is OrderService)
			{
				var address = options[3] as CompletableTextBoxBlock;
				var type = options[4] as CompletableTextBoxBlock;
				var dispatcher = options[5] as CompletableTextBoxBlock;
				var client = options[6] as CompletableTextBoxBlock;
				var courier = options[7] as CompletableTextBoxBlock;
				var recipient = options[8] as CompletableTextBoxBlock;

				var model = new OrderDetailsServiceModel(
					DateTime.Now,
					DateTime.Now,
					"",
					address.completableTextBox1.Text,
					type.completableTextBox1.Text,
					dispatcher.completableTextBox1.Text,
					client.completableTextBox1.Text,
					courier.completableTextBox1.Text,
					recipient.completableTextBox1.Text
				);

				if(options[0] is DatePickerBlock)
				{
					var orderDate = options[0] as DatePickerBlock;
					var receiveDate = options[1] as DatePickerBlock;
					var total = options[2] as NumberRangeBlock;
					var modelFilter = new OrderFilterServiceModel
					(
						orderDate.commonDateTimePicker1.Value,
						orderDate.commonDateTimePicker2.Value,
						receiveDate.commonDateTimePicker1.Value,
						receiveDate.commonDateTimePicker2.Value,
						total.commonTextBox1.Text,
						total.commonTextBox2.Text,
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
					var total = options[2] as TextBoxBlock;
					model.Total = total.commonTextBox1.Text;
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
				return (tableService as OrderService).Validate(GetOptions() as OrderDetailsServiceModel);
			}
			if(tableService is CourierService)
			{
				return (tableService as CourierService).Validate(GetOptions() as CourierServiceModel);
			}
			return false;
		}



	}
}
