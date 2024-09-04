using MediatR;

namespace Trade.Application.UseCases.Features.Orders.Commands.CancelOrder
{
    public sealed record CancelOrderCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
