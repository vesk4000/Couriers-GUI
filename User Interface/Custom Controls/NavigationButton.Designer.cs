
namespace Couriers_GUI.User_Interface.Custom_Controls
{
    partial class NavigationButton
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
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.Location = new System.Drawing.Point(10, 0);
			this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(50, 50);
			this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
			this.kryptonPanel1.StateCommon.Image = global::Couriers_GUI.Properties.Resources.file_circle_exclamation_solid;
			this.kryptonPanel1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
			this.kryptonPanel1.TabIndex = 2;
			this.kryptonPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel1_MouseClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(0, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 30);
			this.label1.TabIndex = 3;
			this.label1.Text = "NO_NAME";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NavigationButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.kryptonPanel1);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
			this.Name = "NavigationButton";
			this.Size = new System.Drawing.Size(70, 80);
			this.Load += new System.EventHandler(this.NavigationButton_Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NavigationButton_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        public Krypton.Toolkit.KryptonPanel kryptonPanel1;
		public System.Windows.Forms.Label label1;
	}
}
