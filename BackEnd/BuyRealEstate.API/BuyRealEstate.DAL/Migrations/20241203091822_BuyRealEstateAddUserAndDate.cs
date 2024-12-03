using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyRealEstate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BuyRealEstateAddUserAndDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Professionals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Professionals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Professionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Plots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "Plots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Plots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Plots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Plots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "PlotPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "PlotPayments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "PlotPayments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "PlotPayments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "PlotPayments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "PaymentStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "PaymentStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "PaymentStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "PaymentProjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "PaymentProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "PaymentProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentProjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "PaymentProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "PaymentExecutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "PaymentExecutions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "PaymentExecutions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "PaymentExecutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "PaymentExecutions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "LegalStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "LegalStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "LegalStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "LegalStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "LegalStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Documents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Documents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "DevelopmentStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "DevelopmentStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "DevelopmentStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "DevelopmentStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "DevelopmentStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "CustomerPlots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InsertUser",
                table: "CustomerPlots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "CustomerPlots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CustomerPlots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateUser",
                table: "CustomerPlots",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Plots");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "PlotPayments");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "PlotPayments");

            migrationBuilder.DropColumn(
                name: "State",
                table: "PlotPayments");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "PlotPayments");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "PlotPayments");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "State",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "PaymentProjects");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "PaymentProjects");

            migrationBuilder.DropColumn(
                name: "State",
                table: "PaymentProjects");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "PaymentProjects");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "PaymentProjects");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "PaymentExecutions");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "PaymentExecutions");

            migrationBuilder.DropColumn(
                name: "State",
                table: "PaymentExecutions");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "PaymentExecutions");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "PaymentExecutions");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "LegalStatuses");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "LegalStatuses");

            migrationBuilder.DropColumn(
                name: "State",
                table: "LegalStatuses");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "LegalStatuses");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "LegalStatuses");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "DevelopmentStatuses");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "DevelopmentStatuses");

            migrationBuilder.DropColumn(
                name: "State",
                table: "DevelopmentStatuses");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "DevelopmentStatuses");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "DevelopmentStatuses");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "CustomerPlots");

            migrationBuilder.DropColumn(
                name: "InsertUser",
                table: "CustomerPlots");

            migrationBuilder.DropColumn(
                name: "State",
                table: "CustomerPlots");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CustomerPlots");

            migrationBuilder.DropColumn(
                name: "UpdateUser",
                table: "CustomerPlots");
        }
    }
}
