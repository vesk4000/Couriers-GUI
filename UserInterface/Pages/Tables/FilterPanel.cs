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
	public class FilterPanel : OptionsStackPanel
	{
		public FilterPanel(
			object tableService,
			TableView tableView
		) : base(
			"Filter",
			tableService,
			"Save",
			(OptionsStackPanel panel) =>
			{
				tableView.filterModel = panel.GetOptions();
			},
			tableView,
			tableView.filterModel,
			false,
			true
		)
		{ }
	}
}
