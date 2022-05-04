using Couriers_GUI.Backend.Services.Implementations;
using Couriers_GUI.Backend.Services.ServiceModels;
using Couriers_GUI.Backend.Services.SQLDBCreateScript;
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
			dataGridView1.DataSource = "";
		}

        private void button2_Click(object sender, EventArgs e)
        {
			OrderService service = new OrderService();

			dataGridView1.DataSource = service.All();
        }

        private void button3_Click(object sender, EventArgs e)
        {
			DBCreateService.CreateDatabase();
		}
    }
}
