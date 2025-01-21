using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class _24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlotPayments",
                keyColumn: "ID",
                keyValue: 1);

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

            migrationBuilder.AddColumn<int>(
                name: "BuildingCost",
                table: "Plots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Equity",
                table: "Plots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ground",
                table: "Plots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagmentCost",
                table: "Plots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RelationshipCustomersPlots",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PlotID = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertUser = table.Column<int>(type: "int", nullable: false),
                    UpdateUser = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipCustomersPlots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RelationshipCustomersPlots_Plots_PlotID",
                        column: x => x.PlotID,
                        principalTable: "Plots",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelationshipCustomersPlots_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 49, DateTimeKind.Local).AddTicks(6447), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(3582), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(3596), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(3600), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(8010), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(8025), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(8029), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(8033), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9030), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9044), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9048), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(5773), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(6012), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(6841), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(6851), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9932), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9981), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9986), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9990), new DateTime(2025, 1, 21, 12, 18, 18, 52, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BuildingCost", "Equity", "Ground", "InsertDate", "ManagmentCost", "UpdateDate" },
                values: new object[] { 0, 0, 0, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(2454), 0, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "BuildingCost", "Equity", "Ground", "InsertDate", "ManagmentCost", "UpdateDate" },
                values: new object[] { 0, 0, 0, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(2586), 0, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BuildingCost", "Equity", "Ground", "InsertDate", "ManagmentCost", "UpdateDate" },
                values: new object[] { 0, 0, 0, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(2592), 0, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(9112), new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(7918), new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode", "VerificationCodeExpiry" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(9328), true, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(9331), "", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode", "VerificationCodeExpiry" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(5630), true, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(5639), "", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "IsVerified", "UpdateDate", "VerificationCode", "VerificationCodeExpiry" },
                values: new object[] { new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(5648), true, new DateTime(2025, 1, 21, 12, 18, 18, 53, DateTimeKind.Local).AddTicks(5649), "", null });

            migrationBuilder.CreateIndex(
                name: "IX_RelationshipCustomersPlots_PlotID",
                table: "RelationshipCustomersPlots",
                column: "PlotID");

            migrationBuilder.CreateIndex(
                name: "IX_RelationshipCustomersPlots_UserID",
                table: "RelationshipCustomersPlots",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelationshipCustomersPlots");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VerificationCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VerificationCodeExpiry",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BuildingCost",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "Equity",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "Ground",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "ManagmentCost",
                table: "Plots");

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 329, DateTimeKind.Local).AddTicks(4285), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3899), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3951), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3958), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8562), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8577), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8583), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8589), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9308), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9320), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9325), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataValue", "Datereference", "InsertDate", "LastPaymentDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(6401), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(6646), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(7359), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(7373), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(76), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(88), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(93), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(138), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(139) });

            migrationBuilder.InsertData(
                table: "PlotPayments",
                columns: new[] { "ID", "InsertDate", "InsertUser", "PaymentID", "PlotID", "State", "UpdateDate", "UpdateUser", "paymentStutusID" },
                values: new object[] { 1, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(7122), 1, 1, 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(7129), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1818), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1837), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1844), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(8152), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(6054), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(8373), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(3886), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "InsertDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(3905), new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(3907) });
        }
    }
}
