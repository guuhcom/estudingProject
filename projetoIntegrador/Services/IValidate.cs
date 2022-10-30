namespace projetoIntegrador.Services
{
    public interface IValidate
    {
        bool IsCpf(string value);
        bool IsCnpj(string value);
        bool IsName(string value);
        bool IsPhone(string value);
        bool IsEmail(string value);
        bool IsNumber(string value);
    }
}
