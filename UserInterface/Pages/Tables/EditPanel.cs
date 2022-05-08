using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couriers_GUI.UserInterface.Components;
using Couriers_GUI.Backend.Services.Implementations;
using Couriers_GUI.Backend.Services.ServiceModels;


namespace Couriers_GUI.UserInterface.Pages.Tables
{
	public class EditPanel : OptionsStackPanel
	{
		public EditPanel(
			object tableService,
			TableView tableView,
			int id
		) : base(
			"Edit",
			tableService,
			"Save",
			(OptionsStackPanel panel) =>
			{
				if (tableService is OrderService)
				{
					OrderService service = tableService as OrderService;
					OrderDetailsServiceModel model = panel.GetOptions() as OrderDetailsServiceModel;
					model.Id = id;
					service.Create(model);
				}
				else if (tableService is CourierService)
				{
					CourierService service = tableService as CourierService;
					CourierServiceModel model = panel.GetOptions() as CourierServiceModel;
					model.Id = id;
					service.Edit(model);
				}

			},
			tableView,
			tableService is OrderService ? new OrderDetailsServiceModel((tableService as OrderService).GetById(id).ToList()[0].OrderDate, (tableService as OrderService).GetById(id).ToList()[0].ReceiveDate, (tableService as OrderService).GetById(id).ToList()[0].Total, (tableService as OrderService).GetById(id).ToList()[0].Address, (tableService as OrderService).GetById(id).ToList()[0].Client, (tableService as OrderService).GetById(id).ToList()[0].Courier,(tableService as OrderService).GetById(id).ToList()[0].Dispatcher, (tableService as OrderService).GetById(id).ToList()[0].Recipient, (tableService as OrderService).GetById(id).ToList()[0].Recipient) :
			tableService is CourierService ? new CourierServiceModel((tableService as CourierService).GetById(id).ToList()[0].Name, (tableService as CourierService).GetById(id).ToList()[0].PhoneNumber) :
			null
		)
		{ }
	}
}
