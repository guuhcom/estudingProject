using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_CONTA")]
    public class Conta
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDCON_CON { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [ForeignKey("TipoConta")]
        public int IDTIP_CON { get; set; }

        public int NUM_CON { get; set; }

        public int NUMAG_CON { get; set; }

        public long VALSAL_CON { get; set; }

        public string SENHA_CON { get; set; }
        public DateTime DTINI_CON { get; set; }
        public DateTime DTMOD_CON { get; set; }
        public DateTime DTFIM_CON { get; set; }
        public bool STATUS_CON { get; set; }

        public virtual TipoConta TipoConta { get; set; }
    }
}