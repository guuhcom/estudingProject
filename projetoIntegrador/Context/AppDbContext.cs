using Microsoft.EntityFrameworkCore;
using projetoIntegrador.Models.DbClass;

namespace projetoIntegrador.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Nivel> Niveis { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<LogUsu> LogsUsu { get; set; }
        public DbSet<Carteira> Carteiras { get; set; }
        public DbSet<NivelCarteira> NivelCarteiras { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<TipoConta> tipoSContas { get; set; }
    }
}
