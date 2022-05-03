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
	public class TOSService : ITableService<TypesOfServiceServiceModel>
	{
		private readonly CouriersDBContext data;

		public TOSService()
		{
			this.data = new CouriersDBContext();
		}

		public TOSService(CouriersDBContext data)
		{
			this.data = data;
		}

		public IEnumerable<TypesOfServiceServiceModel> All()
			=> this.data
				.TypesOfServices
				.Select(t => new TypesOfServiceServiceModel(){
					Id = t.Id,
					Type = t.Type
				})
				.ToList();

		public void Create(TypesOfServiceServiceModel tos)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddTypeOfService {0}", tos.Type);

		public void Edit(TypesOfServiceServiceModel tos)
			=> this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateTypeOfService {0}, {1}", tos.Id, tos.Type);

		public bool Exists(int id)
			=> this.data
				.TypesOfServices
				.Any(a => a.Id == id);

        public IEnumerable<TypesOfServiceServiceModel> GetByContainingText(string containText)
			=> All()
				.Where(t => (t.Id + " " + t.Type).Contains(containText))
				.ToList();

		public void Remove(int id)
			=> data.Database.ExecuteSqlRaw("EXEC dbo.delete_types {0}", id);

        public bool Validate(TypesOfServiceServiceModel type)
        {
			if (type.Type.Length > 50
					  || type.Type == string.Empty)
				return false;
			return true;
		}
    }
}
