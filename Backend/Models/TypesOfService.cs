using System;
using System.Collections.Generic;

#nullable disable

namespace Couriers_GUI.Models
{
    public partial class TypesOfService
    {
        public TypesOfService()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
