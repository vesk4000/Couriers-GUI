using System;
using System.Collections.Generic;

#nullable disable

namespace Couriers_GUI.Models
{
    public partial class Recipient
    {
        public Recipient()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
