using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_DOCUMETO")]
    public class Documento
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDDOC_DOC { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100)]
        public string DESC_DOC { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DTINI_DOC { get; set; }

        public bool STATUS_DOC { get; set; }
    }
}