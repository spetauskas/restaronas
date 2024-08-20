//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace restaronas.services
//{
//    internal class LoginForWaiter
//    {
//        private string filePath = "C:\\Users\\SHpokas laptop\\source\\repos\\restaronas\\restaronas\\services\\waiters.txt";
//        public Dictionary<string, string> waiter = new Dictionary<string, string>();
//        public void LoadFromFile()


//        {
//            if (File.Exists(filePath))
//            {
//                var lines = File.ReadAllLines(filePath);
//                waiter = lines.Select(line => line.Split(':'))
//                               .ToDictionary(parts => parts[0], parts => parts[1]);
//            }
//            else
//            {
//                Console.WriteLine("padaveju sarasas nerastas");
//            }
//        }

//        public void WaiterMenuLogin()
//        {
//            LoadFromFile();

//            if (waiter.Count == 0)
//            {
//                Console.WriteLine("Nėra užregistruotų padavėjų.");
//                return;
//            }

//            while (true)
//            {
//                Console.WriteLine("\nPasirinkite padavėją iš sąrašo:");

//                List<string> waiterNames = waiter.Keys.ToList();
//                for (int i = 0; i < waiterNames.Count; i++)
//                {
//                    Console.WriteLine($"{i + 1}. {waiterNames[i]}");
//                }
//                Console.WriteLine("0. Išeiti");

//                Console.Write("\nĮveskite pasirinkimo numerį: ");
//                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > waiterNames.Count)
//                {
//                    Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar kartą.");
//                    continue;
//                }

//                if (choice == 0)
//                {
//                    Console.WriteLine("Atsijungiama...");
//                    break;
//                }

//                string selectedWaiter = waiterNames[choice - 1];
//                Console.Write("Įveskite slaptažodį: ");
//                string enteredPassword = Console.ReadLine();

//                if (waiter[selectedWaiter] == enteredPassword)
//                {
//                    Console.WriteLine($"Sėkmingai prisijungėte kaip {selectedWaiter}!");
                    
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Neteisingas slaptažodis. Bandykite dar kartą.");
//                }
//            }
//        }
//    }
//}
        

