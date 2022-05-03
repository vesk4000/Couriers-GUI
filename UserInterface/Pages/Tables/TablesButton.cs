using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.UserInterface.Pages.Tables
{
	class TablesButton : Tabs.TabButton
	{
		public Krypton.Toolkit.KryptonLabel kryptonLabel1;
		private Krypton.Toolkit.KryptonPanel kryptonPanel1;

		public TablesButton()
		{
			InitializeComponent();
		}

		public override void SetStateOff() { }

		public override void SetStateHover() { }

		public override void SetStateOn() { }

		private void InitializeComponent()
		{
			this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
			this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// kryptonLabel1
			// 
			this.kryptonLabel1.Location = new System.Drawing.Point(135, 16);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new System.Drawing.Size(109, 24);
			this.kryptonLabel1.TabIndex = 0;
			this.kryptonLabel1.Values.Text = "kryptonLabel1";
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.Location = new System.Drawing.Point(4, 16);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(69, 41);
			this.kryptonPanel1.TabIndex = 1;
			// 
			// TablesButton
			// 
			this.Controls.Add(this.kryptonPanel1);
			this.Controls.Add(this.kryptonLabel1);
			this.Name = "TablesButton";
			this.Size = new System.Drawing.Size(269, 60);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
