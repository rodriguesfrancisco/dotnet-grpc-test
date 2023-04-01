using GrpcTestService.Models;
using GrpcTestService.Repositories.Interfaces;

namespace GrpcTestService.Repositories;

public class OrderRepository : IOrderRepository
{
    public async Task<IEnumerable<Order>> GetOrdersAsync()
    {
        var orders = new List<Order>
        {
            new Order()
            {
                Id = Guid.NewGuid().ToString(),
                Ticker = "ITSA4F",
                Price = 8.22,
                Quantity = 100,
                ClientId = Guid.NewGuid().ToString(),
                ClientName = "I'm a client"
            }
        };

        return await Task.FromResult(orders);
    }
}
