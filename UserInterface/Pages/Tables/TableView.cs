using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.UserInterface.Pages.Tables
{
	public partial class TableView : UserControl
	{
		public TableView()
		{
			InitializeComponent();
		}

		public void InitDataGridView()
		{
			if(Parent is TableContainer)
			{
				TableContainer parent = Parent as TableContainer;
				object tableService = parent.tableService;
				if(tableService is Backend.Services.Implementations.OrderService)
				{
					kryptonDataGridView1.DataSource = (tableService as Backend.Services.Implementations.OrderService).All();
				}
			}
			else
			{
				MessageBox.Show("TableView: Parent has to be a TableContainer");
				return;
			}
		}
	}
}
