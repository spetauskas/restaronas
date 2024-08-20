using restoranas3.Repository;
using restoranas3.Repository.Interfaces;

namespace restoranas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            IBevarageRepository bevarageRepository = new BevarageRepository("C:\\cSharpFiles\\Drinks.csv"); // globalus objektas
            IFoodRepository foodRepository = new FoodRepository("C:\\cSharpFiles\\Food.csv");
            ITableRepository tableRepository = new TableRepository("C:\\cSharpFiles\\Tables.csv");
            //IOrderRepository orderRepository = new OrderRepository("C:\\cSharpFiles\\Order.json");

            var menu = new Menu(bevarageRepository, tableRepository, foodRepository);
            menu.MainMenu();
        }
    }
}