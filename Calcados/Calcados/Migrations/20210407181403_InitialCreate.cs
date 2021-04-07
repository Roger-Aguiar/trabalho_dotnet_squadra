using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Calcados.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalcadoItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Numeracao = table.Column<int>(nullable: false),
                    Modelo = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Solado = table.Column<string>(nullable: true),
                    Forro = table.Column<string>(nullable: true),
                    Palmilha = table.Column<string>(nullable: true),
                    AlturaCano = table.Column<string>(nullable: true),
                    AlturaSola = table.Column<decimal>(nullable: false),
                    Fechamento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalcadoItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalcadoItems");
        }
    }
}
