using restoranas3.Models;
using restoranas3.Repository;
using restoranas3.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace restoranas3
    //isspausdiname stalu sarasa, pasirenkame stala, tada pasirenkame gerimus. issaugome pasirinikimus i order.json su skirtingu ID . 
{
    internal class Menu

    {
        private readonly IBevarageRepository _bevarageRepository;
        private readonly ITableRepository _tableRepository;
        //private readonly IOrderRepository _orderRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly SelectTable _selectTable;
        private readonly InvoiceGenerator _invoiceGenerator;
        public Menu(IBevarageRepository bevarageRepository, ITableRepository tableRepository,IFoodRepository foodRepository/*, IOrderRepository orderRepository*/)
        {
            _bevarageRepository = bevarageRepository;
            _tableRepository = tableRepository;
            _foodRepository = foodRepository;
            //_orderRepository = orderRepository;
            _selectTable = new SelectTable(_tableRepository);
            //_invoiceGenerator = new NewOrder(_orderRepository);

        }

        public void PrintAllBeverages()
        {
            var bevList = _bevarageRepository.GetAll();
            foreach (var bev in bevList)
            {
                Console.WriteLine($"{bev.Name}, {bev.Price}");
            }
        }
        public void PrintTablesLIst()
        {
            var tableList = _tableRepository.GetAll();
            foreach (var tb in tableList)
            {
                Console.WriteLine($"{tb.TableNumber}, {tb.Seats}, {tb.IsReserved}");
            }
        }


            bool running = true;
            public void MainMenu()
            {
                while (running)
                {
                    Console.WriteLine("\n===== Simtas bulviu =====\n");
                    Console.WriteLine("1. Staliukai");
                    Console.WriteLine("2. Uzsakymai");
                    Console.WriteLine("3. patiekalai ir gerimai");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1-4): ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":

                            _selectTable.SelectTableNumber();
                            break;

                        case "2":
                            OrderMenu();
                            break;
                        case "3":
                            Console.WriteLine("-----------gerimai");
                            PrintAllBeverages();
                            Console.WriteLine("-----------patiekalai");
                            //imesti patiekalu lista
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
        public void OrderMenu()
        {
            while (running)
            {
                Console.WriteLine("1. pradeti uzsakyma");
                Console.WriteLine("2. papildyti uzsakyma");
                Console.WriteLine("3. perziureti uzsakyma");
                Console.WriteLine("4. uzbaigti uzsakyma ir spausdinti saskaita");
                Console.WriteLine("5. grizti i pradini langa");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":


                        
                        
                        break;

                    case "2":
                        // HandleTableMenu();
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }


    }
        
    }


























