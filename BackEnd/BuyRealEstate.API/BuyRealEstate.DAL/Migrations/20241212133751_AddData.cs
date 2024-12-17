using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatuses_Payments_PaymentId",
                table: "PaymentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_PlotPayments_PaymentStatuses_paymentStutusId",
                table: "PlotPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPayments_PaymentStatuses_paymentStutusId",
                table: "ProjectPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ProjectManagerID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Permissions_PermissionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PermissionId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectManagerID",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "paymentStutusId",
                table: "ProjectPayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "paymentStutusId",
                table: "PlotPayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "InsertUser",
                table: "Permissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdateUser",
                table: "Permissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WebsiteAddress",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "PaymentStatuses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastPaymentDate",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "PaymentStatuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "PaymentId", "State", "Status", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 15, 37, 50, 806, DateTimeKind.Local).AddTicks(4029), 1, null, true, "לא שולם", new DateTime(2024, 12, 12, 15, 37, 50, 807, DateTimeKind.Local).AddTicks(6560), 1 },
                    { 2, new DateTime(2024, 12, 12, 15, 37, 50, 807, DateTimeKind.Local).AddTicks(7058), 1, null, true, "מחכה לאישור", new DateTime(2024, 12, 12, 15, 37, 50, 807, DateTimeKind.Local).AddTicks(7062), 1 },
                    { 3, new DateTime(2024, 12, 12, 15, 37, 50, 807, DateTimeKind.Local).AddTicks(7064), 1, null, true, "שולם", new DateTime(2024, 12, 12, 15, 37, 50, 807, DateTimeKind.Local).AddTicks(7065), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Discriminator", "Email", "FirstName", "InsertDate", "InsertUser", "LastName", "Password", "PermissionId", "Phone", "State", "UpdateDate", "UpdateUser", "Username" },
                values: new object[,]
                {
                    { 1, "Users", "chayamalot@gmail.com", "חיה", new DateTime(2024, 12, 12, 15, 37, 50, 808, DateTimeKind.Local).AddTicks(1188), 1, "ברנדויין", "cb5328152", 1, "0504101585", true, new DateTime(2024, 12, 12, 15, 37, 50, 808, DateTimeKind.Local).AddTicks(1196), 1, "ChayaBrandwian" },
                    { 2, "Users", "nihul@efshar-nadlan.co.il", "ברכה", new DateTime(2024, 12, 12, 15, 37, 50, 808, DateTimeKind.Local).AddTicks(1340), 1, "וינבאום", "BrachaVinbaum", 1, "0527648861", true, new DateTime(2024, 12, 12, 15, 37, 50, 808, DateTimeKind.Local).AddTicks(1342), 1, "ChayaBrandwian" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatuses_Payments_PaymentId",
                table: "PaymentStatuses",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlotPayments_PaymentStatuses_paymentStutusId",
                table: "PlotPayments",
                column: "paymentStutusId",
                principalTable: "PaymentStatuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPayments_PaymentStatuses_paymentStutusId",
                table: "ProjectPayments",
                column: "paymentStutusId",
                principalTable: "PaymentStatuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_ProjectManagerID",
                table: "Projects",
                column: "ProjectManagerID",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatuses_Payments_PaymentId",
                table: "PaymentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_PlotPayments_PaymentStatuses_paymentStutusId",
                table: "PlotPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPayments_PaymentStatuses_paymentStutusId",
                table: "ProjectPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ProjectManagerID",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "WebsiteAddress",
                table: "Permissions");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectManagerID",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "paymentStutusId",
                table: "ProjectPayments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "paymentStutusId",
                table: "PlotPayments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "PaymentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastPaymentDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermissionId",
                table: "Users",
                column: "PermissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatuses_Payments_PaymentId",
                table: "PaymentStatuses",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlotPayments_PaymentStatuses_paymentStutusId",
                table: "PlotPayments",
                column: "paymentStutusId",
                principalTable: "PaymentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPayments_PaymentStatuses_paymentStutusId",
                table: "ProjectPayments",
                column: "paymentStutusId",
                principalTable: "PaymentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_ProjectManagerID",
                table: "Projects",
                column: "ProjectManagerID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Permissions_PermissionId",
                table: "Users",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
