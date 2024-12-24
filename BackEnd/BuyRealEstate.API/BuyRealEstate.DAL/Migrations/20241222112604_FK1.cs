using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class FK1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PermissionId1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermissionId1",
                table: "Users",
                column: "PermissionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Permissions_PermissionId1",
                table: "Users",
                column: "PermissionId1",
                principalTable: "Permissions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Permissions_PermissionId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PermissionId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PermissionId1",
                table: "Users");
        }
    }
}
