using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Team4_Project.Models;

namespace Team4_Project.Models
{
    internal class SeedCustomers : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity.HasData(
                new Customer { CustomerID = 1, FirstName = "John", LastName = "Smith",
                    Street = "123 Aggie Street", City = "Bryan", State = "TX", ZipCode = 77840,
                    Phone = 2815555555, Email = "johnsmith@example.com" },
                new Customer { CustomerID = 2, FirstName = "Jane", LastName = "Doe",
                    Street = "789 Texas Ave", City = "College Station", State = "TX", ZipCode = 77845, 
                    Phone = 9795555555, Email = "jane.doe@example.com"
                }
                );
        }
    }
}
