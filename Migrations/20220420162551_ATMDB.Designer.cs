// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team4_Project.Models;

namespace Team4_Project.Migrations
{
    [DbContext(typeof(ATMContext))]
    [Migration("20220420162551_ATMDB")]
    partial class ATMDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Team4_Project.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ZipCode")
                        .HasColumnType("bigint");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            City = "Bryan",
                            Email = "johnsmith@example.com",
                            FirstName = "John",
                            LastName = "Smith",
                            Phone = 2815555555L,
                            State = "TX",
                            Street = "123 Aggie Street",
                            ZipCode = 77840L
                        },
                        new
                        {
                            CustomerID = 2,
                            City = "College Station",
                            Email = "jane.doe@example.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            Phone = 9795555555L,
                            State = "TX",
                            Street = "789 Texas Ave",
                            ZipCode = 77845L
                        });
                });

            modelBuilder.Entity("Team4_Project.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            FirstName = "Tanner",
                            LastName = "Croom",
                            Position = "System Admin"
                        },
                        new
                        {
                            EmployeeID = 2,
                            FirstName = "Eric",
                            LastName = "Franks",
                            Position = "System Admin"
                        },
                        new
                        {
                            EmployeeID = 3,
                            FirstName = "Cal",
                            LastName = "Furgal",
                            Position = "System Admin"
                        });
                });

            modelBuilder.Entity("Team4_Project.Models.Inventory", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ItemQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemID");

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            ItemID = 1,
                            ItemName = "Taco",
                            ItemPrice = 5.00m,
                            ItemQuantity = 999,
                            ItemType = "Entree"
                        },
                        new
                        {
                            ItemID = 2,
                            ItemName = "Burrito",
                            ItemPrice = 6.00m,
                            ItemQuantity = 1000,
                            ItemType = "Entree"
                        },
                        new
                        {
                            ItemID = 3,
                            ItemName = "Nachos",
                            ItemPrice = 5.50m,
                            ItemQuantity = 1000,
                            ItemType = "Entree"
                        },
                        new
                        {
                            ItemID = 4,
                            ItemName = "Enchilada",
                            ItemPrice = 6.50m,
                            ItemQuantity = 1000,
                            ItemType = "Entree"
                        },
                        new
                        {
                            ItemID = 5,
                            ItemName = "Churro",
                            ItemPrice = 2.75m,
                            ItemQuantity = 999,
                            ItemType = "Side"
                        },
                        new
                        {
                            ItemID = 6,
                            ItemName = "Quesadilla",
                            ItemPrice = 4.00m,
                            ItemQuantity = 1000,
                            ItemType = "Side"
                        },
                        new
                        {
                            ItemID = 7,
                            ItemName = "Chips & Dip",
                            ItemPrice = 3.75m,
                            ItemQuantity = 1000,
                            ItemType = "Side"
                        },
                        new
                        {
                            ItemID = 8,
                            ItemName = "Small Drink",
                            ItemPrice = 1.75m,
                            ItemQuantity = 999,
                            ItemType = "Drink"
                        },
                        new
                        {
                            ItemID = 9,
                            ItemName = "Large Drink",
                            ItemPrice = 2.25m,
                            ItemQuantity = 1000,
                            ItemType = "Drink"
                        });
                });

            modelBuilder.Entity("Team4_Project.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVV")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CardExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CardNumber")
                        .HasColumnType("bigint");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            CVV = 999,
                            CardExpirationDate = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CardName = "John Smith",
                            CardNumber = 1234123412341234L,
                            CustomerID = 1,
                            EmployeeID = 1,
                            OrderDate = new DateTime(2022, 4, 1, 11, 10, 54, 0, DateTimeKind.Unspecified),
                            PaymentType = "Credit Card",
                            Subtotal = 9.50m,
                            Tax = 0.83m,
                            Total = 10.33m
                        });
                });

            modelBuilder.Entity("Team4_Project.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderDetailSubtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("ItemID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetail");

                    b.HasData(
                        new
                        {
                            OrderDetailID = 1,
                            ItemID = 1,
                            OrderDetailSubtotal = 5.00m,
                            OrderID = 1,
                            OrderQuantity = 1
                        },
                        new
                        {
                            OrderDetailID = 2,
                            ItemID = 5,
                            OrderDetailSubtotal = 2.75m,
                            OrderID = 1,
                            OrderQuantity = 1
                        },
                        new
                        {
                            OrderDetailID = 3,
                            ItemID = 8,
                            OrderDetailSubtotal = 1.75m,
                            OrderID = 1,
                            OrderQuantity = 1
                        });
                });

            modelBuilder.Entity("Team4_Project.Models.Order", b =>
                {
                    b.HasOne("Team4_Project.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");

                    b.HasOne("Team4_Project.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Team4_Project.Models.OrderDetail", b =>
                {
                    b.HasOne("Team4_Project.Models.Inventory", "Item")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team4_Project.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
