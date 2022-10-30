using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_LOGUSU")]
    public class LogUsu
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDLOG_LOGUSU { get; set; }
        [ForeignKey("Section")]
        public int IDSEC_LOGUSU { get; set; }

        public string DESCLOG_LOGUSU { get; set; }

        public virtual Section Section { get; set; }
    }
}
