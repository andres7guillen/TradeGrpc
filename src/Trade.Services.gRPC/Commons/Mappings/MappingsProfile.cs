using AutoMapper;
using Trade.Application.UseCases.Features.Orders.Queries.GetAllOrder;
using Trade.Services.gRPC.Protos;

namespace Trade.Services.gRPC.Commons.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<IEnumerable<GetAllOrderResponseDTO>, IEnumerable<OrderResponse>>().ReverseMap();
        }
    }
}
