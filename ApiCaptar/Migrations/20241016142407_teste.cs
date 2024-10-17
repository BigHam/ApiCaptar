using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiCaptar.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cad_usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cad_usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pesquisas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    IdDoUsuario = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    territorio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    turno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    termino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    justificativa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    situacao_de_rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orientacao_sexual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raca_ou_cor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    documentacaoRG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    documentacaoCPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    documentacaoCertidaoNascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    outrosDocumentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    local_de_nascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cidade_onde_morava = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    voltaria_para_cidade_natal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cidade_antes_de_vir_para_o_municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    porque_esta_cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    motivo_de_estar_na_rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quanto_tempo_na_rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dormia_aonde_antes_da_rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tem_filhos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filhos_tambem_moram_na_rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qual_idade_dos_filhos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    possui_contato_com_familia_de_origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quanto_tempo_faz_contato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    com_quem_tem_contato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    se_quisesse_sair_da_rua_teria_lugar_para_voltar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    se_alimenta_quantas_vezes_por_dia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usou_algum_servico_do_municipio_nos_ultimos_12_meses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qual_servico_usou = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ja_trabalhou_antes_de_morar_na_rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    foi_de_carteira_assinada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tem_alguma_renda_na_rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    o_que_faz_para_ganhar_dinheiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    possui_cadastro_unico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recebe_algum_beneficio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qual_beneficio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esta_gravida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ja_teve_filhos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tem_problema_de_saude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quais_problemas_de_saude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faz_tratamento_de_saude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    toma_medicacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ja_frequentou_o_caps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    consumo_de_drogas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    motivo_do_consumo_de_droga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sabe_ler_e_escrever = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    escolaridade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gostaria_de_voltar_a_estudar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ja_sofreu_violencia_nas_ruas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fez_registro_na_delegacia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quem_praticou_a_violencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    o_que_precisa_para_sair_das_ruas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tem_acesso_a_atividade_cultural = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frequenta_alguma_religiao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qual_religiao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    respeitado_como_pessoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tem_deficiencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vive_com_a_familia_na_rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    situacao_de_abrigo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pesquisas", x => x.id);
                    table.ForeignKey(
                        name: "FK_pesquisas_cad_usuario_IdDoUsuario",
                        column: x => x.IdDoUsuario,
                        principalTable: "cad_usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pesquisas_IdDoUsuario",
                table: "pesquisas",
                column: "IdDoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pesquisas");

            migrationBuilder.DropTable(
                name: "cad_usuario");
        }
    }
}
