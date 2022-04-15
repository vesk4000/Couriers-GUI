using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.User_Interface.Custom_Controls
{
	class TablesNavigationButton : NavigationButton
	{
		public TablesNavigationButton() : base()
		{
			panelToNavigateTo = new MultipleTableControl();
			panelToNavigateTo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel1.StateCommon.Image = global::Couriers_GUI.Properties.Resources.table_solid;
			this.label1.Text = "TABLES";
		}
	}
}
