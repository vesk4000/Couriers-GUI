using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.UserInterface.Navigation
{
	public class NavigationButton : Tabs.TabButton
	{
		private Krypton.Toolkit.KryptonPanel kryptonPanel2;
		public Krypton.Toolkit.KryptonPanel kryptonPanel1;

		public System.Drawing.Image
			darkImage = Properties.Resources.file_circle_exclamation_solid_dark_grey,
			lightImage = Properties.Resources.file_circle_exclamation_solid_grey;


		public NavigationButton()
		{
			InitializeComponent();
			SetStateOff();
		}


		public NavigationButton(System.Drawing.Image darkImage, System.Drawing.Image lightImage)
        {
			InitializeComponent();
			this.darkImage = darkImage;
			this.lightImage = lightImage;
			Cursor = System.Windows.Forms.Cursors.Hand;
			SetStateOff();	
        }

		public override void SetStateOff()
		{
			base.SetStateOff();

			kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(255, 235, 235, 235);
			kryptonPanel1.StateCommon.Color2 = kryptonPanel1.StateCommon.Color1;
			kryptonPanel1.StateCommon.Image = lightImage;
			kryptonPanel2.Visible = false;
		}

		public override void SetStateHover()
		{
			kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(255, 255, 255, 255);
			kryptonPanel1.StateCommon.Color2 = kryptonPanel1.StateCommon.Color1;
			kryptonPanel1.StateCommon.Image = darkImage;	

		}

		public override void SetStateOn()
		{
			base.SetStateOn();

			kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(255, 255, 255, 255);
			kryptonPanel1.StateCommon.Color2 = kryptonPanel1.StateCommon.Color1;
			kryptonPanel1.StateCommon.Image = darkImage;
			kryptonPanel2.Visible = true;

			kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(255, 38, 38, 38);
			kryptonPanel2.StateCommon.Color2 = kryptonPanel1.StateCommon.Color1;
		}

		private void InitializeComponent()
		{
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(60, 60);
            this.kryptonPanel1.StateCommon.Image = global::Couriers_GUI.Properties.Resources.file_circle_exclamation_solid;
            this.kryptonPanel1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.Click += new System.EventHandler(this.kryptonPanel1_Click);
            this.kryptonPanel1.MouseEnter += new System.EventHandler(this.kryptonPanel1_MouseEnter);
            this.kryptonPanel1.MouseLeave += new System.EventHandler(this.kryptonPanel1_MouseLeave);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(4, 60);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // NavigationButton
            // 
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NavigationButton";
            this.Size = new System.Drawing.Size(60, 60);
            this.Click += new System.EventHandler(this.NavigationButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.ResumeLayout(false);

		}

		private void kryptonPanel1_Click(object sender, EventArgs e)
		{
			ClickButton();
		}

        private void kryptonPanel1_MouseEnter(object sender, EventArgs e)
        {
			EnterHover();
        }

        private void kryptonPanel1_MouseLeave(object sender, EventArgs e)
        {
			ExitHover();	
		}

        private void NavigationButton_Click(object sender, EventArgs e)
		{
			ClickButton();
		}
	}
}
