using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_NBA.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    EquipoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Conferencia = table.Column<string>(type: "TEXT", nullable: false),
                    Imagen = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.EquipoId);
                });

            migrationBuilder.CreateTable(
                name: "Jugador",
                columns: table => new
                {
                    JugadorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Posicion = table.Column<string>(type: "TEXT", nullable: false),
                    PuntosporPartido = table.Column<double>(type: "REAL", nullable: false),
                    AsistenciasporPartido = table.Column<double>(type: "REAL", nullable: false),
                    RebotesporPartido = table.Column<double>(type: "REAL", nullable: false),
                    BloqueosporPartido = table.Column<double>(type: "REAL", nullable: false),
                    RobosporPartido = table.Column<double>(type: "REAL", nullable: false),
                    EquipoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugador", x => x.JugadorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipo");

            migrationBuilder.DropTable(
                name: "Jugador");
        }
    }
}
