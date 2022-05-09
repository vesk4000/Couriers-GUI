using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Couriers_GUI.UserInterface.Components;
using System.Windows.Forms;

namespace Couriers_GUI.UserInterface.Pages
{
	public class AboutPage : StackPanel
	{
		public AboutPage()
		{
			AddHeader("About");
			var label = new CommonLabel();
			label.Text =
@"Manage delivery orders, clients, couriers, recipients, addresses and more,
all from a single, convinient place. Couriers GUI is an app, built on top
of the original Couriers, that allows anyone to easily manage a complex
database using a seamless and effective User Interface.

The app was made as a final senior high school Computer Science project.
The goal was to make a User Interface that can be used with our previous
Microsoft SQL Server database project Couriers. The User Interface is
written in C# using WinForms and the Krypton Toolkit.

The goal of Couriers GUI help a hypothetical delivery company manage their
operations using an easy and accessible app. The project facilitates the
storing and managing of orders and all of the information associated with
that, as well as filtering and searching for information within the database.

More information about the project can be found at the GitHub repository:
github.com/vesk4000/Couriers-GUI

Credits:
Vesselin Mitev
User Interface
github.com/vesk4000

Hristo Denev
Backend
github.com/icyDenev
www.linkedin.com/in/hristo-denev-03b282189/

Rumen Karchev
User Interface
github.com/GreenUncle

License:
Copyright (c) 2022 Veselin Mitev, Hristo Denev, Rumen Karchev

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

The Software is provided ""as is"", without warranty of any kind, express or
implied, including but not limited to the warranties of marchantability,
fitness for a particular purpose and noninfringement. In no event shall the
authors or copyright holders be liable for any claim, damagaes or other
liability, whether in an action of contract, tort or otherwise, arising from,
out of or in connection with the software or the use or other dealings in the
software.";
			//label.AutoSize = true;
			// = System.Drawing.Color.Red;

			label.Anchor = AnchorStyles.Top;
			AddControl(label);
		}
	}
}
