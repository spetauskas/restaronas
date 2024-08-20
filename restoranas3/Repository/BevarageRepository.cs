using restoranas3.Models;
using restoranas3.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoranas3.Repository
{
    internal class BevarageRepository : IBevarageRepository
    {
        private readonly string _filePath; // sitoje klaseej pasiekiami kintamieji
        private readonly List<Bevarage> _drinks; //sitoje klaseej pasiekiami kintamieji

        public BevarageRepository(string filePath) // sukuriamas konstruktorius, kad butu privalomai naudojama info
        {
            _filePath = filePath;
            _drinks = LoadFromFIle();
        }

        private List<Bevarage> LoadFromFIle()
        {
            var lines = File.ReadAllLines(_filePath);
            List<Bevarage> bevarages = new List<Bevarage>();
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    decimal price = decimal.Parse(parts[1]);
                    bevarages.Add(new Bevarage(name, price));
                }
            }
            return bevarages;
        }
        public List<Bevarage> GetAll()
        {
            return _drinks;
        }

    }
}
