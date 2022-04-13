using System;

namespace Couriers_GUI.Backend.Services.ServiceModels
{
    public class OrderCreateServiceModel
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
    }
}