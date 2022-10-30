using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Models
{
    public class AccountViewModel
    {
        [Required(ErrorMessage = "Campo é obrigatório!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório!")]
        [Display(Name = "Carteira")]
        public int IdCarteira { get; set; }

        public string Url { get; set; }
    }
}
