using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universite.Data.Migrations
{
    /// <inheritdoc />
    public partial class Lien_UENOTE_EtudiantNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EtudiantID",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UEID",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_EtudiantID",
                table: "Notes",
                column: "EtudiantID");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UEID",
                table: "Notes",
                column: "UEID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Etudiant_EtudiantID",
                table: "Notes",
                column: "EtudiantID",
                principalTable: "Etudiant",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_UE_UEID",
                table: "Notes",
                column: "UEID",
                principalTable: "UE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Etudiant_EtudiantID",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_UE_UEID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_EtudiantID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UEID",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "EtudiantID",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UEID",
                table: "Notes");
        }
    }
}
