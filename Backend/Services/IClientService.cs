using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services
{
    interface IClientService
    {
        void Create(Client client);

        void Edit(Client client);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<Client> All();
    }
}
