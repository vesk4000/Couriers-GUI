﻿using System;
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
			if(Parent is not TabPanel)
            {
				MessageBox.Show("Error, no tab panel");
				return;
            }
			TabPanel parent = Parent as TabPanel;

			foreach(TabButton button in parent.tabButtons)
				button.SetStateOff();
			SetStateOn();

			if(parent.currentTabPanel is not null)
			{
				parent.currentTabPanel.Controls.Clear();
				if(panelToNavigateTo is not null)
					parent.currentTabPanel.Controls.Add(panelToNavigateTo);
			}
		}

		public abstract void SetStateOff();

		public abstract void SetStateHover();

		public abstract void SetStateOn();
    }
}
