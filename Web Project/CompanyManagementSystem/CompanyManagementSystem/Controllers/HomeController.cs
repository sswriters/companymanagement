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
            cmsDBContext db = new cmsDBContext();
            return View(db.Projects.ToList());
        }
        public IActionResult Manager_Users()
        {
            cmsDBContext db = new cmsDBContext();
            return View(db.Person.ToList());
        }
        public IActionResult Customer_Index(People p)
        {
            cmsDBContext db = new cmsDBContext();

            return View(db.Projects.ToList());

        }
        public IActionResult Customer_Info()
        {
            cmsDBContext db = new cmsDBContext();
            People p = new People();
            p.name = TempData["Name"].ToString();
            return View(db.Person.Find(p.name));

        }
        public IActionResult Employee_Index()
        {
            cmsDBContext db = new cmsDBContext();
            return View(db.Projects.ToList());
        }
        public IActionResult Employee_Info()
        {

            cmsDBContext db = new cmsDBContext();
            return View(db.Person.ToList());
        }
        public IActionResult Delete_User(string id)
        {
            cmsDBContext db = new cmsDBContext();
            People s = new People();
            s.name = id;
            db.Person.Remove(s);
            db.SaveChanges();

            return RedirectToAction("Manager_Users");
        }
        public IActionResult Add_User()
        {
           

            return View();
        }
        public IActionResult Manager_Add(People s)
        {
             cmsDBContext db = new cmsDBContext();
             db.Person.Add(s);
             db.SaveChanges();

            return RedirectToAction("Manager_Users");
        }
        public IActionResult Project_Add(Project p)
        {
            cmsDBContext db = new cmsDBContext();
            db.Projects.Add(p);
            db.SaveChanges();
            return RedirectToAction("Manager_Index");
        }
        public IActionResult Add_Project()
        {


            return View();
        }
        public IActionResult Project_Delete(string id)
        {
            cmsDBContext db = new cmsDBContext();
            Project p = new Project();
            p.projectid = id;
            db.Projects.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Manager_Index");
        }
        public IActionResult Project_Update(string id)
        {
            cmsDBContext db = new cmsDBContext();
            Project s = new Project();
            s.projectid = id;

            return View(db.Projects.Find(s.projectid));
        }
        public IActionResult Edit_Project(Project p)
        {
            cmsDBContext db = new cmsDBContext();
            db.Projects.Update(p);
            db.SaveChanges();
            return RedirectToAction("Manager_Index");
            
        }
        public IActionResult User_Update(string id)
        {
            cmsDBContext db = new cmsDBContext();
            People s = new People();
            s.name = id;

            return View(db.Person.Find(s.name));
        }
        public IActionResult Edit_User(People p)
        {
            cmsDBContext db = new cmsDBContext();
            db.Person.Update(p);
            db.SaveChanges();
            return RedirectToAction("Manager_Users");
        }
       /* public IActionResult Customer_User_Update()
        {
            cmsDBContext db = new cmsDBContext();
            People s = new People();
            s.name = ViewBag.Person;

            return View(db.Person.Find(s.name));
        }*/
        public IActionResult Customer_Edit_User(People p)
        {
            cmsDBContext db = new cmsDBContext();
            db.Person.Update(p);
            db.SaveChanges();
            //return RedirectToAction("Manager_Users");
            return View("Customer_Info");
        }
        public IActionResult Login(string name, string pass)
        {

            cmsDBContext db = new cmsDBContext();
            People s = new People();
            s.name = name;
            s = db.Person.Find(s.name);
            //TempData["Project"] = s.projects;TempData["Projects"].ToString
            //TempData["Project"] = "P";
            TempData["Project"] = s.projects;
            TempData["Name"] = s.name;
            TempData["Role"] = s.role;
            if (pass == s.pass) { 
            if (s.role=="Manager") { return RedirectToAction("Manager_Index"); }
            if (s.role == "Customer") { return RedirectToAction("Customer_Index"); }
            if (s.role == "Employee") { return RedirectToAction("Employee_Index"); }
            }
            
            return RedirectToAction("Index");
            
        }
    }
}
