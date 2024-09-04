using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Trade.Application.Interfaces.Persistance;

namespace Trade.Application.UseCases.Features.Orders.Queries.GetAllOrder
{
    public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQuery, IEnumerable<GetAllOrderResponseDTO>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetAllOrderQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetAllOrderResponseDTO>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            var orders  = _context.Orders.AsQueryable().ToListAsync(cancellationToken);
            return _mapper.Map<IEnumerable<GetAllOrderResponseDTO>>(orders);
        }
    }
}
