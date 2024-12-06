using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastRental = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustId);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InvId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genera = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Studio = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.InvId);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    RentalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckedIn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustId = table.Column<int>(type: "int", nullable: false),
                    InventoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.RentalId);
                });

            migrationBuilder.CreateTable(
                name: "CustComments",
                columns: table => new
                {
                    CustCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustId = table.Column<int>(type: "int", nullable: false),
                    CustComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerCustId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustComments", x => x.CustCommentId);
                    table.ForeignKey(
                        name: "FK_CustComments_Customers_CustomerCustId",
                        column: x => x.CustomerCustId,
                        principalTable: "Customers",
                        principalColumn: "CustId");
                });

            migrationBuilder.CreateTable(
                name: "InvComments",
                columns: table => new
                {
                    InvCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvId = table.Column<int>(type: "int", nullable: false),
                    InventoryInvId = table.Column<int>(type: "int", nullable: true),
                    Entered = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvComments", x => x.InvCommentId);
                    table.ForeignKey(
                        name: "FK_InvComments_Inventory_InventoryInvId",
                        column: x => x.InventoryInvId,
                        principalTable: "Inventory",
                        principalColumn: "InvId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustComments_CustomerCustId",
                table: "CustComments",
                column: "CustomerCustId");

            migrationBuilder.CreateIndex(
                name: "IX_InvComments_InventoryInvId",
                table: "InvComments",
                column: "InventoryInvId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustComments");

            migrationBuilder.DropTable(
                name: "InvComments");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
