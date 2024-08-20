using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace restaronas
{
    internal class Menu
    {
        TransactionManager manager = new TransactionManager();
        bool running = true;
        public void MainMenu()
        {
            while (running)
            {
                Console.WriteLine("\n===== bulviu karas =====");
                Console.WriteLine("1. Staliukai");
                Console.WriteLine("2. Uzsakymai");
                Console.WriteLine("3. ");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewPerson(manager);
                        break;
                    case "2":
                        GenerateTransactions(manager);
                        break;
                    case "3":
                        manager.PrintTransactionsSummary();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
    

    


