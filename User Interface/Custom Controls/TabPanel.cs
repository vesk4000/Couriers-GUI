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
	public abstract class TabPanel : UserControl
	{
		public List<TabButton> tabButtons = new List<TabButton>();
		public Krypton.Toolkit.KryptonPanel currentTabPanel;
		
		public abstract void ChangeTab();

    }
}
