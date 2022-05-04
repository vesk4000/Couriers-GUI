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
	public class CourierService : ITableService<CourierServiceModel>
	{
		private readonly CouriersDBContext data;

		public CourierService()
		{
			this.data = new CouriersDBContext();
		}

		public CourierService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<CourierServiceModel> All()
			=> this.data
				.Couriers
				.Select(c => new CourierServiceModel(){
					Id = c.Id,
					Name = c.Name,
					PhoneNumber = c.PhoneNumber
				})
				.ToList();

		public IEnumerable<string> AllString()
			=> this.data
				.Couriers
				.Select(c => $"{c.Id,-3} | {c.Name,-15} | {c.PhoneNumber}")
				.ToList();

		//TODO: create with service models

		public void Create(CourierServiceModel courier)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddCourier {0}, {1}", courier.Name, courier.PhoneNumber);

		//TODO: edit with service models

		public void Edit(CourierServiceModel courier)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateCourier {0}, {1}, {2}", courier.Id, courier.Name, courier.PhoneNumber);

		public bool Exists(int id)
			=> this.data
				.Couriers
				.Any(a => a.Id == id);

        public IEnumerable<CourierServiceModel> GetByContainingText(string containText)
			=> All()
				.Where(c => (c.Id + " " + c.Name + " " + c.PhoneNumber).Contains(containText))
				.ToList();

		public IEnumerable<string> GetByContainingTextString(string containText)
			=> GetByContainingText(containText)
				.Select(c => $"{c.Id,-3} | {c.Name,-15} | {c.PhoneNumber}");

		public IEnumerable<CourierServiceModel> GetById(int id)
			=> All()
				.Where(o => o.Id == id);

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_couriers {0}", id);

        public bool Validate(CourierServiceModel courier)
        {
			if (courier.Name.Length > 50
				|| courier.Name == string.Empty
				|| courier.PhoneNumber == ""
				|| (courier.PhoneNumber.Length != 10 && courier.PhoneNumber[0] == '0')
				|| !CheckPhoneNumberFunc.CheckPhoneNumber(courier.PhoneNumber))
				return false;
			return true;
		}
    }
}
