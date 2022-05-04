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
    public class RecipientService : ITableService<RecipientServiceModel>
    {
        private readonly CouriersDBContext data;

        public RecipientService()
        {
            this.data = new CouriersDBContext();
        }

        public RecipientService(CouriersDBContext data)
        {
            this.data = data;
        }

        public IEnumerable<RecipientServiceModel> All()
            => this.data
                .Recipients
                .Select(r => new RecipientServiceModel(){
                    Id = r.Id,
                    Name = r.Name
                })
                .ToList();

        public IEnumerable<string> AllString()
            => this.data
                .Recipients
                .Select(r => $"{r.Id,-3} | {r.Name}")
                .ToList();

        public void Create(RecipientServiceModel recipient)
            => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddRecipient {0}", recipient.Name);

        public void Edit(RecipientServiceModel recipient)
            => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateRecipient {0}, {1}", recipient.Id, recipient.Name);

        public bool Exists(int id)
            => this.data
                .Recipients
                .Any(a => a.Id == id);

        public IEnumerable<RecipientServiceModel> GetByContainingText(string containText)
            => All()
                .Where(r => (r.Id + " " + r.Name).Contains(containText))
                .ToList();

        public IEnumerable<RecipientServiceModel> GetById(int id)
            => All()
                .Where(r => r.Id == id);

        public IEnumerable<string> GetByContainingTextString(string containText)
            => GetByContainingText(containText)
                .Select(r => $"{r.Id,-3} | {r.Name}");

        public void Remove(int id)
            => data.Database.ExecuteSqlRaw("EXEC dbo.delete_recipients {0}", id);

        public bool Validate(RecipientServiceModel recipient)
        {
            if (recipient.Name.Length > 50
                   || recipient.Name == string.Empty)
                return false;
            return true;
        }
    }
}
