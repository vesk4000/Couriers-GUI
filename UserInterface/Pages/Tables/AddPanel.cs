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
	public class AddPanel : OptionsStackPanel
	{
		public AddPanel(
			object tableService,
			TableView tableView
		) : base(
			"Add",
			tableService,
			"Add",
			(OptionsStackPanel panel) => {
				if(tableService is OrderService)
				{
					OrderService orderService = tableService as OrderService;
					OrderDetailsServiceModel model = panel.GetOptions() as OrderDetailsServiceModel;
					orderService.Create(model);
				}
				else if(tableService is CourierService)
				{
					CourierService service = tableService as CourierService;
					CourierServiceModel model = panel.GetOptions() as CourierServiceModel;
					service.Create(model);
				}
				else if (tableService is AddressService)
				{
					AddressService service = tableService as AddressService;
					AddressServiceModel model = panel.GetOptions() as AddressServiceModel;
					service.Create(model);
				}
				else if (tableService is ClientService)
				{
					ClientService service = tableService as ClientService;
					ClientServiceModel model = panel.GetOptions() as ClientServiceModel;
					service.Create(model);
				}
				else if (tableService is DispatcherService)
				{
					DispatcherService service = tableService as DispatcherService;
					DispatcherServiceModel model = panel.GetOptions() as DispatcherServiceModel;
					service.Create(model);
				}
				else if (tableService is RecipientService)
				{
					RecipientService service = tableService as RecipientService;
					RecipientServiceModel model = panel.GetOptions() as RecipientServiceModel;
					service.Create(model);
				}
				else if (tableService is TOSService)
				{
					TOSService service = tableService as TOSService;
					TypesOfServiceServiceModel model = panel.GetOptions() as TypesOfServiceServiceModel;
					service.Create(model);
				}

			}, 
			tableView
		) { }
	}
}
