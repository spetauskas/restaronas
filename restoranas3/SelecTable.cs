using restoranas3.Models;
using restoranas3.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace restoranas3
{
    public class SelectTable
    {
        public List<Table> TablesAll { get; set; }
        private readonly ITableRepository _tableRepository;

        public SelectTable(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository ?? throw new ArgumentNullException(nameof(tableRepository));
            TablesAll = _tableRepository.GetAll().ToList();
        }

        public void DisplayTablesList()
        {
            Console.WriteLine("Pasirinkite staliuką:");
            foreach (var table in TablesAll)
            {
                string status = table.IsReserved ? "užimtas" : "laisvas";
                Console.WriteLine($"Staliukas {table.TableNumber} ({table.Seats} vietos) - {status}");

            }
            Console.WriteLine("0- iseiti");
            string choice = Console.ReadLine();

            if (choice != null && choice == "0")
            {
                Console.WriteLine("cia turi buti methodo mainmenu iskvietimas");
                Menu exit = new Menu();
                exit.MainMenu();
            }

        }

        public int SelectTableNumber()
        {
            int start = 0;
            if (TablesAll.Count == 0)
            {
                Console.WriteLine("Staliukų nerasta");
                return 0;
            }

            DisplayTablesList();

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int selectedTableNumber))
                {
                    var selectedTable = TablesAll.FirstOrDefault(t => t.TableNumber == selectedTableNumber);
                    if (selectedTable != null)
                    {
                        if (selectedTable.IsReserved)
                        {
                            Console.WriteLine("Staliukas užimtas");
                            Console.WriteLine("ar norite atlaisvinti staliuka? 0 - atlaisvinti, 1 - grizti i sarasa");
                            string choice = Console.ReadLine();
                            if (choice != null && choice == "0")
                            {
                                selectedTable.IsReserved = false;
                                Console.WriteLine($"staliukas {selectedTableNumber} atlaisvintas");
                                DisplayTablesList();
                            }
                            else if (choice != null && choice == "1")
                            {
                                DisplayTablesList();
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Pasirinktas staliukas {selectedTable.TableNumber}");
                            ReserveTable(selectedTableNumber);
                            return selectedTableNumber;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Neteisingas staliuko numeris. Bandykite dar kartą.");
                    }
                }
                else
                {
                    Console.WriteLine("Neteisingas įvedimas. Įveskite skaičių.");
                    
                }
            }
        }
        public bool ReserveTable(int tableNumber)
        {
            var table = TablesAll.FirstOrDefault(t => t.TableNumber == tableNumber);
            if (table != null /*&& !table.IsReserved*/)
            {
                table.IsReserved = true;
                _tableRepository.Update(table);
                return true;
            }

            return false;
            

        }
    }
}