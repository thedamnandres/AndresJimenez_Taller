using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndresJimenez_Taller.Migrations
{
    /// <inheritdoc />
    public partial class columnanombreestadio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nombre",
                table: "Estadio",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Estadio");
        }
    }
}
