using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerApp.Models.Domain
{
    public class Order
    {
        public string FullName { get; set; } = String.Empty;

        public string Address { get; set; } = String.Empty;

        public bool IsDelivered { get; set; } = false;

        public IEnumerable<Burger> Burgers { get; set; }

        public string Location { get; set; } = String.Empty;
    }
}
