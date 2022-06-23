using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerApp.Models.Domain
{
    public class Burger
    {
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; }
        public bool IsVegetarian { get; set; } = false;

        public bool IsVegan { get; set; } = false;

        public bool HasFries { get; set; } = false;
    }
}
