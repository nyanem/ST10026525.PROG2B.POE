using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10026525.PROG62112.POE.part1.Migrations
{
    /// <inheritdoc />
    public partial class AddClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "claims",
                columns: table => new
                {
                    ClaimsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    claimDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hoursWorked = table.Column<int>(type: "int", nullable: false),
                    hourlyRate = table.Column<int>(type: "int", nullable: false),
                    supportingDocument = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_claims", x => x.ClaimsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "claims");
        }
    }
}
