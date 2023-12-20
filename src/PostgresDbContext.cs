using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OregonNexus.Broker.Data;

public class PostgresDbContext : BrokerDbContext
{
    public PostgresDbContext(IConfiguration configuration)
        : base(configuration)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("PostgreSqlConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        var namespaces = new[] { "OregonNexus.Broker.Data.Configurations", "OregonNexus.Broker.Data.Configurations.PostgreSql" };
        ApplyConfiguration(modelBuilder, namespaces);
    }
}