using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroAPI.Migrations
{
    /// <inheritdoc />
    public partial class alterschemasuperheroes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sensedia");

            migrationBuilder.RenameTable(
                name: "SuperHeroes",
                newName: "SuperHeroes",
                newSchema: "Sensedia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "SuperHeroes",
                schema: "Sensedia",
                newName: "SuperHeroes");
        }
    }
}
