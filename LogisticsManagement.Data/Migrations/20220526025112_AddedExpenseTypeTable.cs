using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticsManagement.Data.Migrations
{
    public partial class AddedExpenseTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34c39c00-deb8-4e14-9482-7509a60ad573",
                column: "ConcurrencyStamp",
                value: "7ad58239-e7db-4880-bb4f-fed737a94a64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "56da0918-8021-4892-a68f-479c615e03e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a98663f-baa0-448d-8a26-7c6218a568d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f931ea74-8f75-4c8c-8d88-83ed121e80a3", "AQAAAAEAACcQAAAAEGHf0D2f7CO/zQqdUTRzhu+mnwgTlghhldqY0NOpsxD8zLcRnDsI7h7QsSWrZE4hGg==", "fbafdbc3-5a6b-49a3-a4b4-a104f5e7b03b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94c39c00-deb8-4e14-9482-7509a60ad572",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1317def-1214-4990-aa8d-942cca78f784", "AQAAAAEAACcQAAAAEFpn+LWxLiX6yxUz4Rn/J8hnYP1ozWhXzw6/cQpXYQcapY18/jDuleHI57z2Fm376g==", "52f2a371-c261-4441-beea-6164413bf5e8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseTypes");

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
        }
    }
}
