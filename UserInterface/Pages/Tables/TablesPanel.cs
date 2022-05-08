using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couriers_GUI.Backend.Services.Implementations;

namespace Couriers_GUI.UserInterface.Pages.Tables
{
    class TablesPanel : Tabs.TabPanel
	{
		private TableLayoutPanel tableLayoutPanel2;
		private Krypton.Toolkit.KryptonPanel kryptonPanel1;
		private TableLayoutPanel tableLayoutPanel1;

		private int nextButtonIndex = 0;

		public TablesPanel()
        {
            InitializeComponent();
			currentTabPanel = kryptonPanel1;
			AddButton(new OrderService()).ClickButton();
			AddButton(new CourierService());
			AddButton(new AddressService());
			AddButton(new ClientService());
            tableLayoutPanel2.BackColor = InterfaceSingleton.DIM_BACKGROUND;
			AddButton(new DispatcherService());
			AddButton(new RecipientService());
			AddButton(new TOSService());

		}

		private TablesButton AddButton(object tableService)
		{
			var button = new TablesButton();
            tabButtons.Add(button);
			button.panelToNavigateTo = new TableContainer(tableService);
			button.panelToNavigateTo.Dock = DockStyle.Fill;
			button.parent = this;

			if(tableService is OrderService)
			{
				button.commonLabel1.Text = "Orders";
			}
			else if(tableService is CourierService)
			{
				button.commonLabel1.Text = "Couriers";
			}
			else if(tableService is AddressService)
			{
				button.commonLabel1.Text = "Addresses";
			}
			else if(tableService is ClientService)
			{
				button.commonLabel1.Text = "Clients";
			}
			else if (tableService is DispatcherService)
			{
				button.commonLabel1.Text = "Dispatchers";
			}
			else if (tableService is RecipientService)
			{
				button.commonLabel1.Text = "Recipients";
			}
			else if (tableService is TOSService)
			{
				button.commonLabel1.Text = "Order Types";
			}

			tableLayoutPanel2.ColumnCount = 100;
			tableLayoutPanel2.Controls.Add(button, nextButtonIndex++, 0);

            return button;
		}

		private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(580, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 40);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(580, 419);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // TablesPanel
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TablesPanel";
            this.Size = new System.Drawing.Size(580, 445);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
