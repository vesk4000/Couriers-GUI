using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.User_Interface.Modified_Controls
{
	class ModifiedKryptonPanel : Krypton.Toolkit.KryptonPanel
	{
		public ModifiedKryptonPanel()
		{
			StateCommon.Color1 = System.Drawing.Color.FromArgb(InterfaceSingleton.COLOR_BACKGROUND);
			Dock = System.Windows.Forms.DockStyle.Fill;
			AutoScroll = true;
		}
	}
}
