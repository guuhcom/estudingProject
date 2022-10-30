using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_TIPOCONTA")]
    public class TipoConta
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDTPC_TPC { get; set; }

        [StringLength(200)]
        public string DESC_TPC { get; set; }

        public DateTime DTINI_TPC { get; set; }

        public bool STATUS_TPC { get; set; }
    }
}