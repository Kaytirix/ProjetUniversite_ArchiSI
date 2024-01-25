using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universite.Data.Migrations
{
    /// <inheritdoc />
    public partial class Ajout_Etudiant_Formation_Note_Enseignant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Etudiant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Etudiant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormationSuivieID",
                table: "Etudiant",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Enseignants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enseignants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Formation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intitule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnneeDiplome = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valeur = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intitule = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UE", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etudiant_FormationSuivieID",
                table: "Etudiant",
                column: "FormationSuivieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Etudiant_Formation_FormationSuivieID",
                table: "Etudiant",
                column: "FormationSuivieID",
                principalTable: "Formation",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etudiant_Formation_FormationSuivieID",
                table: "Etudiant");

            migrationBuilder.DropTable(
                name: "Enseignants");

            migrationBuilder.DropTable(
                name: "Formation");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "UE");

            migrationBuilder.DropIndex(
                name: "IX_Etudiant_FormationSuivieID",
                table: "Etudiant");

            migrationBuilder.DropColumn(
                name: "FormationSuivieID",
                table: "Etudiant");

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Etudiant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Etudiant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
