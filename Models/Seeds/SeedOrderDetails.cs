using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Team4_Project.Models;

namespace Team4_Project.Models
{
    internal class SeedOrderDetails : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> entity)
        {
            entity.HasData(
                new OrderDetail
                {
                    OrderDetailID = 1,
                    OrderID = 1,
                    ItemID = 1,
                    OrderQuantity = 1,
                    OrderDetailSubtotal = 5.00m
                },
                new OrderDetail
                {
                    OrderDetailID = 2,
                    OrderID = 1,
                    ItemID = 5,
                    OrderQuantity = 1,
                    OrderDetailSubtotal = 2.75m
                },
                new OrderDetail
                {
                    OrderDetailID = 3,
                    OrderID = 1,
                    ItemID = 8,
                    OrderQuantity = 1,
                    OrderDetailSubtotal = 1.75m
                }
                );
        }
    }
}
