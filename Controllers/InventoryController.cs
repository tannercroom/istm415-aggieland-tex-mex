using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team4_Project.Models;

namespace Team4_Project.Controllers
{
    public class InventoryController : Controller
    {
        private ATMContext context { get; set; }
        public InventoryController(ATMContext ctx)
        {
            context = ctx;
        }

        public IActionResult Inventory()
        {
            var inventory = context.Inventory.OrderBy(m => m.ItemID).ToList();
            return View(inventory);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Inventory());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var item = context.Inventory.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Inventory item)
        {
            if (ModelState.IsValid)
            {
                if (item.ItemID == 0)
                {
                    context.Inventory.Add(item);
                }
                else
                {
                    context.Inventory.Update(item);
                }
                context.SaveChanges();
                return RedirectToAction("Inventory", "Inventory");
            }
            else
            {
                ViewBag.Action = (item.ItemID == 0) ? "Add" : "Edit";
                return View(item);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = context.Inventory.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Inventory item)
        {
            context.Inventory.Remove(item);
            context.SaveChanges();
            return RedirectToAction("Inventory", "Inventory");
        }
    }
}
