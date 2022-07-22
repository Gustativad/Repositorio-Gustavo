using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTeste.Migrations
{
    public partial class WebTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inserir_Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inserir_Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inserir_Pontuação = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogador");
        }
    }
}
