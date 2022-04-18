﻿using Couriers_GUI.Backend.Services.ServiceModels;
using Couriers_GUI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services.Implementations
{
	public class OrderService : IOrderService
	{
		private readonly CouriersDBContext data;

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
						  Recipient = $"{o.Address.Id, -3} | {o.Recipient.Name, -15}",
						  Type = $"{o.Type.Id, -3} | {o.Type.Type, -15}"
					  })
					  .ToList();
		}

		public void Create(DateTime orderDate, DateTime receiveDate, decimal total, int addressId, int typeId, int DispatcherId, int ClientId, int CourierId, int RecipientId)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddOrder {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", orderDate, receiveDate, total, addressId, typeId, DispatcherId, ClientId, CourierId, RecipientId);

		public void Edit(int id, DateTime orderDate, DateTime receiveDate, decimal total, int addressId, int typeId, int DispatcherId, int ClientId, int CourierId, int RecipientId)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateOrder {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", id, orderDate, receiveDate, total, addressId, typeId, DispatcherId, ClientId, CourierId, RecipientId);

		public bool Exists(int id)
			=> this.data
				.Orders
				.Any(a => a.Id == id);

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
					(o.Id + " " + o.Address + " " + o.Client + " " + o.Courier + " " + o.Dispatcher + " " + o.Recipient + " " + o.Type).ToString().Contains(containText)
					&& (o.ReceiveDate >= startReceiveDate && o.ReceiveDate <= endReceiveDate)
					&& (o.OrderDate >= startOrderDate && o.OrderDate <= endOrderDate)
					&& (decimal.Parse(o.Total.Split(' ')[0]) >= minTotal && decimal.Parse(o.Total.Split(' ')[0]) <= maxTotal))
					.ToList();
		}

        public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_orders {0}", id);
	}
}
