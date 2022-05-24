using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Team4_Project.Models;

namespace Team4_Project.Models
{
    internal class SeedInventory : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> entity)
        {
            entity.HasData(
                new Inventory
                {
                    ItemID = 1,
                    ItemName = "Taco",
                    ItemType = "Entree",
                    ItemPrice = 5.00m,
                    ItemQuantity = 999
                },
                new Inventory
                {
                    ItemID = 2,
                    ItemName = "Burrito",
                    ItemType = "Entree",
                    ItemPrice = 6.00m,
                    ItemQuantity = 1000
                },
                new Inventory
                {
                    ItemID = 3,
                    ItemName = "Nachos",
                    ItemType = "Entree",
                    ItemPrice = 5.50m,
                    ItemQuantity = 1000
                },
                new Inventory
                {
                    ItemID = 4,
                    ItemName = "Enchilada",
                    ItemType = "Entree",
                    ItemPrice = 6.50m,
                    ItemQuantity = 1000
                },
                new Inventory
                {
                    ItemID = 5,
                    ItemName = "Churro",
                    ItemType = "Side",
                    ItemPrice = 2.75m,
                    ItemQuantity = 999
                },
                new Inventory
                {
                    ItemID = 6,
                    ItemName = "Quesadilla",
                    ItemType = "Side",
                    ItemPrice = 4.00m,
                    ItemQuantity = 1000
                },
                new Inventory
                {
                    ItemID = 7,
                    ItemName = "Chips & Dip",
                    ItemType = "Side",
                    ItemPrice = 3.75m,
                    ItemQuantity = 1000
                },
                new Inventory
                {
                    ItemID = 8,
                    ItemName = "Small Drink",
                    ItemType = "Drink",
                    ItemPrice = 1.75m,
                    ItemQuantity = 999
                },
                new Inventory
                {
                    ItemID = 9,
                    ItemName = "Large Drink",
                    ItemType = "Drink",
                    ItemPrice = 2.25m,
                    ItemQuantity = 1000
                }
                );
        }
    }
}
