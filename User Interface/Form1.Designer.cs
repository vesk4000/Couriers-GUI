
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
            this.multipleTableControl1 = new Couriers_GUI.User_Interface.Custom_Controls.MultipleTableControl();
            this.SuspendLayout();
            // 
            // multipleTableControl1
            // 
            this.multipleTableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multipleTableControl1.Location = new System.Drawing.Point(0, 0);
            this.multipleTableControl1.Name = "multipleTableControl1";
            this.multipleTableControl1.Size = new System.Drawing.Size(650, 412);
            this.multipleTableControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 412);
            this.Controls.Add(this.multipleTableControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion

		private User_Interface.Custom_Controls.MultipleTableControl multipleTableControl1;
	}
}

