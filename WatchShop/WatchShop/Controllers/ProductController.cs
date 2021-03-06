﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WatchShop.Repositories;
using Microsoft.EntityFrameworkCore;
using WatchShop.Models;
using WatchShop.Models.ViewModels;

namespace WatchShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductView product)
        {
            if (ModelState.IsValid)
            {
                if (productRepository.CreateProduct(product) > 0)
                    return RedirectToAction("Index", "Product");
                
                    ModelState.AddModelError("", "Tên sản phẩm đã tồn tại");
            }
            return View(product);
        }
        public IActionResult Index()
        {
            return View(productRepository.GetProductList());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(productRepository.GetProduct(id));
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (productRepository.EditProduct(product) > 0)
                    return RedirectToAction("Index", "Product");
               
                    ModelState.AddModelError("", "Erors");
            }
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            if (productRepository.Delete(id) > 0)
                return RedirectToAction("Index", "Product");
            
                ModelState.AddModelError("", "Erors");
            return View();
        }

    }
}
