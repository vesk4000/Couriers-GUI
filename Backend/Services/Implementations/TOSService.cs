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
	public class TOSService : ITOSService
	{
		private readonly CouriersDBContext data;

		public TOSService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<TypesOfService> All()
			=> this.data
				.TypesOfServices
				.ToList();

		public void Create(string type)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddTypeOfService {0}", type);

		public void Edit(int id, string type)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateTypeOfService {0}, {1}", id, type);

		public bool Exists(int id)
			=> this.data
				.TypesOfServices
				.Any(a => a.Id == id);

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_types {0}", id);
	}
}
