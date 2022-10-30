using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using projetoIntegrador.Context;
using projetoIntegrador.Models.DbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Models
{
    public class Credential
    {
        private readonly AppDbContext _context;

        public string CredentialId { get; set; }
        public Section Section { get; set; }

        public Credential(AppDbContext context)
        {
            _context = context;
        }

        public static Credential GetCredential(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<AppDbContext>();

            string credentialId = session.GetString("CredentialId") ?? Guid.NewGuid().ToString();

            session.SetString("CredentialId", credentialId);

            return new Credential(context) { CredentialId = credentialId };
        }
    }
}
