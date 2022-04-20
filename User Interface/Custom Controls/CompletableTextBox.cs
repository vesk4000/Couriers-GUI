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
            this.Leave += new System.EventHandler(kryptonTextBox1_Leave);
            this.TextChanged += new System.EventHandler(kryptonTextBox1_TextChanged);
            
           







        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            activeDataSource = dataSource.Where(s => s.Contains(this.Text)).ToList();

            if(kryptonListBox1 is not null)
            {
                //kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
                //Parent.Controls.Add(kryptonListBox1);

                if(activeDataSource.Count == 0)
                    kryptonListBox1.DataSource = activeDataSource;
                else
                    kryptonListBox1.Visible = false;
            }

            

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
            
            //
            dataSource.Add("qwert");
            dataSource.Add("11111111");
            dataSource.Add("123111222333");
            //
            
            kryptonListBox1.DataSource = activeDataSource;
            this.kryptonListBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonListBox1_SelectedIndexChanged);
            this.kryptonListBox1.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + this.Height);
            this.kryptonListBox1.Size = new System.Drawing.Size(this.Size.Width, kryptonListBox1.Size.Height);


            kryptonListBox1.Visible = true;
            kryptonListBox1.BringToFront();
        }

        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        public List<string> dataSource = new List<string>();
        private List<string> activeDataSource = new List<string>();
        //private int heightOfListBox;

    }
}
