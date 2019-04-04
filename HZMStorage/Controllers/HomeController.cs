using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HZMStorage.Models;

namespace HZMStorage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationJooWMSDbContext dbContext;
        public HomeController(ApplicationJooWMSDbContext applicationJooWMSDbContext)
        {
            this.dbContext = applicationJooWMSDbContext;
        }
        public IActionResult Index()
        {
            //test2
            return View();
        }

    }
}
