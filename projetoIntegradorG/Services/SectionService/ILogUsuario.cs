using projetoIntegrador.Models.DbClass;
using System.Collections.Generic;

namespace projetoIntegrador.Services.SectionService
{
    public interface ILogUsuario
    {
        IEnumerable<LogUsu> logsUsu { get; }

        LogUsu GetLogById(int id);

        void InsertLog(int idSection, List<string> acttions);
    }
}
