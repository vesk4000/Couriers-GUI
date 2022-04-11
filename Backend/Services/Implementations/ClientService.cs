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
	public class ClientService : IClientService
	{
		private readonly CouriersDBContext data;

		public ClientService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<Client> All()
			=> this.data
				.Clients
				.ToList();

		//TODO
		//public void Create(ClientCreateServiceModel client)
		//    => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddClient {0}", client.Name, client.PhoneNumber);

		public void Create(string name, string phoneNumber)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddClient {0}, {1}", name, phoneNumber);

		//TODO
		//public void Edit(ClientEditServiceModel client)
		//	=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateClient {0}, {1}", client.Id, client.Name, client.PhoneNumber);

		public void Edit(int id, string name, string phoneNumber)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateClient {0}, {1}, {2}", id, name, phoneNumber);

		public bool Exists(int id)
			=> this.data
				.Clients
				.Any(a => a.Id == id);

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_clients {0}", id);
	}
}
