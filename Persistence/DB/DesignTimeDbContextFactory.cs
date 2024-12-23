using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.DB
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AsdDbContext>
    {
        public AsdDbContext CreateDbContext(string[] args)
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../AsdWebApi");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(basePath) 
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<AsdDbContext>();
            var connectionString = configuration.GetConnectionString("ASDDB");

            builder.UseSqlServer(connectionString, options =>
            {
                options.MigrationsAssembly(typeof(AsdDbContext).Assembly.GetName().Name);
            });

            return new AsdDbContext(builder.Options);
        }
    }

}
