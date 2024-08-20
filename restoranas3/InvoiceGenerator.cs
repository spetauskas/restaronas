using restoranas3.Models;
using restoranas3.Repository;
using restoranas3.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace restoranas3
{
    internal class InvoiceGenerator
    {
        private readonly IBevarageRepository _bevarageRepository;
        private readonly ITableRepository _tableRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly SelectTable _selectTable;
        public InvoiceGenerator(IBevarageRepository bevarageRepository, ITableRepository tableRepository, IFoodRepository foodRepository)
        {
            _bevarageRepository = bevarageRepository;
            _tableRepository = tableRepository;
            _foodRepository = foodRepository;
            _selectTable = new SelectTable(_tableRepository);

        }

        public void NewOrder()
        {
            var orders = new List<Order>(); //susikuriame nauja lista uzsakymui
            //int tableNumber = _selectTable.SelectTableNumber();
            //if (tableNumber == 0)
            //{
            //    Console.WriteLine("Order cancelled.");
            //    return;
            //}
            var tableList = _tableRepository.GetAll();

            var bevList = _bevarageRepository.GetAll();
            //prideti food lista.


            Console.WriteLine("Available beverages:");
            for (int i = 0; i < bevList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bevList[i].Name}: ${bevList[i].Price}");
            }

            Console.WriteLine("Enter the number of the beverage you want to order, or '0' to finish:");

            while (true)
            {
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int bevNumber) && bevNumber > 0 && bevNumber <= bevList.Count)
                {
                    var selectedBeverage = bevList[bevNumber - 1];


                    Console.WriteLine($"{selectedBeverage.Name} added to the order.");

                    // Ask if the user wants to add another item or finish the order
                    Console.WriteLine("Would you like to add another beverage? (y to continue, n to finish):");
                    string continueOrder = Console.ReadLine();
                    if (continueOrder?.ToLower() != "y")
                    {
                        break;
                    }

                    Console.WriteLine("Enter the number of the next beverage you want to order, or '0' to finish:");
                }
                else if (bevNumber == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
            }
            //issaugoti pasirinkimus i order.json
            // AddOrder();


        }
    }
}