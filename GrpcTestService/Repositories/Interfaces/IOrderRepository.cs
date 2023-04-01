using GrpcTestService.Models;

namespace GrpcTestService.Repositories.Interfaces;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetOrdersAsync();
}
