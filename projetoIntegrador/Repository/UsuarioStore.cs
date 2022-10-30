using Microsoft.EntityFrameworkCore;
using projetoIntegrador.Context;
using projetoIntegrador.Models.DbClass;
using projetoIntegrador.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace projetoIntegrador.Repository
{
    public class UsuarioStore : IUsuario
    {
        private readonly AppDbContext _context;

        public UsuarioStore(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Usuario> Usuarios => _context.Usuarios.Include(u => u.Nivel);

        public Usuario GetUsuarioBayLogin(string loginUario) =>
            _context.Usuarios.Include(u => u.Nivel).FirstOrDefault(u => u.LOGIN_USU == loginUario.ToLower());

        public Usuario GetUsuarioById(int id) =>
            _context.Usuarios.Include(u => u.Nivel).FirstOrDefault(u => u.IDNIV_USU == id);

    }
}
