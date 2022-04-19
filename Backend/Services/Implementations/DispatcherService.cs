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

		public IEnumerable<DispatcherDetailsServiceModel> All()
			=> this.data
				.Dispatchers
				.Select(d => new DispatcherDetailsServiceModel(){
					Id = d.Id,
					Name = d.Name,
					PhoneNumber = d.PhoneNumber
				})
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

		public IEnumerable<DispatcherDetailsServiceModel> GetByContainingText(string containText)
			=> All()
				.Where(d => (d.Id + " " + d.Name + " " + d.PhoneNumber).Contains(containText))
				.ToList();

        public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_dispatchers {0}", id);
	}
}
