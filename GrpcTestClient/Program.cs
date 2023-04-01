using Grpc.Net.Client;
using GrpcTestClient;
using System.Diagnostics;

using var channel = GrpcChannel.ForAddress("https://localhost:7139");
var client = new OrderProcessing.OrderProcessingClient(channel);

for (var i = 0; i < 10; i++)
{
    var watch = Stopwatch.StartNew();

    var response = await client.GetOrdersAsync(new GetOrdersRequest());

    watch.Stop();
    Console.WriteLine("Received orders from server:");
    foreach (var order in response.Orders)
    {
        Console.WriteLine(order);
    }
    Console.WriteLine($"Total time: {watch.ElapsedMilliseconds}");
    Task.Delay(1000).Wait();
}

Console.ReadKey();