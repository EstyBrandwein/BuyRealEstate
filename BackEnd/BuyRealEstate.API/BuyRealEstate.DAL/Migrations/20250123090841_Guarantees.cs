using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Guarantees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VerificationCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VerificationCodeExpiry",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Guarantees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoucherNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    GuaranteeUssued = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guarantees", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 979, DateTimeKind.Local).AddTicks(5553), new DateTime(2025, 1, 23, 11, 8, 39, 981, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(1748), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.InsertData(
                table: "Guarantees",
                columns: new[] { "Id", "Amount", "DateOfPayment", "GuaranteeUssued", "InsertDate", "InsertUser", "IsPaid", "Note", "State", "UpdateDate", "UpdateUser", "VoucherNumber" },
                values: new object[] { 1, 200, new DateTime(2025, 1, 23, 11, 8, 39, 984, DateTimeKind.Local).AddTicks(1186), true, new DateTime(2025, 1, 23, 11, 8, 39, 984, DateTimeKind.Local).AddTicks(2171), 1, true, "תשלום עתידי", true, new DateTime(2025, 1, 23, 11, 8, 39, 984, DateTimeKind.Local).AddTicks(2179), 1, 100171001 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(3754), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(5004), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(6753), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(6769), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(6799), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(6803), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(770), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(784), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(787), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(791), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(1607), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(1611), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(8629), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(8852), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(9604), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(9614), new DateTime(2025, 1, 23, 11, 8, 39, 982, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(2420), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(2432), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(2435), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(2467), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(4430), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(4447), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(4451), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 984, DateTimeKind.Local).AddTicks(179), new DateTime(2025, 1, 23, 11, 8, 39, 984, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(9088), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 984, DateTimeKind.Local).AddTicks(372), new DateTime(2025, 1, 23, 11, 8, 39, 984, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(7022), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 1, 23, 11, 8, 39, 983, DateTimeKind.Local).AddTicks(7039) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guarantees");

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

            migrationBuilder.AddColumn<DateTime>(
                name: "VerificationCodeExpiry",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 610, DateTimeKind.Local).AddTicks(8419), new DateTime(2025, 1, 22, 13, 1, 18, 613, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 613, DateTimeKind.Local).AddTicks(7486), new DateTime(2025, 1, 22, 13, 1, 18, 613, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(142), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(1454), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(3045), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(3059), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(3063), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(3066), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(6845), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(6859), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(6862), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(6865), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(7622), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(7634), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(4914), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(5153), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(5872), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(5882), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(8411), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(8424), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(8427), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(8430), new DateTime(2025, 1, 22, 13, 1, 18, 614, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(309), new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(324), new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(328), new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(6037), new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(5017), new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode", "VerificationCodeExpiry" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(6225), true, new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(6228), "", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode", "VerificationCodeExpiry" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(2967), true, new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(2978), "", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode", "VerificationCodeExpiry" },
                values: new object[] { new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(3047), true, new DateTime(2025, 1, 22, 13, 1, 18, 615, DateTimeKind.Local).AddTicks(3049), "", null });
        }
    }
}
