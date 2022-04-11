
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
			this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
			this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			this.kryptonPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.AutoScroll = true;
			this.kryptonPanel1.Controls.Add(this.kryptonDataGridView1);
			this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(856, 698);
			this.kryptonPanel1.TabIndex = 0;
			this.kryptonPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel1_MouseClick);
			// 
			// kryptonDataGridView1
			// 
			this.kryptonDataGridView1.AllowUserToAddRows = false;
			this.kryptonDataGridView1.AllowUserToDeleteRows = false;
			this.kryptonDataGridView1.AllowUserToResizeColumns = false;
			this.kryptonDataGridView1.AllowUserToResizeRows = false;
			this.kryptonDataGridView1.ColumnHeadersHeight = 36;
			this.kryptonDataGridView1.ColumnHeadersVisible = false;
			this.kryptonDataGridView1.Location = new System.Drawing.Point(475, 108);
			this.kryptonDataGridView1.Name = "kryptonDataGridView1";
			this.kryptonDataGridView1.RowHeadersWidth = 51;
			this.kryptonDataGridView1.RowTemplate.Height = 29;
			this.kryptonDataGridView1.Size = new System.Drawing.Size(300, 188);
			this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryptonDataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
			this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.kryptonDataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
			this.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonDataGridView1.StateCommon.DataCell.Border.Rounding = 5F;
			this.kryptonDataGridView1.StateCommon.DataCell.Border.Width = 5;
			this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Draw = Krypton.Toolkit.InheritBool.False;
			this.kryptonDataGridView1.StateCommon.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonDataGridView1.StateCommon.HeaderRow.Content.Draw = Krypton.Toolkit.InheritBool.False;
			this.kryptonDataGridView1.TabIndex = 0;
			// 
			// MultipleTableControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.kryptonPanel1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MultipleTableControl";
			this.Size = new System.Drawing.Size(856, 698);
			this.Load += new System.EventHandler(this.MultipleTableControl_Load);
			this.Click += new System.EventHandler(this.MultipleTableControl_Click);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MultipleTableControl_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			this.kryptonPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Krypton.Toolkit.KryptonPanel kryptonPanel1;
		private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
	}
}
