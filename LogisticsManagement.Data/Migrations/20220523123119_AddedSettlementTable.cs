using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticsManagement.Data.Migrations
{
    public partial class AddedSettlementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settlements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettlementNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayrollStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayrollEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalDriverPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deductions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SettlementTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverInternalNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverSettlementNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    TruckId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    LoadId = table.Column<int>(type: "int", nullable: false),
                    BrokerId = table.Column<int>(type: "int", nullable: false),
                    DispatcherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settlements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Settlements_Brokers_BrokerId",
                        column: x => x.BrokerId,
                        principalTable: "Brokers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Settlements_Dispatchers_DispatcherId",
                        column: x => x.DispatcherId,
                        principalTable: "Dispatchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Settlements_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Settlements_Loads_LoadId",
                        column: x => x.LoadId,
                        principalTable: "Loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Settlements_Trailers_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Settlements_Trucks_TruckId",
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
                value: "7e31ab25-2153-4c49-9e8a-d95b3ae1f6b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "5023178c-0e88-42bc-ae4c-55ecafb24334");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a98663f-baa0-448d-8a26-7c6218a568d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b76614b-f110-44fb-9b3f-036b40dec8f0", "AQAAAAEAACcQAAAAENbdeUDdCtLVszXGzA6E/wDcSdInEEeMs0b9dlWSWNtxoSC1QgrgiAOzLr/o3/MFiw==", "2b8cf504-128c-48f6-b3fe-fb312b099a2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f0b1752-e546-4263-bc32-aa34263dd843", "AQAAAAEAACcQAAAAEO6Iph1ZMxJeE62NKZRNBY3r51zJS7RJRsQc48OSdHOOpEJS8XK9OwBSS4kP42VTUQ==", "afe57dd0-901d-4718-84e8-7110f766061f" });

            migrationBuilder.CreateIndex(
                name: "IX_Settlements_BrokerId",
                table: "Settlements",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_Settlements_DispatcherId",
                table: "Settlements",
                column: "DispatcherId");

            migrationBuilder.CreateIndex(
                name: "IX_Settlements_DriverId",
                table: "Settlements",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Settlements_LoadId",
                table: "Settlements",
                column: "LoadId");

            migrationBuilder.CreateIndex(
                name: "IX_Settlements_TrailerId",
                table: "Settlements",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Settlements_TruckId",
                table: "Settlements",
                column: "TruckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settlements");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c39c00-deb8-4e14-9482-7509a60ad573",
                column: "ConcurrencyStamp",
                value: "4734d6ba-1fe4-4414-992b-ab59cb158003");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "aa7c4188-2271-4a90-8f70-76a689cb3e70");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a98663f-baa0-448d-8a26-7c6218a568d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b7acd1-a362-4d01-8ddb-4f214497ca56", "AQAAAAEAACcQAAAAENCS5f0+sZVAUIJRKWmXSTUqEzpFHBbXRpu/s8rj5Ai9biY7JhlFnUkITGRqqwJaow==", "75618f2d-a595-404e-aeb5-29d9e475bdb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "545f8c69-7a9f-48ca-b47f-cc26afeb2e80", "AQAAAAEAACcQAAAAEKKwvLg39d+NB9Q9Il5+DUGW7Gq6gsfc0RW2Dc+NDfJQislVBSRd28rB9+mkiS+lSw==", "181307e2-6554-4e8f-ba54-e204ca2a9f90" });
        }
    }
}
