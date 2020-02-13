using System;
using EmployeeEntity;
using EmployeeRepositary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_MVC_Employee.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            IEnumerable<Employee> employees = Repositary.GetEmployee();
            ViewBag.Employees = employees;
            ViewData["Employees"] = employees;
            TempData["Employees"] = employees;
            return View();
        }
        public ActionResult IndexDataPassing()
        {
            IEnumerable<Employee> employees = Repositary.GetEmployee();
            ViewBag.Employees = employees;
            ViewData["Employees"] = employees;
            TempData["Employees"] = employees;
            return RedirectToAction("TempDataPassing");
        }
        public ViewResult TempDataPassing()
        {
            return View();
        }
    }
}