using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47973a81-534e-4b5a-b582-10aeb013f20d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba9797a3-1148-4a09-9268-5cc3b43fbbc9", "d9974e1c-bfa2-4e15-b839-55270fe8a07b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d57a1ad9-d7f1-430f-98a6-b3a1263d0c01", "c47027c8-8ec1-48f5-844b-1da965a32a98", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f2ede7e-d6fb-4a9d-ac8b-56a73e0a6d1e", "7fa477b3-f5c0-4462-83d9-1d23b3282917", "Coach", "COACH" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f2ede7e-d6fb-4a9d-ac8b-56a73e0a6d1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba9797a3-1148-4a09-9268-5cc3b43fbbc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d57a1ad9-d7f1-430f-98a6-b3a1263d0c01");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47973a81-534e-4b5a-b582-10aeb013f20d", "86b095b1-ca6e-4ae2-8693-86d760f2b180", "Admin", "ADMIN" });
        }
    }
}
