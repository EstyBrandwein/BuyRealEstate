using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class UserUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "VerificationCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 60, DateTimeKind.Local).AddTicks(4477), new DateTime(2025, 1, 16, 12, 42, 21, 62, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 62, DateTimeKind.Local).AddTicks(7167), new DateTime(2025, 1, 16, 12, 42, 21, 62, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 62, DateTimeKind.Local).AddTicks(8927), new DateTime(2025, 1, 16, 12, 42, 21, 62, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(4373), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(5854), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(7644), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(7667), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(7672), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(7676), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(198), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(204), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(208), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(212), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(604), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(609), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(613), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(8870), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(9081), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(9613), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(9618), new DateTime(2025, 1, 16, 12, 42, 21, 63, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(1000), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(1021), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(1025), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(1029), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "PlotPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(5101), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(2040), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(2048), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(2053), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(5615), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(4524), new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(5717), true, new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(5718), "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(3512), true, new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(3514), "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(3520), true, new DateTime(2025, 1, 16, 12, 42, 21, 64, DateTimeKind.Local).AddTicks(3522), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VerificationCode",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 694, DateTimeKind.Local).AddTicks(2641), new DateTime(2025, 1, 15, 15, 38, 32, 696, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 696, DateTimeKind.Local).AddTicks(4499), new DateTime(2025, 1, 15, 15, 38, 32, 696, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 696, DateTimeKind.Local).AddTicks(6052), new DateTime(2025, 1, 15, 15, 38, 32, 696, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(2460), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(4391), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(6743), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(6772), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(6778), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(6784), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(1155), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(1173), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(1178), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(1184), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2028), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2041), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2046), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(8612), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(8854), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(9977), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(9997), new DateTime(2025, 1, 15, 15, 38, 32, 697, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2830), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2844), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2851), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2857), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "PlotPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(9991), new DateTime(2025, 1, 15, 15, 38, 32, 699, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(4593), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(4612), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(4620), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 699, DateTimeKind.Local).AddTicks(1052), new DateTime(2025, 1, 15, 15, 38, 32, 699, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(8666), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 699, DateTimeKind.Local).AddTicks(1280), new DateTime(2025, 1, 15, 15, 38, 32, 699, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(6854), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(6877), new DateTime(2025, 1, 15, 15, 38, 32, 698, DateTimeKind.Local).AddTicks(6879) });
        }
    }
}
