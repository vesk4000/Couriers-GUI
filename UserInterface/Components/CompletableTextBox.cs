using System;
using System.Collections.Generic;
using System.Drawing;
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
			//	this.Move += new EventHandler(this.RelocateListBox);

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

		public void RelocateListBox(object sender = null, EventArgs e = null)
		{
			if(kryptonListBox1 is not null && kryptonListBox1.Visible == true)
			{
				Point global_loc = FindLocation(this);//LocationInForm(this);
				this.kryptonListBox1.Location = new System.Drawing.Point(global_loc.X, global_loc.Y + this.Height);
				this.kryptonListBox1.Size = new System.Drawing.Size(this.Size.Width, kryptonListBox1.Size.Height);
				this.kryptonListBox1.BringToFront();
				this.kryptonListBox1.Invalidate();

			}
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


		private Point FindLocation(Control ctrl)
		{
			if (ctrl.Parent is not null)
			{
				if (ctrl.Parent is Form)
					return ctrl.Location;
				else
				{
					Point p = FindLocation(ctrl.Parent);
					p.X += ctrl.Location.X;
					p.Y += ctrl.Location.Y;
					return p;
				}
			}
			else
				return new Point();
			
		}

		private void kryptonTextBox1_Enter(object sender, EventArgs e)
		{
			if (kryptonListBox1 is not null)
				Form.ActiveForm.Controls.Remove(kryptonListBox1);
			kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
			InterfaceSingleton.activeListBoxes.Add(this);
			Form.ActiveForm.Controls.Add(kryptonListBox1);

			RelocateListBox();

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
			var oldSource = activeDataSource;

			activeDataSource = dataSource.Where(s => s.Contains(this.Text)).ToList();

			if (activeDataSource.SequenceEqual(oldSource))
				return;

			if (kryptonListBox1 is not null)
				Form.ActiveForm.Controls.Remove(kryptonListBox1);
			kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
			InterfaceSingleton.activeListBoxes.Add(this);

			if (Form.ActiveForm is not null)
				Form.ActiveForm.Controls.Add(kryptonListBox1);

			Point global_loc = FindLocation(this);//LocationInForm(this);
			this.kryptonListBox1.Location = new System.Drawing.Point(global_loc.X, global_loc.Y + this.Height);
			this.kryptonListBox1.Size = new System.Drawing.Size(this.Size.Width, kryptonListBox1.Size.Height);
			this.kryptonListBox1.BringToFront();
		//	kryptonListBox1.Click += new EventHandler(this.kryptonListBox1_Click);
			//this.kryptonListBox1.Invalidate();

			SetListBoxSize();


			if(kryptonListBox1 is not null)
				kryptonListBox1.DataSource = activeDataSource;
			this.kryptonListBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonListBox1_SelectedIndexChanged);
			this.kryptonListBox1.Click += new System.EventHandler(this.kryptonListBox1_Click);
			this.kryptonListBox1.Enter += new System.EventHandler(this.kryptonListBox1_Enter);
			this.kryptonListBox1.GotFocus += new System.EventHandler(this.kryptonListBox1_GotFocus);

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


		public Krypton.Toolkit.KryptonListBox kryptonListBox1;
		public List<string> dataSource = new List<string>();
		private List<string> activeDataSource = new List<string>();
		private bool lbEntered;

	}
}
