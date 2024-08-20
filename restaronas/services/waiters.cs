//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace restaronas.services
//{
//    internal class Waiters
//    {
//        private string filePath = "C:\\Users\\SHpokas laptop\\source\\repos\\restaronas\\restaronas\\services\\waiters.txt";
//        public Dictionary<string, string> waiter = new Dictionary<string, string>();

//        public Waiters()
//        {
//            waiter.Add("Julija", "11");
//            waiter.Add("Andrius", "22");
//            waiter.Add("Rugile", "33");
//        }

//        public void AddWaiterCheckNameDuplicate(string name, string password)
//        {
//            if (!waiter.ContainsKey(name))
//            {
//                waiter.Add(name, password);
//            }
//            else
//            {
//                Console.WriteLine($"Waiter {name} already exists.");
//            }
//        }
//        //pasidaryti check ar egzituoja failas
//        public void SaveToFile()
//        {
//            if (File.Exists(filePath))
//            {
//                File.WriteAllLines(filePath, waiter.Select(kv => $"{kv.Key}:{kv.Value}"));
//            }
//            else
//            {
//                Console.WriteLine("padaveju sarasas nerastas");
//            }
//        }

//    }
//}
