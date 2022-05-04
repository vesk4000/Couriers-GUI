
namespace Couriers_GUI.UserInterface.Pages
{
	partial class ServerPage
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.commonButton1 = new Couriers_GUI.UserInterface.Components.CommonButton();
			this.SuspendLayout();
			// 
			// commonButton1
			// 
			this.commonButton1.Location = new System.Drawing.Point(111, 90);
			this.commonButton1.Name = "commonButton1";
			this.commonButton1.Size = new System.Drawing.Size(112, 31);
			this.commonButton1.TabIndex = 0;
			this.commonButton1.Values.Text = "commonButton1";
			this.commonButton1.Click += new System.EventHandler(this.commonButton1_Click);
			// 
			// ServerPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.commonButton1);
			this.Name = "ServerPage";
			this.Size = new System.Drawing.Size(588, 253);
			this.ResumeLayout(false);

		}

		#endregion

		private Components.CommonButton commonButton1;
	}
}
