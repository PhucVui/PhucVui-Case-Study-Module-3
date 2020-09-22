using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WatchShop.Models;
using WatchShop.Repositories;

namespace WatchShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View(orderRepository.GetOrdersList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                if (orderRepository.CreateOrder(order) > 0)
                    return RedirectToAction("Index", "Order");
                
                    ModelState.AddModelError("", "some thing wrong");
            }
            return View(order);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(orderRepository.GetOrder(id));
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                if (orderRepository.UpdateOrder(order) > 0)
                    return RedirectToAction("Index", "Order");
               
                    ModelState.AddModelError("", "Erors");
            }
            return View(order);
        }

        public IActionResult Delete(int id)
        {
            if (orderRepository.DeleteOrder(id) > 0)
                return RedirectToAction("Index", "Order");
            
                ModelState.AddModelError("", "Erors");
            return View();
        }
    }
}
