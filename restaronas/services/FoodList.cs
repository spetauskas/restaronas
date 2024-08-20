using restaronas.models;
using System;
using System.Collections.Generic;
using System.IO;


namespace FoodCsvWriter
{
    public class FoodList
    {

        public List<Bevarages> Foods { get; set; }

        public FoodList()
        {
            
            Foods = new List<Bevarages>
            {
                new Bevarages("Apple", 1.20m),
                new Bevarages("Banana", 0.80m),
                new Bevarages("Orange", 1.00m),
                new Bevarages("Strawberry", 2.50m),
                new Bevarages("Blueberry", 3.00m),
                new Bevarages("Pineapple", 4.00m),
                new Bevarages("Mango", 1.50m),
                new Bevarages("Grapes", 2.20m),
                new Bevarages("Watermelon", 5.00m),
                new Bevarages("Peach", 1.75m)
            };
        }


    }
    public class SaveFoodToFile
    {

        
        private readonly string _filePath;
        private readonly List<Bevarages> _foods;

        public SaveFoodToFile(FoodList foodList)
        {
            _filePath = "C:\\cSharpFiles\\Food.csv";
            _foods = foodList.Foods;
            Save();
        }

        private void Save()
        {
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                writer.WriteLine("Name,Price");

                foreach (var food in _foods)
                {
                    writer.WriteLine($"{food.Name},{food.Price}");
                }
            }
        }

    }

    

        

}
