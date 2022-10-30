using projetoIntegrador.Models.DbClass;
using System.Collections.Generic;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface ICliente
    {
        IEnumerable<Cliente> Clientes { get; }

        Cliente GetUsuarioById(int id);
        Cliente GetClientByName(string nomeUsuario);

    }
}
