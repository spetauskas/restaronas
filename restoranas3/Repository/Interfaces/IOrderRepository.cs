using restoranas3.Models;

namespace restoranas3.Repository.Interfaces
{
    internal interface IOrderRepository
    {
        List<Order> GetAll();


        //void AddOrder(Order order);
        //void DeleteOrder(int id);
        //List<Order> GetAllOrders();
        //Order GetOrderById(int id);
        //void UpdateOrder(Order updatedOrder);
    }
}