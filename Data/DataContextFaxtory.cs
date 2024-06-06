using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace gs_net.Data
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            // Verifica se está no modo design-time
            if (args != null && args.Length > 0 && args[0].Equals("designTimeDbContext", StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DataContext>();
            var connectionString = configuration.GetConnectionString("OracleConnection");

            builder.UseOracle(connectionString);

            return new DataContext(builder.Options);
        }
    }
}