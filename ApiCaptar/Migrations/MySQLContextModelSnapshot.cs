﻿// <auto-generated />
using System;
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
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("apiCaptar.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("cad_usuario");
                });

            modelBuilder.Entity("apiCaptar._1_Domain.pesquisa", b =>
                {
                    b.Property<int>("IdPesquisa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_pesquisa");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdPesquisa"));

                    b.Property<string>("Ameaça")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ameaca");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("bairro");

                    b.Property<string>("CidadeAntesDeVirParaOMunicipio")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cidade_antes_de_vir_para_o_municipio");

                    b.Property<string>("CidadeOndeMorava")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cidade_onde_morava");

                    b.Property<string>("ComQuemTemContato")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("com_quem_tem_contato");

                    b.Property<string>("ConsumoDeDrogas")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("consumo_de_drogas");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data");

                    b.Property<string>("Desemprego")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("desemprego");

                    b.Property<string>("Documentacao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("documentacao");

                    b.Property<string>("DormiaAondeAntesDaRua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("dormia_aonde_antes_da_rua");

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("duracao");

                    b.Property<string>("Escolaridade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("escolaridade");

                    b.Property<bool>("EstaGravida")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("esta_gravida");

                    b.Property<string>("FazTratamentoDeSaude")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("faz_tratamento_de_saude");

                    b.Property<string>("FezRegistroNaDelegacia")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("fez_registro_na_delegacia");

                    b.Property<string>("FilhosTambemMoramNaRua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("filhos_tambem_moram_na_rua");

                    b.Property<string>("FoiDeCarteiraAssinada")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("foi_de_carteira_assinada");

                    b.Property<bool>("FrequentaAlgumaReligiao")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("frequenta_alguma_religiao");

                    b.Property<string>("GostariaDeVoltarAEstudar")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("gostaria_de_voltar_a_estudar");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id_do_usuario");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("idade");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("inicio");

                    b.Property<string>("JaFrequentouOCaps")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ja_frequentou_o_caps");

                    b.Property<string>("JaSofreuViolenciaNasRuas")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ja_sofreu_violencia_nas_ruas");

                    b.Property<bool>("JaTeveFilhos")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ja_teve_filhos");

                    b.Property<string>("JaTrabalhouAntesDeMorarNaRua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ja_trabalhou_antes_de_morar_na_rua");

                    b.Property<string>("Justificativa")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("justificativa");

                    b.Property<string>("LocalDeNascimento")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("local_de_nascimento");

                    b.Property<string>("MotivoDeEstarNaRua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("motivo_de_estar_na_rua");

                    b.Property<string>("MotivoDoConsumoDeDroga")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("motivo_do_consumo_de_droga");

                    b.Property<string>("OQueFazParaGanharDinheiro")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("o_que_faz_para_ganhar_dinheiro");

                    b.Property<string>("OQuePrecisaParaSairDasRuas")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("o_que_precisa_para_sair_das_ruas");

                    b.Property<string>("OrientacaoSexual")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("orientacao_sexual");

                    b.Property<string>("PorqueEstaCidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("porque_esta_cidade");

                    b.Property<string>("PossuiCadastroUnico")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("possui_cadastro_unico");

                    b.Property<bool>("PossuiContatoComFamiliaDeOrigem")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("possui_contato_com_familia_de_origem");

                    b.Property<string>("Preferencia")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("preferencia");

                    b.Property<string>("QuaisProblemasDeSaude")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("quais_problemas_de_saude");

                    b.Property<string>("QualBeneficio")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("qual_beneficio");

                    b.Property<string>("QualIdadeDosFilhos")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("qual_idade_dos_filhos");

                    b.Property<string>("QualReligiao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("qual_religiao");

                    b.Property<string>("QualServicoUsou")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("qual_servico_usou");

                    b.Property<string>("QuantoTempoFazContato")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("quanto_tempo_faz_contato");

                    b.Property<string>("QuantoTempoNaRua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("quanto_tempo_na_rua");

                    b.Property<string>("QuemPraticouAViolencia")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("quem_praticou_a_violencia");

                    b.Property<string>("RacaOuCor")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("raca_ou_cor");

                    b.Property<string>("RecebeAlgumBeneficio")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("recebe_algum_beneficio");

                    b.Property<string>("RespeitadoComoPessoa")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("respeitado_como_pessoa");

                    b.Property<string>("SabeLerEscrever")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sabe_ler_e_escrever");

                    b.Property<string>("SeAlimentaQuantasVezesPorDia")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("se_alimenta_quantas_vezes_por_dia");

                    b.Property<string>("SeQuisesseSairDaRuaTeriaLugarParaVoltar")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("se_quisesse_sair_da_rua_teria_lugar_para_voltar");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sexo");

                    b.Property<string>("SituacaoDeAbrigo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("situacao_de_abrigo");

                    b.Property<string>("SituacaoDeRua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("situacao_de_rua");

                    b.Property<string>("TemAcessoAAtividadeCultural")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tem_acesso_a_atividade_cultural");

                    b.Property<string>("TemAlgumaRendaNaRua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tem_alguma_renda_na_rua");

                    b.Property<bool>("TemDeficiencia")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("tem_deficiencia");

                    b.Property<bool>("TemFilhos")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("tem_filhos");

                    b.Property<string>("TemProblemaDeSaude")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tem_problema_de_saude");

                    b.Property<DateTime>("Termino")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("termino");

                    b.Property<string>("Territorio")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("territorio");

                    b.Property<string>("TomaMedicacao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("toma_medicacao");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("turno");

                    b.Property<bool>("UsouAlgumServicoDoMunicipioNosUltimos12Meses")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("usou_algum_servico_do_municipio_nos_ultimos_12_meses");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<bool>("ViveComAFamiliaNaRua")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("vive_com_a_familia_na_rua");

                    b.Property<string>("VoltariaParaCidadeNatal")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("voltaria_para_cidade_natal");

                    b.HasKey("IdPesquisa");

                    b.HasIndex("UsuarioId");

                    b.ToTable("pesquisas");
                });

            modelBuilder.Entity("apiCaptar._1_Domain.pesquisa", b =>
                {
                    b.HasOne("apiCaptar.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
