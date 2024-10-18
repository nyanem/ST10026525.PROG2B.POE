using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10026525.PROG62112.POE.part1.Migrations
{
    /// <inheritdoc />
    public partial class Claims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LecturerId",
                table: "claims",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LecturerId",
                table: "claims");
        }
    }
}
