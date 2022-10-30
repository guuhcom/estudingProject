using Microsoft.EntityFrameworkCore;
using projetoIntegrador.Models.DbClass;


namespace projetoIntegrador.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Nivel> Niveis { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<LogUsu> LogsUsu { get; set; }
        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<Models.DbClass.NivelCarteira> NivelCarteiras { get; set; }
    }
}
