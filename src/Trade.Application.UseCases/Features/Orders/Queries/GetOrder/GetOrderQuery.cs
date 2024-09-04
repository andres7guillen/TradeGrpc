using MediatR;

namespace Trade.Application.UseCases.Features.Orders.Queries.GetOrder
{
    public sealed record GetOrderQuery : IRequest<GetOrderResponseDTO>
    {
        public Guid Id { get; set; }
    }
}
