using FoodCsvWriter;
using restaronas;
using restaronas.services;
using static restaronas.services.DrinksList;

namespace restaronas
{
    internal class Program
    {
        //sukurti menu kur 1. pasirinkti stalus 2. prideti uzsakyma 3. isspausdinti ceki 4.paziureti info apie staliukus. 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //LoginForWaiter loginManager = new LoginForWaiter();
            //loginManager.WaiterMenuLogin();

            //FoodList foodList = new FoodList();
            //SaveFoodToFile saveFoodToFile = new SaveFoodToFile(foodList);

            //DrinksList drinksList = new DrinksList();
            //SaveFoodToFiledrinks saveFoodToFile1 = new SaveFoodToFiledrinks(drinksList);

            //TableList tableList = new TableList();
            //tableList.SelectTable();

            //FoodOrder order = new FoodOrder();
            //order.SelectFood();
            //order.DisplayReceipt();

            MenuScreen menuScreen = new MenuScreen();
            menuScreen.Display();
        }
    }
}
