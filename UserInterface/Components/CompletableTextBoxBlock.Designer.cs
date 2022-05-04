
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
			this.SuspendLayout();
			// 
			// commonLabel1
			// 
			this.commonLabel1.Location = new System.Drawing.Point(4, 4);
			this.commonLabel1.Name = "commonLabel1";
			this.commonLabel1.Size = new System.Drawing.Size(94, 20);
			this.commonLabel1.TabIndex = 0;
			this.commonLabel1.Values.Text = "commonLabel1";
			//
			// completableTextBox
			//
			this.completableTextBox1.Location = new System.Drawing.Point(4, 20);
			this.commonLabel1.Name = "completableTextBox1";
			this.commonLabel1.Size = new System.Drawing.Size(94, 20);
			this.commonLabel1.TabIndex = 1;
			this.commonLabel1.Values.Text = "";
			// 
			// CompletableTextBoxBlock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.commonLabel1);
			this.Name = "CompletableTextBoxBlock";
			this.Size = new System.Drawing.Size(318, 107);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public CommonLabel commonLabel1;
		public CompletableTextBox completableTextBox1;

	}
}
