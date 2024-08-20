using restoranas3.Models;
using restoranas3.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoranas3.Repository
{
    internal class TableRepository : ITableRepository
    {
        private readonly string _filePath;
        private readonly List<Table> _tables;

        public TableRepository(string filePath)
        {
            _filePath = filePath;
            _tables = LoadFromFile();
        }

        private List<Table> LoadFromFile()
        {
            var tables = File.ReadAllLines(_filePath);
            List<Table> result = new List<Table>();
            foreach (var etable in tables)
            {
                var parts = etable.Split(',');
                if (parts.Length == 3)
                {
                    int table = int.Parse(parts[0]);
                    int seats = int.Parse(parts[1]);
                    bool isReserved = bool.Parse(parts[2]);
                    result.Add(new Table(table, seats, isReserved));

                }
            }
            return result;
        }
        public List<Table> GetAll()
        {
            return _tables;
        }
        public Table GetById(int id)
        {
            return _tables.FirstOrDefault(t => t.TableNumber == id);
        }


        public void Update(Table table)
        {
            var tables = GetAll().ToList();
            var existingTable = tables.FirstOrDefault(t => t.TableNumber == table.TableNumber);
            if (existingTable != null)
            {
                existingTable.Seats = table.Seats;
                existingTable.IsReserved = table.IsReserved;
                SaveTablesToFile(tables);
            }
        }

        private void SaveTablesToFile(List<Table> tables)
        {
            var lines = new List<string> { } ;
            lines.AddRange(tables.Select(t => $"{t.TableNumber},{t.Seats},{t.IsReserved}"));
            File.WriteAllLines(_filePath, lines);
        }
    }


}

