using Microsoft.EntityFrameworkCore;
using projetoIntegrador.Context;
using projetoIntegrador.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Services.SectionService
{
    public class LogUsuarioStore : ILogUsuario
    {
        private readonly AppDbContext _context;

        public LogUsuarioStore(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<LogUsu> logsUsu => _context.LogsUsu.Include(l => l.Section);

        public LogUsu GetLogById(int id) => _context.LogsUsu.Include(l => l.Section).FirstOrDefault(l => l.IDLOG_LOGUSU == id);

        public void InsertLog(int idSection, List<string> acttions)
        {
            LogUsu log = new LogUsu
            {
                IDSEC_LOGUSU = idSection,
                DESCLOG_LOGUSU = String.Join(";", acttions)
            };
            _context.LogsUsu.Add(log);
            _context.SaveChanges();
        }

    }
}
