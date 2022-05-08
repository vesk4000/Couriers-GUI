
namespace Couriers_GUI.UserInterface
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.navigationPanel1 = new Couriers_GUI.UserInterface.Navigation.NavigationPanel();
			this.SuspendLayout();
			// 
			// navigationPanel1
			// 
			this.navigationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navigationPanel1.Location = new System.Drawing.Point(0, 0);
			this.navigationPanel1.Name = "navigationPanel1";
			this.navigationPanel1.Size = new System.Drawing.Size(897, 563);
			this.navigationPanel1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 563);
			this.Controls.Add(this.navigationPanel1);
			this.MinimumSize = new System.Drawing.Size(915, 610);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private UserInterface.Navigation.NavigationPanel navigationPanel1;
	}
}