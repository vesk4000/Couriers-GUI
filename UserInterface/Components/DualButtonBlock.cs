using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.UserInterface.Components
{
	public partial class DualButtonBlock : UserControl
	{
		public Action button1Action, button2Action;


		public DualButtonBlock()
		{
			InitializeComponent();
		}


		public DualButtonBlock(Action button1Action, Action button2Action)
		{
			InitializeComponent();
			this.button1Action = button1Action;
			this.button2Action = button2Action;
		}


		private void commonButton1_Click(object sender, EventArgs e)
		{
			if(button1Action is not null)
				button1Action.Invoke();
		}


		private void commonButton2_Click(object sender, EventArgs e)
		{
			if(button2Action is not null)
				button2Action.Invoke();
		}
	}
}
