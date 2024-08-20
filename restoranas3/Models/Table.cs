using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoranas3.Models
{
    public class Table
    {
        public int TableNumber { get; set; }
        public int Seats { get; set; }
        public bool IsReserved { get; set; }

        public Table(int table, int seats, bool isReserved)
        {
            TableNumber = table;
            Seats = seats;
            IsReserved = isReserved;
        }
    }
}