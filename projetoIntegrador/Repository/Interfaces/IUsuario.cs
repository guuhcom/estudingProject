using projetoIntegrador.Models.DbClass;
using System.Collections.Generic;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface IUsuario
    {
        IEnumerable<Usuario> Usuarios { get; }

        Usuario GetUsuarioById(int id);
        Usuario GetUsuarioBayLogin(string loginUario);

    }
}
