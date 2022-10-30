using projetoIntegrador.Models;

namespace projetoIntegrador.Services.Authentication
{
    public interface ICredential
    {
        Credential GetCredential(Credential credentil);

        bool ValidateCredential(Credential credential);
    }
}
