using FluentAssertions;
using Tectum.TectumLNodeClient.Requests;

namespace Tectum.TectumLNodeClient.Tests;

public class Tests
{
    private string _addressNode = "http://127.0.0.1:8917";
    private TectumLNodeClient _nodeClient;
    
    [SetUp]
    public void Setup()
    {
        var httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(_addressNode);
        
        _nodeClient = new TectumLNodeClient(httpClient);
    }

    [Test]
    public async Task GetCoinBalancesAsync_Success()
    {
        var result = await _nodeClient.GetCoinBalancesAsync(new GetCoinsBalancesRequest
        {
            AddressTet = "0x9d7365b162c02bc3b6df5cc4c0682c5c6621d983"
        });

        result.Should().NotBeNull();
        result!.HasError.Should().BeFalse();
        result.Balances.Count.Should().BeGreaterThan(1);
    }
    
    [Test]
    public async Task GetCoinTransfersAsync_Success()
    {
        var result = await _nodeClient.GetCoinTransfersAsync(new GetCoinsTransfersRequest
        {
            Rows = 25,
            Skip = 1
        });

        result.Should().NotBeNull();
        result!.HasError.Should().BeFalse();
        result.Transactions!.Count.Should().Be(25);
    }
}