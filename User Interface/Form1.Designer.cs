
namespace Couriers_GUI.User_Interface
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigablePanel1 = new Couriers_GUI.User_Interface.Custom_Controls.NavigablePanel();
            this.SuspendLayout();
            // 
            // navigablePanel1
            // 
            this.navigablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigablePanel1.Location = new System.Drawing.Point(0, 0);
            this.navigablePanel1.Name = "navigablePanel1";
            this.navigablePanel1.Size = new System.Drawing.Size(606, 320);
            this.navigablePanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 320);
            this.Controls.Add(this.navigablePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.NavigablePanel navigablePanel1;
    }
}