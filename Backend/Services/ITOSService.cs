using Couriers_GUI.Backend.Services.ServiceModels;
using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services
{
    interface ITOSService
    {
        void Create(string type);

        void Edit(int id, string type);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<TypesOfServiceDetailsServiceModel> All();

        IEnumerable<TypesOfServiceDetailsServiceModel> GetByContainingText(string containText);
    }
}
