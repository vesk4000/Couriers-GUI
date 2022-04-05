
namespace Couriers_GUI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.multipleTableContainer1 = new Couriers_GUI.User_Interface.MultipleTableContainer();
			this.SuspendLayout();
			// 
			// multipleTableContainer1
			// 
			this.multipleTableContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.multipleTableContainer1.Location = new System.Drawing.Point(0, 0);
			this.multipleTableContainer1.Name = "multipleTableContainer1";
			this.multipleTableContainer1.Size = new System.Drawing.Size(800, 450);
			this.multipleTableContainer1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.multipleTableContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private User_Interface.MultipleTableContainer multipleTableContainer1;
	}
}

