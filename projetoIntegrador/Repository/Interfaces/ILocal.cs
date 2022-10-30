using projetoIntegrador.Models.DbClass;
using System.Collections.Generic;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface ILocal
    {
        IEnumerable<Local> Locais { get; }
    }
}
