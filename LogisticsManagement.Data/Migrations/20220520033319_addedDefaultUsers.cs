using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticsManagement.Data.Migrations
{
    public partial class addedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b7acd1-a362-4d01-8ddb-4f214497ca56", true, "AQAAAAEAACcQAAAAENCS5f0+sZVAUIJRKWmXSTUqEzpFHBbXRpu/s8rj5Ai9biY7JhlFnUkITGRqqwJaow==", "75618f2d-a595-404e-aeb5-29d9e475bdb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "545f8c69-7a9f-48ca-b47f-cc26afeb2e80", true, "AQAAAAEAACcQAAAAEKKwvLg39d+NB9Q9Il5+DUGW7Gq6gsfc0RW2Dc+NDfJQislVBSRd28rB9+mkiS+lSw==", "181307e2-6554-4e8f-ba54-e204ca2a9f90" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c39c00-deb8-4e14-9482-7509a60ad573",
                column: "ConcurrencyStamp",
                value: "45abff3b-93f9-44c4-ad34-9a554646fe85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "418a5b71-4c5f-492b-bf7c-2c8f3651862a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a98663f-baa0-448d-8a26-7c6218a568d4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "994a1743-7e85-438b-8b88-72f4e1191265", false, "AQAAAAEAACcQAAAAEF5t3krl5UT+VHLsfb+UP4xryLI50tdSYTmImesoJFUTZT1iPO5Q7UwKwmGE/iCQug==", "97e99cbd-1e69-4450-9ae8-bbd6f5316453" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a19ef2c4-6857-4e34-9056-78c6cf39f0de", false, "AQAAAAEAACcQAAAAEH63Ia/8rgzTgWBskQayZyZJxXnVZs2PJGQ+rE9sh872cDqllQBr7K5uZnKYF5e1eA==", "14d1a509-b6b8-4631-ab7c-2c27fc0a0579" });
        }
    }
}
