using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Uzum.Aplication.Abstractions;

namespace Uzum.Infrastructure.Services
{
    public class CurrentUserService : ICurrentService
    {
        public int UserId { get; set; }

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            var claims = httpContextAccessor.HttpContext!.User.Claims;
            var idClaim = claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
            if (idClaim != null && int.TryParse(idClaim.Value, out var value))
            {
                UserId = value;
            }

        }

    }
}
