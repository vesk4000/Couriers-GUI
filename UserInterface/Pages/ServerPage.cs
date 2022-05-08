using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couriers_GUI.UserInterface.Components;
using System.Windows.Forms;
using Couriers_GUI.Backend.Services.Implementations;
using System.Drawing;

namespace Couriers_GUI.UserInterface.Pages
{
	public class ServerPage : StackPanel
	{
		public ServerPage()
		{
			Init();
		}

		public void Init()
		{
			tableLayoutPanel1.Controls.Clear();
			tableLayoutPanel1.Width = 400;

			AddHeader("Database Dashboard");

			var label = new CommonLabel();
			label.Text = "Connection to Server...";
			label.Anchor = AnchorStyles.Left;
			AddControl(label);

			label = new CommonLabel();
			label.Anchor = AnchorStyles.Right;
			if (DBService.ExistsConnection())
			{

				label.Text = "Online";
				label.StateCommon.ShortText.Color1 = Color.MediumSpringGreen;
			}
			else
			{
				label.Text = "Offline";
				label.StateCommon.ShortText.Color1 = Color.OrangeRed;
			}
			//label.StateCommon.ShortText.Font = FontStyle.
			label.StateCommon.ShortText.Font = new Font(label.StateCommon.ShortText.Font.Name, label.StateCommon.ShortText.Font.Size, FontStyle.Bold);
			label.StateCommon.ShortText.Color2 = label.StateCommon.ShortText.Color1;
			AddControl(label);

			var button = new CommonButton();
			button.Anchor = AnchorStyles.Right;
			button.Text = "(Re)Connect to Server";
			button.Click += new EventHandler((sender, e) => { InterfaceSingleton.InvalidateTableViews(); Init(); });
			button.AutoSize = true;
			AddControl(button);

			label = new CommonLabel();
			label.Anchor = AnchorStyles.Left;
			label.Text = "Database...";
			AddControl(label);

			label = new CommonLabel();
			label.Anchor = AnchorStyles.Right;
			if(DBService.ExistsDatabase())
			{
				label.Text = "Exists";
				label.StateCommon.ShortText.Color1 = Color.MediumSpringGreen;
			}
			else
			{
				label.Text = "Doesn't Exist";
				label.StateCommon.ShortText.Color1 = Color.OrangeRed;
			}
			label.StateCommon.ShortText.Color2 = label.StateCommon.ShortText.Color1;
			label.StateCommon.ShortText.Font = new Font(label.StateCommon.ShortText.Font.Name, label.StateCommon.ShortText.Font.Size, FontStyle.Bold);
			AddControl(label);

			label = new CommonLabel();
			label.Anchor = AnchorStyles.Left;
			label.Text = "Database Structure...";
			AddControl(label);
			
			label = new CommonLabel();
			label.Anchor = AnchorStyles.Right;
			if(DBService.ExistTables())
			{
				label.Text = "Correct";
				label.StateCommon.ShortText.Color1 = Color.MediumSpringGreen;
			}
			else
			{
				label.Text = "Incorrect";
				label.StateCommon.ShortText.Color1 = Color.OrangeRed;
			}
			label.StateCommon.ShortText.Color2 = label.StateCommon.ShortText.Color1;
			label.StateCommon.ShortText.Font = new Font(label.StateCommon.ShortText.Font.Name, label.StateCommon.ShortText.Font.Size, FontStyle.Bold);
			AddControl(label);


			button = new CommonButton();
			button.Anchor = AnchorStyles.Right;
			button.Text = "(Re)Create Database";
			button.Click += new EventHandler((sender, e) => { DBService.CreateDB(); DBService.CreateAllUPSs(); InterfaceSingleton.InvalidateTableViews(); Init(); });
			button.AutoSize = true;
			AddControl(button);
			
			label = new CommonLabel();
			label.Anchor = AnchorStyles.Left;
			label.Text = "Entries...";
			AddControl(label);

			label = new CommonLabel();
			label.Anchor = AnchorStyles.Right;
			label.Text = $"{DBService.RowsCount()}";
			AddControl(label);

			
			button = new CommonButton();
			button.Anchor = AnchorStyles.Right;
			button.Text = "Populate Database";
			button.Click += new EventHandler((sender, e) => { DBService.PopulateDB(); InterfaceSingleton.InvalidateTableViews(); Init(); });
			button.AutoSize = true;
			AddControl(button);
		}
	}
}
