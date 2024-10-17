using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCaptar.Migrations
{
    /// <inheritdoc />
    public partial class jkjk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pesquisas_cad_usuario_IdDoUsuario",
                table: "pesquisas");

            migrationBuilder.DropIndex(
                name: "IX_pesquisas_IdDoUsuario",
                table: "pesquisas");

            migrationBuilder.DropColumn(
                name: "IdDoUsuario",
                table: "pesquisas");

            migrationBuilder.RenameColumn(
                name: "idUsuario",
                table: "pesquisas",
                newName: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_pesquisas_UsuarioId",
                table: "pesquisas",
                column: "UsuarioId");

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

            migrationBuilder.DropIndex(
                name: "IX_pesquisas_UsuarioId",
                table: "pesquisas");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "pesquisas",
                newName: "idUsuario");

            migrationBuilder.AddColumn<int>(
                name: "IdDoUsuario",
                table: "pesquisas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_pesquisas_IdDoUsuario",
                table: "pesquisas",
                column: "IdDoUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_pesquisas_cad_usuario_IdDoUsuario",
                table: "pesquisas",
                column: "IdDoUsuario",
                principalTable: "cad_usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
