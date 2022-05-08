using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services.ServiceModels
{
	public class OrderFilterServiceModel
	{
		public OrderFilterServiceModel() { }

		public OrderFilterServiceModel(DateTime orderDateFrom, DateTime orderDateTo, DateTime receiveDateFrom, DateTime receiveDateTo, string totalFrom, string totalTo, string address, string client, string courier, string dispatcher, string recipient, string type)
		{
			OrderDateFrom = orderDateFrom;
			OrderDateTo = orderDateTo;
			ReceiveDateFrom = receiveDateFrom; 
			ReceiveDateTo = receiveDateTo;

			TotalFrom = totalFrom;
			TotalTo = totalTo;

			Address = address;

			Type = type;

			Dispatcher = dispatcher;

			Client = client;

			Courier = courier;

			Recipient = recipient;
		}

		public int Id { get; set; }

		public DateTime OrderDateTo { get; set; }

		public DateTime OrderDateFrom { get; set; }

		public DateTime ReceiveDateFrom { get; set; }

		public DateTime ReceiveDateTo { get; set; }

		public string TotalFrom { get; set; }

		public string TotalTo { get; set; }

		public string Address { get; set; }

		public string Type { get; set; }

		public string Dispatcher { get; set; }

		public string Client { get; set; }

		public string Courier { get; set; }

		public string Recipient { get; set; }
	}
}
