using projetoIntegrador.Models.DbClass;
using System.Collections.Generic;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface ICarteira
    {
        IEnumerable<Carteira> Carteiras { get; }

        Carteira GetById(int id);
    }
}
