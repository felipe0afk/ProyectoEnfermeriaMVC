using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoEnfermeriaMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Mensaje = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Testimonios",
                columns: new[] { "Id", "Mensaje", "Nombre" },
                values: new object[,]
                {
                    { 1, "Gracias a la información pude cuidar mejor a mi bebé.", "María" },
                    { 2, "El método canguro nos ayudó muchísimo con nuestro hijo prematuro.", "Carlos" },
                    { 3, "Una guía práctica y sencilla que me dio confianza en la lactancia.", "Laura" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonios");
        }
    }
}
