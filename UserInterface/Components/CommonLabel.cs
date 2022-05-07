using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.UserInterface.Components
{
	public class CommonLabel : Krypton.Toolkit.KryptonLabel
	{
		public CommonLabel()
        {
			StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(255, 90, 90, 90);
			StateCommon.ShortText.Color2 = StateCommon.ShortText.Color1;
        }
	}
}
