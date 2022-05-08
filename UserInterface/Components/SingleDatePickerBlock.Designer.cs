namespace Couriers_GUI.UserInterface.Components
{
	partial class SingleDatePickerBlock
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
			this.commonDateTimePicker1 = new Couriers_GUI.UserInterface.Components.CommonDateTimePicker();
			this.commonLabel1 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.commonLabel2 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.SuspendLayout();
			// 
			// commonDateTimePicker1
			// 
			this.commonDateTimePicker1.Location = new System.Drawing.Point(47, 30);
			this.commonDateTimePicker1.Name = "commonDateTimePicker1";
			this.commonDateTimePicker1.Size = new System.Drawing.Size(292, 25);
			this.commonDateTimePicker1.TabIndex = 3;
			// 
			// commonLabel1
			// 
			this.commonLabel1.Location = new System.Drawing.Point(3, 3);
			this.commonLabel1.Name = "commonLabel1";
			this.commonLabel1.Size = new System.Drawing.Size(129, 27);
			this.commonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.commonLabel1.TabIndex = 4;
			this.commonLabel1.Values.Text = "commonLabel1";
			// 
			// commonLabel2
			// 
			this.commonLabel2.Location = new System.Drawing.Point(3, 30);
			this.commonLabel2.Name = "commonLabel2";
			this.commonLabel2.Size = new System.Drawing.Size(38, 27);
			this.commonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
			this.commonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.commonLabel2.TabIndex = 5;
			this.commonLabel2.Values.Text = "On:";
			// 
			// SingleDatePickerBlock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.commonLabel2);
			this.Controls.Add(this.commonLabel1);
			this.Controls.Add(this.commonDateTimePicker1);
			this.Name = "SingleDatePickerBlock";
			this.Size = new System.Drawing.Size(350, 60);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public CommonDateTimePicker commonDateTimePicker1;
		public CommonLabel commonLabel1;
		private CommonLabel commonLabel2;
	}
}
