namespace Couriers_GUI.UserInterface.Components
{
	partial class NumberRangeBlock
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
			this.commonLabel2 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.commonTextBox1 = new Couriers_GUI.UserInterface.Components.CommonTextBox();
			this.commonLabel3 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.commonTextBox2 = new Couriers_GUI.UserInterface.Components.CommonTextBox();
			this.SuspendLayout();
			// 
			// commonLabel1
			// 
			this.commonLabel1.Location = new System.Drawing.Point(6, 4);
			this.commonLabel1.Name = "commonLabel1";
			this.commonLabel1.Size = new System.Drawing.Size(129, 27);
			this.commonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.commonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.commonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.commonLabel1.TabIndex = 0;
			this.commonLabel1.Values.Text = "commonLabel1";
			// 
			// commonLabel2
			// 
			this.commonLabel2.Location = new System.Drawing.Point(7, 44);
			this.commonLabel2.Name = "commonLabel2";
			this.commonLabel2.Size = new System.Drawing.Size(77, 27);
			this.commonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.commonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.commonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.commonLabel2.TabIndex = 1;
			this.commonLabel2.Values.Text = "Between";
			// 
			// commonTextBox1
			// 
			this.commonTextBox1.Location = new System.Drawing.Point(87, 46);
			this.commonTextBox1.Name = "commonTextBox1";
			this.commonTextBox1.Size = new System.Drawing.Size(125, 27);
			this.commonTextBox1.TabIndex = 2;
			this.commonTextBox1.Text = "commonTextBox1";
			// 
			// commonLabel3
			// 
			this.commonLabel3.Location = new System.Drawing.Point(218, 44);
			this.commonLabel3.Name = "commonLabel3";
			this.commonLabel3.Size = new System.Drawing.Size(43, 27);
			this.commonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.commonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.commonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.commonLabel3.TabIndex = 3;
			this.commonLabel3.Values.Text = "And";
			// 
			// commonTextBox2
			// 
			this.commonTextBox2.Location = new System.Drawing.Point(270, 44);
			this.commonTextBox2.Name = "commonTextBox2";
			this.commonTextBox2.Size = new System.Drawing.Size(125, 27);
			this.commonTextBox2.TabIndex = 4;
			this.commonTextBox2.Text = "commonTextBox2";
			// 
			// NumberRangeBlock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.commonTextBox2);
			this.Controls.Add(this.commonLabel3);
			this.Controls.Add(this.commonTextBox1);
			this.Controls.Add(this.commonLabel2);
			this.Controls.Add(this.commonLabel1);
			this.Name = "NumberRangeBlock";
			this.Size = new System.Drawing.Size(418, 97);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public CommonLabel commonLabel1;
		private CommonLabel commonLabel2;
		public CommonTextBox commonTextBox1;
		private CommonLabel commonLabel3;
		public CommonTextBox commonTextBox2;
	}
}
