using FoodCsvWriter;
using restaronas.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaronas.services
{
    public class DrinksList
    {
        public List<Bevarages> Drinks { get; set; }
        public DrinksList()
        {
            Drinks = new List<Bevarages>
            {
                new Bevarages("Cola", 1.50m),
                new Bevarages("Orange Juice", 2.00m),
                new Bevarages("Lemonade", 1.75m),
                new Bevarages("Iced Tea", 1.25m),
                new Bevarages("Water", 1.00m)

            };
        }
        public class SaveFoodToFiledrinks
        {


            private readonly string _filePath;
            private readonly List<Bevarages> _drinks;

            public SaveFoodToFiledrinks(DrinksList drinklist)
            {
                _filePath = "C:\\cSharpFiles\\Drinks.csv";
                _drinks = drinklist.Drinks;
                Save();
            }

            private void Save()
            {
                using (StreamWriter writer = new StreamWriter(_filePath))
                {
                    writer.WriteLine("Name,Price");

                    foreach (var drink in _drinks)
                    {
                        writer.WriteLine($"{drink.Name},{drink.Price}");
                    }
                }
            }
        }
    }
}
