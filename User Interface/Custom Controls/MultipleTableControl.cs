using Couriers_GUI.Backend.Services.Implementations;
using Couriers_GUI.Backend.Services.ServiceModels;
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

namespace Couriers_GUI.User_Interface.Custom_Controls
{
	public partial class MultipleTableControl : UserControl
	{
		public List<DataGridView> tables = new List<DataGridView>();
		private CouriersDBContext data;

		public MultipleTableControl()
		{
			InitializeComponent();
			data = new CouriersDBContext();
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

			table.DataSource = lst;
			table.Location = new Point(0, newLocation);
			
			//dataGridView1.Refresh();
			tables.Add(table);
			table.AutoSize = true;
			newLocation += table.Size.Height;
			kryptonPanel1.Controls.Add(table);
			table = new DataGridView();
			table.DataSource = lst;
			table.Location = new Point(0, newLocation);
			
			table.AutoSize = true;
			newLocation += table.Size.Height;
			tables.Add(table);
			kryptonPanel1.Controls.Add(table);

		}

		private void MultipleTableControl_MouseClick(object sender, MouseEventArgs e)
		{
            //var table = new DataGridView();
            //var lst = new List<Test>();
            //lst.Add(new Test("asd", "sad2"));
            //lst.Add(new Test("asdsda", "sadsadsad2"));
            //lst.Add(new Test("dasdd", "asdsadsad"));
            //lst.Add(new Test("sadsad", "ssadsadad2"));
            //table.Dock = DockStyle.Left;
            //table.DataSource = lst;
            //table.AutoSize = true;
            //dataGridView1.Refresh();
            //tables.Add(table);
            //kryptonPanel1.Controls.Add(table);
        }

		private void MultipleTableControl_Click(object sender, EventArgs e)
		{

		}

		private void kryptonPanel1_MouseClick(object sender, MouseEventArgs e)
		{
			var table = new DataGridView();
			var lst = new List<Test>();
			lst.Add(new Test("asd", "sad2"));
			lst.Add(new Test("asdsda", "sadsadsad2"));
			lst.Add(new Test("dasdd", "asdsadsad"));
			lst.Add(new Test("sadsad", "ssadsadad2"));
			table.Location = new Point(0, newLocation);
			
			table.AutoSize = true;
			table.DataSource = lst;
			newLocation += table.Size.Height;
			//dataGridView1.Refresh();
			tables.Add(table);
			kryptonPanel1.Controls.Add(table);
		}

        private void button1_Click(object sender, EventArgs e)
        {
			AddressService addressService = new AddressService(data);

			addressService.Remove(7);

			tables.First().DataSource = addressService.All(); 
        }
    }
}
