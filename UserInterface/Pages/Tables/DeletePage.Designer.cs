
namespace Couriers_GUI.UserInterface.Pages.Tables
{
	partial class DeletePage
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.commonLabel1 = new Couriers_GUI.UserInterface.Components.CommonLabel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.commonButtonCancel = new Couriers_GUI.UserInterface.Components.CommonButton();
			this.commonButtonAdd = new Couriers_GUI.UserInterface.Components.CommonButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.commonLabel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 573);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// commonLabel1
			// 
			this.commonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.commonLabel1.Location = new System.Drawing.Point(357, 3);
			this.commonLabel1.Name = "commonLabel1";
			this.commonLabel1.Size = new System.Drawing.Size(37, 24);
			this.commonLabel1.TabIndex = 0;
			this.commonLabel1.Values.Text = "Asd";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 5;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.75148F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.1716F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
			this.tableLayoutPanel3.Controls.Add(this.commonButtonCancel, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.commonButtonAdd, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 33);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(746, 125);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// commonButtonCancel
			// 
			this.commonButtonCancel.Location = new System.Drawing.Point(512, 3);
			this.commonButtonCancel.Name = "commonButtonCancel";
			this.commonButtonCancel.Size = new System.Drawing.Size(112, 31);
			this.commonButtonCancel.TabIndex = 1;
			this.commonButtonCancel.Values.Text = "Cancel";
			this.commonButtonCancel.Click += new System.EventHandler(this.commonButtonCancel_Click);
			// 
			// commonButtonAdd
			// 
			this.commonButtonAdd.Location = new System.Drawing.Point(93, 3);
			this.commonButtonAdd.Name = "commonButtonAdd";
			this.commonButtonAdd.Size = new System.Drawing.Size(112, 31);
			this.commonButtonAdd.TabIndex = 0;
			this.commonButtonAdd.Values.Text = "Add";
			this.commonButtonAdd.Click += new System.EventHandler(this.commonButtonAdd_Click);
			// 
			// DeletePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "DeletePage";
			this.Size = new System.Drawing.Size(752, 573);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Components.CommonLabel commonLabel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private Components.CommonButton commonButtonCancel;
		private Components.CommonButton commonButtonAdd;
	}
}
