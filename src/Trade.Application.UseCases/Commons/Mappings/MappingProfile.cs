using AutoMapper;
using Trade.Application.UseCases.Features.Orders.Commands.CreateOrder;
using Trade.Application.UseCases.Features.Orders.Queries.GetAllOrder;
using Trade.Application.UseCases.Features.Orders.Queries.GetOrder;
using Trade.Domain.Entities;

namespace Trade.Application.UseCases.Commons.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateOrderCommand, Order>().ReverseMap();
            CreateMap<CreateOrderCommand, Order>().ReverseMap();
            CreateMap<GetOrderResponseDTO, Order>().ReverseMap();
            CreateMap<GetAllOrderResponseDTO, Order>().ReverseMap();
        }
    }
}
