using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.User_Interface.Pages
{
    public partial class TablesTabsPage : UserControl
    {
        public List<Custom_Controls.TabButton> Buttons = new List<Custom_Controls.TabButton>();
        public UserControl Content;

        public TablesTabsPage()
        {
            InitializeComponent();
        }
    }
}
