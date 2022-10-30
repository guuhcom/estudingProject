using projetoIntegrador.Context;
using projetoIntegrador.Models.DbClass;
using projetoIntegrador.Repository.Interfaces;
using System.Collections.Generic;

namespace projetoIntegrador.Repository
{
    public class NivelStore : INivel
    {
        private readonly AppDbContext _context;

        public NivelStore(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Nivel> Niveis => _context.Niveis;
    }
}
