using System;
using System.Collections.Generic;

#nullable disable

namespace Couriers_GUI.Models
{
    public partial class Order
    {
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

        public virtual Address Address { get; set; }
        public virtual Client Client { get; set; }
        public virtual Courier Courier { get; set; }
        public virtual Dispatcher Dispatcher { get; set; }
        public virtual Recipient Recipient { get; set; }
        public virtual TypesOfService Type { get; set; }
    }
}
