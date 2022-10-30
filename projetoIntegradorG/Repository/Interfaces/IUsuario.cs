using projetoIntegrador.Models.DbClass;
using System.Collections.Generic;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface IUsuario
    {
        IEnumerable<Usuario> Usuarios { get; }

        Usuario GetUsuarioById(int id);
        Usuario GetUsuarioByMatricula(int matriculaUsuario);
        Usuario GetUsuarioByName(string nomeUsuario);
        Usuario GetUsuarioBayLogin(string loginUario);

    }
}
