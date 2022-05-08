using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.UserInterface.Pages.Tables
{
	class TablesButton : Tabs.TabButton
    {
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public Components.CommonLabel commonLabel1;

		public TablesButton()
		{
			InitializeComponent();
			Cursor = System.Windows.Forms.Cursors.Hand;
			SetStateOff();
		}

		public override void SetStateOff()
		{
			base.SetStateOff();

			BackColor = InterfaceSingleton.DIM_BACKGROUND;
			commonLabel1.StateCommon.ShortText.Color1 = InterfaceSingleton.LIGHT_FOREGROUND;
			commonLabel1.StateCommon.ShortText.Color2 = commonLabel1.StateCommon.ShortText.Color1;
			kryptonPanel1.Visible = false;
		}

		public override void SetStateHover()
		{
			BackColor = InterfaceSingleton.LIGHT_BACKGROUND;
			commonLabel1.StateCommon.ShortText.Color1 = InterfaceSingleton.DARK_FOREGROUND;
			commonLabel1.StateCommon.ShortText.Color2 = commonLabel1.StateCommon.ShortText.Color1;
		}

		public override void SetStateOn()
		{
			base.SetStateOn();

			BackColor = InterfaceSingleton.LIGHT_BACKGROUND;
			commonLabel1.StateCommon.ShortText.Color1 = InterfaceSingleton.DARK_FOREGROUND;
			commonLabel1.StateCommon.ShortText.Color2 = commonLabel1.StateCommon.ShortText.Color1;
			kryptonPanel1.StateCommon.Color1 = InterfaceSingleton.DARK_FOREGROUND;
			kryptonPanel1.StateCommon.Color2 = kryptonPanel1.StateCommon.Color1;
			kryptonPanel1.Visible = true;
		}

		private void InitializeComponent()
		{
			this.commonLabel1 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// commonLabel1
			// 
			this.commonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.commonLabel1.AutoSize = false;
			this.commonLabel1.Location = new System.Drawing.Point(0, 0);
			this.commonLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.commonLabel1.Name = "commonLabel1";
			this.commonLabel1.Size = new System.Drawing.Size(120, 40);
			this.commonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.commonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.commonLabel1.TabIndex = 0;
			this.commonLabel1.Values.Text = "commonLabel1";
			this.commonLabel1.Click += new System.EventHandler(this.commonLabel1_Click);
			this.commonLabel1.MouseEnter += new System.EventHandler(this.commonLabel1_MouseEnter);
			this.commonLabel1.MouseLeave += new System.EventHandler(this.commonLabel1_MouseLeave);
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(120, 4);
			this.kryptonPanel1.TabIndex = 1;
			// 
			// TablesButton
			// 
			this.Controls.Add(this.kryptonPanel1);
			this.Controls.Add(this.commonLabel1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "TablesButton";
			this.Size = new System.Drawing.Size(120, 40);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			this.ResumeLayout(false);

		}

		private void commonLabel1_Click(object sender, EventArgs e)
		{
			ClickButton();
		}

		private void commonLabel1_MouseEnter(object sender, EventArgs e)
		{
			EnterHover();
		}

		private void commonLabel1_MouseLeave(object sender, EventArgs e)
		{
			ExitHover();
		}
	}
}
