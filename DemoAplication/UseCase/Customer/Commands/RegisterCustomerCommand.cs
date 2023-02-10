using MediatR;
using Uzum.Aplication.Abstractions;

namespace Uzum.Aplication.UseCase.Customer.Commands
{
    public class RegisterCustomerCommand : ICommand<Unit>
    {
        public string FullName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;



    }
}
