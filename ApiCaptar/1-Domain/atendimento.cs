using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiCaptar._1_Domain
{

    [Table("controleAtendimento")]
    public class atendimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id
        {
            get; set;
        }

        [Column("data")]
        [StringLength(500)]
        public string data
        {
            get; set;
        }

        [Column("municipio")]
        [StringLength(500)]
        public string municipio
        {
            get; set;
        }

        [Column("tecnico")]
        [StringLength(500)]
        public string tecnico
        {
            get; set;
        }

        [Column("demanda")]
        [StringLength(500)]
        public string demanda
        {
            get; set;
        }
        
        [Column("descricao")]
        [StringLength(500)]
        public string descricao
        {
            get; set;
        }
        
        [Column("hotel")]
        [StringLength(500)]
        public string hotel
        {
            get; set;
        }

        [Column("observacaoHotel")]
        [StringLength(500)]
        public string observacaoHotel
        {
            get; set;
        }

        [Column("carro")]
        [StringLength(500)]
        public string carro
        {
            get; set;
        }

        [Column("observacaoCarro")]
        [StringLength(500)]
        public string observacaoCarro
        {
            get; set;
        }

        [Column("valorcafe")]
        [StringLength(500)]
        public string valorcafe
        {
            get; set;
        }
        [Column("valoralmoco")]
        [StringLength(500)]
        public string valoralmoco
        {
            get; set;
        }
        [Column("valorjanta")]
        [StringLength(500)]
        public string valorjanta
        {
            get; set;
        }
        [Column("valorhotel")]
        [StringLength(500)]
        public string valorhotel
        {
            get; set;
        }
        
        [Column("atendimentoRealizado")]
        public string atendimentoRealizado
        {
            get; set;
        }

        [Column("obsatendimentoRealizado")]
        [StringLength(500)]
        public string obsatendimentoRealizado
        {
            get; set;
        }



    }
}
