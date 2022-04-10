using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services
{
    interface IDispatcherService
    {
        void Create(Dispatcher dispatcher);

        void Edit(Dispatcher dispatcher);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<Dispatcher> All();
    }
}
