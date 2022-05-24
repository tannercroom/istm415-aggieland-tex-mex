using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Team4_Project.Models;

namespace Team4_Project.Controllers
{
    public class EmployeeController : Controller
    {
        private ATMContext context { get; set; }
        public EmployeeController(ATMContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Employee());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var customer = context.Employee.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.EmployeeID == 0)
                {
                    context.Employee.Add(employee);
                }
                else
                {
                    context.Employee.Update(employee);
                }
                context.SaveChanges();
                return RedirectToAction("EmployeeList", "Employee");
            }
            else
            {
                ViewBag.Action = (employee.EmployeeID == 0) ? "Add" : "Edit";
                return View(employee);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = context.Employee.Find(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            context.Employee.Remove(employee);
            context.SaveChanges();
            return RedirectToAction("EmployeeList", "Employee");
        }
        public IActionResult EmployeeList()
        {
            var employees = context.Employee.OrderBy(m => m.EmployeeID).ToList();
            return View(employees);
        }
    }
}
