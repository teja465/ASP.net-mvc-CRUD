using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CURD27.Models;
namespace CURD27.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDataContext objDataContext = new EmployeeDataContext();
        public ActionResult Index()
        {
            
            return View(objDataContext.employees.ToList());
        }

        public ActionResult Edit(int id)
        {
           Employee  emp = objDataContext.employees.Find(Convert.ToInt32(id));
            ViewBag.Message = "Your application description page.";
            return View(emp);
        }
       
        public ActionResult Detail(int id)
        {
            ViewBag.Message = " Employee detail page.";
            int Id = Convert.ToInt32(id);
            var emp = objDataContext.employees.Find(Id);
            if (emp == null)
            {
                return Content("Invalid employee Id");
            }
            return View(emp);
        }
        
        //Just checking 
        public ActionResult Create(Employee data)
        {
            if (data.Name!=null)
            {
                
                objDataContext.employees.Add(data);
                objDataContext.SaveChanges();
                return Content("Employee Object Created Successfully",data.ToString());
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            Employee emp = objDataContext.employees.Find(Convert.ToInt32(id));
            objDataContext.employees.Remove(emp);
            objDataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}