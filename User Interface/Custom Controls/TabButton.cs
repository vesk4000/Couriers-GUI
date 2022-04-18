using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.User_Interface.Custom_Controls
{
	public abstract class TabButton : UserControl
	{
		public UserControl panelToNavigateTo;

		public void ClickButton()
		{
			if(Parent is not Pages.TablesTabsPage)
            {
				MessageBox.Show("Error, no tab panel");
				return;
            }
			var parent = Parent as Pages.TablesTabsPage;
			foreach(TabButton button in parent.Buttons)
				button.SetStateOff();
			SetStateToggled();
			if(InterfaceSingleton.NavigablePanelContent is not null)
			{
				InterfaceSingleton.NavigablePanelContent.Controls.Clear();
				if(panelToNavigateTo is not null)
					InterfaceSingleton.NavigablePanelContent.Controls.Add(panelToNavigateTo);	
			}
		}

		public abstract void SetStateOff();

		public abstract void SetStateHover();

		public abstract void SetStateToggled();
	}
}
