using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Couriers_GUI.UserInterface.Pages.Tables;

namespace Couriers_GUI.UserInterface
{
	public static class InterfaceSingleton
	{
		public static Color DIM_BACKGROUND = Color.FromArgb(255, 235, 235, 235);
		public static Color LIGHT_BACKGROUND = Color.FromArgb(255, 255, 255, 255);
		public static Color LIGHT_GREY_BORDER = Color.FromArgb(255, 224, 224, 224);
		public static Color DIM_GREY_BORDER = Color.FromArgb(255, 191, 191, 191);
		public static Color LIGHT_FOREGROUND = Color.FromArgb(255, 90, 90, 90);
		public static Color DIM_FOREGROUND = Color.FromArgb(255, 64, 64, 64);
		public static Color DARK_FOREGROUND = Color.FromArgb(255, 38, 38, 38);

		public static List<TableView> tableViews = new List<TableView>();

		public static void InvalidateTableViews()
		{
			foreach(var table in tableViews)
			{
				table.InitDataGridView();
			}
		}
	}
}
