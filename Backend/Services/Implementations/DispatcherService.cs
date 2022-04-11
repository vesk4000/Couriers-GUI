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
	public class DispatcherService : IDispatcherService
	{
		private readonly CouriersDBContext data;

		public DispatcherService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<Dispatcher> All()
			=> this.data
				.Dispatchers
				.ToList();

		//TODO: Create with service models

		public void Create(string name, string phoneNumber)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddDispatcher {0}, {1}", name, phoneNumber);

		//TODO: Edit with service models

		public void Edit(int id, string name, string phoneNumber)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateDispatcher {0}, {1}, {2}", id, name, phoneNumber);

		public bool Exists(int id)
			=> this.data
				.Dispatchers
				.Any(a => a.Id == id);

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_dispatchers {0}", id);
	}
}
