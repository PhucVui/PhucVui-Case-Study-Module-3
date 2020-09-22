using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WatchShop.Models;
using WatchShop.Repositories;

namespace WatchShop.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailRepository orderDetailRepository;

        public OrderDetailController(IOrderDetailRepository orderDetailRepository)
        {
            this.orderDetailRepository = orderDetailRepository;
        }
        public IActionResult Index()
        {
            return View();
        }        

        public IActionResult ShowOrderDetail(int id)
        {
           return View(orderDetailRepository.GetOrderByid(id));
        }
            
        [HttpGet]
        public IActionResult Create(int id)
        {
            return View(orderDetailRepository.CreateByOrderId(id));
        }            

        [HttpPost]
        public IActionResult Create(OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                if (orderDetailRepository.CreateOrderDetail(orderDetail) > 0 && orderDetail.Quantity > 0)
                    return RedirectToAction("ShowOrderDetail", "OrderDetail", orderDetailRepository.GetOrderByid(orderDetail.OrderId));

                ModelState.AddModelError("", "Quantity is not Null");
            }
            else
                ModelState.AddModelError("", "Erors");

            return View(orderDetail);
        }

        public JsonResult GetProductsByCategoryId(int id) =>
             Json(new SelectList(orderDetailRepository.GetListProductWithCategoryId(id), "Id", "Name"));

        [Route("/OrderDetail/GetPrice/{ProductId}/{Discount}/{Quantity}")]
        public JsonResult GetPrice(int ProductId, int Discount, int Quantity)
        {
            Product product = orderDetailRepository.GetProductById(ProductId);

            return Json(orderDetailRepository.Bill(product.Price, Discount, Quantity));
        }

        public JsonResult DefaultByProductId(int id)
        {
            Product product = orderDetailRepository.GetProductById(id);

            return Json(product.Price);
        }

        [HttpGet]
        public IActionResult Edit(int ProductId, int OrderId) =>
            View(orderDetailRepository.GetOrderDetailById(ProductId, OrderId));

        [HttpPost]
        public IActionResult Edit(OrderDetail orderDetail)
        {
            if (orderDetailRepository.UpdateOrderDetail(orderDetail) > 0)
                return RedirectToAction("ShowOrderDetail", "OrderDetail", orderDetailRepository.GetOrderByid(orderDetail.OrderId));

            return View(orderDetail);
        }

        [Route("/OrderDetail/Delete/{OrderId}/{ProductId}")]
        public IActionResult Delete(int OrderId, int ProductId)
        {
            var result = orderDetailRepository.DeleteOrderDetail(OrderId, ProductId);
            return Json(new { result });
        }
    }
}
