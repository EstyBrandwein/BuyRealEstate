using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuyRealEstate.Domain.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DevelopmentStatuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "ProjectID", "State", "Status", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "הפיתוח בעיצומו", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "הפיתוח הושלם", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "LegalStatuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "ProjectID", "State", "Status", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 8, 13, 25, 12, 329, DateTimeKind.Local).AddTicks(4285), 1, 0, true, "בשלבי רכישה", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(2925), 1 },
                    { 2, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3899), 1, 0, true, "הושלמה על שם הנאמן", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3917), 1 },
                    { 3, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3951), 1, 0, true, "בתהליכי רישום ברשות המיסים", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3954), 1 },
                    { 4, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3958), 1, 0, true, "העסקה רשומה על שימכם", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(3960), 1 }
                });

            migrationBuilder.InsertData(
                table: "PaymentExecutionMethods",
                columns: new[] { "ID", "Description", "InsertDate", "InsertUser", "State", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, "אשראי", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8562), 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8571), 1 },
                    { 2, "העברה בנקאית", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8577), 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8579), 1 },
                    { 3, "ציק", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8583), 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8586), 1 },
                    { 4, "מזומן", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8589), 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(8592), 1 }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatuses",
                columns: new[] { "Id", "InsertDate", "InsertUser", "State", "Status", "UpdateDate", "UpdateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9308), 1, true, "לא שולם", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9316), 1 },
                    { 2, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9320), 1, true, "מחכה לאישור", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9322), 1 },
                    { 3, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9325), 1, true, "שולם", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(9327), 1 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "InsertDate", "InsertUser", "State", "UpdateDate", "UpdateUser", "permission" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(76), 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(83), 1, "מנהל" },
                    { 2, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(88), 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(90), 1, "מזכירה" },
                    { 3, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(93), 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(133), 1, "לקוח" },
                    { 4, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(138), 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(139), 1, "איש קשר" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Discriminator", "Email", "FirstName", "FirstPhone", "InsertDate", "InsertUser", "LastName", "Password", "PermissionId", "SecendPhon", "State", "UpdateDate", "UpdateUser", "Username" },
                values: new object[] { 1, "User", "chayamalot@gmail.com", "חיה", "0504101585", new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(8373), 1, "ברנדויין", "CB5328152", 1, null, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(8377), 1, "ChayaB" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Discriminator", "Email", "FirstName", "FirstPhone", "InsertDate", "InsertUser", "LastName", "Password", "PermissionId", "Professtion", "SecendPhon", "State", "UpdateDate", "UpdateUser", "Username", "WebsiteAddress" },
                values: new object[,]
                {
                    { 4, "Professional", "ghj@hjj", "רשות", "050141155", new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(3886), 1, "המיסים", "123456", 4, "מיסים", null, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(3896), 1, "רשות המיסים", "https://www.efshar-nadlan.co.il" },
                    { 5, "Professional", "royi@grilak", "רועי", "0556565626", new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(3905), 1, "גרילק", "123456", 4, "עריכת דין", null, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(3907), 1, "עורך דין", "" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Amount", "DataValue", "Datereference", "Detiels", "HNagainst", "InsertDate", "InsertUser", "LastPaymentDate", "PaymentExecutionMethodID", "PaymentStatusId", "ProfessionalId", "State", "Surplus", "Title", "UpdateDate", "UpdateUser", "dose", "movement" },
                values: new object[] { 1, 360000.0, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(6401), new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(6646), "hello", "", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(7359), 1, new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(7373), 1, 1, 4, true, 12000, "רשות המיסים", new DateTime(2025, 1, 8, 13, 25, 12, 331, DateTimeKind.Local).AddTicks(7369), 1, "", "" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "DeveloperStatusID", "GrossProfit", "InsertDate", "InsertUser", "LegalStatusId", "LinkToLead2", "ProjectAddress", "ProjectManagerID", "ProjectName", "ProjectType", "State", "UpdateDate", "UpdateUser" },
                values: new object[] { 1, 1, 12000.0, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(6054), 1, 1, "https://www.efshar-nadlan.co.il/", "כרמית", 1, "כרמית 11", true, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(6069), 1 });

            migrationBuilder.InsertData(
                table: "Plots",
                columns: new[] { "ID", "InsertDate", "InsertUser", "MonthlyFundingCost", "MonthsForFundingCost", "PlotCost", "PlotNumber", "PlotSize", "PlotValue", "ProjectId", "State", "UpdateDate", "UpdateUser", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1818), 1, 10000.0, 10, 580000, 12, 120.0, 600000.0, 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1828), 1, 1 },
                    { 2, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1837), 1, 10000.0, 10, 580000, 11, 138.0, 600000.0, 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1839), 1, 1 },
                    { 3, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1844), 1, 10000.0, 10, 580000, 13, 110.0, 600000.0, 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(1846), 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProjectPayments",
                columns: new[] { "ID", "InsertDate", "InsertUser", "PaymentID", "ProjectID", "State", "UpdateDate", "UpdateUser", "paymentStutusID" },
                values: new object[] { 1, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(8152), 1, 1, 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(8159), 1, 1 });

            migrationBuilder.InsertData(
                table: "PlotPayments",
                columns: new[] { "ID", "InsertDate", "InsertUser", "PaymentID", "PlotID", "State", "UpdateDate", "UpdateUser", "paymentStutusID" },
                values: new object[] { 1, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(7122), 1, 1, 1, true, new DateTime(2025, 1, 8, 13, 25, 12, 332, DateTimeKind.Local).AddTicks(7129), 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevelopmentStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlotPayments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectPayments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plots",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentExecutionMethods",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DevelopmentStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LegalStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
