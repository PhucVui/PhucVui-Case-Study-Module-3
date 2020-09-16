using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WatchShop.Repositories;

namespace WatchShop.Controllers
{
    public class OrderController : Controller
    {      
        public IActionResult Index()
        {
            return View();
        }
    }
}
