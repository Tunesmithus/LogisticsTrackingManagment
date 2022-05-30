using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticsManagement.Data.Migrations
{
    public partial class AddDeductionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Expenses");

            migrationBuilder.CreateTable(
                name: "Deductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfExpense = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Odometer = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenseTypeId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    LoadId = table.Column<int>(type: "int", nullable: false),
                    TruckId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deductions_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deductions_ExpenseTypes_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "ExpenseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deductions_Loads_LoadId",
                        column: x => x.LoadId,
                        principalTable: "Loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deductions_Trailers_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deductions_Trucks_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Trucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c39c00-deb8-4e14-9482-7509a60ad573",
                column: "ConcurrencyStamp",
                value: "563ec0c1-ed40-428d-bb33-4f3407408849");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "d3ad896b-f9e2-4e4a-9dfa-cbf71a4e3346");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a98663f-baa0-448d-8a26-7c6218a568d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7af62c3-fe1d-4b99-b8a0-b8a4c041f104", "AQAAAAEAACcQAAAAEBvOqNFKMNln8sI9n+4sgBxHCj+5+O9OL2ZZ96hGbG5YgxzTeXyd+lXVIZooP/ziMA==", "bea41ac6-d286-4a58-a92b-d114ee63f3a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17eaafad-9473-4d81-b72c-18c1ae220d2d", "AQAAAAEAACcQAAAAEP4LnPfH6PuKUtfzRZQKLFq9R39rZkv25Z8kW4JDjCQudR09gV6/AqLAlhPSVrVN4g==", "c8066a93-9f44-4b97-bf4e-9c8de81a4e2f" });

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_DriverId",
                table: "Deductions",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_ExpenseTypeId",
                table: "Deductions",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_LoadId",
                table: "Deductions",
                column: "LoadId");

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_TrailerId",
                table: "Deductions",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deductions_TruckId",
                table: "Deductions",
                column: "TruckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deductions");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c39c00-deb8-4e14-9482-7509a60ad573",
                column: "ConcurrencyStamp",
                value: "c63dfb4f-a846-4635-b1a1-8c3d197878e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "047fc18d-3f4f-403b-982c-e7e79477099d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a98663f-baa0-448d-8a26-7c6218a568d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc74d961-c771-4d7e-b5df-ef1e4887e167", "AQAAAAEAACcQAAAAEGbUTLNKguxKfdScfIwwPEc1lhFyMWP54MycsMPNAXBcev+J175kcIO3zHYbdianEA==", "991f60ec-af8b-43c6-b549-74ed134f47d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7594bd8-6f39-421c-8ed9-184fdcf5b2ab", "AQAAAAEAACcQAAAAEGXD4DFm1d5ESutrtfKU868exQCiqQJaZeIfKrYPx8MGZiDHqWzdAqwIStZBW55V3g==", "200f35bd-fe89-418c-b94b-a302558c8303" });
        }
    }
}
