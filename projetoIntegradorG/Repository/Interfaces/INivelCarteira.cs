using System.Collections.Generic;

namespace projetoIntegrador.Repository.Interfaces
{
    public interface INivelCarteira
    {
        IEnumerable<NivelCarteira> NivelCarteiras { get; }

        NivelCarteira GetByIdNivel(int idNivel);
    }
}
