using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services
{
    interface ICourierService
    {
        void Create(Courier courier);

        void Edit(Courier courier);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<Courier> All();
    }
}
