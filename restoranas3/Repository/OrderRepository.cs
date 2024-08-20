using restoranas3.Models;
using restoranas3.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace restoranas3.Repository
{
    internal class OrderRepository : IOrderRepository
    {
        private readonly string _filePath;
        private readonly List<Order> _order;

        public OrderRepository(string filePath)
        {
            _filePath = filePath;
            _order = GetAllOrders();
            

        }
        //private List<Order> LoadFromFile()
        //{
        //    var lines = File.ReadAllLines(_filePath);
        //    var order = new List<Order>();
        //    foreach (var line in lines)
        //    {
        //        var parts = line.Split(',');
        //        if (parts.Length == 8)
        //        {
        //            int tableNumber = int.Parse(parts[0]);
        //            int orderId = int.Parse(parts[1]);
        //            string foodName = parts[2];
        //            decimal foodPrice = decimal.Parse(parts[3]);
        //            string drinkName = parts[4];
        //            decimal drinkPrice = decimal.Parse(parts[5]);
        //            decimal totalSum = decimal.Parse(parts[6]);
        //            DateTime dateTime = DateTime.Parse(parts[7]);
        //        }
        //    }

        //    return _order;
        //}
        #region Json


        public List<Order> GetAllOrders() //perziureti visus uzsakymus
        {
            var json = File.ReadAllText(_filePath);
            if (string.IsNullOrWhiteSpace(json))
            {
                Console.WriteLine("Error: The JSON file is empty or contains only whitespace.");
                
            }

            try
            {
                var orders = JsonSerializer.Deserialize<List<Order>>(json);
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON Deserialization Error: {ex.Message}");
                // Handle exception
            }
            return JsonSerializer.Deserialize<List<Order>>(json);
        }

        //public Order GetOrderById(int id) //pasirinkti uzsakyma pagal staliuko nr.
        //{
        //    var orders = GetAllOrders();
        //    return orders.FirstOrDefault(o => o.OrderId == id);
        //}

        //public void AddOrder(Order order)
        //{
        //    var orders = GetAllOrders();

        //    // Assign a new ID
        //    if (orders.Any())
        //    {
        //        order.OrderId = orders.Max(o => o.OrderId) + 1;
        //    }
        //    else
        //    {
        //        order.OrderId = 1;
        //    }

        //    orders.Add(order);
        //    SaveOrders(orders);
        //}

        //public void UpdateOrder(Order updatedOrder)
        //{
        //    var orders = GetAllOrders();
        //    var order = orders.FirstOrDefault(o => o.OrderId == updatedOrder.OrderId);

        //    if (order != null)
        //    {
               
        //        order.Quantity = updatedOrder.Quantity;
                
        //        SaveOrders(orders);
        //    }
        //    else
        //    {
        //        throw new Exception("Order not found");
        //    }
        //}

        //public void DeleteOrder(int id)
        //{
        //    var orders = GetAllOrders();
        //    var order = orders.FirstOrDefault(o => o.OrderId == id);

        //    if (order != null)
        //    {
        //        orders.Remove(order);
        //        SaveOrders(orders);
        //    }
        //    else
        //    {
        //        throw new Exception("Order not found");
        //    }
        //}

        //private void SaveOrders(List<Order> orders)
        //{
        //    var json = JsonSerializer.Serialize(orders, new JsonSerializerOptions { WriteIndented = true });
        //    File.WriteAllText(_filePath, json);
        //}
        #endregion
        public List<Order> GetAll()
        {
            return _order;
        }

        //private List<Order> SaveToFile(List<Order> order)
        //{
        //    string[] pav = order.Select(order => $"{order.OrderId},{order.FoodName}").ToArray();
        //    var lines = File.WriteAllLines(_filePath, pav);
        //    var ord = new List<Order>(); 

        //    foreach (var line in lines)
        //    { 
        //        line.Split(",").ForEach(x => order.Add(x)); 
        //    }

        //return _order;
        //}
    }
    //////////
    /// <summary>
    /// 
    /// 
    /// </summary>
    /// 

    /*
    public class OrderRepository
    {
        private readonly string _filePath;

        public OrderRepository(string filePath)
        {
            _filePath = filePath;

        }

        public List<Order> GetAllOrders()
        {
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Order>>(json);
        }

        public Order GetOrderById(int id)
        {
            var orders = GetAllOrders();
            return orders.FirstOrDefault(o => o.Id == id);
        }

        public void AddOrder(Order order)
        {
            var orders = GetAllOrders();

            // Assign a new ID
            if (orders.Any())
            {
                order.Id = orders.Max(o => o.Id) + 1;
            }
            else
            {
                order.Id = 1;
            }

            orders.Add(order);
            SaveOrders(orders);
        }

        public void UpdateOrder(Order updatedOrder)
        {
            var orders = GetAllOrders();
            var order = orders.FirstOrDefault(o => o.Id == updatedOrder.Id);

            if (order != null)
            {
                order.ProductName = updatedOrder.ProductName;
                order.Quantity = updatedOrder.Quantity;
                order.Price = updatedOrder.Price;
                SaveOrders(orders);
            }
            else
            {
                throw new Exception("Order not found");
            }
        }

        public void DeleteOrder(int id)
        {
            var orders = GetAllOrders();
            var order = orders.FirstOrDefault(o => o.Id == id);

            if (order != null)
            {
                orders.Remove(order);
                SaveOrders(orders);
            }
            else
            {
                throw new Exception("Order not found");
            }
        }

        private void SaveOrders(List<Order> orders)
        {
            var json = JsonSerializer.Serialize(orders, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
    */

}
