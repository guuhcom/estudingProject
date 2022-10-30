using System.ComponentModel.DataAnnotations;

namespace projetoIntegrador.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Campo é obrigatório!")]
        [Display(Name = "Matrícula")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório!")]
        [Display(Name = "Carteira")]
        public int IdCarteira { get; set; }

        public string Url { get; set; }
    }
}
