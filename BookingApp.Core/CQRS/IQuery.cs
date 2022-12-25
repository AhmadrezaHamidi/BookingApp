using MediatR;

namespace BookingApp.Core.CQRS
{
    public interface IQuery<out T> : IRequest<T>
    where T : notnull
    {
    }
}