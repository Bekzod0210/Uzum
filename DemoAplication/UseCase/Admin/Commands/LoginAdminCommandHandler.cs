using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Uzum.Aplication.Abstractions;
using Uzum.Aplication.Exceptions;
using Uzum.Domain.Exceptions;

namespace Uzum.Aplication.UseCase.Admin.Commands
{
    public class LoginAdminCommandHandler : ICommandHandler<LoginAdminCommand, string>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly IHashService _hashService;
        private readonly ITokenService _tokenService;

        public LoginAdminCommandHandler(IAppDbContext appDbContext, IHashService hashService, ITokenService tokenService)
        {
            _appDbContext = appDbContext;
            _hashService = hashService;
            _tokenService = tokenService;
        }

        public async Task<string> Handle(LoginAdminCommand request, CancellationToken cancellationToken)
        {
            var admin = await _appDbContext.Admins.FirstOrDefaultAsync(x => x.UserName == request.UserName, cancellationToken);
            if (admin == null)
            {
                throw new LoginException(new EntityNotFoundException(nameof(admin)));
            }
            if (admin.PasswordHash != _hashService.GetHash(request.Password))
            {
                throw new LoginException();
            }
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, admin.Id.ToString()),
                new (ClaimTypes.Name, request.UserName),
                new (ClaimTypes.Role, nameof(Domain.Entities.Admin)),
                new Claim(ClaimTypes.Email, admin.Email)
            };

            return _tokenService.GetAccessToken(claims);
        }
    }
}
