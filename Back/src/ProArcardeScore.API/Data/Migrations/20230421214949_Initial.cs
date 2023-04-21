using Microsoft.EntityFrameworkCore.Migrations;

namespace ProArcardeScore.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistrarPontos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataPartida = table.Column<string>(type: "TEXT", nullable: true),
                    Pontuacao = table.Column<int>(type: "INTEGER", nullable: false),
                    NomeJogador = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrarPontos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrarPontos");
        }
    }
}
