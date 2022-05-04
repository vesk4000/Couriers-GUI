using System;

namespace Couriers_GUI.Backend.Services.ServiceModels
{
    public class OrderDetailsServiceModel
    {
        public OrderDetailsServiceModel() { }

        public OrderDetailsServiceModel(DateTime orderDate, DateTime receiveDate, string total, string address, string client, string courier, string dispatcher, string recipient, string type)
        {
            OrderDate = orderDate;

            ReceiveDate = receiveDate;

            Total = total;

            Address = address;

            Type = type;

            Dispatcher = dispatcher;

            Client = client;

            Courier = courier;

            Recipient = recipient;
        }

        public OrderDetailsServiceModel(int id, DateTime orderDate, DateTime receiveDate, string total, string address, string client, string courier, string dispatcher, string recipient, string type) : this(orderDate, receiveDate, total, address, client, courier, dispatcher, recipient, type)
        {
            Id = id;
        }

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
    }
}