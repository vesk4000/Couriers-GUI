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
	public partial class MultipleTableControl : UserControl
	{
		public List<DataGridView> tables = new List<DataGridView>();

		public MultipleTableControl()
		{
			InitializeComponent();
		}

		private int newLocation = 0;

		private void MultipleTableControl_Load(object sender, EventArgs e)
		{

			var table = new DataGridView();
			var lst = new List<Test>();
			lst.Add(new Test("asd", "sad2"));
			lst.Add(new Test("asdsda", "sadsadsad2"));
			lst.Add(new Test("dasdd", "asdsadsad"));
			lst.Add(new Test("sadsad", "ssadsadad2"));

			AddTable(lst);

			table.DataSource = lst;
			table.Location = new Point(0, newLocation);

			//kryptonDataGridView1.DataSource = lst;
			
			//dataGridView1.Refresh();
			tables.Add(table);
			table.AutoSize = true;
			//newLocation += table.Size.Height;
			//kryptonPanel1.Controls.Add(table);
			table = new DataGridView();
			table.DataSource = lst;
			table.Location = new Point(0, newLocation);
			
			table.AutoSize = true;
			//newLocation += table.Size.Height;
			tables.Add(table);
			//kryptonPanel1.Controls.Add(table);

		}


		public void AddTable<T>(List<T> table)
        {
			var dataGridView = new Modified_Controls.ModifiedKryptonDataGridView();
			dataGridView.AutoSize = true;
			dataGridView.DataSource = table;
			dataGridView.Location = new Point(0, newLocation);
			newLocation += dataGridView.Height;
			panel.Controls.Add(dataGridView);
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
			var lst = new List<Test>();
			lst.Add(new Test("asd", "sad2"));
			lst.Add(new Test("asdsda", "sadsadsad2"));
			lst.Add(new Test("dasdd", "asdsadsad"));
			lst.Add(new Test("sadsad", "ssadsadad2"));
			AddTable(lst);
        }
	}
}
