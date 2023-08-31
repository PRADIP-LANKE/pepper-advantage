using Microsoft.EntityFrameworkCore.Migrations;

namespace User_Role_WebAPI.Migrations
{
    public partial class UsersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RolesID",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_UserID",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RolesID",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "RolesID",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "UserRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RolesID",
                table: "UserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "UserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RolesID",
                table: "UserRoles",
                column: "RolesID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RolesID",
                table: "UserRoles",
                column: "RolesID",
                principalTable: "Roles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_UserID",
                table: "UserRoles",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
