using projetoIntegrador.Context;
using projetoIntegrador.Models.DbClass;
using projetoIntegrador.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace projetoIntegrador.Repository
{
    public class CarteiraStore : ICarteira
    {
        private readonly AppDbContext _context;

        public CarteiraStore(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Carteira> Carteiras => _context.Carteiras;

        public Carteira GetById(int id)
        {
            var reult = _context.Carteiras.Where(s => s.IDCART_CART == id).Join(
                _context.NivelCarteiras,
                c => c.IDCART_CART,
                nc => nc.IDCART_NIVCART,
                (c, nc) => new { });


            return new Carteira();
        }
    }
}
