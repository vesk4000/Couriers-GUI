
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
            this.commonButton2 = new Couriers_GUI.UserInterface.Components.CommonButton();
            this.SuspendLayout();
            // 
            // commonButton1
            // 
            this.commonButton1.Location = new System.Drawing.Point(111, 90);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.Size = new System.Drawing.Size(112, 31);
            this.commonButton1.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.commonButton1.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.commonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.commonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.commonButton1.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.commonButton1.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.commonButton1.TabIndex = 0;
            this.commonButton1.Values.Text = "commonButton1";
            this.commonButton1.Click += new System.EventHandler(this.commonButton1_Click);
            // 
            // commonButton2
            // 
            this.commonButton2.Location = new System.Drawing.Point(372, 90);
            this.commonButton2.Name = "commonButton2";
            this.commonButton2.Size = new System.Drawing.Size(112, 31);
            this.commonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.commonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.commonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.commonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.commonButton2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.commonButton2.StateCommon.Border.Width = 2;
            this.commonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.commonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.commonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commonButton2.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.commonButton2.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.commonButton2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.commonButton2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.commonButton2.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.commonButton2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.commonButton2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.commonButton2.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.commonButton2.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.commonButton2.StateTracking.Border.Width = 2;
            this.commonButton2.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.commonButton2.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.commonButton2.TabIndex = 1;
            // 
            // ServerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commonButton2);
            this.Controls.Add(this.commonButton1);
            this.Name = "ServerPage";
            this.Size = new System.Drawing.Size(588, 253);
            this.ResumeLayout(false);

		}

		#endregion

		private Components.CommonButton commonButton1;
        private Components.CommonButton commonButton2;
    }
}
