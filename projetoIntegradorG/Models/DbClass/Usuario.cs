using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoIntegrador.Models.DbClass
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int IDUSU_USU { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [ForeignKey("Nivel")]
        public int IDNIV_USU { get; set; }

        [StringLength(300)]
        public string NOME_USU { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(200)]
        public string LOGIN_USU { get; set; }

        [Required(ErrorMessage = "O campo é obrigatorio")]
        [StringLength(200)]
        public string SENHA_USU { get; set; }

        [Required(ErrorMessage = "O campo é Obrigatorio")]
        public int MATRICULA_USU { get; set; }

        public bool ATIVO_USU { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DTCAD_USU { get; set; }

        public bool LOGADO_USU { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime HORAINI_USU { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime HORAFIM_USU { get; set; }

        public string RAMAL_USU { get; set; }

        public virtual Nivel Nivel { get; set; }
    }
}
