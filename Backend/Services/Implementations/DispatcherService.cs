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
	public class DispatcherService : ITableService<DispatcherServiceModel, DispatcherServiceModel>
	{
		private readonly CouriersDBContext data;

		public DispatcherService()
		{
			this.data = new CouriersDBContext();
		}

		public DispatcherService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<DispatcherServiceModel> All()
			=> this.data
				.Dispatchers
				.Select(d => new DispatcherServiceModel(){
					Id = d.Id,
					Name = d.Name,
					PhoneNumber = d.PhoneNumber
				})
				.ToList();

		//TODO: Create with service models

		public void Create(DispatcherServiceModel dispatcher)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddDispatcher {0}, {1}", dispatcher.Name, dispatcher.PhoneNumber);

		//TODO: Edit with service models

		public void Edit(DispatcherServiceModel dispatcher)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateDispatcher {0}, {1}, {2}", dispatcher.Id, dispatcher.Name, dispatcher.PhoneNumber);

		public bool Exists(int id)
			=> this.data
				.Dispatchers
				.Any(a => a.Id == id);

		public IEnumerable<DispatcherServiceModel> GetByContainingText(string containText)
			=> All()
				.Where(d => (d.Id + " " + d.Name + " " + d.PhoneNumber).Contains(containText))
				.ToList();

        public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_dispatchers {0}", id);
	}
}
