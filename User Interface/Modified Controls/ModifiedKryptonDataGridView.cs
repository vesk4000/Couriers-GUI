using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.User_Interface.Modified_Controls
{
	class ModifiedKryptonDataGridView : Krypton.Toolkit.KryptonDataGridView
	{
		public ModifiedKryptonDataGridView()
		{
			//AutoSize = true;
			AllowUserToAddRows = false;
			AllowUserToDeleteRows = false;
			AllowUserToOrderColumns = false;
			AllowUserToResizeColumns = false;
			AllowUserToResizeRows = false;
			AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			//EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			ReadOnly = true;
			RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

			StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(0x00FFFFFF);
			StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(0x00FFFFFF);

			StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(InterfaceSingleton.COLOR_ACCENT);
			StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(InterfaceSingleton.COLOR_ACCENT);
		}
	}
}
