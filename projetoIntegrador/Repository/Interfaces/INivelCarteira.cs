using projetoIntegrador.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface INivelCarteira
    {
        IEnumerable<NivelCarteira> NivelCarteiras { get; }

        NivelCarteira GetByIdNivel(int idNivel);
    }
}
