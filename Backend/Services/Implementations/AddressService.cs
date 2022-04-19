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
    public class AddressService : IAddressService
    {
        private readonly CouriersDBContext data;

        public AddressService(CouriersDBContext data)
        {
            this.data = data;
        }

        public IEnumerable<AddressDetailsServiceModel> All()
            => this.data
                .Addresses
                .Select(a => new AddressDetailsServiceModel(){
                    Id = a.Id,
                    AddressText = a.AddressText
                })
                .ToList();

        public void Create(AddressCreateServiceModel address)
            => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddAddress {0}", address.AddressText);

        public void Create(string addressText)
            => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_AddAddress {0}", addressText);
        
        public void Edit(AddressEditServiceModel address)
            => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateAddress {0}, {1}", address.Id, address.AddressText);

        public void Edit(int id, string addressText)
            => this.data.Database.ExecuteSqlRaw("EXEC dbo.udp_UpdateAddress {0}, {1}", id, addressText);

        public bool Exists(int id)
            => this.data
                .Addresses
                .Any(a => a.Id == id);

        public IEnumerable<AddressDetailsServiceModel> GetByContainingText(string containText)
            => All()
                .Where(a => (a.Id + " " + a.AddressText).Contains(containText));

        public void Remove(int id)
            => data.Database.ExecuteSqlRaw("EXEC dbo.delete_addresses {0}", id);
    }
}
