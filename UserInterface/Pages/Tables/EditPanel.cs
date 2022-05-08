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
					service.Edit(model);
				}
				else if (tableService is CourierService)
				{
					CourierService service = tableService as CourierService;
					CourierServiceModel model = panel.GetOptions() as CourierServiceModel;
					model.Id = id;
					service.Edit(model);
				}
				else if (tableService is AddressService)
				{
					AddressService service = tableService as AddressService;
					AddressServiceModel model = panel.GetOptions() as AddressServiceModel;
					model.Id = id;
					service.Edit(model);
				}
				else if (tableService is ClientService)
				{
					ClientService service = tableService as ClientService;
					ClientServiceModel model = panel.GetOptions() as ClientServiceModel;
					model.Id = id;
					service.Edit(model);
				}
				else if (tableService is DispatcherService)
				{
					DispatcherService service = tableService as DispatcherService;
					DispatcherServiceModel model = panel.GetOptions() as DispatcherServiceModel;
					model.Id = id;
					service.Edit(model);
				}
				else if (tableService is RecipientService)
				{
					RecipientService service = tableService as RecipientService;
					RecipientServiceModel model = panel.GetOptions() as RecipientServiceModel;
					model.Id = id;
					service.Edit(model);
				}
				else if (tableService is TOSService)
				{
					TOSService service = tableService as TOSService;
					TypesOfServiceServiceModel model = panel.GetOptions() as TypesOfServiceServiceModel;
					model.Id = id;
					service.Edit(model);
				}

			},
			tableView,
			tableService is OrderService ? new OrderDetailsServiceModel((tableService as OrderService).GetById(id).ToList()[0].OrderDate, (tableService as OrderService).GetById(id).ToList()[0].ReceiveDate, (tableService as OrderService).GetById(id).ToList()[0].Total, (tableService as OrderService).GetById(id).ToList()[0].Address, (tableService as OrderService).GetById(id).ToList()[0].Client, (tableService as OrderService).GetById(id).ToList()[0].Courier,(tableService as OrderService).GetById(id).ToList()[0].Dispatcher, (tableService as OrderService).GetById(id).ToList()[0].Recipient, (tableService as OrderService).GetById(id).ToList()[0].Type) :
			tableService is CourierService ? new CourierServiceModel((tableService as CourierService).GetById(id).ToList()[0].Name, (tableService as CourierService).GetById(id).ToList()[0].PhoneNumber) :
			tableService is AddressService ? new AddressServiceModel((tableService as AddressService).GetById(id).ToList()[0].AddressText) :
			tableService is ClientService ? new ClientServiceModel((tableService as ClientService).GetById(id).ToList()[0].Name, (tableService as ClientService).GetById(id).ToList()[0].PhoneNumber) :
			tableService is DispatcherService ? new DispatcherServiceModel((tableService as DispatcherService).GetById(id).ToList()[0].Name, (tableService as DispatcherService).GetById(id).ToList()[0].PhoneNumber) :
			tableService is RecipientService ? new RecipientServiceModel((tableService as RecipientService).GetById(id).ToList()[0].Name) :
			tableService is TOSService ? new TypesOfServiceServiceModel((tableService as TOSService).GetById(id).ToList()[0].Type) :




			null
		)
		{ }
	}
}
