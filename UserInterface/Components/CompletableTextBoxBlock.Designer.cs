
namespace Couriers_GUI.UserInterface.Components
{
	public partial class CompletableTextBoxBlock
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.commonLabel1 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.completableTextBox1 = new Couriers_GUI.UserInterface.Components.CompletableTextBox();
			this.SuspendLayout();
			// 
			// commonLabel1
			// 
			this.commonLabel1.Location = new System.Drawing.Point(5, 5);
			this.commonLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.commonLabel1.Name = "commonLabel1";
			this.commonLabel1.Size = new System.Drawing.Size(116, 24);
			this.commonLabel1.TabIndex = 0;
			this.commonLabel1.Values.Text = "commonLabel1";
			// 
			// completableTextBox1
			// 
			this.completableTextBox1.Location = new System.Drawing.Point(5, 27);
			this.completableTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.completableTextBox1.Name = "completableTextBox1";
			this.completableTextBox1.Size = new System.Drawing.Size(229, 27);
			this.completableTextBox1.TabIndex = 1;
			// 
			// CompletableTextBoxBlock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.commonLabel1);
			this.Controls.Add(this.completableTextBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "CompletableTextBoxBlock";
			this.Size = new System.Drawing.Size(363, 82);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public CommonLabel commonLabel1;
		public CompletableTextBox completableTextBox1;

	}
}
