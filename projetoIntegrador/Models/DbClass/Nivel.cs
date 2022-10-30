using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_NIVEIS")]
    public class Nivel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDNIV_NIV { get; set; }

        [StringLength(200)]
        public string DESNIV_NIV { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DTCAD { get; set; }

        public bool ATIVO_NIVEL { get; set; }
    }
}
