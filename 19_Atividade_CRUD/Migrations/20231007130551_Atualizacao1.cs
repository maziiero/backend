using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _19_Atividade_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roupass_Categorias_CategoriaId",
                table: "Roupass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roupass",
                table: "Roupass");

            migrationBuilder.RenameTable(
                name: "Roupass",
                newName: "Roupas");

            migrationBuilder.RenameIndex(
                name: "IX_Roupass_CategoriaId",
                table: "Roupas",
                newName: "IX_Roupas_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roupas",
                table: "Roupas",
                column: "RoupaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roupas_Categorias_CategoriaId",
                table: "Roupas",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roupas_Categorias_CategoriaId",
                table: "Roupas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roupas",
                table: "Roupas");

            migrationBuilder.RenameTable(
                name: "Roupas",
                newName: "Roupass");

            migrationBuilder.RenameIndex(
                name: "IX_Roupas_CategoriaId",
                table: "Roupass",
                newName: "IX_Roupass_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roupass",
                table: "Roupass",
                column: "RoupaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roupass_Categorias_CategoriaId",
                table: "Roupass",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
