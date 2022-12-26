using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroAPI.Migrations
{
    /// <inheritdoc />
    public partial class removeschemasuperhero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "SuperHeroes",
                schema: "Sensedia",
                newName: "SuperHeroes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sensedia");

            migrationBuilder.RenameTable(
                name: "SuperHeroes",
                newName: "SuperHeroes",
                newSchema: "Sensedia");
        }
    }
}
