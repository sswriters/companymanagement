using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CompanyManagementSystem.Models;

namespace CompanyManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Manager_Index()
        {
            return View();
        }

        public IActionResult Manager_Users()
        {
            
            return View();
        }

        public IActionResult Customer_Index()
        {

            return View();
        }

        public IActionResult Customer_Info()
        {
            return View();
        }
        public IActionResult Employee_Index()
        {

            return View();
        }

        public IActionResult Employee_Info()
        {
            return View();
        }

    }
}
