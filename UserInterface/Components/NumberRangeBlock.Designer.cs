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
			this.commonTextBox1 = new Couriers_GUI.UserInterface.Components.CommonTextBox();
			this.commonTextBox2 = new Couriers_GUI.UserInterface.Components.CommonTextBox();
			this.commonLabel1 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.commonLabel2 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.commonLabel3 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.SuspendLayout();
			// 
			// commonTextBox1
			// 
			this.commonTextBox1.Location = new System.Drawing.Point(89, 36);
			this.commonTextBox1.Name = "commonTextBox1";
			this.commonTextBox1.Size = new System.Drawing.Size(125, 27);
			this.commonTextBox1.TabIndex = 2;
			this.commonTextBox1.Text = "commonTextBox1";
			// 
			// commonTextBox2
			// 
			this.commonTextBox2.Location = new System.Drawing.Point(272, 36);
			this.commonTextBox2.Name = "commonTextBox2";
			this.commonTextBox2.Size = new System.Drawing.Size(125, 27);
			this.commonTextBox2.TabIndex = 4;
			this.commonTextBox2.Text = "commonTextBox2";
			// 
			// commonLabel1
			// 
			this.commonLabel1.Location = new System.Drawing.Point(3, 3);
			this.commonLabel1.Name = "commonLabel1";
			this.commonLabel1.Size = new System.Drawing.Size(129, 27);
			this.commonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.commonLabel1.TabIndex = 5;
			this.commonLabel1.Values.Text = "commonLabel1";
			// 
			// commonLabel2
			// 
			this.commonLabel2.Location = new System.Drawing.Point(3, 36);
			this.commonLabel2.Name = "commonLabel2";
			this.commonLabel2.Size = new System.Drawing.Size(80, 27);
			this.commonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.commonLabel2.TabIndex = 6;
			this.commonLabel2.Values.Text = "Between:";
			// 
			// commonLabel3
			// 
			this.commonLabel3.Location = new System.Drawing.Point(220, 36);
			this.commonLabel3.Name = "commonLabel3";
			this.commonLabel3.Size = new System.Drawing.Size(47, 27);
			this.commonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.commonLabel3.TabIndex = 7;
			this.commonLabel3.Values.Text = "And:";
			// 
			// NumberRangeBlock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.commonLabel3);
			this.Controls.Add(this.commonLabel2);
			this.Controls.Add(this.commonLabel1);
			this.Controls.Add(this.commonTextBox2);
			this.Controls.Add(this.commonTextBox1);
			this.Name = "NumberRangeBlock";
			this.Size = new System.Drawing.Size(400, 70);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public CommonTextBox commonTextBox1;
		public CommonTextBox commonTextBox2;
		public CommonLabel commonLabel1;
		private CommonLabel commonLabel2;
		private CommonLabel commonLabel3;
	}
}
