using projetoIntegrador.Context;
using projetoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoIntegrador.Services.Authentication
{
    public class CredentialStore : ICredential
    {
        private readonly AppDbContext _context;

        public CredentialStore(AppDbContext context)
        {
            _context = context;
        }
        public Credential GetCredential(Credential credentil)
        {
            throw new NotImplementedException();
        }

        public bool ValidateCredential(Credential credential)
        {
            throw new NotImplementedException();
        }
    }
}
