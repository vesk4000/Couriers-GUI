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
	public partial class TableContainer : UserControl
	{
		public object tableService;

		public TableContainer()
		{
			InitializeComponent();
		}

		public TableContainer(object tableService)
		{
			this.tableService = tableService;
			InitializeComponent();
			tableView1.InitDataGridView();
		}
	}
}
