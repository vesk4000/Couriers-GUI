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
	public class CourierService : ICourierService
	{
		private readonly CouriersDBContext data;

		public CourierService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<CourierDetailsServiceModel> All()
			=> this.data
				.Couriers
				.Select(c => new CourierDetailsServiceModel(){
					Id = c.Id,
					Name = c.Name,
					PhoneNumber = c.PhoneNumber
				})
				.ToList();

		//TODO: create with service models

		public void Create(string name, string phoneNumber)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddCourier {0}, {1}", name, phoneNumber);

		//TODO: edit with service models

		public void Edit(int id, string name, string phoneNumber)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateCourier {0}, {1}, {2}", id, name, phoneNumber);

		public bool Exists(int id)
			=> this.data
				.Couriers
				.Any(a => a.Id == id);

        public IEnumerable<CourierDetailsServiceModel> GetByContainingText(string containText)
			=> All()
				.Where(c => (c.Id + " " + c.Name + " " + c.PhoneNumber).Contains(containText));

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_couriers {0}", id);
	}
}
