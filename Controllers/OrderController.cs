using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team4_Project.Models;

namespace Team4_Project.Controllers
{
    public class OrderController : Controller
    {
        private ATMContext context { get; set; }
        public OrderController(ATMContext ctx)
        {
            context = ctx;
        }
        public IActionResult Order()
        {
            var orders = context.Order.OrderBy(m => m.OrderID).ToList();
            return View(orders);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Order());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var order = context.Order.Find(id);
            return View(order);
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tax = order.Subtotal * 0.0875m;
                order.Tax = ViewBag.Tax;
                ViewBag.Total = order.Subtotal + order.Tax;
                order.Total = ViewBag.Total;
                if (order.OrderID == 0)
                {
                    order.OrderDate = System.DateTime.Now;
                    context.Order.Add(order);
                }
                else
                {
                    context.Order.Update(order);
                }
                context.SaveChanges();
                return RedirectToAction("Order", "Order");
            }
            else
            {
                ViewBag.Action = (order.OrderID == 0) ? "Add" : "Edit";
                return View(order);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var order = context.Order.Find(id);
            return View(order);
        }

        [HttpPost]
        public IActionResult Delete(Order order)
        {
            context.Order.Remove(order);
            context.SaveChanges();
            return RedirectToAction("Order", "Order");
        }
    }
}
