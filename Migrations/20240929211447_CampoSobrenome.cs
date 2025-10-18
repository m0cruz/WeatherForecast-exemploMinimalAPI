using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuloAPI.Migrations
{
    /// <inheritdoc />
    public partial class CampoSobrenome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos");

            migrationBuilder.AddColumn<string>(
                name: "SobrenomeDoContato",
                table: "Contatos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "SobrenomeDoContato",
                table: "Contatos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contat",
                table: "Contatos",
                column: "Id");
        }
    }
}
