using Uzum.Aplication.Abstractions;

namespace Uzum.Aplication.UseCase.Customer.Commands
{
    public class LoginCustomerCommand : ICommand<string>
    {
        public string UserName { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
