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
	public partial class NavigationButton : UserControl
	{
		public UserControl panelToNavigateTo;

		public NavigationButton()
		{
			InitializeComponent();
			InterfaceSingleton.navigationButtons.Add(this);
			SetStateOff();
		}

		public void ClickButton()
		{
			
			foreach(NavigationButton button in InterfaceSingleton.navigationButtons)
				button.SetStateOff();
			this.SetStateToggled();
			if(InterfaceSingleton.NavigablePanelContent is not null)
			{
				InterfaceSingleton.NavigablePanelContent.Controls.Clear();
				
				
				if(panelToNavigateTo is not null)
				{
					InterfaceSingleton.NavigablePanelContent.Controls.Add(panelToNavigateTo);
					//MessageBox.Show("fghk");
					
				}
					
			}
			

		}

		public void SetStateOff()
		{
			label1.ForeColor = System.Drawing.Color.FromArgb(InterfaceSingleton.COLOR_GREY);
			//kryptonPanel1.Palette
			BackColor = System.Drawing.Color.Transparent;
		}

		public void SetStateHover()
		{
			label1.ForeColor = System.Drawing.Color.FromArgb(InterfaceSingleton.COLOR_BACKGROUND);
		}

		public void SetStateToggled()
		{
			label1.ForeColor = System.Drawing.Color.FromArgb(InterfaceSingleton.COLOR_BACKGROUND);
			BackColor = System.Drawing.Color.FromArgb(unchecked((int)0x40_FF_FF_FF));
			label1.BackColor = System.Drawing.Color.Transparent;
		}

		private void NavigationButton_MouseClick(object sender, MouseEventArgs e)
		{
			ClickButton();
		}

		private void kryptonPanel1_MouseClick(object sender, MouseEventArgs e)
		{
			ClickButton();
		}

		private void kryptonLabel1_MouseClick(object sender, MouseEventArgs e)
		{
			ClickButton();
		}

		private void NavigationButton_Load(object sender, EventArgs e)
		{
			
		}
	}
}
