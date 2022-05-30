using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticsManagement.Data.Migrations
{
    public partial class ChangedExpenseTableColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpenseCategoryId",
                table: "Expenses");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpenseCategoryId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c39c00-deb8-4e14-9482-7509a60ad573",
                column: "ConcurrencyStamp",
                value: "054b0aef-6fdb-4cef-91fd-44fd9f1cb299");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "39f78539-eda3-425e-96d6-41a35470c149");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a98663f-baa0-448d-8a26-7c6218a568d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cb3077b-d5a0-46a0-bdcf-9a3bdf98f952", "AQAAAAEAACcQAAAAEFXmSYaTssPonzlFysTUQrrWlxi1oq82rJrDK+r/xt1LKF8CER5oErxrrjZOj/Q5bw==", "21e9eb4d-9fa8-4923-8982-7d89d0b81b5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ee7fe54-09c8-4871-825d-a9c45b2ac702", "AQAAAAEAACcQAAAAEDUfMsdbEeyWGXN+3dbMb+shq2/tZIZHPxHm4HmXGxXVI0Znud+CbWsHd6poWw5QDA==", "1b1504d1-e7dd-4c4b-a96b-1deaea9c981f" });
        }
    }
}
