using MediatR;

namespace Uzum.Aplication.Abstractions
{
    public interface ICommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : ICommand<TResponse>
    {
    }
}
