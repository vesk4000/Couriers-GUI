
namespace Couriers_GUI.UserInterface.Pages.Tables
{
	partial class TableView
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.commonButtonAdd = new Couriers_GUI.UserInterface.Components.CommonButton();
			this.commonButton2 = new Couriers_GUI.UserInterface.Components.CommonButton();
			this.commonButton3 = new Couriers_GUI.UserInterface.Components.CommonButton();
			this.commonButton4 = new Couriers_GUI.UserInterface.Components.CommonButton();
			this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.kryptonDataGridView1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 498);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.commonButtonAdd, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.commonButton2, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.commonButton3, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.commonButton4, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(728, 40);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// commonButtonAdd
			// 
			this.commonButtonAdd.Location = new System.Drawing.Point(3, 3);
			this.commonButtonAdd.Name = "commonButtonAdd";
			this.commonButtonAdd.Size = new System.Drawing.Size(112, 31);
			this.commonButtonAdd.TabIndex = 0;
			this.commonButtonAdd.Values.Text = "Add";
			this.commonButtonAdd.Click += new System.EventHandler(this.commonButtonAdd_Click);
			// 
			// commonButton2
			// 
			this.commonButton2.Location = new System.Drawing.Point(121, 3);
			this.commonButton2.Name = "commonButton2";
			this.commonButton2.Size = new System.Drawing.Size(112, 31);
			this.commonButton2.TabIndex = 1;
			this.commonButton2.Values.Text = "Edit";
			this.commonButton2.Click += new System.EventHandler(this.commonButton2_Click);
			// 
			// commonButton3
			// 
			this.commonButton3.Location = new System.Drawing.Point(239, 3);
			this.commonButton3.Name = "commonButton3";
			this.commonButton3.Size = new System.Drawing.Size(112, 31);
			this.commonButton3.TabIndex = 2;
			this.commonButton3.Values.Text = "Delete";
			this.commonButton3.Click += new System.EventHandler(this.commonButton3_Click);
			// 
			// commonButton4
			// 
			this.commonButton4.Location = new System.Drawing.Point(357, 3);
			this.commonButton4.Name = "commonButton4";
			this.commonButton4.Size = new System.Drawing.Size(112, 31);
			this.commonButton4.TabIndex = 3;
			this.commonButton4.Values.Text = "Filter";
			this.commonButton4.Click += new System.EventHandler(this.commonButton4_Click);
			// 
			// kryptonDataGridView1
			// 
			this.kryptonDataGridView1.AllowUserToAddRows = false;
			this.kryptonDataGridView1.AllowUserToDeleteRows = false;
			this.kryptonDataGridView1.AllowUserToResizeColumns = false;
			this.kryptonDataGridView1.AllowUserToResizeRows = false;
			this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.kryptonDataGridView1.ColumnHeadersHeight = 36;
			this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kryptonDataGridView1.Location = new System.Drawing.Point(10, 55);
			this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(10);
			this.kryptonDataGridView1.Name = "kryptonDataGridView1";
			this.kryptonDataGridView1.ReadOnly = true;
			this.kryptonDataGridView1.RowHeadersWidth = 51;
			this.kryptonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.kryptonDataGridView1.RowTemplate.Height = 29;
			this.kryptonDataGridView1.Size = new System.Drawing.Size(713, 452);
			this.kryptonDataGridView1.TabIndex = 1;
			// 
			// TableView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "TableView";
			this.Size = new System.Drawing.Size(733, 498);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private Components.CommonButton commonButtonAdd;
		private Components.CommonButton commonButton2;
		private Components.CommonButton commonButton3;
		private Components.CommonButton commonButton4;
		public Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
	}
}
