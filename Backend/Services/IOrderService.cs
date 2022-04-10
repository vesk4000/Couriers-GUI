using Couriers_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriers_GUI.Backend.Services
{
    interface IOrderService
    {
        void Create(Order order);

        void Edit(Order order);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<Order> All();
    }
}
