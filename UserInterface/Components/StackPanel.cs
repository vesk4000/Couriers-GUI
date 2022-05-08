using Couriers_GUI.Backend.Services.Implementations;
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
	public partial class StackPanel : UserControl
	{
		int currRow = 0;


		public StackPanel()
		{
			InitializeComponent();
		}


		public StackPanel(string header) 
		{
			InitializeComponent();
			AddHeader(header);
		}


		public void AddControl(Control control)
		{
			tableLayoutPanel1.Controls.Add(control, 0, currRow++);
			tableLayoutPanel1.RowStyles.Clear();
			for(int i = 0; i < currRow; i++)
				tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize, tableLayoutPanel1.GetControlFromPosition(0, i) is not null ? tableLayoutPanel1.GetControlFromPosition(0, i).Height : 0));
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
			tableLayoutPanel1.Location = new Point(Width / 2 - tableLayoutPanel1.Width / 2, 0);
			tableLayoutPanel1.Anchor = AnchorStyles.Top;
		}

		public void AddHeader(string text)
		{
			var label = new CommonLabel();
			label.Text = text;
			label.StateCommon.ShortText.Font = new Font(label.StateCommon.ShortText.Font.FontFamily, 14F);
			label.Anchor = AnchorStyles.None;
			AddControl(label);
		}
	}
}
