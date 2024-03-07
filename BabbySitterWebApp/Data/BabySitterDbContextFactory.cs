using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BabbySitter.Data
{
    public class BabySitterDbContextFactory : IDesignTimeDbContextFactory<BabySitterDbContext>
    {
        public BabySitterDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory()))) // Adjust the path
                //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
            var builder = new DbContextOptionsBuilder<BabySitterDbContext>();

            // Then, to use an environment variable directly (if not using placeholders in appsettings.json):
            var databaseUsername = Environment.GetEnvironmentVariable("PAPER_DB_USERNAME");
            var databasePassword = Environment.GetEnvironmentVariable("PAPER_DB_PASSWORD");
            var databaseHostname = Environment.GetEnvironmentVariable("PAPER_DB_HOSTNAME");
            var databaseName = Environment.GetEnvironmentVariable("PAPER_DB_NAME");

            // Construct the connection string manually if needed, or use as is if the variables are directly used
            var connectionString = configuration.GetConnectionString("DefaultConnection")
                .Replace("{PAPER_DB_USERNAME}", databaseUsername)
                .Replace("{PAPER_DB_PASSWORD}", databasePassword)
                .Replace("{PAPER_DB_HOSTNAME}", databaseHostname)
                .Replace("{PAPER_DB_NAME}", databaseName);

            // Use SQLite or Npgsql depending on your condition here
            // Example for SQLite, adjust for Npgsql as needed
            builder.UseNpgsql(connectionString);

            return new BabySitterDbContext(builder.Options);
        }
    }
}