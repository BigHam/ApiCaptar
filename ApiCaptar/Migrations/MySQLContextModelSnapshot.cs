﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiCaptar.Configuration;

#nullable disable

namespace apiCaptar.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("apiCaptar.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("cad_usuario");
                });

            modelBuilder.Entity("apiCaptar._1_Domain.Pesquisa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ameaça")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ameaca");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("bairro");

                    b.Property<string>("CidadeAntesDeVirParaOMunicipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cidade_antes_de_vir_para_o_municipio");

                    b.Property<string>("CidadeOndeMorava")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cidade_onde_morava");

                    b.Property<string>("ComQuemTemContato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("com_quem_tem_contato");

                    b.Property<string>("ConsumoDeDrogas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("consumo_de_drogas");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("data");

                    b.Property<string>("Desemprego")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("desemprego");

                    b.Property<string>("DocumentacaoCPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("documentacaoCPF");

                    b.Property<string>("DocumentacaoCertidaoNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("documentacaoCertidaoNascimento");

                    b.Property<string>("DocumentacaoRG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("documentacaoRG");

                    b.Property<string>("DormiaAondeAntesDaRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("dormia_aonde_antes_da_rua");

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("duracao");

                    b.Property<string>("Escolaridade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("escolaridade");

                    b.Property<string>("EstaGravida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("esta_gravida");

                    b.Property<string>("FazTratamentoDeSaude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("faz_tratamento_de_saude");

                    b.Property<string>("FezRegistroNaDelegacia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("fez_registro_na_delegacia");

                    b.Property<string>("FilhosTambemMoramNaRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("filhos_tambem_moram_na_rua");

                    b.Property<string>("FoiDeCarteiraAssinada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("foi_de_carteira_assinada");

                    b.Property<string>("FrequentaAlgumaReligiao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("frequenta_alguma_religiao");

                    b.Property<string>("GostariaDeVoltarAEstudar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("gostaria_de_voltar_a_estudar");

                    b.Property<int>("IdDoUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_do_usuario");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("idade");

                    b.Property<string>("Inicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("inicio");

                    b.Property<string>("JaFrequentouOCaps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ja_frequentou_o_caps");

                    b.Property<string>("JaSofreuViolenciaNasRuas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ja_sofreu_violencia_nas_ruas");

                    b.Property<string>("JaTeveFilhos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ja_teve_filhos");

                    b.Property<string>("JaTrabalhouAntesDeMorarNaRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ja_trabalhou_antes_de_morar_na_rua");

                    b.Property<string>("Justificativa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("justificativa");

                    b.Property<string>("LocalDeNascimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("local_de_nascimento");

                    b.Property<string>("MotivoDeEstarNaRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("motivo_de_estar_na_rua");

                    b.Property<string>("MotivoDoConsumoDeDroga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("motivo_do_consumo_de_droga");

                    b.Property<string>("OQueFazParaGanharDinheiro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("o_que_faz_para_ganhar_dinheiro");

                    b.Property<string>("OQuePrecisaParaSairDasRuas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("o_que_precisa_para_sair_das_ruas");

                    b.Property<string>("OrientacaoSexual")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("orientacao_sexual");

                    b.Property<string>("PorqueEstaCidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("porque_esta_cidade");

                    b.Property<string>("PossuiCadastroUnico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("possui_cadastro_unico");

                    b.Property<string>("PossuiContatoComFamiliaDeOrigem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("possui_contato_com_familia_de_origem");

                    b.Property<string>("Preferencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("preferencia");

                    b.Property<string>("QuaisProblemasDeSaude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("quais_problemas_de_saude");

                    b.Property<string>("QualBeneficio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("qual_beneficio");

                    b.Property<string>("QualIdadeDosFilhos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("qual_idade_dos_filhos");

                    b.Property<string>("QualReligiao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("qual_religiao");

                    b.Property<string>("QualServicoUsou")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("qual_servico_usou");

                    b.Property<string>("QuantoTempoFazContato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("quanto_tempo_faz_contato");

                    b.Property<string>("QuantoTempoNaRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("quanto_tempo_na_rua");

                    b.Property<string>("QuemPraticouAViolencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("quem_praticou_a_violencia");

                    b.Property<string>("RacaOuCor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("raca_ou_cor");

                    b.Property<string>("RecebeAlgumBeneficio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("recebe_algum_beneficio");

                    b.Property<string>("RespeitadoComoPessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("respeitado_como_pessoa");

                    b.Property<string>("SabeLerEscrever")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sabe_ler_e_escrever");

                    b.Property<string>("SeAlimentaQuantasVezesPorDia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("se_alimenta_quantas_vezes_por_dia");

                    b.Property<string>("SeQuisesseSairDaRuaTeriaLugarParaVoltar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("se_quisesse_sair_da_rua_teria_lugar_para_voltar");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sexo");

                    b.Property<string>("SituacaoDeAbrigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("situacao_de_abrigo");

                    b.Property<string>("SituacaoDeRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("situacao_de_rua");

                    b.Property<string>("TemAcessoAAtividadeCultural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tem_acesso_a_atividade_cultural");

                    b.Property<string>("TemAlgumaRendaNaRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tem_alguma_renda_na_rua");

                    b.Property<string>("TemDeficiencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tem_deficiencia");

                    b.Property<string>("TemFilhos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tem_filhos");

                    b.Property<string>("TemProblemaDeSaude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("tem_problema_de_saude");

                    b.Property<string>("Termino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("termino");

                    b.Property<string>("Territorio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("territorio");

                    b.Property<string>("TomaMedicacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("toma_medicacao");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("turno");

                    b.Property<string>("UsouAlgumServicoDoMunicipioNosUltimos12Meses")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("usou_algum_servico_do_municipio_nos_ultimos_12_meses");

                    b.Property<string>("ViveComAFamiliaNaRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("vive_com_a_familia_na_rua");

                    b.Property<string>("VoltariaParaCidadeNatal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("voltaria_para_cidade_natal");

                    b.Property<string>("outrosDocumentos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("outrosDocumentos");

                    b.HasKey("Id");

                    b.HasIndex("IdDoUsuario");

                    b.ToTable("pesquisas");
                });

            modelBuilder.Entity("apiCaptar._1_Domain.Pesquisa", b =>
                {
                    b.HasOne("apiCaptar.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdDoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
