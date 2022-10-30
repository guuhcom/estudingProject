using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_ESTADO")]
    public class Estado
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDEST_EST { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100)]
        public string NOM_EST { get; set; }

        [StringLength(4)]
        public string DDD_EST { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [ForeignKey("Pais")]
        public int IDPAI_EST { get; set; }

        public virtual Pais Pais { get; set; }
    }
}