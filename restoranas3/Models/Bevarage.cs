using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoranas3.Models
{
    public class Bevarage
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Bevarage(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

}

