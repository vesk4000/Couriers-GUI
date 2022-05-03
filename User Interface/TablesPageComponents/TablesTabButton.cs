using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.User_Interface.TablesPageComponents
{
    public partial class TablesTabButton<TableService> : Custom_Controls.TabButton// where TableService : Backend.Services.ITableService
    {
        public Type tableType;

        public TablesTabButton()
        {
            //InitializeComponent();
            
        }

        public override void SetStateOff() { }

		public override void SetStateHover() { }

		public override void SetStateOn() { }

        private void TablesTabButton_Click(object sender, EventArgs e)
        {
            ClickButton();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {
            ClickButton();
        }
    }
}
