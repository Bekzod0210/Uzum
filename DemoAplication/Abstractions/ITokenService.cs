using System.Security.Claims;

namespace Uzum.Aplication.Abstractions
{
    public interface ITokenService
    {
        string GetAccessToken(Claim[] claims);
    }
}
