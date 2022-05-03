using Couriers_GUI.Backend.Services.Interfaces;
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
	public class ClientService : ITableService<ClientServiceModel>
	{
		private readonly CouriersDBContext data;

		public ClientService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<ClientServiceModel> All()
			=> this.data
				.Clients
				.Select(c => new ClientServiceModel(){
					Id = c.Id,
					Name = c.Name,
					PhoneNumber = c.PhoneNumber
				})
				.ToList();

		public IEnumerable<ClientServiceModel> GetByContainingText(string containText)
			=> All()
				.Where(c => (c.Id + " " + c.Name + " " + c.PhoneNumber).Contains(containText))
				.ToList();

		public void Create(ClientServiceModel client)
		    => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddClient {0}", client.Name, client.PhoneNumber);

		public void Edit(ClientServiceModel client)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateClient {0}, {1}", client.Id, client.Name, client.PhoneNumber);

		public bool Exists(int id)
			=> this.data
				.Clients
				.Any(a => a.Id == id);

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_clients {0}", id);
	}
}
