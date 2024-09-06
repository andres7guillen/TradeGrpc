using AutoMapper;
using Grpc.Core;
using MediatR;
using Trade.Application.UseCases.Features.Orders.Queries.GetAllOrder;
using Trade.Services.gRPC.Protos;

namespace Trade.Services.gRPC.Services
{
    public class OrderService : Order.OrderBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrderService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public override async Task<GetAllOrderResponse> GetAllOrder(GetAllOrderRequest request, ServerCallContext context)
        {
            var orderList = await _mediator.Send(new GetAllOrderQuery());
            var response = new GetAllOrderResponse();
            var serverResponse = new ServerResponse();

            if (orderList.Any())
            {
                serverResponse.IsSuccess = true;
                serverResponse.Message = "Success";

                response.Data.AddRange(_mapper.Map<IEnumerable<OrderResponse>>(orderList));
            }
            else 
            {
                serverResponse.Message = "No data";
            }
            response.ServerResponse = serverResponse;
            return response;
        }

    }
}
