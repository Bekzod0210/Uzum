using Uzum.Aplication.Abstractions;

namespace Uzum.Aplication.UseCase.Admin.Commands
{
    public class LoginAdminCommand : ICommand<string>
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
