using Grpc.Core;
using GrpcTestService.Repositories.Interfaces;

namespace GrpcTestService.Services;

public class OrderService : OrderProcessing.OrderProcessingBase
{
    private readonly ILogger<OrderService> _logger;
    private readonly IOrderRepository _orderRepository;

    public OrderService(ILogger<OrderService> logger, IOrderRepository orderRepository)
    {
        _logger = logger;
        _orderRepository = orderRepository;
    }

    public override async Task<GetOrdersResponse> GetOrders(GetOrdersRequest request, ServerCallContext context)
    {
        var response = new GetOrdersResponse();
        response.Orders.Add(await _orderRepository.GetOrdersAsync());

        return response;
    }
}
