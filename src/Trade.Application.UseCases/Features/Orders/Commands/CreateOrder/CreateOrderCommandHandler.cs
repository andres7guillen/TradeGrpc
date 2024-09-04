using AutoMapper;
using MediatR;
using Trade.Application.Interfaces.Persistance;
using Trade.Domain.Entities;

namespace Trade.Application.UseCases.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);
            await _applicationDbContext.Orders.AddAsync(order, cancellationToken);
            return await _applicationDbContext.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}
