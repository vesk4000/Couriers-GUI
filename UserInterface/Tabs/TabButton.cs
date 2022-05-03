using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.UserInterface.Tabs
{
	public class TabButton : UserControl
	{
		public UserControl panelToNavigateTo;
		public TabPanel parent;

		public void ClickButton()
		{
			if(parent is null)
			{
				MessageBox.Show("Error, no tab panel");
				return;
			}

			foreach(TabButton button in parent.tabButtons)
				button.SetStateOff();
			SetStateOn();

			if(parent.currentTabPanel is not null)
			{
				parent.currentTabPanel.Controls.Clear();
				if(panelToNavigateTo is not null)
                {
					parent.currentTabPanel.Controls.Add(panelToNavigateTo);
					panelToNavigateTo.Dock = DockStyle.Fill;
                }
				else
				{
					MessageBox.Show("Error, panelToNavigateTo");
					return;
				}
					
			}
			else
            {
				MessageBox.Show("Error, no place for tab contents");
				return;
            }
		}

		public virtual void SetStateOff() { }

		public virtual void SetStateHover() { }

		public virtual void SetStateOn() { }
	}
}
