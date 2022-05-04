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

		private void commonButtonAdd_Click(object sender, EventArgs e)
		{
			if(Parent is TableContainer)
			{
				var page = new AddPage();
				Parent.Controls.Add(page);
				page.Init();
				page.Dock = DockStyle.Fill;
				Parent.Controls.Remove(this);
			}
			else
			{
				MessageBox.Show("TableView: Parent has to be a TableContainer");
				return;
			}
		}

		private void commonButton2_Click(object sender, EventArgs e)
		{
			if(Parent is TableContainer)
			{
				int a;
				if(kryptonDataGridView1.SelectedRows.Count > 0 && kryptonDataGridView1.SelectedRows[0].Cells.Count > 0 && int.TryParse(kryptonDataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out a))
				{
					var page = new EditPage();
					Parent.Controls.Add(page);
					page.Init();
					page.Dock = DockStyle.Fill;
					page.id = a;
					Parent.Controls.Remove(this);
				}
				
			}
			else
			{
				MessageBox.Show("TableView: Parent has to be a TableContainer");
				return;
			}
		}

		private void commonButton3_Click(object sender, EventArgs e)
		{
			if(Parent is TableContainer)
			{
				int a;
				if(kryptonDataGridView1.SelectedRows.Count > 0 && kryptonDataGridView1.SelectedRows[0].Cells.Count > 0 && int.TryParse(kryptonDataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out a))
				{
					var page = new DeletePage();
					Parent.Controls.Add(page);
					page.Init();
					page.Dock = DockStyle.Fill;
					page.id = a;
					Parent.Controls.Remove(this);
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