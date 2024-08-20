using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaronas.services
{



    
    public class MenuScreen
    {
        public readonly List<IScreen> _screens;

        public MenuScreen()
        {
            _screens = new List<IScreen>
            {
                new TableList(),
                new FoodOrder()
            };
        }

        public void Display()
        {
            bool continueMenu = true;
            while (continueMenu)
            {
                Console.WriteLine("\nMenu:");
                for (int i = 0; i < _screens.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_screens[i].Name}");
                }
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                    {
                        continueMenu = false;
                    }
                    else if (choice > 0 && choice <= _screens.Count)
                    {
                        _screens[choice - 1].Show();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
    
}

