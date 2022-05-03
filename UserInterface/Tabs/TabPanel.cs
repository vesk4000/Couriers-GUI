using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.UserInterface.Tabs
{
	public class TabPanel : UserControl
	{
		public List<TabButton> tabButtons = new List<TabButton>();
		public Krypton.Toolkit.KryptonPanel currentTabPanel;
	}
}
