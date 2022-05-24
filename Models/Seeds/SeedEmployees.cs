using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Team4_Project.Models;

namespace Team4_Project.Models
{
    internal class SeedEmployees : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasData(
                new Employee { EmployeeID = 1, FirstName = "Tanner", LastName = "Croom", Position = "System Admin"},
                new Employee { EmployeeID = 2, FirstName = "Eric", LastName = "Franks", Position = "System Admin" },
                new Employee { EmployeeID = 3, FirstName = "Cal", LastName = "Furgal", Position = "System Admin" }
                );
        }
    }
}
