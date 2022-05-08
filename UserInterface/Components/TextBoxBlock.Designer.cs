
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
            this.commonTextBox1 = new Couriers_GUI.UserInterface.Components.CommonTextBox();
            this.commonLabel1 = new Couriers_GUI.UserInterface.Components.CommonLabel();
            this.SuspendLayout();
            // 
            // commonTextBox1
            // 
            this.commonTextBox1.Location = new System.Drawing.Point(4, 23);
            this.commonTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commonTextBox1.Name = "commonTextBox1";
            this.commonTextBox1.Size = new System.Drawing.Size(299, 23);
            this.commonTextBox1.TabIndex = 1;
            this.commonTextBox1.Text = "commonTextBox1";
            // 
            // commonLabel1
            // 
            this.commonLabel1.Location = new System.Drawing.Point(3, 1);
            this.commonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commonLabel1.Name = "commonLabel1";
            this.commonLabel1.Size = new System.Drawing.Size(104, 22);
            this.commonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.commonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.commonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commonLabel1.TabIndex = 2;
            this.commonLabel1.Values.Text = "commonLabel1";
            // 
            // TextBoxBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commonLabel1);
            this.Controls.Add(this.commonTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TextBoxBlock";
            this.Size = new System.Drawing.Size(306, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		public CommonTextBox commonTextBox1;
		public CommonLabel commonLabel1;
	}
}
