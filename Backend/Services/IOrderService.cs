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

        IEnumerable<Order> All();
    }
}

/*
 public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public decimal Total { get; set; }
        public int? AddressId { get; set; }
        public int? TypeId { get; set; }
        public int? DispatcherId { get; set; }
        public int? ClientId { get; set; }
        public int? CourierId { get; set; }
        public int? RecipientId { get; set; }
 */
