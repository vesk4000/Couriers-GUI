﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couriers_GUI.Backend.Services.Implementations;

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
				if(tableService is OrderService)
				{
					kryptonDataGridView1.DataSource = (tableService as OrderService).All();
				}
				else if(tableService is CourierService)
				{
					kryptonDataGridView1.DataSource = (tableService as CourierService).All();
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
