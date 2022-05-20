using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticsManagement.Data.Migrations
{
    public partial class DefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34c39c00-deb8-4e14-9482-7509a60ad573", "45abff3b-93f9-44c4-ad34-9a554646fe85", "User", "USER" },
                    { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "418a5b71-4c5f-492b-bf7c-2c8f3651862a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5a98663f-baa0-448d-8a26-7c6218a568d4", 0, "Major Key Trucking", "994a1743-7e85-438b-8b88-72f4e1191265", "admin@localhost.com", false, "Channing", "Robertson", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEF5t3krl5UT+VHLsfb+UP4xryLI50tdSYTmImesoJFUTZT1iPO5Q7UwKwmGE/iCQug==", "6013108018", false, "97e99cbd-1e69-4450-9ae8-bbd6f5316453", false, null },
                    { "94c39c00-deb8-4e14-9482-7509a60ad572", 0, "Major Key Trucking", "a19ef2c4-6857-4e34-9056-78c6cf39f0de", "user@localhost.com", false, "Kingston", "Robertson", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEH63Ia/8rgzTgWBskQayZyZJxXnVZs2PJGQ+rE9sh872cDqllQBr7K5uZnKYF5e1eA==", "6013108018", false, "14d1a509-b6b8-4631-ab7c-2c27fc0a0579", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "5a98663f-baa0-448d-8a26-7c6218a568d4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "34c39c00-deb8-4e14-9482-7509a60ad573", "94c39c00-deb8-4e14-9482-7509a60ad572" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "5a98663f-baa0-448d-8a26-7c6218a568d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34c39c00-deb8-4e14-9482-7509a60ad573", "94c39c00-deb8-4e14-9482-7509a60ad572" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c39c00-deb8-4e14-9482-7509a60ad573");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a98663f-baa0-448d-8a26-7c6218a568d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572");
        }
    }
}
