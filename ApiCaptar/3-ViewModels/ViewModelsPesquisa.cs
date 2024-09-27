using apiCaptar._1_Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiCaptar._3_ViewModels
{
    public class ViewModelsPesquisa : pesquisa
    {

        
        public int IdPesquisa
        {
            get; set;
        }

        
        public int Id
        {
            get; set;
        }
        public Usuario usuarioo
        {
            get; set;
        }




       
        public DateTime Data
        {
            get; set;
        }

        
        public string Bairro
        {
            get; set;
        }

        
        public string Territorio
        {
            get; set;
        }

        
        public string Turno
        {
            get; set;
        }

        
        public DateTime Inicio
        {
            get; set;
        }

        
        public DateTime Termino
        {
            get; set;
        }

        
        public string Duracao
        {
            get; set;
        }

        
        public string Justificativa
        {
            get; set;
        }

        
        public string SituacaoDeRua
        {
            get; set;
        }

       
        public string Sexo
        {
            get; set;
        }

       
        public string OrientacaoSexual
        {
            get; set;
        }

        
        public int Idade
        {
            get; set;
        }

        
        public string RacaOuCor
        {
            get; set;
        }

        
        public string Documentacao
        {
            get; set;
        }

        
        public string LocalDeNascimento
        {
            get; set;
        }

        
        public string CidadeOndeMorava
        {
            get; set;
        }

       
        public string VoltariaParaCidadeNatal
        {
            get; set;
        }

        
        public string CidadeAntesDeVirParaOMunicipio
        {
            get; set;
        }

       
        public string PorqueEstaCidade
        {
            get; set;
        }

        
        public string MotivoDeEstarNaRua
        {
            get; set;
        }

        
        public string Desemprego
        {
            get; set;
        }

        
        public string Ameaça
        {
            get; set;
        }

        
        public string Preferencia
        {
            get; set;
        }

        
        public string QuantoTempoNaRua
        {
            get; set;
        }

        
        public string DormiaAondeAntesDaRua
        {
            get; set;
        }

       
        public bool TemFilhos
        {
            get; set;
        }

       
        public string FilhosTambemMoramNaRua
        {
            get; set;
        }

        
        public string QualIdadeDosFilhos
        {
            get; set;
        }

        
        public bool PossuiContatoComFamiliaDeOrigem
        {
            get; set;
        }

        
        public string QuantoTempoFazContato
        {
            get; set;
        }

        
        public string ComQuemTemContato
        {
            get; set;
        }

        
        public string SeQuisesseSairDaRuaTeriaLugarParaVoltar
        {
            get; set;
        }

        
        public string SeAlimentaQuantasVezesPorDia
        {
            get; set;
        }

       
        public bool UsouAlgumServicoDoMunicipioNosUltimos12Meses
        {
            get; set;
        }

       
        public string QualServicoUsou
        {
            get; set;
        }

        
        public string JaTrabalhouAntesDeMorarNaRua
        {
            get; set;
        }

        
        public string FoiDeCarteiraAssinada
        {
            get; set;
        }

        
        public string TemAlgumaRendaNaRua
        {
            get; set;
        }

       
        public string OQueFazParaGanharDinheiro
        {
            get; set;
        }

        
        public string PossuiCadastroUnico
        {
            get; set;
        }

        
        public string RecebeAlgumBeneficio
        {
            get; set;
        }

        
        public string QualBeneficio
        {
            get; set;
        }

       
        public bool EstaGravida
        {
            get; set;
        }

       
        public bool JaTeveFilhos
        {
            get; set;
        }

        
        public string TemProblemaDeSaude
        {
            get; set;
        }

        
        public string QuaisProblemasDeSaude
        {
            get; set;
        }

        
        public string FazTratamentoDeSaude
        {
            get; set;
        }

        
        public string TomaMedicacao
        {
            get; set;
        }

        
        public string JaFrequentouOCaps
        {
            get; set;
        }

        
        public string ConsumoDeDrogas
        {
            get; set;
        }

        
        public string MotivoDoConsumoDeDroga
        {
            get; set;
        }

        
        public string SabeLerEscrever
        {
            get; set;
        }

       
        public string Escolaridade
        {
            get; set;
        }

        
        public string GostariaDeVoltarAEstudar
        {
            get; set;
        }

        
        public string JaSofreuViolenciaNasRuas
        {
            get; set;
        }

        
        public string FezRegistroNaDelegacia
        {
            get; set;
        }

        
        public string QuemPraticouAViolencia
        {
            get; set;
        }

        
        public string OQuePrecisaParaSairDasRuas
        {
            get; set;
        }

        
        public string TemAcessoAAtividadeCultural
        {
            get; set;
        }

        
        public bool FrequentaAlgumaReligiao
        {
            get; set;
        }

        
        public string QualReligiao
        {
            get; set;
        }

        
        public string RespeitadoComoPessoa
        {
            get; set;
        }

        
        public bool TemDeficiencia
        {
            get; set;
        }

        
        public bool ViveComAFamiliaNaRua
        {
            get; set;
        }

        
        public string SituacaoDeAbrigo
        {
            get; set;
        }

    }
}
