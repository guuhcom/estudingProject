using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_CARTEIRAS")]
    public class Carteira
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDCART_CART { get; set; }

        [StringLength(200)]
        public string NOMCART_CART { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DTCAD_CART { get; set; }

        public bool ATIVO_CART { get; set; }
    }
}
