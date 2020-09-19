using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;

namespace WatchShop.Repositories
{
    public interface IOrderDetailRepository
    {
        Product GetProductById(int id);
        Order GetOrderByid(int id);
        int CreateOrderDetail(OrderDetail orderDetail);
        OrderDetail CreateByOrderId(int id);             
        OrderDetail GetOrderDetailById(int ProductId, int OrderId);
        List<Product> GetListProductWithCategoryId(int id);
        double Bill (double Price, int Quantity, double Discount );
        int UpdateOrderDetail(OrderDetail orderDetail);
        int DeleteOrderDetail(int OrderId, int ProductId);

    }
}
