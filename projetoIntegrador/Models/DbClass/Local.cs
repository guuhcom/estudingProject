using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_LOCAL")]
    public class Local
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDLOC_LOC { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100)]
        public string RUA_LOC { get; set; }

        public int CEP_LOC { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [ForeignKey("Estado")]
        public int IDEST_LOC { get; set; }

        public virtual Estado Estado { get; set; }
    }
}