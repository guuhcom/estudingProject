using projetoIntegrador.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Services.SectionService
{
    public interface ILogUsuario
    {
        IEnumerable<LogUsu> logsUsu { get; }

        LogUsu GetLogById(int id);

        void InsertLog(int idSection, List<string> acttions);
    }
}
