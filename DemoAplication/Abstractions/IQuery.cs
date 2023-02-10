using MediatR;

namespace Uzum.Aplication.Abstractions
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
