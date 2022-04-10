using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI
{
	public partial class Form1 : Form
	{
		CouriersDBContext data;

		public Form1()
		{
			InitializeComponent();
			data = new CouriersDBContext();
		}

		private void tableLayoutPanel1_Click(object sender, EventArgs e)
		{

			Label label = new Label();
			label.Text = "Hello!";
			//tableLayoutPanel1.Controls.Add(label, 0, 0);
		}

		private void kryptonButton1_Click(object sender, EventArgs e)
		{

		}
	}
}
