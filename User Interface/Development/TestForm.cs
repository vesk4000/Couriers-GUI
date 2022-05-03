using Couriers_GUI.Backend.Services.Implementations;
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

namespace Couriers_GUI.User_Interface.Development
{
	public partial class TestForm : Form
	{
		CouriersDBContext data;

		public TestForm()
		{
			InitializeComponent();

			data = new CouriersDBContext();

			dataGridView1.AutoResizeColumns();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OrderService service = new OrderService();
			if (service.Validate(new OrderDetailsServiceModel() { OrderDate = new DateTime(), ReceiveDate = new DateTime(), Total = "103,03 лв.", Address = "10", Client = "1", Courier = "1", Dispatcher = "1", Recipient = "1", Type = "1" }))
				service.Create(new OrderDetailsServiceModel() { OrderDate = new DateTime(), ReceiveDate = new DateTime(), Total = "103,03 лв.", Address = "10", Client = "1", Courier = "1", Dispatcher = "1", Recipient = "1", Type = "1" });
			else
				MessageBox.Show("Ha GAYYYY");

			dataGridView1.DataSource = service.All();
		}
    }
}
