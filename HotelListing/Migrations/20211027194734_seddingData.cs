using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class seddingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76441e8f-3e98-4d08-9cd7-34b0de3a7d3f", "adb8b1b8-7601-4e8b-8d92-2f8f7a135a36", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6e82d57-b1d7-479a-9507-4bb7d2bb47f4", "d7a0264b-f2f4-451f-8816-56aa4d31c240", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76441e8f-3e98-4d08-9cd7-34b0de3a7d3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6e82d57-b1d7-479a-9507-4bb7d2bb47f4");
        }
    }
}
