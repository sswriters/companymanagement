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

            //Add_User();
            return View();
        }
        public IActionResult Manager_Index()
        {
            return View();
        }

        public IActionResult Manager_Users()
        {
            cmsDBContext db = new cmsDBContext();
            return View(db.Person.ToList());
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
        public IActionResult Delete_User(string id)
        {
            cmsDBContext db = new cmsDBContext();
            People s = new People();
            s.name = id;
            db.Person.Remove(s);
            db.SaveChanges();

            return View("Manager_Index");
        }
        public IActionResult Add_User()
        {
           /* cmsDBContext db = new cmsDBContext();
            People s = new People();
            s.name = "Ahmet Mehmet";
            s.pass = "admin";
            s.phone = "858585";
            s.projects = "Project 5";
            s.mail = "ahmet@ahmet.com";
            s.role = "Employee";
            db.Person.Add(s);
            db.SaveChanges();*/

            return View();
        }

        public IActionResult Manager_Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Manager_Add(People s)
        {
             cmsDBContext db = new cmsDBContext();
             /*People s = new People();
             s.name = "Ahmet Mehmet";
             s.pass = "admin";
             s.phone = "858585";
             s.projects = "Project 5";
             s.mail = "ahmet@ahmet.com";
             s.role = "Employee";*/
             db.Person.Add(s);
             db.SaveChanges();

            return View("Manager_Index");
        }



    }
}
