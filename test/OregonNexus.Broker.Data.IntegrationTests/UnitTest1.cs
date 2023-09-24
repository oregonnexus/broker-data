using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using OregonNexus.Broker.Data.IntegrationTests.Fixtures;

namespace OregonNexus.Broker.Data.IntegrationTests;

[Collection("BrokerWebDICollection")]
public class UnitTest1
{
    private readonly BrokerWebDIServicesFixture _services;

    public UnitTest1(BrokerWebDIServicesFixture services)
    {
        _services = services;
    }
    
    [Fact]
    public void Test1()
    {
        var dbconext = _services.BrokerDbContextService;

        Assert.NotNull(dbconext);
    }
}