using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjoutNumEtudiant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroEtudiant",
                table: "Etudiant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroEtudiant",
                table: "Etudiant");
        }
    }
}
