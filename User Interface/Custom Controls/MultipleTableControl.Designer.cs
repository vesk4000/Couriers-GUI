
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.AutoScroll = true;
            this.kryptonPanel1.Controls.Add(this.button1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(532, 476);
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MultipleTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MultipleTableControl";
            this.Size = new System.Drawing.Size(532, 476);
            this.Load += new System.EventHandler(this.MultipleTableControl_Load);
            this.Click += new System.EventHandler(this.MultipleTableControl_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MultipleTableControl_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Button button1;
    }
}
