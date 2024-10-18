using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10026525.PROG62112.POE.part1.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnsToClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "claimDate",
                table: "claims",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "claims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "claims",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "claims");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "claims");

            migrationBuilder.AlterColumn<string>(
                name: "claimDate",
                table: "claims",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
