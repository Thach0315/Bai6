using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai6.Migrations
{
    /// <inheritdoc />
    public partial class RenamePriveToPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prive",
                table: "Moves",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Moves",
                newName: "Prive");
        }
    }
}
