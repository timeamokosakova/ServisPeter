using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServisPeter.Data.Migrations
{
    public partial class jeden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Databaza",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datump = table.Column<DateTime>(nullable: false),
                    datumo = table.Column<DateTime>(nullable: false),
                    Auto = table.Column<string>(nullable: false),
                    Typ = table.Column<string>(nullable: false),
                    Kod = table.Column<string>(nullable: false),
                    Kilometre = table.Column<double>(nullable: false),
                    SPZ = table.Column<string>(nullable: false),
                    WIN = table.Column<string>(maxLength: 17, nullable: false),
                    Oprava = table.Column<string>(nullable: false),
                    Cena = table.Column<string>(nullable: false),
                    Poznamky = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Databaza", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Databaza");
        }
    }
}
