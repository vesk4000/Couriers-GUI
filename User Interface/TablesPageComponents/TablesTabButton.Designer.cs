
namespace Couriers_GUI.User_Interface.TablesPageComponents
{
    partial class TablesTabButton : Custom_Controls.TabButton
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(4, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            //this.kryptonLabel1.Click += new System.EventHandler(this.kryptonLabel1_Click);
            // 
            // TablesTabButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "TablesTabButton";
            this.Size = new System.Drawing.Size(117, 29);
            //this.Click += new System.EventHandler(this.TablesTabButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override void SetStateOff()
        {
            throw new System.NotImplementedException();
        }

        public override void SetStateHover()
        {
            throw new System.NotImplementedException();
        }

        public override void SetStateOn()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
