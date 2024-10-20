using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndresJimenez_Taller.Migrations
{
    public partial class segundamigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Agregar la columna 'IdEquipo' a la tabla 'Jugador'
            migrationBuilder.AddColumn<int>(
                name: "IdEquipo",
                table: "Jugador",
                type: "int",
                nullable: false,
                defaultValue: 0); // Valor predeterminado para evitar conflictos con valores nulos

            // Crear un índice para la nueva columna
            migrationBuilder.CreateIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador",
                column: "IdEquipo");

            // Agregar la clave foránea a la columna 'IdEquipo'
            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipo_IdEquipo",
                table: "Jugador",
                column: "IdEquipo",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Eliminar la clave foránea
            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipo_IdEquipo",
                table: "Jugador");

            // Eliminar el índice de la columna 'IdEquipo'
            migrationBuilder.DropIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador");

            // Eliminar la columna 'IdEquipo'
            migrationBuilder.DropColumn(
                name: "IdEquipo",
                table: "Jugador");
        }
    }
}
