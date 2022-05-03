using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.UserInterface.Pages.Tables
{
    class TablesPanel : Tabs.TabPanel
	{
		private TableLayoutPanel tableLayoutPanel2;
		private Krypton.Toolkit.KryptonPanel kryptonPanel1;
		private TableLayoutPanel tableLayoutPanel1;

		public TablesPanel()
        {
            InitializeComponent();
			currentTabPanel = kryptonPanel1;
			AddButton("Orders");
		}

		private void AddButton(string tableName)
		{
			var button = new TablesButton();
			button.panelToNavigateTo = new TableContainer(/*new Backend.Services.Implementations.OrderService()*/);
			button.kryptonLabel1.Text = tableName;
			button.parent = this;
			tableLayoutPanel2.Controls.Add(button, 0, 0);
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
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 445);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(580, 80);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel1.Location = new System.Drawing.Point(3, 83);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(574, 419);
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
