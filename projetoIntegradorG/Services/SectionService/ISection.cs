using projetoIntegrador.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Services.SectionService
{
    public interface ISection
    {
        IEnumerable<Section> Sections { get; }

        Section GetById(int id);
        Section GetByIdUser(int idUser);
        Section GetByKey(string key);
        void InsertSection(Usuario user, string keySection);
        void StatusSection(string keySection, bool statusSection);
    }
}
