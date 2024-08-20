using restoranas3.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace restoranas3
{
    public class TableList
    {
        public List<Table> TablesAll { get; set; }

        public TableList()
        {
            TablesAll = new List<Table>
            {
                new Table(1, 9, false),
                new Table(2, 2, false),
                new Table(3, 4, false),
                new Table(4, 9, false),
                new Table(5, 6, false),
                new Table(6, 2, false),
                new Table(7, 4, false)
            };



            ///////////////kodel neseivina failu?

            //string filePath = @"C:\cSharpFiles\Tables.csv";

            //try
            //{
            //    using (StreamWriter writer = new StreamWriter(filePath))
            //    {
            //        writer.WriteLine("TableId,NumberOfSeats,IsReserved");
            //        foreach (var table in TablesAll)
            //        {
            //            writer.WriteLine($"{table.TableNumber},{table.Seats},{table.IsReserved}");
            //        }
            //    }
            //    Console.WriteLine("File created successfully at: " + filePath);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}
        }
    }
}