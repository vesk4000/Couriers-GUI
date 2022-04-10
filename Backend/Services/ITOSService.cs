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
        void Create(TypesOfService tos);

        void Edit(TypesOfService tos);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<TypesOfService> All();
    }
}
