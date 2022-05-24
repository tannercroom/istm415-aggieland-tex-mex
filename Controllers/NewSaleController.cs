using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Team4_Project.Models;

namespace Team4_Project.Controllers
{
    public class NewSaleController : Controller
    {
        List<Inventory> InventoryList = new List<Inventory>();
        List<Employee> EmployeeList = new List<Employee>();
        List<Customer> CustomerList = new List<Customer>();

        private ATMContext context { get; set; }

        public NewSaleController(ATMContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult NewSaleItem()
        {
            foreach (var item in context.Inventory)
            {
                InventoryList.Add(item);
            }
            ViewBag.Inventory = InventoryList;
            
            var orderdetail = new OrderDetail();
            return View(orderdetail);
        }

        [HttpPost]
        public IActionResult NewSaleItem(OrderDetail orderdetail)
        {
            if (ModelState.IsValid)
            {
                //Find Item in Inventory
                foreach (var item in context.Inventory)
                {
                    if (item.ItemID == orderdetail.ItemID)
                    {
                        orderdetail.OrderDetailSubtotal = item.ItemPrice * orderdetail.OrderQuantity; //Get OD Subtotal

                        //Decrease Item Qty in Inventory
                        item.ItemQuantity = item.ItemQuantity - orderdetail.OrderQuantity;
                        context.Inventory.Update(item);
                        break;
                    }
                }

                //Add OD to table and prep for next entry
                context.OrderDetail.Add(orderdetail);
                context.SaveChanges();
                return RedirectToAction("NewSaleItem", "NewSale");
            }
            else
            {
                return View(orderdetail);
            }
        }

        [HttpGet]
        public IActionResult FinishSale()
        {
            ViewBag.Subtotal = 0m;
            var order = new Order();

            //Populate Customer Dropdown
            foreach (var customer in context.Customer)
            {
                CustomerList.Add(customer);
            }
            ViewBag.Customer = CustomerList;

            //Populate Employee Dropdown
            foreach (var employee in context.Employee)
            {
                EmployeeList.Add(employee);
            }
            ViewBag.Employee = EmployeeList;

            //Prepopulate Subtotal, Tax, and Total
            foreach (var orderdetail in context.OrderDetail)
            {
                if (orderdetail.OrderID == null)
                {
                    ViewBag.Subtotal += orderdetail.OrderDetailSubtotal;
                }
            }
            order.Subtotal = ViewBag.Subtotal;
            order.Tax = order.Subtotal * 0.0875m;
            order.Total = order.Subtotal + order.Tax;

            //Prepopulate OrderDate
            order.OrderDate = System.DateTime.Now;

            return View(order);
        }

        [HttpPost]
        public IActionResult FinishSale(Order order)
        {
            //Populate Customer Dropdown
            foreach (var customer in context.Customer)
            {
                CustomerList.Add(customer);
            }
            ViewBag.Customer = CustomerList;

            //Populate Employee Dropdown
            foreach (var employee in context.Employee)
            {
                EmployeeList.Add(employee);
            }
            ViewBag.Employee = EmployeeList;

            if (ModelState.IsValid)
            {
                //Add New Order to table
                context.Order.Add(order);
                context.SaveChanges();

                //Set OrderDetail OrderIDs to new Order OrderID
                foreach (var orderdetail in context.OrderDetail)
                {
                    if (orderdetail.OrderID == null)
                    {
                        orderdetail.OrderID = order.OrderID;
                        context.OrderDetail.Update(orderdetail);
                    }
                }

                //Save all changes between tables and return
                context.SaveChanges();
                return RedirectToAction("Order", "Order");
            }
            else
            {
                return View(order);
            }
        }
    }
}
