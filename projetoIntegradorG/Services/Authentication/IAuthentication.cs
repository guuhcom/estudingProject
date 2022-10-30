using projetoIntegrador.Models.DbClass;

namespace projetoIntegrador.Services.Authentication
{
    public interface IAuthentication
    {
        bool ValidateUser(Usuario user);

        bool ValidateSection(Usuario user, int idSection);        

        void StatusUsu(Usuario user, bool statusUser);

        bool ValidateAdmin(Usuario user);
        bool ValidateCard(int idCard);
    }
}
