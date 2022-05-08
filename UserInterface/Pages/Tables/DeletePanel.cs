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
	public class DeletePanel : OptionsStackPanel
	{
		public DeletePanel(
			object tableService,
			TableView tableView,
			int id
		) : base(
			"Are you sure you want to delete this entry?",
			tableService,
			"Delete",
			(OptionsStackPanel panel) =>
			{
				if (tableService is OrderService)
				{
					OrderService service = tableService as OrderService;
					service.Remove(id);
				}
				else if (tableService is CourierService)
				{
					CourierService service = tableService as CourierService;
					service.Remove(id);
				}

			},
			tableView,
			null,
			false,
			false
		)
		{ }
	}
}
