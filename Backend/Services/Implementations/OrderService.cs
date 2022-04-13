using Couriers_GUI.Backend.Services.ServiceModels;
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
			=> this.data
				.Orders
				.Select(o => new OrderDetailsServiceModel(){
					Id = o.Id,
					OrderDate = o.OrderDate,
					ReceiveDate = o.ReceiveDate,
					Total = o.Total.ToString("N2") + " лв.",
					AddressId = o.AddressId,
					ClientId = o.ClientId,
					CourierId = o.CourierId,
					DispatcherId = o.DispatcherId,
					RecipientId = o.RecipientId,
					TypeId = o.TypeId
				})
				.ToList();

		public void Create(DateTime orderDate, DateTime receiveDate, decimal total, int addressId, int typeId, int DispatcherId, int ClientId, int CourierId, int RecipientId)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddOrder {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", orderDate, receiveDate, total, addressId, typeId, DispatcherId, ClientId, CourierId, RecipientId);

		public void Edit(int id, DateTime orderDate, DateTime receiveDate, decimal total, int addressId, int typeId, int DispatcherId, int ClientId, int CourierId, int RecipientId)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateOrder {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", id, orderDate, receiveDate, total, addressId, typeId, DispatcherId, ClientId, CourierId, RecipientId);

		public bool Exists(int id)
			=> this.data
				.Orders
				.Any(a => a.Id == id);

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_orders {0}", id);
	}
}
