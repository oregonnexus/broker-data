using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OregonNexus.Broker.Data;

public class MsSqlDbContext : BrokerDbContext
{
    public MsSqlDbContext(IConfiguration configuration) : base(configuration)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {   
        options.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        var namespaces = new[] { "OregonNexus.Broker.Data.Configurations", "OregonNexus.Broker.Data.Configurations.MsSql" };
        ApplyConfiguration(modelBuilder, namespaces);
    }
}
