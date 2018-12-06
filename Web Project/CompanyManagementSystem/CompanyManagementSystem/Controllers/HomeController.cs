using Microsoft.AspNetCore.Mvc;

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

    }
}
