using Microsoft.EntityFrameworkCore.Migrations;

namespace User_Role_WebAPI.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "Role" },
                values: new object[,]
                {
                    { 1, "Manager" },
                    { 2, "Developer" },
                    { 3, "Tester" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "FullName", "UserName" },
                values: new object[,]
                {
                    { 1, "Pradip Lanke", "Pradip" },
                    { 2, "Ram Kale", "Ram" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
