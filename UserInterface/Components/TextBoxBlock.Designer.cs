
namespace Couriers_GUI.UserInterface.Components
{
	public partial class TextBoxBlock
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
			this.commonLabel1 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.commonTextBox1 = new Couriers_GUI.UserInterface.Components.CommonTextBox();
			this.SuspendLayout();
			// 
			// commonLabel1
			// 
			this.commonLabel1.Location = new System.Drawing.Point(4, 4);
			this.commonLabel1.Name = "commonLabel1";
			this.commonLabel1.Size = new System.Drawing.Size(116, 24);
			this.commonLabel1.TabIndex = 0;
			this.commonLabel1.Values.Text = "commonLabel1";
			// 
			// commonTextBox1
			// 
			this.commonTextBox1.Location = new System.Drawing.Point(4, 35);
			this.commonTextBox1.Name = "commonTextBox1";
			this.commonTextBox1.Size = new System.Drawing.Size(454, 27);
			this.commonTextBox1.TabIndex = 1;
			this.commonTextBox1.Text = "commonTextBox1";
			// 
			// TextBoxBlock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.commonTextBox1);
			this.Controls.Add(this.commonLabel1);
			this.Name = "TextBoxBlock";
			this.Size = new System.Drawing.Size(648, 75);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public CommonLabel commonLabel1;
		public CommonTextBox commonTextBox1;
	}
}
