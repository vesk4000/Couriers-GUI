
namespace Couriers_GUI.User_Interface.Custom_Controls
{
    partial class NavigablePanel
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tablesNavigationButton1 = new Couriers_GUI.User_Interface.Custom_Controls.TablesNavigationButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.serverPageNavigationButton1 = new Couriers_GUI.User_Interface.Custom_Controls.ServerPageNavigationButton();
			this.devPageNavigationButton1 = new Couriers_GUI.User_Interface.Custom_Controls.DevPageNavigationButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 609);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.PaleGreen;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.tablesNavigationButton1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.serverPageNavigationButton1, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.devPageNavigationButton1, 0, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(80, 609);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// tablesNavigationButton1
			// 
			this.tablesNavigationButton1.BackColor = System.Drawing.Color.Transparent;
			this.tablesNavigationButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tablesNavigationButton1.Location = new System.Drawing.Point(0, 0);
			this.tablesNavigationButton1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
			this.tablesNavigationButton1.Name = "tablesNavigationButton1";
			this.tablesNavigationButton1.Size = new System.Drawing.Size(88, 100);
			this.tablesNavigationButton1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(83, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(767, 603);
			this.panel1.TabIndex = 1;
			// 
			// serverPageNavigationButton1
			// 
			this.serverPageNavigationButton1.BackColor = System.Drawing.Color.Transparent;
			this.serverPageNavigationButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.serverPageNavigationButton1.Location = new System.Drawing.Point(0, 105);
			this.serverPageNavigationButton1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
			this.serverPageNavigationButton1.Name = "serverPageNavigationButton1";
			this.serverPageNavigationButton1.Size = new System.Drawing.Size(88, 100);
			this.serverPageNavigationButton1.TabIndex = 1;
			// 
			// devPageNavigationButton1
			// 
			this.devPageNavigationButton1.BackColor = System.Drawing.Color.Transparent;
			this.devPageNavigationButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.devPageNavigationButton1.Location = new System.Drawing.Point(0, 210);
			this.devPageNavigationButton1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
			this.devPageNavigationButton1.Name = "devPageNavigationButton1";
			this.devPageNavigationButton1.Size = new System.Drawing.Size(88, 100);
			this.devPageNavigationButton1.TabIndex = 2;
			// 
			// NavigablePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "NavigablePanel";
			this.Size = new System.Drawing.Size(833, 609);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel1;
		private TablesNavigationButton tablesNavigationButton1;
		private ServerPageNavigationButton serverPageNavigationButton1;
		private DevPageNavigationButton devPageNavigationButton1;
	}
}
