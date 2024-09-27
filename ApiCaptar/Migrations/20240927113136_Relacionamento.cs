using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCaptar.Migrations
{
    /// <inheritdoc />
    public partial class Relacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pesquisas_cad_usuario_usuariooId",
                table: "pesquisas");

            migrationBuilder.RenameColumn(
                name: "usuariooId",
                table: "pesquisas",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_pesquisas_usuariooId",
                table: "pesquisas",
                newName: "IX_pesquisas_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_pesquisas_cad_usuario_UsuarioId",
                table: "pesquisas",
                column: "UsuarioId",
                principalTable: "cad_usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pesquisas_cad_usuario_UsuarioId",
                table: "pesquisas");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "pesquisas",
                newName: "usuariooId");

            migrationBuilder.RenameIndex(
                name: "IX_pesquisas_UsuarioId",
                table: "pesquisas",
                newName: "IX_pesquisas_usuariooId");

            migrationBuilder.AddForeignKey(
                name: "FK_pesquisas_cad_usuario_usuariooId",
                table: "pesquisas",
                column: "usuariooId",
                principalTable: "cad_usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
