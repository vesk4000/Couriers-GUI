using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.User_Interface.Custom_Controls
{
    public partial class NavigationButton : UserControl
    {
        public NavigationButton()
        {
            InitializeComponent();
        }

        public void ClickButton()
        {

        }

        private void NavigationButton_MouseClick(object sender, MouseEventArgs e)
        {
            ClickButton();
        }

        private void kryptonPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            ClickButton();
        }

        private void kryptonLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            ClickButton();
        }
    }
}
