using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoranas3.Models
{
    public class Order
    {
        public Order(int orderId, decimal totalSum, int quantity)
        {

            OrderId = orderId;         
            TotalSum = totalSum;
            //DateTime = dateTime;
            Quantity = quantity;
        }


        public int OrderId { get; set; } = 0;       
        public decimal TotalSum { get; set; }
        //public DateTime DateTime { get; set; }
        public int Quantity { get; set; }




    }
}
