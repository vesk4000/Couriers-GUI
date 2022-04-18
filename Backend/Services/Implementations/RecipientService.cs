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
    public class RecipientService : IRecipientService
    {
        private readonly CouriersDBContext data;

        public RecipientService(CouriersDBContext data)
        {
            this.data = data;
        }

        public IEnumerable<RecipientDetailsServiceModel> All()
            => this.data
                .Recipients
                .Select(r => new RecipientDetailsServiceModel(){
                    Id = r.Id,
                    Name = r.Name
                })
                .ToList();

        public void Create(string name)
            => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddRecipient {0}", name);

        public void Edit(int id, string name)
            => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateRecipient {0}, {1}", id, name);

        public bool Exists(int id)
            => this.data
                .Recipients
                .Any(a => a.Id == id);

        public IEnumerable<RecipientDetailsServiceModel> GetByContainingText(string containText)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
            => data.Database.ExecuteSqlRaw("EXEC dbo.delete_recipients {0}", id);
    }
}
