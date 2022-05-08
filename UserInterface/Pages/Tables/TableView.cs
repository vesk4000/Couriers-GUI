using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couriers_GUI.Backend.Services.Implementations;
using Couriers_GUI.Backend.Services.ServiceModels;

namespace Couriers_GUI.UserInterface.Pages.Tables
{
	public partial class TableView : UserControl
	{
		public object filterModel;


		public TableView()
		{
			InitializeComponent();
			BackColor = InterfaceSingleton.LIGHT_BACKGROUND;
			InterfaceSingleton.tableViews.Add(this);
		}

		public void InitDataGridView()
		{
			if (DBService.ExistTables())
			{
				if (Parent is TableContainer)
				{
					TableContainer parent = Parent as TableContainer;
					object tableService = parent.tableService;

					int afterFilter = 0, beforeFilter = 0;

				if(tableService is OrderService)
				{
					var service = tableService as OrderService;
					if (filterModel is null)
					{
						kryptonDataGridView1.DataSource = service.All();
						filterModel = new OrderFilterServiceModel(DateTime.MinValue, DateTime.MaxValue, DateTime.MinValue, DateTime.MaxValue, "0", "1000000", "", "", "", "", "", "");
					}
					else
					{
						var model = filterModel as OrderFilterServiceModel;
						kryptonDataGridView1.DataSource = service.Filter(model).ToList();
						afterFilter = service.Filter(model).Count();
						beforeFilter = service.All().Count();
					}				}
				else if(tableService is CourierService)
				{
					var service = tableService as CourierService;
					if (filterModel is null)
						kryptonDataGridView1.DataSource = service.All();
					else
					{
						var model = filterModel as CourierServiceModel;
						kryptonDataGridView1.DataSource = service.Filter(model.Name, model.PhoneNumber).ToList();
						afterFilter = service.Filter(model.Name, model.PhoneNumber).Count();
						beforeFilter = service.All().Count();
					}
				}
				else if(tableService is AddressService)
				{
					kryptonDataGridView1.DataSource = (tableService as AddressService).All();
				}
				else if(tableService is ClientService)
				{
					kryptonDataGridView1.DataSource = (tableService as ClientService).All();
				}
				else if (tableService is DispatcherService)
				{
					kryptonDataGridView1.DataSource = (tableService as DispatcherService).All();
				}
				else if (tableService is RecipientService)
				{
					kryptonDataGridView1.DataSource = (tableService as RecipientService).All();
				}
				else if (tableService is TOSService)
				{
					kryptonDataGridView1.DataSource = (tableService as TOSService).All();
				}
				if (afterFilter == beforeFilter)
					commonButton4.Text = "Filter";
				else
					commonButton4.Text = "Fitler (" + afterFilter + "/" + beforeFilter  + ")";

				}
				else
				{
					MessageBox.Show("TableView: Parent has to be a TableContainer");
					return;
				}
			}
		}

		private void commonButtonAdd_Click(object sender, EventArgs e)
		{
			if(Parent is TableContainer)
			{
				//var page = new AddPage();
				//Parent.Controls.Add(page);
				//page.Init();
				//page.Dock = DockStyle.Fill;
				//Parent.Controls.Remove(this);
				var page = new AddPanel((Parent as TableContainer).tableService, this);
				Parent.Controls.Add(page);
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
				if(kryptonDataGridView1.SelectedCells.Count > 0 && int.TryParse(kryptonDataGridView1.Rows[kryptonDataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString(), out a))
				{
					var page = new EditPanel((Parent as TableContainer).tableService, this, a);
					Parent.Controls.Add(page);
					page.Dock = DockStyle.Fill;
					Parent.Controls.Remove(this);
					return;
				}
				if(kryptonDataGridView1.SelectedRows.Count > 0 && kryptonDataGridView1.SelectedRows[0].Cells.Count > 0 && int.TryParse(kryptonDataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out a))
				{
					MessageBox.Show("Asd");
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
				if(kryptonDataGridView1.SelectedCells.Count > 0 && int.TryParse(kryptonDataGridView1.Rows[kryptonDataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString(), out a))
				{
					var page = new DeletePanel((Parent as TableContainer).tableService, this, a);
					Parent.Controls.Add(page);
					page.Dock = DockStyle.Fill;
					Parent.Controls.Remove(this);
					return;
				}
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

		private void commonButton4_Click(object sender, EventArgs e)
		{
			if(Parent is TableContainer)
			{
				var page = new FilterPanel((Parent as TableContainer).tableService, this);
				Parent.Controls.Add(page);
				page.Dock = DockStyle.Fill;
				Parent.Controls.Remove(this);
			}
			else
			{
				MessageBox.Show("TableView: Parent has to be a TableContainer");
				return;
			}
		}
	}
}
