using projetoIntegrador.Context;
using projetoIntegrador.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Services.Authentication
{
    public class AuthenticationStore : IAuthentication
    {
        private readonly AppDbContext _context;

        public AuthenticationStore(AppDbContext context)
        {
            _context = context;
        }

        public bool ValidateSection(Usuario user, int idSection) =>
            (_context.Sections.Where(s => s.IDSUS_SUS == user.MATRICULA_USU).FirstOrDefault(s => s.IDSEC_SEC == idSection) != null) ? true : false;

        public bool ValidateUser(Usuario user) =>
            (_context.Usuarios.FirstOrDefault(u => u.MATRICULA_USU == user.MATRICULA_USU) != null) ? true : false;

        public void StatusUsu(Usuario user, bool statusUser)
        {
            user.LOGADO_USU = statusUser;
            _context.Usuarios.Update(user);
        }

        public bool ValidateCard(int idCard) =>
           (_context.Carteiras.Where(s => s.IDCART_CART == idCard).Join(
              _context.NivelCarteiras,
              c => c.IDCART_CART,
              nc => nc.IDCART_NIVCART,
              (c, nc) => new Carteira
              {
                  IDCART_CART = c.IDCART_CART,
                  NOMCART_CART = c.NOMCART_CART,
                  DTCAD_CART = c.DTCAD_CART,
                  ATIVO_CART = c.ATIVO_CART
              }
              ).FirstOrDefault() != null) ? true : false;

        public bool ValidateAdmin(Usuario user) =>
            (_context.Usuarios.Where(u => u.IDNIV_USU == 1 && u.MATRICULA_USU == user.MATRICULA_USU).FirstOrDefault() != null) ? true : false;

    }
}
