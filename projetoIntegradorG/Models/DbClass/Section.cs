using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_SECTION")]
    public class Section
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDSEC_SEC { get; set; }

        public string KEYSEC_SEC { get; set; }

        [ForeignKey("Usuario")]
        public int IDSUS_SUS { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DTCAD_SEC { get; set; }
        public bool ATIVO_SEC { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}