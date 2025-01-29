using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Guarantees1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerPlots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(9498), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DocumentDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "הודעה על נאמנות שמחי", new DateTime(2025, 1, 28, 12, 0, 23, 101, DateTimeKind.Local).AddTicks(488), new DateTime(2025, 1, 28, 12, 0, 23, 103, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DocumentDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "אישור ניהול חשבון", new DateTime(2025, 1, 28, 12, 0, 23, 104, DateTimeKind.Local).AddTicks(2018), new DateTime(2025, 1, 28, 12, 0, 23, 104, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DocumentDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "אישור נאמן לצורך העברת כספים", new DateTime(2025, 1, 28, 12, 0, 23, 104, DateTimeKind.Local).AddTicks(3435), new DateTime(2025, 1, 28, 12, 0, 23, 104, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DocumentDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "אישור ניהול חשבון", new DateTime(2025, 1, 28, 12, 0, 23, 104, DateTimeKind.Local).AddTicks(7622), new DateTime(2025, 1, 28, 12, 0, 23, 104, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.InsertData(
                table: "Guarantees",
                columns: new[] { "Id", "Amount", "DateOfPayment", "GuaranteeUssued", "InsertDate", "InsertUser", "IsPaid", "Note", "State", "UpdateDate", "UpdateUser", "VoucherNumber" },
                values: new object[,]
                {
                    { 1, 87643, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(2454), true, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(3312), 1, false, "עוד לא שולם", true, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(3319), 1, 4 },
                    { 2, 673829, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(3323), false, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(3325), 1, false, "עוד לא שולם", true, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(3326), 1, 1 },
                    { 3, 3572, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(3328), true, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(3330), 1, true, "שולם", true, new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(3331), 1, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ImageDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "מיגרשים", new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(257), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ImageDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "הבית שלך", new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(2069), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ImageDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "המגרש שלך", new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(3022), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ImageDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "חירן", new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(4105), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(6454), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(6469), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(6473), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(6476), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(518), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(531), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(534), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(537), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(1341), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(1354), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(1357), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(8514), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(8733), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9449), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9459), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9651), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9657), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9659), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9662), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9665), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9667), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9668), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9671), new DateTime(2025, 1, 28, 12, 0, 23, 105, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(2193), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(2196), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(2200), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "PlotPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(473), new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(4057), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(4071), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(4100), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(1582), new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(8608), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(1774), new DateTime(2025, 1, 28, 12, 0, 23, 107, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(6751), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(6768), new DateTime(2025, 1, 28, 12, 0, 23, 106, DateTimeKind.Local).AddTicks(6769) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guarantees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guarantees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guarantees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CustomerPlots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 483, DateTimeKind.Local).AddTicks(447), new DateTime(2025, 1, 28, 11, 44, 16, 483, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DocumentDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "תעודת זהות", new DateTime(2025, 1, 28, 11, 44, 16, 475, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 1, 28, 11, 44, 16, 477, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DocumentDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "תעודת זהות", new DateTime(2025, 1, 28, 11, 44, 16, 479, DateTimeKind.Local).AddTicks(3783), new DateTime(2025, 1, 28, 11, 44, 16, 479, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DocumentDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "תעודת זהות", new DateTime(2025, 1, 28, 11, 44, 16, 479, DateTimeKind.Local).AddTicks(7407), new DateTime(2025, 1, 28, 11, 44, 16, 479, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DocumentDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "תעודת זהות", new DateTime(2025, 1, 28, 11, 44, 16, 480, DateTimeKind.Local).AddTicks(1688), new DateTime(2025, 1, 28, 11, 44, 16, 480, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ImageDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "תמונה", new DateTime(2025, 1, 28, 11, 44, 16, 480, DateTimeKind.Local).AddTicks(7354), new DateTime(2025, 1, 28, 11, 44, 16, 480, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ImageDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "תמונה", new DateTime(2025, 1, 28, 11, 44, 16, 480, DateTimeKind.Local).AddTicks(9855), new DateTime(2025, 1, 28, 11, 44, 16, 480, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ImageDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "תמונה", new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(1066), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ImageDescription", "InsertDate", "UpdateDate" },
                values: new object[] { "תמונה", new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(1920), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(6534), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(6553), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(6557), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(6560), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(789), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(804), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(808), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(811), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(1607), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(1622), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(1625), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(8588), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(8815), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9675), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9688), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9891), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9897), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9898), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9902), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9904), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9906), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9907), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9910), new DateTime(2025, 1, 28, 11, 44, 16, 481, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(2405), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(2419), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(2422), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(2426), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "PlotPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 483, DateTimeKind.Local).AddTicks(1612), new DateTime(2025, 1, 28, 11, 44, 16, 483, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(4363), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(4379), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(4412), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 483, DateTimeKind.Local).AddTicks(2823), new DateTime(2025, 1, 28, 11, 44, 16, 483, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(9397), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 483, DateTimeKind.Local).AddTicks(3047), new DateTime(2025, 1, 28, 11, 44, 16, 483, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(7335), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(7354), new DateTime(2025, 1, 28, 11, 44, 16, 482, DateTimeKind.Local).AddTicks(7356) });
        }
    }
}
