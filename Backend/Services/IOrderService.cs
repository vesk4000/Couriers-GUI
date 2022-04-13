using Couriers_GUI.Backend.Services.ServiceModels;
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
        void Create(DateTime orderDate, DateTime receiveDate, decimal total, int addressId, int typeId, int DispatcherId, int ClientId, int CourierId, int RecipientId);

        void Edit(int id, DateTime orderDate, DateTime receiveDate, decimal total, int addressId, int typeId, int DispatcherId, int ClientId, int CourierId, int RecipientId);

        void Remove(int id);

        bool Exists(int id);

        IEnumerable<OrderDetailsServiceModel> All();
    }
}
