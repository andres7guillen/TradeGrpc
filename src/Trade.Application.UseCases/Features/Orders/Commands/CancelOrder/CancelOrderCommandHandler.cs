using MediatR;
using Microsoft.EntityFrameworkCore;
using Trade.Application.Interfaces.Persistance;

namespace Trade.Application.UseCases.Features.Orders.Commands.CancelOrder
{
    internal class CancelOrderCommandHandler : IRequestHandler<CancelOrderCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CancelOrderCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<bool> Handle(CancelOrderCommand request, CancellationToken cancellationToken)
        {
            var order = await _applicationDbContext.Orders.FirstOrDefaultAsync(o => o.Id.Equals(request.Id), cancellationToken);
            if (order is not null)
            {
                _applicationDbContext.Orders.Remove(order);
            }
            return await _applicationDbContext.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}
