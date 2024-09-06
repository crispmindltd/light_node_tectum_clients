using Microsoft.Extensions.Hosting;
using Tectum.TectumLNodeClient.Requests;

namespace Tectum.TectumLNodeClient.Example;

public class Example : BackgroundService
{
    private readonly ITectumLNodeClient _client;

    public Example(ITectumLNodeClient client)
    {
        _client = client;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("Get transaction from node");
        var request = new GetCoinsTransfersRequest { Rows = 25 };
        try
        {
            var transactions = await _client.GetCoinTransfersAsync(request, stoppingToken);

            if (transactions?.Transactions == null)
            {
                Console.WriteLine("No transactions");
                return;
            }

            foreach (var transaction in transactions.Transactions)
            {
                var date = DateTimeOffset.FromUnixTimeSeconds(transaction.Date).UtcDateTime;
                Console.WriteLine(
                    $"{transaction.Block}\t{date:s}\t{transaction.Amount}\t{transaction.Fee}\t{transaction.Hash}\t{transaction.AddressFrom}\t{transaction.AddressTo}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Get transactions failed: {e}");
        }
    }
}