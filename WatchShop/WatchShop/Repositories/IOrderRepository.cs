using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Repositories
{
     public interface IOrderRepository
    {
        int CreateOrder(Order order);
        List<Order> GetOrdersList();
        Order GetOrder(int id);
        int UpdateOrder(Order order);
        int DeleteOrder(int id);
    }
}
