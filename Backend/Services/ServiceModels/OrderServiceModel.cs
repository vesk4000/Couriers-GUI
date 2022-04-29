using System;

namespace Couriers_GUI.Backend.Services.ServiceModels
{
    public class OrderServiceModel
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ReceiveDate { get; set; }

        public string Total { get; set; }

        public string Address { get; set; }

        public string Type { get; set; }

        public string Dispatcher { get; set; }

        public string Client { get; set; }

        public string Courier { get; set; }

        public string Recipient { get; set; }

        public int? AddressId { get; set; }

        public int? TypeId { get; set; }

        public int? DispatcherId { get; set; }

        public int? ClientId { get; set; }

        public int? CourierId { get; set; }

        public int? RecipientId { get; set; }
    }
}