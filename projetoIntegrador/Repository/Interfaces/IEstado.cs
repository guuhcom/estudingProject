using projetoIntegrador.Models.DbClass;
using System.Collections.Generic;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface IEstado
    {
        IEnumerable<Estado> Esctados { get; }

        Estado GetEstadoByID(int id);
        Estado GetEstadoByName(string nomeEstado);
        Estado GetEstadoByDDD(string DDD);
    }
}
