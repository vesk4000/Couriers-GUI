using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.User_Interface
{
	static class InterfaceSingleton
	{
		// E0 FF EE
		// 0xFF_EE_FF_FE
		public const int COLOR_BACKGROUND = unchecked((int)0xFF_EE_FF_FE);
		public const int COLOR_ACCENT = unchecked((int)0xFF_00_FF_B8);
		public const int COLOR_GREY = unchecked((int)0xFF_64_83_81);
		public static System.Windows.Forms.Panel NavigablePanelContent;
		public static List<Custom_Controls.NavigationButton> navigationButtons = new List<Custom_Controls.NavigationButton>();
	}
}
