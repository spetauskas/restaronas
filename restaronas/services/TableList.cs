using restaronas.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace restaronas.services
{
    public class TableList : IScreen
    {

        public string Name { get; set; } = "Pasirinkite staliuka";

        public void Show()
        {
            
            int selectedTableNumber = SelectTable();
            IfTableSelected(selectedTableNumber);
        }
        public List<Tables> TablesAll { get; set; }
        public TableList()
        {
            TablesAll = new List<Tables>
            {

            new Tables(1, 9),
            new Tables(2, 2),
            new Tables(3, 4),
            new Tables(4, 9),
            new Tables(5, 6),
            new Tables(6, 2),
            new Tables(7, 4)

            };

        }
        public int SelectTable()
        {
            if (TablesAll.Count == 0)
            {
                Console.WriteLine("Staliukų nerasta");
                return 0;
            }
            
                Console.WriteLine("Pasirinkite staliuką:");
                foreach (var table in TablesAll)
                {
                    string status = table.IsReserved ? "užimtas" : "laisvas";
                    Console.WriteLine($"Staliukas {table.TableNumber} ({table.Seats} vietos) - {status}");
                }

                int selectedTableNumber;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out selectedTableNumber))
                    {
                        var selectedTable = TablesAll.FirstOrDefault(t => t.TableNumber == selectedTableNumber);
                        if (selectedTable != null)
                        {
                            if (selectedTable.IsReserved)
                            {
                                Console.WriteLine("Staliukas užimtas");
                            }
                            else
                            {
                                selectedTable.IsReserved = true;
                                Console.WriteLine($"Pasirinktas staliukas {selectedTable.TableNumber}");
                            }

                            return selectedTableNumber;
                        }
                    }
                    Console.WriteLine("Neteisingas staliuko numeris. Bandykite dar kartą.");
                    return 0;
                   
                }
                
            

            
        }

        public void IfTableSelected(int number)
        {
           
            if (number != 0)
            {
                FoodOrder menuScreen = new FoodOrder();
                menuScreen.SelectFood();
                menuScreen.DisplayReceipt();
            }
        }
    }
    
    
    
}
