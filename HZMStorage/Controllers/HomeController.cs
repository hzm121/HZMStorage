using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HZMStorage.Models;
using Microsoft.AspNetCore.Authorization;

namespace HZMStorage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationJooWMSDbContext dbContext;
        public HomeController(ApplicationJooWMSDbContext applicationJooWMSDbContext)
        {
            this.dbContext = applicationJooWMSDbContext;
        }
        /// <summary>
        /// 登录界面
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            
            return View();
        }

        /// <summary>
        /// 后台欢迎界面
        /// </summary>
        /// <returns></returns>
        public  IActionResult Welcome()
        {
            return  View();
        }

    }
}
