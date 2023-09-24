using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OregonNexus.Broker.Domain;
using OregonNexus.Broker.SharedKernel;

namespace OregonNexus.Broker.Data.IntegrationTests.Fixtures;

public static class BrokerDbFixture 
{
    public static UserManager<IdentityUser<Guid>> UserManagerService;

    public static BrokerDbContext BrokerDbContext;

    public static IRepository<User> UserRepository;
    
    public static async Task SeedDbContext()
    {
        await SeedUser();
    }

    private static async Task SeedUser()
    {
        // Create User through user manager
        var identityUser = new IdentityUser<Guid> { UserName = "test@email.com", Email = "test@email.com" }; 
        await UserManagerService.CreateAsync(identityUser);

        // Create user
        var user = new User()
        {
            Id = identityUser.Id,
            FirstName = "Test",
            LastName = "User",
            IsSuperAdmin = true,
            AllEducationOrganizations = PermissionType.None
        };

        await UserRepository.AddAsync(user);
    }

    private static async Task SeedEducationOrganizations()
    {
        
    }
}