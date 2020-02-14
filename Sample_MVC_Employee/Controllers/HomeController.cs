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
        Repositary repositary = new Repositary();
        // GET: Home
        public ViewResult Index()  //To display employee details
        {
            IEnumerable<Employee> employees = Repositary.GetEmployee();
            ViewData["Employees"] = employees;
            return View();
        }
        public ActionResult IndexDataPassing() //To redirect Tempdata
        {
            IEnumerable<Employee> employees = Repositary.GetEmployee();
            ViewBag.Employees = employees;
            ViewData["Employees"] = employees;
            TempData["Employees"] = employees;
            return RedirectToAction("TempDataPassing");
        }
        public ViewResult TempDataPassing() //Display redirected Tempdata details
        {
            return View();
        }
        public ViewResult Create()  //To insert new Employee
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                repositary.Add(employee);
                TempData["Message"] = "Employee is added successfully";
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        public ActionResult Delete(int id)
        {
            repositary.Delete(id);
            TempData["Message"] = "Employee is deleted successfully";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Employee employee = repositary.GetEmployeeById(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                repositary.Update(employee);
                TempData["Message"] = "Employee is Updated successfully";
                return RedirectToAction("Index");
            }
            return View("Edit", employee);
        }
    }
}