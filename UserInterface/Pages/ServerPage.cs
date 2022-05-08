using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couriers_GUI.UserInterface.Components;
using System.Windows.Forms;
using Couriers_GUI.Backend.Services.Implementations;

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
			tableLayoutPanel1.Width = 300;

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
			}
			else
			{
				label.Text = "Offline";
			}
			AddControl(label);

			label = new CommonLabel();
			label.Anchor = AnchorStyles.Left;
			label.Text = "Database...";
			AddControl(label);

			label = new CommonLabel();
			label.Anchor = AnchorStyles.Right;
			if(DBService.ExistsDatabase())
			{
				label.Text = "Exists";
			}
			else
			{
				label.Text = "Doesn't Exist";
			}
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
			}
			else
			{
				label.Text = "Incorrect";
			}
			AddControl(label);


			var button = new CommonButton();
			button.Anchor = AnchorStyles.Right;
			button.Text = "(Re)Create Database";
			button.Click += new EventHandler((sender, e) => { DBService.CreateDB(); DBService.CreateUSPs(); InterfaceSingleton.InvalidateTableViews(); Init(); });
			AddControl(button);
			
			label = new CommonLabel();
			label.Anchor = AnchorStyles.Left;
			label.Text = "Entries...";
			AddControl(label);

			label = new CommonLabel();
			label.Anchor = AnchorStyles.Right;
			label.Text = $"{DBService.RowsCount()}";

			
			button = new CommonButton();
			button.Anchor = AnchorStyles.Right;
			button.Text = "Populate Database";
			button.Click += new EventHandler((sender, e) => { DBService.PopulateDB(); InterfaceSingleton.InvalidateTableViews(); Init(); });
			AddControl(button);
		}
	}
}
