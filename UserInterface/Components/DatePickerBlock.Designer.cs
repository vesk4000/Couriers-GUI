
namespace Couriers_GUI.UserInterface.Components
{
    partial class DatePickerBlock
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
            this.commonLabel1 = new Couriers_GUI.UserInterface.Components.CommonLabel();
            this.commonLabel2 = new Couriers_GUI.UserInterface.Components.CommonLabel();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.commonLabel3 = new Couriers_GUI.UserInterface.Components.CommonLabel();
            this.kryptonDateTimePicker2 = new Krypton.Toolkit.KryptonDateTimePicker();
            this.SuspendLayout();
            // 
            // commonLabel1
            // 
            this.commonLabel1.Location = new System.Drawing.Point(4, 4);
            this.commonLabel1.Name = "commonLabel1";
            this.commonLabel1.Size = new System.Drawing.Size(94, 20);
            this.commonLabel1.TabIndex = 0;
            this.commonLabel1.Values.Text = "commonLabel1";
            // 
            // commonLabel2
            // 
            this.commonLabel2.Location = new System.Drawing.Point(4, 31);
            this.commonLabel2.Name = "commonLabel2";
            this.commonLabel2.Size = new System.Drawing.Size(60, 20);
            this.commonLabel2.TabIndex = 1;
            this.commonLabel2.Values.Text = "Between:";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(71, 31);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(160, 21);
            this.kryptonDateTimePicker1.TabIndex = 2;
            // 
            // commonLabel3
            // 
            this.commonLabel3.Location = new System.Drawing.Point(238, 31);
            this.commonLabel3.Name = "commonLabel3";
            this.commonLabel3.Size = new System.Drawing.Size(35, 20);
            this.commonLabel3.TabIndex = 3;
            this.commonLabel3.Values.Text = "And:";
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(280, 31);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(161, 21);
            this.kryptonDateTimePicker2.TabIndex = 4;
            // 
            // DatePickerBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonDateTimePicker2);
            this.Controls.Add(this.commonLabel3);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.commonLabel2);
            this.Controls.Add(this.commonLabel1);
            this.Name = "DatePickerBlock";
            this.Size = new System.Drawing.Size(486, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CommonLabel commonLabel1;
        private CommonLabel commonLabel2;
        public Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private CommonLabel commonLabel3;
        public Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
    }
}
