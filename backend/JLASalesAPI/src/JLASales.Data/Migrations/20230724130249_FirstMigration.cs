using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JLASales.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    MotorPower = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    ReleaseYear = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VendorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Neighbourhood = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VendorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleValue = table.Column<double>(type: "float", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Vehicles_VehicleId1",
                        column: x => x.VehicleId1,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sales_Vendors_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vendors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_VendorId",
                table: "Addresses",
                column: "VendorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_VehicleId",
                table: "Sales",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_VehicleId1",
                table: "Sales",
                column: "VehicleId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
