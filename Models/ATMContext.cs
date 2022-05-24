using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team4_Project.Models;

namespace Team4_Project.Models
{
    public class ATMContext : DbContext
    {
        public ATMContext(DbContextOptions<ATMContext> options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Order: Set Foreign Keys
            modelBuilder.Entity<Order>()
                .HasOne(e => e.Employee)
                .WithMany(o => o.Orders)
                .HasForeignKey(e => e.EmployeeID);
            modelBuilder.Entity<Order>()
                .HasOne(c => c.Customer)
                .WithMany(o => o.Orders)
                .HasForeignKey(c => c.CustomerID);
            
            //OrderDetail: Set Foreign Keys
            modelBuilder.Entity<OrderDetail>()
                .HasOne(o => o.Order)
                .WithMany(od => od.OrderDetails)
                .HasForeignKey(o => o.OrderID);
            modelBuilder.Entity<OrderDetail>()
                .HasOne(i => i.Item)
                .WithMany(od => od.OrderDetails)
                .HasForeignKey(i => i.ItemID);

            //Delete OrderDetails with Order
            modelBuilder.Entity<Order>()
                .HasMany(od => od.OrderDetails)
                .WithOne(o => o.Order)
                .OnDelete(DeleteBehavior.Cascade);

            //Seed Initial Data
            modelBuilder.ApplyConfiguration(new SeedCustomers());
            modelBuilder.ApplyConfiguration(new SeedEmployees());
            modelBuilder.ApplyConfiguration(new SeedInventory());
            modelBuilder.ApplyConfiguration(new SeedOrders());
            modelBuilder.ApplyConfiguration(new SeedOrderDetails());
        }
    }
}
