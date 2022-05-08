using Couriers_GUI.Backend.Services.Interfaces;
using Couriers_GUI.Backend.Services.ServiceModels;
using Couriers_GUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couriers_GUI.Backend.Services.Implementations
{
	public class OrderService : ITableService<OrderDetailsServiceModel>
	{
		private readonly CouriersDBContext data;

		public OrderService()
		{
			this.data = new CouriersDBContext();
		}

		public OrderService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<OrderDetailsServiceModel> All()
		{
			var orders = this.data
							.Orders
							.Include(o => o.Address)
							.Include(o => o.Client)
							.Include(o => o.Courier)
							.Include(o => o.Dispatcher)
							.Include(o => o.Recipient)
							.Include(o => o.Type);

			return orders
					  .Select(o => new OrderDetailsServiceModel()
					  {
						  Id = o.Id,
						  OrderDate = o.OrderDate,
						  ReceiveDate = o.ReceiveDate,
						  Total = o.Total.ToString("N2") + " лв.",
						  Address = $"{o.Address.Id, -3} | {o.Address.AddressText, -15}",
						  Client = $"{o.Client.Id, -3} | {o.Client.Name, -15} | {o.Client.PhoneNumber}",
						  Courier = $"{o.Courier.Id, -3} | {o.Courier.Name, -15} | {o.Courier.PhoneNumber}",
						  Dispatcher = $"{o.Dispatcher.Id, -3} | {o.Dispatcher.Name, -15} | {o.Dispatcher.PhoneNumber}",
						  Recipient = $"{o.Recipient.Id, -3} | {o.Recipient.Name, -15}",
						  Type = $"{o.Type.Id, -3} | {o.Type.Type, -15}"
					  })
					  .ToList();
		}

		public IEnumerable<string> AllString()
		{
			var orders = this.data
							.Orders
							.Include(o => o.Address)
							.Include(o => o.Client)
							.Include(o => o.Courier)
							.Include(o => o.Dispatcher)
							.Include(o => o.Recipient)
							.Include(o => o.Type);

			return orders
					  .Select(o =>
						  o.Id + " " + 
						  o.OrderDate + " " +
						  o.ReceiveDate + " " +
						  o.Total.ToString("N2") + " лв." + " " +
						  $"{o.Address.Id,-3} | {o.Address.AddressText,-15}" + " " +
						  $"{o.Client.Id,-3} | {o.Client.Name,-15} | {o.Client.PhoneNumber}" + " " +
						  $"{o.Courier.Id,-3} | {o.Courier.Name,-15} | {o.Courier.PhoneNumber}" + " " +
						  $"{o.Dispatcher.Id,-3} | {o.Dispatcher.Name,-15} | {o.Dispatcher.PhoneNumber}" + " " +
						  $"{o.Recipient.Id,-3} | {o.Recipient.Name,-15}" + " " +
						  $"{o.Type.Id,-3} | {o.Type.Type,-15}")
					  .ToList();
		}

		public bool Validate(OrderDetailsServiceModel order)
		{
			AddressService address = new AddressService(data);
			ClientService client = new ClientService(data);
			CourierService courier = new CourierService(data);
			DispatcherService dispatcher = new DispatcherService(data);
			RecipientService recipient = new RecipientService(data);
			TOSService type = new TOSService(data);

			decimal total;

			string totalStr = order.Total.Split(' ')[0];
			string addressStr = order.Address.Split('|')[0].Trim();
			string clientStr = order.Client.Split('|')[0].Trim();
			string courierStr = order.Courier.Split('|')[0].Trim();
			string dispatcherStr = order.Dispatcher.Split('|')[0].Trim();
			string recipientStr = order.Recipient.Split('|')[0].Trim();
			string typeStr = order.Type.Split('|')[0].Trim();

			try
			{
				if (!address.Exists(int.Parse(addressStr))
					|| !client.Exists(int.Parse(clientStr))
					|| !courier.Exists(int.Parse(courierStr))
					|| !dispatcher.Exists(int.Parse(dispatcherStr))
					|| !recipient.Exists(int.Parse(recipientStr))
					|| !type.Exists(int.Parse(typeStr))
					|| !decimal.TryParse(totalStr, out total))
					return false;
				//else if (data.Orders.Where(o => order.OrderDate == o.OrderDate
				//	&& order.ReceiveDate == o.ReceiveDate
				//	&& totalStr == o.Total.ToString("N2")
				//	&& addressStr == o.AddressId.ToString()
				//	&& clientStr == o.ClientId.ToString()
				//	&& courierStr == o.CourierId.ToString()
				//	&& dispatcherStr == o.DispatcherId.ToString()
				//	&& recipientStr == o.RecipientId.ToString()
				//	&& typeStr == o.TypeId.ToString()).Count() != 0)
				//	return false;
			}
			catch
			{
				return false;
			}

			return true;
		}

		public void Create(OrderDetailsServiceModel order)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddOrder {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", order.OrderDate, order.ReceiveDate, decimal.Parse(order.Total.Split(' ')[0]), order.Address.Split('|')[0].Trim(), order.Type.Split('|')[0].Trim(), order.Dispatcher.Split('|')[0].Trim(), order.Client.Split('|')[0].Trim(), order.Courier.Split('|')[0].Trim(), order.Recipient.Split('|')[0].Trim());

		public void Edit(OrderDetailsServiceModel order)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateOrder {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", order.Id, order.OrderDate, order.ReceiveDate, decimal.Parse(order.Total.Split(' ')[0]), order.Address.Split('|')[0].Trim(), order.Type.Split('|')[0].Trim(), order.Dispatcher.Split('|')[0].Trim(), order.Client.Split('|')[0].Trim(), order.Courier.Split('|')[0].Trim(), order.Recipient.Split('|')[0].Trim());

		public bool Exists(int id)
			=> this.data
				.Orders
				.Any(a => a.Id == id);

		public IEnumerable<OrderDetailsServiceModel> GetByContainingText(string containText)
			=>	All()
					.Where(o =>
					(o.Id + " " + o.Address + " " + o.Client + " " + o.Courier + " " + o.Dispatcher + " " + o.Recipient + " " + o.Type).Contains(containText))
					.ToList();

		public IEnumerable<string> GetByContainingTextString(string containText)
		{
			var orders = this.data
							.Orders
							.Include(o => o.Address)
							.Include(o => o.Client)
							.Include(o => o.Courier)
							.Include(o => o.Dispatcher)
							.Include(o => o.Recipient)
							.Include(o => o.Type);

			return orders
					  .Where(o =>
					  (o.Id + " " + o.Address + " " + o.Client + " " + o.Courier + " " + o.Dispatcher + " " + o.Recipient + " " + o.Type).Contains(containText))
					  .Select(o =>
							o.Id + " " +
							o.OrderDate + " " +
							o.ReceiveDate + " " +
							o.Total.ToString("N2") + " лв." + " " +
							$"{o.Address.Id,-3} | {o.Address.AddressText,-15}" + " " +
							$"{o.Client.Id,-3} | {o.Client.Name,-15} | {o.Client.PhoneNumber}" + " " +
							$"{o.Courier.Id,-3} | {o.Courier.Name,-15} | {o.Courier.PhoneNumber}" + " " +
							$"{o.Dispatcher.Id,-3} | {o.Dispatcher.Name,-15} | {o.Dispatcher.PhoneNumber}" + " " +
							$"{o.Recipient.Id,-3} | {o.Recipient.Name,-15}" + " " +
							$"{o.Type.Id,-3} | {o.Type.Type,-15}")
					  .ToList();
		}


		public IEnumerable<OrderDetailsServiceModel> GetById(int id)
			=> All()
				.Where(o => o.Id == id);

		public IEnumerable<OrderDetailsServiceModel> GetByFilters(string containText, DateTime startOrderDate = default, DateTime endOrderDate = default, DateTime startReceiveDate = default, DateTime endReceiveDate = default, decimal minTotal = 0, decimal maxTotal = int.MaxValue)
		{
			if (startOrderDate == default)
				startOrderDate = DateTime.MinValue;

			if (endOrderDate == default)
				endOrderDate = DateTime.MaxValue;

			if (startReceiveDate == default)
				startReceiveDate = DateTime.MinValue;

			if (endReceiveDate == default)
				endReceiveDate = DateTime.MaxValue;

			return All()
					.Where(o =>
					(o.Id + " " + o.Address + " " + o.Client + " " + o.Courier + " " + o.Dispatcher + " " + o.Recipient + " " + o.Type).Contains(containText)
					&& (o.ReceiveDate >= startReceiveDate && o.ReceiveDate <= endReceiveDate)
					&& (o.OrderDate >= startOrderDate && o.OrderDate <= endOrderDate)
					&& (decimal.Parse(o.Total.Split(' ')[0]) >= minTotal && decimal.Parse(o.Total.Split(' ')[0]) <= maxTotal))
					.ToList();
		}

		public IEnumerable<string> GetByFiltersString(string containText, DateTime startOrderDate = default, DateTime endOrderDate = default, DateTime startReceiveDate = default, DateTime endReceiveDate = default, decimal minTotal = 0, decimal maxTotal = int.MaxValue)
		{
			if (startOrderDate == default)
				startOrderDate = DateTime.MinValue;

			if (endOrderDate == default)
				endOrderDate = DateTime.MaxValue;

			if (startReceiveDate == default)
				startReceiveDate = DateTime.MinValue;

			if (endReceiveDate == default)
				endReceiveDate = DateTime.MaxValue;

			var orders = this.data
							.Orders
							.Include(o => o.Address)
							.Include(o => o.Client)
							.Include(o => o.Courier)
							.Include(o => o.Dispatcher)
							.Include(o => o.Recipient)
							.Include(o => o.Type);

			return orders
					.Where(o =>
					(o.Id + " " + o.Address + " " + o.Client + " " + o.Courier + " " + o.Dispatcher + " " + o.Recipient + " " + o.Type).Contains(containText)
					&& (o.ReceiveDate >= startReceiveDate && o.ReceiveDate <= endReceiveDate)
					&& (o.OrderDate >= startOrderDate && o.OrderDate <= endOrderDate)
					&& o.Total >= minTotal && o.Total <= maxTotal)
					.Select(o =>
							o.Id + " " +
							o.OrderDate + " " +
							o.ReceiveDate + " " +
							o.Total.ToString("N2") + " лв." + " " +
							$"{o.Address.Id,-3} | {o.Address.AddressText,-15}" + " " +
							$"{o.Client.Id,-3} | {o.Client.Name,-15} | {o.Client.PhoneNumber}" + " " +
							$"{o.Courier.Id,-3} | {o.Courier.Name,-15} | {o.Courier.PhoneNumber}" + " " +
							$"{o.Dispatcher.Id,-3} | {o.Dispatcher.Name,-15} | {o.Dispatcher.PhoneNumber}" + " " +
							$"{o.Recipient.Id,-3} | {o.Recipient.Name,-15}" + " " +
							$"{o.Type.Id,-3} | {o.Type.Type,-15}")
					.ToList();
		}

		public List<OrderDetailsServiceModel> Filter(OrderFilterServiceModel filterModel)
		{
			List<OrderDetailsServiceModel> ans = All().ToList();

			ans = ans.Where(o => o.OrderDate >= filterModel.OrderDateFrom && o.OrderDate <= filterModel.OrderDateTo).ToList();
			ans = ans.Where(o => o.ReceiveDate >= filterModel.ReceiveDateFrom && o.ReceiveDate <= filterModel.ReceiveDateTo).ToList();
			int a = 0;
			float f = 0;
			if(int.TryParse(filterModel.TotalFrom, out a) && int.TryParse(filterModel.TotalTo, out a))
				ans = ans.Where(o => float.TryParse(o.Total.Split()[0], out f) && float.Parse(o.Total.Split()[0]) >= int.Parse(filterModel.TotalFrom) && float.Parse(o.Total.Split()[0]) <= int.Parse(filterModel.TotalTo)).ToList();

			var addresses = new AddressService().GetByContainingText(filterModel.Address);
			ans = ans.Where(o => addresses.Any(a => o.Address == a.ToString())).ToList();

			var clients = new ClientService().GetByContainingText(filterModel.Client);
			ans = ans.Where(o => clients.Any(c => o.Client == c.ToString())).ToList();

			var couriers = new CourierService().GetByContainingText(filterModel.Courier);
			ans = ans.Where(o => couriers.Any(c => o.Courier == c.ToString())).ToList();

			var dispatchers = new DispatcherService().GetByContainingText(filterModel.Dispatcher);
			ans = ans.Where(o => dispatchers.Any(d => o.Dispatcher == d.ToString())).ToList();

			var recipients = new RecipientService().GetByContainingText(filterModel.Recipient);
			ans = ans.Where(o => recipients.Any(r => o.Recipient == r.ToString())).ToList();

			var types = new TOSService().GetByContainingText(filterModel.Type);
			ans = ans.Where(o => types.Any(t => o.Type == t.ToString())).ToList();

			return ans;
		}

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_orders {0}", id);
	}
}
