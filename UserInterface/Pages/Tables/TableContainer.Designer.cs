
namespace Couriers_GUI.UserInterface.Pages.Tables
{
	partial class TableContainer
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
			this.tableView1 = new Couriers_GUI.UserInterface.Pages.Tables.TableView();
			this.SuspendLayout();
			// 
			// tableView1
			// 
			this.tableView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableView1.Location = new System.Drawing.Point(0, 0);
			this.tableView1.Name = "tableView1";
			this.tableView1.Size = new System.Drawing.Size(751, 510);
			this.tableView1.TabIndex = 0;
			// 
			// TableContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableView1);
			this.Name = "TableContainer";
			this.Size = new System.Drawing.Size(751, 510);
			this.ResumeLayout(false);

		}

		#endregion

		private TableView tableView1;
	}
}
