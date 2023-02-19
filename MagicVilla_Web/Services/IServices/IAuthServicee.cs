using MagicVilla_Web.Models.DTO;

namespace MagicVilla_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToLogin);
        Task<T> RegisterAsync<T>(RegistrationRequestDTO objToRequest);
    }
}
