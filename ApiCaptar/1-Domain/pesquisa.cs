using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiCaptar._1_Domain;

[Table("pesquisas")]
public class Pesquisa
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_do_usuario")]
    public int IdDoUsuario { get; set; }  // Chave estrangeira

    [ForeignKey("IdDoUsuario")]  // Define a chave estrangeira para a relação com Usuario
    public Usuario Usuario { get; set; }

    [Column("data")]
    public string? Data { get; set; }

    [Column("bairro")]
    public string Bairro { get; set; }

    [Column("territorio")]
    public string Territorio { get; set; }

    [Column("turno")]
    public string Turno { get; set; }

    [Column("inicio")]
    public string Inicio { get; set; }

    [Column("termino")]
    public string Termino { get; set; }

    [Column("duracao")]
    public string? Duracao { get; set; }

    [Column("justificativa")]
    public string Justificativa { get; set; }

    [Column("situacao_de_rua")]
    public string SituacaoDeRua { get; set; }

    [Column("sexo")]
    public string Sexo { get; set; }

    [Column("orientacao_sexual")]
    public string OrientacaoSexual { get; set; }

    [Column("idade")]
    public string Idade { get; set; }

    [Column("raca_ou_cor")]
    public string RacaOuCor { get; set; }

    [Column("documentacaoRG")]
    public string DocumentacaoRG { get; set; }

    [Column("documentacaoCPF")]
    public string DocumentacaoCPF
    {
        get; set;
    }

    [Column("documentacaoCertidaoNascimento")]
    public string DocumentacaoCertidaoNascimento
    {
        get; set;
    }
    
    [Column("outrosDocumentos")]
    public string outrosDocumentos
    {
        get; set;
    }

    [Column("local_de_nascimento")]
    public string LocalDeNascimento { get; set; }

    [Column("cidade_onde_morava")]
    public string CidadeOndeMorava { get; set; }

    [Column("voltaria_para_cidade_natal")]
    public string VoltariaParaCidadeNatal { get; set; }

    [Column("cidade_antes_de_vir_para_o_municipio")]
    public string CidadeAntesDeVirParaOMunicipio { get; set; }

    [Column("porque_esta_cidade")]
    public string PorqueEstaCidade { get; set; }

    [Column("motivo_de_estar_na_rua")]
    public string MotivoDeEstarNaRua { get; set; }


    [Column("quanto_tempo_na_rua")]
    public string QuantoTempoNaRua { get; set; }

    [Column("dormia_aonde_antes_da_rua")]
    public string DormiaAondeAntesDaRua { get; set; }

    [Column("tem_filhos")]
    public string TemFilhos { get; set; }

    [Column("filhos_tambem_moram_na_rua")]
    public string? FilhosTambemMoramNaRua { get; set; }

    [Column("qual_idade_dos_filhos")]
    public string? QualIdadeDosFilhos { get; set; }

    [Column("possui_contato_com_familia_de_origem")]
    public string PossuiContatoComFamiliaDeOrigem { get; set; }

    [Column("quanto_tempo_faz_contato")]
    public string? QuantoTempoFazContato { get; set; }

    [Column("com_quem_tem_contato")]
    public string? ComQuemTemContato { get; set; }

    [Column("se_quisesse_sair_da_rua_teria_lugar_para_voltar")]
    public string SeQuisesseSairDaRuaTeriaLugarParaVoltar { get; set; }

    [Column("se_alimenta_quantas_vezes_por_dia")]
    public string SeAlimentaQuantasVezesPorDia { get; set; }

    [Column("usou_algum_servico_do_municipio_nos_ultimos_12_meses")]
    public string UsouAlgumServicoDoMunicipioNosUltimos12Meses { get; set; }

    [Column("qual_servico_usou")]
    public string? QualServicoUsou { get; set; }

    [Column("ja_trabalhou_antes_de_morar_na_rua")]
    public string JaTrabalhouAntesDeMorarNaRua { get; set; }

    [Column("foi_de_carteira_assinada")]
    public string? FoiDeCarteiraAssinada { get; set; }

    [Column("tem_alguma_renda_na_rua")]
    public string TemAlgumaRendaNaRua { get; set; }

    [Column("o_que_faz_para_ganhar_dinheiro")]
    public string? OQueFazParaGanharDinheiro { get; set; }

    [Column("possui_cadastro_unico")]
    public string PossuiCadastroUnico { get; set; }

    [Column("recebe_algum_beneficio")]
    public string RecebeAlgumBeneficio { get; set; }

    [Column("qual_beneficio")]
    public string? QualBeneficio { get; set; }

    [Column("esta_gravida")]
    public string? EstaGravida { get; set; }

    [Column("ja_teve_filhos")]
    public string? JaTeveFilhos { get; set; }

    [Column("tem_problema_de_saude")]
    public string TemProblemaDeSaude { get; set; }

    [Column("quais_problemas_de_saude")]
    public string? QuaisProblemasDeSaude { get; set; }

    [Column("faz_tratamento_de_saude")]
    public string? FazTratamentoDeSaude { get; set; }

    [Column("toma_medicacao")]
    public string? TomaMedicacao { get; set; }

    [Column("ja_frequentou_o_caps")]
    public string JaFrequentouOCaps { get; set; }

    [Column("consumo_de_drogas")]
    public string ConsumoDeDrogas { get; set; }

    [Column("motivo_do_consumo_de_droga")]
    public string MotivoDoConsumoDeDroga { get; set; }

    [Column("sabe_ler_e_escrever")]
    public string SabeLerEscrever { get; set; }

    [Column("escolaridade")]
    public string Escolaridade { get; set; }

    [Column("gostaria_de_voltar_a_estudar")]
    public string GostariaDeVoltarAEstudar { get; set; }

    [Column("ja_sofreu_violencia_nas_ruas")]
    public string JaSofreuViolenciaNasRuas { get; set; }

    [Column("fez_registro_na_delegacia")]
    public string FezRegistroNaDelegacia { get; set; }

    [Column("quem_praticou_a_violencia")]
    public string QuemPraticouAViolencia { get; set; }

    [Column("o_que_precisa_para_sair_das_ruas")]
    public string OQuePrecisaParaSairDasRuas { get; set; }

    [Column("tem_acesso_a_atividade_cultural")]
    public string TemAcessoAAtividadeCultural { get; set; }

    [Column("frequenta_alguma_religiao")]
    public string FrequentaAlgumaReligiao { get; set; }

    [Column("qual_religiao")]
    public string QualReligiao { get; set; }

    [Column("respeitado_como_pessoa")]
    public string RespeitadoComoPessoa { get; set; }

    [Column("tem_deficiencia")]
    public string TemDeficiencia { get; set; }

    [Column("vive_com_a_familia_na_rua")]
    public string ViveComAFamiliaNaRua { get; set; }

    [Column("situacao_de_abrigo")]
    public string SituacaoDeAbrigo { get; set; }
}
