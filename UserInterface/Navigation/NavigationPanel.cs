using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Couriers_GUI.Properties;

namespace Couriers_GUI.UserInterface.Navigation
{
	public class NavigationPanel : Tabs.TabPanel
	{
		private TableLayoutPanel tableLayoutPanel2;
		private Krypton.Toolkit.KryptonPanel kryptonPanel1;
		private TableLayoutPanel tableLayoutPanel1;

		private int nextButtonIndex = 0;


		public NavigationPanel() : base()
		{
			InitializeComponent();
			currentTabPanel = kryptonPanel1;
			tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(255, 235, 235, 235);
			AddButton(new NavigationButton(Resources.table_solid_dark_grey, Resources.table_solid_grey), new Pages.Tables.TablesPanel());
			AddButton(new NavigationButton(Resources.server_solid_dark_grey, Resources.server_solid_grey), new Pages.ServerPage());
            AddButton(new NavigationButton(Resources.question_solid_dark_grey, Resources.question_solid_grey), new Pages.AboutPage());
		}


		private void AddButton(NavigationButton button, UserControl panelToNavigateTo)
		{
			button.panelToNavigateTo = panelToNavigateTo;
			button.panelToNavigateTo.Dock = DockStyle.Fill;
			button.parent = this;
			tableLayoutPanel2.Controls.Add(button, 0, nextButtonIndex++);
			tabButtons.Add(button);
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(60, 537);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(60, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(499, 537);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // NavigationPanel
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NavigationPanel";
            this.Size = new System.Drawing.Size(559, 537);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
