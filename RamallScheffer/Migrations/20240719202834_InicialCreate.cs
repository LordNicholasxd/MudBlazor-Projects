using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RamallScheffer.Migrations
{
    /// <inheritdoc />
    public partial class InicialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ramais",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Setor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroRamall = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Funcionarios = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ramais", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ramais",
                columns: new[] { "Id", "Funcionarios", "NumeroRamall", "Setor" },
                values: new object[,]
                {
                    { 1L, "Denyson", "239", "Tecnologia da Informação" },
                    { 2L, "Sato", "244", "Tecnologia da Informação" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ramais");
        }
    }
}
