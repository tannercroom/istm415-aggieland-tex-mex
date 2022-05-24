using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Team4_Project.Models;

namespace Team4_Project.Models
{
    internal class SeedOrders : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.HasData(
                new Order
                {
                    OrderID = 1,
                    EmployeeID = 1,
                    CustomerID = 1,
                    OrderDate = DateTime.Parse("2022-04-01 11:10:54"),
                    PaymentType = "Credit Card",
                    CardName = "John Smith",
                    CardNumber = 1234123412341234,
                    CVV = 999,
                    CardExpirationDate = DateTime.Parse("04-2023"),
                    Subtotal = 9.50m,
                    Tax = 0.83m,
                    Total = 10.33m
                }
                );
        }
    }
}
