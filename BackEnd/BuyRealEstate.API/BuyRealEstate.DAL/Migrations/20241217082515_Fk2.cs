using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Fk2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevelopmentStatuses_Projects_ProjectID",
                table: "DevelopmentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_LegalStatuses_Projects_ProjectID",
                table: "LegalStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentExecutionMethods_Payments_PaymentExecutionMethodID",
                table: "PaymentExecutionMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PlotPayments_PaymentStatuses_paymentStutusId",
                table: "PlotPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPayments_PaymentStatuses_paymentStutusId",
                table: "ProjectPayments");

            migrationBuilder.DropIndex(
                name: "IX_PaymentExecutionMethods_PaymentExecutionMethodID",
                table: "PaymentExecutionMethods");

            migrationBuilder.DropIndex(
                name: "IX_LegalStatuses_ProjectID",
                table: "LegalStatuses");

            migrationBuilder.DropIndex(
                name: "IX_DevelopmentStatuses_ProjectID",
                table: "DevelopmentStatuses");

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
                name: "Profession",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "WebsiteAddress",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "PaymentExecutionMethodID",
                table: "PaymentExecutionMethods");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DeveloperStatusID",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LegalStatusId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "PaymentExecutionMethodId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PaymentExecutionMethods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DeveloperStatusID",
                table: "Projects",
                column: "DeveloperStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_LegalStatusId",
                table: "Projects",
                column: "LegalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentExecutionMethodId",
                table: "Payments",
                column: "PaymentExecutionMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentExecutionMethods_PaymentExecutionMethodId",
                table: "Payments",
                column: "PaymentExecutionMethodId",
                principalTable: "PaymentExecutionMethods",
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
                name: "FK_Projects_DevelopmentStatuses_DeveloperStatusID",
                table: "Projects",
                column: "DeveloperStatusID",
                principalTable: "DevelopmentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_LegalStatuses_LegalStatusId",
                table: "Projects",
                column: "LegalStatusId",
                principalTable: "LegalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentExecutionMethods_PaymentExecutionMethodId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_PlotPayments_PaymentStatuses_paymentStutusId",
                table: "PlotPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPayments_PaymentStatuses_paymentStutusId",
                table: "ProjectPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_DevelopmentStatuses_DeveloperStatusID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_LegalStatuses_LegalStatusId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_DeveloperStatusID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_LegalStatusId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PaymentExecutionMethodId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DeveloperStatusID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "LegalStatusId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PaymentExecutionMethodId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PaymentExecutionMethods");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Documents");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebsiteAddress",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentExecutionMethodID",
                table: "PaymentExecutionMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_PaymentExecutionMethods_PaymentExecutionMethodID",
                table: "PaymentExecutionMethods",
                column: "PaymentExecutionMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_LegalStatuses_ProjectID",
                table: "LegalStatuses",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentStatuses_ProjectID",
                table: "DevelopmentStatuses",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_DevelopmentStatuses_Projects_ProjectID",
                table: "DevelopmentStatuses",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LegalStatuses_Projects_ProjectID",
                table: "LegalStatuses",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentExecutionMethods_Payments_PaymentExecutionMethodID",
                table: "PaymentExecutionMethods",
                column: "PaymentExecutionMethodID",
                principalTable: "Payments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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
        }
    }
}
