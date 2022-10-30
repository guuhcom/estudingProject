using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_CLIENTE")]
    public class Cliente
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDCLI_CLI { get; set; }

        [StringLength(300)]
        public string NOME_CLI { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [ForeignKey("Documento")]
        public int IDDOC_CLI { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [ForeignKey("Conta")]
        public int IDCONT_CLI { get; set; }

        [StringLength(20)]
        public string DESDOC_CLI { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DTNAS_CLI { get; set; }

        [StringLength(200)]
        public string NOMMAE_CLI { get; set; }

        [StringLength(15)]
        public string TEL_CLI { get; set; }

        [StringLength(200)]
        public string EMAIL_CLI { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [ForeignKey("Local")]
        public int IDLOC_CLI { get; set; }

        [StringLength(100)]
        public string COMP_CLI { get; set; }

        public int NUM_CLI { get; set; }

        public bool STATUS_CLI { get; set; }


        public virtual Conta Conta { get; set; }
        public virtual Documento Documento { get; set; }
        public virtual Local Local { get; set; }
    }
}
