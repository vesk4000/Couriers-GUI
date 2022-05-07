using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.UserInterface.Components
{
	public class CommonButton : Krypton.Toolkit.KryptonButton
	{
		public CommonButton() : base()
		{
			StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(255, 235, 235, 235);
			StateCommon.Back.Color2 = StateCommon.Back.Color1;
			StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(255, 224, 224, 224);
			StateCommon.Border.Color2 = StateCommon.Border.Color1;
			StateCommon.Border.Width = 2;
			StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(90, 90, 90);
			StateCommon.Content.ShortText.Color2 = StateCommon.Content.ShortText.Color1;
			StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(90, 90, 90);
            StateNormal.Content.ShortText.Color2 = StateNormal.Content.ShortText.Color1; 
            StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            StateTracking.Border.Width = 2;
            StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
		}
	}
}
