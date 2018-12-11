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
            /*
            cmsDBContext db = new cmsDBContext();
            Project s = new Project();
            s.projectid = "A21";
            s.projectname = "Job 1";
            s.duedate = "26.01.1995";
            s.status = "Open";
            s.assigned_people = "Anıl";
            db.Projects.Add(s);
            db.SaveChanges();
            */


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

            return RedirectToAction("Manager_Users");
        }
        public IActionResult Add_User()
        {
           

            return View();
        }

        [HttpPost]
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
    }
}
