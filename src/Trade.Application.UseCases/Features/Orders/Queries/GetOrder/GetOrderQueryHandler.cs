using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Trade.Application.Interfaces.Persistance;

namespace Trade.Application.UseCases.Features.Orders.Queries.GetOrder
{
    internal class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, GetOrderResponseDTO>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetOrderResponseDTO> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id.Equals(request.Id), cancellationToken);
            var response = _mapper.Map<GetOrderResponseDTO>(order);
            return response;
        }
    }
}
