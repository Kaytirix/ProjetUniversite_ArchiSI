using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universite.Data.Migrations
{
    /// <inheritdoc />
    public partial class Ajout_FK_UeAttache_table_Formation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormationAttacheID",
                table: "UE",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UE_FormationAttacheID",
                table: "UE",
                column: "FormationAttacheID");

            migrationBuilder.AddForeignKey(
                name: "FK_UE_Formation_FormationAttacheID",
                table: "UE",
                column: "FormationAttacheID",
                principalTable: "Formation",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UE_Formation_FormationAttacheID",
                table: "UE");

            migrationBuilder.DropIndex(
                name: "IX_UE_FormationAttacheID",
                table: "UE");

            migrationBuilder.DropColumn(
                name: "FormationAttacheID",
                table: "UE");
        }
    }
}
