﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class D : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "ID", "DocumentData", "DocumentDescription", "FileType", "InsertDate", "InsertUser", "PamentID", "ProjectID", "State", "UpdateDate", "UpdateUser", "UserId" },

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 661, DateTimeKind.Local).AddTicks(816), new DateTime(2025, 1, 15, 12, 35, 42, 664, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 664, DateTimeKind.Local).AddTicks(6594), new DateTime(2025, 1, 15, 12, 35, 42, 664, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(292), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(1757), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(3770), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(3799), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(3835), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(3841), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(7370), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(7382), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(7389), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(7395), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8044), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8052), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8058), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(5474), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(5686), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(6365), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(6373), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8682), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8691), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8697), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8724), new DateTime(2025, 1, 15, 12, 35, 42, 665, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "PlotPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(5005), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(331), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(343), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(352), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(5924), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(4021), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(6097), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(2369), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(2383), new DateTime(2025, 1, 15, 12, 35, 42, 666, DateTimeKind.Local).AddTicks(2385) });
        }
    }
}