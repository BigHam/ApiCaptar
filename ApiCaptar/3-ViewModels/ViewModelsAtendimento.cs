using apiCaptar._1_Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace apiCaptar._3_ViewModels
{
    public class ViewModelsAtendimento : atendimento
    {

        public int id
        {
            get; set;
        }
        public string data
        {
            get; set;
        }
        public string municipio
        {
            get; set;
        }
        public string tecnico
        {
            get; set;
        }
        public string? demanda
        {
            get; set;
        }
        public string? descricao
        {
            get; set;
        }
        public string hotel
        {
            get; set;
        }
        public string? observacaoHotel
        {
            get; set;
        }
        public string carro
        {
            get; set;
        }
        public string? observacaoCarro
        {
            get; set;
        }
        public string? valorcafe
        {
            get; set;
        }
        public string? valoralmoco
        {
            get; set;
        }
        public string? valorjanta
        {
            get; set;
        }
        public string? valorhotel
        {
            get; set;
        }
        public string atendimentoRealizado
        {
            get; set;
        }
        public string? obsatendimentoRealizado
        {
            get; set;
        }


    }
}
