using restoranas3.Models;
using restoranas3.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restoranas3.Repository
{
    internal class FoodRepository : IFoodRepository
    {
        private readonly string _filePath;
        private readonly List<FoodList> _food;

        public FoodRepository(string filePath)
        {
            _filePath = filePath;
            _food = LoadFromFile();
        }

        private List<FoodList> LoadFromFile()
        {
            var lines = File.ReadAllLines(_filePath);
            List<FoodList> foodLists = new List<FoodList>();
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    decimal price = decimal.Parse(parts[1]);
                    foodLists.Add(new FoodList(name, price));
                }
            }
            return foodLists;

        }
        public List<FoodList> GetAll()
        {
            return _food;
        }
    }
}
