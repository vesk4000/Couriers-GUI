using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.UserInterface.Navigation
{
	public class NavigationButton : Tabs.TabButton
	{
		public Krypton.Toolkit.KryptonPanel kryptonPanel1;

		public NavigationButton()
		{
			InitializeComponent();
		}

		public override void SetStateOff() { }

		public override void SetStateHover() { }

		public override void SetStateOn() { }

		private void InitializeComponent()
		{
			this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(60, 60);
			this.kryptonPanel1.StateCommon.Image = global::Couriers_GUI.Properties.Resources.file_circle_exclamation_solid;
			this.kryptonPanel1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
			this.kryptonPanel1.TabIndex = 0;
			this.kryptonPanel1.Click += new System.EventHandler(this.kryptonPanel1_Click);
			// 
			// NavigationButton
			// 
			this.Controls.Add(this.kryptonPanel1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "NavigationButton";
			this.Size = new System.Drawing.Size(60, 70);
			this.Click += new System.EventHandler(this.NavigationButton_Click);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			this.ResumeLayout(false);

		}

		private void kryptonPanel1_Click(object sender, EventArgs e)
		{
			ClickButton();
		}

		private void NavigationButton_Click(object sender, EventArgs e)
		{
			ClickButton();
		}
	}
}
