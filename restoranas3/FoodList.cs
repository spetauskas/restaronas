using restoranas3.Models;
using System;
using System.Collections.Generic;
using System.IO;


namespace restoranas3
{
    public class FoodList
    {
        private string name;
        private decimal price;

        public List<Bevarage> Foods { get; set; }

        public FoodList()
        {

            Foods = new List<Bevarage>
            {
                new Bevarage("Apple", 1.20m),
                new Bevarage("Banana", 0.80m),
                new Bevarage("Orange", 1.00m),
                new Bevarage("Strawberry", 2.50m),
                new Bevarage("Blueberry", 3.00m),
                new Bevarage("Pineapple", 4.00m),
                new Bevarage("Mango", 1.50m),
                new Bevarage("Grapes", 2.20m),
                new Bevarage("Watermelon", 5.00m),
                new Bevarage("Peach", 1.75m)
            };
        }

        public FoodList(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
    //public class SaveFoodToFile // ar as galiu padaryti sita klase, kad irasytu visus failus maista, drinksus, stalus
    //{


    //    private readonly string _filePath;
    //    private readonly List<Bevarages> _foods;

    //    public SaveFoodToFile(FoodList foodList)
    //    {
    //        _filePath = "C:\\cSharpFiles\\Food.csv";
    //        _foods = foodList.Foods;
    //        Save();
    //    }

    //    private void Save()
    //    {
    //        using (StreamWriter writer = new StreamWriter(_filePath))
    //        {
    //            writer.WriteLine("Name,Price");

    //            foreach (var food in _foods)
    //            {
    //                writer.WriteLine($"{food.Name},{food.Price}");
    //            }
    //        }
    //    }

    //}





}
