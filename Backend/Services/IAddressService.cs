using Couriers_GUI.Backend.Services.ServiceModels;
using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services
{
    public interface IAddressService
    {
        void Create(AddressCreateServiceModel address);

        void Edit(AddressEditServiceModel address);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<Address> All();
    }
}
