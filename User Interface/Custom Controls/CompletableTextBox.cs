using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.User_Interface.Custom_Controls
{
    class CompletableTextBox : Krypton.Toolkit.KryptonTextBox
    {
        public CompletableTextBox() : base()
        {
            this.Click += new System.EventHandler(kryptonTextBox1_Click);
            this.Leave += new System.EventHandler(this.kryptonTextBox1_Leave);

            
           







        }



        private void kryptonListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = kryptonListBox1.SelectedItem.ToString();
            kryptonListBox1.Visible = false;
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if(!kryptonListBox1.Focused) kryptonListBox1.Visible = false;
        }

        private void kryptonTextBox1_Click(object sender, EventArgs e)
        {
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            Parent.Controls.Add(kryptonListBox1);
            this.kryptonListBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonListBox1_SelectedIndexChanged);


            kryptonListBox1.Visible = true;
            kryptonListBox1.BringToFront();
        }

        private Krypton.Toolkit.KryptonListBox kryptonListBox1;

    }
}
