using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team4_Project.Models;

namespace Team4_Project.Controllers
{
    public class OrderDetailController : Controller
    {
        private ATMContext context { get; set; }
        public OrderDetailController(ATMContext ctx)
        {
            context = ctx;
        }
        public IActionResult OrderDetail()
        {
            var orderdetail = context.OrderDetail.OrderBy(m => m.OrderDetailID).ToList();
            return View(orderdetail);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new OrderDetail());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var orderdetail = context.OrderDetail.Find(id);
            return View(orderdetail);
        }

        [HttpPost]
        public IActionResult Edit(OrderDetail orderdetail)
        {
            if (ModelState.IsValid)
            {
                if (orderdetail.OrderDetailID == 0)
                {
                    context.OrderDetail.Add(orderdetail);
                }
                else
                {
                    context.OrderDetail.Update(orderdetail);
                }
                context.SaveChanges();
                return RedirectToAction("OrderDetail", "OrderDetail");
            }
            else
            {
                ViewBag.Action = (orderdetail.OrderDetailID == 0) ? "Add" : "Edit";
                return View(orderdetail);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var orderdetail = context.OrderDetail.Find(id);
            return View(orderdetail);
        }

        [HttpPost]
        public IActionResult Delete(OrderDetail orderdetail)
        {
            context.OrderDetail.Remove(orderdetail);
            context.SaveChanges();
            return RedirectToAction("OrderDetail", "OrderDetail");
        }
    }
}
