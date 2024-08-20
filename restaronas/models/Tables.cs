using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaronas.models
{
    public class Tables
    {
        public int TableNumber { get; set; }
        public int Seats { get; set; }
        public bool IsReserved { get; set; }
        public Tables(int table, int seats)
        {
            TableNumber = table;
            Seats = seats;  
            IsReserved = false;
        }
    }
}
