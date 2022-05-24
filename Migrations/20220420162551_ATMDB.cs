using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team4_Project.Migrations
{
    public partial class ATMDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ZipCode = table.Column<long>(nullable: false),
                    Phone = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(nullable: false),
                    ItemType = table.Column<string>(nullable: false),
                    ItemPrice = table.Column<decimal>(nullable: false),
                    ItemQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<string>(nullable: false),
                    CardName = table.Column<string>(nullable: true),
                    CardNumber = table.Column<long>(nullable: true),
                    CVV = table.Column<int>(nullable: true),
                    CardExpirationDate = table.Column<DateTime>(nullable: true),
                    Subtotal = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(nullable: true),
                    ItemID = table.Column<int>(nullable: false),
                    OrderQuantity = table.Column<int>(nullable: false),
                    OrderDetailSubtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Inventory_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Inventory",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "City", "Email", "FirstName", "LastName", "Phone", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Bryan", "johnsmith@example.com", "John", "Smith", 2815555555L, "TX", "123 Aggie Street", 77840L },
                    { 2, "College Station", "jane.doe@example.com", "Jane", "Doe", 9795555555L, "TX", "789 Texas Ave", 77845L }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { 1, "Tanner", "Croom", "System Admin" },
                    { 2, "Eric", "Franks", "System Admin" },
                    { 3, "Cal", "Furgal", "System Admin" }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "ItemID", "ItemName", "ItemPrice", "ItemQuantity", "ItemType" },
                values: new object[,]
                {
                    { 1, "Taco", 5.00m, 999, "Entree" },
                    { 2, "Burrito", 6.00m, 1000, "Entree" },
                    { 3, "Nachos", 5.50m, 1000, "Entree" },
                    { 4, "Enchilada", 6.50m, 1000, "Entree" },
                    { 5, "Churro", 2.75m, 999, "Side" },
                    { 6, "Quesadilla", 4.00m, 1000, "Side" },
                    { 7, "Chips & Dip", 3.75m, 1000, "Side" },
                    { 8, "Small Drink", 1.75m, 999, "Drink" },
                    { 9, "Large Drink", 2.25m, 1000, "Drink" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CVV", "CardExpirationDate", "CardName", "CardNumber", "CustomerID", "EmployeeID", "OrderDate", "PaymentType", "Subtotal", "Tax", "Total" },
                values: new object[] { 1, 999, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Smith", 1234123412341234L, 1, 1, new DateTime(2022, 4, 1, 11, 10, 54, 0, DateTimeKind.Unspecified), "Credit Card", 9.50m, 0.83m, 10.33m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "ItemID", "OrderDetailSubtotal", "OrderID", "OrderQuantity" },
                values: new object[] { 1, 1, 5.00m, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "ItemID", "OrderDetailSubtotal", "OrderID", "OrderQuantity" },
                values: new object[] { 2, 5, 2.75m, 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailID", "ItemID", "OrderDetailSubtotal", "OrderID", "OrderQuantity" },
                values: new object[] { 3, 8, 1.75m, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeID",
                table: "Order",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ItemID",
                table: "OrderDetail",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
