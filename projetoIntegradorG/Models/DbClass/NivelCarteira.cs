using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_NIVEISCARTEIRA")]
    public class NivelCarteira
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDNIVCART_NIVCART { get; set; }

        [ForeignKey("Nivel")]
        public int IDNIV_NIVCART { get; set; }

        [ForeignKey("Carteira")]
        public int IDCART_NIVCART { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DTCAD_NIVCART { get; set; }

        public bool ATIVO_NIVCART { get; set; }

        public virtual Nivel Nivel { get; set; }
        public virtual Carteira Carteira { get; set; }
    }
}
