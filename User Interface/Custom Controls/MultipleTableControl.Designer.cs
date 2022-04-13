
namespace Couriers_GUI.User_Interface.Custom_Controls
{
	partial class MultipleTableControl
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
			this.panel = new Couriers_GUI.User_Interface.Modified_Controls.ModifiedKryptonPanel();
			this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
			this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
			((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.AutoScroll = true;
			this.panel.Controls.Add(this.kryptonButton1);
			this.panel.Controls.Add(this.kryptonDataGridView1);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(856, 699);
			this.panel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
			this.panel.TabIndex = 0;
			this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
			// 
			// kryptonDataGridView1
			// 
			this.kryptonDataGridView1.ColumnHeadersHeight = 36;
			this.kryptonDataGridView1.Location = new System.Drawing.Point(398, 105);
			this.kryptonDataGridView1.Name = "kryptonDataGridView1";
			this.kryptonDataGridView1.RowHeadersWidth = 51;
			this.kryptonDataGridView1.RowTemplate.Height = 29;
			this.kryptonDataGridView1.Size = new System.Drawing.Size(300, 188);
			this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryptonDataGridView1.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryptonDataGridView1.StateCommon.Background.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
			this.kryptonDataGridView1.StateCommon.Background.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
			this.kryptonDataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
			this.kryptonDataGridView1.TabIndex = 0;
			// 
			// kryptonButton1
			// 
			this.kryptonButton1.Location = new System.Drawing.Point(613, 431);
			this.kryptonButton1.Name = "kryptonButton1";
			this.kryptonButton1.Size = new System.Drawing.Size(85, 157);
			this.kryptonButton1.StateCommon.Back.Image = global::Couriers_GUI.Properties.Resources.question_solid;
			this.kryptonButton1.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
			this.kryptonButton1.TabIndex = 1;
			this.kryptonButton1.Values.Text = "kryptonButton1";
			// 
			// MultipleTableControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MultipleTableControl";
			this.Size = new System.Drawing.Size(856, 699);
			this.Load += new System.EventHandler(this.MultipleTableControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Modified_Controls.ModifiedKryptonPanel panel;
		private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
		private Krypton.Toolkit.KryptonButton kryptonButton1;
	}
}
