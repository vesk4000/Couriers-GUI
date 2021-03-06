using Couriers_GUI.Backend.Functions;
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

		public ClientService()
		{
			this.data = new CouriersDBContext();
		}

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

		public IEnumerable<string> AllString()
			=> All()
			.Select(c => c.ToString())
			.ToList();

		public IEnumerable<ClientServiceModel> GetByContainingText(string containText)
			=> All()
				.Where(c => c.ToString().Contains(containText))
				.ToList();

		public IEnumerable<string> GetByContainingTextString(string containText)
			=> GetByContainingText(containText)
				.Select(c => $"{c.Id,-3} | {c.Name,-15} | {c.PhoneNumber}");

		public IEnumerable<ClientServiceModel> GetById(int id)
			=> All()
				.Where(o => o.Id == id);

		public void Create(ClientServiceModel client)
		    => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddClient {0}, {1}", client.Name, client.PhoneNumber);

		public void Edit(ClientServiceModel client)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateClient {0}, {1}, {2}", client.Id, client.Name, client.PhoneNumber);

		public bool Exists(int id)
			=> this.data
				.Clients
				.Any(a => a.Id == id);

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_clients {0}", id);

        public bool Validate(ClientServiceModel client)
        {
			if (client.Name.Length > 50
				|| client.Name == string.Empty
				|| client.PhoneNumber == ""
				|| !CheckPhoneNumberFunc.CheckPhoneNumber(client.PhoneNumber))
				return false;
			return true;
        }

		public IEnumerable<ClientServiceModel> Filter(string name, string phone)
        {
			IEnumerable<ClientServiceModel> result = All();
			if (name != "") result = result.Where(o => o.Name.Contains(name));
			if (phone != "") result = result.Where(o => o.PhoneNumber.Contains(phone));
			return result;
        }
    }
}
