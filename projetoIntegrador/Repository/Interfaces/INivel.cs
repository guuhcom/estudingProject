using projetoIntegrador.Models.DbClass;
using System.Collections.Generic;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface INivel
    {
        IEnumerable<Nivel> Niveis { get; }
    }
}
