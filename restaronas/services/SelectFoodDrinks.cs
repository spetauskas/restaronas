using restaronas.models;
using restaronas.services;
using System;
using System.Collections.Generic;
using System.IO;

public class FoodOrder : IScreen
{
    public string Name { get; set; } = "Pasirinkite patiekalus";
    public void Show()
    {
        SelectFood();
    }
    public List<Bevarages> availableFoods;
    public List<Bevarages> selectedFoods;

    public FoodOrder()
    {
        availableFoods = LoadFoodsFromFile("C:\\cSharpFiles\\Food.csv");
        selectedFoods = new List<Bevarages>();
    }

    public List<Bevarages> LoadFoodsFromFile(string filename)
    {
        List<Bevarages> foods = new List<Bevarages>();  // Add parentheses here
        string[] lines = File.ReadAllLines(filename);
        for (int i = 1; i < lines.Length; i++) // Skip header
        {
            string[] parts = lines[i].Split(',');
            foods.Add(new Bevarages(parts[0], decimal.Parse(parts[1])));
        }
        return foods;
    }

    public void DisplayAvailableFoods()
    {
        Console.WriteLine("Patiekalai:");
        for (int i = 0; i < availableFoods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {availableFoods[i].Name} - ${availableFoods[i].Price}");
        }
    }

    public void SelectFood()
    {
        DisplayAvailableFoods();
        Console.WriteLine("Enter the number of the food you want to add (0 to finish): ");
        
        int choice;
        while (int.TryParse(Console.ReadLine(), out choice) && choice != 0)
        {
            if (choice > 0 && choice <= availableFoods.Count)
            {
                selectedFoods.Add(availableFoods[choice - 1]);
                Console.WriteLine($"patiekalas {availableFoods[choice - 1].Name} pridetas.");
                Console.WriteLine("spauskite enter, jei norite išeiti");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            Console.Write("Enter the number of the food you want to add (0 to finish): ");
        }
        
    }

    public void DisplayReceipt()
    {
        Console.WriteLine("\nSąskaita:");
        decimal total = 0;
        foreach (var food in selectedFoods)
        {
            Console.WriteLine($"{food.Name} - ${food.Price}");
            total += food.Price;
        }
        Console.WriteLine($"Suma: ${total}");
        //write to file
    }
}