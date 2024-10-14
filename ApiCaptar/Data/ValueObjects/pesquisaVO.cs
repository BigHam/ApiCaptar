﻿namespace apiCaptar.Data.ValueObjects;

public class pesquisaVO
{
    public int IdPesquisa   { get; set; }
    public int Id   { get; set;}
    public Usuario Usuario  {get; set;}
    public string? Data    {get; set;}
    public string Bairro    {get; set;}
    public string Territorio    {get; set;}
    public string Turno {get; set;}
    public string Inicio  {get; set;}
    public string Termino {get; set;}
    public string? Duracao   {get; set;}
    public string Justificativa {get; set;}
    public string SituacaoDeRua {get; set;}
    public string Sexo  {get; set;}
    public string OrientacaoSexual  {get; set;}
    public string Idade    {get; set;}
    public string RacaOuCor {get; set;}
    public string DocumentacaoRG  {get; set;}
    public string DocumentacaoCPF  {get; set;}
    public string DocumentacaoCertidaoNascimento  {get; set;}
    public string outrosDocumentos  {get; set;}
    public string LocalDeNascimento {get; set;}
    public string CidadeOndeMorava { get; set; }
    public string VoltariaParaCidadeNatal { get; set; }
    public string CidadeAntesDeVirParaOMunicipio { get; set; }
    public string PorqueEstaCidade { get; set; }
    public string MotivoDeEstarNaRua { get; set; }
    public string QuantoTempoNaRua { get; set; }
    public string DormiaAondeAntesDaRua { get; set; }
    public string TemFilhos { get; set; }
    public string? FilhosTambemMoramNaRua { get; set; }
    public string? QualIdadeDosFilhos { get; set; }
    public string PossuiContatoComFamiliaDeOrigem { get; set; }
    public string? QuantoTempoFazContato { get; set; }
    public string? ComQuemTemContato { get; set; }
    public string SeQuisesseSairDaRuaTeriaLugarParaVoltar { get; set; }
    public string SeAlimentaQuantasVezesPorDia { get; set; }
    public string UsouAlgumServicoDoMunicipioNosUltimos12Meses { get; set; }
    public string? QualServicoUsou { get; set; }
    public string JaTrabalhouAntesDeMorarNaRua { get; set; }
    public string? FoiDeCarteiraAssinada { get; set; }
    public string TemAlgumaRendaNaRua { get; set; }
    public string? OQueFazParaGanharDinheiro { get; set; }
    public string PossuiCadastroUnico { get; set; }
    public string RecebeAlgumBeneficio { get; set; }
    public string? QualBeneficio { get; set; }
    public string? EstaGravida { get; set; }
    public string? JaTeveFilhos { get; set; }
    public string TemProblemaDeSaude { get; set; }
    public string? QuaisProblemasDeSaude { get; set; }
    public string? FazTratamentoDeSaude { get; set; }
    public string? TomaMedicacao { get; set; }
    public string JaFrequentouOCaps { get; set; }
    public string ConsumoDeDrogas { get; set; }
    public string MotivoDoConsumoDeDroga { get; set; }
    public string SabeLerEscrever { get; set; }
    public string Escolaridade { get; set; }
    public string GostariaDeVoltarAEstudar { get; set; }
    public string JaSofreuViolenciaNasRuas { get; set; }
    public string FezRegistroNaDelegacia { get; set; }
    public string QuemPraticouAViolencia { get; set; }
    public string OQuePrecisaParaSairDasRuas { get; set; }
    public string TemAcessoAAtividadeCultural { get; set; }
    public string FrequentaAlgumaReligiao { get; set; }
    public string? QualReligiao { get; set; }
    public string RespeitadoComoPessoa { get; set; }
    public string TemDeficiencia { get; set; }
    public string ViveComAFamiliaNaRua { get; set; }
    public string SituacaoDeAbrigo { get; set; }


}
