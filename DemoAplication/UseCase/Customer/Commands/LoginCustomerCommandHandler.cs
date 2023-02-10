using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Uzum.Aplication.Abstractions;
using Uzum.Aplication.Exceptions;
using Uzum.Domain.Exceptions;

namespace Uzum.Aplication.UseCase.Customer.Commands
{
    public class LoginCustomerCommandHandler : ICommandHandler<LoginCustomerCommand, string>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly IHashService _hashService;
        private readonly ITokenService _tokenService;
        public LoginCustomerCommandHandler(IAppDbContext appDbContext, IHashService hashService, ITokenService tokenService)
        {
            _appDbContext = appDbContext;
            _hashService = hashService;
            _tokenService = tokenService;
        }
        public async Task<string> Handle(LoginCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _appDbContext.Customers.FirstOrDefaultAsync(x => x.UserName == request.UserName, cancellationToken);
            if (customer == null)
            {
                throw new LoginException(new EntityNotFoundException(nameof(customer)));
            }
            if (customer.PasswordHash != _hashService.GetHash(request.Password))
            {
                throw new LoginException();
            }
            var claims = new Claim[]
            {
                new (ClaimTypes.NameIdentifier, customer.Id.ToString()),
                new (ClaimTypes.Name, customer.UserName),
                new (ClaimTypes.Role, nameof(Domain.Entities.Customer)),
                new Claim(ClaimTypes.Email, customer.Email),
            };
            return _tokenService.GetAccessToken(claims);
        }
    }
}
