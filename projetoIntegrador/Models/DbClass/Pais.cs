using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_PAIS")]
    public class Pais
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDPAI_PAI { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100)]
        public string NOM_PAI { get; set; }

        [StringLength(4)]
        public string DDI_PAI { get; set; }

    }
}