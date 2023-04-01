using System.Text.Json;

namespace GrpcTestService.Models;

public class Order
{
    private decimal _total;

    public string Id { get; set; } = string.Empty;

    public string Ticker { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal Total 
    {
        get
        {
            return _total;
        }

        set
        {
            _total = Price * Quantity;
        }
    }

    public string ClientId { get; set; } = string.Empty;

    public string ClientName { get;  set; } = string.Empty;

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
