using Uzum.Domain.Entities;

namespace Uzum.Infrastructure.Abstractions
{
    public interface ITokenService
    {
        string GenerateAccessToken(User user);
    }
}
