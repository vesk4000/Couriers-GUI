using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.UserInterface.Components
{
	public class CompletableTextBox : Krypton.Toolkit.KryptonTextBox
	{
		public CompletableTextBox() : base()
		{
			this.Click += new System.EventHandler(kryptonTextBox1_Click);
			this.Leave += new System.EventHandler(kryptonTextBox1_Leave);
			this.TextChanged += new System.EventHandler(kryptonTextBox1_TextChanged);
			this.CursorChanged += new System.EventHandler(kryptonTextBox1_CursorChanged);
			this.Enter += new System.EventHandler(kryptonTextBox1_Enter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.completableTextBox1_KeyDown);

			//
			dataSource.Add("qwert");
			dataSource.Add("qweqqeqewqwe");
			dataSource.Add("fsdfsdfsf");
			dataSource.Add("fsdfsdfsfqqqqq");
			dataSource.Add("fsdfsdfsfwwwwew");
			dataSource.Add("fsdfsdfsfwwwwew");
			dataSource.Add("fsdfsdfsfwwww");
			//


		}

		private void completableTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				kryptonListBox1.Visible = false;
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		private void kryptonTextBox1_Enter(object sender, EventArgs e)
		{
			kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
			Parent.Controls.Add(kryptonListBox1);

			this.kryptonListBox1.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + this.Height);
			this.kryptonListBox1.Size = new System.Drawing.Size(this.Size.Width, kryptonListBox1.Size.Height);

			SetListBoxSize();

			activeDataSource = dataSource.Where(s => s.Contains(this.Text)).ToList();

			//kryptonListBox1.Visible = true;
			//kryptonListBox1.BringToFront();

			kryptonListBox1.DataSource = activeDataSource;
			this.kryptonListBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonListBox1_SelectedIndexChanged);
			this.kryptonListBox1.Click += new System.EventHandler(this.kryptonListBox1_Click);
			this.kryptonListBox1.Enter += new System.EventHandler(this.kryptonListBox1_Enter);
			this.kryptonListBox1.GotFocus += new System.EventHandler(this.kryptonListBox1_GotFocus);


		}

		private void kryptonTextBox1_Leave(object sender, EventArgs e)
		{
			if(!lbEntered) kryptonListBox1.Visible = false;
		}

		private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
		{
			activeDataSource = dataSource.Where(s => s.Contains(this.Text)).ToList();

			SetListBoxSize();


			if(kryptonListBox1 is not null)
				kryptonListBox1.DataSource = activeDataSource;
		}

		private void kryptonListBox1_Enter(object sender, EventArgs e)
		{
			lbEntered = true;
			kryptonListBox1.Visible = true;
		}

		private void kryptonListBox1_GotFocus(object sender, EventArgs e)
		{
			//lbEntered = true;
		}


		private void kryptonListBox1_Click(object sender, EventArgs e)
		{
			this.Text = kryptonListBox1.GetItemText(kryptonListBox1.SelectedItem);
			kryptonListBox1.Visible = false;
			lbEntered = false;

		}

		private void kryptonTextBox1_Click(object sender, EventArgs e)
		{
			kryptonListBox1.Visible = true;

			SetListBoxSize();
		}
		private void kryptonTextBox1_CursorChanged(object sender, EventArgs e)
		{

		}
		private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void SetListBoxSize()
		{
			if(activeDataSource.Count == 0)
				kryptonListBox1.Visible = false;
			else if(activeDataSource.Count > 5)
			{
				kryptonListBox1.Height = (this.PreferredSize.Height - 5) * 5 + 5;
				kryptonListBox1.Visible = true;
			}
			else
			{
				kryptonListBox1.Height = (this.PreferredSize.Height - 5) * activeDataSource.Count + 5;
				kryptonListBox1.Visible = true;
			}
		}


		private Krypton.Toolkit.KryptonListBox kryptonListBox1;
		public List<string> dataSource = new List<string>();
		private List<string> activeDataSource = new List<string>();
		private bool lbEntered;

	}
}
