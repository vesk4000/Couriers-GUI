using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.User_Interface.Custom_Controls
{
	class DevPageNavigationButton : NavigationButton
	{
		public DevPageNavigationButton() : base()
		{
			panelToNavigateTo = new DevControl();
			panelToNavigateTo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel1.StateCommon.Image = global::Couriers_GUI.Properties.Resources.laptop_code_solid;
			this.label1.Text = "DEV";
		}
	}
}
