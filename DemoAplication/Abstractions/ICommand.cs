using MediatR;

namespace Uzum.Aplication.Abstractions
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
