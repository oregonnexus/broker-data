using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OregonNexus.Broker.Data.IntegrationTests.Services;
using OregonNexus.Broker.Domain;
using OregonNexus.Broker.SharedKernel;

namespace OregonNexus.Broker.Data.IntegrationTests.Fixtures;

public class BrokerWebDIServicesFixture : IDisposable
{
    private ServiceProvider _serviceProvider;

    public BrokerDbContext BrokerDbContextService
    {
        get
        {
            return _serviceProvider.GetService<BrokerDbContext>();
        }
    }

    public UserManager<IdentityUser<Guid>> UserManagerService
    {
        get
        {
            return _serviceProvider.GetService<UserManager<IdentityUser<Guid>>>();
        }
    }

    public ServiceProvider Services
    {
        get
        {
            return _serviceProvider;
        }
    }

    public BrokerWebDIServicesFixture()
    {
        createServices();

        BrokerDbFixture.BrokerDbContext = Services.GetService<BrokerDbContext>();
        BrokerDbFixture.UserRepository = Services.GetService<IRepository<User>>();
        BrokerDbFixture.UserManagerService = Services.GetService<UserManager<IdentityUser<Guid>>>();

        Task.WaitAll(
            PrepareDbContext(),
            BrokerDbFixture.SeedDbContext()
        );
    }

    private void createServices()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        var services = new ServiceCollection();

        services.AddLogging();

        services.AddBrokerDataContext(configuration);

        services.AddScoped<ICurrentUser, CurrentUserService>();
        
        _serviceProvider = services.BuildServiceProvider();
    }

    private async Task PrepareDbContext()
    {   
        BrokerDbContextService.Database.EnsureDeleted();
        BrokerDbContextService.Database.EnsureCreated();
    }

    public void Dispose()
    {
        // clean up the setup code, if required
    }
}