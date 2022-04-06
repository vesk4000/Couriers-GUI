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
	public class Test
	{
		public string name { get; set; }
		public string name2 { get; set; }
		public Test(string name, string name2)
		{
			this.name = name;
			this.name2 = name2;
		}
	}
	public partial class MultipleTableContainer : UserControl
	{
		public MultipleTableContainer()
		{
			InitializeComponent();
		}

		private void MultipleTableContainer_Load(object sender, EventArgs e)
		{
			var lst = new List<(string name, string name2)>();
			lst.Add((name: "asd", name2: "asd2"));
			dataGridView1.DataSource = lst;
			Console.WriteLine("test");
		}

		private void MultipleTableContainer_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void MultipleTableContainer_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var lst = new List<Test>();
			lst.Add(new Test("asd", "sad2"));
			lst.Add(new Test("asdsda", "sadsadsad2"));
			lst.Add(new Test("dasdd", "asdsadsad"));
			lst.Add(new Test("sadsad", "ssadsadad2"));
			
			dataGridView1.DataSource = lst;
			//dataGridView1.Refresh();
			Console.WriteLine("test");
			label1.Text = "wasd";
		}
	}
}
