using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchShop.Models;
using WatchShop.Repositories;

namespace WatchShop.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly WatchShopDbContext _context;

        public OrderDetailRepository(WatchShopDbContext context)
        {
            this._context = context;
        }

        public double Bill(double Price, int Quantity, double Discount)
        {
            return Price * Quantity * ((100 - Discount) / 100);
        }

        public OrderDetail CreateByOrderId(int id)
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                OrderId = id
            };
            return orderDetail;
        }

       
        public int CreateOrderDetail(OrderDetail orderDetail)
        {
            List<OrderDetail> orderDetails = _context.OrderDetails.ToList();

            OrderDetail FindOrderDetail = orderDetails.Find(o =>
                                        o.OrderId == orderDetail.OrderId &&
                                        o.ProductId == orderDetail.ProductId);
            Product product = _context.Products.FirstOrDefault(p => p.Id == orderDetail.ProductId);

            if (orderDetails.Contains(FindOrderDetail))  // ngang đoạn này hơi hoang mang
            {
                FindOrderDetail.Quantity += orderDetail.Quantity;
                FindOrderDetail.Total += Bill(product.Price, orderDetail.Quantity, orderDetail.Discount);

                _context.Update(FindOrderDetail);
            }
            else
            {
                orderDetail.Total = Bill(product.Price, orderDetail.Quantity, orderDetail.Discount);

                _context.Add(orderDetail);
            }

            return _context.SaveChanges();
        }

        public List<Product> GetListProductWithCategoryId(int id)
        {
            return _context.Products.ToList().FindAll(p => p.CategoryId == id);
        }

        public Order GetOrderByid(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public OrderDetail GetOrderDetailById(int ProductId, int OrderId)
        {
            var orderdetail = _context.OrderDetails.FirstOrDefault(od => od.ProductId == ProductId
                                                                   && od.OrderId == OrderId);
            return (orderdetail);
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(el => el.Id == id);
        }

        public int UpdateOrderDetail(OrderDetail orderDetail)
        {
            _context.Update(orderDetail);
            return _context.SaveChanges();
        }
        public int DeleteOrderDetail(int OrderId, int ProductId)
        {
            var orderDetail = _context.OrderDetails.FirstOrDefault(o => o.OrderId == OrderId &&
                                                                   o.ProductId == ProductId);
            _context.Remove(orderDetail);
            return _context.SaveChanges();
        }
    }
}
