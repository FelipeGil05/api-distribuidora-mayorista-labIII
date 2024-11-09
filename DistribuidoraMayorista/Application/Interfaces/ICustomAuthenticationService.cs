using Application.Models.Responses;
using Application.Models.Requests;

namespace Application.Interfaces
{
    public interface ICustomAuthenticationService
    {
        LoginResponses Login(LoginRequest loginRequest);
    }
}
