using Microsoft.EntityFrameworkCore;
using projetoIntegrador.Context;
using projetoIntegrador.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projetoIntegrador.Services.SectionService
{
    public class SectionStore : ISection
    {
        private readonly AppDbContext _context;

        public SectionStore(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Section> Sections => _context.Sections.Include(s => s.Usuario);

        public Section GetById(int id) => _context.Sections.Include(s => s.Usuario).FirstOrDefault(s => s.IDSEC_SEC == id);

        public Section GetByIdUser(int idUser) => _context.Sections.Include(s => s.Usuario).FirstOrDefault(s => s.IDSUS_SUS == idUser);

        public Section GetByKey(string key) => _context.Sections.Include(s => s.Usuario).FirstOrDefault(s => s.KEYSEC_SEC == key);

        public void InsertSection(Usuario user, string keySection)
        {
            Section section = new Section
            {
                KEYSEC_SEC = keySection,
                IDSUS_SUS = user.IDUSU_USU,
                DTCAD_SEC = DateTime.Now,
                ATIVO_SEC = true
            };

            _context.Sections.Add(section);
            StatusUser(user, true);
        }

        public void StatusSection(string keySection, bool statusSection)
        {
            var sec = _context.Sections.Include(s => s.Usuario).FirstOrDefault(s => s.KEYSEC_SEC == keySection);
            if (sec != null)
            {
                sec.ATIVO_SEC = statusSection;
                _context.Sections.Update(sec);

                StatusUser(sec.Usuario, statusSection);
            }
        }

        private void StatusUser(Usuario user, bool statusUser)
        {
            user.LOGADO_USU = statusUser;
            _context.Usuarios.Update(user);
            _context.SaveChanges();
        }
    }
}
