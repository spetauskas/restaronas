using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoranas3.Models
{
    internal class FoodList
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public FoodList(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        
    }
}
