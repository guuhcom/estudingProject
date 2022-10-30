using Microsoft.EntityFrameworkCore;
using projetoIntegrador.Context;
using projetoIntegrador.Models.DbClass;
using projetoIntegrador.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace projetoIntegrador.Repository
{
    public class NivelCarteiraStore : INivelCarteira
    {
        private readonly AppDbContext _context;

        public NivelCarteiraStore(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<NivelCarteira> NivelCarteiras => _context.NivelCarteiras.Include(n => n.Nivel).Include(n => n.Carteira);

        public NivelCarteira GetByIdNivel(int idNivel) =>
            _context.NivelCarteiras.Include(n => n.Nivel).Include(n => n.Carteira).FirstOrDefault(n => n.IDNIV_NIVCART == idNivel);
    }
}
