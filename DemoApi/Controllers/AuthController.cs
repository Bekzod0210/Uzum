using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uzum.Aplication.UseCase.Admin.Commands;
using Uzum.Aplication.UseCase.Customer.Commands;

namespace Uzum.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Admin/Login")]
        public async Task< IActionResult> LoginAsAdmin(LoginAdminCommand loginAdminCommand)
        {
            var response = await _mediator.Send(loginAdminCommand);
            return Ok(response);
        }

        [HttpPost("Customer/Login")]
        public async Task<IActionResult> LoginAsCustmer(LoginCustomerCommand loginCustomerCommand)
        {
            var response = await _mediator.Send(loginCustomerCommand);
            return Ok(response);
        }
        [HttpPost("Customer/Register")]
        public async Task<IActionResult> RegisterAsCustomer(RegisterAdminCommand registerAdminCommand)
        {
            var response = await _mediator.Send(registerAdminCommand);
            return Ok(response);
        }

    }
}
