using System;
using System.Collections.Generic;

#nullable disable

namespace Couriers_GUI.Models
{
    public partial class Address
    {
        public Address()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string AddressText { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
