using MediatR;
using Microsoft.EntityFrameworkCore;
using Uzum.Aplication.Abstractions;
using Uzum.Aplication.Exceptions;
using Uzum.Aplication.UseCase.Customer.Commands;
using Uzum.Domain.Exceptions;

namespace Uzum.Aplication.UseCase.Customer.Commands
{
    public class RegisterCustomerCommandHandler : ICommandHandler<RegisterCustomerCommand, Unit>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly IHashService _hashService;
        public RegisterCustomerCommandHandler(IAppDbContext appDbContext, IHashService hashService)
        {
            _appDbContext = appDbContext;
            _hashService = hashService;
        }

        public async Task<Unit> Handle(RegisterCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _appDbContext.Customers.FirstOrDefaultAsync(x => x.UserName == request.UserName);
            if (customer != null)
            {
                throw new RegisterException(new EntityNotFoundException(nameof(customer)));
            }

            var customers = new Domain.Entities.Customer()
            {
                FullName = request.FullName,
                UserName = request.UserName,
                Email = request.Email,
                PasswordHash = _hashService.GetHash(request.Password),
                PhoneNumber = request.PhoneNumber,
                Balance = 0
            };

            await _appDbContext.Customers.AddAsync(customers);
            await _appDbContext.SaveChangesAsync();
            return Unit.Value;

        }
    }
}


