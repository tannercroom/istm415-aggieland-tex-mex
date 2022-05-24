using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Team4_Project.Models;

namespace Team4_Project.Controllers
{
    public class CustomerController : Controller
    {
        private ATMContext context { get; set; }
        public CustomerController(ATMContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var customer = context.Customer.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerID == 0)
                {
                    context.Customer.Add(customer);
                }
                else
                {
                    context.Customer.Update(customer);
                }
                context.SaveChanges();
                return RedirectToAction("CustomerList", "Customer");
            }
            else
            {
                ViewBag.Action = (customer.CustomerID == 0) ? "Add" : "Edit";
                return View(customer);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customer.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customer.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("CustomerList", "Customer");
        }
        public IActionResult CustomerList()
        {
            var customers = context.Customer.OrderBy(m => m.CustomerID).ToList();
            return View(customers);
        }
    }
}
